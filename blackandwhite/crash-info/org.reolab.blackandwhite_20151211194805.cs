S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 3751
Date: 2015-12-11 19:48:05+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x7ffffd74

Register Information
r0   = 0x7ffffd68, r1   = 0x0000000d
r2   = 0x7ffffbb8, r3   = 0x41453194
r4   = 0x7ffffd68, r5   = 0x00000000
r6   = 0x418bdcdc, r7   = 0x41896e08
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbe8b1c4c, sp   = 0xbe8b1c00
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     17056 KB
Buffers:     17644 KB
Cached:     181216 KB
VmPeak:     112184 KB
VmSize:     111672 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15992 KB
VmRSS:       15992 KB
VmData:      55144 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3751 TID = 3751
3751 4187 4195 

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
41453000 41456000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
4145e000 41466000 r-xp /usr/lib/libmdm-common.so.1.0.89
41467000 4146c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41474000 41476000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4147f000 41485000 r-xp /usr/lib/libappsvc.so.0.1.0
4148d000 414b1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414ba000 41589000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4159f000 415a9000 r-xp /lib/libnss_files-2.13.so
415b6000 415bb000 rw-p [heap]
415bb000 41669000 rw-p [heap]
41827000 4182b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4183b000 41842000 r-xp /usr/lib/libappcore-watch.so.1.1
41953000 41983000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41984000 41998000 r-xp /usr/lib/libcapi-network-nfc.so.0.2.3
419a0000 419ad000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.55
419b5000 419ba000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
419c2000 419cf000 r-xp /usr/lib/libalarm.so.0.0.0
419d8000 41b15000 r-xp /usr/lib/libicui18n.so.51.1
41b25000 41c09000 r-xp /usr/lib/libicuuc.so.51.1
41c1e000 41c24000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41c2c000 41c32000 r-xp /usr/lib/libwidget.so.1.0.0
41c3b000 41c40000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41c48000 41c7f000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41c88000 41ca1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41caa000 41cd4000 r-xp /usr/lib/libnfc.so.1.0.0
41cdd000 41d0e000 r-xp /usr/lib/libmdm.so.1.1.85
41d16000 41d2c000 r-xp /usr/lib/libnetwork.so.0.0.0
41d35000 41d3a000 r-xp /usr/lib/libcsc-feature.so.0.0.0
432c9000 432d2000 r-xp /usr/lib/libcom-core.so.0.0.1
432db000 432e7000 r-xp /usr/lib/libwidget_service.so.1.0.0
432ef000 432f8000 r-xp /usr/lib/libwidget_provider.so.1.0.0
43301000 43307000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4330f000 43317000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4331f000 4334d000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
43359000 43361000 r-xp /usr/lib/libdrm.so.2.4.0
43369000 4336b000 r-xp /usr/lib/libdri2.so.0.0.0
43373000 4337a000 r-xp /usr/lib/libtbm.so.1.0.0
43382000 4339c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
433a5000 433ac000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
433b5000 433b7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
433bf000 433c6000 r-xp /usr/lib/libminizip.so.1.0.0
433ce000 433db000 r-xp /usr/lib/libail.so.0.1.0
43716000 43f15000 rw-p [stack:4187]
43f15000 43f18000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f20000 43f2b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43fb3000 43fca000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44209000 4420b000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:4195]
be892000 be8b3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3751)
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
-stub.c: __wnoti_post_notification_cards_stub(1149) > Post Card, application_id : 101, identifier : 170:11, gear_source : 0, view_type: 0, time_stamp: 1449830773, feedback : -1, length : 1
12-11 19:46:57.955+0900 E/wnoti-service(  862): wnoti-db-server.c: _wnoti_update_category(851) > re_table_id : 0
12-11 19:46:57.965+0900 I/wnoti-service(  862): wnoti-msg-builder.c: _publish_notification(1453) > operation_type : 0, source : 1, application_id : 101, display_count : 1
12-11 19:46:57.970+0900 E/wnoti-service(  862): wnoti-db-server.c: set_global_noti_count(1555) > pre_count : 1, count : 2
12-11 19:46:57.970+0900 E/wnoti-service(  862): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 19:46:57.975+0900 E/wnoti-proxy( 2286): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2286, caller_id : 0, listener_type : 0
12-11 19:46:57.975+0900 I/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1488) > Handle this change type in idler.
12-11 19:46:57.975+0900 E/wnoti-proxy(  714): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 714, caller_id : 0, listener_type : 0
12-11 19:46:57.975+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 0, op_type: 1, category_id: 101, display count: 1
12-11 19:46:57.975+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1548) > Handle this change type in idler.
12-11 19:46:57.980+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1572) > App tray not displayed and edit mode is off.
12-11 19:46:57.980+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1051) > idler for type: 0
12-11 19:46:57.980+0900 I/MSG_CONSUMER( 1194): msg-consumer-external.c: insert_noti_msg(528) > [0;32mpost noti.ret:0, app:sms, CARD_ID:170:11, source:0, view_type:0[0;m
12-11 19:46:58.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:46:58.015+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:46:58.020+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:46:58.020+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:46:58.025+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:46:58.025+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1098) > unread_count: 3
12-11 19:46:58.025+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(622) > category_id: 285, application_id: 218, application_name: 카카오톡, time_stamp: 1449830580, content_id: 0, spannable_string_version: 1
12-11 19:46:58.025+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:46:58.030+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:46:58.030+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:46:58.030+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:46:58.030+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:46:58.030+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:46:58.030+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:46:58.030+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:46:58.030+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:46:58.030+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:46:58.030+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:46:58.030+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:46:58.035+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:46:58.035+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:46:58.035+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:46:58.035+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:46:58.035+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:46:58.035+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:46:58.035+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:46:58.035+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1098) > unread_count: 1
12-11 19:46:58.035+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(622) > category_id: 288, application_id: 101, application_name: message application, time_stamp: 1449830773, content_id: 0, spannable_string_version: 1
12-11 19:46:58.035+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(647) > error_code: 0, string_val: (null)
12-11 19:46:58.040+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(72) > Apply LTR special character for sender.
12-11 19:46:58.040+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(112) > Apply LTR special character for address.
12-11 19:46:58.040+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1335) > New noti is here. Add it on panel  288, message application.
12-11 19:46:58.040+0900 W/wnotib  (  714): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(260) > Create a panel for panel_id: 1, instance_id: 288
12-11 19:46:58.040+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_initialize(4750) > Initialize the panel with id: 288
12-11 19:46:58.040+0900 W/wnotib  (  714): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(275) > Page instance, instance_id [288] has been created.
12-11 19:46:58.040+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 288, application_id: 101, type: 1
12-11 19:46:58.070+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4398) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
12-11 19:46:58.070+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 13
12-11 19:46:58.070+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 288, application_id: 101, type: 13
12-11 19:46:58.070+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_message_label_str_from_json(2408) > type:text, thumbnail: (null)
12-11 19:46:58.090+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 101, thumbnail path: (null), width: 58, height: 58
12-11 19:46:58.090+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2230) > Use the pre-installed icon for 101.
12-11 19:46:58.090+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88018), origin_x(1), origin_y(1)
12-11 19:46:58.095+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 101, thumbnail path: (null), width: 58, height: 58
12-11 19:46:58.095+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2230) > Use the pre-installed icon for 101.
12-11 19:46:58.105+0900 W/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4577) > Show home indicator.
12-11 19:46:58.105+0900 W/W_HOME  (  714): noti_broker.c: _handler_noti_indicator_show(478) > 
12-11 19:46:58.105+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 12
12-11 19:46:58.105+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 288, application_id: 101, type: 12
12-11 19:46:58.105+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 2, num total noti: 4
12-11 19:46:58.110+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-11 19:46:58.110+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-11 19:46:58.110+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-11 19:46:58.110+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-11 19:46:58.110+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 2, setting_power_saving_mode: 0, show_summary_board: 0
12-11 19:46:58.110+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-11 19:46:58.110+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 2.
12-11 19:46:58.110+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_update(562) > 0x2
12-11 19:46:58.155+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 1
12-11 19:46:58.155+0900 W/W_HOME  (  714): noti_broker.c: _handler_noti_indicator_show(478) > 
12-11 19:46:58.165+0900 W/W_HOME  (  714): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-11 19:46:58.165+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:46:58.175+0900 W/W_HOME  (  714): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-11 19:46:58.175+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:46:58.190+0900 I/GESTURE (  143): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-11 19:46:58.190+0900 I/GESTURE (  143): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-11 19:46:58.220+0900 W/WATCH_CORE( 3584): appcore-watch.c: __widget_pause(1001) > widget_pause
12-11 19:46:58.240+0900 W/APPS    (  714): AppsItem.cpp: onItemBadgeShow(598) >  badge show:[0:1]
12-11 19:46:58.240+0900 W/WATCH_CORE( 3584): appcore-watch.c: __widget_resume(1012) > widget_resume
12-11 19:46:58.245+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:46:58.265+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:46:58.295+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:46:59.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:46:59.030+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:46:59.050+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:00.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:00.020+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:00.050+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:00.125+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-11 19:47:00.125+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-11 19:47:00.125+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: preference_get_double(1214) > preference_get_double(1049) : pedometer_inactive_period error
12-11 19:47:00.125+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-11 19:47:00.125+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-11 19:47:00.125+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: preference_get_double(1214) > preference_get_double(1049) : inactive_10min_precaution_millisec error
12-11 19:47:00.130+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-11 19:47:00.130+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-11 19:47:00.130+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: preference_get_double(1214) > preference_get_double(1049) : inactive_before_10min_precaution_millisec error
12-11 19:47:00.995+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:01.025+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:01.050+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:02.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:02.030+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:02.045+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:03.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:03.030+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:03.045+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:04.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:04.030+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:04.055+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:04.999+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:05.024+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:05.049+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:06.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:06.030+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:06.050+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:06.994+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:07.029+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:07.044+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:07.999+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:08.029+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:08.049+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:09.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:09.015+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:09.045+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:09.999+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:10.035+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:10.060+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:11.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:11.020+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:11.050+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:12.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:12.030+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:12.050+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:13.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:13.025+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:13.045+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:13.080+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 19:47:13.080+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 19:47:14.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:14.025+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:14.070+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:14.999+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:15.034+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:15.049+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:16.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:16.030+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:16.050+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:17.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:17.030+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:17.055+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:18.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:18.025+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:18.050+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:19.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:19.020+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:19.050+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:20.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:20.025+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:20.040+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:20.540+0900 W/WATCH_CORE( 3584): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-11 19:47:20.540+0900 I/WATCH_CORE( 3584): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-11 19:47:20.555+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-11 19:47:20.555+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-11 19:47:20.560+0900 I/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-11 19:47:20.565+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-11 19:47:20.570+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-11 19:47:20.570+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 1
12-11 19:47:20.570+0900 W/W_HOME  (  714): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-11 19:47:20.570+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:47:20.575+0900 W/STARTER (  701): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-11 19:47:20.575+0900 W/STARTER (  701): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-11 19:47:20.580+0900 E/STARTER (  701): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-11 19:47:20.580+0900 W/STARTER (  701): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-11 19:47:20.580+0900 W/STARTER (  701): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-11 19:47:20.585+0900 I/SCONTEXT-LIB(  648): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-11 19:47:20.670+0900 I/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-11 19:47:20.670+0900 W/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-11 19:47:20.670+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-11 19:47:20.670+0900 I/HIGEAR  ( 1106): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-11 19:47:20.895+0900 W/MUSIC_CONTROL_SERVICE(  819): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:819]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-11 19:47:20.900+0900 I/SHealth_Common( 1049): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-11 19:47:20.905+0900 W/STARTER (  701): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-11 19:47:20.905+0900 W/STARTER (  701): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-11 19:47:20.905+0900 W/STARTER (  701): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-11 19:47:20.905+0900 W/STARTER (  701): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-11 19:47:20.910+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: PAUSE State: RUNNING
12-11 19:47:20.910+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-11 19:47:20.910+0900 W/W_HOME  (  714): main.c: _appcore_pause_cb(690) > appcore pause
12-11 19:47:20.910+0900 W/W_HOME  (  714): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-11 19:47:20.915+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:47:20.915+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:47:20.915+0900 W/W_HOME  (  714): main.c: home_pause(751) > clock/widget paused
12-11 19:47:20.915+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:47:20.915+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 19:47:20.915+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 19:47:20.915+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 19:47:20.915+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-11 19:47:20.915+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-11 19:47:20.915+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 19:47:20.915+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 19:47:20.915+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 19:47:20.920+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 19:47:20.920+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 19:47:20.920+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 19:47:20.920+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 19:47:20.920+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 19:47:20.920+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 19:47:20.920+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 19:47:20.920+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 19:47:20.920+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 19:47:20.920+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 19:47:20.920+0900 E/CAPI_APPFW_APP_CONTROL(  819): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-11 19:47:20.920+0900 W/MUSIC_CONTROL_SERVICE(  819): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:819]   value = [false][0m
12-11 19:47:20.925+0900 I/GESTURE (  143): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-11 19:47:20.945+0900 I/SHealth_Service( 1049): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-11 19:47:21.000+0900 I/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 19:47:21.010+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:21.020+0900 I/CAPI_NETWORK_WIFI( 3584): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:21.075+0900 W/WATCH_CORE( 3584): appcore-watch.c: __widget_pause(1001) > widget_pause
12-11 19:47:21.425+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: MEM_FLUSH State: PAUSED
12-11 19:47:24.475+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 19:47:25.320+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_client_exit_consumer(691) > [0;31m* Critical * Total allocated space (uordblks):255544
12-11 19:47:25.320+0900 E/W-CONTACTS2-CONSUMER( 3633): [0;m
12-11 19:47:25.320+0900 I/CAPI_APPFW_APPLICATION( 3633): service_app_main.c: service_app_exit(441) > service_app_exit
12-11 19:47:25.320+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 19:47:25.320+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(884) > app status : 4
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 19:47:25.445+0900 E/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
12-11 19:47:25.445+0900 E/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(3633) are closed. delete client info
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
12-11 19:47:25.445+0900 E/MESSAGE_PORT(  438): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  3633
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: UnregisterMessagePortByDiscon(280) > _MessagePortService::UnregisterMessagePortByDiscon
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.445+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:47:25.535+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 23
12-11 19:47:25.535+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-11 19:47:25.535+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 3633
12-11 19:47:25.535+0900 W/AUL_AMD (  475): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-11 19:47:25.540+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3633
12-11 19:47:25.925+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: MEM_FLUSH State: PAUSED
12-11 19:47:27.324+0900 W/AUL_AMD (  475): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 19:47:45.045+0900 E/PKGMGR_SERVER( 4180): pkgmgr-server.c: main(2126) > package manager server start
12-11 19:47:45.125+0900 E/PKGMGR_SERVER( 4180): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_229622921], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 19:47:45.130+0900 E/PKGMGR_SERVER( 4182): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 19:47:45.135+0900 E/PKGMGR  ( 4174): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 19:47:45.200+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:47:45.210+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3584
12-11 19:47:45.210+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:47:45.215+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 19:47:45.220+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(3584), cmd(4)
12-11 19:47:45.220+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 19:47:45.220+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(884) > app status : 4
12-11 19:47:45.220+0900 W/CAPI_WATCH_APPLICATION( 3584): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 19:47:45.225+0900 W/WATCH_CORE( 3584): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 19:47:45.225+0900 E/WIDGET_PROVIDER_APP( 3584): client.c: client_fini(1175) > Provider is not initialized
12-11 19:47:45.225+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:47:45.235+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3584
12-11 19:47:45.235+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 19:47:45.340+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:47:45.355+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 19:47:45.365+0900 E/PKGMGR_SERVER( 4182): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 19:47:45.385+0900 E/PKGMGR_SERVER( 4180): pkgmgr-server.c: sighandler(445) > child NORMAL exit [4182]
12-11 19:47:45.445+0900 E/AUL_AMD (  475): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 19:47:45.445+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(3584), cmd(4)
12-11 19:47:45.450+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 19:47:45.470+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:47:45.490+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:47:45.490+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 19:47:45.490+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 703
12-11 19:47:45.530+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 19:47:45.530+0900 W/AUL_PAD ( 1208): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 19:47:45.530+0900 W/AUL_PAD ( 1208): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 19:47:45.535+0900 E/RESOURCED(  481): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-11 19:47:45.535+0900 E/RESOURCED(  481): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 19:47:45.595+0900 I/CAPI_WATCH_APPLICATION( 3751): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 19:47:45.620+0900 E/TBM     ( 3751): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 19:47:45.640+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3584
12-11 19:47:45.675+0900 W/WATCH_CORE( 3751): appcore-watch.c: __widget_create(958) > widget_create
12-11 19:47:45.675+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1712) > [SECURE_LOG] [14.824063] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263044:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 19:47:45.675+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[14.824063] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263044:4] gbar_fname[]
12-11 19:47:45.695+0900 E/WIDGET_VIEWER(  714): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 19:47:45.695+0900 E/WIDGET_EVAS(  714): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 19:47:45.830+0900 I/CAPI_NETWORK_WIFI( 3751): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:47:45.845+0900 I/CAPI_NETWORK_WIFI( 3751): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:47:46.025+0900 W/WATCH_CORE( 3751): appcore-watch.c: __widget_create(976) > widget_create done
12-11 19:47:46.055+0900 I/WATCH_CORE( 3751): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 19:47:46.055+0900 I/WATCH_CORE( 3751): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 19:47:46.055+0900 I/WATCH_CORE( 3751): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 19:47:46.640+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 19:47:46.640+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 19:47:46.655+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:47:46.665+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3751
12-11 19:47:46.665+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:47:46.855+0900 I/AUL_PAD ( 4213): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 19:47:47.220+0900 W/AUL_AMD (  475): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 19:47:47.515+0900 E/PKGMGR_SERVER( 4180): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 19:47:47.515+0900 E/PKGMGR_SERVER( 4180): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 19:47:59.285+0900 E/PKGMGR  ( 4324): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 19:47:59.470+0900 E/PKGMGR_SERVER( 4326): pkgmgr-server.c: main(2126) > package manager server start
12-11 19:47:59.570+0900 E/PKGMGR_SERVER( 4326): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_244032317], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_244032317' '-r' 'org.reolab.blackandwhite'], cookie=[jasQ+yUj7quSzmcm4QsL5e5/XwY=], backend_flag=[0]
12-11 19:47:59.575+0900 E/PKGMGR  ( 4326): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 19:47:59.575+0900 E/PKGMGR_SERVER( 4326): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 19:47:59.575+0900 E/PKGMGR_SERVER( 4327): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 19:47:59.580+0900 E/PKGMGR  ( 4324): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[43240002]
12-11 19:47:59.755+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 19:47:59.765+0900 W/AUL_AMD (  475): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 19:47:59.775+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 19:47:59.780+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:48:00.350+0900 E/PKGMGR_CERT( 4327): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 19:48:00.355+0900 E/PKGMGR_CERT( 4327): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
12-11 19:48:00.355+0900 E/PKGMGR_CERT( 4327): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
12-11 19:48:00.360+0900 E/PKGMGR_CERT( 4327): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-11 19:48:00.360+0900 E/PKGMGR_CERT( 4327): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-11 19:48:00.360+0900 E/PKGMGR_CERT( 4327): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-11 19:48:00.360+0900 E/PKGMGR_CERT( 4327): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-11 19:48:00.370+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:48:00.385+0900 E/PKGMGR_CERT( 4327): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 19:48:01.515+0900 E/PKGMGR_SERVER( 4326): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:48:02.105+0900 E/rpm-installer( 4327): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-11 19:48:03.515+0900 E/PKGMGR_SERVER( 4326): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:48:05.010+0900 E/PKGMGR_SERVER( 4326): pkgmgr-server.c: sighandler(445) > child NORMAL exit [4327]
12-11 19:48:05.020+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:48:05.035+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-11 19:48:05.035+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-11 19:48:05.050+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-11 19:48:05.050+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-11 19:48:05.050+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-11 19:48:05.050+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-11 19:48:05.085+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-11 19:48:05.130+0900 E/PKGMGR_INFO(  479): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-11 19:48:05.175+0900 E/APPS    (  714): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-11 19:48:05.400+0900 W/CRASH_MANAGER( 4331): worker.c: worker_job(1199) > 1103751626c61144983088
