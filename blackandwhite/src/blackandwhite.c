#include <tizen.h>
#include "blackandwhite.h"

#define TEXT_BUF_SIZE 512
static void get_real_content_path(const char *file_name, char *real_path,int path_size_max){
	char *res_path = app_get_resource_path();
	if(res_path)
	{
		snprintf(real_path, path_size_max, "%s%s",res_path,file_name);
		free(res_path);
	}

}

int getImage(EO *image, const char *path){
	char buf[PATH_MAX]={0,};
	get_real_content_path(path, buf, (int)PATH_MAX);
	if(image == NULL || path == NULL){
		return FALSE;
	}
	//evas_object_image_file_set(image,buf,NULL);
	elm_image_file_set(image,buf,NULL);
	return TRUE;
}

void setBG(appdata_s *ad){
	if(ad->colorT==0){
		elm_bg_color_set(ad->bg,255,255,255);
	}else{
		elm_bg_color_set(ad->bg,0,0,0);
	}

}
void getBattery(appdata_s *ad){
	int per = 0;
	bool bCharge = false;

	device_battery_get_percent(&per);
	device_battery_is_charging(&bCharge);

	ad->batteryP = per;
	ad->batteryC = bCharge;

}
void getWifiStatus(appdata_s *ad){
	wifi_connection_state_e wifi_a;
	int wstate = 0;
	if(wifi_initialize()==WIFI_ERROR_NONE){
		if(wifi_get_connection_state(&wifi_a)==WIFI_ERROR_NONE){
			if(wifi_a == WIFI_CONNECTION_STATE_CONNECTED ){
				wstate = 2;
			}else if(wifi_a==WIFI_CONNECTION_STATE_CONFIGURATION){
				wstate = 2;
			}else{
				wstate = 0;
			}
		}else{
		}
	}else{
	}
	ad->b_wifi = wstate;
	wifi_deinitialize();
}
void getNFCStatus(appdata_s *ad){
	bool nstate = false;
	nfc_manager_initialize();
	nstate = nfc_manager_is_activated();
	ad->b_nfc = nstate;
	nfc_manager_deinitialize();
}
bool BTStatusCb(bt_device_info_s *d_info,void *user_data){
	appdata_s *ad = user_data;
	if(d_info==NULL){
		return false;
	}
	if(d_info->is_connected){
		LOGE("BT connected");
		ad->b_r_bt = 1;
	}else{
		LOGE("BT disconnected");
		ad->b_r_bt = 0;
	}
	return true;
}
void getBTStatus(appdata_s *ad){
	bt_adapter_state_e bt_a = 0;
	int bstate = 0;
	if(bt_initialize() == BT_ERROR_NONE){
		if(bt_adapter_get_state(&bt_a) == BT_ERROR_NONE){
			if(bt_a == BT_ADAPTER_ENABLED){
				bt_adapter_foreach_bonded_device(BTStatusCb,ad);
				if(ad->b_r_bt){
					bstate = 2;
				}else{
					bstate = 1;
				}
				LOGE("bstate = %d",bstate);
			}else{
				bstate = 0;
				LOGE("bstate = %d",bstate);
			}
		}
	}
	ad->b_bt = bstate;
	bt_deinitialize();
}
void changeIconColor(int color,void* data){
	appdata_s* ad = data;
	if(color==0){
			if(ad->b_bt ==2){
				getImage(ad->bt_img,"btc_b.png");
			}else if(ad->b_bt==1){
				getImage(ad->bt_img,"bt_b.png");
			}else{
				getImage(ad->bt_img,"bt_w.png");
			}
			if(ad->b_nfc){
				getImage(ad->nfc_img,"nfc_b.png");
			}else{
				getImage(ad->nfc_img,"nfc_w.png");
			}
			if(ad->b_wifi == 2){
					getImage(ad->wifi_img,"wifi_b.png");
			}else if(ad->b_wifi == 1){
				getImage(ad->wifi_img,"wifid_b.png");
			}else{
				getImage(ad->wifi_img,"wifi_w.png");
			}
		}else{
			if(ad->b_bt ==2){
				getImage(ad->bt_img,"btc_w.png");
			}else if(ad->b_bt==1){
				getImage(ad->bt_img,"bt_w.png");
			}else{
				getImage(ad->bt_img,"bt_b.png");
			}
			if(ad->b_nfc){
				getImage(ad->nfc_img,"nfc_w.png");
			}else{
				getImage(ad->nfc_img,"nfc_b.png");
			}
			if(ad->b_wifi == 2){
					getImage(ad->wifi_img,"wifi_w.png");
			}else if(ad->b_wifi == 1){
				getImage(ad->wifi_img,"wifid_w.png");
			}else{
				getImage(ad->wifi_img,"wifi_b.png");
			}
		}
}
static void
update_watch(appdata_s *ad, watch_time_h watch_time, int ambient)
{
	char watch_text[TEXT_BUF_SIZE];
	char battery_text[TEXT_BUF_SIZE];
	char day_text[TEXT_BUF_SIZE];
	char apm_text[TEXT_BUF_SIZE];
	char* colorType=NULL;
	int hour24, minute, second,day_of_week;
	setBG(ad);
	if (watch_time == NULL)
		return;
	getBattery(ad);
	getWifiStatus(ad);
	getNFCStatus(ad);
	getBTStatus(ad);
	changeIconColor(ad->colorT,ad);
	watch_time_get_hour24(watch_time, &hour24);
	watch_time_get_minute(watch_time, &minute);
	watch_time_get_second(watch_time, &second);
	watch_time_get_day_of_week(watch_time, &day_of_week);
	if(ad->colorT==0){
		colorType = "<color=#000000>";
	}else{
		colorType = "<color=#FFFFFF>";
	}
	int hour=0;
	if(hour24%12 == 0){
		hour = 12;
	}else{
		hour = hour24%12;
	}
	if (!ambient) {
		snprintf(watch_text, TEXT_BUF_SIZE, "%s<align=center><font_size=120>%02d:%02d</font_size></align></color>",colorType,hour, minute);
		if(hour24<12){
			snprintf(apm_text, TEXT_BUF_SIZE, "%s<align=center><font_size=50>AM</font_size></align></color>",colorType);
		}else{
			snprintf(apm_text, TEXT_BUF_SIZE, "%s<align=center><font_size=50>PM</font_size></align></color>",colorType);
		}
		if(!ad->batteryC){
			snprintf(battery_text,TEXT_BUF_SIZE, "%s<align=center><font_size=20>REOLAB. <font_size=30>%d</align></color>",colorType,ad->batteryP);
		}else{
			snprintf(battery_text,TEXT_BUF_SIZE, "%s<align=center><font_size=20>REOLAB. <font_size=30>C</align></color>",colorType);
		}
		snprintf(day_text,TEXT_BUF_SIZE, "%s<align=center><font_size=30>%s</align></color>",colorType,DAY_OF_WEEK_STR[day_of_week-1]);
		evas_object_show(ad->bt_img);
		evas_object_show(ad->wifi_img);
		evas_object_show(ad->nfc_img);
		evas_object_show(ad->day_label);
		evas_object_show(ad->ampm_label);
		evas_object_show(ad->blabel);
		evas_object_show(ad->day_label);
	} else {
		snprintf(watch_text, TEXT_BUF_SIZE, "<color=#FFFFFF><align=center><font_size=120>%02d:%02d</font_size></align></color>",hour, minute);
		if(hour24<12){
			snprintf(apm_text, TEXT_BUF_SIZE, "<color=#FFFFFF><align=center><font_size=50>AM</font_size></align></color>");
		}else{
			snprintf(apm_text, TEXT_BUF_SIZE, "<color=#FFFFFF><align=center><font_size=50>PM</font_size></align></color>");
		}
		elm_bg_color_set(ad->bg,0,0,0);
		evas_object_hide(ad->bt_img);
		evas_object_hide(ad->wifi_img);
		evas_object_hide(ad->nfc_img);
		evas_object_hide(ad->day_label);
		evas_object_hide(ad->blabel);
		evas_object_hide(ad->day_label);
	}

	elm_object_text_set(ad->ampm_label,apm_text);
	elm_object_text_set(ad->label, watch_text);
	elm_object_text_set(ad->blabel, battery_text);
	elm_object_text_set(ad->day_label, day_text);

}
static void multidownCB(void *data, Evas *evas, Evas_Object *obj, void *event_info){
	appdata_s* ad = data;
	if(ad->colorT == 1){
		ad->colorT = 0;
	}else{
		ad->colorT = 1;
	}
}

