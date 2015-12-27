S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 21793
Date: 2015-12-11 22:44:43+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xea0

Register Information
r0   = 0x00000000, r1   = 0x000000ff
r2   = 0x000000ff, r3   = 0x000000ff
r4   = 0xbe9995cc, r5   = 0xbe9992c8
r6   = 0x00000132, r7   = 0xbe9989e8
r8   = 0x4030b9c0, r9   = 0x41d69078
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4145d6d0, sp   = 0xbe9989d8
lr   = 0x414543a9, pc   = 0x00000ea0
cpsr = 0x20000010

Memory Information
MemTotal:   489992 KB
MemFree:     14392 KB
Buffers:     26784 KB
Cached:     109856 KB
VmPeak:     119884 KB
VmSize:     119372 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16124 KB
VmRSS:       16124 KB
VmData:      62844 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 21793 TID = 21793
21793 21953 21962 

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
41770000 41774000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41784000 4178b000 r-xp /usr/lib/libappcore-watch.so.1.1
41794000 417c4000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
417c5000 417d9000 r-xp /usr/lib/libcapi-network-nfc.so.0.2.3
417e1000 417ee000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.55
417f6000 417fb000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41803000 41810000 r-xp /usr/lib/libalarm.so.0.0.0
41819000 41956000 r-xp /usr/lib/libicui18n.so.51.1
41966000 41a4a000 r-xp /usr/lib/libicuuc.so.51.1
41a5f000 41a65000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41a6d000 41a73000 r-xp /usr/lib/libwidget.so.1.0.0
41a7c000 41a81000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a89000 41ac0000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41ac9000 41ae2000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41aeb000 41b15000 r-xp /usr/lib/libnfc.so.1.0.0
41b1e000 41b4f000 r-xp /usr/lib/libmdm.so.1.1.85
41b57000 41b6d000 r-xp /usr/lib/libnetwork.so.0.0.0
41b76000 41b7b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
41b83000 41b8c000 r-xp /usr/lib/libcom-core.so.0.0.1
41b95000 41ba1000 r-xp /usr/lib/libwidget_service.so.1.0.0
41ba9000 41bb2000 r-xp /usr/lib/libwidget_provider.so.1.0.0
41bbb000 41bc1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41bc9000 41bd1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41bd9000 41c07000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
41c13000 41c1b000 r-xp /usr/lib/libdrm.so.2.4.0
41c23000 41c25000 r-xp /usr/lib/libdri2.so.0.0.0
41c2d000 41c34000 r-xp /usr/lib/libtbm.so.1.0.0
41c3c000 41c56000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41c5f000 41c66000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41c6f000 41c71000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41c79000 41c80000 r-xp /usr/lib/libminizip.so.1.0.0
41c88000 41c95000 r-xp /usr/lib/libail.so.0.1.0
41c9e000 41ca1000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
41ca9000 41cb4000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41cbd000 41cd4000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
41cf0000 41cf2000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41cfa000 41d30000 rw-p [heap]
41d30000 41e63000 rw-p [heap]
4381c000 4401b000 rw-p [stack:21953]
45c01000 46400000 rw-p [stack:21962]
be979000 be99a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21793)
Call Stack Count: 1
 0: (0xea0) (null)
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
 _ecore_x_message_cb(403) > state: 0 -> 1
