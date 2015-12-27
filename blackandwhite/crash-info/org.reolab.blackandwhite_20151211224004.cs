S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 19100
Date: 2015-12-11 22:40:04+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xea0

Register Information
r0   = 0x41a74d80, r1   = 0xbec4e5cc
r2   = 0x00000000, r3   = 0xbec4da4c
r4   = 0xbec4e5cc, r5   = 0xbec4e2c8
r6   = 0x00000132, r7   = 0xbec4d9e0
r8   = 0x4030b9c0, r9   = 0x419a4f30
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4145d6a8, sp   = 0xbec4d9c0
lr   = 0x41454397, pc   = 0x00000ea0
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     15072 KB
Buffers:     25904 KB
Cached:     127108 KB
VmPeak:     111680 KB
VmSize:     111168 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16124 KB
VmRSS:       16124 KB
VmData:      54640 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 19100 TID = 19100
19100 19938 19946 

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
41966000 4196c000 rw-p [heap]
4196c000 41a9e000 rw-p [heap]
41a9e000 41b82000 r-xp /usr/lib/libicuuc.so.51.1
41b97000 41b9d000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41ba5000 41bab000 r-xp /usr/lib/libwidget.so.1.0.0
41bb4000 41bb9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41bc1000 41bf8000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41c01000 41c1a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41c23000 41c4d000 r-xp /usr/lib/libnfc.so.1.0.0
41c56000 41c87000 r-xp /usr/lib/libmdm.so.1.1.85
41c8f000 41ca5000 r-xp /usr/lib/libnetwork.so.0.0.0
41cae000 41cb3000 r-xp /usr/lib/libcsc-feature.so.0.0.0
43242000 4324b000 r-xp /usr/lib/libcom-core.so.0.0.1
43254000 43260000 r-xp /usr/lib/libwidget_service.so.1.0.0
43268000 43271000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4327a000 43280000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43288000 43290000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43298000 432c6000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
432d2000 432da000 r-xp /usr/lib/libdrm.so.2.4.0
432e2000 432e4000 r-xp /usr/lib/libdri2.so.0.0.0
432ec000 432f3000 r-xp /usr/lib/libtbm.so.1.0.0
432fb000 43315000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4331e000 43325000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4332e000 43330000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43338000 4333f000 r-xp /usr/lib/libminizip.so.1.0.0
43347000 43354000 r-xp /usr/lib/libail.so.0.1.0
4378f000 43f8e000 rw-p [stack:19938]
43f8e000 43f91000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f99000 43fa4000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4402c000 44043000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44282000 44284000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:19946]
bec2e000 bec4f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19100)
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
ore pause
12-11 22:38:58.726+0900 W/W_HOME  (  717): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-11 22:38:58.726+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:38:58.731+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:38:58.731+0900 W/W_HOME  (  717): main.c: home_pause(751) > clock/widget paused
12-11 22:38:58.731+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:38:58.736+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:38:58.736+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:38:58.736+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:38:58.736+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-11 22:38:58.736+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-11 22:38:58.736+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:38:58.736+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 22:38:58.736+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:38:58.741+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:38:58.741+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:38:58.741+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:38:58.741+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 22:38:58.741+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 22:38:58.741+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:38:58.741+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 22:38:58.741+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 22:38:58.741+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 22:38:58.741+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:38:58.741+0900 E/CAPI_APPFW_APP_CONTROL(  834): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-11 22:38:58.741+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:834]   value = [false][0m
12-11 22:38:58.746+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-11 22:38:58.761+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:38:58.786+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:38:58.996+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:38:59.071+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:38:59.126+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:38:59.241+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-11 22:38:59.276+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:00.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:00.116+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:00.171+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:00.256+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:01.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:01.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:01.146+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:01.251+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:02.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:02.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:02.156+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:02.231+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:03.011+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:03.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:03.146+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:03.231+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:03.746+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-11 22:39:03.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:03.836+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:04.001+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:04.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:04.141+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:04.236+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:05.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:05.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:05.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:05.251+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:06.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:06.101+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:06.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:06.246+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:07.011+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:07.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:07.151+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:07.266+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:08.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:08.101+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:08.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:08.261+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:08.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:08.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:09.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:09.101+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:09.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:09.256+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:10.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:10.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:10.156+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:10.236+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:10.281+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 22:39:11.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:11.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:11.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:11.246+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:12.011+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:12.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:12.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:12.246+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:13.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:13.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:13.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:13.246+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:13.766+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:13.836+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:14.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:14.101+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:14.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:14.261+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:15.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:15.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:15.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:15.256+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:16.001+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:16.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:16.156+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:16.231+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:17.011+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:17.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:17.156+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:17.266+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:18.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:18.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:18.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:18.256+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:18.776+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:18.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:19.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:19.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:19.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:19.251+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:20.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:20.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:20.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:20.251+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:21.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:21.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:21.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:21.271+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:22.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:22.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:22.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:22.246+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:23.001+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:23.101+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:23.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:23.256+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:23.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:23.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:24.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:24.101+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:24.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:24.261+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:25.011+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:25.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:25.151+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:25.251+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:26.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:26.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:26.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:26.246+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:27.011+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:27.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:27.151+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:27.236+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:28.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:28.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:28.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:28.256+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:28.776+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:28.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:29.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:29.101+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:29.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:29.261+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:30.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:30.101+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:30.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:30.261+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:31.011+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:31.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:31.151+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:31.266+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:32.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:32.116+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:32.156+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:32.251+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:33.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:33.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:33.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:33.251+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:33.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:33.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:34.001+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:34.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:34.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:34.261+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:35.011+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:35.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:35.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:35.251+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:36.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:36.101+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:36.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:36.251+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:37.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:37.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:37.146+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:37.251+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:38.001+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:38.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:38.151+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:38.246+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:38.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:38.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:39.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:39.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:39.151+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:39.256+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:40.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:40.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:40.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:40.246+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:41.011+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:41.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:41.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:41.251+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:42.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:42.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:42.166+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:42.256+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:43.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:43.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:43.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:43.261+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:43.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:43.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:44.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:44.116+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:44.156+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:44.271+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:45.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:45.111+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:45.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:45.181+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 22:39:45.181+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 22:39:45.266+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:46.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:46.121+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:46.171+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:46.271+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:47.011+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:47.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:47.161+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:47.261+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:48.001+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:48.056+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:48.106+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:48.186+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:48.766+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:48.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:49.001+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:49.071+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:49.116+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:49.166+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:50.006+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:50.136+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:50.206+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:50.316+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:51.001+0900 I/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:51.156+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:51.266+0900 I/CAPI_NETWORK_WIFI(18941): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:51.351+0900 E/blackandwhite(18941): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:51.481+0900 E/PKGMGR_SERVER(19931): pkgmgr-server.c: main(2126) > package manager server start
12-11 22:39:51.576+0900 E/PKGMGR_SERVER(19931): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1966145484], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 22:39:51.576+0900 E/PKGMGR_SERVER(19932): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 22:39:51.586+0900 E/PKGMGR  (19924): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 22:39:51.646+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:51.651+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18941
12-11 22:39:51.656+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 22:39:51.661+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 22:39:51.661+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(18941), cmd(4)
12-11 22:39:51.666+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 22:39:51.666+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(884) > app status : 4
12-11 22:39:51.666+0900 W/CAPI_WATCH_APPLICATION(18941): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 22:39:51.666+0900 W/WATCH_CORE(18941): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 22:39:51.666+0900 E/WIDGET_PROVIDER_APP(18941): client.c: client_fini(1175) > Provider is not initialized
12-11 22:39:51.666+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:51.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18941
12-11 22:39:51.676+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 22:39:51.781+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:51.811+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 22:39:51.841+0900 E/PKGMGR_SERVER(19932): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 22:39:51.896+0900 E/AUL_AMD (  479): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 22:39:51.896+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(18941), cmd(4)
12-11 22:39:51.901+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 22:39:51.921+0900 E/PKGMGR_SERVER(19931): pkgmgr-server.c: sighandler(445) > child NORMAL exit [19932]
12-11 22:39:51.941+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 22:39:51.961+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 22:39:51.961+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 22:39:51.961+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 698
12-11 22:39:52.036+0900 E/RESOURCED(  480): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-11 22:39:52.036+0900 E/RESOURCED(  480): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 22:39:52.041+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 22:39:52.041+0900 W/AUL_PAD ( 1168): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 22:39:52.041+0900 W/AUL_PAD ( 1168): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 22:39:52.096+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 22:39:52.121+0900 E/TBM     (19100): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 22:39:52.146+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 18941
12-11 22:39:52.191+0900 W/WATCH_CORE(19100): appcore-watch.c: __widget_create(958) > widget_create
12-11 22:39:52.191+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [633.058716] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_633.058716.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263072:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 22:39:52.191+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[633.058716] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_633.058716.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263072:4] gbar_fname[]
12-11 22:39:52.206+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 22:39:52.206+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 22:39:52.336+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:52.356+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:52.516+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:52.531+0900 W/WATCH_CORE(19100): appcore-watch.c: __widget_create(976) > widget_create done
12-11 22:39:52.556+0900 I/WATCH_CORE(19100): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 22:39:52.556+0900 I/WATCH_CORE(19100): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 22:39:52.561+0900 I/WATCH_CORE(19100): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 22:39:52.601+0900 W/WATCH_CORE(19100): appcore-watch.c: __widget_resume(1012) > widget_resume
12-11 22:39:52.606+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:52.646+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:52.656+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:52.696+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:52.996+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:53.006+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:53.016+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:53.051+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:53.146+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 22:39:53.146+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 22:39:53.186+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:53.191+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 19100
12-11 22:39:53.196+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 22:39:53.366+0900 I/AUL_PAD (19959): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 22:39:53.676+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 22:39:53.761+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:53.776+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:54.001+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:54.151+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:54.191+0900 E/PKGMGR_SERVER(19931): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 22:39:54.191+0900 E/PKGMGR_SERVER(19931): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 22:39:54.331+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:54.381+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:55.001+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:55.156+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:55.276+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:55.341+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:56.001+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:56.176+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:56.216+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:56.331+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:57.001+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:57.061+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 22:39:57.061+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 22:39:57.061+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 22:39:57.061+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 22:39:57.091+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:57.156+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:57.226+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:58.006+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:58.106+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:58.221+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:58.291+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:39:58.766+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:39:58.796+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:39:59.001+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:39:59.121+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:39:59.266+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:39:59.321+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:40:00.001+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:40:00.086+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:40:00.146+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:40:00.226+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:40:01.001+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:40:01.056+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:40:01.101+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:40:01.201+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:40:02.006+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:40:02.121+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:40:02.166+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:40:02.306+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:40:02.911+0900 E/PKGMGR  (20122): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 22:40:02.996+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:40:03.021+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:40:03.046+0900 I/CAPI_NETWORK_WIFI(19100): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:40:03.121+0900 E/blackandwhite(19100): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:40:03.201+0900 E/PKGMGR_SERVER(20124): pkgmgr-server.c: main(2126) > package manager server start
12-11 22:40:03.291+0900 E/PKGMGR_SERVER(20124): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1977726364], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_1977726364' '-r' 'org.reolab.blackandwhite'], cookie=[bQCNh0qbz51NPNkhjWqcTYsbFFE=], backend_flag=[0]
12-11 22:40:03.291+0900 E/PKGMGR  (20124): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 22:40:03.296+0900 E/PKGMGR_SERVER(20124): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 22:40:03.301+0900 E/PKGMGR_SERVER(20125): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 22:40:03.306+0900 E/PKGMGR  (20122): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[201220002]
12-11 22:40:03.456+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 22:40:03.466+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 22:40:03.476+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 22:40:03.481+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:40:03.761+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:40:03.771+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:40:03.996+0900 I/CAPI_WATCH_APPLICATION(19100): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:40:04.106+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:40:04.111+0900 E/PKGMGR_CERT(20125): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 22:40:04.116+0900 E/PKGMGR_CERT(20125): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 96
12-11 22:40:04.116+0900 E/PKGMGR_CERT(20125): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 96
12-11 22:40:04.116+0900 E/PKGMGR_CERT(20125): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 4
12-11 22:40:04.116+0900 E/PKGMGR_CERT(20125): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 4
12-11 22:40:04.121+0900 E/PKGMGR_CERT(20125): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 4
12-11 22:40:04.121+0900 E/PKGMGR_CERT(20125): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 4
12-11 22:40:04.136+0900 E/PKGMGR_CERT(20125): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 22:40:04.256+0900 W/CRASH_MANAGER(20127): worker.c: worker_job(1199) > 1119100626c61144984120
