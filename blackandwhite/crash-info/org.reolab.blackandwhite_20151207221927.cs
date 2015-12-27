S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 30487
Date: 2015-12-07 22:19:27+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xba8

Register Information
r0   = 0xbec90c30, r1   = 0xbec915f0
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbec91558, r5   = 0xbec912f0
r6   = 0x00000132, r7   = 0xbec90c38
r8   = 0x4030b9c0, r9   = 0x41460078
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4155ca10, sp   = 0xbec90c20
lr   = 0x4155404f, pc   = 0x00000ba8
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     17320 KB
Buffers:     20424 KB
Cached:      93140 KB
VmPeak:      76304 KB
VmSize:      75792 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14752 KB
VmRSS:       14752 KB
VmData:      21480 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20488 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 30487 TID = 30487
30487 30702 30711 

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
41994000 41999000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
419a1000 419ae000 r-xp /usr/lib/libalarm.so.0.0.0
419b7000 41af4000 r-xp /usr/lib/libicui18n.so.51.1
41b04000 41be8000 r-xp /usr/lib/libicuuc.so.51.1
41bfd000 41c03000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41c0b000 41c11000 r-xp /usr/lib/libwidget.so.1.0.0
41c1a000 41c1f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
431ae000 431b7000 r-xp /usr/lib/libcom-core.so.0.0.1
431c0000 431cc000 r-xp /usr/lib/libwidget_service.so.1.0.0
431d4000 431dd000 r-xp /usr/lib/libwidget_provider.so.1.0.0
431e6000 431ee000 r-xp /usr/lib/libdrm.so.2.4.0
431f6000 431fd000 r-xp /usr/lib/libtbm.so.1.0.0
43537000 43d36000 rw-p [stack:30702]
43d36000 43d39000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d41000 43d4c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dd4000 43deb000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4402b000 44900000 rw-p [stack:30711]
bec71000 bec92000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30487)
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
NCE( 1078): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-07 22:19:00.114+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: preference_get_double(1214) > preference_get_double(1078) : inactive_10min_precaution_millisec error
12-07 22:19:00.114+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-07 22:19:00.114+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-07 22:19:00.114+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: preference_get_double(1214) > preference_get_double(1078) : inactive_before_10min_precaution_millisec error
12-07 22:19:00.344+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:19:00.344+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:19:00.344+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:19:00.344+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:19:00.344+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:19:00.344+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:19:00.344+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 22:19:00.349+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:19:00.354+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:19:00.354+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:19:00.354+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:19:00.354+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:19:00.354+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:19:00.354+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:19:00.354+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 22:19:00.354+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:19:00.354+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:19:00.354+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:19:00.359+0900 E/CAPI_APPFW_APP_CONTROL( 1081): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-07 22:19:00.359+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1081]   value = [true][0m
12-07 22:19:00.389+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:19:00.434+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 715
12-07 22:19:00.454+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT][0m
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:19:00.464+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:19:00.469+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:19:00.469+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-07 22:19:00.469+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 22:19:00.469+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT][0m
12-07 22:19:00.474+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:19:00.474+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:19:00.474+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:19:00.474+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:19:00.474+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:19:00.474+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:19:00.474+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 22:19:00.474+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:19:00.479+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-07 22:19:00.479+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 22:19:00.479+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:19:00.484+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:19:00.484+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:19:00.484+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:19:00.484+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:19:00.484+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:19:00.484+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:19:00.484+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 22:19:00.484+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:19:00.484+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:19:00.484+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:19:01.819+0900 W/STARTER (  707): hw_key.c: _key_press_cb(1200) > [_key_press_cb:1200] POWER Key is pressed
12-07 22:19:01.819+0900 W/STARTER (  707): hw_key.c: _key_press_cb(1203) > [_key_press_cb:1203] LCD state : 1
12-07 22:19:01.819+0900 W/STARTER (  707): hw_key.c: _key_press_cb(1210) > [_key_press_cb:1210] PM state : 1
12-07 22:19:01.819+0900 W/STARTER (  707): hw_key.c: _key_press_cb(1224) > [_key_press_cb:1224] powerkey count : 1
12-07 22:19:01.964+0900 W/STARTER (  707): hw_key.c: _key_release_cb(1124) > [_key_release_cb:1124] POWER Key is released
12-07 22:19:02.224+0900 W/STARTER (  707): hw_key.c: _powerkey_timer_cb(806) > [_powerkey_timer_cb:806] _powerkey_timer_cb, powerkey count[1]
12-07 22:19:02.229+0900 W/STARTER (  707): hw_key.c: _powerkey_timer_cb(961) > [_powerkey_timer_cb:961] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
12-07 22:19:02.254+0900 E/STARTER (  707): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
12-07 22:19:02.254+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:19:02.254+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 707
12-07 22:19:02.264+0900 W/AUL_AMD (  495): amd_launch.c: __nofork_processing(1138) > __nofork_processing, cmd: 0, pid: 715
12-07 22:19:02.264+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: RESET State: RUNNING
12-07 22:19:02.264+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_reset(245) > app_appcore_reset
12-07 22:19:02.264+0900 W/W_HOME  (  715): main.c: _app_control(1726) > Service value : powerkey
12-07 22:19:02.264+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x40001
12-07 22:19:02.264+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4518) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:19:02.264+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:19:02.264+0900 W/W_HOME  (  715): noti_broker.c: _noti_broker_home_cb(781) > continue the home key execution
12-07 22:19:02.264+0900 E/W_HOME  (  715): cs_broker.c: _cs_broker_home_cb(256) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
12-07 22:19:02.264+0900 W/W_HOME  (  715): move.c: move_move_to_apps(216) > move to apps
12-07 22:19:02.264+0900 W/W_HOME  (  715): rotary.c: rotary_attach(138) > rotary_attach:0x47d099e8
12-07 22:19:02.264+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47d099e8, elm_layout, _activated_obj : 0x45c8a6a8, activated : 1
12-07 22:19:02.264+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
12-07 22:19:02.264+0900 W/W_HOME  (  715): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
12-07 22:19:02.264+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:19:02.264+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:19:02.269+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(715), cmd(0)
12-07 22:19:02.279+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-07 22:19:02.279+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-07 22:19:02.284+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
12-07 22:19:02.284+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
12-07 22:19:02.284+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:19:02.284+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:19:02.284+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:19:02.284+0900 W/W_HOME  (  715): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
12-07 22:19:02.284+0900 W/W_HOME  (  715): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
12-07 22:19:02.284+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x80002
12-07 22:19:02.284+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1263) > Unhandled type: 0x80002
12-07 22:19:02.564+0900 W/APPS    (  715): AppsItem.cpp: onItemBadgeShow(598) >  badge show:[12:17]
12-07 22:19:02.564+0900 W/W_HOME  (  715): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
12-07 22:19:02.564+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:19:02.564+0900 W/W_HOME  (  715): rotary.c: rotary_deattach(156) > rotary_deattach:0x47d099e8
12-07 22:19:02.564+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 22:19:02.564+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47d099e8, elm_layout, func : 0x4004ac29
12-07 22:19:02.564+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
12-07 22:19:02.564+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
12-07 22:19:02.564+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 22:19:02.564+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8a6a8, elm_box, _activated_obj : 0x47d099e8, activated : 1
12-07 22:19:02.564+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
12-07 22:19:02.564+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:19:02.564+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5125) > Return true for 215, 218.
12-07 22:19:02.564+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
12-07 22:19:02.574+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(578) > apps,show
12-07 22:19:02.574+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
12-07 22:19:02.574+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-07 22:19:02.574+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-07 22:19:02.574+0900 W/W_HOME  (  715): main.c: home_pause(751) > clock/widget paused
12-07 22:19:02.574+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
12-07 22:19:02.574+0900 W/APPS    (  715): apps_main.c: _time_changed_cb(295) >  date : 7->7
12-07 22:19:02.574+0900 W/APPS    (  715): AppsItem.cpp: onItemBadgeShow(598) >  badge show:[12:17]
12-07 22:19:02.574+0900 W/W_HOME  (  715): rotary.c: rotary_attach(138) > rotary_attach:0x45cdb7a0
12-07 22:19:02.579+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45cdb7a0, elm_layout, _activated_obj : 0x45c8a6a8, activated : 1
12-07 22:19:02.579+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
12-07 22:19:02.579+0900 W/W_HOME  (  715): noti_broker.c: _apptray_visibility_cb(788) > apps,show
12-07 22:19:02.579+0900 W/W_HOME  (  715): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
12-07 22:19:02.579+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x80000
12-07 22:19:02.579+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:19:02.579+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_close_second_depth_view(5176) > wnotib_action_drawer_hidden_get(): 1, page_popup: 0x0
12-07 22:19:02.579+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4518) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:19:02.579+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:19:02.579+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_is_available(4814) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:19:02.579+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1701) > is_app_tray_displayed: 1
12-07 22:19:02.579+0900 E/APPS    (  715): apps_main.c: apps_main_resume(633) >  resumed already
12-07 22:19:02.584+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4534) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
12-07 22:19:02.584+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4529) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
12-07 22:19:02.584+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4529) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
12-07 22:19:02.584+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4529) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
12-07 22:19:02.594+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_pause_cb(296) > widget obj was paused
12-07 22:19:02.594+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(145) > enter background group
12-07 22:19:03.264+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:19:03.264+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:19:07.834+0900 W/STARTER (  707): hw_key.c: _key_press_cb(1200) > [_key_press_cb:1200] POWER Key is pressed
12-07 22:19:07.834+0900 W/STARTER (  707): hw_key.c: _key_press_cb(1203) > [_key_press_cb:1203] LCD state : 1
12-07 22:19:07.834+0900 W/STARTER (  707): hw_key.c: _key_press_cb(1210) > [_key_press_cb:1210] PM state : 1
12-07 22:19:07.834+0900 W/STARTER (  707): hw_key.c: _key_press_cb(1224) > [_key_press_cb:1224] powerkey count : 1
12-07 22:19:07.959+0900 W/STARTER (  707): hw_key.c: _key_release_cb(1124) > [_key_release_cb:1124] POWER Key is released
12-07 22:19:08.219+0900 W/STARTER (  707): hw_key.c: _powerkey_timer_cb(806) > [_powerkey_timer_cb:806] _powerkey_timer_cb, powerkey count[1]
12-07 22:19:08.224+0900 W/STARTER (  707): hw_key.c: _powerkey_timer_cb(961) > [_powerkey_timer_cb:961] clock visibility[0] pressed lcd status[1], current lcd status[1] pressed pm state[1]
12-07 22:19:08.244+0900 E/STARTER (  707): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
12-07 22:19:08.244+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:19:08.249+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 707
12-07 22:19:08.254+0900 W/AUL_AMD (  495): amd_launch.c: __nofork_processing(1138) > __nofork_processing, cmd: 0, pid: 715
12-07 22:19:08.254+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: RESET State: RUNNING
12-07 22:19:08.254+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_reset(245) > app_appcore_reset
12-07 22:19:08.254+0900 W/W_HOME  (  715): main.c: _app_control(1726) > Service value : powerkey
12-07 22:19:08.254+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x40001
12-07 22:19:08.254+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4518) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:19:08.254+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:19:08.254+0900 W/W_HOME  (  715): noti_broker.c: _noti_broker_home_cb(781) > continue the home key execution
12-07 22:19:08.254+0900 E/W_HOME  (  715): cs_broker.c: _cs_broker_home_cb(256) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
12-07 22:19:08.254+0900 W/W_HOME  (  715): move.c: move_back_to_home(246) > back to home
12-07 22:19:08.254+0900 W/W_HOME  (  715): rotary.c: rotary_attach(138) > rotary_attach:0x47d099e8
12-07 22:19:08.254+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x47d099e8, elm_layout, _activated_obj : 0x45cdb7a0, activated : 1
12-07 22:19:08.254+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
12-07 22:19:08.254+0900 W/W_HOME  (  715): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
12-07 22:19:08.254+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-07 22:19:08.254+0900 W/W_HOME  (  715): event_manager.c: _state_control(303) > clock/widget (force) resumed
12-07 22:19:08.254+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-07 22:19:08.254+0900 W/APPS    (  715): AppsViewNecklace.cpp: onTouchEventCancel(4324) >  touch cancel
12-07 22:19:08.259+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(715), cmd(0)
12-07 22:19:08.259+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-07 22:19:08.259+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(578) > apps,hide,start
12-07 22:19:08.259+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(596) > state: 0 -> 1
12-07 22:19:08.259+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-07 22:19:08.259+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-07 22:19:08.259+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
12-07 22:19:08.259+0900 W/W_HOME  (  715): noti_broker.c: _apptray_visibility_cb(788) > apps,hide,start
12-07 22:19:08.259+0900 W/W_HOME  (  715): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
12-07 22:19:08.259+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x80002
12-07 22:19:08.259+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1263) > Unhandled type: 0x80002
12-07 22:19:08.264+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4529) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
12-07 22:19:08.264+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4529) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
12-07 22:19:08.284+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
12-07 22:19:08.284+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
12-07 22:19:08.704+0900 W/W_HOME  (  715): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
12-07 22:19:08.704+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
12-07 22:19:08.704+0900 W/W_HOME  (  715): rotary.c: rotary_deattach(156) > rotary_deattach:0x47d099e8
12-07 22:19:08.704+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 22:19:08.704+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x47d099e8, elm_layout, func : 0x4004ac29
12-07 22:19:08.704+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
12-07 22:19:08.704+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
12-07 22:19:08.704+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 22:19:08.704+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45cdb7a0, elm_layout, _activated_obj : 0x47d099e8, activated : 1
12-07 22:19:08.704+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
12-07 22:19:08.714+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(578) > apps,hide
12-07 22:19:08.714+0900 W/W_HOME  (  715): event_manager.c: _apptray_visibility_cb(596) > state: 0 -> 0
12-07 22:19:08.714+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
12-07 22:19:08.719+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
12-07 22:19:08.719+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-07 22:19:08.719+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
12-07 22:19:08.719+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 0, apptray edit visibility : 0
12-07 22:19:08.719+0900 W/W_HOME  (  715): rotary.c: rotary_deattach(156) > rotary_deattach:0x45cdb7a0
12-07 22:19:08.719+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 22:19:08.719+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x45cdb7a0, elm_layout, func : 0x4004ac29
12-07 22:19:08.719+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
12-07 22:19:08.719+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
12-07 22:19:08.719+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 22:19:08.719+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8a6a8, elm_box, _activated_obj : 0x45cdb7a0, activated : 1
12-07 22:19:08.719+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
12-07 22:19:08.719+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:19:08.719+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5125) > Return true for 215, 218.
12-07 22:19:08.719+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
12-07 22:19:08.724+0900 W/W_HOME  (  715): noti_broker.c: _apptray_visibility_cb(788) > apps,hide
12-07 22:19:08.724+0900 W/W_HOME  (  715): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80001
12-07 22:19:08.724+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x80001
12-07 22:19:08.724+0900 I/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1701) > is_app_tray_displayed: 0
12-07 22:19:08.729+0900 E/APPS    (  715): apps_main.c: apps_main_pause(599) >  paused already
12-07 22:19:08.739+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-07 22:19:08.739+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4529) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
12-07 22:19:08.739+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4534) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
12-07 22:19:09.254+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:19:09.254+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:19:11.649+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 2 -> 1
12-07 22:19:11.669+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-07 22:19:11.669+0900 E/WMS     (  491): ==========
12-07 22:19:11.669+0900 E/WMS     (  491): ##WMS SEND : mgr_gear_wear_onoff_req
12-07 22:19:11.669+0900 E/WMS     (  491): ==========
12-07 22:19:11.669+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-07 22:19:11.749+0900 W/SHealth_Service( 1078): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
12-07 22:19:11.749+0900 E/SHealth_Service( 1078): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-07 22:19:15.954+0900 E/PKGMGR_SERVER(30698): pkgmgr-server.c: main(2126) > package manager server start
12-07 22:19:16.089+0900 E/PKGMGR_SERVER(30698): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1271988193], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-07 22:19:16.094+0900 E/PKGMGR_SERVER(30700): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-07 22:19:16.104+0900 E/PKGMGR  (30692): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-07 22:19:16.164+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:19:16.174+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 30318
12-07 22:19:16.174+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:19:16.174+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 5
12-07 22:19:16.179+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(30318), cmd(4)
12-07 22:19:16.179+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 22:19:16.179+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(884) > app status : 4
12-07 22:19:16.184+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:19:16.184+0900 W/CAPI_WATCH_APPLICATION(30318): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-07 22:19:16.184+0900 W/WATCH_CORE(30318): appcore-watch.c: __widget_destroy(992) > widget_destory
12-07 22:19:16.184+0900 E/WIDGET_PROVIDER_APP(30318): client.c: client_fini(1175) > Provider is not initialized
12-07 22:19:16.189+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 30318
12-07 22:19:16.189+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 22:19:16.294+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:19:16.364+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 22:19:16.404+0900 E/AUL_AMD (  495): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-07 22:19:16.404+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(30318), cmd(4)
12-07 22:19:16.419+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:19:16.424+0900 E/PKGMGR_SERVER(30700): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-07 22:19:16.464+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:19:16.469+0900 E/PKGMGR_SERVER(30698): pkgmgr-server.c: sighandler(445) > child NORMAL exit [30700]
12-07 22:19:16.489+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:19:16.489+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 22:19:16.489+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 22:19:16.549+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 22:19:16.549+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 22:19:16.554+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 22:19:16.554+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-07 22:19:16.554+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 22:19:16.589+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 22:19:16.614+0900 E/TBM     (30487): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 22:19:16.664+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 30318
12-07 22:19:16.709+0900 W/WATCH_CORE(30487): appcore-watch.c: __widget_create(958) > widget_create
12-07 22:19:16.709+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [81032.296875] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_81032.296875.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29361068:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 22:19:16.709+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[81032.296875] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_81032.296875.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29361068:4] gbar_fname[]
12-07 22:19:16.724+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 22:19:16.724+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 22:19:16.794+0900 W/WATCH_CORE(30487): appcore-watch.c: __widget_create(976) > widget_create done
12-07 22:19:16.869+0900 I/WATCH_CORE(30487): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-07 22:19:16.869+0900 I/WATCH_CORE(30487): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-07 22:19:16.869+0900 I/WATCH_CORE(30487): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-07 22:19:16.909+0900 W/WATCH_CORE(30487): appcore-watch.c: __widget_resume(1012) > widget_resume
12-07 22:19:16.909+0900 W/W_HOME  (  715): gesture.c: _widget_updated_cb(190) > widget updated
12-07 22:19:16.909+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-07 22:19:16.909+0900 W/W_HOME  (  715): gesture.c: _manual_render(176) > 
12-07 22:19:16.919+0900 W/W_HOME  (  715): gesture.c: _manual_render(176) > 
12-07 22:19:16.944+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:16.949+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 0
12-07 22:19:16.994+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:17.664+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:19:17.664+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:19:17.679+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:19:17.689+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 30487
12-07 22:19:17.689+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:19:17.884+0900 I/AUL_PAD (30727): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 22:19:17.999+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:18.219+0900 W/AUL_AMD (  495): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 22:19:18.829+0900 E/PKGMGR_SERVER(30698): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 22:19:18.829+0900 E/PKGMGR_SERVER(30698): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 22:19:18.999+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:19.999+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:21.009+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:21.074+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 22:19:21.074+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 22:19:21.999+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:23.004+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:23.999+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:25.004+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:26.004+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:26.399+0900 E/PKGMGR  (30850): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-07 22:19:26.539+0900 E/PKGMGR_SERVER(30852): pkgmgr-server.c: main(2126) > package manager server start
12-07 22:19:26.679+0900 E/PKGMGR_SERVER(30852): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1261408306], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-1261408306' '-r' 'org.reolab.blackandwhite'], cookie=[OrC77Gd3vkPlzCRTvl7Lhgr5yt0=], backend_flag=[0]
12-07 22:19:26.684+0900 E/PKGMGR  (30852): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-07 22:19:26.684+0900 E/PKGMGR_SERVER(30852): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-07 22:19:26.689+0900 E/PKGMGR  (30850): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[308500002]
12-07 22:19:26.694+0900 E/PKGMGR_SERVER(30853): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-07 22:19:26.844+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-07 22:19:26.854+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 22:19:26.859+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-07 22:19:26.874+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:19:26.999+0900 I/CAPI_WATCH_APPLICATION(30487): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:19:27.339+0900 W/CRASH_MANAGER(30855): worker.c: worker_job(1199) > 1130487626c61144949436
