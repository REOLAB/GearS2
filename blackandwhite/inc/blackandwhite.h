#ifndef __blackandwhite_H__
#define __blackandwhite_H__

#include <watch_app.h>
#include <watch_app_efl.h>
#include <Elementary.h>
#include <dlog.h>
#include <battery.h>
#include <bluetooth.h>
#include <wifi.h>
#include <nfc.h>
#include <callback.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "blackandwhite"
#define EO Evas_Object

#if !defined(PACKAGE)
#define PACKAGE "org.reolab.blackandwhite"
#endif
typedef struct appdata {
	int width;
	int height;
	int batteryP;
	bool batteryC;
	bool b_nfc;
	int b_wifi;
	int b_bt;
	int b_r_bt;
	int colorT;
	EO *wifi_img;
	EO *nfc_img;
	EO *bt_img;
	EO *win;
	EO *conform;
	EO *ampm_label;
	EO *label;
	EO *blabel;
	EO *day_label;
	EO *bg;
} appdata_s;
const char *DAY_OF_WEEK_STR[7] = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY"};
#endif /* __blackandwhite_H__ */
