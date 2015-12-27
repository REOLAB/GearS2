S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 24746
Date: 2015-12-07 21:45:37+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x112

Register Information
r0   = 0x00000106, r1   = 0x0000000d
r2   = 0x00000006, r3   = 0x41553194
r4   = 0x00000106, r5   = 0x00000000
r6   = 0x414e0ccc, r7   = 0x414dd608
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbef10c74, sp   = 0xbef10c28
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     20948 KB
Buffers:     13636 KB
Cached:      94896 KB
VmPeak:      76244 KB
VmSize:      75732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14680 KB
VmRSS:       14680 KB
VmData:      21472 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20468 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 24746 TID = 24746
24746 25657 25664 

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
41553000 41555000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
4155d000 4155f000 r-xp /usr/lib/libdri2.so.0.0.0
41567000 4156c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41574000 41576000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4157f000 41585000 r-xp /usr/lib/libappsvc.so.0.1.0
4158d000 415b1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415ba000 41689000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4169f000 416a9000 r-xp /lib/libnss_files-2.13.so
41970000 41974000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41984000 4198b000 r-xp /usr/lib/libappcore-watch.so.1.1
41994000 419a1000 r-xp /usr/lib/libalarm.so.0.0.0
419aa000 41ae7000 r-xp /usr/lib/libicui18n.so.51.1
41af7000 41bdb000 r-xp /usr/lib/libicuuc.so.51.1
41bf0000 41bf6000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41bfe000 41c04000 r-xp /usr/lib/libwidget.so.1.0.0
43194000 4319d000 r-xp /usr/lib/libcom-core.so.0.0.1
431a6000 431b2000 r-xp /usr/lib/libwidget_service.so.1.0.0
431ba000 431c3000 r-xp /usr/lib/libwidget_provider.so.1.0.0
431cc000 431d4000 r-xp /usr/lib/libdrm.so.2.4.0
431dc000 431e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
431e9000 431f0000 r-xp /usr/lib/libtbm.so.1.0.0
4352a000 43d29000 rw-p [stack:25657]
43d29000 43d2c000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d34000 43d3f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dc7000 43dde000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4401e000 44900000 rw-p [stack:25664]
beef1000 bef12000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24746)
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
ZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-07 21:35:11.779+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-07 21:35:11.779+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-07 21:35:11.779+0900 E/TIZEN_N_SYSTEM_SETTINGS(13736): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-07 21:35:11.824+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3641) > ::UI:: VI TYPE : 1
12-07 21:35:11.824+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3647) > alert_type : 1, is_source_companion: 1
12-07 21:35:11.824+0900 W/TIZEN_N_RECORDER(13736): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
12-07 21:35:11.824+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1258) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
12-07 21:35:11.824+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1267) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
12-07 21:35:11.824+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1301) > ::APP:: Determined feedback: sound 0, vibration: 0
12-07 21:35:11.824+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1305) > No feedback.
12-07 21:35:11.829+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(1)
12-07 21:35:11.829+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
12-07 21:35:11.829+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:35:11.829+0900 W/W_HOME  (  715): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(1)
12-07 21:35:11.829+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: PAUSE State: PAUSED
12-07 21:35:11.834+0900 I/APP_CORE(  715): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
12-07 21:35:11.834+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
12-07 21:35:11.834+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 21:35:11.844+0900 I/wnotibp (13736): wnotiboard-popup.c: _wnotib_popup_ecore_x_event_visibility_changed_cb(1036) > fully_obscured: 0 [0x7e0000a 0x7e0000a 0x7e00008 ]
12-07 21:35:11.844+0900 I/APP_CORE(13736): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
12-07 21:35:11.849+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 21:35:11.849+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-07 21:35:11.914+0900 I/MALI    (13736): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43aa7ef8] swap changed from async to sync
12-07 21:35:12.194+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_show_finished_cb(1009) > ::UI:: popup effect is finished (2070, 4699cf00)
12-07 21:35:12.194+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_view_unlock(908) > ::UI:: [[[ [simple popup] is UNLOCK , 0000 <=== ]]]
12-07 21:35:12.194+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 1 1
12-07 21:35:12.209+0900 E/wnoti-service(  871): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
12-07 21:35:12.214+0900 E/wnoti-service(  871): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 2
12-07 21:35:12.219+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-07 21:35:12.239+0900 E/wnoti-proxy(13736): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
12-07 21:35:12.239+0900 E/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_get_alert_list(908) > ::DATA:: No categories available.
12-07 21:35:12.239+0900 W/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_get_alert_list(911) > ::DATA:: read alert list : 0, list count : 1
12-07 21:35:13.254+0900 E/wnoti-service(  871): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 1
12-07 21:35:15.259+0900 E/wnoti-service(  871): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
12-07 21:35:18.634+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1890) > state : (2, 1, 1)
12-07 21:35:18.634+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1903) > simple popup=4699cf00, view_state=1
12-07 21:35:18.634+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-07 21:35:18.634+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(997) > ::UI:: lock state = 0000
12-07 21:35:18.739+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1963) > device_power_release_lock CPU>>>>>>>
12-07 21:35:18.809+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 21:35:18.809+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-07 21:35:18.874+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 21:35:18.874+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 215, 218
12-07 21:35:18.874+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 21:35:18.874+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1998) > ::INFO:: call lower
12-07 21:35:18.899+0900 W/W_HOME  (  715): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
12-07 21:35:18.899+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:35:18.899+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:35:18.904+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:35:18.904+0900 W/W_HOME  (  715): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
12-07 21:35:18.909+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_del_cb(424) > ::UI:: (3, 4699cf00, 4699cf00, 0)
12-07 21:35:18.909+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(918) > ::DATA:: remove notification data, 2070
12-07 21:35:18.909+0900 I/wnotibp (13736): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(948) > ::DATA:: CHECK DATA : 0, 0
12-07 21:35:18.909+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_view_unlock(910) > ::UI:: [[[ [simple popup] is not in lock state , 0000  <===]]]
12-07 21:35:18.909+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 0 0
12-07 21:35:18.909+0900 I/efl-extension(13736): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4678c448, elm_genlist, _activated_obj : 0x0, activated : 0
12-07 21:35:18.914+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_w_input_selector(4847) > No need to close w-input-selector.
12-07 21:35:18.914+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(0)
12-07 21:35:18.914+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
12-07 21:35:18.914+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:35:18.914+0900 W/W_HOME  (  715): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(0)
12-07 21:35:18.914+0900 I/APP_CORE(  715): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
12-07 21:35:18.914+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
12-07 21:35:18.914+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 21:35:18.914+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-07 21:35:18.924+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:35:18.934+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 21:35:18.939+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_notifiboard_selector(4882) > ret : 0, is_running : 0
12-07 21:35:18.939+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 21:35:18.939+0900 I/wnotibp (13736): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 215, 218
12-07 21:35:18.939+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 21:35:18.949+0900 I/efl-extension(13736): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4678c448, obj: 0x4678c448
12-07 21:35:18.949+0900 I/efl-extension(13736): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-07 21:35:18.959+0900 I/efl-extension(13736): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 21:35:18.959+0900 I/efl-extension(13736): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4678c448, elm_genlist, func : 0x41841e59
12-07 21:35:18.959+0900 I/efl-extension(13736): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 21:35:18.974+0900 I/MALI    (13736): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43aa7ef8] swap changed from sync to async
12-07 21:35:18.974+0900 I/efl-extension(13736): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
12-07 21:35:18.979+0900 W/APP_CORE(13736): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:7e0000a
12-07 21:35:18.979+0900 I/APP_CORE(13736): appcore-efl.c: __do_app(429) > [APP 13736] Event: PAUSE State: RUNNING
12-07 21:35:18.979+0900 I/CAPI_APPFW_APPLICATION(13736): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-07 21:35:18.994+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(267) > fg_app : 1
12-07 21:35:18.999+0900 W/wnotibp (13736): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-07 21:35:18.999+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1368) > [0, 0, 45, 0000]
12-07 21:35:18.999+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [1, 0]
12-07 21:35:18.999+0900 W/wnotibp (13736): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [0, 3, 0, 2, 0]
12-07 21:35:21.074+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:35:21.079+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:35:24.009+0900 I/APP_CORE(13736): appcore-efl.c: __do_app(429) > [APP 13736] Event: MEM_FLUSH State: PAUSED
12-07 21:35:42.844+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 66 -> 65 1449491742 151
12-07 21:35:42.849+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 65 1677 195 1817
12-07 21:35:42.849+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 65 0 0 2174
12-07 21:35:42.849+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 65 1796 299 1946
12-07 21:35:42.849+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 65 174 5 189
12-07 21:35:42.849+0900 I/RESOURCED(  498): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 65 437 25 473
12-07 21:36:21.124+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:36:21.124+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:37:21.134+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:37:21.134+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:38:21.134+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:38:21.139+0900 I/RESOURCED(  498): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-07 21:38:21.139+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:39:06.794+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:39:06.824+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 21:39:06.829+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 26
12-07 21:39:06.869+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
12-07 21:39:06.889+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
12-07 21:39:06.889+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 21:39:06.889+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 483
12-07 21:39:06.914+0900 W/AUL_AMD (  495): amd_launch.c: start_process(573) > child process: 25165
12-07 21:39:06.969+0900 W/AUL_AMD (  495): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 25165
12-07 21:39:06.979+0900 E/RESOURCED(  498): proc-main.c: proc_add_app_list(272) > [proc_add_app_list,272] not found previous pai : com.samsung.w-contacts2.consumer
12-07 21:39:06.979+0900 E/RESOURCED(  498): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-contacts2
12-07 21:39:07.034+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:39:07.044+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 25165
12-07 21:39:07.044+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 21:39:07.099+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
12-07 21:39:07.114+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
12-07 21:39:07.114+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
12-07 21:39:07.124+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:39:07.124+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:39:07.124+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:39:07.124+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
12-07 21:39:07.124+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
12-07 21:39:07.124+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:39:07.124+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.w-contacts2.consumer:w-contacts2-consumer], client = 25165
12-07 21:39:07.124+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:39:07.259+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __ct_sap_svc_client_find_peer_agent(1011) > [0;31m* Critical * connectivity_type 0[0;m
12-07 21:39:07.259+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):108432
12-07 21:39:07.259+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:07.259+0900 W/CAPI_APPFW_APP_CONTROL(25165): app_control.c: app_control_error(138) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
12-07 21:39:07.259+0900 W/CAPI_APPFW_APP_CONTROL(25165): app_control.c: app_control_error(138) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
12-07 21:39:07.269+0900 I/WECONN  (  511): esap.c: __sap_service_signal_peeragent_added_cb(1627) > path: /Application/com_2E_samsung_2E_w_2D_contacts2_2E_consumer/b2_contacts_consumer, [sig: PeerAgentAdded]
12-07 21:39:07.274+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __on_create(1797) > [0;31m* Critical * create service connection failed as unknown error 7[0;m
12-07 21:39:08.269+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __on_receive(1204) > [0;31m* Critical * crypt_key for encrypt version !!![0;m
12-07 21:39:08.349+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):113576
12-07 21:39:08.349+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:08.419+0900 W/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __ct_sap_svc_client_set_logs_sync_status(1045) > [0;35mlogs_sync_status on reconnection: (3) -> (1)[0;m
12-07 21:39:08.419+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):113648
12-07 21:39:08.419+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:08.669+0900 W/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-composer-logs.c: __mark_as_read(654) > [0;35m0 logs has been marked as read[0;m
12-07 21:39:08.699+0900 W/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-composer-logs.c: ct_sap_svc_composer_logs_reset_notification(555) > [0;35mmissed: 0 / total_missed: 35[0;m
12-07 21:39:08.769+0900 E/wnoti-service(  871): wnoti-server-mgr-stub.c: __wnoti_remove_notification_cards_stub(474) > [ERROR] Read Card, No application panel app_id = com.samsung.w-logs2, panel_id = missed_call
12-07 21:39:08.769+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-07 21:39:08.794+0900 W/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-composer-logs.c: ct_sap_svc_composer_logs_clear_notification_by_host(692) > [0;35m0 logs updated[0;m
12-07 21:39:08.794+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):119512
12-07 21:39:08.794+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:08.954+0900 W/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-composer-logs.c: __log_get_from_db(273) > [0;35mget 1000 records(err:0)[0;m
12-07 21:39:08.999+0900 W/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __ct_sap_svc_client_sync_deleted_logs(1069) > [0;35mnothing to upload[0;m
12-07 21:39:08.999+0900 W/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __ct_sap_svc_client_set_logs_sync_status(1045) > [0;35mlogs_sync_status on reconnection: (1) -> (3)[0;m
12-07 21:39:08.999+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(25165): preference.c: _preference_check_retry_err(507) > key(calllog-markasread-pending), check retry err: -21/(2/No such file or directory).
12-07 21:39:08.999+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(25165): preference.c: _preference_get_key(1101) > _preference_get_key(calllog-markasread-pending) step(-17825744) failed(2 / No such file or directory)
12-07 21:39:08.999+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE(25165): preference.c: preference_get_boolean(1173) > preference_get_boolean(25165) : calllog-markasread-pending error
12-07 21:39:08.999+0900 W/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __ct_sap_svc_client_sync_noti_clear_on_host(208) > [0;35msynced already.[0;m
12-07 21:39:08.999+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):227424
12-07 21:39:08.999+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:10.979+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-parser-contacts.c: ct_sap_svc_parser_contacts_get_buddylist(2513) > [0;31m* Critical * json_object_has_member(rawContacts) is failed[0;m
12-07 21:39:10.979+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-parser-contacts.c: ct_sap_svc_parser_contacts_get_buddylist(2561) > [0;31m* Critical * json_array_get_length(0)[0;m
12-07 21:39:10.979+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_free_foreach_data(1338) > [0;31m* Critical * foreach_data is NULL[0;m
12-07 21:39:10.979+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_free_contacts_record_hash_table_for_buddy(1485) > [0;31m* Critical * (NULL == __hash_table_contacts_for_buddy)[0;m
12-07 21:39:10.984+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):224984
12-07 21:39:10.984+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:10.984+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:39:10.984+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:39:10.984+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:39:10.984+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:39:10.984+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:39:10.984+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:39:10.984+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-buddy:w-buddy]
12-07 21:39:10.984+0900 E/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(354) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-07 21:39:10.984+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:39:10.984+0900 E/MESSAGE_PORT(25165): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
12-07 21:39:11.444+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __ct_sap_svc_decrypt_data(563) > [0;31m* Critical * EVP_CipherInit_ex - err:1[0;m
12-07 21:39:11.784+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __ct_sap_svc_decrypt_data(563) > [0;31m* Critical * EVP_CipherInit_ex - err:1[0;m
12-07 21:39:11.829+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):245144
12-07 21:39:11.829+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:11.839+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):255928
12-07 21:39:11.839+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:12.914+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):726576
12-07 21:39:12.914+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:13.379+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):726608
12-07 21:39:13.379+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:13.699+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):268760
12-07 21:39:13.699+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:13.704+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):263080
12-07 21:39:13.704+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:13.744+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(858) > [0;31m* Critical * [PERFORMANCE] __ct_sap_svc_client_read_file end[0;m
12-07 21:39:13.849+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __ct_sap_svc_client_read_files_end(901) > [0;31m* Critical * CALLING __ct_sap_svc_client_exit_consumer - contact[0;m
12-07 21:39:21.074+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:39:21.079+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:39:22.254+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-parser-contacts.c: ct_sap_svc_parser_contacts_get_buddylist(2513) > [0;31m* Critical * json_object_has_member(rawContacts) is failed[0;m
12-07 21:39:22.254+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-parser-contacts.c: ct_sap_svc_parser_contacts_get_buddylist(2561) > [0;31m* Critical * json_array_get_length(0)[0;m
12-07 21:39:22.254+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_free_foreach_data(1338) > [0;31m* Critical * foreach_data is NULL[0;m
12-07 21:39:22.254+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_free_contacts_record_hash_table_for_buddy(1485) > [0;31m* Critical * (NULL == __hash_table_contacts_for_buddy)[0;m
12-07 21:39:22.269+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):523312
12-07 21:39:22.269+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:39:22.279+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:39:22.279+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:39:22.279+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:39:22.279+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:39:22.279+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:39:22.279+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:39:22.279+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-buddy:w-buddy]
12-07 21:39:22.279+0900 E/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(354) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-07 21:39:22.279+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:39:22.284+0900 E/MESSAGE_PORT(25165): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
12-07 21:40:21.134+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:40:21.134+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:40:22.334+0900 E/W-CONTACTS2-CONSUMER(25165): ct-sap-svc-client.c: __ct_sap_svc_client_exit_consumer(691) > [0;31m* Critical * Total allocated space (uordblks):522840
12-07 21:40:22.334+0900 E/W-CONTACTS2-CONSUMER(25165): [0;m
12-07 21:40:22.339+0900 I/CAPI_APPFW_APPLICATION(25165): service_app_main.c: service_app_exit(441) > service_app_exit
12-07 21:40:22.354+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 21:40:22.354+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(884) > app status : 4
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:40:22.539+0900 E/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
12-07 21:40:22.539+0900 E/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(25165) are closed. delete client info
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
12-07 21:40:22.539+0900 E/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  25165
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: UnregisterMessagePortByDiscon(280) > _MessagePortService::UnregisterMessagePortByDiscon
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 21:40:22.659+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 23
12-07 21:40:22.659+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-07 21:40:22.659+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 25165
12-07 21:40:22.659+0900 W/AUL_AMD (  495): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-07 21:40:22.669+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 25165
12-07 21:40:24.359+0900 W/AUL_AMD (  495): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 21:41:21.134+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:41:21.134+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:42:21.134+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:42:21.134+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:42:42.439+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 1 -> 2
12-07 21:42:42.444+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-07 21:42:42.444+0900 E/WMS     (  491): ==========
12-07 21:42:42.444+0900 E/WMS     (  491): ##WMS SEND : mgr_gear_wear_onoff_req
12-07 21:42:42.444+0900 E/WMS     (  491): ==========
12-07 21:42:42.444+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-07 21:43:21.114+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:43:21.114+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:44:21.134+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:44:21.139+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:44:21.139+0900 I/RESOURCED(  498): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-07 21:45:12.139+0900 E/PKGMGR_SERVER(25648): pkgmgr-server.c: main(2126) > package manager server start
12-07 21:45:12.279+0900 E/PKGMGR_SERVER(25648): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_979156733], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-07 21:45:12.289+0900 E/PKGMGR  (25641): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-07 21:45:12.289+0900 E/PKGMGR_SERVER(25649): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-07 21:45:12.354+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:45:12.364+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24613
12-07 21:45:12.364+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 21:45:12.369+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 5
12-07 21:45:12.374+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(24613), cmd(4)
12-07 21:45:12.374+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:45:12.374+0900 W/CAPI_WATCH_APPLICATION(24613): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-07 21:45:12.374+0900 W/WATCH_CORE(24613): appcore-watch.c: __widget_destroy(992) > widget_destory
12-07 21:45:12.374+0900 E/WIDGET_PROVIDER_APP(24613): client.c: client_fini(1175) > Provider is not initialized
12-07 21:45:12.379+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24613
12-07 21:45:12.379+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 21:45:12.379+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(884) > app status : 4
12-07 21:45:12.384+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 21:45:12.484+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:45:12.564+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 21:45:12.634+0900 E/AUL_AMD (  495): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-07 21:45:12.634+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(24613), cmd(4)
12-07 21:45:12.639+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 21:45:12.699+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 21:45:12.724+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 21:45:12.724+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 21:45:12.724+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 21:45:12.764+0900 E/PKGMGR_SERVER(25649): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-07 21:45:12.814+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 21:45:12.819+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 21:45:12.849+0900 E/PKGMGR_SERVER(25648): pkgmgr-server.c: sighandler(445) > child NORMAL exit [25649]
12-07 21:45:12.889+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 21:45:12.889+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-07 21:45:12.889+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 21:45:12.914+0900 I/CAPI_WATCH_APPLICATION(24746): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 21:45:12.939+0900 E/TBM     (24746): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 21:45:12.994+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 24613
12-07 21:45:13.029+0900 W/WATCH_CORE(24746): appcore-watch.c: __widget_create(958) > widget_create
12-07 21:45:13.034+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [76046.937500] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29360948:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 21:45:13.034+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[76046.937500] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29360948:4] gbar_fname[]
12-07 21:45:13.049+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 21:45:13.049+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 21:45:13.119+0900 W/WATCH_CORE(24746): appcore-watch.c: __widget_create(976) > widget_create done
12-07 21:45:13.189+0900 I/WATCH_CORE(24746): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-07 21:45:13.189+0900 I/WATCH_CORE(24746): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-07 21:45:13.189+0900 I/WATCH_CORE(24746): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-07 21:45:13.994+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 21:45:13.994+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 21:45:14.009+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:45:14.019+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24746
12-07 21:45:14.019+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 21:45:14.194+0900 I/AUL_PAD (25667): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 21:45:14.384+0900 W/AUL_AMD (  495): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 21:45:14.829+0900 E/PKGMGR_SERVER(25648): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 21:45:14.834+0900 E/PKGMGR_SERVER(25648): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 21:45:21.079+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:45:21.079+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:45:31.404+0900 E/PKGMGR  (25814): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-07 21:45:31.569+0900 E/PKGMGR_SERVER(25816): pkgmgr-server.c: main(2126) > package manager server start
12-07 21:45:31.644+0900 E/PKGMGR_SERVER(25816): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_998569197], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_998569197' '-r' 'org.reolab.blackandwhite'], cookie=[lKTKyC9lEdTdokTkN67LwIo8Sjo=], backend_flag=[0]
12-07 21:45:31.649+0900 E/PKGMGR  (25816): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-07 21:45:31.649+0900 E/PKGMGR_SERVER(25816): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-07 21:45:31.659+0900 E/PKGMGR  (25814): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[258140002]
12-07 21:45:31.664+0900 E/PKGMGR_SERVER(25817): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-07 21:45:31.834+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-07 21:45:31.834+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:45:31.839+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 21:45:31.869+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-07 21:45:32.424+0900 E/PKGMGR_CERT(25817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-07 21:45:32.434+0900 E/PKGMGR_CERT(25817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-07 21:45:32.439+0900 E/PKGMGR_CERT(25817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-07 21:45:32.439+0900 E/PKGMGR_CERT(25817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-07 21:45:32.439+0900 E/PKGMGR_CERT(25817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-07 21:45:32.439+0900 E/PKGMGR_CERT(25817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-07 21:45:32.439+0900 E/PKGMGR_CERT(25817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-07 21:45:32.444+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:45:32.459+0900 E/PKGMGR_CERT(25817): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-07 21:45:33.829+0900 E/PKGMGR_SERVER(25816): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 21:45:34.224+0900 E/rpm-installer(25817): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-07 21:45:35.829+0900 E/PKGMGR_SERVER(25816): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 21:45:37.159+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:45:37.159+0900 E/PKGMGR_SERVER(25816): pkgmgr-server.c: sighandler(445) > child NORMAL exit [25817]
12-07 21:45:37.174+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-07 21:45:37.174+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-07 21:45:37.189+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-07 21:45:37.189+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-07 21:45:37.189+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-07 21:45:37.189+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-07 21:45:37.244+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-07 21:45:37.264+0900 E/PKGMGR_INFO(  483): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-07 21:45:37.289+0900 E/APPS    (  715): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-07 21:45:37.704+0900 W/CRASH_MANAGER(25825): worker.c: worker_job(1199) > 1124746626c61144949233
