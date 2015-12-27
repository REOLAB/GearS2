S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 2957
Date: 2015-12-10 20:29:00+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1d

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x4044f250, r3   = 0x00000029
r4   = 0xbeb1f370, r5   = 0x00000168
r6   = 0x00000168, r7   = 0xbeb1e888
r8   = 0x00000168, r9   = 0x00000168
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x40845d68, sp   = 0xbeb1e870
lr   = 0x403981e8, pc   = 0x40001432
cpsr = 0x60000030

Memory Information
MemTotal:   490732 KB
MemFree:     17812 KB
Buffers:     16400 KB
Cached:     182400 KB
VmPeak:      92612 KB
VmSize:      92100 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14768 KB
VmRSS:       14768 KB
VmData:      37004 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       21004 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 2957 TID = 2957
2957 2962 2987 

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
4332d000 43b2c000 rw-p [stack:2962]
43b2c000 43b2f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43b37000 43b42000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43e88000 43e9f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
440e9000 440eb000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
450f4000 45a40000 rw-p [stack:2987]
beaff000 beb20000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2957)
Call Stack Count: 17
 0: getBTStatus + 0x31 (0x40001432) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1432
 1: update_watch + 0x50 (0x40001701) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1701
 2: create_base_gui + 0x376 (0x40001d5b) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1d5b
 3: app_create + 0x2c (0x400015bd) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x15bd
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
14: main + 0xc6 (0x4000152b) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x152b
15: __libc_start_main + 0x114 (0x4034082c) [/lib/libc.so.6] + 0x1782c
16: (0x40001084) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1084
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
78795] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_15.378795.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263032:4] gbar_fname[]
12-10 20:29:02.336+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-10 20:29:02.336+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-10 20:29:02.561+0900 I/CAPI_NETWORK_WIFI( 2956): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 20:29:02.581+0900 I/CAPI_NETWORK_WIFI( 2956): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 20:29:03.246+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-10 20:29:03.246+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-10 20:29:03.281+0900 I/AUL     ( 1048): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
12-10 20:29:03.296+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-10 20:29:03.296+0900 E/AUL_AMD (  475): amd_request.c: __app_process_by_pid(193) > pid(2956) is dead. cmd(4) is canceled
12-10 20:29:03.301+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:4001ee2d
12-10 20:29:03.311+0900 W/W_HOME  (  715): clock_service.c: clock_service_event_handler(821) > scroller freeze off
12-10 20:29:03.311+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:4001f5e5
12-10 20:29:03.311+0900 W/W_HOME  (  715): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: com.samsung.watchface 0 1 1 0
12-10 20:29:03.311+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-10 20:29:03.311+0900 E/W_HOME  (  715): clock_service.c: _clock_provider_change(396) > clock will be changed to com.samsung.watchface
12-10 20:29:03.311+0900 E/WMS     (  473): wms_event_handler.c: _wms_event_handler_cb_vconf_clocks_set_idle(6378) > Watchface loader app, ignore callback..
12-10 20:29:03.331+0900 E/W_HOME  (  715): dbox.c: widget_create(359) > add-viewer info none: com.samsung.watchface
12-10 20:29:03.336+0900 W/W_HOME  (  715): clock_inf_dbox.c: _is_preload_watchface(166) > ret:1
12-10 20:29:03.341+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_resize(5435) > [SECURE_LOG] Failed to get box size
12-10 20:29:03.341+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_is_created_by_user(3452) > [SECURE_LOG] Handler is invalid
12-10 20:29:03.341+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-10 20:29:03.341+0900 E/W_HOME  (  715): clock_service.c: _set_waiting_timer(356) > clock waiting timer is started
12-10 20:29:03.341+0900 E/W_HOME  (  715): clock_service.c: _clock_error_report(295) > error:org.reolab.blackandwhite treat:3
12-10 20:29:03.346+0900 W/W_HOME  (  715): clock_service.c: clock_service_event_handler(821) > scroller freeze off
12-10 20:29:03.346+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:4001f5a7
12-10 20:29:03.346+0900 W/W_HOME  (  715): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: com.samsung.watchface 1 0 0 0
12-10 20:29:03.346+0900 E/W_HOME  (  715): clock_service.c: _clock_service_heartbeat_pump(544) > not ready to create a new clock:com.samsung.watchface
12-10 20:29:03.351+0900 W/W_HOME  (  715): gesture.c: _clock_show(228) > clock show
12-10 20:29:03.361+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2956
12-10 20:29:03.361+0900 W/W_HOME  (  715): gesture.c: _clock_show(243) > home raise
12-10 20:29:03.361+0900 E/W_HOME  (  715): gesture.c: gesture_win_aux_set(396) > wm.policy.win.do.not.use.deiconify.approve:-1
12-10 20:29:03.361+0900 W/W_HOME  (  715): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
12-10 20:29:03.361+0900 W/W_HOME  (  715): gesture.c: _clock_show(246) > home raise done
12-10 20:29:03.361+0900 W/W_HOME  (  715): gesture.c: _clock_show(253) > show clock
12-10 20:29:03.361+0900 E/W_HOME  (  715): dbus_util.c: home_dbus_lcd_on_signal_send(225) > Sending LCD ON request signal wristup:0 result:0
12-10 20:29:03.361+0900 W/W_HOME  (  715): cs_broker.c: _wms_clock_vconf_cb(283) > 
12-10 20:29:03.366+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02400003)
12-10 20:29:03.381+0900 I/AUL     ( 1048): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : , ret : 0
12-10 20:29:03.386+0900 E/CAPI_APPFW_APP_MANAGER( 1048): app_manager.c: app_manager_error(76) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
12-10 20:29:03.406+0900 W/WAKEUP-SERVICE( 1112): WakeupService.cpp: OnReceiveDisplayChanged(905) > [0;32mINFO: LCDOn receive data : 1124318408[0;m
12-10 20:29:03.406+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-10 20:29:03.406+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_set(161) > timer set
12-10 20:29:03.406+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-10 20:29:03.406+0900 W/W_HOME  (  715): gesture.c: _apps_status_get(123) > apps status:0
12-10 20:29:03.406+0900 W/W_HOME  (  715): gesture.c: _lcd_on_cb(295) > move_to_clock:1 clock_visible:1 info->offtime:36042
12-10 20:29:03.406+0900 W/W_HOME  (  715): gesture.c: _manual_render_schedule(211) > schedule, manual render
12-10 20:29:03.406+0900 W/W_HOME  (  715): event_manager.c: _lcd_on_cb(691) > lcd state: 1
12-10 20:29:03.406+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 20:29:03.411+0900 W/STARTER (  687): clock-mgr.c: _on_lcd_signal_receive_cb(1519) > [_on_lcd_signal_receive_cb:1519] _on_lcd_signal_receive_cb, 1519, Pre LCD on by [event] after screen off time [36042]ms
12-10 20:29:03.411+0900 W/STARTER (  687): clock-mgr.c: _pre_lcd_on(1245) > [_pre_lcd_on:1245] Will LCD ON as reserved app[(null)] alpm mode[0]
12-10 20:29:03.411+0900 I/SCONTEXT-LIB(  613): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 42 (req_id=6)
12-10 20:29:03.411+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: RESUME State: PAUSED
12-10 20:29:03.411+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-10 20:29:03.411+0900 W/W_HOME  (  715): main.c: _appcore_resume_cb(681) > appcore resume
12-10 20:29:03.411+0900 W/W_HOME  (  715): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
12-10 20:29:03.411+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 20:29:03.411+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 20:29:03.411+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-10 20:29:03.411+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
12-10 20:29:03.416+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 20:29:03.416+0900 I/GESTURE (  138): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-10 20:29:03.426+0900 W/WAKEUP-SERVICE( 1112): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-10 20:29:03.426+0900 I/TIZEN_N_SOUND_MANAGER( 1112): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-10 20:29:03.436+0900 W/TIZEN_N_SOUND_MANAGER( 1112): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-10 20:29:03.436+0900 I/TIZEN_N_SOUND_MANAGER( 1112): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-10 20:29:03.491+0900 W/MUSIC_CONTROL_SERVICE(  817): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:817]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
12-10 20:29:03.491+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-10 20:29:03.506+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 20:29:03.516+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 20:29:03.516+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-10 20:29:03.516+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 689
12-10 20:29:03.521+0900 W/STARTER (  687): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [event]
12-10 20:29:03.521+0900 W/STARTER (  687): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[0]
12-10 20:29:03.531+0900 E/RESOURCED(  476): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-10 20:29:03.556+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-10 20:29:03.556+0900 W/AUL_PAD ( 1182): launchpad.c: __launchpad_main_loop(526) > Candidate is not prepared, enter legacy logic
12-10 20:29:03.556+0900 W/AUL_PAD ( 1182): launchpad.c: __send_result_to_caller(265) > Check app launching
12-10 20:29:03.556+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2037) > Launch with legacy way : no launchpad
12-10 20:29:03.561+0900 W/AUL_AMD (  475): amd_launch.c: start_process(573) > child process: 3034
12-10 20:29:03.606+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
12-10 20:29:03.606+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 0
12-10 20:29:03.611+0900 W/AUL_AMD (  475): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 3034
12-10 20:29:03.631+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: evas_render_pre_cb(6758) > [SECURE_LOG] Failed to create a resource lock
12-10 20:29:03.821+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_has_glance_bar(1890) > [SECURE_LOG] Handler is invalid
12-10 20:29:03.841+0900 I/TIZEN_N_SOUND_MANAGER( 1112): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-10 20:29:03.841+0900 W/TIZEN_N_SOUND_MANAGER( 1112): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-10 20:29:03.841+0900 W/WAKEUP-SERVICE( 1112): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-10 20:29:03.841+0900 I/HIGEAR  ( 1112): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-10 20:29:03.941+0900 I/SHealth_Common( 1048): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-10 20:29:03.941+0900 I/SHealth_Service( 1048): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-10 20:29:03.941+0900 E/SHealth_Common( 1048): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 20:29:03.946+0900 I/efl-extension( 3034): efl_extension.c: eext_mod_init(40) > Init
12-10 20:29:03.991+0900 I/UXT     ( 3034): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
12-10 20:29:04.036+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 20:29:04.046+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3034
12-10 20:29:04.051+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 20:29:04.096+0900 I/CAPI_WATCH_APPLICATION( 3034): watch_app_main.c: watch_app_main(382) > watch_app_main
12-10 20:29:04.146+0900 E/TBM     ( 3034): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-10 20:29:04.196+0900 W/WATCH_CORE( 3034): appcore-watch.c: __widget_create(958) > widget_create
12-10 20:29:04.196+0900 E/watchface-loader( 3034): watchface-loader.cpp: OnAppCreated(502) > 
12-10 20:29:04.196+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [308.831818] pkgname: com.samsung.watchface, id: file:///opt/usr/share/live_magazine/com.samsung.watchface_715_308.831818.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-10 20:29:04.196+0900 W/W_HOME  (  715): dbox.c: _widget_created_cb(238) > widget resume:0x49a99520
12-10 20:29:04.196+0900 E/WIDGET_VIEWER(  715): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
12-10 20:29:04.201+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
12-10 20:29:04.216+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
12-10 20:29:04.221+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
12-10 20:29:04.231+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 20:29:04.231+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 20:29:04.231+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 20:29:04.231+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
12-10 20:29:04.231+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
12-10 20:29:04.231+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 20:29:04.231+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.watchface:watchface::messageport::event], client = 3034
12-10 20:29:04.231+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_set_changed_cb(534) > Enter [system_settings_set_changed_cb]
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=16
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 16, key = 16, type = 1
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_set_changed_cb(534) > Enter [system_settings_set_changed_cb]
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=16
12-10 20:29:04.236+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 16, key = 16, type = 1
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 20:29:04.416+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 20:29:04.416+0900 E/CAPI_APPFW_APP_CONTROL(  817): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-10 20:29:04.416+0900 W/MUSIC_CONTROL_SERVICE(  817): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:817]   value = [true][0m
12-10 20:29:04.416+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 20:29:04.421+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 715
12-10 20:29:04.441+0900 W/MUSIC_CONTROL_SERVICE(  817): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:817]   [MUSIC_PLAYER_EVENT][0m
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 20:29:04.441+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 20:29:04.446+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-10 20:29:04.446+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-10 20:29:04.446+0900 W/MUSIC_CONTROL_SERVICE(  817): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:817]   [MUSIC_PLAYER_EVENT][0m
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 20:29:04.446+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-10 20:29:04.446+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 20:29:04.446+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-10 20:29:04.451+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 20:29:04.451+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 20:29:04.451+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 20:29:04.466+0900 I/DALI    ( 3034): slp-logging.cpp: LogMessage(36) > EGL Information
12-10 20:29:04.466+0900 I/DALI    ( 3034):             Vendor:        ARM
12-10 20:29:04.466+0900 I/DALI    ( 3034):             Version:       1.4 Linux-r4p0-00rel0
12-10 20:29:04.466+0900 I/DALI    ( 3034):             Client APIs:   OpenGL_ES
12-10 20:29:04.466+0900 I/DALI    ( 3034):             Extensions:    EGL_KHR_image EGL_KHR_image_base EGL_KHR_image_pixmap EGL_KHR_gl_texture_2D_image EGL_KHR_gl_texture_cubemap_image EGL_KHR_gl_renderbuffer_image EGL_KHR_reusable_sync EGL_KHR_fence_sync EGL_EXT_swap_buffers_with_damage EGL_TIZEN_image_native_buffer EGL_TIZEN_image_native_surface EGL_KHR_lock_surface EGL_KHR_lock_surface2 EGL_EXT_create_context_robustness EGL_SEC_swapbuffers_region 
12-10 20:29:04.536+0900 I/watchface-viewer( 3034): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [1]
12-10 20:29:04.536+0900 I/watchface-viewer( 3034): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [2]
12-10 20:29:04.541+0900 I/watchface-viewer( 3034): viewer-view.cpp: View(96) > default camera z[720.000000]
12-10 20:29:04.581+0900 E/BASE_UTILS( 3034): utils_i18n_ucalendar.c: i18n_ucalendar_get_timezone_displayname(113) > (calendar == NULL || result == NULL || buf_size_needed == NULL)
12-10 20:29:04.586+0900 I/watchface-viewer( 3034): viewer-util.cpp: ToUTF8(1214) > i18n_ustring_to_UTF8 returns -22(ffffffea)
12-10 20:29:04.586+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: UpdateTimezone(2782) > timezonePath[Asia/Seoul] mTimezone[]
12-10 20:29:04.586+0900 I/watchface-viewer( 3034): viewer-impl.cpp: SetDummyMode(95) > dummyMode[3]
12-10 20:29:04.586+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: UpdateTimestamp(1310) > now[1449746944] dummy[1449709840]
12-10 20:29:04.601+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseXML(669) > schema version[0.0]
12-10 20:29:04.606+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseXML(689) > wrong target resolution!!
12-10 20:29:04.606+0900 I/watchface-viewer( 3034): viewer-util.cpp: GetAppId(61) > appId[com.samsung.watchface]
12-10 20:29:04.611+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-10 20:29:04.611+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseGroup(1654) > added transition effect [1][1]
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2201) > draw data set!!
12-10 20:29:04.636+0900 I/data-util( 3034): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2201) > draw data set!!
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseCondition(2340) > ParseCondition depth[0]
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseCondition(2523) > conditional data type[4] set
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseCondition(2554) > default data type[4] set
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseCondition(2340) > ParseCondition depth[0]
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseCondition(2447) > eq found!! ignore other attributes!!
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseCondition(2554) > default data type[3] set
12-10 20:29:04.636+0900 I/data-util( 3034): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseGroup(1568) > action added type[1]trigger[1]
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseGroup(1568) > action added type[2]trigger[2]
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseGroup(1654) > added transition effect [1][1]
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseCondition(2340) > ParseCondition depth[0]
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseCondition(2523) > conditional data type[3] set
12-10 20:29:04.636+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseCondition(2554) > default data type[3] set
12-10 20:29:04.641+0900 I/data-util( 3034): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
12-10 20:29:04.641+0900 I/data-util( 3034): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
12-10 20:29:04.641+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseGroup(1568) > action added type[1]trigger[1]
12-10 20:29:04.641+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseGroup(1568) > action added type[2]trigger[2]
12-10 20:29:04.641+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseGroup(1654) > added transition effect [1][1]
12-10 20:29:04.641+0900 I/data-util( 3034): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
12-10 20:29:04.641+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParseGroup(1654) > added transition effect [1][1]
12-10 20:29:04.641+0900 I/data-util( 3034): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
12-10 20:29:04.641+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2175) > rotationData set!!
12-10 20:29:04.641+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2175) > rotationData set!!
12-10 20:29:04.646+0900 I/data-util( 3034): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
12-10 20:29:04.646+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2175) > rotationData set!!
12-10 20:29:04.646+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2175) > rotationData set!!
12-10 20:29:04.646+0900 I/data-util( 3034): data-util-xml-parser.c: data_util_xml_get_child_nodeptr(106) > parentPtr->xmlChildrenNode is failed
12-10 20:29:04.646+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2175) > rotationData set!!
12-10 20:29:04.646+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2243) > added transition effect [1][1]
12-10 20:29:04.646+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2175) > rotationData set!!
12-10 20:29:04.646+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2243) > added transition effect [1][1]
12-10 20:29:04.646+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2175) > rotationData set!!
12-10 20:29:04.651+0900 I/watchface-viewer( 3034): viewer-model.cpp: ParsePart(2175) > rotationData set!!
12-10 20:29:04.651+0900 I/watchface-viewer( 3034): viewer-group-manager.cpp: Clear(32) > 
12-10 20:29:04.651+0900 I/watchface-viewer( 3034): viewer-impl.cpp: LoadWatchfaceData(212) > wrong shape [0]
12-10 20:29:04.651+0900 I/watchface-viewer( 3034): viewer-view.cpp: SetWatchfaceSizeType(676) > watchface size 0x0 shape[0] noMasking[0]
12-10 20:29:04.651+0900 I/watchface-viewer( 3034): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [1]
12-10 20:29:04.651+0900 I/watchface-viewer( 3034): viewer-shader-manager.cpp: DisableShaderEffect(500) > not enabled effect type!! [2]
12-10 20:29:04.656+0900 I/watchface-viewer( 3034): viewer-group.cpp: Group(96) > Group[0x477cc840][bg]
12-10 20:29:04.656+0900 I/watchface-viewer( 3034): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x477aeaf8]
12-10 20:29:04.656+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477cd0e0]
12-10 20:29:04.656+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477d06f0]
12-10 20:29:04.656+0900 I/watchface-viewer( 3034): viewer-group.cpp: Group(96) > Group[0x477c6048][complication-1]
12-10 20:29:04.656+0900 I/watchface-viewer( 3034): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x477aeaf8]
12-10 20:29:04.656+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477c6190]
12-10 20:29:04.656+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477c1f60]
12-10 20:29:04.656+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477c52c0]
12-10 20:29:04.656+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477c72a0]
12-10 20:29:04.661+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: SetUpdateImage(1825) > new mThread[0x477c7980]
12-10 20:29:04.661+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477c7c28]
12-10 20:29:04.661+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477ca2d0]
12-10 20:29:04.661+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477ca2d0] for [32]
12-10 20:29:04.661+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [32] to pending list
12-10 20:29:04.661+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: SetUpdateImage(1825) > new mThread[0x477ca9e0]
12-10 20:29:04.661+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477cac10] for [32]
12-10 20:29:04.661+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477c03b8]
12-10 20:29:04.661+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477c0a88]
12-10 20:29:04.661+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477caf58] for [34]
12-10 20:29:04.661+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [34] to pending list
12-10 20:29:04.666+0900 I/watchface-viewer( 3034): viewer-touch-feedback.cpp: Downcast(55) > wrong action type[1] to downcast
12-10 20:29:04.666+0900 I/watchface-viewer( 3034): viewer-group.cpp: Group(96) > Group[0x477cb560][complication-2]
12-10 20:29:04.666+0900 I/watchface-viewer( 3034): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x477aeaf8]
12-10 20:29:04.666+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477cb930]
12-10 20:29:04.666+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477b5b20]
12-10 20:29:04.666+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477b6678]
12-10 20:29:04.666+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477c8028]
12-10 20:29:04.666+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477c8ac0] for [73]
12-10 20:29:04.666+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [73] to pending list
12-10 20:29:04.666+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [77] to pending list
12-10 20:29:04.666+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477c8f60]
12-10 20:29:04.671+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477c90f0]
12-10 20:29:04.671+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 20:29:04.671+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 20:29:04.671+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 20:29:04.671+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 20:29:04.671+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: ThreadCallback(1952) > thread[0x477c7980]
12-10 20:29:04.671+0900 I/watchface-viewer( 3034): viewer-util.cpp: UpdateLocale(1043) > mLocale[ko_KR]
12-10 20:29:04.671+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: ThreadCallback(1952) > thread[0x477ca9e0]
12-10 20:29:04.686+0900 I/watchface-viewer( 3034): viewer-part-resource-evas.cpp: CreateEvasBuffer(83) > created mEvas[0x477c0068] size(90x43)
12-10 20:29:04.691+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477be2c8] for [73]
12-10 20:29:04.691+0900 I/watchface-viewer( 3034): viewer-touch-feedback.cpp: Downcast(55) > wrong action type[1] to downcast
12-10 20:29:04.691+0900 I/watchface-viewer( 3034): viewer-group.cpp: Group(96) > Group[0x477bf6d0][day-1]
12-10 20:29:04.691+0900 I/watchface-viewer( 3034): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x477aeaf8]
12-10 20:29:04.691+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477bf818]
12-10 20:29:04.691+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477e6c68]
12-10 20:29:04.691+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477e1f38]
12-10 20:29:04.691+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477e25d8]
12-10 20:29:04.696+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 20:29:04.696+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 20:29:04.696+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 20:29:04.696+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3034): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 20:29:04.696+0900 I/watchface-viewer( 3034): viewer-util.cpp: UpdateLocale(1043) > mLocale[ko_KR]
12-10 20:29:04.696+0900 I/watchface-viewer( 3034): viewer-part-resource-evas.cpp: CreateEvasBuffer(83) > created mEvas[0x477e06c8] size(32x32)
12-10 20:29:04.696+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477e8128] for [17]
12-10 20:29:04.696+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477e8498] for [30]
12-10 20:29:04.696+0900 I/watchface-viewer( 3034): viewer-group.cpp: Group(96) > Group[0x477e0b58][hands]
12-10 20:29:04.696+0900 I/watchface-viewer( 3034): viewer-group.cpp: GetDataProvider(222) > DataProvider::Get() [0x477aeaf8]
12-10 20:29:04.696+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477e0f28]
12-10 20:29:04.696+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477e1130]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477e0f84] for [7]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477af9f8]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477b00a8]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477afa54] for [7]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477b0df8]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477e2a88]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477b0e54] for [5]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477e3768]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477e3eb8]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477e37c4] for [5]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477e4b18]
12-10 20:29:04.701+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477e5288]
12-10 20:29:04.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477e4b74] for [2]
12-10 20:29:04.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [2] to pending list
12-10 20:29:04.706+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477e5f58]
12-10 20:29:04.706+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477bafa0]
12-10 20:29:04.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddListener(570) > added listener[0x477e5fb4] for [2]
12-10 20:29:04.706+0900 I/watchface-viewer( 3034): viewer-group.cpp: Group(96) > Group[0x477bbb98][alpm-hands]
12-10 20:29:04.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddDataBroker(1563) > added broker [0x477bbf68]
12-10 20:29:04.706+0900 I/watchface-viewer( 3034): viewer-data-broker.cpp: AmbientDataBroker(1276) > AmbientDataBroker[0x477bbf68]
12-10 20:29:04.706+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477bc518]
12-10 20:29:04.706+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477bcc40]
12-10 20:29:04.706+0900 I/watchface-viewer( 3034): viewer-data-broker.cpp: AddListener(1289) > added listener[0x477bc574] for [7]
12-10 20:29:04.711+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
12-10 20:29:04.711+0900 I/watchface-viewer( 3034): viewer-part.cpp: Part(84) > Part[0x477bd8f0]
12-10 20:29:04.711+0900 I/watchface-viewer( 3034): viewer-part-resource.cpp: PartResource(66) > PartResource[0x477be048]
12-10 20:29:04.711+0900 I/watchface-viewer( 3034): viewer-data-broker.cpp: AddListener(1289) > added listener[0x477bd94c] for [6]
12-10 20:29:04.711+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [6] to pending list
12-10 20:29:04.711+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: ConnectModels(1381) > models will be connected later when first resume received!!
12-10 20:29:04.711+0900 I/watchface-viewer( 3034): viewer-model.cpp: ~ModelWatchfaceData(534) > 
12-10 20:29:04.711+0900 W/WATCH_CORE( 3034): appcore-watch.c: __widget_create(976) > widget_create done
12-10 20:29:04.716+0900 I/watchface-viewer( 3034): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x477cf8f0]
12-10 20:29:04.716+0900 I/watchface-viewer( 3034): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x477b0bb0]
12-10 20:29:04.736+0900 I/watchface-viewer( 3034): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x477e3580]
12-10 20:29:04.751+0900 I/watchface-viewer( 3034): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x477e49b0]
12-10 20:29:04.771+0900 I/watchface-viewer( 3034): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x477e5d90]
12-10 20:29:04.791+0900 I/watchface-viewer( 3034): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x477bb9f8]
12-10 20:29:04.811+0900 I/watchface-viewer( 3034): viewer-image-file-loader.cpp: ImageEditThreadWorker(101) > new image edit thread [0x477bd748]
12-10 20:29:04.816+0900 W/CRASH_MANAGER( 2910): worker.c: worker_job(1199) > 1102957626c61144974694
