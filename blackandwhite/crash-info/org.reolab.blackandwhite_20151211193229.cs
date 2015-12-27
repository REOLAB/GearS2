S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 7229
Date: 2015-12-11 19:32:29+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x810198ed

Register Information
r0   = 0x810198e1, r1   = 0x0000000d
r2   = 0x81019741, r3   = 0x41553194
r4   = 0x810198e1, r5   = 0x00000000
r6   = 0x414e922c, r7   = 0x414dd608
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeed0c4c, sp   = 0xbeed0c00
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   490336 KB
MemFree:     19804 KB
Buffers:     11032 KB
Cached:      97500 KB
VmPeak:     111464 KB
VmSize:     110952 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16020 KB
VmRSS:       16020 KB
VmData:      54424 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 7229 TID = 7229
7229 7481 7489 

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
43757000 43f56000 rw-p [stack:7481]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:7489]
beeb1000 beed2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7229)
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
und_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-11 19:30:04.885+0900 W/PROCESSMGR(  366): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
12-11 19:30:04.885+0900 W/WATCH_CORE( 6662): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
12-11 19:30:04.885+0900 I/WATCH_CORE( 6662): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
12-11 19:30:04.890+0900 W/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-11 19:30:04.890+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-11 19:30:04.910+0900 W/W_HOME  (  713): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
12-11 19:30:04.910+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:30:04.910+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:30:04.930+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:30:04.930+0900 W/W_HOME  (  713): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
12-11 19:30:04.970+0900 I/MALI    ( 6822): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
12-11 19:30:04.970+0900 I/MALI    ( 6822): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=6822   close drm_fd=28 
12-11 19:30:04.970+0900 I/MALI    ( 6822): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
12-11 19:30:04.990+0900 W/MUSIC_CONTROL_SERVICE( 1067): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1067]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
12-11 19:30:05.040+0900 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [event]
12-11 19:30:05.040+0900 W/STARTER (  705): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[0]
12-11 19:30:05.060+0900 I/UXT     ( 6822): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
12-11 19:30:05.070+0900 W/W_HOME  (  713): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
12-11 19:30:05.070+0900 W/W_HOME  (  713): gesture.c: _manual_render_enable(133) > 0
12-11 19:30:05.125+0900 I/SHealth_Common( 1068): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-11 19:30:05.125+0900 I/SHealth_Service( 1068): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-11 19:30:05.180+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-11 19:30:05.180+0900 W/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-11 19:30:05.180+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-11 19:30:05.180+0900 I/HIGEAR  ( 1108): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-11 19:30:05.310+0900 I/TIZEN_N_SOUND_MANAGER( 6822): sound_manager.c: __sound_manager_finalize(831) > <ENTER>
12-11 19:30:05.310+0900 I/TIZEN_N_SOUND_MANAGER( 6822): sound_manager.c: __sound_manager_finalize(837) > <LEAVE>
12-11 19:30:05.310+0900 I/efl-extension( 6822): efl_extension.c: eext_mod_shutdown(46) > Shutdown
12-11 19:30:05.485+0900 I/AUL_AMD (  454): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 6822
12-11 19:30:05.630+0900 W/AUL_AMD (  454): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 19:30:05.630+0900 W/AUL_AMD (  454): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 19:30:05.630+0900 E/RESOURCED( 1068): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
12-11 19:30:05.630+0900 E/AUL     ( 1068): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
12-11 19:30:05.630+0900 E/CAPI_APPFW_APP_MANAGER( 1068): app_manager.c: app_manager_error(76) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
12-11 19:30:05.840+0900 I/AUL_PAD ( 7229): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 19:30:06.885+0900 W/AUL_AMD (  454): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 19:30:07.595+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.595+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(242) ev->cur.canvas.y(271)
12-11 19:30:07.595+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.600+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9137443 button=1 downs=1
12-11 19:30:07.600+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.600+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(241) ev->cur.canvas.y(268)
12-11 19:30:07.600+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.605+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.605+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(241) ev->cur.canvas.y(266)
12-11 19:30:07.610+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.620+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.620+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(240) ev->cur.canvas.y(265)
12-11 19:30:07.620+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.620+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9137451 button=1 downs=1
12-11 19:30:07.630+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.630+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(239) ev->cur.canvas.y(265)
12-11 19:30:07.630+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.640+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.640+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(237) ev->cur.canvas.y(266)
12-11 19:30:07.640+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.650+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.650+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(235) ev->cur.canvas.y(268)
12-11 19:30:07.650+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.660+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9137512 button=1 downs=0
12-11 19:30:07.675+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9137515 button=1 downs=0
12-11 19:30:07.905+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.905+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(171) ev->cur.canvas.y(277)
12-11 19:30:07.905+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.910+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9137753 button=1 downs=1
12-11 19:30:07.910+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.910+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(166) ev->cur.canvas.y(278)
12-11 19:30:07.910+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.920+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.920+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(160) ev->cur.canvas.y(278)
12-11 19:30:07.920+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.930+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.930+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(155) ev->cur.canvas.y(277)
12-11 19:30:07.930+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.930+0900 E/EFL     (  713): evas_main<713> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=9137780 device=10 downs=2
12-11 19:30:07.935+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9137760 button=1 downs=1
12-11 19:30:07.950+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=9137783 device=10 downs=2
12-11 19:30:07.960+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.960+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(156) ev->cur.canvas.y(279)
12-11 19:30:07.960+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.970+0900 E/EFL     (  713): evas_main<713> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=9137823 device=10 downs=1
12-11 19:30:07.980+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:07.985+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(162) ev->cur.canvas.y(273)
12-11 19:30:07.985+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:07.985+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=9137825 device=10 downs=1
12-11 19:30:07.995+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9137844 button=1 downs=0
12-11 19:30:08.010+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9137848 button=1 downs=0
12-11 19:30:08.185+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:08.185+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(274) ev->cur.canvas.y(185)
12-11 19:30:08.185+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:08.185+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9138031 button=1 downs=1
12-11 19:30:08.210+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9138039 button=1 downs=1
12-11 19:30:08.230+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:08.230+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(274) ev->cur.canvas.y(186)
12-11 19:30:08.230+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:08.230+0900 E/EFL     (  713): evas_main<713> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=9138079 device=10 downs=2
12-11 19:30:08.240+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9138090 button=1 downs=1
12-11 19:30:08.250+0900 E/EFL     (  713): evas_main<713> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=9138100 device=10 downs=0
12-11 19:30:08.255+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=9138082 device=10 downs=2
12-11 19:30:08.275+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9138095 button=1 downs=1
12-11 19:30:08.295+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=9138102 device=10 downs=0
12-11 19:30:08.415+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:08.415+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(237) ev->cur.canvas.y(188)
12-11 19:30:08.415+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:08.415+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9138262 button=1 downs=1
12-11 19:30:08.415+0900 E/EFL     (  713): evas_main<713> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=9138262 device=10 downs=2
12-11 19:30:08.420+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:08.420+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(237) ev->cur.canvas.y(187)
12-11 19:30:08.420+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:08.435+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=9138266 button=1 downs=1
12-11 19:30:08.460+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=9138267 device=10 downs=2
12-11 19:30:08.460+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-11 19:30:08.465+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(236) ev->cur.canvas.y(189)
12-11 19:30:08.465+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-11 19:30:08.475+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9138324 button=1 downs=1
12-11 19:30:08.475+0900 E/EFL     (  713): evas_main<713> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=9138325 device=10 downs=0
12-11 19:30:08.480+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=9138329 button=1 downs=1
12-11 19:30:08.500+0900 E/EFL     ( 6662): evas_main<6662> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=9138329 device=10 downs=0
12-11 19:30:08.980+0900 W/W_HOME  (  713): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
12-11 19:30:11.515+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 19:30:11.515+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 19:30:11.515+0900 I/RESOURCED(  464): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-11 19:30:11.830+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 98 -> 97 1449829811 391
12-11 19:30:11.830+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 97 1224 37 1979
12-11 19:30:11.830+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 97 0 0 2422
12-11 19:30:11.830+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 97 1416 303 2289
12-11 19:30:11.830+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 97 0 0 0
12-11 19:30:11.830+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 97 0 0 0
12-11 19:30:37.705+0900 W/WATCH_CORE( 6662): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-11 19:30:37.705+0900 I/WATCH_CORE( 6662): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-11 19:30:37.730+0900 W/W_HOME  (  713): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-11 19:30:37.730+0900 W/W_HOME  (  713): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-11 19:30:37.730+0900 W/W_HOME  (  713): gesture.c: _manual_render_enable(133) > 1
12-11 19:30:37.730+0900 W/W_HOME  (  713): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-11 19:30:37.730+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:30:37.740+0900 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-11 19:30:37.740+0900 W/STARTER (  705): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-11 19:30:37.740+0900 E/STARTER (  705): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-11 19:30:37.740+0900 W/STARTER (  705): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-11 19:30:37.740+0900 W/STARTER (  705): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-11 19:30:37.740+0900 I/SCONTEXT-LIB(  662): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-11 19:30:37.765+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-11 19:30:37.765+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-11 19:30:37.765+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-11 19:30:37.840+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-11 19:30:37.840+0900 W/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-11 19:30:37.840+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-11 19:30:37.840+0900 I/HIGEAR  ( 1108): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-11 19:30:38.015+0900 W/MUSIC_CONTROL_SERVICE( 1067): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1067]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-11 19:30:38.020+0900 I/SHealth_Common( 1068): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-11 19:30:38.020+0900 I/SHealth_Service( 1068): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-11 19:30:38.035+0900 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-11 19:30:38.035+0900 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-11 19:30:38.035+0900 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-11 19:30:38.035+0900 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[0]
12-11 19:30:38.045+0900 I/APP_CORE(  713): appcore-efl.c: __do_app(429) > [APP 713] Event: PAUSE State: PAUSED
12-11 19:30:38.060+0900 W/ALARM_MANAGER(  705): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(20), start(11-12-2015, 19:30:58), repeat(1), interval(20), type(-1073741822)
12-11 19:30:38.140+0900 W/ALARM_MANAGER(  460): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1363055247, next duetime: 1449829858
12-11 19:30:38.140+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(1363055247)
12-11 19:30:38.140+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449830315), due_time(1449829858)
12-11 19:30:38.140+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-11 19:30:38.140+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 10:30:58 (UTC).
12-11 19:30:38.140+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-11 19:30:40.575+0900 E/W-CONTACTS2-CONSUMER( 7165): ct-sap-svc-client.c: __ct_sap_svc_client_exit_consumer(691) > [0;31m* Critical * Total allocated space (uordblks):838992
12-11 19:30:40.575+0900 E/W-CONTACTS2-CONSUMER( 7165): [0;m
12-11 19:30:40.575+0900 I/CAPI_APPFW_APPLICATION( 7165): service_app_main.c: service_app_exit(441) > service_app_exit
12-11 19:30:40.575+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 19:30:40.575+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(884) > app status : 4
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 19:30:40.700+0900 E/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
12-11 19:30:40.700+0900 E/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(7165) are closed. delete client info
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
12-11 19:30:40.700+0900 E/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  7165
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: UnregisterMessagePortByDiscon(280) > _MessagePortService::UnregisterMessagePortByDiscon
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.700+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-11 19:30:40.770+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 23
12-11 19:30:40.770+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-11 19:30:40.770+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 7165
12-11 19:30:40.770+0900 W/AUL_AMD (  454): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-11 19:30:40.775+0900 I/AUL_AMD (  454): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7165
12-11 19:30:42.580+0900 W/AUL_AMD (  454): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 19:30:57.995+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-11 19:30:58.005+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-11 19:30:58.030+0900 E/RESOURCED(  464): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 705
12-11 19:30:58.035+0900 W/ALARM_MANAGER(  705): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [1363055247]
12-11 19:30:58.035+0900 W/STARTER (  705): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(926) > [__starter_clock_mgr_homescreen_alarm_cb:926] homescreen alarm timer expired [1363055247]
12-11 19:30:58.040+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 19:30:58.045+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(1659) > caller pid : 705
12-11 19:30:58.050+0900 W/AUL_AMD (  454): amd_launch.c: __nofork_processing(1138) > __nofork_processing, cmd: 0, pid: 713
12-11 19:30:58.055+0900 I/APP_CORE(  713): appcore-efl.c: __do_app(429) > [APP 713] Event: RESET State: PAUSED
12-11 19:30:58.055+0900 I/CAPI_APPFW_APPLICATION(  713): app_main.c: app_appcore_reset(245) > app_appcore_reset
12-11 19:30:58.055+0900 W/W_HOME  (  713): main.c: _app_control(1726) > Service value : show_clock
12-11 19:30:58.055+0900 W/W_HOME  (  713): main.c: _app_control(1762) > Show clock operation
12-11 19:30:58.055+0900 W/W_HOME  (  713): gesture.c: _clock_show(228) > clock show
12-11 19:30:58.055+0900 W/W_HOME  (  713): gesture.c: _clock_show(243) > home raise
12-11 19:30:58.055+0900 E/W_HOME  (  713): gesture.c: gesture_win_aux_set(396) > wm.policy.win.do.not.use.deiconify.approve:-1
12-11 19:30:58.060+0900 W/AUL_AMD (  454): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(713), cmd(0)
12-11 19:30:58.070+0900 I/efl-extension(27660): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 19:30:58.070+0900 W/wnotibp (27660): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1721) > [0, 2, 1]
12-11 19:30:58.070+0900 W/W_HOME  (  713): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
12-11 19:30:58.070+0900 W/W_HOME  (  713): gesture.c: _clock_show(246) > home raise done
12-11 19:30:58.070+0900 W/W_HOME  (  713): gesture.c: _clock_show(253) > show clock
12-11 19:30:58.070+0900 I/APP_CORE(  713): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-11 19:30:58.070+0900 E/E17     (  366): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02400003)
12-11 19:30:58.080+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __alarm_expired(1325) > alarm_id[1363055247] is expired.
12-11 19:30:58.080+0900 W/ALARM_MANAGER(  460): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1363055247, next duetime: 1449829878
12-11 19:30:58.080+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-11 19:30:58.080+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 10:31:18 (UTC).
12-11 19:30:58.080+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-11 19:30:58.080+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-11 19:30:58.090+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-11 19:30:58.090+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(1363055247)
12-11 19:30:58.090+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-11 19:30:58.090+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 10:38:35 (UTC).
12-11 19:30:58.090+0900 W/ALARM_MANAGER(  460): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-11 19:30:58.090+0900 W/ALARM_MANAGER(  460): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[1363055247] is removed.
12-11 19:30:59.055+0900 W/AUL_AMD (  454): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 19:30:59.055+0900 W/AUL_AMD (  454): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 19:31:11.515+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 19:31:11.515+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 19:31:38.955+0900 I/CAPI_APPFW_APPLICATION( 7205): service_app_main.c: service_app_exit(441) > service_app_exit
12-11 19:31:38.970+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 19:31:38.970+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(884) > app status : 4
12-11 19:31:39.135+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 23
12-11 19:31:39.135+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-11 19:31:39.135+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 7205
12-11 19:31:39.135+0900 W/AUL_AMD (  454): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-11 19:31:39.140+0900 I/AUL_AMD (  454): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7205
12-11 19:31:40.970+0900 W/AUL_AMD (  454): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 19:32:11.510+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 19:32:11.510+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 19:32:11.555+0900 E/PKGMGR_SERVER( 7474): pkgmgr-server.c: main(2126) > package manager server start
12-11 19:32:11.635+0900 E/PKGMGR_SERVER( 7474): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-703866314], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 19:32:11.640+0900 E/PKGMGR  ( 7472): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 19:32:11.655+0900 E/PKGMGR_SERVER( 7475): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 19:32:11.715+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:32:11.725+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6662
12-11 19:32:11.725+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:32:11.730+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 19:32:11.730+0900 W/CAPI_WATCH_APPLICATION( 6662): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 19:32:11.735+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 19:32:11.735+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(884) > app status : 4
12-11 19:32:11.735+0900 W/AUL_AMD (  454): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(6662), cmd(4)
12-11 19:32:11.735+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:32:11.740+0900 W/WATCH_CORE( 6662): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 19:32:11.740+0900 E/WIDGET_PROVIDER_APP( 6662): client.c: client_fini(1175) > Provider is not initialized
12-11 19:32:11.740+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6662
12-11 19:32:11.745+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 19:32:11.845+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:32:11.855+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 19:32:11.865+0900 E/PKGMGR_SERVER( 7475): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 19:32:11.885+0900 E/PKGMGR_SERVER( 7474): pkgmgr-server.c: sighandler(445) > child NORMAL exit [7475]
12-11 19:32:11.945+0900 E/AUL_AMD (  454): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 19:32:11.945+0900 W/AUL_AMD (  454): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(6662), cmd(4)
12-11 19:32:11.950+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 19:32:11.975+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:32:11.995+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:32:11.995+0900 E/AUL_AMD (  454): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 19:32:11.995+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(1659) > caller pid : 707
12-11 19:32:12.110+0900 E/RESOURCED(  464): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 9
12-11 19:32:12.110+0900 E/RESOURCED(  464): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 19:32:12.115+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 19:32:12.115+0900 W/AUL_PAD ( 1159): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 19:32:12.115+0900 W/AUL_PAD ( 1159): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 19:32:12.155+0900 I/CAPI_WATCH_APPLICATION( 7229): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 19:32:12.175+0900 E/TBM     ( 7229): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 19:32:12.215+0900 I/AUL_AMD (  454): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 6662
12-11 19:32:12.255+0900 W/WATCH_CORE( 7229): appcore-watch.c: __widget_create(958) > widget_create
12-11 19:32:12.260+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1712) > [SECURE_LOG] [7836.844238] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_713_7836.844238.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263216:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 19:32:12.260+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[7836.844238] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_713_7836.844238.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263216:4] gbar_fname[]
12-11 19:32:12.280+0900 E/WIDGET_VIEWER(  713): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 19:32:12.280+0900 E/WIDGET_EVAS(  713): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 19:32:12.410+0900 I/CAPI_NETWORK_WIFI( 7229): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:32:12.420+0900 I/CAPI_NETWORK_WIFI( 7229): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:32:12.580+0900 W/WATCH_CORE( 7229): appcore-watch.c: __widget_create(976) > widget_create done
12-11 19:32:12.615+0900 I/WATCH_CORE( 7229): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 19:32:12.615+0900 I/WATCH_CORE( 7229): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 19:32:12.615+0900 I/WATCH_CORE( 7229): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 19:32:12.655+0900 W/W_HOME  (  713): gesture.c: _widget_updated_cb(190) > widget updated
12-11 19:32:12.655+0900 W/W_HOME  (  713): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-11 19:32:12.655+0900 W/W_HOME  (  713): gesture.c: _manual_render(176) > 
12-11 19:32:12.660+0900 W/W_HOME  (  713): gesture.c: _manual_render(176) > 
12-11 19:32:12.685+0900 W/W_HOME  (  713): gesture.c: _manual_render_enable(133) > 0
12-11 19:32:13.220+0900 W/AUL_AMD (  454): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 19:32:13.220+0900 W/AUL_AMD (  454): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 19:32:13.230+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:32:13.240+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7229
12-11 19:32:13.240+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:32:13.455+0900 I/AUL_PAD ( 7495): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 19:32:13.735+0900 W/AUL_AMD (  454): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 19:32:14.150+0900 E/PKGMGR_SERVER( 7474): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 19:32:14.150+0900 E/PKGMGR_SERVER( 7474): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 19:32:22.860+0900 E/PKGMGR  ( 7612): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 19:32:23.030+0900 E/PKGMGR_SERVER( 7614): pkgmgr-server.c: main(2126) > package manager server start
12-11 19:32:23.120+0900 E/PKGMGR_SERVER( 7614): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-692391481], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-692391481' '-r' 'org.reolab.blackandwhite'], cookie=[7gHrJzcbREW1n9lddH3XbgaNWMQ=], backend_flag=[0]
12-11 19:32:23.120+0900 E/PKGMGR  ( 7614): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 19:32:23.120+0900 E/PKGMGR_SERVER( 7614): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 19:32:23.125+0900 E/PKGMGR_SERVER( 7615): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 19:32:23.130+0900 E/PKGMGR  ( 7612): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[76120002]
12-11 19:32:23.300+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 19:32:23.310+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 19:32:23.315+0900 W/AUL_AMD (  454): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 19:32:23.330+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:32:23.920+0900 E/PKGMGR_CERT( 7615): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 19:32:23.925+0900 E/PKGMGR_CERT( 7615): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
12-11 19:32:23.925+0900 E/PKGMGR_CERT( 7615): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
12-11 19:32:23.925+0900 E/PKGMGR_CERT( 7615): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-11 19:32:23.925+0900 E/PKGMGR_CERT( 7615): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-11 19:32:23.925+0900 E/PKGMGR_CERT( 7615): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-11 19:32:23.925+0900 E/PKGMGR_CERT( 7615): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-11 19:32:23.930+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:32:23.940+0900 E/PKGMGR_CERT( 7615): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 19:32:25.150+0900 E/PKGMGR_SERVER( 7614): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:32:25.710+0900 E/rpm-installer( 7615): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-11 19:32:27.150+0900 E/PKGMGR_SERVER( 7614): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:32:28.955+0900 E/PKGMGR_SERVER( 7614): pkgmgr-server.c: sighandler(445) > child NORMAL exit [7615]
12-11 19:32:28.960+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:32:28.980+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-11 19:32:28.980+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-11 19:32:29.010+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-11 19:32:29.010+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-11 19:32:29.010+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-11 19:32:29.010+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-11 19:32:29.095+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-11 19:32:29.150+0900 E/PKGMGR_SERVER( 7614): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 19:32:29.150+0900 E/PKGMGR_SERVER( 7614): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 19:32:29.165+0900 E/PKGMGR_INFO(  461): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-11 19:32:29.250+0900 E/APPS    (  713): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-11 19:32:29.500+0900 W/CRASH_MANAGER( 7625): worker.c: worker_job(1199) > 1107229626c61144982994
