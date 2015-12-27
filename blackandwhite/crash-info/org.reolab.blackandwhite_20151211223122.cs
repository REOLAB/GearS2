S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 15677
Date: 2015-12-11 22:31:22+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xea0

Register Information
r0   = 0xbee039d8, r1   = 0xbee045cc
r2   = 0x00000000, r3   = 0xbee03a4c
r4   = 0xbee045cc, r5   = 0xbee042c8
r6   = 0x00000132, r7   = 0xbee039e0
r8   = 0x4030b9c0, r9   = 0x4145fca0
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4155d674, sp   = 0xbee039c8
lr   = 0x4155440b, pc   = 0x00000ea0
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     19940 KB
Buffers:     23264 KB
Cached:     124944 KB
VmPeak:     111464 KB
VmSize:     110952 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16068 KB
VmRSS:       16068 KB
VmData:      54424 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 15677 TID = 15677
15677 15885 15896 

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
41527000 4152b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4153b000 41540000 r-xp /usr/lib/libappcore-common.so.1.1
41548000 4154a000 r-xp /usr/lib/libiniparser.so.0
41553000 41556000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
4155e000 41566000 r-xp /usr/lib/libmdm-common.so.1.0.89
41567000 4156c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41574000 41576000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4157f000 41585000 r-xp /usr/lib/libappsvc.so.0.1.0
4158d000 415b1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415ba000 41689000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4169f000 416a9000 r-xp /lib/libnss_files-2.13.so
41970000 41974000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41984000 4198b000 r-xp /usr/lib/libappcore-watch.so.1.1
41994000 419c4000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
419c5000 419d9000 r-xp /usr/lib/libcapi-network-nfc.so.0.2.3
419e1000 419ee000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.55
419f6000 419fb000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41a03000 41a10000 r-xp /usr/lib/libalarm.so.0.0.0
41a19000 41b56000 r-xp /usr/lib/libicui18n.so.51.1
41b66000 41c4a000 r-xp /usr/lib/libicuuc.so.51.1
41c5f000 41c65000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41c6d000 41c73000 r-xp /usr/lib/libwidget.so.1.0.0
41c7c000 41c81000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41c89000 41cc0000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41cc9000 41ce2000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41ceb000 41d15000 r-xp /usr/lib/libnfc.so.1.0.0
41d1e000 41d4f000 r-xp /usr/lib/libmdm.so.1.1.85
41d57000 41d6d000 r-xp /usr/lib/libnetwork.so.0.0.0
41d76000 41d7b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
4330a000 43313000 r-xp /usr/lib/libcom-core.so.0.0.1
4331c000 43328000 r-xp /usr/lib/libwidget_service.so.1.0.0
43330000 43339000 r-xp /usr/lib/libwidget_provider.so.1.0.0
43342000 43348000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43350000 43358000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43360000 4338e000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
4339a000 433a2000 r-xp /usr/lib/libdrm.so.2.4.0
433aa000 433ac000 r-xp /usr/lib/libdri2.so.0.0.0
433b4000 433bb000 r-xp /usr/lib/libtbm.so.1.0.0
433c3000 433dd000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
433e6000 433ed000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
433f6000 433f8000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43400000 43407000 r-xp /usr/lib/libminizip.so.1.0.0
4340f000 4341c000 r-xp /usr/lib/libail.so.0.1.0
43757000 43f56000 rw-p [stack:15885]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:15896]
bede4000 bee05000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15677)
Call Stack Count: 1
 0: (0xea0) (null)
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
4
12-11 22:31:17.971+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1098) > unread_count: 2
12-11 22:31:17.971+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(622) > category_id: 285, application_id: 218, application_name: 카카오톡, time_stamp: 1449840676, content_id: 0, spannable_string_version: 1
12-11 22:31:17.971+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 22:31:17.971+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 22:31:17.971+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 22:31:17.976+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124317720[0;m
12-11 22:31:17.986+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 22:31:17.986+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 22:31:17.986+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 22:31:17.991+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 22:31:17.991+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_get_block_mode(2328) > Returning false.
12-11 22:31:17.991+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 22:31:17.991+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 22:31:17.991+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 22:31:17.996+0900 E/wnoti-service(  871): wnoti-db-client.c: wnoti_get_alert_categories(712) > !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! application_id : 218, db_id : 2859, is_duplicated : 0
12-11 22:31:18.001+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 22:31:18.001+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 22:31:18.001+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 22:31:18.001+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1335) > New noti is here. Add it on panel  285, 카카오톡.
12-11 22:31:18.001+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 1
12-11 22:31:18.001+0900 E/wnoti-service(  871): wnoti-db-client.c: wnoti_get_alert_categories(851) > view_type : 1, turn_screen_on : 0, allow_gesture : 1, is_used_popup : 0, feedback : 0
12-11 22:31:18.001+0900 I/CAPI_WATCH_APPLICATION(15677): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:31:18.021+0900 I/wnoti-proxy( 2501): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 22:31:18.026+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_get_alert_list(805) > application_name: 카카오톡, application_id: 218, category_id: 285, time: 1449840676, launch_app_id: (null), bg_image: /opt/usr/data/wnoti/.app_icon_218.jpg, icon_color: -5730296
12-11 22:31:18.026+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_get_alert_list(812) > noti_type: 1
12-11 22:31:18.026+0900 W/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(77) > db_id = 2859, alert_type: 1, app_feedback_type: 0
12-11 22:31:18.031+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(364) > Activity fetch finished: -1
12-11 22:31:18.036+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-11 22:31:18.036+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(369) > activity action count: 1
12-11 22:31:18.036+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(374) > 1 activities retrieved.
12-11 22:31:18.041+0900 I/CAPI_NETWORK_WIFI(15677): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:31:18.041+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(465) > Page fetch finished: -1
12-11 22:31:18.046+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(470) > wearable_page_cnt: 1
12-11 22:31:18.046+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(475) > 1 pages retrieved.
12-11 22:31:18.046+0900 W/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_get_alert_list(911) > ::DATA:: read alert list : 1, list count : 1
12-11 22:31:18.046+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 22:31:18.046+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 22:31:18.046+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 22:31:18.046+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 22:31:18.046+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_app_control(1130) > ::DATA:: CHECK IN APP CONTROL : 1, 0, 1
12-11 22:31:18.046+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4398) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
12-11 22:31:18.046+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 13
12-11 22:31:18.046+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 22:31:18.046+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 22:31:18.046+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 22:31:18.046+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 22:31:18.046+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_app_control(1142) > ::APP:: CHECK STATE : 3, 0, (null)
12-11 22:31:18.046+0900 I/wnotib  (  717): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 22:31:18.046+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 22:31:18.051+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 22:31:18.056+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(627) > [2859, 1, 1, 10, 0000]
12-11 22:31:18.056+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(628) > [0, 1, 1, 0]
12-11 22:31:18.056+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(629) > [1, 0, 0, 0]
12-11 22:31:18.056+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 22:31:18.056+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 285, 218
12-11 22:31:18.056+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 22:31:18.071+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1370) > This noti will be removed from panel: 285, 카카오톡.
12-11 22:31:18.071+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 2
12-11 22:31:18.071+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2960) > We don't need to delete the item for second_depth_type: 0.
12-11 22:31:18.071+0900 E/EFL     (  717): elementary<717> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
12-11 22:31:18.071+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 12
12-11 22:31:18.071+0900 I/wnotib  (  717): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 22:31:18.076+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 1, num total noti: 2
12-11 22:31:18.076+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-11 22:31:18.076+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-11 22:31:18.076+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-11 22:31:18.076+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-11 22:31:18.076+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
12-11 22:31:18.076+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-11 22:31:18.076+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 1.
12-11 22:31:18.076+0900 W/W_HOME  (  717): noti_broker.c: _handler_indicator_update(562) > 0x1
12-11 22:31:18.081+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-11 22:31:18.136+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:834]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-11 22:31:18.171+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-11 22:31:18.171+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-11 22:31:18.171+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-11 22:31:18.171+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-11 22:31:18.176+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 2
12-11 22:31:18.176+0900 W/W_HOME  (  717): noti_broker.c: _handler_noti_indicator_show(478) > 
12-11 22:31:18.181+0900 W/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(331) > body is NULL and no attachments found.
12-11 22:31:18.186+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-11 22:31:18.191+0900 W/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-11 22:31:18.191+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-11 22:31:18.196+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_lock(858) > ::UI:: [[[ ===> [simple popup] is LOCK, 0001 ]]]
12-11 22:31:18.196+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4351) > wnotiboard_popup_vi_type: 1
12-11 22:31:18.196+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4357) > (2859, 2859)
12-11 22:31:18.201+0900 I/efl-extension( 2501): efl_extension_circle_surface.c: eext_circle_surface_layout_add(1293) > Put the surface[0x44382bf0]'s widget[0x468925a8] to layout widget[0x468928a8]
12-11 22:31:18.216+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_create_genlist(4285) > (2859, 2859)
12-11 22:31:18.216+0900 I/SHealth_Common( 1061): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-11 22:31:18.221+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: RUNNING
12-11 22:31:18.221+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-11 22:31:18.221+0900 W/W_HOME  (  717): main.c: _appcore_pause_cb(690) > appcore pause
12-11 22:31:18.221+0900 W/W_HOME  (  717): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-11 22:31:18.221+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:31:18.221+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:31:18.221+0900 W/W_HOME  (  717): main.c: home_pause(751) > clock/widget paused
12-11 22:31:18.221+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 22:31:18.221+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:31:18.226+0900 E/CAPI_APPFW_APP_CONTROL(  834): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-11 22:31:18.226+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:834]   value = [false][0m
12-11 22:31:18.226+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-11 22:31:18.231+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
12-11 22:31:18.251+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_create_card_data(3908) > 0x43a91310, 0x43a91190, 0x43a91310
12-11 22:31:18.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 22:31:18.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 22:31:18.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 22:31:18.251+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 22:31:18.251+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_draw_simple_popup(3290) > alert_type : 1, is_source_companion: 1
12-11 22:31:18.256+0900 I/HIGEAR  ( 1131): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-11 22:31:18.256+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_draw_simple_popup(3296) > Manually lock the display.
12-11 22:31:18.266+0900 I/efl-extension( 2501): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x44382bf0 = w: 0 h: 0  obj 0x468925a8 w: 360 h: 360
12-11 22:31:18.266+0900 I/efl-extension( 2501): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
12-11 22:31:18.276+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_turn_on_lcd(2801) > ::APP:: alert_type: 1
12-11 22:31:18.276+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_set_smart_relay(1055) > Set the smart relay for 1, 285, 218, 카카오톡
12-11 22:31:18.276+0900 E/wnoti-proxy( 2501): wnoti.c: wnoti_set_smart_relay(1149) > smart_relay setting : 0
12-11 22:31:18.276+0900 E/E17     (  365): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x0660000a)
12-11 22:31:18.286+0900 W/W_HOME  (  717): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-11 22:31:18.286+0900 W/W_HOME  (  717): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-11 22:31:18.286+0900 W/W_HOME  (  717): gesture.c: _manual_render_enable(133) > 1
12-11 22:31:18.286+0900 W/W_HOME  (  717): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-11 22:31:18.286+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:31:18.301+0900 W/W_HOME  (  717): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
12-11 22:31:18.301+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:31:18.301+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:31:18.306+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:31:18.306+0900 W/W_HOME  (  717): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
12-11 22:31:18.331+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_change_win_level(1170) > current : 8, 0, 1, 0
12-11 22:31:18.331+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_show_detail_view(1855) > ::APP:: Start VI by watch-face
12-11 22:31:18.331+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_lock(858) > ::UI:: [[[ ===> [detail view in simple popup] is LOCK, 0101 ]]]
12-11 22:31:18.341+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_display_lock(1800) > is_display_locked: 1
12-11 22:31:18.346+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_display_lock(1820) > lock lcd
12-11 22:31:18.346+0900 I/APP_CORE( 2501): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-11 22:31:18.346+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x06600008)
12-11 22:31:18.356+0900 W/APP_CORE( 2501): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:660000a
12-11 22:31:18.381+0900 W/wnotibp ( 2501): w-notification-board-panel-basic-common.c: _wnotib_basic_panel_expand_basic_gl_group_content_get(2215) > Unhandled part: stack.separator
12-11 22:31:18.381+0900 I/wnotibp ( 2501): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 22:31:18.381+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(1)
12-11 22:31:18.381+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
12-11 22:31:18.381+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:31:18.381+0900 W/W_HOME  (  717): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(1)
12-11 22:31:18.381+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: PAUSED
12-11 22:31:18.381+0900 I/APP_CORE(  717): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
12-11 22:31:18.381+0900 I/wnotib  (  717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
12-11 22:31:18.381+0900 E/wnotib  (  717): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-11 22:31:18.386+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 22:31:18.386+0900 W/AUL_AMD (  479): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-11 22:31:18.396+0900 I/SHealth_Service( 1061): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-11 22:31:18.396+0900 I/wnotibp ( 2501): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 22:31:18.401+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 22:31:18.401+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 22:31:18.401+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 22:31:18.401+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 22:31:18.411+0900 W/wnotibp ( 2501): w-notification-board-action-drawer.c: wnotib_action_drawer_set_item_info(4618) > category_id: 285, application_id: 218, db_id: 2859, clear_all_items: 1
12-11 22:31:18.411+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_w_input_selector(4847) > No need to close w-input-selector.
12-11 22:31:18.411+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:31:18.421+0900 I/CAPI_NETWORK_WIFI(15677): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:31:18.421+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 22:31:18.421+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_notifiboard_selector(4882) > ret : 0, is_running : 0
12-11 22:31:18.421+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_items_clear(517) > called!!
12-11 22:31:18.421+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_items_clear(2167) > called!!
12-11 22:31:18.421+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 22:31:18.426+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 22:31:18.426+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 22:31:18.426+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 22:31:18.431+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 22:31:18.431+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(3879) > Create drawer pages for 285, 218
12-11 22:31:18.436+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(4304) > action list lengh is [1]
12-11 22:31:18.436+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 22:31:18.436+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 22:31:18.441+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 22:31:18.441+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 22:31:18.446+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 22:31:18.446+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 22:31:18.451+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2199) > called!!
12-11 22:31:18.451+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 22:31:18.451+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 22:31:18.451+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 22:31:18.461+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 22:31:18.461+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 22:31:18.461+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 22:31:18.461+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 22:31:18.466+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 22:31:18.466+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 22:31:18.466+0900 I/wnotibp ( 2501): w-notification-board-common.c: wnotib_common_get_category_name(2172) > application_id: 218, default_name: 카카오톡
12-11 22:31:18.466+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 22:31:18.466+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 22:31:18.471+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 22:31:18.471+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 22:31:18.471+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(4465) > Number of pages: 4 for 218
12-11 22:31:18.481+0900 E/blackandwhite(15677): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:31:18.511+0900 E/EFL     ( 2501): evas_main<2501> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 22:31:18.511+0900 E/EFL     ( 2501): evas_main<2501> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 22:31:18.511+0900 E/EFL     ( 2501): evas_main<2501> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 22:31:18.511+0900 I/wnotibp ( 2501): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 22:31:18.511+0900 I/wnotibp ( 2501): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 22:31:18.516+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 22:31:18.516+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 22:31:18.516+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 22:31:18.516+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 22:31:18.551+0900 I/efl-extension( 2501): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
12-11 22:31:18.551+0900 I/wnotibp ( 2501): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1036) > fully_obscured: 0 [0x660000a 0x660000a 0x6600008 ]
12-11 22:31:18.551+0900 I/APP_CORE( 2501): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
12-11 22:31:18.551+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_update_animator_cb(1376) > called
12-11 22:31:18.556+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_update_animator_cb(1385) > item_list(0x1183239552), count(5)
12-11 22:31:18.561+0900 I/MALI    ( 2501): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43aa8980] swap changed from async to sync
12-11 22:31:18.571+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3641) > ::UI:: VI TYPE : 1
12-11 22:31:18.581+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3647) > alert_type : 1, is_source_companion: 1
12-11 22:31:18.581+0900 W/TIZEN_N_RECORDER( 2501): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
12-11 22:31:18.581+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1258) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
12-11 22:31:18.581+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1267) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
12-11 22:31:18.581+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1301) > ::APP:: Determined feedback: sound 0, vibration: 0
12-11 22:31:18.581+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1305) > No feedback.
12-11 22:31:18.726+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-11 22:31:18.761+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:31:18.776+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:31:18.941+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_show_finished_cb(1009) > ::UI:: popup effect is finished (2859, 443cd348)
12-11 22:31:18.941+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_unlock(908) > ::UI:: [[[ [simple popup] is UNLOCK , 0100 <=== ]]]
12-11 22:31:18.941+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_unlock(949) > ::UI:: wating unlock.
12-11 22:31:18.996+0900 I/CAPI_WATCH_APPLICATION(15677): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:31:19.056+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_detail_view_by_timer_cb(1741) > ::APP:: view state=1, 443cd348
12-11 22:31:19.056+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_vi_start(865) > ::APP:: view_state=2
12-11 22:31:19.056+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_lock(855) > ::UI:: [[[ ===> already [detail view in simple popup] is LOCK, 0100 ]]]
12-11 22:31:19.066+0900 I/CAPI_NETWORK_WIFI(15677): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:31:19.086+0900 I/CAPI_NETWORK_WIFI(15677): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:31:19.176+0900 E/blackandwhite(15677): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:31:19.636+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_unlock(908) > ::UI:: [[[ [detail view in simple popup] is UNLOCK , 0000 <=== ]]]
12-11 22:31:19.636+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 1 1
12-11 22:31:19.651+0900 E/wnoti-service(  871): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
12-11 22:31:19.651+0900 E/wnoti-service(  871): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 2
12-11 22:31:19.656+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 22:31:19.666+0900 E/wnoti-proxy( 2501): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
12-11 22:31:19.666+0900 E/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_get_alert_list(908) > ::DATA:: No categories available.
12-11 22:31:19.666+0900 W/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_get_alert_list(911) > ::DATA:: read alert list : 0, list count : 1
12-11 22:31:19.666+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x443a9160, elm_genlist, _activated_obj : 0x0, activated : 1
12-11 22:31:19.666+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_view_simple_vi_end_idler_cb(679) > Set the drawer 0x45aecde0 again.
12-11 22:31:19.666+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_view_simple_vi_end_idler_cb(683) > ::UI:: SIMPLE_POPUP_TAP (1144836936)
12-11 22:31:19.686+0900 E/wnoti-service(  871): wnoti-server-mgr-stub.c: __wnoti_change_new_flag_stub(2269) > change_type : 1, value : 2859
12-11 22:31:19.691+0900 E/wnoti-service(  871): wnoti-db-server.c: wnoti_get_new_flag_count(4796) > >> count : 1
12-11 22:31:19.691+0900 I/wnoti-service(  871): wnoti-msg-builder.c: _publish_notification(1453) > operation_type : 9, source : 0, application_id : 0, display_count : 1
12-11 22:31:19.701+0900 E/wnoti-service(  871): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
12-11 22:31:19.711+0900 E/wnoti-proxy(  717): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 717, caller_id : 0, listener_type : 9
12-11 22:31:19.711+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 9, op_type: 0, category_id: 0, display count: 1
12-11 22:31:19.711+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1505) > WNOTI_EVENT_CHANGE_NEW_FLAG from popup.
12-11 22:31:19.711+0900 W/W_HOME  (  717): noti_broker.c: _handler_noti_indicator_show(478) > 
12-11 22:31:19.711+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_change_win_level(1170) > current : 12, 1, 2, 1
12-11 22:31:19.721+0900 I/efl-extension( 2501): efl_extension_more_option.c: _cue_show_cb(244) > called!!
12-11 22:31:19.746+0900 E/wnoti-proxy( 2501): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2501, caller_id : 0, listener_type : 9
12-11 22:31:20.001+0900 I/CAPI_WATCH_APPLICATION(15677): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:31:20.126+0900 I/CAPI_NETWORK_WIFI(15677): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:31:20.161+0900 I/CAPI_NETWORK_WIFI(15677): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:31:20.311+0900 E/blackandwhite(15677): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:31:20.336+0900 E/wnoti-service(  871): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(37)
12-11 22:31:20.336+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 2, category : 0, source : 7, feedback : -1, popup_type(RICH) : 0, application_id : -1, seq_num : 230442, noti_flag : 0, g_span_version : 1
12-11 22:31:20.336+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-11 22:31:20.341+0900 E/wnoti-service(  871): wnoti-db-server.c: clear_notification_card(2929) > _query_step failed()
12-11 22:31:20.341+0900 E/wnoti-service(  871): wnoti-db-server.c: clear_notification_card_by_window_id(2854) > _query_step failed()
12-11 22:31:20.346+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 22:31:20.346+0900 E/wnoti-service(  871): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(45)
12-11 22:31:20.351+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 2, category : 0, source : 7, feedback : -1, popup_type(RICH) : 0, application_id : 218, seq_num : 230433, noti_flag : 0, g_span_version : 1
12-11 22:31:20.351+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-11 22:31:20.386+0900 I/wnoti-service(  871): wnoti-msg-builder.c: _publish_notification(1453) > operation_type : 0, source : 0, application_id : 218, display_count : 0
12-11 22:31:20.386+0900 E/wnoti-service(  871): wnoti-db-server.c: set_global_noti_count(1555) > pre_count : 1, count : 1
12-11 22:31:20.386+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 22:31:20.391+0900 E/wnoti-proxy(  717): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 717, caller_id : 0, listener_type : 0
12-11 22:31:20.391+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 0, op_type: 0, category_id: 218, display count: 0
12-11 22:31:20.391+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1548) > Handle this change type in idler.
12-11 22:31:20.391+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1553) > Home is background. Postpone the board update.
12-11 22:31:20.396+0900 E/wnoti-proxy( 2501): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2501, caller_id : 0, listener_type : 0
12-11 22:31:20.396+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1488) > Handle this change type in idler.
12-11 22:31:20.396+0900 E/wnotibp ( 2501): w-notification-board-noti-manager-common.c: wnotib_noti_manager_get_noti_by_db_id(317) > No noti matched. db_id [2856]
12-11 22:31:20.396+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(918) > ::DATA:: remove notification data, 2856
12-11 22:31:20.396+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(948) > ::DATA:: CHECK DATA : 1, 1
12-11 22:31:20.401+0900 E/wnoti-service(  871): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(46)
12-11 22:31:20.406+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 2, category : 0, source : 7, feedback : -1, popup_type(RICH) : 0, application_id : 218, seq_num : 230443, noti_flag : 0, g_span_version : 1
12-11 22:31:20.416+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-11 22:31:20.436+0900 E/wnoti-service(  871): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 1
12-11 22:31:20.436+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 1
12-11 22:31:21.001+0900 I/CAPI_WATCH_APPLICATION(15677): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:31:21.176+0900 I/CAPI_NETWORK_WIFI(15677): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:31:21.281+0900 I/CAPI_NETWORK_WIFI(15677): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:31:21.406+0900 E/blackandwhite(15677): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:31:21.506+0900 E/PKGMGR  (16046): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 22:31:21.671+0900 E/PKGMGR_SERVER(16048): pkgmgr-server.c: main(2126) > package manager server start
12-11 22:31:21.701+0900 E/wnoti-service(  871): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
12-11 22:31:21.701+0900 E/wnoti-service(  871): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 2
12-11 22:31:21.706+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 22:31:21.816+0900 E/PKGMGR_SERVER(16048): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1456318029], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_1456318029' '-r' 'org.reolab.blackandwhite'], cookie=[khayLUIEm3WwCUhxPljZb0wbomo=], backend_flag=[0]
12-11 22:31:21.821+0900 E/PKGMGR  (16048): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 22:31:21.821+0900 E/PKGMGR_SERVER(16048): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 22:31:21.826+0900 E/PKGMGR  (16046): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[160460002]
12-11 22:31:21.836+0900 E/PKGMGR_SERVER(16049): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 22:31:21.836+0900 I/wnoti-service(  871): wnoti-msg-builder.c: _publish_notification(1453) > operation_type : 0, source : 0, application_id : 0, display_count : 0
12-11 22:31:21.846+0900 E/wnoti-service(  871): wnoti-db-server.c: set_global_noti_count(1555) > pre_count : 1, count : 0
12-11 22:31:21.846+0900 E/wnoti-proxy(  717): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 717, caller_id : 0, listener_type : 0
12-11 22:31:21.846+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 0, op_type: 0, category_id: 0, display count: 0
12-11 22:31:21.846+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1548) > Handle this change type in idler.
12-11 22:31:21.846+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1553) > Home is background. Postpone the board update.
12-11 22:31:21.871+0900 E/wnoti-proxy( 2501): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2501, caller_id : 0, listener_type : 0
12-11 22:31:21.871+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1488) > Handle this change type in idler.
12-11 22:31:21.871+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1667) > This notification's category is expired!!!
12-11 22:31:21.871+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1670) > ::APP:: This notification is removed by wnotification service :(2859),(1)
12-11 22:31:21.871+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1673) > ::APP:: delete_reserved_category_id=285, win_id=(null)
12-11 22:31:21.871+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1890) > state : (5, 1, 3)
12-11 22:31:21.871+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1903) > simple popup=443cd348, view_state=3
12-11 22:31:21.871+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1927) > ::APP:: this notification is removed by service, wating ack from host. or more option excution timeout.
12-11 22:31:21.876+0900 I/AUL     (  871): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-11 22:31:21.891+0900 I/AUL     (  871): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-11 22:31:21.906+0900 E/APPS    (  717): AppsBadge.cpp: onBadgeChange(215) >  (!pAppsItem) -> onBadgeChange() return
12-11 22:31:21.996+0900 I/CAPI_WATCH_APPLICATION(15677): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:31:22.036+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 22:31:22.051+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 22:31:22.066+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 22:31:22.066+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:31:22.296+0900 W/CRASH_MANAGER(16051): worker.c: worker_job(1199) > 1115677626c61144984068
