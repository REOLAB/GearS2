S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 25860
Date: 2015-12-07 21:47:17+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10c

Register Information
r0   = 0x00000100, r1   = 0x0000000d
r2   = 0x00000000, r3   = 0x41453194
r4   = 0x00000100, r5   = 0x00000000
r6   = 0x41f42244, r7   = 0x41f33e08
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbee7cc74, sp   = 0xbee7cc28
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     20488 KB
Buffers:     14344 KB
Cached:      95588 KB
VmPeak:      76460 KB
VmSize:      75948 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14692 KB
VmRSS:       14692 KB
VmData:      21688 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20468 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 25860 TID = 25860
25860 26072 26078 

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
41794000 417a1000 r-xp /usr/lib/libalarm.so.0.0.0
417aa000 418e7000 r-xp /usr/lib/libicui18n.so.51.1
418f7000 419db000 r-xp /usr/lib/libicuuc.so.51.1
419f0000 419f6000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
419fe000 41a04000 r-xp /usr/lib/libwidget.so.1.0.0
41a0d000 41a16000 r-xp /usr/lib/libcom-core.so.0.0.1
41a1f000 41a2b000 r-xp /usr/lib/libwidget_service.so.1.0.0
41a33000 41a3c000 r-xp /usr/lib/libwidget_provider.so.1.0.0
41a45000 41a4d000 r-xp /usr/lib/libdrm.so.2.4.0
41a55000 41a5a000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a62000 41a69000 r-xp /usr/lib/libtbm.so.1.0.0
41da2000 41da5000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
41dad000 41db8000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41e40000 41e42000 rw-p [heap]
41e42000 41f74000 rw-p [heap]
435fc000 43dfb000 rw-p [stack:26072]
43dfb000 43e12000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44052000 44900000 rw-p [stack:26078]
bee5d000 bee7e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25860)
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
12-07 21:45:55.474+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:45:55.474+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:45:55.474+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 21:45:55.474+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 21:45:55.474+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:45:55.474+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 21:45:55.479+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:45:55.479+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:45:55.479+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:45:55.479+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:45:55.484+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:45:55.484+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:45:55.484+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:45:55.484+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 21:45:55.484+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 21:45:55.484+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 21:45:55.484+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:45:55.489+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-07 21:45:55.504+0900 E/CAPI_APPFW_APP_CONTROL( 1081): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-07 21:45:55.504+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1081]   value = [false][0m
12-07 21:45:55.639+0900 W/WATCH_CORE(25667): appcore-watch.c: __widget_pause(1001) > widget_pause
12-07 21:45:55.644+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_pause_cb(296) > widget obj was paused
12-07 21:45:55.644+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(145) > enter background group
12-07 21:45:55.989+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-07 21:46:00.579+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-07 21:46:09.795+0900 W/WATCH_CORE(25667): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
12-07 21:46:09.795+0900 I/WATCH_CORE(25667): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
12-07 21:46:09.800+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
12-07 21:46:09.800+0900 W/W_HOME  (  715): gesture.c: _manual_render_schedule(211) > schedule, manual render
12-07 21:46:09.800+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: OnReceiveGestureChanged(928) > [0;32mINFO: wakeup receive data : 1124318360[0;m
12-07 21:46:09.800+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-07 21:46:09.800+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-07 21:46:09.855+0900 W/WATCH_CORE(25667): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
12-07 21:46:09.855+0900 I/WATCH_CORE(25667): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-07 21:46:09.860+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-07 21:46:09.860+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-07 21:46:09.865+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1405) > ::APP:: view state=0, 2, 0
12-07 21:46:09.875+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-07 21:46:09.880+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_set(161) > timer set
12-07 21:46:09.880+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-07 21:46:09.880+0900 W/W_HOME  (  715): gesture.c: _apps_status_get(123) > apps status:0
12-07 21:46:09.880+0900 W/W_HOME  (  715): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:1 info->offtime:14827
12-07 21:46:09.880+0900 W/W_HOME  (  715): gesture.c: _manual_render_schedule(211) > schedule, manual render
12-07 21:46:09.880+0900 W/W_HOME  (  715): event_manager.c: _lcd_on_cb(691) > lcd state: 1
12-07 21:46:09.880+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:46:09.880+0900 W/STARTER (  707): clock-mgr.c: _on_lcd_signal_receive_cb(1519) > [_on_lcd_signal_receive_cb:1519] _on_lcd_signal_receive_cb, 1519, Pre LCD on by [gesture] after screen off time [14827]ms
12-07 21:46:09.880+0900 W/STARTER (  707): clock-mgr.c: _pre_lcd_on(1245) > [_pre_lcd_on:1245] Will LCD ON as reserved app[(null)] alpm mode[0]
12-07 21:46:09.885+0900 I/SCONTEXT-LIB(  687): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 42 (req_id=352)
12-07 21:46:09.890+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: RESUME State: PAUSED
12-07 21:46:09.890+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-07 21:46:09.890+0900 W/W_HOME  (  715): main.c: _appcore_resume_cb(681) > appcore resume
12-07 21:46:09.890+0900 W/W_HOME  (  715): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
12-07 21:46:09.890+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:46:09.890+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:46:09.890+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-07 21:46:09.890+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
12-07 21:46:09.890+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:46:09.895+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-07 21:46:09.910+0900 W/WATCH_CORE(25667): appcore-watch.c: __widget_resume(1012) > widget_resume
12-07 21:46:09.910+0900 I/CAPI_WATCH_APPLICATION(25667): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:46:09.925+0900 W/W_HOME  (  715): gesture.c: _widget_updated_cb(190) > widget updated
12-07 21:46:09.925+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-07 21:46:09.925+0900 W/W_HOME  (  715): gesture.c: _manual_render(176) > 
12-07 21:46:09.950+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
12-07 21:46:09.955+0900 I/SHealth_Common( 1078): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-07 21:46:09.955+0900 I/SHealth_Service( 1078): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-07 21:46:09.960+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
12-07 21:46:09.960+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
12-07 21:46:09.979+0900 W/W_HOME  (  715): gesture.c: _manual_render(176) > 
12-07 21:46:09.994+0900 I/CAPI_WATCH_APPLICATION(25667): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:46:10.014+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 0
12-07 21:46:10.014+0900 W/STARTER (  707): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [gesture]
12-07 21:46:10.014+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[0]
12-07 21:46:10.104+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-07 21:46:10.104+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-07 21:46:10.104+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: preference_get_double(1214) > preference_get_double(1078) : pedometer_inactive_period error
12-07 21:46:10.104+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-07 21:46:10.104+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-07 21:46:10.104+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: preference_get_double(1214) > preference_get_double(1078) : inactive_10min_precaution_millisec error
12-07 21:46:10.104+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-07 21:46:10.104+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-07 21:46:10.104+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: preference_get_double(1214) > preference_get_double(1078) : inactive_before_10min_precaution_millisec error
12-07 21:46:10.194+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-07 21:46:10.194+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-07 21:46:10.194+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-07 21:46:10.194+0900 I/HIGEAR  ( 1107): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-07 21:46:10.194+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: OnReceiveDisplayChanged(905) > [0;32mINFO: LCDOn receive data : 1124318408[0;m
12-07 21:46:10.194+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-07 21:46:10.194+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-07 21:46:10.199+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-07 21:46:10.199+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-07 21:46:10.204+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-07 21:46:10.204+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-07 21:46:10.204+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-07 21:46:10.204+0900 I/HIGEAR  ( 1107): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-07 21:46:10.269+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 1 -> 2
12-07 21:46:10.269+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-07 21:46:10.269+0900 E/WMS     (  491): ==========
12-07 21:46:10.269+0900 E/WMS     (  491): ##WMS SEND : mgr_gear_wear_onoff_req
12-07 21:46:10.269+0900 E/WMS     (  491): ==========
12-07 21:46:10.269+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-07 21:46:10.374+0900 W/SHealth_Service( 1078): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
12-07 21:46:10.374+0900 E/SHealth_Service( 1078): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-07 21:46:10.899+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:46:10.899+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:46:10.899+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:46:10.899+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 21:46:10.899+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 21:46:10.899+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:46:10.899+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 21:46:10.899+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:46:10.904+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:46:10.904+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:46:10.904+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:46:10.904+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:46:10.904+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:46:10.904+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:46:10.904+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 21:46:10.904+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 21:46:10.904+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 21:46:10.904+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:46:10.909+0900 E/CAPI_APPFW_APP_CONTROL( 1081): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-07 21:46:10.909+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1081]   value = [true][0m
12-07 21:46:10.919+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:46:10.969+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 715
12-07 21:46:10.984+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT][0m
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 21:46:10.994+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:46:10.999+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-07 21:46:10.999+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 21:46:11.004+0900 I/CAPI_WATCH_APPLICATION(25667): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:46:11.014+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT][0m
12-07 21:46:11.014+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:46:11.014+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:46:11.014+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:46:11.019+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 21:46:11.019+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 21:46:11.019+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:46:11.019+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 21:46:11.019+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:46:11.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:46:11.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:46:11.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:46:11.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:46:11.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:46:11.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:46:11.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 21:46:11.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 21:46:11.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 21:46:11.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:46:11.059+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-07 21:46:11.059+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 21:46:11.064+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:46:11.064+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:46:11.064+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:46:11.064+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 21:46:11.064+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 21:46:11.064+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:46:11.064+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 21:46:11.064+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:46:11.069+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:46:11.069+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:46:11.069+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:46:11.069+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:46:11.069+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:46:11.069+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:46:11.069+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 21:46:11.069+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 21:46:11.069+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 21:46:11.069+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:46:12.004+0900 I/CAPI_WATCH_APPLICATION(25667): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:46:12.999+0900 I/CAPI_WATCH_APPLICATION(25667): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:46:14.004+0900 I/CAPI_WATCH_APPLICATION(25667): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:46:15.004+0900 I/CAPI_WATCH_APPLICATION(25667): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:46:16.004+0900 I/CAPI_WATCH_APPLICATION(25667): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:46:16.464+0900 W/WATCH_CORE(25667): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-07 21:46:16.464+0900 I/WATCH_CORE(25667): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-07 21:46:16.499+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-07 21:46:16.504+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-07 21:46:16.504+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 1
12-07 21:46:16.504+0900 W/W_HOME  (  715): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-07 21:46:16.504+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:46:16.504+0900 W/STARTER (  707): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-07 21:46:16.504+0900 W/STARTER (  707): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-07 21:46:16.504+0900 E/STARTER (  707): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-07 21:46:16.504+0900 W/STARTER (  707): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-07 21:46:16.504+0900 W/STARTER (  707): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-07 21:46:16.509+0900 I/SCONTEXT-LIB(  687): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-07 21:46:16.529+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-07 21:46:16.529+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-07 21:46:16.539+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-07 21:46:16.639+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-07 21:46:16.639+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-07 21:46:16.639+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-07 21:46:16.639+0900 I/HIGEAR  ( 1107): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-07 21:46:16.774+0900 I/SHealth_Common( 1078): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-07 21:46:16.779+0900 I/SHealth_Service( 1078): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-07 21:46:16.779+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-07 21:46:16.819+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: PAUSE State: RUNNING
12-07 21:46:16.819+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-07 21:46:16.819+0900 W/W_HOME  (  715): main.c: _appcore_pause_cb(690) > appcore pause
12-07 21:46:16.819+0900 W/W_HOME  (  715): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-07 21:46:16.819+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:46:16.824+0900 W/STARTER (  707): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-07 21:46:16.824+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-07 21:46:16.824+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-07 21:46:16.824+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-07 21:46:16.844+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:46:16.844+0900 W/W_HOME  (  715): main.c: home_pause(751) > clock/widget paused
12-07 21:46:16.844+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:46:16.859+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:46:16.859+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:46:16.859+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:46:16.859+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 21:46:16.859+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 21:46:16.859+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:46:16.859+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 21:46:16.859+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:46:16.864+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:46:16.864+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:46:16.864+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:46:16.864+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:46:16.864+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:46:16.864+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:46:16.869+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 21:46:16.869+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 21:46:16.869+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 21:46:16.869+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:46:16.869+0900 E/CAPI_APPFW_APP_CONTROL( 1081): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-07 21:46:16.869+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1081]   value = [false][0m
12-07 21:46:16.874+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-07 21:46:16.999+0900 I/CAPI_WATCH_APPLICATION(25667): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:46:17.009+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_pause_cb(296) > widget obj was paused
12-07 21:46:17.014+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(145) > enter background group
12-07 21:46:17.014+0900 W/WATCH_CORE(25667): appcore-watch.c: __widget_pause(1001) > widget_pause
12-07 21:46:17.374+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-07 21:46:21.079+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 21:46:21.079+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 21:46:21.974+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-07 21:46:43.504+0900 E/SHealth_Common( 1078): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-07 21:46:52.414+0900 E/PKGMGR_SERVER(26068): pkgmgr-server.c: main(2126) > package manager server start
12-07 21:46:52.559+0900 E/PKGMGR_SERVER(26068): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1079437100], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-07 21:46:52.564+0900 E/PKGMGR_SERVER(26070): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-07 21:46:52.564+0900 E/PKGMGR  (26062): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-07 21:46:52.634+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:46:52.639+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 25667
12-07 21:46:52.644+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 21:46:52.644+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 5
12-07 21:46:52.649+0900 W/CAPI_WATCH_APPLICATION(25667): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-07 21:46:52.649+0900 W/WATCH_CORE(25667): appcore-watch.c: __widget_destroy(992) > widget_destory
12-07 21:46:52.649+0900 E/WIDGET_PROVIDER_APP(25667): client.c: client_fini(1175) > Provider is not initialized
12-07 21:46:52.649+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 21:46:52.654+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(884) > app status : 4
12-07 21:46:52.654+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(25667), cmd(4)
12-07 21:46:52.654+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 21:46:52.654+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:46:52.664+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 25667
12-07 21:46:52.764+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:46:52.774+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 21:46:52.799+0900 E/PKGMGR_SERVER(26070): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-07 21:46:52.854+0900 E/PKGMGR_SERVER(26068): pkgmgr-server.c: sighandler(445) > child NORMAL exit [26070]
12-07 21:46:52.914+0900 E/AUL_AMD (  495): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-07 21:46:52.914+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(25667), cmd(4)
12-07 21:46:52.924+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 21:46:53.004+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 21:46:53.034+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 21:46:53.034+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 21:46:53.034+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 21:46:53.129+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 21:46:53.129+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 21:46:53.134+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 21:46:53.134+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-07 21:46:53.134+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 21:46:53.159+0900 I/CAPI_WATCH_APPLICATION(25860): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 21:46:53.184+0900 E/TBM     (25860): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 21:46:53.244+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 25667
12-07 21:46:53.279+0900 W/WATCH_CORE(25860): appcore-watch.c: __widget_create(958) > widget_create
12-07 21:46:53.284+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [76046.937500] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29360956:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 21:46:53.284+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[76046.937500] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29360956:4] gbar_fname[]
12-07 21:46:53.299+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 21:46:53.299+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 21:46:53.364+0900 W/WATCH_CORE(25860): appcore-watch.c: __widget_create(976) > widget_create done
12-07 21:46:53.434+0900 I/WATCH_CORE(25860): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-07 21:46:53.434+0900 I/WATCH_CORE(25860): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-07 21:46:53.434+0900 I/WATCH_CORE(25860): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-07 21:46:54.244+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 21:46:54.244+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 21:46:54.259+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:46:54.269+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 25860
12-07 21:46:54.269+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 21:46:54.454+0900 I/AUL_PAD (26079): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 21:46:54.654+0900 W/AUL_AMD (  495): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 21:46:54.829+0900 E/PKGMGR_SERVER(26068): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 21:46:54.834+0900 E/PKGMGR_SERVER(26068): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 21:47:11.514+0900 E/PKGMGR  (26206): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-07 21:47:11.659+0900 E/PKGMGR_SERVER(26208): pkgmgr-server.c: main(2126) > package manager server start
12-07 21:47:11.794+0900 E/PKGMGR_SERVER(26208): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1098675367], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_1098675367' '-r' 'org.reolab.blackandwhite'], cookie=[lgvTCqE9cold1zXI2JM7LQ7YPUU=], backend_flag=[0]
12-07 21:47:11.799+0900 E/PKGMGR  (26208): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-07 21:47:11.799+0900 E/PKGMGR_SERVER(26208): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-07 21:47:11.804+0900 E/PKGMGR  (26206): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[262060002]
12-07 21:47:11.809+0900 E/PKGMGR_SERVER(26209): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-07 21:47:11.969+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-07 21:47:11.969+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 21:47:11.989+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:47:11.994+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-07 21:47:12.559+0900 E/PKGMGR_CERT(26209): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-07 21:47:12.564+0900 E/PKGMGR_CERT(26209): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-07 21:47:12.569+0900 E/PKGMGR_CERT(26209): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-07 21:47:12.569+0900 E/PKGMGR_CERT(26209): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-07 21:47:12.569+0900 E/PKGMGR_CERT(26209): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-07 21:47:12.569+0900 E/PKGMGR_CERT(26209): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-07 21:47:12.569+0900 E/PKGMGR_CERT(26209): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-07 21:47:12.579+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:47:12.589+0900 E/PKGMGR_CERT(26209): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-07 21:47:13.829+0900 E/PKGMGR_SERVER(26208): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 21:47:14.669+0900 E/rpm-installer(26209): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-07 21:47:15.829+0900 E/PKGMGR_SERVER(26208): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 21:47:17.629+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:47:17.639+0900 E/PKGMGR_SERVER(26208): pkgmgr-server.c: sighandler(445) > child NORMAL exit [26209]
12-07 21:47:17.659+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-07 21:47:17.659+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-07 21:47:17.674+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-07 21:47:17.674+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-07 21:47:17.674+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-07 21:47:17.674+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-07 21:47:17.684+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-07 21:47:17.744+0900 E/APPS    (  715): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-07 21:47:17.804+0900 E/PKGMGR_INFO(  483): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-07 21:47:17.829+0900 E/PKGMGR_SERVER(26208): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 21:47:17.829+0900 E/PKGMGR_SERVER(26208): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 21:47:18.159+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 21:47:18.164+0900 E/AUL_AMD (  495): amd_request.c: __app_process_by_pid(193) > pid(25860) is dead. cmd(4) is canceled
12-07 21:47:18.164+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 21:47:18.184+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 21:47:18.194+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 21:47:18.194+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 21:47:18.194+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 21:47:18.204+0900 W/CRASH_MANAGER(26212): worker.c: worker_job(1199) > 1125860626c61144949243
