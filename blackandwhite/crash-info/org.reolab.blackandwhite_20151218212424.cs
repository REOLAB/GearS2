S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 2556
Date: 2015-12-18 21:24:24+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1c6

Register Information
r0   = 0x000001ba, r1   = 0x0000000d
r2   = 0x0000000a, r3   = 0x41453194
r4   = 0x000001ba, r5   = 0x00000000
r6   = 0x41648ce4, r7   = 0x41621e08
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbe951c44, sp   = 0xbe951bf8
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   489992 KB
MemFree:     28040 KB
Buffers:      5792 KB
Cached:      85056 KB
VmPeak:     112184 KB
VmSize:     111672 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16140 KB
VmRSS:       16140 KB
VmData:      55144 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 2556 TID = 2556
2556 2755 2766 

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
415b2000 415b6000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
415c6000 415cd000 r-xp /usr/lib/libappcore-watch.so.1.1
416de000 4170e000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
4170f000 41723000 r-xp /usr/lib/libcapi-network-nfc.so.0.2.3
4172b000 41738000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.55
41740000 41745000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
4174d000 41753000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
4175b000 41762000 rw-p [heap]
41762000 41810000 rw-p [heap]
419ce000 419db000 r-xp /usr/lib/libalarm.so.0.0.0
419e4000 41b21000 r-xp /usr/lib/libicui18n.so.51.1
41b31000 41c15000 r-xp /usr/lib/libicuuc.so.51.1
41c2a000 41c30000 r-xp /usr/lib/libwidget.so.1.0.0
41c39000 41c3e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41c46000 41c7d000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41c86000 41c9f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41ca8000 41cd2000 r-xp /usr/lib/libnfc.so.1.0.0
41cdb000 41d0c000 r-xp /usr/lib/libmdm.so.1.1.85
41d14000 41d2a000 r-xp /usr/lib/libnetwork.so.0.0.0
41d33000 41d38000 r-xp /usr/lib/libcsc-feature.so.0.0.0
432c7000 432d0000 r-xp /usr/lib/libcom-core.so.0.0.1
432d9000 432e5000 r-xp /usr/lib/libwidget_service.so.1.0.0
432ed000 432f6000 r-xp /usr/lib/libwidget_provider.so.1.0.0
432ff000 43305000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4330d000 43315000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4331d000 4334b000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
43357000 4335f000 r-xp /usr/lib/libdrm.so.2.4.0
43367000 43369000 r-xp /usr/lib/libdri2.so.0.0.0
43371000 43378000 r-xp /usr/lib/libtbm.so.1.0.0
43380000 4339a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
433a3000 433aa000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
433b3000 433b5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
433bd000 433c4000 r-xp /usr/lib/libminizip.so.1.0.0
433cc000 433d9000 r-xp /usr/lib/libail.so.0.1.0
43714000 43f13000 rw-p [stack:2755]
43f13000 43f16000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f1e000 43f29000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43f32000 43f49000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44207000 44209000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:2766]
be932000 be953000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2556)
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
000)
12-18 21:23:10.786+0900 I/TIZEN_N_SOUND_MANAGER( 9325): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-18 21:23:10.821+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1519) > [_on_lcd_signal_receive_cb:1519] _on_lcd_signal_receive_cb, 1519, Pre LCD on by [gesture] after screen off time [106974]ms
12-18 21:23:10.821+0900 W/STARTER (  693): clock-mgr.c: _pre_lcd_on(1245) > [_pre_lcd_on:1245] Will LCD ON as reserved app[(null)] alpm mode[0]
12-18 21:23:10.821+0900 I/SCONTEXT-LIB(  669): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 42 (req_id=1633)
12-18 21:23:10.826+0900 I/APP_CORE( 9295): appcore-efl.c: __do_app(429) > [APP 9295] Event: RESUME State: PAUSED
12-18 21:23:10.826+0900 I/CAPI_APPFW_APPLICATION( 9295): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-18 21:23:10.826+0900 W/W_HOME  ( 9295): main.c: _appcore_resume_cb(681) > appcore resume
12-18 21:23:10.826+0900 W/W_HOME  ( 9295): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
12-18 21:23:10.826+0900 W/W_HOME  ( 9295): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-18 21:23:10.826+0900 W/W_HOME  ( 9295): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-18 21:23:10.826+0900 W/W_HOME  ( 9295): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-18 21:23:10.831+0900 W/W_HOME  ( 9295): main.c: home_resume(733) > clock/widget resumed
12-18 21:23:10.831+0900 W/W_HOME  ( 9295): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-18 21:23:10.831+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-18 21:23:10.856+0900 W/WATCH_CORE( 2401): appcore-watch.c: __widget_resume(1012) > widget_resume
12-18 21:23:10.856+0900 I/CAPI_WATCH_APPLICATION( 2401): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-18 21:23:10.886+0900 W/MUSIC_CONTROL_SERVICE( 9094): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:9094]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
12-18 21:23:10.916+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [gesture]
12-18 21:23:10.916+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[0]
12-18 21:23:10.921+0900 I/SHealth_Common( 9090): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-18 21:23:10.921+0900 I/SHealth_Service( 9090): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-18 21:23:10.961+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 9090): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-18 21:23:10.971+0900 W/W_HOME  ( 9295): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
12-18 21:23:10.971+0900 W/W_HOME  ( 9295): gesture.c: _manual_render_enable(133) > 0
12-18 21:23:10.976+0900 E/WIDGET_EVAS( 9295): widget_viewer_evas.c: evas_render_pre_cb(6758) > [SECURE_LOG] Failed to create a resource lock
12-18 21:23:10.976+0900 E/WIDGET_EVAS( 9295): widget_viewer_evas.c: evas_render_pre_cb(6758) > [SECURE_LOG] Failed to create a resource lock
12-18 21:23:10.981+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-18 21:23:11.046+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-18 21:23:11.051+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 9090): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-18 21:23:11.051+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 9090): preference.c: preference_get_double(1214) > preference_get_double(9090) : pedometer_inactive_period error
12-18 21:23:11.051+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 9090): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-18 21:23:11.051+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 9090): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-18 21:23:11.051+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 9090): preference.c: preference_get_double(1214) > preference_get_double(9090) : inactive_10min_precaution_millisec error
12-18 21:23:11.051+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 9090): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-18 21:23:11.051+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 9090): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-18 21:23:11.051+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 9090): preference.c: preference_get_double(1214) > preference_get_double(9090) : inactive_before_10min_precaution_millisec error
12-18 21:23:11.076+0900 I/TIZEN_N_SOUND_MANAGER( 9325): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-18 21:23:11.076+0900 W/TIZEN_N_SOUND_MANAGER( 9325): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-18 21:23:11.081+0900 W/WAKEUP-SERVICE( 9325): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-18 21:23:11.081+0900 I/HIGEAR  ( 9325): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-18 21:23:11.081+0900 W/WAKEUP-SERVICE( 9325): WakeupService.cpp: OnReceiveDisplayChanged(905) > [0;32mINFO: LCDOn receive data : 1124318408[0;m
12-18 21:23:11.081+0900 W/WAKEUP-SERVICE( 9325): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-18 21:23:11.086+0900 E/CAPI_NETWORK_BLUETOOTH( 2401): bluetooth-adapter.c: bt_adapter_foreach_bonded_device(579) > [bt_adapter_foreach_bonded_device] NOT_INITIALIZED(0xfe400101)
12-18 21:23:11.086+0900 I/TIZEN_N_SOUND_MANAGER( 9325): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-18 21:23:11.091+0900 W/TIZEN_N_SOUND_MANAGER( 9325): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-18 21:23:11.096+0900 I/TIZEN_N_SOUND_MANAGER( 9325): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-18 21:23:11.106+0900 I/TIZEN_N_SOUND_MANAGER( 9325): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-18 21:23:11.106+0900 W/TIZEN_N_SOUND_MANAGER( 9325): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-18 21:23:11.106+0900 W/WAKEUP-SERVICE( 9325): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-18 21:23:11.106+0900 I/HIGEAR  ( 9325): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-18 21:23:11.111+0900 E/blackandwhite( 2401): blackandwhite.c: getBTStatus(92) > bstate = 1
12-18 21:23:11.126+0900 I/CAPI_WATCH_APPLICATION( 2401): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-18 21:23:11.126+0900 W/W_HOME  ( 9295): gesture.c: _widget_updated_cb(190) > widget updated
12-18 21:23:11.126+0900 W/W_HOME  ( 9295): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-18 21:23:11.126+0900 W/W_HOME  ( 9295): gesture.c: _manual_render(176) > 
12-18 21:23:11.146+0900 W/W_HOME  ( 9295): gesture.c: _manual_render(176) > 
12-18 21:23:11.146+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-18 21:23:11.156+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-18 21:23:11.176+0900 E/CAPI_NETWORK_BLUETOOTH( 2401): bluetooth-adapter.c: bt_adapter_foreach_bonded_device(579) > [bt_adapter_foreach_bonded_device] NOT_INITIALIZED(0xfe400101)
12-18 21:23:11.186+0900 W/W_HOME  ( 9295): gesture.c: _manual_render_enable(133) > 0
12-18 21:23:11.211+0900 E/blackandwhite( 2401): blackandwhite.c: getBTStatus(92) > bstate = 1
12-18 21:23:11.836+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-18 21:23:11.836+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-18 21:23:11.836+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-18 21:23:11.836+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-18 21:23:11.836+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-18 21:23:11.836+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-18 21:23:11.836+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-18 21:23:11.836+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-18 21:23:11.846+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-18 21:23:11.846+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-18 21:23:11.846+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-18 21:23:11.846+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-18 21:23:11.846+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-18 21:23:11.846+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-18 21:23:11.846+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-18 21:23:11.846+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-18 21:23:11.846+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-18 21:23:11.846+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-18 21:23:11.856+0900 E/CAPI_APPFW_APP_CONTROL( 9094): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-18 21:23:11.856+0900 W/MUSIC_CONTROL_SERVICE( 9094): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:9094]   value = [true][0m
12-18 21:23:11.886+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-18 21:23:11.946+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9295
12-18 21:23:11.971+0900 W/MUSIC_CONTROL_SERVICE( 9094): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:9094]   [MUSIC_PLAYER_EVENT][0m
12-18 21:23:11.981+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-18 21:23:11.981+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-18 21:23:11.981+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-18 21:23:11.981+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-18 21:23:11.981+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-18 21:23:11.981+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-18 21:23:11.981+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-18 21:23:11.981+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-18 21:23:11.991+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-18 21:23:11.991+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-18 21:23:11.991+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-18 21:23:11.991+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-18 21:23:11.991+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-18 21:23:11.991+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-18 21:23:11.991+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-18 21:23:11.991+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-18 21:23:11.991+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-18 21:23:11.991+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-18 21:23:11.991+0900 W/W_HOME  ( 9295): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-18 21:23:11.991+0900 E/W_HOME  ( 9295): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-18 21:23:11.996+0900 I/CAPI_WATCH_APPLICATION( 2401): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-18 21:23:12.011+0900 W/MUSIC_CONTROL_SERVICE( 9094): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:9094]   [MUSIC_PLAYER_EVENT][0m
12-18 21:23:12.041+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-18 21:23:12.076+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-18 21:23:12.096+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-18 21:23:12.096+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-18 21:23:12.096+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-18 21:23:12.096+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-18 21:23:12.096+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-18 21:23:12.101+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-18 21:23:12.101+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-18 21:23:12.101+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-18 21:23:12.111+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-18 21:23:12.111+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-18 21:23:12.111+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-18 21:23:12.111+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-18 21:23:12.111+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-18 21:23:12.111+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-18 21:23:12.111+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-18 21:23:12.111+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-18 21:23:12.111+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-18 21:23:12.111+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-18 21:23:12.116+0900 W/W_HOME  ( 9295): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-18 21:23:12.116+0900 E/W_HOME  ( 9295): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-18 21:23:12.126+0900 E/CAPI_NETWORK_BLUETOOTH( 2401): bluetooth-adapter.c: bt_adapter_foreach_bonded_device(579) > [bt_adapter_foreach_bonded_device] NOT_INITIALIZED(0xfe400101)
12-18 21:23:12.141+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-18 21:23:12.141+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-18 21:23:12.141+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-18 21:23:12.141+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-18 21:23:12.141+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-18 21:23:12.141+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-18 21:23:12.141+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-18 21:23:12.141+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-18 21:23:12.146+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-18 21:23:12.146+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-18 21:23:12.146+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-18 21:23:12.146+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-18 21:23:12.146+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-18 21:23:12.146+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-18 21:23:12.146+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-18 21:23:12.146+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-18 21:23:12.146+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-18 21:23:12.146+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-18 21:23:12.166+0900 E/blackandwhite( 2401): blackandwhite.c: getBTStatus(92) > bstate = 1
12-18 21:23:13.006+0900 I/CAPI_WATCH_APPLICATION( 2401): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-18 21:23:13.106+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-18 21:23:13.161+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-18 21:23:13.196+0900 E/CAPI_NETWORK_BLUETOOTH( 2401): bluetooth-adapter.c: bt_adapter_foreach_bonded_device(579) > [bt_adapter_foreach_bonded_device] NOT_INITIALIZED(0xfe400101)
12-18 21:23:13.251+0900 E/blackandwhite( 2401): blackandwhite.c: getBTStatus(92) > bstate = 1
12-18 21:23:14.006+0900 I/CAPI_WATCH_APPLICATION( 2401): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-18 21:23:14.101+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-18 21:23:14.146+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-18 21:23:14.191+0900 E/CAPI_NETWORK_BLUETOOTH( 2401): bluetooth-adapter.c: bt_adapter_foreach_bonded_device(579) > [bt_adapter_foreach_bonded_device] NOT_INITIALIZED(0xfe400101)
12-18 21:23:14.246+0900 E/blackandwhite( 2401): blackandwhite.c: getBTStatus(92) > bstate = 1
12-18 21:23:15.006+0900 I/CAPI_WATCH_APPLICATION( 2401): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-18 21:23:15.101+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-18 21:23:15.166+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-18 21:23:15.216+0900 E/CAPI_NETWORK_BLUETOOTH( 2401): bluetooth-adapter.c: bt_adapter_foreach_bonded_device(579) > [bt_adapter_foreach_bonded_device] NOT_INITIALIZED(0xfe400101)
12-18 21:23:15.266+0900 E/blackandwhite( 2401): blackandwhite.c: getBTStatus(92) > bstate = 1
12-18 21:23:16.006+0900 I/CAPI_WATCH_APPLICATION( 2401): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-18 21:23:16.106+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-18 21:23:16.146+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-18 21:23:16.216+0900 E/CAPI_NETWORK_BLUETOOTH( 2401): bluetooth-adapter.c: bt_adapter_foreach_bonded_device(579) > [bt_adapter_foreach_bonded_device] NOT_INITIALIZED(0xfe400101)
12-18 21:23:16.276+0900 E/blackandwhite( 2401): blackandwhite.c: getBTStatus(92) > bstate = 1
12-18 21:23:17.011+0900 I/CAPI_WATCH_APPLICATION( 2401): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-18 21:23:17.106+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-18 21:23:17.161+0900 I/CAPI_NETWORK_WIFI( 2401): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-18 21:23:17.226+0900 E/CAPI_NETWORK_BLUETOOTH( 2401): bluetooth-adapter.c: bt_adapter_foreach_bonded_device(579) > [bt_adapter_foreach_bonded_device] NOT_INITIALIZED(0xfe400101)
12-18 21:23:17.271+0900 W/W_HOME  ( 9295): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-18 21:23:17.271+0900 W/W_HOME  ( 9295): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-18 21:23:17.271+0900 W/W_HOME  ( 9295): gesture.c: _manual_render_enable(133) > 1
12-18 21:23:17.271+0900 W/W_HOME  ( 9295): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-18 21:23:17.271+0900 W/W_HOME  ( 9295): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-18 21:23:17.291+0900 W/WAKEUP-SERVICE( 9325): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-18 21:23:17.291+0900 W/WAKEUP-SERVICE( 9325): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-18 21:23:17.296+0900 I/TIZEN_N_SOUND_MANAGER( 9325): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-18 21:23:17.311+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-18 21:23:17.311+0900 W/STARTER (  693): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-18 21:23:17.311+0900 E/STARTER (  693): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-18 21:23:17.311+0900 W/STARTER (  693): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-18 21:23:17.311+0900 W/STARTER (  693): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-18 21:23:17.316+0900 I/SCONTEXT-LIB(  669): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-18 21:23:17.381+0900 I/TIZEN_N_SOUND_MANAGER( 9325): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-18 21:23:17.381+0900 W/TIZEN_N_SOUND_MANAGER( 9325): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-18 21:23:17.381+0900 E/blackandwhite( 2401): blackandwhite.c: getBTStatus(92) > bstate = 1
12-18 21:23:17.381+0900 W/WAKEUP-SERVICE( 9325): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-18 21:23:17.381+0900 I/HIGEAR  ( 9325): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-18 21:23:17.396+0900 W/WATCH_CORE( 2401): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-18 21:23:17.396+0900 I/WATCH_CORE( 2401): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-18 21:23:17.571+0900 W/MUSIC_CONTROL_SERVICE( 9094): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:9094]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-18 21:23:17.576+0900 I/SHealth_Common( 9090): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-18 21:23:17.581+0900 I/SHealth_Service( 9090): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-18 21:23:17.666+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-18 21:23:17.671+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-18 21:23:17.676+0900 I/APP_CORE( 9295): appcore-efl.c: __do_app(429) > [APP 9295] Event: PAUSE State: RUNNING
12-18 21:23:17.676+0900 I/CAPI_APPFW_APPLICATION( 9295): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-18 21:23:17.676+0900 W/W_HOME  ( 9295): main.c: _appcore_pause_cb(690) > appcore pause
12-18 21:23:17.676+0900 W/W_HOME  ( 9295): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-18 21:23:17.676+0900 W/W_HOME  ( 9295): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-18 21:23:17.676+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-18 21:23:17.676+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-18 21:23:17.676+0900 W/W_HOME  ( 9295): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-18 21:23:17.676+0900 W/W_HOME  ( 9295): main.c: home_pause(751) > clock/widget paused
12-18 21:23:17.676+0900 W/W_HOME  ( 9295): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-18 21:23:17.676+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-18 21:23:17.676+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-18 21:23:17.676+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-18 21:23:17.676+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-18 21:23:17.676+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-18 21:23:17.676+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-18 21:23:17.676+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-18 21:23:17.676+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-18 21:23:17.681+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-18 21:23:17.681+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-18 21:23:17.681+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-18 21:23:17.681+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-18 21:23:17.681+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-18 21:23:17.681+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-18 21:23:17.681+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-18 21:23:17.681+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-18 21:23:17.681+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-18 21:23:17.681+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-18 21:23:17.681+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-18 21:23:17.686+0900 E/CAPI_APPFW_APP_CONTROL( 9094): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-18 21:23:17.686+0900 W/MUSIC_CONTROL_SERVICE( 9094): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:9094]   value = [false][0m
12-18 21:23:17.691+0900 W/WATCH_CORE( 2401): appcore-watch.c: __widget_pause(1001) > widget_pause
12-18 21:23:18.186+0900 I/APP_CORE( 9295): appcore-efl.c: __do_app(429) > [APP 9295] Event: MEM_FLUSH State: PAUSED
12-18 21:23:20.796+0900 I/WEMAIL_CONSUMER( 1540): wemail-consumer.c: __kill_timer_cb(252) >  Enter
12-18 21:23:20.796+0900 I/CAPI_APPFW_APPLICATION( 1540): service_app_main.c: service_app_exit(441) > service_app_exit
12-18 21:23:20.801+0900 I/WEMAIL_CONSUMER( 1540): wemail-consumer.c: __kill_timer_cb(259) >  Leave
12-18 21:23:20.826+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 22
12-18 21:23:20.826+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(884) > app status : 4
12-18 21:23:20.846+0900 I/WEMAIL_CONSUMER( 1540): main.c: __service_app_terminate(37) >  Enter
12-18 21:23:20.846+0900 W/WEMAIL_CONSUMER( 1540): main.c: __service_app_terminate(38) >  Goodbye world!
12-18 21:23:20.851+0900 I/WEMAIL_CONSUMER( 1540): wemail-consumer.c: _consumer_deinit(108) >  Enter
12-18 21:23:20.856+0900 I/WEMAIL_CONSUMER( 1540): wemail-consumer-notification-mgr.c: _notification_deinit(59) >  Enter
12-18 21:23:20.856+0900 I/WEMAIL_CONSUMER( 1540): wemail-consumer-notification-mgr.c: _notification_deinit(64) >  Leave
12-18 21:23:20.861+0900 I/WEMAIL_CONSUMER( 1540): wemail-consumer-db.c: _db_deinit(223) >  _g_db_ref_cnt count: 1
12-18 21:23:20.871+0900 I/WEMAIL_COMMON( 1540): wemail-db-util.c: _db_deinit(474) >  Enter
12-18 21:23:20.871+0900 I/WEMAIL_COMMON( 1540): wemail-db-util.c: _db_deinit(478) >  db deinit count: 1
12-18 21:23:20.876+0900 I/WEMAIL_CONSUMER( 1540): wemail-consumer-db.c: _db_deinit(236) >  Leave
12-18 21:23:20.881+0900 I/WEMAIL_CONSUMER( 1540): wemail-consumer-ipc.c: _ipc_deinit(121) >  Enter
12-18 21:23:21.001+0900 I/WEMAIL_CONSUMER( 1540): wemail-consumer-ipc.c: _ipc_deinit(125) >  Leave
12-18 21:23:21.001+0900 I/WEMAIL_CONSUMER( 1540): wemail-consumer.c: __text_locale_deinit(286) >  Enter
12-18 21:23:21.016+0900 I/WEMAIL_CONSUMER( 1540): wemail-consumer.c: _consumer_deinit(125) >  Leave
12-18 21:23:21.016+0900 I/WEMAIL_CONSUMER( 1540): main.c: __service_app_terminate(44) >  Leave
12-18 21:23:21.216+0900 I/efl-extension( 1540): efl_extension.c: eext_mod_shutdown(46) > Shutdown
12-18 21:23:21.736+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 23
12-18 21:23:21.736+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-18 21:23:21.736+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 1540
12-18 21:23:21.736+0900 W/AUL_AMD (  479): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-18 21:23:21.751+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1540
12-18 21:23:22.686+0900 I/APP_CORE( 9295): appcore-efl.c: __do_app(429) > [APP 9295] Event: MEM_FLUSH State: PAUSED
12-18 21:23:22.831+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-18 21:23:25.796+0900 W/LFE      (12393): [12418] 12:15:49.958[F:lfeWatchdog.cpp  L:  119][01][HIGH] Send Notify to Main thread. 484th=1
12-18 21:23:25.796+0900 W/LFE      (12393): [12393] 12:15:49.963[F:lfeWatchdog.cpp  L:   90][01][HIGH] Got thread notify. g_MainThreadLockup=1 g_write_lock=0
12-18 21:23:34.201+0900 E/SHealth_Common( 9090): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-18 21:23:45.721+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-18 21:23:45.721+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-18 21:24:05.901+0900 W/LFE      (12393): [12418] 12:16:30.065[F:lfeWatchdog.cpp  L:  119][01][HIGH] Send Notify to Main thread. 485th=1
12-18 21:24:06.001+0900 W/LFE      (12393): [12393] 12:16:30.165[F:lfeWatchdog.cpp  L:   90][01][HIGH] Got thread notify. g_MainThreadLockup=1 g_write_lock=0
12-18 21:24:06.331+0900 E/PKGMGR_SERVER( 2751): pkgmgr-server.c: main(2126) > package manager server start
12-18 21:24:06.471+0900 E/PKGMGR_SERVER( 2751): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_925581855], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-18 21:24:06.481+0900 E/PKGMGR  ( 2745): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-18 21:24:06.481+0900 E/PKGMGR_SERVER( 2752): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-18 21:24:06.566+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-18 21:24:06.571+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2401
12-18 21:24:06.576+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-18 21:24:06.581+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 5
12-18 21:24:06.581+0900 W/CAPI_WATCH_APPLICATION( 2401): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-18 21:24:06.581+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 22
12-18 21:24:06.581+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(884) > app status : 4
12-18 21:24:06.581+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(2401), cmd(4)
12-18 21:24:06.586+0900 W/WATCH_CORE( 2401): appcore-watch.c: __widget_destroy(992) > widget_destory
12-18 21:24:06.586+0900 E/WIDGET_PROVIDER_APP( 2401): client.c: client_fini(1175) > Provider is not initialized
12-18 21:24:06.586+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-18 21:24:06.596+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2401
12-18 21:24:06.596+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 4
12-18 21:24:06.706+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-18 21:24:06.776+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-18 21:24:06.816+0900 E/PKGMGR_SERVER( 2752): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-18 21:24:06.851+0900 E/AUL_AMD (  479): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-18 21:24:06.851+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(2401), cmd(4)
12-18 21:24:06.856+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-18 21:24:06.896+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-18 21:24:06.911+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-18 21:24:06.911+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-18 21:24:06.911+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 698
12-18 21:24:06.951+0900 E/PKGMGR_SERVER( 2751): pkgmgr-server.c: sighandler(445) > child NORMAL exit [2752]
12-18 21:24:06.986+0900 E/RESOURCED(  480): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 11
12-18 21:24:06.986+0900 E/RESOURCED(  480): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-18 21:24:07.001+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(2026) > pad pid(-5)
12-18 21:24:07.001+0900 W/AUL_PAD ( 1168): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-18 21:24:07.001+0900 W/AUL_PAD ( 1168): launchpad.c: __send_result_to_caller(265) > Check app launching
12-18 21:24:07.046+0900 I/CAPI_WATCH_APPLICATION( 2556): watch_app_main.c: watch_app_main(382) > watch_app_main
12-18 21:24:07.071+0900 E/TBM     ( 2556): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-18 21:24:07.111+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2401
12-18 21:24:07.151+0900 W/WATCH_CORE( 2556): appcore-watch.c: __widget_create(958) > widget_create
12-18 21:24:07.156+0900 E/WIDGET_VIEWER( 9295): client.c: master_created(1712) > [SECURE_LOG] [109948.015625] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_9295_109948.015625.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263418:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-18 21:24:07.156+0900 E/WIDGET_VIEWER( 9295): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[109948.015625] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_9295_109948.015625.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263418:4] gbar_fname[]
12-18 21:24:07.171+0900 E/WIDGET_VIEWER( 9295): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-18 21:24:07.171+0900 E/WIDGET_EVAS( 9295): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-18 21:24:07.301+0900 I/CAPI_NETWORK_WIFI( 2556): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-18 21:24:07.316+0900 I/CAPI_NETWORK_WIFI( 2556): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-18 21:24:07.391+0900 E/CAPI_NETWORK_BLUETOOTH( 2556): bluetooth-adapter.c: bt_adapter_foreach_bonded_device(579) > [bt_adapter_foreach_bonded_device] NOT_INITIALIZED(0xfe400101)
12-18 21:24:07.486+0900 E/blackandwhite( 2556): blackandwhite.c: getBTStatus(92) > bstate = 1
12-18 21:24:07.501+0900 W/WATCH_CORE( 2556): appcore-watch.c: __widget_create(976) > widget_create done
12-18 21:24:07.551+0900 I/WATCH_CORE( 2556): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-18 21:24:07.551+0900 I/WATCH_CORE( 2556): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-18 21:24:07.551+0900 I/WATCH_CORE( 2556): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-18 21:24:08.111+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-18 21:24:08.111+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-18 21:24:08.141+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-18 21:24:08.146+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2556
12-18 21:24:08.146+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-18 21:24:08.346+0900 I/AUL_PAD ( 2781): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-18 21:24:08.586+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-18 21:24:08.761+0900 E/PKGMGR_SERVER( 2751): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-18 21:24:08.761+0900 E/PKGMGR_SERVER( 2751): pkgmgr-server.c: main(2180) > package manager server terminated.
12-18 21:24:17.976+0900 E/PKGMGR  ( 2889): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-18 21:24:18.156+0900 E/PKGMGR_SERVER( 2891): pkgmgr-server.c: main(2126) > package manager server start
12-18 21:24:18.336+0900 E/PKGMGR_SERVER( 2891): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_937367608], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_937367608' '-r' 'org.reolab.blackandwhite'], cookie=[YQG4W47W3Gk7NVFkI5aFo1ycbSY=], backend_flag=[0]
12-18 21:24:18.341+0900 E/PKGMGR  ( 2891): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-18 21:24:18.341+0900 E/PKGMGR_SERVER( 2891): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-18 21:24:18.356+0900 E/PKGMGR  ( 2889): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[28890002]
12-18 21:24:18.356+0900 E/PKGMGR_SERVER( 2892): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-18 21:24:18.521+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-18 21:24:18.531+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-18 21:24:18.536+0900 W/W_HOME  ( 9295): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-18 21:24:18.551+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-18 21:24:19.141+0900 E/PKGMGR_CERT( 2892): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-18 21:24:19.151+0900 E/PKGMGR_CERT( 2892): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 96
12-18 21:24:19.151+0900 E/PKGMGR_CERT( 2892): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 96
12-18 21:24:19.151+0900 E/PKGMGR_CERT( 2892): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 3
12-18 21:24:19.151+0900 E/PKGMGR_CERT( 2892): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 3
12-18 21:24:19.156+0900 E/PKGMGR_CERT( 2892): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 3
12-18 21:24:19.156+0900 E/PKGMGR_CERT( 2892): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 3
12-18 21:24:19.161+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-18 21:24:19.176+0900 E/PKGMGR_CERT( 2892): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-18 21:24:20.761+0900 E/PKGMGR_SERVER( 2891): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-18 21:24:20.991+0900 E/rpm-installer( 2892): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-18 21:24:22.761+0900 E/PKGMGR_SERVER( 2891): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-18 21:24:24.061+0900 E/PKGMGR_SERVER( 2891): pkgmgr-server.c: sighandler(445) > child NORMAL exit [2892]
12-18 21:24:24.076+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-18 21:24:24.081+0900 W/W_HOME  ( 9295): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-18 21:24:24.081+0900 W/W_HOME  ( 9295): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-18 21:24:24.121+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-18 21:24:24.121+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-18 21:24:24.121+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-18 21:24:24.121+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-18 21:24:24.151+0900 W/W_HOME  ( 9295): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-18 21:24:24.221+0900 E/PKGMGR_INFO(  476): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-18 21:24:24.301+0900 E/APPS    ( 9295): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-18 21:24:24.471+0900 W/CRASH_MANAGER( 2896): worker.c: worker_job(1199) > 1102556626c61145044146