12-11 22:44:14.946+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:14.946+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:14.951+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:14.951+0900 I/APP_CORE(20221): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
12-11 22:44:14.951+0900 W/W_HOME  (  717): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
12-11 22:44:14.956+0900 I/APP_CORE(20221): appcore-efl.c: __do_app(474) > [APP 20221] Initial Launching, call the resume_cb
12-11 22:44:14.956+0900 I/CAPI_APPFW_APPLICATION(20221): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
12-11 22:44:14.971+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-11 22:44:14.986+0900 W/APP_CORE(20221): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6200002
12-11 22:44:14.996+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:15.031+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(1)
12-11 22:44:15.031+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
12-11 22:44:15.031+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:15.031+0900 W/W_HOME  (  717): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(1)
12-11 22:44:15.031+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: RUNNING
12-11 22:44:15.031+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-11 22:44:15.031+0900 W/W_HOME  (  717): main.c: _appcore_pause_cb(690) > appcore pause
12-11 22:44:15.031+0900 W/W_HOME  (  717): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-11 22:44:15.036+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:15.041+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 22:44:15.041+0900 W/AUL_AMD (  479): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-11 22:44:15.051+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:15.051+0900 W/W_HOME  (  717): main.c: home_pause(751) > clock/widget paused
12-11 22:44:15.056+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:15.056+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:44:15.056+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:44:15.056+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:44:15.056+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-11 22:44:15.056+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-11 22:44:15.056+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:44:15.056+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 22:44:15.056+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:44:15.061+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:15.066+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:44:15.066+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:44:15.066+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:44:15.066+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 22:44:15.066+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 22:44:15.066+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:44:15.066+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 22:44:15.066+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 22:44:15.066+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 22:44:15.066+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:44:15.066+0900 E/CAPI_APPFW_APP_CONTROL(  834): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-11 22:44:15.066+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:834]   value = [false][0m
12-11 22:44:15.066+0900 I/APP_CORE(20221): appcore-efl.c: __do_app(429) > [APP 20221] Event: RESUME State: RUNNING
12-11 22:44:15.071+0900 E/EFL     (20221): evas_main<20221> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3292863 button=1 downs=1
12-11 22:44:15.106+0900 E/EFL     (20221): evas_main<20221> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3292917 button=1 downs=0
12-11 22:44:15.121+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:15.131+0900 I/wnotib  (  717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
12-11 22:44:15.131+0900 E/wnotib  (  717): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-11 22:44:15.181+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:15.191+0900 E/EFL     (20221): evas_main<20221> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=3293000 button=1 downs=1
12-11 22:44:15.266+0900 E/EFL     (20221): evas_main<20221> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=3293076 button=1 downs=0
12-11 22:44:15.426+0900 W/W_HOME  (  717): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
12-11 22:44:15.571+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-11 22:44:15.901+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:44:15.926+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 20221
12-11 22:44:15.931+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 22:44:16.001+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:16.051+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:16.076+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:16.141+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:16.291+0900 I/AUL_PAD (21793): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 22:44:17.011+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:17.111+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:17.161+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:17.236+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:18.011+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:18.121+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:18.171+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:18.261+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:18.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:44:18.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:44:19.001+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:19.111+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:19.141+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:19.231+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:20.001+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:20.071+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-11 22:44:20.121+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:20.141+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:20.221+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:21.001+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:21.106+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:21.156+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:21.266+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:22.006+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:22.106+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:22.156+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:22.271+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:23.006+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:23.116+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:23.166+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:23.251+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:23.766+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:44:23.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:44:24.001+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:24.116+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:24.161+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:24.256+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:24.316+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=44   flick_area=55 ---> SET value to 1
12-11 22:44:24.316+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
12-11 22:44:24.316+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=44   flick_area=55 ---> SET value to 1
12-11 22:44:24.381+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
12-11 22:44:24.391+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 22:44:24.391+0900 W/AUL_AMD (  479): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-11 22:44:24.396+0900 I/MALI    (  717): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442b6d88] swap changed from sync to async
12-11 22:44:24.451+0900 W/PROCESSMGR(  365): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
12-11 22:44:24.451+0900 W/WATCH_CORE(19959): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
12-11 22:44:24.451+0900 I/WATCH_CORE(19959): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
12-11 22:44:24.451+0900 W/W_HOME  (  717): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
12-11 22:44:24.451+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:24.451+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:24.451+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:24.451+0900 W/W_HOME  (  717): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
12-11 22:44:24.481+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(0)
12-11 22:44:24.481+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
12-11 22:44:24.481+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:24.481+0900 W/W_HOME  (  717): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(0)
12-11 22:44:24.481+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: RESUME State: PAUSED
12-11 22:44:24.481+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-11 22:44:24.481+0900 W/W_HOME  (  717): main.c: _appcore_resume_cb(681) > appcore resume
12-11 22:44:24.481+0900 W/W_HOME  (  717): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
12-11 22:44:24.481+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:24.481+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:24.481+0900 W/W_HOME  (  717): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-11 22:44:24.481+0900 W/W_HOME  (  717): main.c: home_resume(733) > clock/widget resumed
12-11 22:44:24.481+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:44:24.486+0900 I/wnotib  (  717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
12-11 22:44:24.486+0900 E/wnotib  (  717): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-11 22:44:24.486+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-11 22:44:24.491+0900 I/APP_CORE(20221): appcore-efl.c: __do_app(429) > [APP 20221] Event: PAUSE State: RUNNING
12-11 22:44:24.491+0900 I/CAPI_APPFW_APPLICATION(20221): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
12-11 22:44:24.491+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-11 22:44:24.946+0900 I/MALI    (  717): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442b6d88] swap changed from async to sync
12-11 22:44:24.996+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:25.051+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:25.096+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:25.266+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:25.486+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:44:25.486+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:44:25.486+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:44:25.486+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-11 22:44:25.486+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-11 22:44:25.486+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:44:25.486+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 22:44:25.486+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:44:25.496+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:44:25.496+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:44:25.496+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:44:25.496+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 22:44:25.496+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 22:44:25.496+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:44:25.496+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 22:44:25.496+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 22:44:25.496+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 22:44:25.496+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:44:25.496+0900 E/CAPI_APPFW_APP_CONTROL(  834): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-11 22:44:25.496+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:834]   value = [true][0m
12-11 22:44:25.501+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:44:25.526+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 717
12-11 22:44:25.541+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:834]   [MUSIC_PLAYER_EVENT][0m
12-11 22:44:25.546+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:44:25.546+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:44:25.546+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:44:25.546+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-11 22:44:25.546+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-11 22:44:25.546+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:44:25.546+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-11 22:44:25.546+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:44:25.556+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:44:25.556+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:44:25.556+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:44:25.556+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 22:44:25.556+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 22:44:25.556+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:44:25.556+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-11 22:44:25.556+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 22:44:25.556+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 22:44:25.561+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:44:25.561+0900 W/W_HOME  (  717): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-11 22:44:25.561+0900 E/W_HOME  (  717): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-11 22:44:25.561+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:834]   [MUSIC_PLAYER_EVENT][0m
12-11 22:44:25.566+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:44:25.566+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:44:25.566+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:44:25.566+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-11 22:44:25.566+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-11 22:44:25.566+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:44:25.566+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-11 22:44:25.566+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:44:25.571+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:44:25.571+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:44:25.571+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:44:25.571+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 22:44:25.571+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 22:44:25.571+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:44:25.571+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-11 22:44:25.571+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 22:44:25.571+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 22:44:25.571+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:44:25.571+0900 W/W_HOME  (  717): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-11 22:44:25.571+0900 E/W_HOME  (  717): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 22:44:25.576+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:44:26.001+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:26.136+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:26.186+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:26.271+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:27.006+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:27.106+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:27.156+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:27.271+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:28.001+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:28.091+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:28.176+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:28.251+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:28.761+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:44:28.771+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:44:29.001+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:29.131+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:29.226+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:29.286+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:29.516+0900 I/APP_CORE(20221): appcore-efl.c: __do_app(429) > [APP 20221] Event: MEM_FLUSH State: PAUSED
12-11 22:44:30.001+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:30.111+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:30.161+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:30.251+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:30.996+0900 I/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:31.036+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:31.061+0900 I/CAPI_NETWORK_WIFI(19959): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:31.136+0900 E/blackandwhite(19959): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:31.181+0900 E/PKGMGR_SERVER(21949): pkgmgr-server.c: main(2126) > package manager server start
12-11 22:44:31.276+0900 E/PKGMGR_SERVER(21949): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-2049161515], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 22:44:31.286+0900 E/PKGMGR  (21943): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 22:44:31.286+0900 E/PKGMGR_SERVER(21951): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 22:44:31.361+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:44:31.371+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19959
12-11 22:44:31.371+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 22:44:31.376+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 22:44:31.376+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(19959), cmd(4)
12-11 22:44:31.381+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 22:44:31.381+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(884) > app status : 4
12-11 22:44:31.381+0900 W/CAPI_WATCH_APPLICATION(19959): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 22:44:31.381+0900 W/WATCH_CORE(19959): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 22:44:31.381+0900 E/WIDGET_PROVIDER_APP(19959): client.c: client_fini(1175) > Provider is not initialized
12-11 22:44:31.381+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:44:31.396+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19959
12-11 22:44:31.396+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 22:44:31.501+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:44:31.516+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 22:44:31.541+0900 E/PKGMGR_SERVER(21951): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 22:44:31.591+0900 E/PKGMGR_SERVER(21949): pkgmgr-server.c: sighandler(445) > child NORMAL exit [21951]
12-11 22:44:31.611+0900 E/AUL_AMD (  479): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 22:44:31.611+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(19959), cmd(4)
12-11 22:44:31.616+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 22:44:31.651+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 22:44:31.676+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 22:44:31.676+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 22:44:31.681+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 698
12-11 22:44:31.796+0900 E/RESOURCED(  480): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-11 22:44:31.801+0900 E/RESOURCED(  480): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 22:44:31.806+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 22:44:31.806+0900 W/AUL_PAD ( 1168): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 22:44:31.806+0900 W/AUL_PAD ( 1168): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 22:44:31.846+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 22:44:31.876+0900 E/TBM     (21793): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 22:44:31.906+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 19959
12-11 22:44:31.941+0900 W/WATCH_CORE(21793): appcore-watch.c: __widget_create(958) > widget_create
12-11 22:44:31.946+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [633.058716] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_633.058716.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263080:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 22:44:31.946+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[633.058716] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_633.058716.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263080:4] gbar_fname[]
12-11 22:44:31.966+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 22:44:31.966+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 22:44:32.096+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:32.106+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:32.276+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:32.286+0900 W/WATCH_CORE(21793): appcore-watch.c: __widget_create(976) > widget_create done
12-11 22:44:32.321+0900 I/WATCH_CORE(21793): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 22:44:32.321+0900 I/WATCH_CORE(21793): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 22:44:32.321+0900 I/WATCH_CORE(21793): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 22:44:32.376+0900 W/WATCH_CORE(21793): appcore-watch.c: __widget_resume(1012) > widget_resume
12-11 22:44:32.391+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:32.401+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:32.416+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:32.456+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:32.911+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 22:44:32.911+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 22:44:32.921+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:44:32.931+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 21793
12-11 22:44:32.931+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 22:44:32.996+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:33.011+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:33.021+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:33.066+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:33.181+0900 I/AUL_PAD (21978): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 22:44:33.191+0900 E/PKGMGR_SERVER(21949): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 22:44:33.191+0900 E/PKGMGR_SERVER(21949): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 22:44:33.386+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 22:44:33.766+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:44:33.801+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:44:34.001+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:34.071+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:34.096+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:34.161+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:35.001+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:35.026+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:35.036+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:35.096+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:36.006+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:36.116+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:36.206+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:36.276+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:37.001+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:37.091+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:37.166+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:37.236+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:38.001+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:38.056+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:38.096+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:38.181+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:38.766+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:44:38.851+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:44:39.001+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:39.046+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:39.071+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:39.136+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:40.006+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:40.106+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:40.141+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:40.261+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:41.001+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:41.106+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:41.146+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:41.321+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:42.001+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:42.096+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:44:42.206+0900 I/CAPI_NETWORK_WIFI(21793): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:44:42.306+0900 E/blackandwhite(21793): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:44:42.411+0900 E/PKGMGR  (22116): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 22:44:42.596+0900 E/PKGMGR_SERVER(22118): pkgmgr-server.c: main(2126) > package manager server start
12-11 22:44:42.716+0900 E/PKGMGR_SERVER(22118): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-2037741891], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-2037741891' '-r' 'org.reolab.blackandwhite'], cookie=[xL9XmJg9S2D67CN4201FpCLd/kE=], backend_flag=[0]
12-11 22:44:42.721+0900 E/PKGMGR  (22118): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 22:44:42.721+0900 E/PKGMGR_SERVER(22118): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 22:44:42.726+0900 E/PKGMGR  (22116): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[221160002]
12-11 22:44:42.726+0900 E/PKGMGR_SERVER(22119): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 22:44:42.901+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 22:44:42.911+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 22:44:42.921+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 22:44:42.926+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:44:42.996+0900 I/CAPI_WATCH_APPLICATION(21793): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:44:43.251+0900 W/CRASH_MANAGER(22120): worker.c: worker_job(1199) > 1121793626c61144984148
