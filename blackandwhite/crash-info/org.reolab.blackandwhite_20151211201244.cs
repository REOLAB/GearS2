S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 8598
Date: 2015-12-11 20:12:44+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb0

Register Information
r0   = 0x000000b1, r1   = 0x000000b0
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x400021e3
r6   = 0xbea92178, r7   = 0x000000b1
r8   = 0x00000000, r9   = 0x42ef8418
r10  = 0x400021e2, fp   = 0xbea9216c
ip   = 0x00000000, sp   = 0xbea91c08
lr   = 0x403685b8, pc   = 0x4039bdc4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     15492 KB
Buffers:     22944 KB
Cached:     176328 KB
VmPeak:     138448 KB
VmSize:     137936 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16096 KB
VmRSS:       16096 KB
VmData:      54452 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       21004 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 8598 TID = 8598
8598 8601 8608 

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
4332d000 43b2c000 rw-p [stack:8601]
43b2c000 43b2f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43b37000 43b42000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43e88000 43e9f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
440e9000 440eb000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
450f4000 458f3000 rw-p [stack:8608]
bea73000 bea94000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8598)
Call Stack Count: 1
 0: strlen + 0x4 (0x4039bdc4) [/lib/libc.so.6] + 0x72dc4
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
lity.c: lock_pm(490) > >> lock_pm status : 2
12-11 20:12:39.505+0900 E/wnoti-service(  862): wnoti-db-server.c: insert_panel_asset(3440) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-11 20:12:39.505+0900 E/wnoti-service(  862): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/582
12-11 20:12:39.515+0900 E/wnoti-service(  862): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 2
12-11 20:12:39.515+0900 E/wnoti-service(  862): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 2013
12-11 20:12:39.515+0900 E/wnoti-service(  862): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-11 20:12:39.520+0900 E/wnoti-service(  862): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/582
12-11 20:12:39.520+0900 E/wnoti-service(  862): wnoti-db-server.c: check_asset_images(3974) > summary_bg_image : /opt/usr/data/wnoti/.crop_382.png
12-11 20:12:39.525+0900 E/wnoti-service(  862): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/580
12-11 20:12:39.585+0900 E/wnoti-service(  862): wnoti-db-server.c: wnoti_is_check_notification_update(4451) > 5/230281
12-11 20:12:39.585+0900 E/wnoti-service(  862): wnoti-sap-client.c: _add_exception_handling(581) > type : 5, application_id : 218
12-11 20:12:39.590+0900 W/W_HOME  (  714): event_manager.c: _home_scroll_cb(564) > scroll,done
12-11 20:12:39.600+0900 E/wnoti-service(  862): wnoti-sap-client.c: publish_received_noti(1839) > application status : 0
12-11 20:12:39.600+0900 E/wnoti-service(  862): wnoti-sap-client.c: publish_received_noti(1848) > 5, category : 0, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 230289, noti_flag : 0, g_span_version : 1
12-11 20:12:39.600+0900 E/wnoti-service(  862): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-11 20:12:39.635+0900 E/wnoti-service(  862): wnoti-db-server.c: set_global_noti_count(1555) > pre_count : 1, count : 1
12-11 20:12:39.635+0900 E/wnoti-service(  862): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 20:12:39.695+0900 I/CAPI_WIDGET_APPLICATION(  779): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
12-11 20:12:39.695+0900 I/CAPI_WIDGET_APPLICATION(  779): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
12-11 20:12:39.965+0900 W/W_HOME  (  714): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
12-11 20:12:40.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(85) ev->cur.canvas.y(233)
12-11 20:12:40.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.070+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2328552 button=1 downs=1
12-11 20:12:40.080+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.080+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(89) ev->cur.canvas.y(230)
12-11 20:12:40.085+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.090+0900 E/EFL     (  779): evas_main<779> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2328551 button=1 downs=1
12-11 20:12:40.130+0900 I/wnoti-service(  862): wnoti-msg-builder.c: _publish_notification(1453) > operation_type : 0, source : 0, application_id : 0, display_count : 0
12-11 20:12:40.140+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.140+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(99) ev->cur.canvas.y(227)
12-11 20:12:40.140+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.140+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.140+0900 E/wnoti-proxy( 2286): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2286, caller_id : 0, listener_type : 0
12-11 20:12:40.140+0900 I/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1488) > Handle this change type in idler.
12-11 20:12:40.140+0900 I/wnotibp ( 2286): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(918) > ::DATA:: remove notification data, 2837
12-11 20:12:40.140+0900 I/wnotibp ( 2286): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(948) > ::DATA:: CHECK DATA : 0, 0
12-11 20:12:40.145+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(113) ev->cur.canvas.y(226)
12-11 20:12:40.145+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.145+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.145+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(131) ev->cur.canvas.y(226)
12-11 20:12:40.145+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.145+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-11 20:12:40.145+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88018), type(elm_scroller)
12-11 20:12:40.145+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-11 20:12:40.145+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88018), type(elm_scroller)
12-11 20:12:40.165+0900 W/W_HOME  (  714): home_navigation.c: _is_rightedge(188) > (1080 360) not right edge: 0 0 0x47d0ff58 -> 360 0 0x47752950
12-11 20:12:40.165+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.170+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(160) ev->cur.canvas.y(226)
12-11 20:12:40.170+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.170+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.170+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(200) ev->cur.canvas.y(228)
12-11 20:12:40.170+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.170+0900 W/W_HOME  (  714): event_manager.c: _home_scroll_cb(564) > scroll,start
12-11 20:12:40.170+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88018), locked_x(0)
12-11 20:12:40.170+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88018)
12-11 20:12:40.175+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.175+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.195+0900 E/wnoti-proxy(  714): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 714, caller_id : 0, listener_type : 0
12-11 20:12:40.200+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 0, op_type: 0, category_id: 0, display count: 0
12-11 20:12:40.200+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1548) > Handle this change type in idler.
12-11 20:12:40.200+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1568) > Notiboard VI is ongoing. Postpone the board update.
12-11 20:12:40.200+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.205+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(242) ev->cur.canvas.y(229)
12-11 20:12:40.205+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.205+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2328638 button=1 downs=0
12-11 20:12:40.205+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88018), type(elm_scroller)
12-11 20:12:40.215+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.220+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.240+0900 W/W_HOME  (  714): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
12-11 20:12:40.240+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.245+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.260+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.265+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.305+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.310+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.360+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.360+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.380+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1684) > Do the postponed update job.
12-11 20:12:40.380+0900 I/efl-extension(  714): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88018 : elm_scroller] CurrentPage(2)
12-11 20:12:40.430+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1051) > idler for type: 0
12-11 20:12:40.460+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 20:12:40.470+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 20:12:40.470+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 20:12:40.475+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 20:12:40.480+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1098) > unread_count: 4
12-11 20:12:40.480+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(622) > category_id: 285, application_id: 218, application_name: 카카오톡, time_stamp: 1449831761, content_id: 0, spannable_string_version: 1
12-11 20:12:40.480+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 20:12:40.480+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 20:12:40.480+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 20:12:40.485+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 20:12:40.485+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 20:12:40.490+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 20:12:40.490+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 20:12:40.490+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 20:12:40.490+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 20:12:40.495+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 20:12:40.495+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 20:12:40.495+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 20:12:40.495+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 20:12:40.500+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 20:12:40.500+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 20:12:40.500+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 20:12:40.500+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 20:12:40.500+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 20:12:40.500+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 20:12:40.500+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 20:12:40.500+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 20:12:40.505+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 20:12:40.505+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 20:12:40.505+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 20:12:40.505+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1335) > New noti is here. Add it on panel  285, 카카오톡.
12-11 20:12:40.505+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 1
12-11 20:12:40.525+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 20:12:40.530+0900 E/EFL     (  779): evas_main<779> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2328641 button=1 downs=0
12-11 20:12:40.535+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:12:40.535+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 20:12:40.535+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 20:12:40.535+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4398) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
12-11 20:12:40.535+0900 I/CAPI_WIDGET_APPLICATION(  779): widget_app.c: __provider_pause_cb(296) > widget obj was paused
12-11 20:12:40.535+0900 I/CAPI_WIDGET_APPLICATION(  779): widget_app.c: __check_status_for_cgroup(145) > enter background group
12-11 20:12:40.535+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 13
12-11 20:12:40.540+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 20:12:40.540+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:12:40.540+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 20:12:40.540+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 20:12:40.540+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 20:12:40.555+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1370) > This noti will be removed from panel: 285, 카카오톡.
12-11 20:12:40.555+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 2
12-11 20:12:40.555+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2960) > We don't need to delete the item for second_depth_type: 0.
12-11 20:12:40.560+0900 E/EFL     (  714): elementary<714> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
12-11 20:12:40.560+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 12
12-11 20:12:40.560+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 20:12:40.565+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 1, num total noti: 4
12-11 20:12:40.565+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-11 20:12:40.565+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-11 20:12:40.565+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-11 20:12:40.570+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-11 20:12:40.570+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
12-11 20:12:40.570+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-11 20:12:40.570+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 1.
12-11 20:12:40.570+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_update(562) > 0x1
12-11 20:12:40.645+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 1
12-11 20:12:40.645+0900 W/W_HOME  (  714): noti_broker.c: _handler_noti_indicator_show(478) > 
12-11 20:12:40.645+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.645+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(107) ev->cur.canvas.y(227)
12-11 20:12:40.650+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.650+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2329083 button=1 downs=1
12-11 20:12:40.650+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(110) ev->cur.canvas.y(226)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(118) ev->cur.canvas.y(226)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(128) ev->cur.canvas.y(225)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(155) ev->cur.canvas.y(223)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88018), type(elm_scroller)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-11 20:12:40.655+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88018), type(elm_scroller)
12-11 20:12:40.660+0900 E/W_HOME  (  714): home_navigation.c: _vi_init(939) > (scroller_info->vi_info.on == 1) -> _vi_init() return
12-11 20:12:40.660+0900 W/W_HOME  (  714): home_navigation.c: _is_rightedge(188) > (720 360) not right edge: 0 0 0x47cb1920 -> 360 0 0x47d0ff58
12-11 20:12:40.665+0900 W/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(331) > body is NULL and no attachments found.
12-11 20:12:40.705+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.705+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(200) ev->cur.canvas.y(223)
12-11 20:12:40.710+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.710+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 20:12:40.710+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(248) ev->cur.canvas.y(223)
12-11 20:12:40.710+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 20:12:40.710+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2329157 button=1 downs=0
12-11 20:12:40.710+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88018), type(elm_scroller)
12-11 20:12:40.715+0900 E/EFL     (  770): evas_main<770> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2329103 button=1 downs=1
12-11 20:12:40.715+0900 E/EFL     (  770): evas_main<770> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 20:12:40.715+0900 E/EFL     (  770): evas_main<770> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 20:12:40.715+0900 E/EFL     (  770): evas_main<770> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 20:12:40.715+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.720+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.720+0900 E/W_HOME  (  714): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
12-11 20:12:40.735+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.735+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.750+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.750+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.755+0900 E/EFL     (  770): evas_main<770> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2329198 button=1 downs=0
12-11 20:12:40.770+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.770+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.780+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.785+0900 W/WATCH_CORE( 8417): appcore-watch.c: __widget_resume(1012) > widget_resume
12-11 20:12:40.785+0900 I/CAPI_WATCH_APPLICATION( 8417): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 20:12:40.785+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.795+0900 W/W_HOME  (  714): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-11 20:12:40.795+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 20:12:40.800+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.800+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.805+0900 I/GESTURE (  143): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-11 20:12:40.815+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.815+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.830+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 20:12:40.830+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 20:12:40.835+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-11 20:12:40.835+0900 I/efl-extension(  714): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88018 : elm_scroller] CurrentPage(1)
12-11 20:12:40.840+0900 I/CAPI_NETWORK_WIFI( 8417): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 20:12:40.875+0900 I/CAPI_NETWORK_WIFI( 8417): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 20:12:40.950+0900 E/blackandwhite( 8417): blackandwhite.c: update_watch(149) > colorT : 1
12-11 20:12:40.990+0900 W/W_HOME  (  714): event_manager.c: _home_scroll_cb(564) > scroll,done
12-11 20:12:41.125+0900 W/CRASH_MANAGER( 8377): worker.c: worker_job(1199) > 1108417626c611449832360
12-11 20:12:41.135+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:12:41.335+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 20:12:41.335+0900 W/W_HOME  (  714): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
12-11 20:12:41.340+0900 E/AUL     (  475): app_sock.c: __connect_client_sock(194) > connect error: 111
12-11 20:12:41.340+0900 E/AUL     (  475): app_sock.c: __create_client_sock(160) > cannot connect the client socket: 111
12-11 20:12:41.440+0900 E/AUL     (  475): app_sock.c: __connect_client_sock(194) > connect error: 111
12-11 20:12:41.440+0900 E/AUL     (  475): app_sock.c: __create_client_sock(160) > cannot connect the client socket: 111
12-11 20:12:41.475+0900 E/RESOURCED(  481): procfs.c: proc_get_oom_score_adj(124) > [proc_get_oom_score_adj,124] fopen /proc/8417/oom_score_adj failed
12-11 20:12:41.475+0900 E/RESOURCED(  481): proc-main.c: resourced_proc_status_change(860) > [resourced_proc_status_change,860] Empty pid or process not exists. 8417
12-11 20:12:41.740+0900 E/AUL     (  475): app_sock.c: __connect_client_sock(194) > connect error: 111
12-11 20:12:41.740+0900 E/AUL     (  475): app_sock.c: __create_client_sock(160) > cannot connect the client socket: 111
12-11 20:12:41.740+0900 E/AUL_AMD (  475): amd_launch.c: _term_app(1015) > fail to killing - 8417
12-11 20:12:41.740+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 8417
12-11 20:12:41.750+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 20:12:41.765+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:12:41.775+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:12:41.775+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 20:12:41.775+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 703
12-11 20:12:41.790+0900 E/RESOURCED(  481): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-11 20:12:41.790+0900 E/RESOURCED(  481): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 20:12:41.800+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 20:12:41.800+0900 W/AUL_PAD ( 1208): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 20:12:41.800+0900 W/AUL_PAD ( 1208): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 20:12:41.840+0900 I/CAPI_WATCH_APPLICATION( 8519): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 20:12:41.865+0900 E/TBM     ( 8519): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 20:12:41.905+0900 E/RESOURCED(  481): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.reolab.blackandwhite
12-11 20:12:41.940+0900 W/WATCH_CORE( 8519): appcore-watch.c: __widget_create(958) > widget_create
12-11 20:12:41.945+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1712) > [SECURE_LOG] [14.824063] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263112:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 20:12:41.945+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[14.824063] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263112:4] gbar_fname[]
12-11 20:12:41.965+0900 E/WIDGET_VIEWER(  714): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 20:12:41.965+0900 E/WIDGET_EVAS(  714): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 20:12:42.095+0900 I/CAPI_NETWORK_WIFI( 8519): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 20:12:42.110+0900 I/CAPI_NETWORK_WIFI( 8519): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 20:12:42.290+0900 E/blackandwhite( 8519): blackandwhite.c: update_watch(149) > colorT : 1
12-11 20:12:42.305+0900 W/WATCH_CORE( 8519): appcore-watch.c: __widget_create(976) > widget_create done
12-11 20:12:42.360+0900 I/WATCH_CORE( 8519): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 20:12:42.365+0900 I/WATCH_CORE( 8519): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 20:12:42.365+0900 I/WATCH_CORE( 8519): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 20:12:42.415+0900 W/W_HOME  (  714): gesture.c: _widget_updated_cb(190) > widget updated
12-11 20:12:42.415+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-11 20:12:42.415+0900 W/W_HOME  (  714): gesture.c: _manual_render(176) > 
12-11 20:12:42.425+0900 W/W_HOME  (  714): gesture.c: _manual_render(176) > 
12-11 20:12:42.440+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 0
12-11 20:12:42.455+0900 W/WATCH_CORE( 8519): appcore-watch.c: __widget_resume(1012) > widget_resume
12-11 20:12:42.465+0900 I/CAPI_WATCH_APPLICATION( 8519): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 20:12:42.500+0900 I/CAPI_NETWORK_WIFI( 8519): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 20:12:42.535+0900 I/CAPI_NETWORK_WIFI( 8519): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 20:12:42.580+0900 E/blackandwhite( 8519): blackandwhite.c: update_watch(149) > colorT : 1
12-11 20:12:42.905+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 20:12:42.905+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 20:12:42.995+0900 I/CAPI_WATCH_APPLICATION( 8519): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 20:12:43.010+0900 I/CAPI_NETWORK_WIFI( 8519): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 20:12:43.030+0900 I/CAPI_NETWORK_WIFI( 8519): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 20:12:43.075+0900 E/blackandwhite( 8519): blackandwhite.c: update_watch(149) > colorT : 1
12-11 20:12:43.160+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 20:12:43.165+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8519
12-11 20:12:43.170+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 20:12:43.170+0900 W/CRASH_MANAGER( 8377): worker.c: worker_job(1199) > 1108519626c611449832363
12-11 20:12:43.385+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 20:12:43.390+0900 E/AUL_AMD (  475): amd_request.c: __app_process_by_pid(193) > pid(8519) is dead. cmd(4) is canceled
12-11 20:12:43.390+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 20:12:43.405+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:12:43.420+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:12:43.420+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 20:12:43.420+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 703
12-11 20:12:43.510+0900 E/RESOURCED(  481): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-11 20:12:43.515+0900 E/RESOURCED(  481): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 20:12:43.520+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 20:12:43.520+0900 W/AUL_PAD ( 1208): launchpad.c: __launchpad_main_loop(526) > Candidate is not prepared, enter legacy logic
12-11 20:12:43.520+0900 W/AUL_PAD ( 1208): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 20:12:43.520+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2037) > Launch with legacy way : no launchpad
12-11 20:12:43.520+0900 W/AUL_AMD (  475): amd_launch.c: start_process(573) > child process: 8598
12-11 20:12:43.570+0900 W/AUL_AMD (  475): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 8598
12-11 20:12:43.590+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 8519
12-11 20:12:43.620+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 20:12:43.625+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8598
12-11 20:12:43.625+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 20:12:43.670+0900 I/CAPI_WATCH_APPLICATION( 8598): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 20:12:43.835+0900 E/TBM     ( 8598): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 20:12:43.885+0900 W/WATCH_CORE( 8598): appcore-watch.c: __widget_create(958) > widget_create
12-11 20:12:43.890+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1712) > [SECURE_LOG] [14.824063] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263116:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 20:12:43.890+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[14.824063] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263116:4] gbar_fname[]
12-11 20:12:43.905+0900 E/WIDGET_VIEWER(  714): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 20:12:43.905+0900 E/WIDGET_EVAS(  714): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 20:12:43.925+0900 I/AUL_PAD ( 8589): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 20:12:44.145+0900 I/CAPI_NETWORK_WIFI( 8598): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 20:12:44.155+0900 I/CAPI_NETWORK_WIFI( 8598): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 20:12:44.320+0900 E/blackandwhite( 8598): blackandwhite.c: update_watch(149) > colorT : 1
12-11 20:12:44.345+0900 W/WATCH_CORE( 8598): appcore-watch.c: __widget_create(976) > widget_create done
12-11 20:12:44.405+0900 I/WATCH_CORE( 8598): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 20:12:44.405+0900 I/WATCH_CORE( 8598): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 20:12:44.405+0900 I/WATCH_CORE( 8598): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 20:12:44.470+0900 W/WATCH_CORE( 8598): appcore-watch.c: __widget_resume(1012) > widget_resume
12-11 20:12:44.475+0900 I/CAPI_WATCH_APPLICATION( 8598): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 20:12:44.500+0900 I/CAPI_NETWORK_WIFI( 8598): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 20:12:44.540+0900 I/CAPI_NETWORK_WIFI( 8598): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 20:12:44.575+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 20:12:44.575+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 20:12:44.580+0900 E/blackandwhite( 8598): blackandwhite.c: update_watch(149) > colorT : 1
12-11 20:12:44.920+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 20:12:44.925+0900 E/AUL_AMD (  475): amd_request.c: __app_process_by_pid(193) > pid(8598) is dead. cmd(4) is canceled
12-11 20:12:44.925+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 20:12:44.940+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:12:44.945+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:12:44.945+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 20:12:44.945+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 703
12-11 20:12:45.025+0900 E/RESOURCED(  481): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-11 20:12:45.025+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 20:12:45.025+0900 E/RESOURCED(  481): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 20:12:45.025+0900 W/AUL_PAD ( 1208): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 20:12:45.025+0900 W/AUL_PAD ( 1208): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 20:12:45.070+0900 I/CAPI_WATCH_APPLICATION( 8589): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 20:12:45.095+0900 E/TBM     ( 8589): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 20:12:45.130+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 23
12-11 20:12:45.130+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-11 20:12:45.130+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 8598
12-11 20:12:45.130+0900 W/AUL_AMD (  475): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-11 20:12:45.140+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 8598
12-11 20:12:45.180+0900 W/WATCH_CORE( 8589): appcore-watch.c: __widget_create(958) > widget_create
12-11 20:12:45.185+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1712) > [SECURE_LOG] [14.824063] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263120:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 20:12:45.185+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[14.824063] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263120:4] gbar_fname[]
12-11 20:12:45.210+0900 E/WIDGET_VIEWER(  714): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 20:12:45.210+0900 E/WIDGET_EVAS(  714): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 20:12:45.460+0900 I/CAPI_NETWORK_WIFI( 8589): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 20:12:45.475+0900 I/CAPI_NETWORK_WIFI( 8589): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 20:12:45.665+0900 E/blackandwhite( 8589): blackandwhite.c: update_watch(149) > colorT : 1
12-11 20:12:45.685+0900 W/WATCH_CORE( 8589): appcore-watch.c: __widget_create(976) > widget_create done
12-11 20:12:45.735+0900 I/WATCH_CORE( 8589): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 20:12:45.735+0900 I/WATCH_CORE( 8589): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 20:12:45.740+0900 I/WATCH_CORE( 8589): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 20:12:46.130+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 20:12:46.130+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 20:12:46.170+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 20:12:46.180+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8589
12-11 20:12:46.180+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 20:12:47.725+0900 I/AUL_PAD ( 8629): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 20:12:49.810+0900 W/CRASH_MANAGER( 8377): worker.c: worker_job(1199) > 1108598626c61144983236
