S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 24152
Date: 2015-12-07 21:32:19+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x380

Register Information
r0   = 0x00000374, r1   = 0x0000000d
r2   = 0x00000274, r3   = 0x4147d194
r4   = 0x00000374, r5   = 0x00000000
r6   = 0x41668834, r7   = 0x41665208
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbece5c74, sp   = 0xbece5c28
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     20340 KB
Buffers:     14484 KB
Cached:      96008 KB
VmPeak:      75344 KB
VmSize:      74832 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14656 KB
VmRSS:       14656 KB
VmData:      20572 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20468 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 24152 TID = 24152
24152 24277 24283 

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
41433000 41438000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41444000 41465000 rw-p [heap]
41465000 4146a000 r-xp /usr/lib/libappcore-common.so.1.1
41472000 41474000 r-xp /usr/lib/libiniparser.so.0
4147d000 4147f000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
41487000 41489000 r-xp /usr/lib/libdri2.so.0.0.0
41491000 41493000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4149c000 414a2000 r-xp /usr/lib/libappsvc.so.0.1.0
414aa000 414ce000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414d7000 415a6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
415bc000 415c6000 r-xp /lib/libnss_files-2.13.so
4188d000 41891000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
418a1000 418a8000 r-xp /usr/lib/libappcore-watch.so.1.1
418b1000 418be000 r-xp /usr/lib/libalarm.so.0.0.0
418c7000 41a04000 r-xp /usr/lib/libicui18n.so.51.1
41a14000 41af8000 r-xp /usr/lib/libicuuc.so.51.1
41b0d000 41b13000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41b1b000 41b21000 r-xp /usr/lib/libwidget.so.1.0.0
430b1000 430ba000 r-xp /usr/lib/libcom-core.so.0.0.1
430c3000 430cf000 r-xp /usr/lib/libwidget_service.so.1.0.0
430d7000 430e0000 r-xp /usr/lib/libwidget_provider.so.1.0.0
430e9000 430f1000 r-xp /usr/lib/libdrm.so.2.4.0
430f9000 430fe000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
43106000 4310d000 r-xp /usr/lib/libtbm.so.1.0.0
43547000 43d46000 rw-p [stack:24277]
43d46000 43d49000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d51000 43d5c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43de4000 43dfb000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4403b000 44963000 rw-p [stack:24283]
becc6000 bece7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24152)
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
d
12-07 21:31:37.364+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:31:37.364+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:31:37.364+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:31:37.364+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 21:31:37.364+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 21:31:37.364+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 21:31:37.364+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:31:37.369+0900 E/CAPI_APPFW_APP_CONTROL( 1081): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-07 21:31:37.369+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1081]   value = [true][0m
12-07 21:31:37.369+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:31:37.374+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 715
12-07 21:31:37.379+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT][0m
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 21:31:37.384+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:31:37.384+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-07 21:31:37.384+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 21:31:37.384+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT][0m
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:31:37.389+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-07 21:31:37.389+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 21:31:37.389+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:31:37.994+0900 I/CAPI_WATCH_APPLICATION(24036): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:31:38.999+0900 I/CAPI_WATCH_APPLICATION(24036): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:31:39.994+0900 I/CAPI_WATCH_APPLICATION(24036): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:31:40.949+0900 W/WATCH_CORE(24036): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 2
12-07 21:31:40.949+0900 I/WATCH_CORE(24036): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
12-07 21:31:40.954+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: OnReceiveGestureChanged(928) > [0;32mINFO: wakeup receive data : 1124318360[0;m
12-07 21:31:40.954+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-07 21:31:40.954+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-07 21:31:40.964+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
12-07 21:31:40.964+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-07 21:31:40.964+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-07 21:31:40.969+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-07 21:31:40.969+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-07 21:31:40.969+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-07 21:31:40.969+0900 I/HIGEAR  ( 1107): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-07 21:31:40.994+0900 I/CAPI_WATCH_APPLICATION(24036): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:31:41.999+0900 I/CAPI_WATCH_APPLICATION(24036): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:31:42.254+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 2 -> 1
12-07 21:31:42.259+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-07 21:31:42.259+0900 E/WMS     (  491): ==========
12-07 21:31:42.259+0900 E/WMS     (  491): ##WMS SEND : mgr_gear_wear_onoff_req
12-07 21:31:42.259+0900 E/WMS     (  491): ==========
12-07 21:31:42.259+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-07 21:31:42.274+0900 W/SHealth_Service( 1078): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
12-07 21:31:42.274+0900 E/SHealth_Service( 1078): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-07 21:31:42.999+0900 I/CAPI_WATCH_APPLICATION(24036): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:31:43.309+0900 E/wnoti-service(  871): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(557)
12-07 21:31:43.309+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
12-07 21:31:43.309+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-07 21:31:43.309+0900 E/wnoti-service(  871): wnoti-db-server.c: insert_panel_asset(3440) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-07 21:31:43.309+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/584
12-07 21:31:43.314+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
12-07 21:31:43.314+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 142
12-07 21:31:43.314+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-07 21:31:43.314+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/584
12-07 21:31:43.314+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3974) > summary_bg_image : /opt/usr/data/wnoti/.crop_386.png
12-07 21:31:43.339+0900 E/wnoti-service(  871): wnoti-db-server.c: wnoti_is_check_notification_update(4451) > 5/0
12-07 21:31:43.339+0900 E/wnoti-service(  871): wnoti-sap-client.c: _add_exception_handling(581) > type : 5, application_id : 218
12-07 21:31:43.349+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1839) > application status : 0
12-07 21:31:43.349+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 5, category : 1000, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 230084, noti_flag : 528, g_span_version : 1
12-07 21:31:43.349+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-07 21:31:43.349+0900 E/wnoti-service(  871): wnoti-db-server.c: _wnoti_update_category(804) > Reuse category, application_id : 218
12-07 21:31:43.369+0900 E/wnoti-service(  871): wnoti-db-server.c: set_global_noti_count(1555) > pre_count : 0, count : 1
12-07 21:31:43.399+0900 I/AUL     (  871): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-07 21:31:43.419+0900 I/AUL     (  871): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-07 21:31:43.454+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-07 21:31:43.454+0900 E/APPS    (  715): AppsBadge.cpp: onBadgeChange(215) >  (!pAppsItem) -> onBadgeChange() return
12-07 21:31:43.459+0900 E/wnoti-service(  871): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(1984)
12-07 21:31:43.459+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
12-07 21:31:43.469+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-07 21:31:43.469+0900 E/wnoti-service(  871): wnoti-db-server.c: insert_panel_asset(3440) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-07 21:31:43.469+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_noti_extender(793) > noti_info->label : 7
12-07 21:31:43.469+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/582
12-07 21:31:43.469+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 2
12-07 21:31:43.469+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 1506
12-07 21:31:43.469+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-07 21:31:43.469+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/582
12-07 21:31:43.469+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3974) > summary_bg_image : /opt/usr/data/wnoti/.crop_382.png
12-07 21:31:43.469+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/580
12-07 21:31:43.479+0900 E/wnoti-service(  871): wnoti-db-server.c: _clear_summary_noti(946) > summary popup : 2066, seq_num : 230084
12-07 21:31:43.489+0900 E/wnoti-service(  871): wnoti-db-server.c: wnoti_is_check_notification_update(4451) > 5/0
12-07 21:31:43.489+0900 E/wnoti-service(  871): wnoti-sap-client.c: _add_exception_handling(581) > type : 5, application_id : 218
12-07 21:31:43.489+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1839) > application status : 0
12-07 21:31:43.489+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 5, category : 0, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 230085, noti_flag : 0, g_span_version : 1
12-07 21:31:43.489+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-07 21:31:43.514+0900 E/wnoti-service(  871): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 1
12-07 21:31:43.514+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 1
12-07 21:31:43.994+0900 I/CAPI_WATCH_APPLICATION(24036): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:31:44.914+0900 E/wnoti-service(  871): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 2
12-07 21:31:44.914+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-07 21:31:44.914+0900 I/wnoti-service(  871): wnoti-msg-builder.c: _publish_notification(1453) > operation_type : 0, source : 0, application_id : 0, display_count : 0
12-07 21:31:44.919+0900 E/wnoti-service(  871): wnoti-db-server.c: set_global_noti_count(1555) > pre_count : 1, count : 1
12-07 21:31:44.929+0900 E/wnoti-proxy(13736): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 13736, caller_id : 0, listener_type : 0
12-07 21:31:44.929+0900 I/wnotibp (13736): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1488) > Handle this change type in idler.
12-07 21:31:44.929+0900 E/wnoti-proxy(  715): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 715, caller_id : 0, listener_type : 0
12-07 21:31:44.929+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 0, op_type: 0, category_id: 0, display count: 0
12-07 21:31:44.929+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1548) > Handle this change type in idler.
12-07 21:31:44.929+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1572) > App tray not displayed and edit mode is off.
12-07 21:31:44.929+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1051) > idler for type: 0
12-07 21:31:44.949+0900 I/wnoti-proxy(  715): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-07 21:31:44.949+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1098) > unread_count: 1
12-07 21:31:44.949+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(622) > category_id: 215, application_id: 218, application_name: 카카오톡, time_stamp: 1449491226, content_id: 0, spannable_string_version: 1
12-07 21:31:44.949+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-07 21:31:44.949+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-07 21:31:44.949+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-07 21:31:44.949+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-07 21:31:44.949+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-07 21:31:44.949+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-07 21:31:44.949+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1335) > New noti is here. Add it on panel  215, 카카오톡.
12-07 21:31:44.949+0900 W/wnotib  (  715): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(260) > Create a panel for panel_id: 1, instance_id: 215
12-07 21:31:44.949+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_initialize(4750) > Initialize the panel with id: 215
12-07 21:31:44.949+0900 W/wnotib  (  715): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(275) > Page instance, instance_id [215] has been created.
12-07 21:31:44.949+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 215, application_id: 218, type: 1
12-07 21:31:44.979+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-07 21:31:44.979+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-07 21:31:44.979+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-07 21:31:44.979+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-07 21:31:44.979+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4398) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
12-07 21:31:44.979+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 215, application_id: 218, type: 13
12-07 21:31:44.979+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-07 21:31:44.979+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-07 21:31:44.979+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-07 21:31:44.979+0900 E/TIZEN_N_SYSTEM_SETTINGS(  715): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-07 21:31:44.989+0900 I/wnotib  (  715): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-07 21:31:44.994+0900 I/wnotib  (  715): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-07 21:31:44.999+0900 I/CAPI_WATCH_APPLICATION(24036): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:31:45.009+0900 W/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4577) > Show home indicator.
12-07 21:31:45.009+0900 W/W_HOME  (  715): noti_broker.c: _handler_noti_indicator_show(478) > 
12-07 21:31:45.009+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 215, application_id: 218, type: 12
12-07 21:31:45.009+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 1, num total noti: 1
12-07 21:31:45.009+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-07 21:31:45.009+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-07 21:31:45.009+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-07 21:31:45.009+0900 I/wnotib  (  715): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-07 21:31:45.009+0900 I/wnotib  (  715): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
12-07 21:31:45.009+0900 W/wnotib  (  715): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(206) > Summary board was disabled. But receive update request
12-07 21:31:45.009+0900 I/wnotib  (  715): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-07 21:31:45.009+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 1.
12-07 21:31:45.009+0900 W/W_HOME  (  715): noti_broker.c: _handler_indicator_update(562) > 0x1
12-07 21:31:45.054+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 1
12-07 21:31:45.054+0900 W/W_HOME  (  715): noti_broker.c: _handler_noti_indicator_show(478) > 
12-07 21:31:45.089+0900 W/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(331) > body is NULL and no attachments found.
12-07 21:31:45.129+0900 W/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(331) > body is NULL and no attachments found.
12-07 21:31:45.994+0900 I/CAPI_WATCH_APPLICATION(24036): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:31:46.999+0900 I/CAPI_WATCH_APPLICATION(24036): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 21:31:47.474+0900 W/WATCH_CORE(24036): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-07 21:31:47.474+0900 I/WATCH_CORE(24036): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-07 21:31:47.524+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-07 21:31:47.524+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-07 21:31:47.524+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 1
12-07 21:31:47.524+0900 W/W_HOME  (  715): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-07 21:31:47.524+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:31:47.524+0900 W/STARTER (  707): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-07 21:31:47.524+0900 W/STARTER (  707): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-07 21:31:47.524+0900 E/STARTER (  707): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-07 21:31:47.524+0900 W/STARTER (  707): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-07 21:31:47.524+0900 W/STARTER (  707): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-07 21:31:47.524+0900 I/SCONTEXT-LIB(  687): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-07 21:31:47.544+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-07 21:31:47.544+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-07 21:31:47.544+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-07 21:31:47.609+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-07 21:31:47.609+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-07 21:31:47.609+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-07 21:31:47.609+0900 I/HIGEAR  ( 1107): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-07 21:31:47.794+0900 W/STARTER (  707): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-07 21:31:47.794+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-07 21:31:47.799+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-07 21:31:47.799+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-07 21:31:47.799+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: PAUSE State: RUNNING
12-07 21:31:47.799+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-07 21:31:47.799+0900 W/W_HOME  (  715): main.c: _appcore_pause_cb(690) > appcore pause
12-07 21:31:47.799+0900 W/W_HOME  (  715): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-07 21:31:47.799+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:31:47.799+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:31:47.799+0900 W/W_HOME  (  715): main.c: home_pause(751) > clock/widget paused
12-07 21:31:47.799+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 21:31:47.804+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 21:31:47.804+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-07 21:31:47.869+0900 W/WATCH_CORE(24036): appcore-watch.c: __widget_pause(1001) > widget_pause
12-07 21:31:47.869+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_pause_cb(296) > widget obj was paused
12-07 21:31:47.869+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(145) > enter background group
12-07 21:31:47.889+0900 I/SHealth_Common( 1078): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-07 21:31:47.889+0900 I/SHealth_Service( 1078): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-07 21:31:47.889+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-07 21:31:47.899+0900 E/CAPI_APPFW_APP_CONTROL( 1081): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-07 21:31:47.899+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1081]   value = [false][0m
12-07 21:31:48.304+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-07 21:31:52.824+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-07 21:32:00.104+0900 E/PKGMGR_SERVER(24274): pkgmgr-server.c: main(2126) > package manager server start
12-07 21:32:00.304+0900 E/PKGMGR_SERVER(24274): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_187112622], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-07 21:32:00.314+0900 E/PKGMGR  (24272): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-07 21:32:00.334+0900 E/PKGMGR_SERVER(24275): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-07 21:32:00.484+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:32:00.494+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24036
12-07 21:32:00.499+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 21:32:00.499+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 5
12-07 21:32:00.504+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(24036), cmd(4)
12-07 21:32:00.504+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 21:32:00.504+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(884) > app status : 4
12-07 21:32:00.504+0900 W/CAPI_WATCH_APPLICATION(24036): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-07 21:32:00.509+0900 W/WATCH_CORE(24036): appcore-watch.c: __widget_destroy(992) > widget_destory
12-07 21:32:00.509+0900 E/WIDGET_PROVIDER_APP(24036): client.c: client_fini(1175) > Provider is not initialized
12-07 21:32:00.509+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 21:32:00.529+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:32:00.534+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24036
12-07 21:32:00.639+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:32:00.649+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 21:32:00.659+0900 E/PKGMGR_SERVER(24275): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-07 21:32:00.679+0900 E/PKGMGR_SERVER(24274): pkgmgr-server.c: sighandler(445) > child NORMAL exit [24275]
12-07 21:32:00.784+0900 E/AUL_AMD (  495): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-07 21:32:00.784+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(24036), cmd(4)
12-07 21:32:00.784+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 21:32:00.799+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 21:32:00.809+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 21:32:00.809+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 21:32:00.809+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 21:32:00.944+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 21:32:00.944+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 21:32:00.949+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 21:32:00.949+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-07 21:32:00.949+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 21:32:00.979+0900 I/CAPI_WATCH_APPLICATION(24152): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 21:32:00.999+0900 E/TBM     (24152): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 21:32:01.059+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 24036
12-07 21:32:01.094+0900 W/WATCH_CORE(24152): appcore-watch.c: __widget_create(958) > widget_create
12-07 21:32:01.099+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [76046.937500] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29360932:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 21:32:01.099+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[76046.937500] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29360932:4] gbar_fname[]
12-07 21:32:01.119+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 21:32:01.119+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 21:32:01.189+0900 W/WATCH_CORE(24152): appcore-watch.c: __widget_create(976) > widget_create done
12-07 21:32:01.279+0900 I/WATCH_CORE(24152): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-07 21:32:01.279+0900 I/WATCH_CORE(24152): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-07 21:32:01.279+0900 I/WATCH_CORE(24152): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-07 21:32:02.059+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 21:32:02.059+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 21:32:02.079+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 21:32:02.084+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24152
12-07 21:32:02.084+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 21:32:02.304+0900 I/AUL_PAD (24284): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 21:32:02.509+0900 W/AUL_AMD (  495): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 21:32:02.829+0900 E/PKGMGR_SERVER(24274): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 21:32:02.829+0900 E/PKGMGR_SERVER(24274): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 21:32:13.659+0900 E/PKGMGR  (24368): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-07 21:32:13.819+0900 E/PKGMGR_SERVER(24370): pkgmgr-server.c: main(2126) > package manager server start
12-07 21:32:14.019+0900 E/PKGMGR_SERVER(24370): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_200818871], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_200818871' '-r' 'org.reolab.blackandwhite'], cookie=[K+9wDZZsLubyxJxTadnxaEPXoH0=], backend_flag=[0]
12-07 21:32:14.019+0900 E/PKGMGR  (24370): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-07 21:32:14.019+0900 E/PKGMGR_SERVER(24370): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-07 21:32:14.034+0900 E/PKGMGR  (24368): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[243680002]
12-07 21:32:14.034+0900 E/PKGMGR_SERVER(24371): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-07 21:32:14.254+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-07 21:32:14.269+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 21:32:14.284+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:32:14.314+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-07 21:32:14.969+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:32:14.994+0900 E/PKGMGR_CERT(24371): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-07 21:32:14.999+0900 E/PKGMGR_CERT(24371): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-07 21:32:14.999+0900 E/PKGMGR_CERT(24371): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-07 21:32:14.999+0900 E/PKGMGR_CERT(24371): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-07 21:32:14.999+0900 E/PKGMGR_CERT(24371): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-07 21:32:14.999+0900 E/PKGMGR_CERT(24371): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-07 21:32:14.999+0900 E/PKGMGR_CERT(24371): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-07 21:32:15.014+0900 E/PKGMGR_CERT(24371): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-07 21:32:15.829+0900 E/PKGMGR_SERVER(24370): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 21:32:16.699+0900 E/rpm-installer(24371): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-07 21:32:17.829+0900 E/PKGMGR_SERVER(24370): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 21:32:19.564+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 21:32:19.584+0900 E/PKGMGR_SERVER(24370): pkgmgr-server.c: sighandler(445) > child NORMAL exit [24371]
12-07 21:32:19.584+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-07 21:32:19.584+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-07 21:32:19.609+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-07 21:32:19.609+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-07 21:32:19.609+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-07 21:32:19.609+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-07 21:32:19.679+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-07 21:32:19.814+0900 E/APPS    (  715): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-07 21:32:19.819+0900 E/PKGMGR_INFO(  483): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-07 21:32:19.829+0900 E/PKGMGR_SERVER(24370): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 21:32:19.829+0900 E/PKGMGR_SERVER(24370): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 21:32:20.249+0900 W/CRASH_MANAGER(24373): worker.c: worker_job(1199) > 1124152626c61144949153
