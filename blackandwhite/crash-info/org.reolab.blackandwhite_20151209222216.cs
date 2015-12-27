S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 2316
Date: 2015-12-09 22:22:16+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xe14

Register Information
r0   = 0xbed99c28, r1   = 0xbed9a5e4
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbed9a548, r5   = 0xbed9a2e0
r6   = 0x00000132, r7   = 0xbed99c30
r8   = 0x4030b9c0, r9   = 0x415f8098
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4145d1c4, sp   = 0xbed99c18
lr   = 0x4145433f, pc   = 0x00000e14
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     14292 KB
Buffers:     23932 KB
Cached:     191408 KB
VmPeak:      95212 KB
VmSize:      94700 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15676 KB
VmRSS:       15676 KB
VmData:      38172 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22104 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 2316 TID = 2316
2316 2686 2697 

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
4145e000 41466000 r-xp /usr/lib/libmdm-common.so.1.0.89
41467000 4146c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41474000 41476000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4147f000 41485000 r-xp /usr/lib/libappsvc.so.0.1.0
4148d000 41492000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
4149a000 414bb000 rw-p [heap]
414bb000 414df000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414e8000 415b7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415cd000 415d7000 r-xp /lib/libnss_files-2.13.so
4189e000 418a2000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
418b2000 418b9000 r-xp /usr/lib/libappcore-watch.so.1.1
418c2000 418f2000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
418f3000 41907000 r-xp /usr/lib/libcapi-network-nfc.so.0.2.3
4190f000 4191c000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.55
41924000 41931000 r-xp /usr/lib/libalarm.so.0.0.0
4193a000 41a77000 r-xp /usr/lib/libicui18n.so.51.1
41a87000 41b6b000 r-xp /usr/lib/libicuuc.so.51.1
41b80000 41b86000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41b8e000 41b94000 r-xp /usr/lib/libwidget.so.1.0.0
41b9d000 41ba2000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41baa000 41be1000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41bea000 41c03000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41c0c000 41c36000 r-xp /usr/lib/libnfc.so.1.0.0
41c3f000 41c70000 r-xp /usr/lib/libmdm.so.1.1.85
41c78000 41c8e000 r-xp /usr/lib/libnetwork.so.0.0.0
41c97000 41c9c000 r-xp /usr/lib/libcsc-feature.so.0.0.0
4322b000 43234000 r-xp /usr/lib/libcom-core.so.0.0.1
4323d000 43249000 r-xp /usr/lib/libwidget_service.so.1.0.0
43251000 4325a000 r-xp /usr/lib/libwidget_provider.so.1.0.0
43263000 43269000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43271000 43279000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43281000 432af000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
432bb000 432c3000 r-xp /usr/lib/libdrm.so.2.4.0
432cb000 432cd000 r-xp /usr/lib/libdri2.so.0.0.0
432d5000 432dc000 r-xp /usr/lib/libtbm.so.1.0.0
432e4000 432fe000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43307000 4330e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43317000 43319000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43321000 43328000 r-xp /usr/lib/libminizip.so.1.0.0
43330000 4333d000 r-xp /usr/lib/libail.so.0.1.0
43778000 43f77000 rw-p [stack:2686]
43f77000 43f7a000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f82000 43f8d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
44015000 4402c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4426b000 4426d000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45cca000 rw-p [stack:2697]
bed7a000 bed9b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2316)
Call Stack Count: 1
 0: (0xe14) (null)
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
MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:19:49.790+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 22:19:49.790+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:19:49.795+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:19:49.800+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:19:49.800+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-09 22:19:49.800+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 22:19:49.810+0900 W/MUSIC_CONTROL_SERVICE( 1073): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1073]   [MUSIC_PLAYER_EVENT][0m
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:19:49.815+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:19:49.820+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-09 22:19:49.820+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 22:19:49.825+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:19:49.825+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:19:49.825+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:19:49.825+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 22:19:49.825+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 22:19:49.825+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:19:49.825+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 22:19:49.825+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:19:49.830+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:19:49.830+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:19:49.830+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:19:49.830+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 22:19:49.830+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 22:19:49.830+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:19:49.830+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 22:19:49.830+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:19:49.830+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:19:49.830+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:19:50.005+0900 I/CAPI_WATCH_APPLICATION( 2151): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:19:51.010+0900 I/CAPI_WATCH_APPLICATION( 2151): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:19:52.005+0900 I/CAPI_WATCH_APPLICATION( 2151): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:19:53.010+0900 I/CAPI_WATCH_APPLICATION( 2151): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:19:54.005+0900 I/CAPI_WATCH_APPLICATION( 2151): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:19:55.005+0900 I/CAPI_WATCH_APPLICATION( 2151): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:19:55.175+0900 W/WATCH_CORE( 2151): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-09 22:19:55.175+0900 I/WATCH_CORE( 2151): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-09 22:19:55.190+0900 W/WAKEUP-SERVICE( 1116): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318512[0;m
12-09 22:19:55.200+0900 W/STARTER (  683): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-09 22:19:55.200+0900 W/STARTER (  683): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-09 22:19:55.205+0900 E/STARTER (  683): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 22:19:55.205+0900 W/STARTER (  683): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-09 22:19:55.205+0900 W/STARTER (  683): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-09 22:19:55.210+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 22:19:55.210+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-09 22:19:55.210+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 1
12-09 22:19:55.210+0900 W/W_HOME  (  715): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-09 22:19:55.210+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:19:55.215+0900 I/SCONTEXT-LIB(  644): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-09 22:19:55.230+0900 W/WAKEUP-SERVICE( 1116): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-09 22:19:55.230+0900 I/TIZEN_N_SOUND_MANAGER( 1116): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-09 22:19:55.315+0900 I/TIZEN_N_SOUND_MANAGER( 1116): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-09 22:19:55.315+0900 W/TIZEN_N_SOUND_MANAGER( 1116): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-09 22:19:55.315+0900 W/WAKEUP-SERVICE( 1116): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-09 22:19:55.315+0900 I/HIGEAR  ( 1116): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-09 22:19:55.405+0900 W/MUSIC_CONTROL_SERVICE( 1073): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1073]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-09 22:19:55.410+0900 I/SHealth_Common( 1065): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-09 22:19:55.420+0900 W/STARTER (  683): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-09 22:19:55.420+0900 W/STARTER (  683): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-09 22:19:55.420+0900 W/STARTER (  683): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-09 22:19:55.420+0900 W/STARTER (  683): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-09 22:19:55.425+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: PAUSE State: RUNNING
12-09 22:19:55.425+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-09 22:19:55.425+0900 W/W_HOME  (  715): main.c: _appcore_pause_cb(690) > appcore pause
12-09 22:19:55.425+0900 W/W_HOME  (  715): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-09 22:19:55.425+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:19:55.425+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:19:55.425+0900 W/W_HOME  (  715): main.c: home_pause(751) > clock/widget paused
12-09 22:19:55.425+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:19:55.435+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:19:55.435+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:19:55.435+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:19:55.435+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 22:19:55.435+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 22:19:55.435+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:19:55.435+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 22:19:55.435+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:19:55.440+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:19:55.440+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:19:55.440+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:19:55.440+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 22:19:55.440+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 22:19:55.440+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:19:55.440+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 22:19:55.440+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:19:55.440+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:19:55.440+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:19:55.440+0900 I/GESTURE (  134): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-09 22:19:55.485+0900 I/SHealth_Service( 1065): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-09 22:19:55.485+0900 E/CAPI_APPFW_APP_CONTROL( 1073): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 22:19:55.495+0900 W/MUSIC_CONTROL_SERVICE( 1073): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1073]   value = [false][0m
12-09 22:19:55.550+0900 W/WATCH_CORE( 2151): appcore-watch.c: __widget_pause(1001) > widget_pause
12-09 22:19:55.945+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-09 22:20:00.530+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-09 22:20:02.070+0900 I/RESOURCED(  535): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-09 22:20:02.070+0900 I/RESOURCED(  535): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-09 22:20:14.115+0900 E/SHealth_Common( 1065): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-09 22:21:02.105+0900 I/RESOURCED(  535): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-09 22:21:02.105+0900 I/RESOURCED(  535): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-09 22:21:14.135+0900 E/SHealth_Common( 1065): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-09 22:22:00.095+0900 E/PKGMGR_SERVER( 2676): pkgmgr-server.c: main(2126) > package manager server start
12-09 22:22:00.125+0900 I/GESTURE (  134): gesture.c: GestureHandleKeyPressEvent(3712) > [GestureHandleKeyPressEvent] Ignore key press in DPMS off (devid:7) keycode=124
12-09 22:22:00.210+0900 W/WATCH_CORE( 2151): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
12-09 22:22:00.210+0900 I/WATCH_CORE( 2151): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-09 22:22:00.215+0900 W/WAKEUP-SERVICE( 1116): WakeupService.cpp: OnReceiveDisplayChanged(905) > [0;32mINFO: LCDOn receive data : 1124318512[0;m
12-09 22:22:00.215+0900 W/WAKEUP-SERVICE( 1116): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-09 22:22:00.215+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-09 22:22:00.215+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_set(161) > timer set
12-09 22:22:00.215+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-09 22:22:00.215+0900 W/W_HOME  (  715): gesture.c: _apps_status_get(123) > apps status:0
12-09 22:22:00.215+0900 W/W_HOME  (  715): gesture.c: _lcd_on_cb(295) > move_to_clock:1 clock_visible:1 info->offtime:125085
12-09 22:22:00.215+0900 W/W_HOME  (  715): gesture.c: _manual_render_schedule(211) > schedule, manual render
12-09 22:22:00.215+0900 W/W_HOME  (  715): event_manager.c: _lcd_on_cb(691) > lcd state: 1
12-09 22:22:00.215+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:22:00.215+0900 W/STARTER (  683): clock-mgr.c: _on_lcd_signal_receive_cb(1519) > [_on_lcd_signal_receive_cb:1519] _on_lcd_signal_receive_cb, 1519, Pre LCD on by [powerkey] after screen off time [125085]ms
12-09 22:22:00.215+0900 W/STARTER (  683): clock-mgr.c: _pre_lcd_on(1245) > [_pre_lcd_on:1245] Will LCD ON as reserved app[(null)] alpm mode[0]
12-09 22:22:00.220+0900 I/SCONTEXT-LIB(  644): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 42 (req_id=11)
12-09 22:22:00.220+0900 I/TIZEN_N_SOUND_MANAGER( 1116): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-09 22:22:00.220+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: RESUME State: PAUSED
12-09 22:22:00.220+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-09 22:22:00.220+0900 W/W_HOME  (  715): main.c: _appcore_resume_cb(681) > appcore resume
12-09 22:22:00.220+0900 W/W_HOME  (  715): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
12-09 22:22:00.220+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:22:00.220+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:22:00.220+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-09 22:22:00.220+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
12-09 22:22:00.225+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:22:00.225+0900 I/GESTURE (  134): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-09 22:22:00.245+0900 W/WATCH_CORE( 2151): appcore-watch.c: __widget_resume(1012) > widget_resume
12-09 22:22:00.245+0900 I/CAPI_WATCH_APPLICATION( 2151): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:00.270+0900 W/W_HOME  (  715): gesture.c: _widget_updated_cb(190) > widget updated
12-09 22:22:00.270+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-09 22:22:00.270+0900 W/W_HOME  (  715): gesture.c: _manual_render(176) > 
12-09 22:22:00.290+0900 W/MUSIC_CONTROL_SERVICE( 1073): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1073]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
12-09 22:22:00.310+0900 W/STARTER (  683): hw_key.c: _key_press_cb(1200) > [_key_press_cb:1200] POWER Key is pressed
12-09 22:22:00.310+0900 W/STARTER (  683): hw_key.c: _key_press_cb(1203) > [_key_press_cb:1203] LCD state : 0
12-09 22:22:00.325+0900 W/STARTER (  683): hw_key.c: _key_press_cb(1210) > [_key_press_cb:1210] PM state : 1
12-09 22:22:00.325+0900 W/STARTER (  683): hw_key.c: _key_press_cb(1224) > [_key_press_cb:1224] powerkey count : 1
12-09 22:22:00.330+0900 W/STARTER (  683): hw_key.c: _key_release_cb(1124) > [_key_release_cb:1124] POWER Key is released
12-09 22:22:00.330+0900 W/STARTER (  683): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [powerkey]
12-09 22:22:00.330+0900 W/STARTER (  683): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[0]
12-09 22:22:00.335+0900 E/PKGMGR_SERVER( 2676): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-106566705], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-09 22:22:00.350+0900 E/PKGMGR_SERVER( 2683): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-09 22:22:00.355+0900 E/PKGMGR  ( 2670): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-09 22:22:00.410+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:22:00.415+0900 W/W_HOME  (  715): gesture.c: _manual_render(176) > 
12-09 22:22:00.420+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2151
12-09 22:22:00.425+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 22:22:00.435+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 5
12-09 22:22:00.440+0900 W/CAPI_WATCH_APPLICATION( 2151): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-09 22:22:00.440+0900 W/WATCH_CORE( 2151): appcore-watch.c: __widget_destroy(992) > widget_destory
12-09 22:22:00.440+0900 E/WIDGET_PROVIDER_APP( 2151): client.c: client_fini(1175) > Provider is not initialized
12-09 22:22:00.440+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 22
12-09 22:22:00.440+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(884) > app status : 4
12-09 22:22:00.440+0900 W/AUL_AMD (  534): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(2151), cmd(4)
12-09 22:22:00.440+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 4
12-09 22:22:00.450+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:22:00.460+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2151
12-09 22:22:00.485+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 0
12-09 22:22:00.500+0900 I/SHealth_Common( 1065): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-09 22:22:00.500+0900 W/TIZEN_N_SOUND_MANAGER( 1116): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-09 22:22:00.500+0900 I/TIZEN_N_SOUND_MANAGER( 1116): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-09 22:22:00.500+0900 I/SHealth_Service( 1065): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-09 22:22:00.525+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 2 -> 1
12-09 22:22:00.525+0900 E/WMS     (  529): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-09 22:22:00.525+0900 E/WMS     (  529): ==========
12-09 22:22:00.525+0900 E/WMS     (  529): ##WMS SEND : mgr_gear_wear_onoff_req
12-09 22:22:00.525+0900 E/WMS     (  529): ==========
12-09 22:22:00.525+0900 E/WMS     (  529): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-09 22:22:00.545+0900 W/SCSD    ( 1273): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
12-09 22:22:00.545+0900 W/SCSD    ( 1273): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
12-09 22:22:00.545+0900 W/SCSD    ( 1273): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
12-09 22:22:00.550+0900 W/SCSD    ( 1273): <util_scs_send:975> sent [63 / 63] bytes. 
12-09 22:22:00.565+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:22:00.570+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-09 22:22:00.575+0900 E/PKGMGR_SERVER( 2683): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-09 22:22:00.580+0900 W/STARTER (  683): hw_key.c: _powerkey_timer_cb(806) > [_powerkey_timer_cb:806] _powerkey_timer_cb, powerkey count[1]
12-09 22:22:00.580+0900 W/STARTER (  683): hw_key.c: _powerkey_timer_cb(961) > [_powerkey_timer_cb:961] clock visibility[1] pressed lcd status[0], current lcd status[1] pressed pm state[1]
12-09 22:22:00.580+0900 W/STARTER (  683): hw_key.c: _powerkey_timer_cb(963) > [_powerkey_timer_cb:963] LCD OFF state => ignore key operation
12-09 22:22:00.595+0900 E/PKGMGR_SERVER( 2676): pkgmgr-server.c: sighandler(445) > child NORMAL exit [2683]
12-09 22:22:00.650+0900 E/AUL_AMD (  534): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-09 22:22:00.650+0900 W/AUL_AMD (  534): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(2151), cmd(4)
12-09 22:22:00.650+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 0
12-09 22:22:00.665+0900 I/AUL_AMD (  534): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 22:22:00.680+0900 I/AUL_AMD (  534): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 22:22:00.680+0900 E/AUL_AMD (  534): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-09 22:22:00.680+0900 W/AUL_AMD (  534): amd_launch.c: _start_app(1659) > caller pid : 685
12-09 22:22:00.760+0900 I/TIZEN_N_SOUND_MANAGER( 1116): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-09 22:22:00.760+0900 W/TIZEN_N_SOUND_MANAGER( 1116): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-09 22:22:00.760+0900 W/WAKEUP-SERVICE( 1116): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-09 22:22:00.760+0900 I/HIGEAR  ( 1116): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-09 22:22:00.780+0900 E/RESOURCED(  535): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 1
12-09 22:22:00.780+0900 E/RESOURCED(  535): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-09 22:22:00.785+0900 W/AUL_AMD (  534): amd_launch.c: _start_app(2026) > pad pid(-5)
12-09 22:22:00.785+0900 W/AUL_PAD ( 1158): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-09 22:22:00.785+0900 W/AUL_PAD ( 1158): launchpad.c: __send_result_to_caller(265) > Check app launching
12-09 22:22:00.795+0900 E/SHealth_Common( 1065): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-09 22:22:00.795+0900 W/SHealth_Service( 1065): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
12-09 22:22:00.795+0900 E/SHealth_Service( 1065): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-09 22:22:00.835+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: watch_app_main(382) > watch_app_main
12-09 22:22:00.855+0900 E/TBM     ( 2316): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-09 22:22:00.890+0900 I/AUL_AMD (  534): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2151
12-09 22:22:00.935+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [37.319309] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_37.319309.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263030:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-09 22:22:00.935+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[37.319309] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_37.319309.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263030:4] gbar_fname[]
12-09 22:22:00.935+0900 W/WATCH_CORE( 2316): appcore-watch.c: __widget_create(958) > widget_create
12-09 22:22:00.950+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-09 22:22:00.950+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-09 22:22:01.045+0900 E/SHealth_Common( 1065): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-09 22:22:01.055+0900 W/WATCH_CORE( 2316): appcore-watch.c: __widget_create(976) > widget_create done
12-09 22:22:01.125+0900 I/WATCH_CORE( 2316): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-09 22:22:01.125+0900 I/WATCH_CORE( 2316): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-09 22:22:01.125+0900 I/WATCH_CORE( 2316): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-09 22:22:01.165+0900 W/WATCH_CORE( 2316): appcore-watch.c: __widget_resume(1012) > widget_resume
12-09 22:22:01.205+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:22:01.230+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:22:01.235+0900 E/CAPI_APPFW_APP_CONTROL( 1073): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 22:22:01.235+0900 W/MUSIC_CONTROL_SERVICE( 1073): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1073]   value = [true][0m
12-09 22:22:01.235+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:22:01.240+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 715
12-09 22:22:01.245+0900 W/MUSIC_CONTROL_SERVICE( 1073): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1073]   [MUSIC_PLAYER_EVENT][0m
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:22:01.245+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:22:01.250+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-09 22:22:01.250+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 22:22:01.250+0900 W/MUSIC_CONTROL_SERVICE( 1073): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1073]   [MUSIC_PLAYER_EVENT][0m
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 22:22:01.250+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:22:01.255+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-09 22:22:01.255+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:22:01.255+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:22:01.890+0900 W/AUL_AMD (  534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 22:22:01.890+0900 W/AUL_AMD (  534): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-09 22:22:01.905+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:22:01.915+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2316
12-09 22:22:01.915+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 22:22:02.000+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:02.065+0900 I/RESOURCED(  535): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-09 22:22:02.065+0900 I/RESOURCED(  535): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-09 22:22:02.065+0900 I/RESOURCED(  535): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-09 22:22:02.115+0900 I/AUL_PAD ( 2711): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-09 22:22:02.470+0900 W/AUL_AMD (  534): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-09 22:22:02.930+0900 E/PKGMGR_SERVER( 2676): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-09 22:22:02.935+0900 E/PKGMGR_SERVER( 2676): pkgmgr-server.c: main(2180) > package manager server terminated.
12-09 22:22:03.005+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:04.005+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:05.000+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:06.005+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:07.000+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:08.005+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:09.020+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:10.005+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:11.005+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:12.005+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:13.005+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:14.005+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:14.810+0900 E/PKGMGR  ( 2860): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-09 22:22:14.965+0900 E/PKGMGR_SERVER( 2862): pkgmgr-server.c: main(2126) > package manager server start
12-09 22:22:15.000+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:15.045+0900 E/PKGMGR_SERVER( 2862): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-91686559], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-91686559' '-r' 'org.reolab.blackandwhite'], cookie=[BsByWgyvkwfL3Z9TIYbA4LC5pbQ=], backend_flag=[0]
12-09 22:22:15.050+0900 E/PKGMGR  ( 2862): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-09 22:22:15.050+0900 E/PKGMGR_SERVER( 2862): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-09 22:22:15.055+0900 E/PKGMGR  ( 2860): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[28600002]
12-09 22:22:15.055+0900 E/PKGMGR_SERVER( 2863): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-09 22:22:15.205+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-09 22:22:15.215+0900 W/AUL_AMD (  534): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-09 22:22:15.235+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-09 22:22:15.235+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 22:22:15.850+0900 E/PKGMGR_CERT( 2863): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-09 22:22:15.860+0900 E/PKGMGR_CERT( 2863): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-09 22:22:15.860+0900 E/PKGMGR_CERT( 2863): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-09 22:22:15.865+0900 E/PKGMGR_CERT( 2863): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-09 22:22:15.865+0900 E/PKGMGR_CERT( 2863): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-09 22:22:15.865+0900 E/PKGMGR_CERT( 2863): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-09 22:22:15.865+0900 E/PKGMGR_CERT( 2863): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-09 22:22:15.875+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 22:22:15.885+0900 E/PKGMGR_CERT( 2863): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-09 22:22:16.000+0900 I/CAPI_WATCH_APPLICATION( 2316): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:22:16.255+0900 W/CRASH_MANAGER( 2867): worker.c: worker_job(1199) > 1102316626c61144966733
