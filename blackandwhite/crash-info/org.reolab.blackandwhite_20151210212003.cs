S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 1759
Date: 2015-12-10 21:20:03+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1d

Register Information
r0   = 0xfe400106, r1   = 0x00000000
r2   = 0xe5d1f500, r3   = 0xe5d1f500
r4   = 0xbea90370, r5   = 0x00000168
r6   = 0x00000168, r7   = 0xbea8f888
r8   = 0x00000168, r9   = 0x00000168
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x4044f490, sp   = 0xbea8f860
lr   = 0x403981e8, pc   = 0x400014dc
cpsr = 0x60000030

Memory Information
MemTotal:   490532 KB
MemFree:      9120 KB
Buffers:     15380 KB
Cached:     170020 KB
VmPeak:      93652 KB
VmSize:      93140 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14824 KB
VmRSS:       14824 KB
VmData:      38044 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       21004 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 1759 TID = 1759
1759 1762 1769 

Maps Information
40000000 40003000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
4000b000 40028000 r-xp /lib/ld-2.13.so
40031000 40035000 r-xp /usr/lib/libsys-assert.so
4003e000 40042000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
40052000 40059000 r-xp /usr/lib/libappcore-watch.so.1.1
40062000 40064000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4006d000 4009d000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
4009e000 400b2000 r-xp /usr/lib/libcapi-network-nfc.so.0.2.3
400ba000 400c7000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.55
400cf000 400d4000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
400dc000 400de000 r-xp /usr/lib/libdlog.so.0.0.0
400e6000 40220000 r-xp /usr/lib/libelementary.so.1.7.99
40236000 40305000 r-xp /usr/lib/libevas.so.1.7.99
40329000 40444000 r-xp /lib/libc-2.13.so
40452000 4045a000 r-xp /lib/libgcc_s-4.6.so.1
4045b000 4046f000 r-xp /lib/libpthread-2.13.so
4047a000 40485000 r-xp /lib/libunwind.so.8.0.1
404b2000 404b4000 r-xp /lib/libdl-2.13.so
404bd000 404c9000 r-xp /usr/lib/libaul.so.0.1.0
404d3000 404ea000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
404f2000 404ff000 r-xp /usr/lib/libalarm.so.0.0.0
40508000 4053c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40545000 4054a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40552000 40574000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4057c000 40593000 r-xp /usr/lib/libecore.so.1.7.99
405aa000 405eb000 r-xp /usr/lib/libeina.so.1.7.99
405f4000 40731000 r-xp /usr/lib/libicui18n.so.51.1
40741000 40825000 r-xp /usr/lib/libicuuc.so.51.1
4083a000 4083e000 r-xp /usr/lib/libvconf.so.0.2.45
40846000 40916000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40917000 40941000 r-xp /usr/lib/libdbus-1.so.3.8.12
4094a000 40950000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
40958000 4095e000 r-xp /usr/lib/libwidget.so.1.0.0
40967000 4096c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
40974000 409ab000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
409b4000 409ba000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
409c3000 409dc000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
409e5000 40a0f000 r-xp /usr/lib/libnfc.so.1.0.0
40a18000 40a68000 r-xp /usr/lib/libecore_x.so.1.7.99
40a6a000 40a9b000 r-xp /usr/lib/libmdm.so.1.1.85
40aa3000 40ab9000 r-xp /usr/lib/libnetwork.so.0.0.0
40ac2000 40b95000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40ba0000 40ba5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
40bad000 40c16000 r-xp /lib/libm-2.13.so
40c1f000 40c38000 r-xp /usr/lib/libeet.so.1.7.99
40c49000 40c6b000 r-xp /usr/lib/libecore_evas.so.1.7.99
40c74000 40c79000 r-xp /usr/lib/libecore_file.so.1.7.99
40c81000 40c92000 r-xp /usr/lib/libecore_input.so.1.7.99
40c9a000 40cf7000 r-xp /usr/lib/libedje.so.1.7.99
40d01000 40d0a000 r-xp /usr/lib/libedbus.so.1.7.99
40d12000 40d2c000 r-xp /usr/lib/libecore_con.so.1.7.99
40d35000 40d48000 r-xp /usr/lib/libfribidi.so.0.3.1
40d50000 40d8d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40d96000 40dbe000 r-xp /usr/lib/libfontconfig.so.1.8.0
40dbf000 40e15000 r-xp /usr/lib/libfreetype.so.6.11.3
40e21000 40e77000 r-xp /usr/lib/libpixman-1.so.0.28.2
40e84000 40e87000 r-xp /usr/lib/libbundle.so.0.1.22
40e8f000 40e94000 r-xp /usr/lib/libxdgmime.so.1.1.0
40e9c000 40ed8000 r-xp /usr/lib/libsystemd.so.0.4.0
40ee1000 40ee4000 r-xp /usr/lib/libproc-stat.so.0.2.86
40eec000 40f12000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40f1b000 40f21000 r-xp /usr/lib/libappsvc.so.0.1.0
40f29000 40f2a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40f32000 40f38000 r-xp /lib/librt-2.13.so
40f41000 40f46000 r-xp /usr/lib/libffi.so.5.0.10
40f4e000 40f51000 r-xp /usr/lib/libsmack.so.1.0.0
40f59000 40f6e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40f76000 40feb000 r-xp /usr/lib/libsqlite3.so.0.8.6
40ff5000 41089000 r-xp /usr/lib/libstdc++.so.6.0.16
42623000 4262c000 r-xp /usr/lib/libcom-core.so.0.0.1
42635000 42641000 r-xp /usr/lib/libwidget_service.so.1.0.0
42649000 42652000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4265b000 4273c000 r-xp /usr/lib/libX11.so.6.3.0
42747000 42749000 r-xp /usr/lib/libiniparser.so.0
42752000 4281e000 r-xp /usr/lib/libxml2.so.2.7.8
4282b000 4282d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
42837000 4283d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
42845000 4284d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
42855000 42883000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
4288f000 42896000 r-xp /usr/lib/libXcursor.so.1.0.2
4289e000 428a0000 r-xp /usr/lib/libXdamage.so.1.1.0
428a9000 428ab000 r-xp /usr/lib/libXcomposite.so.1.0.0
428b3000 428b5000 r-xp /usr/lib/libXgesture.so.7.0.0
428bd000 428c0000 r-xp /usr/lib/libXfixes.so.3.1.0
428c8000 428d1000 r-xp /usr/lib/libXi.so.6.1.0
428d9000 428da000 r-xp /usr/lib/libXinerama.so.1.0.0
428e3000 428e9000 r-xp /usr/lib/libXrandr.so.2.2.0
428f2000 428f8000 r-xp /usr/lib/libXrender.so.1.3.0
42900000 42903000 r-xp /usr/lib/libXtst.so.6.1.0
4290c000 42916000 r-xp /usr/lib/libXext.so.6.4.0
4291f000 42927000 r-xp /usr/lib/libmdm-common.so.1.0.89
42928000 4292a000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
42933000 42949000 r-xp /lib/libz.so.1.2.5
42951000 42961000 r-xp /lib/libresolv-2.13.so
42965000 42988000 r-xp /usr/lib/libjpeg.so.8.0.2
429a0000 429a5000 r-xp /usr/lib/libecore_fb.so.1.7.99
429ae000 429b2000 r-xp /usr/lib/libecore_ipc.so.1.7.99
429bc000 429bf000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
429c7000 429ce000 r-xp /usr/lib/libembryo.so.1.7.99
429d6000 429ed000 r-xp /usr/lib/liblua-5.1.so
429f6000 429fc000 r-xp /usr/lib/libecore_imf.so.1.7.99
42a04000 42a05000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
42a0e000 42a52000 r-xp /usr/lib/libcurl.so.4.3.0
42a5b000 42a71000 r-xp /lib/libexpat.so.1.5.2
42a7b000 42a93000 r-xp /usr/lib/libpng12.so.0.50.0
42a9b000 42ab3000 r-xp /usr/lib/liblzma.so.5.0.3
42abb000 42b37000 r-xp /usr/lib/libgcrypt.so.20.0.3
42b44000 42b60000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
42b69000 42b6b000 r-xp /usr/lib/journal/libjournal.so.0.1.0
42b73000 42b7b000 r-xp /usr/lib/libdrm.so.2.4.0
42b83000 42b85000 r-xp /usr/lib/libdri2.so.0.0.0
42b8e000 42b95000 r-xp /usr/lib/libtbm.so.1.0.0
42b9d000 42bb0000 r-xp /usr/lib/libxcb.so.1.1.0
42bb9000 42bd3000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
42bdc000 42d84000 r-xp /usr/lib/libcrypto.so.1.0.0
42d9e000 42da7000 r-xp /usr/lib/libcares.so.2.1.0
42db0000 42dde000 r-xp /usr/lib/libidn.so.11.5.44
42de6000 42e33000 r-xp /usr/lib/libssl.so.1.0.0
42e3f000 42e4a000 r-xp /usr/lib/libgpg-error.so.0.15.0
42e53000 42e55000 r-xp /usr/lib/libiri.so
42e5d000 42e60000 r-xp /lib/libcap.so.2.21
42e68000 42e6f000 r-xp /lib/libcrypt-2.13.so
42e9f000 42ea1000 r-xp /usr/lib/libXau.so.6.0.0
42ea9000 42eb0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
42eba000 42ebc000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
42ec4000 42ecb000 r-xp /usr/lib/libminizip.so.1.0.0
42ed3000 42ee0000 r-xp /usr/lib/libail.so.0.1.0
42ee9000 42eec000 r-xp /lib/libattr.so.1.1.0
4332d000 43b2c000 rw-p [stack:1762]
43b2c000 43b2f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43b37000 43b42000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43e88000 43e9f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
440e9000 440eb000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
450f4000 45900000 rw-p [stack:1769]
bea70000 bea91000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1759)
Call Stack Count: 17
 0: getBTStatus + 0x4b (0x400014dc) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x14dc
 1: update_watch + 0x50 (0x400017ad) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x17ad
 2: create_base_gui + 0x376 (0x40001e07) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1e07
 3: app_create + 0x2c (0x40001669) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1669
 4: (0x400564d5) [/usr/lib/libappcore-watch.so.1] + 0x44d5
 5: (0x4005466b) [/usr/lib/libappcore-watch.so.1] + 0x266b
 6: (0x4094cbff) [/usr/lib/libwidget_provider_app.so.1] + 0x2bff
 7: widget_provider_send_hello_sync + 0x166 (0x42650017) [/usr/lib/libwidget_provider.so.1] + 0x7017
 8: (0x4094cc4b) [/usr/lib/libwidget_provider_app.so.1] + 0x2c4b
 9: widget_provider_init + 0xb8 (0x4264fced) [/usr/lib/libwidget_provider.so.1] + 0x6ced
