S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 27627
Date: 2015-12-07 22:09:31+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xba8

Register Information
r0   = 0xbe98dc50, r1   = 0xbe98e2f0
r2   = 0x6f9e3a00, r3   = 0x6f9e3a00
r4   = 0xbe98e558, r5   = 0xbe98e2f0
r6   = 0x00000132, r7   = 0xbe98dc58
r8   = 0x4030b9c0, r9   = 0x41e28f30
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4145c9ec, sp   = 0xbe98dc40
lr   = 0x4145404f, pc   = 0x00000ba8
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     21368 KB
Buffers:     17428 KB
Cached:      97064 KB
VmPeak:      76520 KB
VmSize:      76008 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14732 KB
VmRSS:       14732 KB
VmData:      21696 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20488 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 27627 TID = 27627
27627 27780 27787 

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
41453000 41455000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
4145d000 4145f000 r-xp /usr/lib/libdri2.so.0.0.0
41467000 4146c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41474000 41476000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4147f000 41485000 r-xp /usr/lib/libappsvc.so.0.1.0
4148d000 414b1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414ba000 41589000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4159f000 415a9000 r-xp /lib/libnss_files-2.13.so
41770000 41774000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41784000 4178b000 r-xp /usr/lib/libappcore-watch.so.1.1
41794000 41799000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
417a1000 417ae000 r-xp /usr/lib/libalarm.so.0.0.0
417b7000 418f4000 r-xp /usr/lib/libicui18n.so.51.1
41904000 419e8000 r-xp /usr/lib/libicuuc.so.51.1
419fd000 41a03000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41a0b000 41a11000 r-xp /usr/lib/libwidget.so.1.0.0
41a1a000 41a1f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a27000 41a30000 r-xp /usr/lib/libcom-core.so.0.0.1
41a39000 41a45000 r-xp /usr/lib/libwidget_service.so.1.0.0
41a4d000 41a56000 r-xp /usr/lib/libwidget_provider.so.1.0.0
41a5f000 41a67000 r-xp /usr/lib/libdrm.so.2.4.0
41a6f000 41a76000 r-xp /usr/lib/libtbm.so.1.0.0
41daf000 41db2000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
41dba000 41dc5000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41ddd000 41df0000 rw-p [heap]
41df0000 41f22000 rw-p [heap]
435aa000 43da9000 rw-p [stack:27780]
43e28000 43e3f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44070000 44900000 rw-p [stack:27787]
be96e000 be98f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27627)
Call Stack Count: 1
 0: (0xba8) (null)
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
00 W/W_HOME  (  715): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
12-07 22:09:18.024+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-07 22:09:18.024+0900 W/W_HOME  (  715): event_manager.c: _state_control(303) > clock/widget (force) resumed
12-07 22:09:18.024+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-07 22:09:18.024+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(715), cmd(0)
12-07 22:09:18.024+0900 W/APPS    (  715): AppsViewNecklace.cpp: onTouchEventCancel(4324) >  touch cancel
12-07 22:09:18.029+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-07 22:09:18.029+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(578) > apps,hide,start
12-07 22:09:18.029+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(596) > state: 0 -> 1
12-07 22:09:18.029+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-07 22:09:18.029+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-07 22:09:18.029+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-07 22:09:18.029+0900 W/W_HOME  (  715): noti_broker.c: _apptray_visibility_cb(788) > apps,hide,start
12-07 22:09:18.029+0900 W/W_HOME  (  715): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
12-07 22:09:18.029+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x80002
12-07 22:09:18.029+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1263) > Unhandled type: 0x80002
12-07 22:09:18.034+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4529) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
12-07 22:09:18.034+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4529) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
12-07 22:09:18.039+0900 W/WATCH_CORE(27627): appcore-watch.c: __widget_resume(1012) > widget_resume
12-07 22:09:18.039+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:18.049+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
12-07 22:09:18.049+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
12-07 22:09:18.469+0900 W/W_HOME  (  715): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
12-07 22:09:18.469+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:18.469+0900 W/W_HOME  (  715): rotary.c: rotary_deattach(156) > rotary_deattach:0x47d099e8
12-07 22:09:18.469+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 22:09:18.469+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47d099e8, elm_layout, func : 0x4004ac29
12-07 22:09:18.469+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
12-07 22:09:18.469+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
12-07 22:09:18.469+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 22:09:18.469+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45cdb7a0, elm_layout, _activated_obj : 0x47d099e8, activated : 1
12-07 22:09:18.469+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
12-07 22:09:18.479+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(578) > apps,hide
12-07 22:09:18.479+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(596) > state: 0 -> 0
12-07 22:09:18.479+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:18.484+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:18.484+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-07 22:09:18.484+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
12-07 22:09:18.484+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:18.484+0900 W/W_HOME  (  715): rotary.c: rotary_deattach(156) > rotary_deattach:0x45cdb7a0
12-07 22:09:18.484+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 22:09:18.484+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45cdb7a0, elm_layout, func : 0x4004ac29
12-07 22:09:18.484+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
12-07 22:09:18.484+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
12-07 22:09:18.484+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 22:09:18.484+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8a6a8, elm_box, _activated_obj : 0x45cdb7a0, activated : 1
12-07 22:09:18.484+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
12-07 22:09:18.484+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:09:18.484+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5125) > Return true for 215, 218.
12-07 22:09:18.484+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
12-07 22:09:18.489+0900 W/W_HOME  (  715): noti_broker.c: _apptray_visibility_cb(788) > apps,hide
12-07 22:09:18.489+0900 W/W_HOME  (  715): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80001
12-07 22:09:18.489+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x80001
12-07 22:09:18.489+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1701) > is_app_tray_displayed: 0
12-07 22:09:18.494+0900 E/APPS    (  715): apps_main.c: apps_main_pause(599) >  paused already
12-07 22:09:18.509+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-07 22:09:18.509+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4529) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
12-07 22:09:18.509+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4534) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
12-07 22:09:18.994+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:19.024+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:09:19.024+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:09:19.999+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:21.009+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:21.119+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 22:09:21.119+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 22:09:22.004+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:23.009+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:24.004+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:24.999+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:26.004+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:26.999+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:28.004+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:29.004+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:29.469+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(307) ev->cur.canvas.y(238)
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.479+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80909644 button=1 downs=1
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(298) ev->cur.canvas.y(238)
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.489+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.489+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(286) ev->cur.canvas.y(234)
12-07 22:09:29.489+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.499+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.499+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(278) ev->cur.canvas.y(231)
12-07 22:09:29.499+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.504+0900 E/EFL     (27627): evas_main<27627> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80909656 button=1 downs=1
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(270) ev->cur.canvas.y(231)
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88128), type(elm_scroller)
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88128), type(elm_scroller)
12-07 22:09:29.524+0900 W/W_HOME  (  715): home_navigation.c: _is_rightedge(188) > (720 360) not right edge: 0 0 0x49c82ba8 -> 360 0 0x477101f8
12-07 22:09:29.529+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,start
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(264) ev->cur.canvas.y(231)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(256) ev->cur.canvas.y(231)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.534+0900 W/W_HOME  (  715): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-07 22:09:29.534+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:29.534+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.534+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.539+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-07 22:09:29.554+0900 E/EFL     (27627): evas_main<27627> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80909687 button=1 downs=0
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(249) ev->cur.canvas.y(230)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(242) ev->cur.canvas.y(230)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.554+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.554+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.569+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.569+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(233) ev->cur.canvas.y(229)
12-07 22:09:29.569+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.569+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.569+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.569+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.569+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.579+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.579+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(221) ev->cur.canvas.y(228)
12-07 22:09:29.579+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.579+0900 W/W_HOME  (  715): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
12-07 22:09:29.584+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.584+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(204) ev->cur.canvas.y(228)
12-07 22:09:29.584+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.584+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.584+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.584+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.584+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.594+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.594+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(188) ev->cur.canvas.y(228)
12-07 22:09:29.594+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.599+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.599+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.604+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.604+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.609+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.609+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(174) ev->cur.canvas.y(227)
12-07 22:09:29.609+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.614+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.614+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(160) ev->cur.canvas.y(225)
12-07 22:09:29.614+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.619+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.619+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.619+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.619+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.629+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.629+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(147) ev->cur.canvas.y(225)
12-07 22:09:29.629+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.634+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.634+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.634+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.634+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(135) ev->cur.canvas.y(225)
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(121) ev->cur.canvas.y(225)
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.664+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.664+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.664+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.664+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(103) ev->cur.canvas.y(225)
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(90) ev->cur.canvas.y(227)
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.684+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80909853 button=1 downs=0
12-07 22:09:29.689+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88128), type(elm_scroller)
12-07 22:09:29.694+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.694+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.714+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.714+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.729+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.729+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.744+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.744+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.754+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.754+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.769+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.769+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.819+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.819+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.824+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-07 22:09:29.824+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88128 : elm_scroller] CurrentPage(3)
12-07 22:09:29.859+0900 W/WATCH_CORE(27627): appcore-watch.c: __widget_pause(1001) > widget_pause
12-07 22:09:29.954+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
12-07 22:09:30.004+0900 E/PKGMGR  (27962): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-07 22:09:30.114+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.114+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(63) ev->cur.canvas.y(261)
12-07 22:09:30.114+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.114+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80910283 button=1 downs=1
12-07 22:09:30.124+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.124+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(70) ev->cur.canvas.y(260)
12-07 22:09:30.124+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.134+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.134+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(86) ev->cur.canvas.y(261)
12-07 22:09:30.134+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(102) ev->cur.canvas.y(264)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88128), type(elm_scroller)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88128), type(elm_scroller)
12-07 22:09:30.154+0900 W/W_HOME  (  715): home_navigation.c: _is_rightedge(188) > (1080 360) not right edge: 0 0 0x477101f8 -> 360 0 0x47ba86b0
12-07 22:09:30.154+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,start
12-07 22:09:30.159+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.159+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(118) ev->cur.canvas.y(265)
12-07 22:09:30.159+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.159+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.159+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.159+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.159+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.159+0900 E/PKGMGR_SERVER(27964): pkgmgr-server.c: main(2126) > package manager server start
12-07 22:09:30.169+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.169+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(130) ev->cur.canvas.y(268)
12-07 22:09:30.169+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.169+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.169+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.174+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.174+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.179+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.179+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(143) ev->cur.canvas.y(269)
12-07 22:09:30.179+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.184+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.184+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.184+0900 E/EFL     (  803): evas_main<803> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80910282 button=1 downs=1
12-07 22:09:30.184+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.184+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.184+0900 E/EFL     (  803): evas_main<803> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-07 22:09:30.184+0900 E/EFL     (  803): evas_main<803> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-07 22:09:30.184+0900 E/EFL     (  803): evas_main<803> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-07 22:09:30.189+0900 E/EFL     (  803): evas_main<803> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80910320 button=1 downs=0
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(159) ev->cur.canvas.y(269)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(172) ev->cur.canvas.y(270)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.199+0900 W/WATCH_CORE(27627): appcore-watch.c: __widget_resume(1012) > widget_resume
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.199+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:30.199+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.199+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.214+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.214+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(183) ev->cur.canvas.y(271)
12-07 22:09:30.214+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.214+0900 W/W_HOME  (  715): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
12-07 22:09:30.214+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.214+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.214+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.214+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(202) ev->cur.canvas.y(271)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(221) ev->cur.canvas.y(271)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.234+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.234+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.249+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.249+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(234) ev->cur.canvas.y(271)
12-07 22:09:30.249+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.249+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.249+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.249+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.249+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.279+0900 E/PKGMGR_SERVER(27964): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1857806329], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-1857806329' '-r' 'org.reolab.blackandwhite'], cookie=[D837MbYDFmw5J3C+ozB67vYCCgo=], backend_flag=[0]
12-07 22:09:30.279+0900 E/PKGMGR  (27964): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-07 22:09:30.279+0900 E/PKGMGR_SERVER(27964): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(250) ev->cur.canvas.y(271)
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(265) ev->cur.canvas.y(271)
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.294+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80910444 button=1 downs=0
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88128), type(elm_scroller)
12-07 22:09:30.299+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.299+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.299+0900 E/PKGMGR_SERVER(27966): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-07 22:09:30.309+0900 E/PKGMGR  (27962): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[279620002]
12-07 22:09:30.324+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.324+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.334+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.334+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.359+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.359+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.379+0900 W/W_HOME  (  715): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-07 22:09:30.379+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:30.384+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.384+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.389+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-07 22:09:30.404+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.404+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.419+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-07 22:09:30.419+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88128 : elm_scroller] CurrentPage(2)
12-07 22:09:30.519+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-07 22:09:30.524+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-07 22:09:30.529+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 22:09:30.539+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:09:30.584+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
12-07 22:09:30.919+0900 W/W_HOME  (  715): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
12-07 22:09:30.994+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:31.189+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-07 22:09:31.194+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-07 22:09:31.214+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-07 22:09:31.339+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1127627626c61144949377
