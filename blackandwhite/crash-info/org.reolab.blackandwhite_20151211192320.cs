S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 4733
Date: 2015-12-11 19:23:20+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1330

Register Information
r0   = 0x00001324, r1   = 0x0000000d
r2   = 0x000011a4, r3   = 0x41553194
r4   = 0x00001324, r5   = 0x00000000
r6   = 0x414e922c, r7   = 0x414dd608
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbe8aac54, sp   = 0xbe8aac08
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   490336 KB
MemFree:     18460 KB
Buffers:     10928 KB
Cached:      97180 KB
VmPeak:     111464 KB
VmSize:     110952 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15944 KB
VmRSS:       15944 KB
VmData:      54424 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 4733 TID = 4733
4733 5635 5644 

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
43757000 43f56000 rw-p [stack:5635]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:5644]
be88b000 be8ac000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4733)
Call Stack Count: 6
 0: (0x400169dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0x400170d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0x40017360) [/lib/ld-linux.so.3] + 0xa360
 3: (0x4001b5e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0x40021a60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0x404e1808) [/lib/libc.so.6] + 0x6d808
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
 1 activities retrieved.
12-11 19:22:15.735+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:22:15.735+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:22:15.735+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:22:15.735+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:22:15.735+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:22:15.735+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:22:15.740+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:22:15.740+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:22:15.740+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:22:15.740+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1335) > New noti is here. Add it on panel  285, 카카오톡.
12-11 19:22:15.740+0900 I/wnotib  (  713): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 1
12-11 19:22:15.745+0900 W/wnotibp (27660): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(267) > fg_app : 1
12-11 19:22:15.750+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:22:15.760+0900 E/TIZEN_N_SYSTEM_SETTINGS(  713): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 19:22:15.760+0900 E/TIZEN_N_SYSTEM_SETTINGS(  713): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 19:22:15.760+0900 E/TIZEN_N_SYSTEM_SETTINGS(  713): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 19:22:15.760+0900 E/TIZEN_N_SYSTEM_SETTINGS(  713): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 19:22:15.760+0900 I/wnotib  (  713): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4398) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
12-11 19:22:15.760+0900 I/wnotib  (  713): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 13
12-11 19:22:15.760+0900 E/TIZEN_N_SYSTEM_SETTINGS(  713): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 19:22:15.760+0900 E/TIZEN_N_SYSTEM_SETTINGS(  713): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 19:22:15.760+0900 E/TIZEN_N_SYSTEM_SETTINGS(  713): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 19:22:15.760+0900 E/TIZEN_N_SYSTEM_SETTINGS(  713): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 19:22:15.765+0900 I/wnotib  (  713): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 19:22:15.765+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 19:22:15.765+0900 I/wnotibp (27660): wnotiboard-popup-view.c: wnotiboard_popup_get_block_mode(2328) > Returning false.
12-11 19:22:15.770+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1370) > This noti will be removed from panel: 285, 카카오톡.
12-11 19:22:15.770+0900 I/wnotib  (  713): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 2
12-11 19:22:15.770+0900 I/wnotib  (  713): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2960) > We don't need to delete the item for second_depth_type: 0.
12-11 19:22:15.770+0900 E/EFL     (  713): elementary<713> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
12-11 19:22:15.775+0900 I/wnotib  (  713): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 12
12-11 19:22:15.775+0900 I/wnotib  (  713): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 19:22:15.775+0900 W/wnotib  (  713): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 1, num total noti: 2
12-11 19:22:15.775+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-11 19:22:15.775+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-11 19:22:15.780+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-11 19:22:15.780+0900 I/wnotib  (  713): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-11 19:22:15.780+0900 I/wnotib  (  713): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
12-11 19:22:15.780+0900 I/wnotib  (  713): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-11 19:22:15.780+0900 I/wnotib  (  713): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 1.
12-11 19:22:15.780+0900 W/W_HOME  (  713): noti_broker.c: _handler_indicator_update(562) > 0x1
12-11 19:22:15.780+0900 E/wnoti-service(  851): wnoti-db-client.c: wnoti_get_alert_categories(712) > !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! application_id : 218, db_id : 2811, is_duplicated : 0
12-11 19:22:15.780+0900 E/wnoti-service(  851): wnoti-db-client.c: wnoti_get_alert_categories(851) > view_type : 1, turn_screen_on : 0, allow_gesture : 1, is_used_popup : 0, feedback : 0
12-11 19:22:15.805+0900 I/wnoti-proxy(27660): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:22:15.805+0900 I/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_get_alert_list(805) > application_name: 카카오톡, application_id: 218, category_id: 285, time: 1449829334, launch_app_id: (null), bg_image: /opt/usr/data/wnoti/.app_icon_218.jpg, icon_color: -5730296
12-11 19:22:15.805+0900 I/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_get_alert_list(812) > noti_type: 1
12-11 19:22:15.805+0900 W/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_convert_alert_data(77) > db_id = 2811, alert_type: 1, app_feedback_type: 0
12-11 19:22:15.805+0900 I/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_convert_alert_data(364) > Activity fetch finished: -1
12-11 19:22:15.805+0900 I/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_convert_alert_data(369) > activity action count: 1
12-11 19:22:15.805+0900 I/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_convert_alert_data(374) > 1 activities retrieved.
12-11 19:22:15.805+0900 I/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_convert_alert_data(465) > Page fetch finished: -1
12-11 19:22:15.805+0900 I/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_convert_alert_data(470) > wearable_page_cnt: 1
12-11 19:22:15.805+0900 I/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_convert_alert_data(475) > 1 pages retrieved.
12-11 19:22:15.805+0900 W/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_get_alert_list(911) > ::DATA:: read alert list : 1, list count : 1
12-11 19:22:15.805+0900 W/wnotibp (27660): wnotiboard-popup.c: _wnotiboard_popup_app_control(1130) > ::DATA:: CHECK IN APP CONTROL : 1, 0, 1
12-11 19:22:15.805+0900 W/wnotibp (27660): wnotiboard-popup.c: _wnotiboard_popup_app_control(1142) > ::APP:: CHECK STATE : 2, 0, (null)
12-11 19:22:15.810+0900 W/wnotibp (27660): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 19:22:15.810+0900 W/wnotibp (27660): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 19:22:15.810+0900 W/wnotibp (27660): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(627) > [2811, 1, 1, 22, 0000]
12-11 19:22:15.810+0900 W/wnotibp (27660): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(628) > [0, 3, 0, 0]
12-11 19:22:15.810+0900 W/wnotibp (27660): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(629) > [1, 0, 0, 0]
12-11 19:22:15.810+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:22:15.810+0900 I/wnotibp (27660): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 285, 218
12-11 19:22:15.810+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:22:15.830+0900 W/wnotibp (27660): wnotiboard-popup.c: wnotiboard_popup_view_lock(858) > ::UI:: [[[ ===> [simple popup] is LOCK, 0001 ]]]
12-11 19:22:15.830+0900 I/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4351) > wnotiboard_popup_vi_type: 1
12-11 19:22:15.830+0900 I/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4357) > (2811, 2811)
12-11 19:22:15.835+0900 W/wnotib  (  713): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 2
12-11 19:22:15.835+0900 W/W_HOME  (  713): noti_broker.c: _handler_noti_indicator_show(478) > 
12-11 19:22:15.835+0900 I/efl-extension(27660): efl_extension_circle_surface.c: eext_circle_surface_layout_add(1293) > Put the surface[0x4433f2d0]'s widget[0x4433dee0] to layout widget[0x4433e360]
12-11 19:22:15.840+0900 W/wnotib  (  713): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(331) > body is NULL and no attachments found.
12-11 19:22:15.850+0900 I/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_create_genlist(4285) > (2811, 2811)
12-11 19:22:15.865+0900 I/efl-extension(27660): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
12-11 19:22:15.875+0900 I/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_create_card_data(3908) > 0x451051b8, 0x45105038, 0x451051b8
12-11 19:22:15.875+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 19:22:15.875+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 19:22:15.875+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 19:22:15.875+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 19:22:15.880+0900 I/wnotibp (27660): wnotiboard-popup-view.c: wnotiboard_popup_draw_simple_popup(3290) > alert_type : 1, is_source_companion: 1
12-11 19:22:15.890+0900 W/wnotibp (27660): wnotiboard-popup-view.c: wnotiboard_popup_draw_simple_popup(3296) > Manually lock the display.
12-11 19:22:15.890+0900 I/efl-extension(27660): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x4433f2d0 = w: 0 h: 0  obj 0x4433dee0 w: 360 h: 360
12-11 19:22:15.895+0900 I/efl-extension(27660): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
12-11 19:22:15.905+0900 W/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_turn_on_lcd(2801) > ::APP:: alert_type: 1
12-11 19:22:15.905+0900 W/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_set_smart_relay(1055) > Set the smart relay for 1, 285, 218, 카카오톡
12-11 19:22:15.905+0900 E/wnoti-proxy(27660): wnoti.c: wnoti_set_smart_relay(1149) > smart_relay setting : 0
12-11 19:22:15.905+0900 E/E17     (  366): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x0140000a)
12-11 19:22:15.905+0900 I/wnotibp (27660): wnotiboard-popup-view.c: wnotiboard_popup_change_win_level(1170) > current : 12, 1, 1, 1
12-11 19:22:15.905+0900 I/APP_CORE(27660): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-11 19:22:15.920+0900 W/wnotibp (27660): w-notification-board-panel-basic-common.c: _wnotib_basic_panel_expand_basic_gl_group_content_get(2215) > Unhandled part: stack.separator
12-11 19:22:15.920+0900 I/wnotibp (27660): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 19:22:15.920+0900 I/wnotibp (27660): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 19:22:15.930+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 19:22:15.930+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 19:22:15.930+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 19:22:15.930+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 19:22:15.935+0900 W/W_HOME  (  713): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
12-11 19:22:15.935+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:22:15.935+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:22:15.935+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:22:15.935+0900 W/W_HOME  (  713): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
12-11 19:22:15.935+0900 E/E17     (  366): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x0140000a)
12-11 19:22:15.950+0900 W/wnotibp (27660): w-notification-board-action-drawer.c: wnotib_action_drawer_set_item_info(4618) > category_id: 285, application_id: 218, db_id: 2811, clear_all_items: 1
12-11 19:22:15.950+0900 I/wnotibp (27660): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_w_input_selector(4847) > No need to close w-input-selector.
12-11 19:22:15.950+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:22:15.960+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 19:22:15.960+0900 I/wnotibp (27660): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_notifiboard_selector(4882) > ret : 0, is_running : 0
12-11 19:22:15.960+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_items_clear(517) > called!!
12-11 19:22:15.960+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_items_clear(2167) > called!!
12-11 19:22:15.960+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 19:22:15.965+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 19:22:15.965+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 19:22:15.970+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 19:22:15.975+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 19:22:15.975+0900 I/wnotibp (27660): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(3879) > Create drawer pages for 285, 218
12-11 19:22:15.975+0900 I/wnotibp (27660): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(4304) > action list lengh is [1]
12-11 19:22:15.975+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 19:22:15.975+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 19:22:15.980+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 19:22:15.980+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 19:22:15.985+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 19:22:15.985+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 19:22:15.985+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2199) > called!!
12-11 19:22:15.990+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 19:22:15.990+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 19:22:15.990+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 19:22:15.990+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 19:22:15.990+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 19:22:15.995+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 19:22:15.995+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 19:22:15.995+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 19:22:15.995+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 19:22:15.995+0900 I/wnotibp (27660): w-notification-board-common.c: wnotib_common_get_category_name(2172) > application_id: 218, default_name: 카카오톡
12-11 19:22:15.995+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 19:22:15.995+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 19:22:16.000+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 19:22:16.000+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 19:22:16.000+0900 I/wnotibp (27660): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(4465) > Number of pages: 4 for 218
12-11 19:22:16.015+0900 I/efl-extension(27660): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
12-11 19:22:16.020+0900 W/APP_CORE(27660): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:140000a
12-11 19:22:16.020+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: _item_update_animator_cb(1376) > called
12-11 19:22:16.020+0900 I/efl-extension(27660): efl_extension_rotary_selector.c: _item_update_animator_cb(1385) > item_list(0x1168266888), count(5)
12-11 19:22:16.035+0900 E/EFL     (27660): evas_main<27660> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 19:22:16.035+0900 E/EFL     (27660): evas_main<27660> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 19:22:16.035+0900 E/EFL     (27660): evas_main<27660> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 19:22:16.035+0900 I/wnotibp (27660): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 19:22:16.035+0900 I/wnotibp (27660): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 19:22:16.035+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 19:22:16.035+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 19:22:16.035+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 19:22:16.035+0900 E/TIZEN_N_SYSTEM_SETTINGS(27660): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 19:22:16.080+0900 W/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3641) > ::UI:: VI TYPE : 1
12-11 19:22:16.080+0900 W/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3647) > alert_type : 1, is_source_companion: 1
12-11 19:22:16.080+0900 W/TIZEN_N_RECORDER(27660): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
12-11 19:22:16.080+0900 W/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1258) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
12-11 19:22:16.085+0900 I/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1267) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
12-11 19:22:16.085+0900 W/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1301) > ::APP:: Determined feedback: sound 0, vibration: 0
12-11 19:22:16.085+0900 I/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1305) > No feedback.
12-11 19:22:16.085+0900 W/W_HOME  (  713): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(1)
12-11 19:22:16.085+0900 W/W_HOME  (  713): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
12-11 19:22:16.085+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:22:16.085+0900 W/W_HOME  (  713): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(1)
12-11 19:22:16.085+0900 I/APP_CORE(  713): appcore-efl.c: __do_app(429) > [APP 713] Event: PAUSE State: PAUSED
12-11 19:22:16.090+0900 I/APP_CORE(  713): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
12-11 19:22:16.090+0900 I/wnotib  (  713): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
12-11 19:22:16.090+0900 E/wnotib  (  713): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-11 19:22:16.090+0900 I/wnotibp (27660): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1036) > fully_obscured: 0 [0x140000a 0x140000a 0x1400008 ]
12-11 19:22:16.090+0900 I/APP_CORE(27660): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
12-11 19:22:16.110+0900 W/AUL_AMD (  454): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 19:22:16.110+0900 W/AUL_AMD (  454): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-11 19:22:16.120+0900 I/MALI    (27660): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x4511b940] swap changed from async to sync
12-11 19:22:16.460+0900 W/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_show_finished_cb(1009) > ::UI:: popup effect is finished (2811, 46d7aa78)
12-11 19:22:16.460+0900 W/wnotibp (27660): wnotiboard-popup.c: wnotiboard_popup_view_unlock(908) > ::UI:: [[[ [simple popup] is UNLOCK , 0000 <=== ]]]
12-11 19:22:16.460+0900 W/wnotibp (27660): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 1 1
12-11 19:22:16.475+0900 E/wnoti-service(  851): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
12-11 19:22:16.480+0900 E/wnoti-service(  851): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 2
12-11 19:22:16.485+0900 E/wnoti-service(  851): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 19:22:16.495+0900 E/wnoti-proxy(27660): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
12-11 19:22:16.495+0900 E/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_get_alert_list(908) > ::DATA:: No categories available.
12-11 19:22:16.495+0900 W/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_get_alert_list(911) > ::DATA:: read alert list : 0, list count : 1
12-11 19:22:17.555+0900 E/wnoti-service(  851): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
12-11 19:22:19.565+0900 E/wnoti-service(  851): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
12-11 19:22:22.900+0900 W/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1890) > state : (2, 1, 1)
12-11 19:22:22.900+0900 I/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1903) > simple popup=46d7aa78, view_state=1
12-11 19:22:22.900+0900 W/wnotibp (27660): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 19:22:22.900+0900 W/wnotibp (27660): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(997) > ::UI:: lock state = 0000
12-11 19:22:22.955+0900 W/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1963) > device_power_release_lock CPU>>>>>>>
12-11 19:22:23.030+0900 W/W_HOME  (  713): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
12-11 19:22:23.030+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:22:23.030+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:22:23.070+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:22:23.070+0900 I/wnotibp (27660): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 285, 218
12-11 19:22:23.070+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:22:23.070+0900 I/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1998) > ::INFO:: call lower
12-11 19:22:23.100+0900 W/AUL_AMD (  454): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 19:22:23.100+0900 W/AUL_AMD (  454): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-11 19:22:23.130+0900 W/wnotibp (27660): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_del_cb(424) > ::UI:: (3, 46d7aa78, 46d7aa78, 0)
12-11 19:22:23.130+0900 I/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(918) > ::DATA:: remove notification data, 2811
12-11 19:22:23.130+0900 I/wnotibp (27660): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(948) > ::DATA:: CHECK DATA : 0, 0
12-11 19:22:23.130+0900 W/wnotibp (27660): wnotiboard-popup.c: wnotiboard_popup_view_unlock(910) > ::UI:: [[[ [simple popup] is not in lock state , 0000  <===]]]
12-11 19:22:23.130+0900 W/wnotibp (27660): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 0 0
12-11 19:22:23.130+0900 I/efl-extension(27660): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4569a7b0, elm_genlist, _activated_obj : 0x0, activated : 0
12-11 19:22:23.130+0900 I/wnotibp (27660): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_w_input_selector(4847) > No need to close w-input-selector.
12-11 19:22:23.135+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:22:23.135+0900 W/W_HOME  (  713): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
12-11 19:22:23.140+0900 W/W_HOME  (  713): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(0)
12-11 19:22:23.140+0900 W/W_HOME  (  713): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
12-11 19:22:23.140+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:22:23.140+0900 W/W_HOME  (  713): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(0)
12-11 19:22:23.140+0900 I/APP_CORE(  713): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
12-11 19:22:23.140+0900 I/wnotib  (  713): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
12-11 19:22:23.140+0900 E/wnotib  (  713): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-11 19:22:23.140+0900 W/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-11 19:22:23.155+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:22:23.165+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 19:22:23.170+0900 I/wnotibp (27660): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_notifiboard_selector(4882) > ret : 0, is_running : 0
12-11 19:22:23.170+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:22:23.170+0900 I/wnotibp (27660): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 285, 218
12-11 19:22:23.175+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:22:23.185+0900 I/efl-extension(27660): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4569a7b0, obj: 0x4569a7b0
12-11 19:22:23.185+0900 I/efl-extension(27660): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-11 19:22:23.210+0900 I/efl-extension(27660): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-11 19:22:23.210+0900 I/efl-extension(27660): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4569a7b0, elm_genlist, func : 0x41a41e59
12-11 19:22:23.210+0900 I/efl-extension(27660): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-11 19:22:23.220+0900 I/MALI    (27660): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4511b940] swap changed from sync to async
12-11 19:22:23.225+0900 I/efl-extension(27660): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
12-11 19:22:23.225+0900 W/APP_CORE(27660): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:140000a
12-11 19:22:23.225+0900 I/APP_CORE(27660): appcore-efl.c: __do_app(429) > [APP 27660] Event: PAUSE State: RUNNING
12-11 19:22:23.225+0900 I/CAPI_APPFW_APPLICATION(27660): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-11 19:22:23.240+0900 W/wnotibp (27660): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(267) > fg_app : 1
12-11 19:22:23.245+0900 W/wnotibp (27660): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 19:22:23.245+0900 W/wnotibp (27660): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1368) > [0, 0, 22, 0000]
12-11 19:22:23.245+0900 W/wnotibp (27660): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [1, 0]
12-11 19:22:23.245+0900 W/wnotibp (27660): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [0, 3, 0, 2, 0]
12-11 19:22:28.250+0900 I/APP_CORE(27660): appcore-efl.c: __do_app(429) > [APP 27660] Event: MEM_FLUSH State: PAUSED
12-11 19:22:51.215+0900 E/PKGMGR_SERVER( 5625): pkgmgr-server.c: main(2126) > package manager server start
12-11 19:22:51.320+0900 E/PKGMGR_SERVER( 5625): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1264192918], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 19:22:51.330+0900 E/PKGMGR_SERVER( 5627): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 19:22:51.330+0900 E/PKGMGR  ( 5618): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 19:22:51.395+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:22:51.405+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4286
12-11 19:22:51.405+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:22:51.410+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 19:22:51.410+0900 W/AUL_AMD (  454): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(4286), cmd(4)
12-11 19:22:51.415+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 19:22:51.415+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(884) > app status : 4
12-11 19:22:51.415+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:22:51.420+0900 W/CAPI_WATCH_APPLICATION( 4286): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 19:22:51.420+0900 W/WATCH_CORE( 4286): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 19:22:51.420+0900 E/WIDGET_PROVIDER_APP( 4286): client.c: client_fini(1175) > Provider is not initialized
12-11 19:22:51.420+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4286
12-11 19:22:51.420+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 19:22:51.525+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:22:51.605+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 19:22:51.660+0900 E/AUL_AMD (  454): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 19:22:51.660+0900 W/AUL_AMD (  454): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(4286), cmd(4)
12-11 19:22:51.685+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 19:22:51.745+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:22:51.785+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:22:51.785+0900 E/AUL_AMD (  454): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 19:22:51.785+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(1659) > caller pid : 707
12-11 19:22:51.910+0900 E/PKGMGR_SERVER( 5627): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 19:22:52.015+0900 E/PKGMGR_SERVER( 5625): pkgmgr-server.c: sighandler(445) > child NORMAL exit [5627]
12-11 19:22:52.050+0900 E/RESOURCED(  464): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 9
12-11 19:22:52.050+0900 E/RESOURCED(  464): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 19:22:52.055+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 19:22:52.055+0900 W/AUL_PAD ( 1159): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 19:22:52.055+0900 W/AUL_PAD ( 1159): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 19:22:52.100+0900 I/CAPI_WATCH_APPLICATION( 4733): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 19:22:52.120+0900 E/TBM     ( 4733): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 19:22:52.160+0900 I/AUL_AMD (  454): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4286
12-11 19:22:52.205+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1712) > [SECURE_LOG] [7836.844238] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_713_7836.844238.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263196:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 19:22:52.205+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[7836.844238] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_713_7836.844238.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263196:4] gbar_fname[]
12-11 19:22:52.205+0900 W/WATCH_CORE( 4733): appcore-watch.c: __widget_create(958) > widget_create
12-11 19:22:52.215+0900 E/WIDGET_VIEWER(  713): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 19:22:52.215+0900 E/WIDGET_EVAS(  713): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 19:22:52.340+0900 I/CAPI_NETWORK_WIFI( 4733): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:22:52.345+0900 I/CAPI_NETWORK_WIFI( 4733): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:22:52.515+0900 W/WATCH_CORE( 4733): appcore-watch.c: __widget_create(976) > widget_create done
12-11 19:22:52.550+0900 I/WATCH_CORE( 4733): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 19:22:52.550+0900 I/WATCH_CORE( 4733): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 19:22:52.550+0900 I/WATCH_CORE( 4733): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 19:22:53.150+0900 E/PKGMGR_SERVER( 5625): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 19:22:53.150+0900 E/PKGMGR_SERVER( 5625): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 19:22:53.160+0900 W/AUL_AMD (  454): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 19:22:53.160+0900 W/AUL_AMD (  454): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 19:22:53.215+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:22:53.220+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4733
12-11 19:22:53.220+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:22:53.380+0900 I/AUL_PAD ( 5648): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 19:22:53.415+0900 W/AUL_AMD (  454): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 19:23:11.520+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 19:23:11.520+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 19:23:12.880+0900 E/PKGMGR  ( 5791): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 19:23:13.040+0900 E/PKGMGR_SERVER( 5793): pkgmgr-server.c: main(2126) > package manager server start
12-11 19:23:13.170+0900 E/PKGMGR_SERVER( 5793): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1242376356], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-1242376356' '-r' 'org.reolab.blackandwhite'], cookie=[3u9bGkVczyPN/q1J08bUq46O6ns=], backend_flag=[0]
12-11 19:23:13.175+0900 E/PKGMGR  ( 5793): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 19:23:13.175+0900 E/PKGMGR_SERVER( 5793): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 19:23:13.175+0900 E/PKGMGR  ( 5791): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[57910002]
12-11 19:23:13.180+0900 E/PKGMGR_SERVER( 5794): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 19:23:13.495+0900 W/AUL_AMD (  454): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 19:23:13.495+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 19:23:13.500+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:23:13.540+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 19:23:14.165+0900 E/PKGMGR_CERT( 5794): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 19:23:14.185+0900 E/PKGMGR_CERT( 5794): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
12-11 19:23:14.185+0900 E/PKGMGR_CERT( 5794): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
12-11 19:23:14.185+0900 E/PKGMGR_CERT( 5794): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-11 19:23:14.185+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:23:14.185+0900 E/PKGMGR_CERT( 5794): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-11 19:23:14.185+0900 E/PKGMGR_CERT( 5794): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-11 19:23:14.185+0900 E/PKGMGR_CERT( 5794): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-11 19:23:14.220+0900 E/PKGMGR_CERT( 5794): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 19:23:15.150+0900 E/PKGMGR_SERVER( 5793): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:23:17.150+0900 E/PKGMGR_SERVER( 5793): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:23:17.180+0900 E/rpm-installer( 5794): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-11 19:23:19.150+0900 E/PKGMGR_SERVER( 5793): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:23:20.645+0900 E/PKGMGR_SERVER( 5793): pkgmgr-server.c: sighandler(445) > child NORMAL exit [5794]
12-11 19:23:20.655+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:23:20.690+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-11 19:23:20.690+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-11 19:23:20.710+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-11 19:23:20.710+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-11 19:23:20.710+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-11 19:23:20.710+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-11 19:23:20.770+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-11 19:23:20.805+0900 E/APPS    (  713): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-11 19:23:20.870+0900 E/PKGMGR_INFO(  461): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-11 19:23:21.150+0900 E/PKGMGR_SERVER( 5793): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 19:23:21.150+0900 E/PKGMGR_SERVER( 5793): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 19:23:21.205+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 19:23:21.210+0900 E/AUL_AMD (  454): amd_request.c: __app_process_by_pid(193) > pid(4733) is dead. cmd(4) is canceled
12-11 19:23:21.210+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 19:23:21.225+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:23:21.235+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:23:21.235+0900 E/AUL_AMD (  454): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 19:23:21.235+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(1659) > caller pid : 707
12-11 19:23:21.345+0900 E/RESOURCED(  464): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 9
12-11 19:23:21.345+0900 E/RESOURCED(  464): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 19:23:21.350+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 19:23:21.350+0900 W/AUL_PAD ( 1159): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 19:23:21.350+0900 W/AUL_PAD ( 1159): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 19:23:21.390+0900 W/CRASH_MANAGER( 5806): worker.c: worker_job(1199) > 1104733626c61144982940
