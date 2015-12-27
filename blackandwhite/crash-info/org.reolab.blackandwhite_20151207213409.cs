S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 24395
Date: 2015-12-07 21:34:09+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x380

Register Information
r0   = 0x00000374, r1   = 0x0000000d
r2   = 0x00000274, r3   = 0x41453194
r4   = 0x00000374, r5   = 0x00000000
r6   = 0x41a93334, r7   = 0x41a84e08
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbecf9c74, sp   = 0xbecf9c28
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     17748 KB
Buffers:     13456 KB
Cached:      94948 KB
VmPeak:      75412 KB
VmSize:      74900 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14656 KB
VmRSS:       14656 KB
VmData:      20640 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20468 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 24395 TID = 24395
24395 24606 24612 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40046000 r-xp /usr/lib/libappcore-efl.so.1.1
40054000 40060000 r-xp /usr/lib/libaul.so.0.1.0
4006a000 4006c000 r-xp /lib/libdl-2.13.so
40075000 40078000 r-xp /usr/lib/libbundle.so.0.1.22
40080000 40082000 r-xp /usr/lib/libdlog.so.0.0.0
4008a000 4009e000 r-xp /lib/libpthread-2.13.so
400a9000 401e3000 r-xp /usr/lib/libelementary.so.1.7.99
401f9000 402c8000 r-xp /usr/lib/libevas.so.1.7.99
402ec000 40303000 r-xp /usr/lib/libecore.so.1.7.99
4031a000 40377000 r-xp /usr/lib/libedje.so.1.7.99
40381000 40451000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40452000 40458000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40460000 40463000 r-xp /usr/lib/libsmack.so.1.0.0
4046b000 40473000 r-xp /lib/libgcc_s-4.6.so.1
40474000 4058f000 r-xp /lib/libc-2.13.so
4059d000 405d9000 r-xp /usr/lib/libsystemd.so.0.4.0
405e2000 405ed000 r-xp /lib/libunwind.so.8.0.1
4061a000 40631000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40639000 40663000 r-xp /usr/lib/libdbus-1.so.3.8.12
4066c000 40671000 r-xp /usr/lib/libxdgmime.so.1.1.0
40679000 4069b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
406a3000 406a6000 r-xp /usr/lib/libproc-stat.so.0.2.86
406ae000 406b4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406bd000 40726000 r-xp /lib/libm-2.13.so
4072f000 40748000 r-xp /usr/lib/libeet.so.1.7.99
40759000 4079a000 r-xp /usr/lib/libeina.so.1.7.99
407a3000 407c5000 r-xp /usr/lib/libecore_evas.so.1.7.99
407ce000 407d3000 r-xp /usr/lib/libecore_file.so.1.7.99
407db000 407ec000 r-xp /usr/lib/libecore_input.so.1.7.99
407f4000 407f8000 r-xp /usr/lib/libvconf.so.0.2.45
40800000 40850000 r-xp /usr/lib/libecore_x.so.1.7.99
40852000 4085b000 r-xp /usr/lib/libedbus.so.1.7.99
40863000 4087d000 r-xp /usr/lib/libecore_con.so.1.7.99
40886000 40899000 r-xp /usr/lib/libfribidi.so.0.3.1
408a1000 408de000 r-xp /usr/lib/libharfbuzz.so.0.940.0
408e7000 4090f000 r-xp /usr/lib/libfontconfig.so.1.8.0
40910000 40966000 r-xp /usr/lib/libfreetype.so.6.11.3
40972000 409c8000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d5000 409db000 r-xp /lib/librt-2.13.so
409e4000 409eb000 r-xp /usr/lib/libembryo.so.1.7.99
409f3000 40a0a000 r-xp /usr/lib/liblua-5.1.so
40a13000 40a19000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a21000 40a22000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2a000 40a50000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a59000 40a5c000 r-xp /lib/libcap.so.2.21
40a64000 40a7c000 r-xp /usr/lib/liblzma.so.5.0.3
40a84000 40b00000 r-xp /usr/lib/libgcrypt.so.20.0.3
40b0c000 40b1c000 r-xp /lib/libresolv-2.13.so
40b20000 40bf3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40bfe000 40c32000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40c3b000 40c50000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40c58000 40ccd000 r-xp /usr/lib/libsqlite3.so.0.8.6
40cd7000 40ced000 r-xp /lib/libz.so.1.2.5
40cf5000 40d18000 r-xp /usr/lib/libjpeg.so.8.0.2
40d30000 40e11000 r-xp /usr/lib/libX11.so.6.3.0
40e1c000 40e21000 r-xp /usr/lib/libecore_fb.so.1.7.99
40e2a000 40e2e000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40e37000 40e3a000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40e42000 40e49000 r-xp /usr/lib/libXcursor.so.1.0.2
40e51000 40e53000 r-xp /usr/lib/libXdamage.so.1.1.0
40e5b000 40e5d000 r-xp /usr/lib/libXcomposite.so.1.0.0
40e65000 40e67000 r-xp /usr/lib/libXgesture.so.7.0.0
40e6f000 40e72000 r-xp /usr/lib/libXfixes.so.3.1.0
40e7a000 40e83000 r-xp /usr/lib/libXi.so.6.1.0
40e8b000 40e8c000 r-xp /usr/lib/libXinerama.so.1.0.0
40e95000 40e9b000 r-xp /usr/lib/libXrandr.so.2.2.0
40ea3000 40ea9000 r-xp /usr/lib/libXrender.so.1.3.0
40eb1000 40eb4000 r-xp /usr/lib/libXtst.so.6.1.0
40ebd000 40ec7000 r-xp /usr/lib/libXext.so.6.4.0
40ed0000 40f14000 r-xp /usr/lib/libcurl.so.4.3.0
40f1d000 40f33000 r-xp /lib/libexpat.so.1.5.2
40f3d000 40f55000 r-xp /usr/lib/libpng12.so.0.50.0
40f5d000 40f79000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f82000 41016000 r-xp /usr/lib/libstdc++.so.6.0.16
4102a000 4102d000 r-xp /lib/libattr.so.1.1.0
41035000 41040000 r-xp /usr/lib/libgpg-error.so.0.15.0
41048000 41049000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
41051000 41056000 r-xp /usr/lib/libffi.so.5.0.10
4105e000 41060000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41069000 41135000 r-xp /usr/lib/libxml2.so.2.7.8
41142000 41144000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
4114d000 4114f000 r-xp /usr/lib/journal/libjournal.so.0.1.0
41157000 4116a000 r-xp /usr/lib/libxcb.so.1.1.0
41174000 4117d000 r-xp /usr/lib/libcares.so.2.1.0
41186000 411b4000 r-xp /usr/lib/libidn.so.11.5.44
411bc000 41209000 r-xp /usr/lib/libssl.so.1.0.0
41215000 413bd000 r-xp /usr/lib/libcrypto.so.1.0.0
413d6000 413d8000 r-xp /usr/lib/libiri.so
413e1000 413e8000 r-xp /lib/libcrypt-2.13.so
41418000 4141a000 r-xp /usr/lib/libXau.so.6.0.0
41427000 4142b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4143b000 41440000 r-xp /usr/lib/libappcore-common.so.1.1
41448000 4144a000 r-xp /usr/lib/libiniparser.so.0
41453000 41455000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
4145d000 4145f000 r-xp /usr/lib/libdri2.so.0.0.0
41467000 4146c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41474000 41476000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4147f000 41485000 r-xp /usr/lib/libappsvc.so.0.1.0
4148d000 414b1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414ba000 41589000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4159f000 415a9000 r-xp /lib/libnss_files-2.13.so
41770000 41774000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41784000 4178b000 r-xp /usr/lib/libappcore-watch.so.1.1
41794000 417a1000 r-xp /usr/lib/libalarm.so.0.0.0
417aa000 418e7000 r-xp /usr/lib/libicui18n.so.51.1
418f7000 418fd000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41905000 4190b000 r-xp /usr/lib/libwidget.so.1.0.0
41914000 4191d000 r-xp /usr/lib/libcom-core.so.0.0.1
41926000 41932000 r-xp /usr/lib/libwidget_service.so.1.0.0
4193a000 41943000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4194c000 41954000 r-xp /usr/lib/libdrm.so.2.4.0
4195c000 41961000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41969000 41970000 r-xp /usr/lib/libtbm.so.1.0.0
41978000 4197b000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
41992000 41ac5000 rw-p [heap]
41ac5000 41ba9000 r-xp /usr/lib/libicuuc.so.51.1
43577000 43d76000 rw-p [stack:24606]
43d76000 43d81000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43e09000 43e20000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44051000 44974000 rw-p [stack:24612]
becda000 becfb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24395)
Call Stack Count: 6
 0: (0x400169dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0x400170d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0x40017360) [/lib/ld-linux.so.3] + 0xa360
 3: (0x4001b5e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0x40021a60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0x404e170c) [/lib/libc.so.6] + 0x6d70c