static void
create_base_gui(appdata_s *ad, int width, int height)
{
	int ret;
	ad->colorT =0;
	watch_time_h watch_time = NULL;

	/* Window */
	ret = watch_app_get_elm_win(&ad->win);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "failed to get window. err = %d", ret);
		return;
	}
	ad->bg=elm_bg_add(ad->win);
	evas_object_size_hint_weight_set(ad->bg, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_resize(ad->win, width, height);
	elm_win_resize_object_add(ad->win, ad->bg);
	evas_object_show(ad->bg);
	/* Create Background */
	evas_object_show(ad->win);
	/* Conformant */
	ad->conform = elm_conformant_add(ad->win);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	/* AMPM Label */
	ad->ampm_label = elm_label_add(ad->conform);
	evas_object_resize(ad->ampm_label,width,100);
	evas_object_move(ad->ampm_label, 0, 30);
	evas_object_show(ad->ampm_label);
	/* Label*/
	ad->label = elm_label_add(ad->conform);
	evas_object_resize(ad->label, width, 130);
	evas_object_move(ad->label, 0, 80);
	evas_object_show(ad->label);
	/* Battery Label*/
	ad->blabel = elm_label_add(ad->conform);
	evas_object_resize(ad->blabel, width/2, 80);
	evas_object_move(ad->blabel, width/2, 200);
	evas_object_show(ad->blabel);
	/* Day Label*/
	ad->day_label = elm_label_add(ad->conform);
	evas_object_resize(ad->day_label, width/2, 80);
	evas_object_move(ad->day_label, 0, 200);
	evas_object_show(ad->day_label);

	evas_object_event_callback_add(ad->label,EVAS_CALLBACK_MULTI_DOWN,multidownCB,ad);

	/* status image */
	ad->bt_img = elm_image_add(ad->conform);
	ad->nfc_img = elm_image_add(ad->conform);
	ad->wifi_img = elm_image_add(ad->conform);
	changeIconColor(ad->colorT,ad);
	evas_object_move(ad->bt_img,(width/3)*2,height/2+80);
	evas_object_move(ad->nfc_img,width/2-16,height/2+80);
	evas_object_move(ad->wifi_img,width/3-32,height/2+80);
	elm_image_aspect_fixed_set(ad->bt_img, EINA_FALSE);
	elm_image_aspect_fixed_set(ad->wifi_img, EINA_FALSE);
	elm_image_aspect_fixed_set(ad->nfc_img, EINA_FALSE);

	evas_object_resize(ad->bt_img,32,32);
	evas_object_resize(ad->wifi_img,32,32);
	evas_object_resize(ad->nfc_img,32,32);
	evas_object_show(ad->bt_img);
	evas_object_show(ad->wifi_img);
	evas_object_show(ad->nfc_img);
	ret = watch_time_get_current_time(&watch_time);
	if (ret != APP_ERROR_NONE)
		dlog_print(DLOG_ERROR, LOG_TAG, "failed to get current time. err = %d", ret);

	update_watch(ad, watch_time, 0);
	watch_time_delete(watch_time);

	/* Show window after base gui is set up */

}

static bool
app_create(int width, int height, void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;
	create_base_gui(ad, width, height);


	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */

}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
app_time_tick(watch_time_h watch_time, void *data)
{
	/* Called at each second while your app is visible. Update watch UI. */
	appdata_s *ad = data;
	update_watch(ad, watch_time, 0);
}

static void
app_ambient_tick(watch_time_h watch_time, void *data)
{
	/* Called at each minute while the device is in ambient mode. Update watch UI. */
	appdata_s *ad = data;
	update_watch(ad, watch_time, 1);
}

static void
app_ambient_changed(bool ambient_mode, void *data)
{
	/* Update your watch UI to conform to the ambient mode */
}

static void
watch_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	app_event_get_language(event_info, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
watch_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	watch_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;
	event_callback.time_tick = app_time_tick;
	event_callback.ambient_tick = app_ambient_tick;
	event_callback.ambient_changed = app_ambient_changed;

	watch_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
		APP_EVENT_LANGUAGE_CHANGED, watch_app_lang_changed, &ad);
	watch_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
		APP_EVENT_REGION_FORMAT_CHANGED, watch_app_region_changed, &ad);

	ret = watch_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "watch_app_main() is failed. err = %d", ret);
	}
	return ret;
}