10: (0x4094d34d) [/usr/lib/libwidget_provider_app.so.1] + 0x334d
11: widget_provider_app_init_sync + 0x2c (0x4094df51) [/usr/lib/libwidget_provider_app.so.1] + 0x3f51
12: watch_core_main + 0xb2 (0x400555e3) [/usr/lib/libappcore-watch.so.1] + 0x35e3
13: watch_app_main + 0xca (0x40056753) [/usr/lib/libappcore-watch.so.1] + 0x4753
14: main + 0xc6 (0x400015d7) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x15d7
15: __libc_start_main + 0x114 (0x4034082c) [/lib/libc.so.6] + 0x1782c
16: (0x40001114) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1114
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
rable_page_cnt: 1
12-10 21:20:01.590+0900 I/wnotib  (  705): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-10 21:20:01.590+0900 I/wnotib  (  705): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1335) > New noti is here. Add it on panel  263, 카카오톡.
12-10 21:20:01.590+0900 I/wnotib  (  705): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 263, application_id: 218, type: 1
12-10 21:20:01.590+0900 I/efl-extension( 1221): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
12-10 21:20:01.600+0900 E/TIZEN_N_SYSTEM_SETTINGS(  705): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-10 21:20:01.600+0900 E/TIZEN_N_SYSTEM_SETTINGS(  705): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 21:20:01.605+0900 E/TIZEN_N_SYSTEM_SETTINGS(  705): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-10 21:20:01.605+0900 E/TIZEN_N_SYSTEM_SETTINGS(  705): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-10 21:20:01.605+0900 I/wnotib  (  705): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4398) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
12-10 21:20:01.605+0900 I/wnotib  (  705): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 263, application_id: 218, type: 13
12-10 21:20:01.605+0900 E/TIZEN_N_SYSTEM_SETTINGS(  705): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-10 21:20:01.605+0900 E/TIZEN_N_SYSTEM_SETTINGS(  705): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 21:20:01.605+0900 E/TIZEN_N_SYSTEM_SETTINGS(  705): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-10 21:20:01.605+0900 E/TIZEN_N_SYSTEM_SETTINGS(  705): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-10 21:20:01.605+0900 I/wnotib  (  705): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-10 21:20:01.615+0900 I/wnotib  (  705): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1370) > This noti will be removed from panel: 263, 카카오톡.
12-10 21:20:01.615+0900 I/wnotib  (  705): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 263, application_id: 218, type: 2
12-10 21:20:01.615+0900 I/wnotib  (  705): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2960) > We don't need to delete the item for second_depth_type: 0.
12-10 21:20:01.615+0900 E/EFL     (  705): elementary<705> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
12-10 21:20:01.615+0900 I/wnotib  (  705): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 263, application_id: 218, type: 12
12-10 21:20:01.615+0900 I/wnotib  (  705): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-10 21:20:01.615+0900 I/wnotibp ( 1221): wnotiboard-popup-view.c: _wnotiboard_popup_create_card_data(3908) > 0x44fe31c0, 0x44fe3040, 0x44fe3040
12-10 21:20:01.620+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-10 21:20:01.620+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 21:20:01.620+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-10 21:20:01.620+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-10 21:20:01.620+0900 W/wnotib  (  705): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 1, num total noti: 2
12-10 21:20:01.620+0900 I/wnotib  (  705): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-10 21:20:01.620+0900 I/wnotib  (  705): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-10 21:20:01.620+0900 I/wnotib  (  705): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-10 21:20:01.620+0900 I/wnotib  (  705): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-10 21:20:01.620+0900 I/wnotib  (  705): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
12-10 21:20:01.620+0900 I/wnotib  (  705): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-10 21:20:01.625+0900 I/wnotib  (  705): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 1.
12-10 21:20:01.625+0900 W/W_HOME  (  705): noti_broker.c: _handler_indicator_update(562) > 0x1
12-10 21:20:01.630+0900 E/E17     (  367): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04c00008)
12-10 21:20:01.630+0900 I/APP_CORE( 1221): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-10 21:20:01.660+0900 E/E17     (  367): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x04c00008)
12-10 21:20:01.680+0900 W/wnotibp ( 1221): w-notification-board-panel-basic-common.c: _wnotib_basic_panel_expand_basic_gl_group_content_get(2215) > Unhandled part: stack.separator
12-10 21:20:01.680+0900 I/wnotibp ( 1221): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-10 21:20:01.680+0900 I/wnotibp ( 1221): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-10 21:20:01.705+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-10 21:20:01.705+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 21:20:01.705+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-10 21:20:01.705+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-10 21:20:01.735+0900 W/APP_CORE( 1221): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00008
12-10 21:20:01.735+0900 W/wnotib  (  705): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 2
12-10 21:20:01.735+0900 W/W_HOME  (  705): noti_broker.c: _handler_noti_indicator_show(478) > 
12-10 21:20:01.740+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1079): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-10 21:20:01.740+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1079): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-10 21:20:01.740+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1079): preference.c: preference_get_double(1214) > preference_get_double(1079) : pedometer_inactive_period error
12-10 21:20:01.740+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1079): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-10 21:20:01.740+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1079): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-10 21:20:01.740+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1079): preference.c: preference_get_double(1214) > preference_get_double(1079) : inactive_10min_precaution_millisec error
12-10 21:20:01.740+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1079): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-10 21:20:01.740+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1079): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-10 21:20:01.740+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1079): preference.c: preference_get_double(1214) > preference_get_double(1079) : inactive_before_10min_precaution_millisec error
12-10 21:20:01.740+0900 W/W_HOME  (  705): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
12-10 21:20:01.740+0900 W/W_HOME  (  705): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 21:20:01.740+0900 W/W_HOME  (  705): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 21:20:01.740+0900 W/W_HOME  (  705): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 21:20:01.740+0900 W/W_HOME  (  705): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
12-10 21:20:01.745+0900 W/wnotib  (  705): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(331) > body is NULL and no attachments found.
12-10 21:20:01.755+0900 E/EFL     ( 1221): evas_main<1221> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-10 21:20:01.755+0900 E/EFL     ( 1221): evas_main<1221> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-10 21:20:01.755+0900 E/EFL     ( 1221): evas_main<1221> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-10 21:20:01.755+0900 I/wnotibp ( 1221): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-10 21:20:01.755+0900 I/wnotibp ( 1221): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-10 21:20:01.760+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-10 21:20:01.760+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 21:20:01.760+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-10 21:20:01.760+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1221): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-10 21:20:01.775+0900 I/MALI    (  705): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442b71c0] swap changed from sync to async
12-10 21:20:01.820+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-10 21:20:01.825+0900 W/wnotibp ( 1221): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3641) > ::UI:: VI TYPE : 2
12-10 21:20:01.825+0900 W/wnotibp ( 1221): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3647) > alert_type : 1, is_source_companion: 1
12-10 21:20:01.825+0900 W/TIZEN_N_RECORDER( 1221): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
12-10 21:20:01.825+0900 W/wnotibp ( 1221): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1258) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
12-10 21:20:01.835+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 21:20:01.845+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 21:20:01.845+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-10 21:20:01.845+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 690
12-10 21:20:01.845+0900 I/wnotibp ( 1221): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1267) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
12-10 21:20:01.850+0900 W/wnotibp ( 1221): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1301) > ::APP:: Determined feedback: sound 0, vibration: 0
12-10 21:20:01.850+0900 I/wnotibp ( 1221): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1305) > No feedback.
12-10 21:20:01.860+0900 E/RESOURCED(  485): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-10 21:20:01.860+0900 E/RESOURCED(  485): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-10 21:20:01.860+0900 I/wnotibp ( 1221): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1036) > fully_obscured: 0 [0x4c00008 0x4c0000a 0x4c00008 ]
12-10 21:20:01.860+0900 I/APP_CORE( 1221): appcore-efl.c: __do_app(429) > [APP 1221] Event: RESUME State: RUNNING
12-10 21:20:01.865+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-10 21:20:01.865+0900 W/AUL_PAD ( 1220): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-10 21:20:01.865+0900 W/AUL_PAD ( 1220): launchpad.c: __send_result_to_caller(265) > Check app launching
12-10 21:20:01.895+0900 W/wnotibp ( 1221): wnotiboard-popup.c: wnotiboard_popup_view_lock(855) > ::UI:: [[[ ===> already [small popup] is LOCK, 0010 ]]]
12-10 21:20:01.895+0900 W/wnotibp ( 1221): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_pre_cb(2168) > ::UI:: start showing animation
12-10 21:20:01.935+0900 I/CAPI_WATCH_APPLICATION( 1332): watch_app_main.c: watch_app_main(382) > watch_app_main
12-10 21:20:01.960+0900 E/TBM     ( 1332): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-10 21:20:01.970+0900 E/RESOURCED(  485): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.reolab.blackandwhite
12-10 21:20:01.975+0900 W/WATCH_CORE( 1196): appcore-watch.c: __widget_resume(1012) > widget_resume
12-10 21:20:01.975+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppResume(725) > 
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [2] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [7]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [17]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [17]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [17] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [30]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [30] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [32]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [32]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [32] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [34]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [34]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [34] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [73]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [73] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [77]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [77] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [3]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [3] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [1]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [1] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [4]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [4] to pending list
12-10 21:20:01.975+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:01.975+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [6]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [6] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [7]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [8]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [8] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [9]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [9] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [10]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [10] to pending list
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [28]
12-10 21:20:01.975+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: AddPendingChanges(1053) > added [28] to pending list
12-10 21:20:01.980+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-10 21:20:01.980+0900 W/AUL_AMD (  475): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-10 21:20:02.050+0900 W/WATCH_CORE( 1332): appcore-watch.c: __widget_create(958) > widget_create
12-10 21:20:02.060+0900 E/WIDGET_VIEWER(  705): client.c: master_created(1712) > [SECURE_LOG] [120.483307] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_705_120.483307.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-10 21:20:02.060+0900 W/W_HOME  (  705): dbox.c: _widget_created_cb(238) > widget resume:0x49d12218
12-10 21:20:02.060+0900 E/WIDGET_VIEWER(  705): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
12-10 21:20:02.090+0900 E/WIDGET_VIEWER(  705): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-10 21:20:02.090+0900 E/WIDGET_EVAS(  705): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-10 21:20:02.140+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:02.140+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:02.140+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:02.140+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:02.140+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 21:20:02.140+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:20:02.200+0900 W/wnotibp ( 1221): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_show_animator_cb(2078) > ::UI:: end show animation
12-10 21:20:02.200+0900 W/wnotibp ( 1221): wnotiboard-popup.c: wnotiboard_popup_view_unlock(908) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
12-10 21:20:02.200+0900 W/wnotibp ( 1221): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 1 1
12-10 21:20:02.205+0900 E/wnoti-service(  856): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
12-10 21:20:02.205+0900 E/wnoti-service(  856): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 2
12-10 21:20:02.205+0900 E/wnoti-service(  856): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-10 21:20:02.210+0900 E/wnoti-proxy( 1221): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
12-10 21:20:02.210+0900 E/wnotibp ( 1221): wnotiboard-popup-data.c: wnotibp_get_alert_list(908) > ::DATA:: No categories available.
12-10 21:20:02.210+0900 W/wnotibp ( 1221): wnotiboard-popup-data.c: wnotibp_get_alert_list(911) > ::DATA:: read alert list : 0, list count : 1
12-10 21:20:02.260+0900 I/CAPI_NETWORK_WIFI( 1332): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 21:20:02.270+0900 I/CAPI_NETWORK_WIFI( 1332): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 21:20:02.310+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:02.310+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:02.310+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:02.310+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:02.445+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-10 21:20:02.445+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-10 21:20:02.460+0900 W/WG-CONSUMER( 1103): [32m[F:SAPProxy.cpp     L:  620][_WARN][Phone->Gear] Got Disconnect. uwServiceHandle(1) wStatusCode(0)[0m
12-10 21:20:02.460+0900 W/WG-CONSUMER( 1103): [32m[F:ConnectionInfo.c L: 1238][_WARN][TX][Phone->Gear] Got Disconnect. uwServiceHandle(1) wStatusCode(0)[0m
12-10 21:20:02.460+0900 W/WG-CONSUMER( 1103): [32m[F:ConnectionInfo.c L: 1239][_WARN][TX]Connection Info. AgentID(48014) ServiceHandle(1) CurrentState=SM_STATE_ESTABLISHED[0m
12-10 21:20:02.460+0900 W/WG-CONSUMER( 1103): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=1 pConnected=0x42ea4100[0m
12-10 21:20:02.460+0900 W/WG-CONSUMER( 1103): [34m[F:PeerList.cpp     L:  103][_HIGH][TX]This=0x42ea4100 PeerAgent(0x42ea4104) bSet(1)[0m
12-10 21:20:02.460+0900 W/WG-CONSUMER( 1103): [34m[F:PeerList.cpp     L:  104][_HIGH][TX]  DeviceID=1 PeerAgentID=49677 ServiceHandle=1[0m
12-10 21:20:02.465+0900 W/WG-CONSUMER( 1103): [34m[F:PeerList.cpp     L:  106][_HIGH][TX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=2.1[0m
12-10 21:20:02.465+0900 W/WG-CONSUMER( 1103): [34m[F:PeerList.cpp     L:  107][_HIGH][TX]  ConnectType(1) : BT|[0m
12-10 21:20:02.465+0900 W/WG-CONSUMER( 1103): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_ESTABLISHED->SM_STATE_REGISTER_AGENT[0m
12-10 21:20:02.465+0900 W/WG-CONSUMER( 1103): [34m[F:TransferCtrl.cpp L:  210][_HIGH]CTransferCtrl::OnTerminated. Cause=TERMINATION_FROM_PEER[0m
12-10 21:20:02.470+0900 W/WG-CONSUMER( 1103): [34m[F:TransferCtrl.cpp L:  218][_HIGH]Malloc Trimmed[0m
12-10 21:20:02.490+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:02.490+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:02.490+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:02.490+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:02.565+0900 W/WG-CONSUMER( 1103): [32m[F:SAPProxy.cpp     L:  620][_WARN][Phone->Gear] Got Disconnect. uwServiceHandle(2) wStatusCode(0)[0m
12-10 21:20:02.565+0900 W/WG-CONSUMER( 1103): [32m[F:ConnectionInfo.c L: 1238][_WARN][RX][Phone->Gear] Got Disconnect. uwServiceHandle(2) wStatusCode(0)[0m
12-10 21:20:02.565+0900 W/WG-CONSUMER( 1103): [32m[F:ConnectionInfo.c L: 1239][_WARN][RX]Connection Info. AgentID(48015) ServiceHandle(2) CurrentState=SM_STATE_ESTABLISHED[0m
12-10 21:20:02.565+0900 W/WG-CONSUMER( 1103): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=1 pConnected=0x42eabcc0[0m
12-10 21:20:02.565+0900 W/WG-CONSUMER( 1103): [34m[F:PeerList.cpp     L:  103][_HIGH][RX]This=0x42eabcc0 PeerAgent(0x42eabcc4) bSet(1)[0m
12-10 21:20:02.565+0900 W/WG-CONSUMER( 1103): [34m[F:PeerList.cpp     L:  104][_HIGH][RX]  DeviceID=1 PeerAgentID=23056 ServiceHandle=2[0m
12-10 21:20:02.565+0900 W/WG-CONSUMER( 1103): [34m[F:PeerList.cpp     L:  106][_HIGH][RX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=3.0[0m
12-10 21:20:02.565+0900 W/WG-CONSUMER( 1103): [34m[F:PeerList.cpp     L:  107][_HIGH][RX]  ConnectType(1) : BT|[0m
12-10 21:20:02.565+0900 W/WG-CONSUMER( 1103): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_ESTABLISHED->SM_STATE_REGISTER_AGENT[0m
12-10 21:20:02.565+0900 W/WG-CONSUMER( 1103): [34m[F:ReceiverCtrl.cpp L:  460][_HIGH]CReceiverCtrl::OnTerminated. Cause=TERMINATION_FROM_PEER[0m
12-10 21:20:02.670+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:02.670+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:02.670+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:02.670+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:02.785+0900 W/CRASH_MANAGER( 1745): worker.c: worker_job(1199) > 1101332626c611449750002
12-10 21:20:02.850+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-10 21:20:02.850+0900 E/AUL_AMD (  475): amd_request.c: __app_process_by_pid(193) > pid(1332) is dead. cmd(4) is canceled
12-10 21:20:02.855+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-10 21:20:02.865+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 21:20:02.870+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:02.870+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:02.870+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:02.870+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:02.880+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 21:20:02.880+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-10 21:20:02.880+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 690
12-10 21:20:02.915+0900 E/RESOURCED(  485): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-10 21:20:02.920+0900 E/RESOURCED(  485): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-10 21:20:02.920+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-10 21:20:02.970+0900 W/AUL_PAD ( 1220): launchpad.c: __launchpad_main_loop(526) > Candidate is not prepared, enter legacy logic
12-10 21:20:02.970+0900 W/AUL_PAD ( 1220): launchpad.c: __send_result_to_caller(265) > Check app launching
12-10 21:20:02.970+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2037) > Launch with legacy way : no launchpad
12-10 21:20:02.975+0900 W/AUL_AMD (  475): amd_launch.c: start_process(573) > child process: 1759
12-10 21:20:02.995+0900 E/RESOURCED( 1079): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
12-10 21:20:02.995+0900 E/AUL     ( 1079): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
12-10 21:20:02.995+0900 E/CAPI_APPFW_APP_MANAGER( 1079): app_manager.c: app_manager_error(76) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
12-10 21:20:03.025+0900 W/AUL_AMD (  475): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 1759
12-10 21:20:03.035+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1332
12-10 21:20:03.055+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:03.055+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:03.055+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:03.055+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:03.055+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 21:20:03.055+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:20:03.130+0900 I/CAPI_WATCH_APPLICATION( 1759): watch_app_main.c: watch_app_main(382) > watch_app_main
12-10 21:20:03.215+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 21:20:03.220+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1759
12-10 21:20:03.225+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 21:20:03.245+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:03.245+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:03.245+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:03.245+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:03.310+0900 E/TBM     ( 1759): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-10 21:20:03.360+0900 W/WATCH_CORE( 1759): appcore-watch.c: __widget_create(958) > widget_create
12-10 21:20:03.365+0900 E/WIDGET_VIEWER(  705): client.c: master_created(1712) > [SECURE_LOG] [120.483307] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_705_120.483307.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263030:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-10 21:20:03.365+0900 E/WIDGET_VIEWER(  705): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[120.483307] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_705_120.483307.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263030:4] gbar_fname[]
12-10 21:20:03.375+0900 E/wnoti-service(  856): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
12-10 21:20:03.385+0900 E/WIDGET_VIEWER(  705): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-10 21:20:03.385+0900 E/WIDGET_EVAS(  705): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-10 21:20:03.435+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:03.435+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:03.435+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:03.435+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:03.490+0900 I/AUL_PAD ( 1758): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-10 21:20:03.595+0900 I/CAPI_NETWORK_WIFI( 1759): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 21:20:03.610+0900 I/CAPI_NETWORK_WIFI( 1759): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 21:20:03.630+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:03.630+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:03.630+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:03.630+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:03.830+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:03.830+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:03.830+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:03.830+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:04.015+0900 E/W_HOME  (  705): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-10 21:20:04.025+0900 I/CAPI_WATCH_APPLICATION( 1196): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:20:04.025+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:20:04.025+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:20:04.025+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:20:04.025+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 21:20:04.025+0900 I/watchface-viewer( 1196): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:20:04.025+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-10 21:20:04.025+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-10 21:20:04.035+0900 W/W_HOME  (  705): clock_view.c: clock_view_attach(512) > changed pause/resume option -> manual
12-10 21:20:04.035+0900 E/EFL     (  705): elementary<705> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c885c8), origin_x(0), origin_y(0)
12-10 21:20:04.035+0900 W/W_HOME  (  705): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-10 21:20:04.035+0900 W/W_HOME  (  705): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 21:20:04.040+0900 E/EFL     (  705): elementary<705> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c885c8), origin_x(0), origin_y(0)
12-10 21:20:04.040+0900 W/W_HOME  (  705): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-10 21:20:04.045+0900 W/W_HOME  (  705): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 21:20:04.045+0900 W/W_HOME  (  705): clock_view.c: clock_view_attach(529) > changed pause/resume option -> automatic
12-10 21:20:04.045+0900 W/W_HOME  (  705): clock_manager.c: clock_manager_clock_set(255) > attached clock isn't cleaned-up, yet
12-10 21:20:04.045+0900 E/W_HOME  (  705): page.c: _page_clip_del(240) > (!page_info) -> _page_clip_del() return
12-10 21:20:04.050+0900 E/W_HOME  (  705): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
12-10 21:20:04.050+0900 W/W_HOME  (  705): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
12-10 21:20:04.050+0900 E/W_HOME  (  705): dbox.c: del_cb(225) > Add viewer has no info: com.samsung.watchface
12-10 21:20:04.055+0900 W/W_HOME  (  705): cfwd.c: cfwd_get_icon_status(362) > 
12-10 21:20:04.055+0900 W/W_HOME  (  705): ============================
12-10 21:20:04.055+0900 W/W_HOME  (  705): multi_sim_category:0
12-10 21:20:04.055+0900 W/W_HOME  (  705): multi_sim_model:0
12-10 21:20:04.055+0900 W/W_HOME  (  705): support_callforward_auto:0
12-10 21:20:04.055+0900 W/W_HOME  (  705): conn_status:1
12-10 21:20:04.055+0900 W/W_HOME  (  705): remote_call_forward_auto:0
12-10 21:20:04.055+0900 W/W_HOME  (  705): auto_call_forward_status:0
12-10 21:20:04.055+0900 W/W_HOME  (  705): support_callforward_reverse:0
12-10 21:20:04.055+0900 W/W_HOME  (  705): reverse_call_forward_auto:0
12-10 21:20:04.055+0900 W/W_HOME  (  705): fwd_type:
12-10 21:20:04.055+0900 W/W_HOME  (  705): ============================
12-10 21:20:04.055+0900 W/W_HOME  (  705): 
12-10 21:20:04.055+0900 W/W_HOME  (  705): clock_view_indicator.c: _view_call_fw_icon(131) > call fwd status:0
12-10 21:20:04.060+0900 E/W_HOME  (  705): clock_event.c: _flightmode_state_get(417) > Failed to get VCONFKEY_TELEPHONY_FLIGHT_MODE:db/telephony/flight_mode
12-10 21:20:04.060+0900 E/W_HOME  (  705): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-10 21:20:04.060+0900 W/W_HOME  (  705): noti_broker.c: _clock_attached_cb(804) > 1
12-10 21:20:04.060+0900 W/W_HOME  (  705): cs_broker.c: _clock_view_attached_cb(231) > 
12-10 21:20:04.060+0900 W/W_HOME  (  705): scroller.c: scroller_unfreeze(1860) > unfreezed:40043c11
12-10 21:20:04.065+0900 W/W_HOME  (  705): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,hide
12-10 21:20:04.065+0900 W/W_HOME  (  705): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 21:20:04.065+0900 W/W_HOME  (  705): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 21:20:04.070+0900 I/CLOCK-LIST(  705): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(264) > send watch_list_event, watch_list_out
12-10 21:20:04.070+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 21:20:04.070+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 21:20:04.070+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 21:20:04.070+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 21:20:04.070+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 21:20:04.070+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 21:20:04.070+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [org.reolab.blackandwhite:watchface::messageport::event]
12-10 21:20:04.070+0900 E/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(354) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-10 21:20:04.070+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 21:20:04.070+0900 E/MESSAGE_PORT(  705): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
12-10 21:20:04.070+0900 E/CLOCK-LIST(  705): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(268) > message_port_send_message returns -18022399(feed0001)
12-10 21:20:04.080+0900 I/efl-extension(  705): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8ab48, elm_box, _activated_obj : 0x45c8ab48, activated : 1
12-10 21:20:04.080+0900 E/wnotib  (  705): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-10 21:20:04.080+0900 I/wnotib  (  705): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5125) > Return true for 263, 218.
12-10 21:20:04.080+0900 I/wnotib  (  705): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
12-10 21:20:04.080+0900 I/efl-extension(  705): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x49b6a208, obj: 0x49b6a208
12-10 21:20:04.080+0900 I/efl-extension(  705): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-10 21:20:04.080+0900 I/efl-extension(  705): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-10 21:20:04.080+0900 I/efl-extension(  705): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x49b6a208, elm_scroller, func : 0x4072fe19
12-10 21:20:04.080+0900 I/efl-extension(  705): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-10 21:20:04.080+0900 I/efl-extension(  705): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-10 21:20:04.080+0900 I/efl-extension(  705): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x49bbe130, elm_image, func : 0x4072fe19
12-10 21:20:04.080+0900 I/efl-extension(  705): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-10 21:20:04.080+0900 I/efl-extension(  705): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(841) > [0x49b6a208 : elm_scroller] rotary callabck is deleted
12-10 21:20:04.165+0900 W/WATCH_CORE( 1196): appcore-watch.c: __widget_pause(1001) > widget_pause
12-10 21:20:04.165+0900 E/watchface-loader( 1196): watchface-loader.cpp: OnAppPause(717) > 
12-10 21:20:04.165+0900 E/watchface-viewer( 1196): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-10 21:20:04.165+0900 E/watchface-viewer( 1196): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-10 21:20:04.165+0900 E/watchface-viewer( 1196): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-10 21:20:04.165+0900 E/watchface-viewer( 1196): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-10 21:20:04.165+0900 E/watchface-viewer( 1196): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-10 21:20:04.165+0900 E/watchface-viewer( 1196): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-10 21:20:04.255+0900 W/CRASH_MANAGER( 1745): worker.c: worker_job(1199) > 1101759626c61144975000