End of Call Stack

Package Information
Package Name: org.reolab.blackandwhite
Package ID : org.reolab.blackandwhite
Version: 1.0.0
Package Type: rpm
App Name: blackandwhite
App ID: org.reolab.blackandwhite
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 715, caller_id : 0, listener_type : 0
12-07 21:33:29.164+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 0, op_type: 0, category_id: 0, display count: 0
12-07 21:33:29.164+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1548) > Handle this change type in idler.
12-07 21:33:29.164+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1572) > App tray not displayed and edit mode is off.
12-07 21:33:29.164+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1051) > idler for type: 0
12-07 21:33:29.179+0900 I/wnoti-proxy(  715): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-07 21:33:29.179+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1098) > unread_count: 1
12-07 21:33:29.179+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(622) > category_id: 215, application_id: 218, application_name: 카카오톡, time_stamp: 1449491608, content_id: 0, spannable_string_version: 1
12-07 21:33:29.179+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-07 21:33:29.179+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-07 21:33:29.179+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-07 21:33:29.179+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-07 21:33:29.179+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-07 21:33:29.179+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-07 21:33:29.179+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1335) > New noti is here. Add it on panel  215, 카카오톡.
12-07 21:33:29.179+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 215, application_id: 218, type: 1
12-07 21:33:29.184+0900 E/wnoti-service(  871): wnoti-sap-client.c: on_timer(291) > is_exist_alert_list : 0, g_launch_popup_time : 1449491609, g_use_aul_launch : 0
12-07 21:33:29.184+0900 E/wnoti-service(  871): wnoti-sap-client.c: on_timer(293) > >> launching notification popup
12-07 21:33:29.194+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 21:33:29.204+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-07 21:33:29.214+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-07 21:33:29.214+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 21:33:29.214+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 871
12-07 21:33:29.224+0900 W/AUL_AMD (  495): amd_launch.c: __nofork_processing(1138) > __nofork_processing, cmd: 0, pid: 13736
12-07 21:33:29.234+0900 I/APP_CORE(13736): appcore-efl.c: __do_app(429) > [APP 13736] Event: RESET State: PAUSED
12-07 21:33:29.234+0900 I/CAPI_APPFW_APPLICATION(13736): app_main.c: app_appcore_reset(245) > app_appcore_reset
12-07 21:33:29.234+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(13736), cmd(0)
12-07 21:33:29.254+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(267) > fg_app : 1
12-07 21:33:29.254+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-07 21:33:29.254+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-07 21:33:29.254+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-07 21:33:29.254+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-07 21:33:29.259+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4398) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
12-07 21:33:29.259+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 215, application_id: 218, type: 13
12-07 21:33:29.259+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-07 21:33:29.259+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-07 21:33:29.259+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-07 21:33:29.259+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-07 21:33:29.264+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:33:29.274+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 21:33:29.279+0900 I/wnotib  (  715): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-07 21:33:29.284+0900 I/wnotibp (13736): wnotiboard-popup-view.c: wnotiboard_popup_get_block_mode(2328) > Returning false.
12-07 21:33:29.289+0900 E/wnoti-service(  871): wnoti-db-client.c: wnoti_get_alert_categories(712) > !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! application_id : 218, db_id : 2069, is_duplicated : 0
12-07 21:33:29.294+0900 E/wnoti-service(  871): wnoti-db-client.c: wnoti_get_alert_categories(851) > view_type : 1, turn_screen_on : 0, allow_gesture : 1, is_used_popup : 0, feedback : 0
12-07 21:33:29.309+0900 I/wnoti-proxy(13736): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-07 21:33:29.309+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_get_alert_list(805) > application_name: 카카오톡, application_id: 218, category_id: 215, time: 1449491608, launch_app_id: (null), bg_image: /opt/usr/data/wnoti/.app_icon_218.jpg, icon_color: -5730296
12-07 21:33:29.309+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_get_alert_list(812) > noti_type: 1
12-07 21:33:29.309+0900 W/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_convert_alert_data(77) > db_id = 2069, alert_type: 1, app_feedback_type: 0
12-07 21:33:29.309+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_convert_alert_data(364) > Activity fetch finished: -1
12-07 21:33:29.309+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_convert_alert_data(369) > activity action count: 1
12-07 21:33:29.309+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_convert_alert_data(374) > 1 activities retrieved.
12-07 21:33:29.309+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_convert_alert_data(465) > Page fetch finished: -1
12-07 21:33:29.309+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_convert_alert_data(470) > wearable_page_cnt: 1
12-07 21:33:29.309+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_convert_alert_data(475) > 1 pages retrieved.
12-07 21:33:29.309+0900 W/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_get_alert_list(911) > ::DATA:: read alert list : 1, list count : 1
12-07 21:33:29.309+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_app_control(1130) > ::DATA:: CHECK IN APP CONTROL : 1, 0, 1
12-07 21:33:29.309+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_app_control(1142) > ::APP:: CHECK STATE : 2, 0, (null)
12-07 21:33:29.309+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-07 21:33:29.309+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-07 21:33:29.309+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(627) > [2069, 1, 1, 44, 0000]
12-07 21:33:29.309+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(628) > [0, 3, 0, 0]
12-07 21:33:29.309+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(629) > [1, 0, 0, 0]
12-07 21:33:29.309+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 21:33:29.309+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 215, 218
12-07 21:33:29.309+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 21:33:29.319+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1370) > This noti will be removed from panel: 215, 카카오톡.
12-07 21:33:29.319+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 215, application_id: 218, type: 2
12-07 21:33:29.319+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2960) > We don't need to delete the item for second_depth_type: 0.
12-07 21:33:29.324+0900 E/EFL     (  715): elementary<715> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
12-07 21:33:29.324+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 215, application_id: 218, type: 12
12-07 21:33:29.324+0900 I/wnotib  (  715): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-07 21:33:29.324+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 1, num total noti: 1
12-07 21:33:29.324+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-07 21:33:29.324+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-07 21:33:29.324+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-07 21:33:29.324+0900 I/wnotib  (  715): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-07 21:33:29.324+0900 I/wnotib  (  715): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
12-07 21:33:29.324+0900 I/wnotib  (  715): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-07 21:33:29.324+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 1.
12-07 21:33:29.324+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_update(562) > 0x1
12-07 21:33:29.349+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_view_lock(858) > ::UI:: [[[ ===> [simple popup] is LOCK, 0001 ]]]
12-07 21:33:29.349+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4351) > wnotiboard_popup_vi_type: 1
12-07 21:33:29.349+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4357) > (2069, 2069)
12-07 21:33:29.369+0900 I/efl-extension(13736): efl_extension_circle_surface.c: eext_circle_surface_layout_add(1293) > Put the surface[0x46979858]'s widget[0x46769fe0] to layout widget[0x467cf1f0]
12-07 21:33:29.399+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_create_genlist(4285) > (2069, 2069)
12-07 21:33:29.404+0900 I/efl-extension(13736): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
12-07 21:33:29.424+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_create_card_data(3908) > 0x43a90860, 0x43a906e0, 0x43a90860
12-07 21:33:29.424+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-07 21:33:29.424+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-07 21:33:29.424+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-07 21:33:29.424+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-07 21:33:29.429+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 1
12-07 21:33:29.429+0900 W/W_HOME  (  715): noti_broker.c: _handler_noti_indicator_show(478) > 
12-07 21:33:29.434+0900 W/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(331) > body is NULL and no attachments found.
12-07 21:33:29.444+0900 I/wnotibp (13736): wnotiboard-popup-view.c: wnotiboard_popup_draw_simple_popup(3290) > alert_type : 1, is_source_companion: 1
12-07 21:33:29.454+0900 W/wnotibp (13736): wnotiboard-popup-view.c: wnotiboard_popup_draw_simple_popup(3296) > Manually lock the display.
12-07 21:33:29.454+0900 I/efl-extension(13736): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x46979858 = w: 0 h: 0  obj 0x46769fe0 w: 360 h: 360
12-07 21:33:29.459+0900 I/efl-extension(13736): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
12-07 21:33:29.479+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_turn_on_lcd(2801) > ::APP:: alert_type: 1
12-07 21:33:29.479+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_set_smart_relay(1055) > Set the smart relay for 1, 215, 218, 카카오톡
12-07 21:33:29.479+0900 E/wnoti-proxy(13736): wnoti.c: wnoti_set_smart_relay(1149) > smart_relay setting : 0
12-07 21:33:29.479+0900 E/E17     (  365): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x07e0000a)
12-07 21:33:29.544+0900 I/wnotibp (13736): wnotiboard-popup-view.c: wnotiboard_popup_change_win_level(1170) > current : 12, 1, 1, 1
12-07 21:33:29.544+0900 I/APP_CORE(13736): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-07 21:33:29.549+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x07e0000a)
12-07 21:33:29.559+0900 W/APP_CORE(13736): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7e0000a
12-07 21:33:29.569+0900 W/W_HOME  (  715): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
12-07 21:33:29.569+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:33:29.569+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:33:29.574+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:33:29.574+0900 W/W_HOME  (  715): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
12-07 21:33:29.624+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 21:33:29.624+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-07 21:33:29.639+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(1)
12-07 21:33:29.639+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
12-07 21:33:29.639+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:33:29.639+0900 W/W_HOME  (  715): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(1)
12-07 21:33:29.649+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: PAUSE State: PAUSED
12-07 21:33:29.649+0900 I/APP_CORE(  715): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
12-07 21:33:29.649+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
12-07 21:33:29.649+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 21:33:29.664+0900 W/wnotibp (13736): w-notification-board-panel-basic-common.c: _wnotib_basic_panel_expand_basic_gl_group_content_get(2215) > Unhandled part: stack.separator
12-07 21:33:29.664+0900 I/wnotibp (13736): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-07 21:33:29.664+0900 I/wnotibp (13736): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-07 21:33:29.669+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-07 21:33:29.669+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-07 21:33:29.669+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-07 21:33:29.669+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-07 21:33:29.679+0900 W/wnotibp (13736): w-notification-board-action-drawer.c: wnotib_action_drawer_set_item_info(4618) > category_id: 215, application_id: 218, db_id: 2069, clear_all_items: 1
12-07 21:33:29.679+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_w_input_selector(4847) > No need to close w-input-selector.
12-07 21:33:29.679+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:33:29.689+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 21:33:29.689+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_notifiboard_selector(4882) > ret : 0, is_running : 0
12-07 21:33:29.689+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_items_clear(517) > called!!
12-07 21:33:29.689+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_items_clear(2167) > called!!
12-07 21:33:29.689+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-07 21:33:29.694+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-07 21:33:29.694+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-07 21:33:29.699+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-07 21:33:29.699+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-07 21:33:29.699+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(3879) > Create drawer pages for 215, 218
12-07 21:33:29.699+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(4304) > action list lengh is [1]
12-07 21:33:29.699+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-07 21:33:29.699+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-07 21:33:29.704+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-07 21:33:29.704+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-07 21:33:29.704+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-07 21:33:29.704+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-07 21:33:29.709+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2199) > called!!
12-07 21:33:29.709+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-07 21:33:29.709+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-07 21:33:29.709+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-07 21:33:29.714+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-07 21:33:29.714+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-07 21:33:29.714+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-07 21:33:29.714+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-07 21:33:29.724+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-07 21:33:29.724+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-07 21:33:29.724+0900 I/wnotibp (13736): w-notification-board-common.c: wnotib_common_get_category_name(2172) > application_id: 218, default_name: 카카오톡
12-07 21:33:29.724+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-07 21:33:29.724+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-07 21:33:29.729+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-07 21:33:29.729+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-07 21:33:29.729+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(4465) > Number of pages: 4 for 218
12-07 21:33:29.754+0900 E/EFL     (13736): evas_main<13736> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-07 21:33:29.754+0900 E/EFL     (13736): evas_main<13736> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-07 21:33:29.754+0900 E/EFL     (13736): evas_main<13736> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-07 21:33:29.754+0900 I/wnotibp (13736): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-07 21:33:29.764+0900 I/wnotibp (13736): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-07 21:33:29.764+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-07 21:33:29.764+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-07 21:33:29.764+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-07 21:33:29.764+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-07 21:33:29.789+0900 I/efl-extension(13736): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
12-07 21:33:29.789+0900 I/wnotibp (13736): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1036) > fully_obscured: 0 [0x7e0000a 0x7e0000a 0x7e00008 ]
12-07 21:33:29.789+0900 I/APP_CORE(13736): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
12-07 21:33:29.789+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: _item_update_animator_cb(1376) > called
12-07 21:33:29.794+0900 I/efl-extension(13736): efl_extension_rotary_selector.c: _item_update_animator_cb(1385) > item_list(0x1184341496), count(5)
12-07 21:33:29.794+0900 I/MALI    (13736): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43aa7ef8] swap changed from async to sync
12-07 21:33:29.799+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3641) > ::UI:: VI TYPE : 1
12-07 21:33:29.799+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3647) > alert_type : 1, is_source_companion: 1
12-07 21:33:29.799+0900 W/TIZEN_N_RECORDER(13736): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
12-07 21:33:29.799+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1258) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
12-07 21:33:29.804+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1267) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
12-07 21:33:29.804+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1301) > ::APP:: Determined feedback: sound 0, vibration: 0
12-07 21:33:29.804+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1305) > No feedback.
12-07 21:33:30.169+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_show_finished_cb(1009) > ::UI:: popup effect is finished (2069, 46775960)
12-07 21:33:30.169+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_view_unlock(908) > ::UI:: [[[ [simple popup] is UNLOCK , 0000 <=== ]]]
12-07 21:33:30.169+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 1 1
12-07 21:33:30.174+0900 E/wnoti-service(  871): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
12-07 21:33:30.174+0900 E/wnoti-service(  871): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 2
12-07 21:33:30.184+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-07 21:33:30.189+0900 E/wnoti-proxy(13736): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
12-07 21:33:30.189+0900 E/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_get_alert_list(908) > ::DATA:: No categories available.
12-07 21:33:30.189+0900 W/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_get_alert_list(911) > ::DATA:: read alert list : 0, list count : 1
12-07 21:33:31.159+0900 E/wnoti-service(  871): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
12-07 21:33:33.159+0900 E/wnoti-service(  871): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
12-07 21:33:36.459+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1890) > state : (2, 1, 1)
12-07 21:33:36.459+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1903) > simple popup=46775960, view_state=1
12-07 21:33:36.459+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-07 21:33:36.459+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(997) > ::UI:: lock state = 0000
12-07 21:33:36.469+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1963) > device_power_release_lock CPU>>>>>>>
12-07 21:33:36.494+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 21:33:36.494+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-07 21:33:36.509+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 21:33:36.509+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 215, 218
12-07 21:33:36.509+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 21:33:36.509+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1998) > ::INFO:: call lower
12-07 21:33:36.509+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_del_cb(424) > ::UI:: (3, 46775960, 46775960, 0)
12-07 21:33:36.559+0900 W/W_HOME  (  715): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
12-07 21:33:36.559+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:33:36.559+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:33:36.574+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(918) > ::DATA:: remove notification data, 2069
12-07 21:33:36.574+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(948) > ::DATA:: CHECK DATA : 0, 0
12-07 21:33:36.574+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_view_unlock(910) > ::UI:: [[[ [simple popup] is not in lock state , 0000  <===]]]
12-07 21:33:36.574+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 0 0
12-07 21:33:36.574+0900 I/efl-extension(13736): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46785150, elm_genlist, _activated_obj : 0x0, activated : 0
12-07 21:33:36.574+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_w_input_selector(4847) > No need to close w-input-selector.
12-07 21:33:36.579+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:33:36.579+0900 W/W_HOME  (  715): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
12-07 21:33:36.584+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(0)
12-07 21:33:36.584+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
12-07 21:33:36.584+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:33:36.584+0900 W/W_HOME  (  715): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(0)
12-07 21:33:36.584+0900 I/APP_CORE(  715): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
12-07 21:33:36.584+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
12-07 21:33:36.584+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 21:33:36.584+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-07 21:33:36.589+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:33:36.594+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 21:33:36.599+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_notifiboard_selector(4882) > ret : 0, is_running : 0
12-07 21:33:36.599+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 21:33:36.599+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 215, 218
12-07 21:33:36.599+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 21:33:36.619+0900 I/efl-extension(13736): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x46785150, obj: 0x46785150
12-07 21:33:36.619+0900 I/efl-extension(13736): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-07 21:33:36.634+0900 I/efl-extension(13736): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 21:33:36.634+0900 I/efl-extension(13736): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46785150, elm_genlist, func : 0x41841e59
12-07 21:33:36.634+0900 I/efl-extension(13736): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 21:33:36.659+0900 I/MALI    (13736): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43aa7ef8] swap changed from sync to async
12-07 21:33:36.659+0900 I/efl-extension(13736): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
12-07 21:33:36.659+0900 W/APP_CORE(13736): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:7e0000a
12-07 21:33:36.659+0900 I/APP_CORE(13736): appcore-efl.c: __do_app(429) > [APP 13736] Event: PAUSE State: RUNNING
12-07 21:33:36.659+0900 I/CAPI_APPFW_APPLICATION(13736): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-07 21:33:36.679+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(267) > fg_app : 1
12-07 21:33:36.679+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-07 21:33:36.679+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1368) > [0, 0, 44, 0000]
12-07 21:33:36.679+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [1, 0]
12-07 21:33:36.679+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [0, 3, 0, 2, 0]
12-07 21:33:41.684+0900 I/APP_CORE(13736): appcore-efl.c: __do_app(429) > [APP 13736] Event: MEM_FLUSH State: PAUSED
12-07 21:33:49.209+0900 E/PKGMGR_SERVER(24602): pkgmgr-server.c: main(2126) > package manager server start
12-07 21:33:49.409+0900 E/PKGMGR_SERVER(24602): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_296212571], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-07 21:33:49.424+0900 E/PKGMGR  (24600): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-07 21:33:49.429+0900 E/PKGMGR_SERVER(24603): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-07 21:33:49.544+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:33:49.554+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24284
12-07 21:33:49.554+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 21:33:49.559+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 5
12-07 21:33:49.564+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(24284), cmd(4)
12-07 21:33:49.564+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 21:33:49.564+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(884) > app status : 4
12-07 21:33:49.564+0900 W/CAPI_WATCH_APPLICATION(24284): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-07 21:33:49.564+0900 W/WATCH_CORE(24284): appcore-watch.c: __widget_destroy(992) > widget_destory
12-07 21:33:49.564+0900 E/WIDGET_PROVIDER_APP(24284): client.c: client_fini(1175) > Provider is not initialized
12-07 21:33:49.569+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 21:33:49.589+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:33:49.594+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24284
12-07 21:33:49.699+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:33:49.709+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 21:33:49.719+0900 E/PKGMGR_SERVER(24603): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-07 21:33:49.734+0900 E/PKGMGR_SERVER(24602): pkgmgr-server.c: sighandler(445) > child NORMAL exit [24603]
12-07 21:33:49.834+0900 E/AUL_AMD (  495): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-07 21:33:49.834+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(24284), cmd(4)
12-07 21:33:49.839+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 21:33:49.849+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 21:33:49.859+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 21:33:49.859+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 21:33:49.859+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 21:33:49.994+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 21:33:49.994+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 21:33:49.999+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 21:33:49.999+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-07 21:33:49.999+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 21:33:50.024+0900 I/CAPI_WATCH_APPLICATION(24395): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 21:33:50.049+0900 E/TBM     (24395): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 21:33:50.109+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 24284
12-07 21:33:50.144+0900 W/WATCH_CORE(24395): appcore-watch.c: __widget_create(958) > widget_create
12-07 21:33:50.149+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [76046.937500] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29360940:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 21:33:50.149+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[76046.937500] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29360940:4] gbar_fname[]
12-07 21:33:50.169+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 21:33:50.169+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 21:33:50.234+0900 W/WATCH_CORE(24395): appcore-watch.c: __widget_create(976) > widget_create done
12-07 21:33:50.329+0900 I/WATCH_CORE(24395): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-07 21:33:50.329+0900 I/WATCH_CORE(24395): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-07 21:33:50.329+0900 I/WATCH_CORE(24395): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-07 21:33:51.109+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 21:33:51.109+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 21:33:51.129+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:33:51.134+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24395
12-07 21:33:51.134+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 21:33:51.349+0900 I/AUL_PAD (24613): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 21:33:51.564+0900 W/AUL_AMD (  495): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 21:33:51.829+0900 E/PKGMGR_SERVER(24602): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 21:33:51.829+0900 E/PKGMGR_SERVER(24602): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 21:34:03.649+0900 E/PKGMGR  (24709): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-07 21:34:03.814+0900 E/PKGMGR_SERVER(24711): pkgmgr-server.c: main(2126) > package manager server start
12-07 21:34:04.024+0900 E/PKGMGR_SERVER(24711): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_310815324], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_310815324' '-r' 'org.reolab.blackandwhite'], cookie=[gdpXQXOn3sgKzg0T3vxRSilqTBk=], backend_flag=[0]
12-07 21:34:04.024+0900 E/PKGMGR  (24711): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-07 21:34:04.024+0900 E/PKGMGR_SERVER(24711): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-07 21:34:04.039+0900 E/PKGMGR  (24709): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[247090002]
12-07 21:34:04.044+0900 E/PKGMGR_SERVER(24712): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-07 21:34:04.259+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-07 21:34:04.264+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-07 21:34:04.274+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 21:34:04.299+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:34:04.994+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:34:05.019+0900 E/PKGMGR_CERT(24712): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-07 21:34:05.024+0900 E/PKGMGR_CERT(24712): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-07 21:34:05.024+0900 E/PKGMGR_CERT(24712): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-07 21:34:05.024+0900 E/PKGMGR_CERT(24712): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-07 21:34:05.024+0900 E/PKGMGR_CERT(24712): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-07 21:34:05.024+0900 E/PKGMGR_CERT(24712): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-07 21:34:05.024+0900 E/PKGMGR_CERT(24712): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-07 21:34:05.039+0900 E/PKGMGR_CERT(24712): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-07 21:34:05.829+0900 E/PKGMGR_SERVER(24711): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 21:34:06.724+0900 E/rpm-installer(24712): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-07 21:34:07.829+0900 E/PKGMGR_SERVER(24711): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 21:34:09.594+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:34:09.609+0900 E/PKGMGR_SERVER(24711): pkgmgr-server.c: sighandler(445) > child NORMAL exit [24712]
12-07 21:34:09.614+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-07 21:34:09.614+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-07 21:34:09.649+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-07 21:34:09.649+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-07 21:34:09.649+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-07 21:34:09.649+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-07 21:34:09.729+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-07 21:34:09.829+0900 E/PKGMGR_SERVER(24711): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 21:34:09.829+0900 E/PKGMGR_SERVER(24711): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 21:34:09.874+0900 E/APPS    (  715): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-07 21:34:09.879+0900 E/PKGMGR_INFO(  483): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-07 21:34:10.259+0900 W/CRASH_MANAGER(24720): worker.c: worker_job(1199) > 1124395626c61144949164
