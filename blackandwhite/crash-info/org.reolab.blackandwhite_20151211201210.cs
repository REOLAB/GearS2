S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 7898
Date: 2015-12-11 20:12:10+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x70616124

Register Information
r0   = 0x70616118, r1   = 0x0000000d
r2   = 0x70615f68, r3   = 0x41553194
r4   = 0x70616118, r5   = 0x00000000
r6   = 0x414e9204, r7   = 0x414dd608
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbe88ec4c, sp   = 0xbe88ec00
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     21672 KB
Buffers:     22264 KB
Cached:     172140 KB
VmPeak:     111464 KB
VmSize:     110952 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15948 KB
VmRSS:       15948 KB
VmData:      54424 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 7898 TID = 7898
7898 8230 8241 

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
43757000 43f56000 rw-p [stack:8230]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:8241]
be86f000 be890000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7898)
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
 ::DATA:: No categories available.
12-11 19:59:21.530+0900 W/wnotibp ( 2286): wnotiboard-popup-data.c: wnotibp_get_alert_list(911) > ::DATA:: read alert list : 0, list count : 2
12-11 19:59:23.255+0900 E/wnoti-service(  862): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
12-11 19:59:24.005+0900 W/wnotibp ( 2286): wnotiboard-popup.c: wnotiboard_popup_view_lock(858) > ::UI:: [[[ ===> [small popup] is LOCK, 0010 ]]]
12-11 19:59:24.005+0900 W/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotiboard_popup_main_popup_timer_cb(2298) > ::UI:: start hiding animation
12-11 19:59:24.315+0900 W/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotiboard_popup_sub_popup_hide_animator_cb(2229) > ::UI:: end hiding animation
12-11 19:59:24.315+0900 W/wnotibp ( 2286): wnotiboard-popup.c: wnotiboard_popup_view_unlock(908) > ::UI:: [[[ [small popup] is UNLOCK , 0000 <=== ]]]
12-11 19:59:24.315+0900 W/wnotibp ( 2286): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 2 2
12-11 19:59:24.315+0900 W/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1890) > state : (8, 1, 3)
12-11 19:59:24.315+0900 I/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1903) > simple popup=46d12180, view_state=3
12-11 19:59:24.315+0900 I/wnotibp ( 2286): wnotiboard-popup.c: wnotiboard_popup_view_unlock(902) > ::UI:: it is invalid object.
12-11 19:59:24.315+0900 W/wnotibp ( 2286): wnotiboard-popup.c: wnotiboard_popup_view_unlock(908) > ::UI:: [[[ [invalid object] is UNLOCK , 0000 <=== ]]]
12-11 19:59:24.315+0900 W/wnotibp ( 2286): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 2 2
12-11 19:59:24.315+0900 I/wnotibp ( 2286): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(918) > ::DATA:: remove notification data, 2837
12-11 19:59:24.315+0900 I/wnotibp ( 2286): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(948) > ::DATA:: CHECK DATA : 1, 1
12-11 19:59:24.315+0900 I/efl-extension( 2286): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x45746cb8, obj: 0x45746cb8
12-11 19:59:24.315+0900 I/efl-extension( 2286): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-11 19:59:24.345+0900 I/efl-extension( 2286): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-11 19:59:24.345+0900 I/efl-extension( 2286): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45746cb8, elm_genlist, func : 0x41a41e59
12-11 19:59:24.345+0900 I/efl-extension( 2286): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-11 19:59:24.505+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 19:59:24.815+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: MEM_FLUSH State: PAUSED
12-11 19:59:26.675+0900 W/WATCH_CORE( 7756): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-11 19:59:26.675+0900 I/WATCH_CORE( 7756): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-11 19:59:26.715+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-11 19:59:26.715+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-11 19:59:26.715+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 1
12-11 19:59:26.715+0900 W/W_HOME  (  714): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-11 19:59:26.715+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:59:26.725+0900 W/STARTER (  701): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-11 19:59:26.725+0900 W/STARTER (  701): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-11 19:59:26.725+0900 E/STARTER (  701): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-11 19:59:26.725+0900 W/STARTER (  701): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-11 19:59:26.725+0900 W/STARTER (  701): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-11 19:59:26.730+0900 I/SCONTEXT-LIB(  648): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-11 19:59:26.755+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-11 19:59:26.780+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-11 19:59:26.780+0900 I/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-11 19:59:26.870+0900 I/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-11 19:59:26.870+0900 W/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-11 19:59:26.870+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-11 19:59:26.870+0900 I/HIGEAR  ( 1106): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-11 19:59:26.920+0900 I/SHealth_Common( 1049): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-11 19:59:26.920+0900 I/SHealth_Service( 1049): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-11 19:59:26.925+0900 W/MUSIC_CONTROL_SERVICE(  819): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:819]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-11 19:59:26.930+0900 W/STARTER (  701): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-11 19:59:26.930+0900 W/STARTER (  701): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-11 19:59:26.930+0900 W/STARTER (  701): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-11 19:59:26.930+0900 W/STARTER (  701): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[0]
12-11 19:59:26.935+0900 I/APP_CORE( 2286): appcore-efl.c: __do_app(429) > [APP 2286] Event: PAUSE State: RUNNING
12-11 19:59:26.935+0900 I/CAPI_APPFW_APPLICATION( 2286): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-11 19:59:26.940+0900 W/wnotibp ( 2286): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(267) > fg_app : 10
12-11 19:59:26.940+0900 W/wnotibp ( 2286): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 19:59:26.940+0900 W/wnotibp ( 2286): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1368) > [1, 1, 20, 0000]
12-11 19:59:26.940+0900 W/wnotibp ( 2286): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [10, 0]
12-11 19:59:26.940+0900 W/wnotibp ( 2286): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 3, 3, 2, 46d12180]
12-11 19:59:26.940+0900 I/APP_CORE( 2286): appcore-efl.c: __do_app(429) > [APP 2286] Event: PAUSE State: PAUSED
12-11 19:59:26.960+0900 W/ALARM_MANAGER(  701): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(20), start(11-12-2015, 19:59:47), repeat(1), interval(20), type(-1073741822)
12-11 19:59:27.050+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1659482720, next duetime: 1449831587
12-11 19:59:27.050+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(1659482720)
12-11 19:59:27.050+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449833400), due_time(1449831587)
12-11 19:59:27.050+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-11 19:59:27.050+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 10:59:47 (UTC).
12-11 19:59:27.050+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-11 19:59:31.949+0900 I/APP_CORE( 2286): appcore-efl.c: __do_app(429) > [APP 2286] Event: MEM_FLUSH State: PAUSED
12-11 19:59:47.000+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-11 19:59:47.065+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-11 19:59:47.150+0900 E/RESOURCED(  481): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 701
12-11 19:59:47.160+0900 W/ALARM_MANAGER(  701): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [1659482720]
12-11 19:59:47.160+0900 W/STARTER (  701): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(926) > [__starter_clock_mgr_homescreen_alarm_cb:926] homescreen alarm timer expired [1659482720]
12-11 19:59:47.180+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 19:59:47.185+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 701
12-11 19:59:47.200+0900 W/AUL_AMD (  475): amd_launch.c: __nofork_processing(1138) > __nofork_processing, cmd: 0, pid: 714
12-11 19:59:47.205+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(714), cmd(0)
12-11 19:59:47.205+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: RESET State: PAUSED
12-11 19:59:47.205+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_reset(245) > app_appcore_reset
12-11 19:59:47.205+0900 W/W_HOME  (  714): main.c: _app_control(1726) > Service value : show_clock
12-11 19:59:47.205+0900 W/W_HOME  (  714): main.c: _app_control(1762) > Show clock operation
12-11 19:59:47.205+0900 W/W_HOME  (  714): gesture.c: _clock_show(228) > clock show
12-11 19:59:47.225+0900 W/W_HOME  (  714): gesture.c: _clock_show(243) > home raise
12-11 19:59:47.225+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __alarm_expired(1325) > alarm_id[1659482720] is expired.
12-11 19:59:47.230+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1659482720, next duetime: 1449831607
12-11 19:59:47.235+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-11 19:59:47.235+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 11:00:07 (UTC).
12-11 19:59:47.240+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-11 19:59:47.245+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-11 19:59:47.250+0900 E/W_HOME  (  714): gesture.c: gesture_win_aux_set(396) > wm.policy.win.do.not.use.deiconify.approve:-1
12-11 19:59:47.255+0900 W/W_HOME  (  714): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
12-11 19:59:47.265+0900 W/W_HOME  (  714): gesture.c: _clock_show(246) > home raise done
12-11 19:59:47.265+0900 W/W_HOME  (  714): gesture.c: _clock_show(253) > show clock
12-11 19:59:47.265+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-11 19:59:47.275+0900 E/E17     (  366): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02000003)
12-11 19:59:47.300+0900 I/efl-extension( 2286): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:59:47.300+0900 W/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1721) > [3, 2, 1]
12-11 19:59:47.300+0900 W/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1890) > state : (7, 1, 3)
12-11 19:59:47.300+0900 I/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1903) > simple popup=46d12180, view_state=3
12-11 19:59:47.300+0900 W/wnotibp ( 2286): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 19:59:47.300+0900 W/wnotibp ( 2286): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(997) > ::UI:: lock state = 0000
12-11 19:59:47.340+0900 W/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1963) > device_power_release_lock CPU>>>>>>>
12-11 19:59:47.340+0900 I/wnotibp ( 2286): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_w_input_selector(4847) > No need to close w-input-selector.
12-11 19:59:47.350+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:59:47.360+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 19:59:47.370+0900 I/wnotibp ( 2286): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_notifiboard_selector(4882) > ret : 0, is_running : 0
12-11 19:59:47.370+0900 I/efl-extension( 2286): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:59:47.370+0900 I/wnotibp ( 2286): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 285, 218
12-11 19:59:47.370+0900 I/efl-extension( 2286): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:59:47.370+0900 I/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1998) > ::INFO:: call lower
12-11 19:59:47.380+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 19:59:47.380+0900 W/AUL_AMD (  475): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-11 19:59:47.385+0900 W/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_del_cb(424) > ::UI:: (2, 46d12180, 46d12180, 0)
12-11 19:59:47.385+0900 I/wnotibp ( 2286): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(918) > ::DATA:: remove notification data, 2836
12-11 19:59:47.400+0900 I/wnotibp ( 2286): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(948) > ::DATA:: CHECK DATA : 0, 0
12-11 19:59:47.400+0900 W/wnotibp ( 2286): wnotiboard-popup.c: wnotiboard_popup_view_unlock(910) > ::UI:: [[[ [simple popup] is not in lock state , 0000  <===]]]
12-11 19:59:47.405+0900 W/wnotibp ( 2286): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 0 0
12-11 19:59:47.405+0900 I/efl-extension( 2286): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x457a4960, elm_genlist, _activated_obj : 0x457a4960, activated : 0
12-11 19:59:47.430+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-11 19:59:47.435+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(1659482720)
12-11 19:59:47.435+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-11 19:59:47.435+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 11:30:00 (UTC).
12-11 19:59:47.435+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-11 19:59:47.435+0900 W/ALARM_MANAGER(  478): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[1659482720] is removed.
12-11 19:59:47.455+0900 I/wnotibp ( 2286): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_w_input_selector(4847) > No need to close w-input-selector.
12-11 19:59:47.455+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:59:47.465+0900 W/W_HOME  (  714): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
12-11 19:59:47.465+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:59:47.465+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:59:47.470+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 19:59:47.470+0900 I/wnotibp ( 2286): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_notifiboard_selector(4882) > ret : 0, is_running : 0
12-11 19:59:47.470+0900 I/efl-extension( 2286): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:59:47.470+0900 I/wnotibp ( 2286): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 285, 218
12-11 19:59:47.470+0900 I/efl-extension( 2286): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:59:47.485+0900 I/efl-extension( 2286): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x457a4960, obj: 0x457a4960
12-11 19:59:47.485+0900 I/efl-extension( 2286): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-11 19:59:47.505+0900 I/efl-extension( 2286): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-11 19:59:47.505+0900 I/efl-extension( 2286): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x457a4960, elm_genlist, func : 0x41a41e59
12-11 19:59:47.505+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:59:47.505+0900 W/W_HOME  (  714): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
12-11 19:59:47.505+0900 I/efl-extension( 2286): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-11 19:59:47.525+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(448) > Window [0x2000003] is now visible(0)
12-11 19:59:47.525+0900 W/W_HOME  (  714): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
12-11 19:59:47.525+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:59:47.525+0900 W/W_HOME  (  714): main.c: _window_visibility_cb(1189) > Window [0x2000003] is now visible(0)
12-11 19:59:47.525+0900 I/APP_CORE(  714): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
12-11 19:59:47.525+0900 I/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
12-11 19:59:47.525+0900 E/wnotib  (  714): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-11 19:59:47.525+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1684) > Do the postponed update job.
12-11 19:59:47.535+0900 I/efl-extension( 2286): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
12-11 19:59:47.535+0900 W/APP_CORE( 2286): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:440000a
12-11 19:59:47.535+0900 W/APP_CORE( 2286): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:4400008
12-11 19:59:47.535+0900 I/APP_CORE( 2286): appcore-efl.c: __do_app(429) > [APP 2286] Event: PAUSE State: PAUSED
12-11 19:59:47.540+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1051) > idler for type: 0
12-11 19:59:47.565+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:59:47.565+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:59:47.570+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:59:47.570+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:59:47.575+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1098) > unread_count: 4
12-11 19:59:47.575+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(622) > category_id: 285, application_id: 218, application_name: 카카오톡, time_stamp: 1449831555, content_id: 0, spannable_string_version: 1
12-11 19:59:47.575+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:59:47.575+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:59:47.575+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:59:47.575+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:59:47.575+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:59:47.575+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:59:47.580+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:59:47.580+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:59:47.580+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:59:47.580+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:59:47.580+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:59:47.580+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:59:47.580+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:59:47.580+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:59:47.580+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:59:47.585+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:59:47.585+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:59:47.585+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:59:47.585+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:59:47.585+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:59:47.585+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:59:47.585+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:59:47.585+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:59:47.585+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:59:47.585+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1335) > New noti is here. Add it on panel  285, 카카오톡.
12-11 19:59:47.585+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 1
12-11 19:59:47.595+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 19:59:47.595+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 19:59:47.595+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 19:59:47.595+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 19:59:47.595+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4398) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
12-11 19:59:47.595+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 13
12-11 19:59:47.595+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 19:59:47.595+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 19:59:47.595+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 19:59:47.595+0900 E/TIZEN_N_SYSTEM_SETTINGS(  714): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 19:59:47.595+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 19:59:47.605+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1370) > This noti will be removed from panel: 285, 카카오톡.
12-11 19:59:47.605+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 2
12-11 19:59:47.605+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2960) > We don't need to delete the item for second_depth_type: 0.
12-11 19:59:47.605+0900 E/EFL     (  714): elementary<714> elm_genlist.c:6080 elm_genlist_items_count() obj ((nil)) is NULL or type is not correct
12-11 19:59:47.605+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 12
12-11 19:59:47.605+0900 I/wnotib  (  714): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 19:59:47.610+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 1, num total noti: 4
12-11 19:59:47.610+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-11 19:59:47.610+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-11 19:59:47.610+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-11 19:59:47.610+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-11 19:59:47.610+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
12-11 19:59:47.610+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-11 19:59:47.610+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 1.
12-11 19:59:47.610+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_update(562) > 0x1
12-11 19:59:47.645+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 1
12-11 19:59:47.645+0900 W/W_HOME  (  714): noti_broker.c: _handler_noti_indicator_show(478) > 
12-11 19:59:47.650+0900 W/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(331) > body is NULL and no attachments found.
12-11 20:00:13.095+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:00:13.095+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:00:24.500+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:01:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:01:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:01:24.509+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:02:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:02:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:02:24.504+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:03:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:03:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:03:24.505+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:04:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:04:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:04:13.129+0900 I/RESOURCED(  481): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-11 20:04:24.505+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:05:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:05:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:05:24.505+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:06:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:06:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:06:24.515+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:07:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:07:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:07:24.504+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:08:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:08:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:08:24.510+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:09:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:09:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:09:24.505+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:10:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:10:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:10:13.130+0900 I/RESOURCED(  481): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-11 20:10:24.500+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:11:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:11:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:11:24.505+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:11:53.340+0900 E/PKGMGR_SERVER( 8226): pkgmgr-server.c: main(2126) > package manager server start
12-11 20:11:53.425+0900 E/PKGMGR_SERVER( 8226): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1677918393], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 20:11:53.430+0900 E/PKGMGR_SERVER( 8228): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 20:11:53.435+0900 E/PKGMGR  ( 8220): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 20:11:53.495+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 20:11:53.505+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7756
12-11 20:11:53.505+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 20:11:53.510+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 20:11:53.515+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(7756), cmd(4)
12-11 20:11:53.515+0900 W/CAPI_WATCH_APPLICATION( 7756): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 20:11:53.515+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 20:11:53.515+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(884) > app status : 4
12-11 20:11:53.515+0900 W/WATCH_CORE( 7756): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 20:11:53.515+0900 E/WIDGET_PROVIDER_APP( 7756): client.c: client_fini(1175) > Provider is not initialized
12-11 20:11:53.515+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 20:11:53.520+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 20:11:53.530+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7756
12-11 20:11:53.635+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 20:11:53.645+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 20:11:53.670+0900 E/PKGMGR_SERVER( 8228): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 20:11:53.715+0900 E/PKGMGR_SERVER( 8226): pkgmgr-server.c: sighandler(445) > child NORMAL exit [8228]
12-11 20:11:53.735+0900 E/AUL_AMD (  475): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 20:11:53.735+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(7756), cmd(4)
12-11 20:11:53.740+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 20:11:53.775+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:11:53.805+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:11:53.805+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 20:11:53.805+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 703
12-11 20:11:53.895+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 20:11:53.900+0900 W/AUL_PAD ( 1208): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 20:11:53.900+0900 W/AUL_PAD ( 1208): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 20:11:53.900+0900 E/RESOURCED(  481): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-11 20:11:53.900+0900 E/RESOURCED(  481): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 20:11:53.950+0900 I/CAPI_WATCH_APPLICATION( 7898): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 20:11:53.970+0900 E/TBM     ( 7898): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 20:11:54.010+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7756
12-11 20:11:54.045+0900 W/WATCH_CORE( 7898): appcore-watch.c: __widget_create(958) > widget_create
12-11 20:11:54.050+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1712) > [SECURE_LOG] [14.824063] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263100:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 20:11:54.050+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[14.824063] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263100:4] gbar_fname[]
12-11 20:11:54.075+0900 E/WIDGET_VIEWER(  714): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 20:11:54.075+0900 E/WIDGET_EVAS(  714): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 20:11:54.200+0900 I/CAPI_NETWORK_WIFI( 7898): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 20:11:54.215+0900 I/CAPI_NETWORK_WIFI( 7898): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 20:11:54.375+0900 E/blackandwhite( 7898): blackandwhite.c: update_watch(100) > colorT : 1
12-11 20:11:54.390+0900 W/WATCH_CORE( 7898): appcore-watch.c: __widget_create(976) > widget_create done
12-11 20:11:54.425+0900 I/WATCH_CORE( 7898): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 20:11:54.425+0900 I/WATCH_CORE( 7898): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 20:11:54.425+0900 I/WATCH_CORE( 7898): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 20:11:55.010+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 20:11:55.010+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 20:11:55.025+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 20:11:55.030+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7898
12-11 20:11:55.030+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 20:11:55.240+0900 I/AUL_PAD ( 8256): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 20:11:55.525+0900 E/PKGMGR_SERVER( 8226): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 20:11:55.525+0900 E/PKGMGR_SERVER( 8226): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 20:11:55.585+0900 W/AUL_AMD (  475): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 20:12:04.340+0900 E/PKGMGR  ( 8370): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 20:12:04.550+0900 E/PKGMGR_SERVER( 8372): pkgmgr-server.c: main(2126) > package manager server start
12-11 20:12:04.650+0900 E/PKGMGR_SERVER( 8372): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1689091037], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_1689091037' '-r' 'org.reolab.blackandwhite'], cookie=[cJXkQo9e1fAYY3r0NFNFAZrlBOI=], backend_flag=[0]
12-11 20:12:04.655+0900 E/PKGMGR  ( 8372): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 20:12:04.655+0900 E/PKGMGR_SERVER( 8372): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 20:12:04.665+0900 E/PKGMGR  ( 8370): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[83700002]
12-11 20:12:04.665+0900 E/PKGMGR_SERVER( 8373): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 20:12:04.825+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 20:12:04.830+0900 W/AUL_AMD (  475): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 20:12:04.845+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 20:12:04.850+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 20:12:05.405+0900 E/PKGMGR_CERT( 8373): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 20:12:05.415+0900 E/PKGMGR_CERT( 8373): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
12-11 20:12:05.415+0900 E/PKGMGR_CERT( 8373): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
12-11 20:12:05.415+0900 E/PKGMGR_CERT( 8373): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-11 20:12:05.420+0900 E/PKGMGR_CERT( 8373): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-11 20:12:05.420+0900 E/PKGMGR_CERT( 8373): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-11 20:12:05.420+0900 E/PKGMGR_CERT( 8373): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-11 20:12:05.425+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 20:12:05.445+0900 E/PKGMGR_CERT( 8373): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 20:12:06.515+0900 E/PKGMGR_SERVER( 8372): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 20:12:07.230+0900 E/rpm-installer( 8373): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-11 20:12:08.515+0900 E/PKGMGR_SERVER( 8372): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 20:12:10.260+0900 E/PKGMGR_SERVER( 8372): pkgmgr-server.c: sighandler(445) > child NORMAL exit [8373]
12-11 20:12:10.270+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 20:12:10.295+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-11 20:12:10.295+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-11 20:12:10.325+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-11 20:12:10.325+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-11 20:12:10.325+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-11 20:12:10.325+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-11 20:12:10.350+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-11 20:12:10.405+0900 E/APPS    (  714): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-11 20:12:10.470+0900 E/PKGMGR_INFO(  479): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-11 20:12:10.515+0900 E/PKGMGR_SERVER( 8372): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 20:12:10.515+0900 E/PKGMGR_SERVER( 8372): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 20:12:10.815+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 20:12:10.820+0900 E/AUL     (  475): app_sock.c: __connect_client_sock(194) > connect error: 111
12-11 20:12:10.820+0900 E/AUL     (  475): app_sock.c: __create_client_sock(160) > cannot connect the client socket: 111
12-11 20:12:10.885+0900 W/CRASH_MANAGER( 8377): worker.c: worker_job(1199) > 1107898626c61144983233
