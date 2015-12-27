S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 1690
Date: 2015-12-07 22:48:18+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x190

Register Information
r0   = 0x00000184, r1   = 0x0000000d
r2   = 0x00000004, r3   = 0x41553194
r4   = 0x00000184, r5   = 0x00000000
r6   = 0x414e103c, r7   = 0x414dd608
r8   = 0x00000070, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeaf2c6c, sp   = 0xbeaf2c20
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     16788 KB
Buffers:     24692 KB
Cached:     187604 KB
VmPeak:      76304 KB
VmSize:      75792 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14780 KB
VmRSS:       14780 KB
VmData:      21480 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20488 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 1690 TID = 1690
1690 1851 1860 

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
43537000 43d36000 rw-p [stack:1851]
43d36000 43d39000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d41000 43d4c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dd4000 43deb000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4402b000 44900000 rw-p [stack:1860]
bead3000 beaf4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1690)
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
(1) : BT|[0m
12-07 22:47:35.375+0900 W/WG-CONSUMER( 1156): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_ESTABLISHED->SM_STATE_REGISTER_AGENT[0m
12-07 22:47:35.375+0900 W/WG-CONSUMER( 1156): [34m[F:TransferCtrl.cpp L:  210][_HIGH]CTransferCtrl::OnTerminated. Cause=TERMINATION_FROM_PEER[0m
12-07 22:47:35.375+0900 W/WG-CONSUMER( 1156): [34m[F:TransferCtrl.cpp L:  218][_HIGH]Malloc Trimmed[0m
12-07 22:47:35.390+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-07 22:47:35.390+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-07 22:47:35.390+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-07 22:47:35.390+0900 I/HIGEAR  ( 1071): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-07 22:47:35.395+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: OnReceiveDisplayChanged(905) > [0;32mINFO: LCDOn receive data : 1124318408[0;m
12-07 22:47:35.395+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-07 22:47:35.395+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-07 22:47:35.400+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-07 22:47:35.400+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-07 22:47:35.410+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-07 22:47:35.410+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-07 22:47:35.410+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-07 22:47:35.410+0900 I/HIGEAR  ( 1071): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-07 22:47:35.420+0900 W/WG-CONSUMER( 1156): [32m[F:SAPProxy.cpp     L:  620][_WARN][Phone->Gear] Got Disconnect. uwServiceHandle(2) wStatusCode(0)[0m
12-07 22:47:35.420+0900 W/WG-CONSUMER( 1156): [32m[F:ConnectionInfo.c L: 1238][_WARN][RX][Phone->Gear] Got Disconnect. uwServiceHandle(2) wStatusCode(0)[0m
12-07 22:47:35.420+0900 W/WG-CONSUMER( 1156): [32m[F:ConnectionInfo.c L: 1239][_WARN][RX]Connection Info. AgentID(18756) ServiceHandle(2) CurrentState=SM_STATE_ESTABLISHED[0m
12-07 22:47:35.420+0900 W/WG-CONSUMER( 1156): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=1 pConnected=0x42ea8d98[0m
12-07 22:47:35.420+0900 W/WG-CONSUMER( 1156): [34m[F:PeerList.cpp     L:  103][_HIGH][RX]This=0x42ea8d98 PeerAgent(0x42ea8d9c) bSet(1)[0m
12-07 22:47:35.420+0900 W/WG-CONSUMER( 1156): [34m[F:PeerList.cpp     L:  104][_HIGH][RX]  DeviceID=1 PeerAgentID=23056 ServiceHandle=2[0m
12-07 22:47:35.420+0900 W/WG-CONSUMER( 1156): [34m[F:PeerList.cpp     L:  106][_HIGH][RX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=3.0[0m
12-07 22:47:35.420+0900 W/WG-CONSUMER( 1156): [34m[F:PeerList.cpp     L:  107][_HIGH][RX]  ConnectType(1) : BT|[0m
12-07 22:47:35.420+0900 W/WG-CONSUMER( 1156): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_ESTABLISHED->SM_STATE_REGISTER_AGENT[0m
12-07 22:47:35.420+0900 W/WG-CONSUMER( 1156): [34m[F:ReceiverCtrl.cpp L:  460][_HIGH]CReceiverCtrl::OnTerminated. Cause=TERMINATION_FROM_PEER[0m
12-07 22:47:36.000+0900 I/CAPI_WATCH_APPLICATION( 1533): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:36.150+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:36.150+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:36.150+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:36.150+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:47:36.150+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:47:36.150+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:36.150+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 22:47:36.150+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:36.155+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:36.160+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:36.160+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:36.160+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:47:36.160+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:47:36.160+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:36.160+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 22:47:36.160+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:47:36.160+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:47:36.160+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:36.165+0900 E/CAPI_APPFW_APP_CONTROL( 1020): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-07 22:47:36.165+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1020]   value = [true][0m
12-07 22:47:36.235+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:47:36.245+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 707
12-07 22:47:36.270+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT][0m
12-07 22:47:36.275+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:36.275+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:36.275+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:36.275+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:47:36.275+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:47:36.275+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:36.275+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 22:47:36.275+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:36.280+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:36.280+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:36.280+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:36.280+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:47:36.280+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:47:36.280+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:36.280+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 22:47:36.285+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:47:36.285+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:47:36.285+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:36.285+0900 W/W_HOME  (  707): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-07 22:47:36.285+0900 E/W_HOME  (  707): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 22:47:36.295+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT][0m
12-07 22:47:36.305+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:36.305+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:36.305+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:36.305+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:47:36.305+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:47:36.305+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:36.305+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 22:47:36.305+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:36.310+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:36.310+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:36.310+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:36.310+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:47:36.310+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:47:36.310+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:36.310+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 22:47:36.310+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:47:36.310+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:47:36.310+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:36.310+0900 W/W_HOME  (  707): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-07 22:47:36.310+0900 E/W_HOME  (  707): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 22:47:36.320+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:36.320+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:36.320+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:36.320+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:47:36.320+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:47:36.320+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:36.325+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 22:47:36.325+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:36.330+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:36.330+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:36.330+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:36.330+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:47:36.330+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:47:36.330+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:36.330+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 22:47:36.330+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:47:36.335+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:47:36.335+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:37.004+0900 I/CAPI_WATCH_APPLICATION( 1533): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:38.005+0900 I/CAPI_WATCH_APPLICATION( 1533): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:39.005+0900 I/CAPI_WATCH_APPLICATION( 1533): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:39.970+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-07 22:47:40.005+0900 I/CAPI_WATCH_APPLICATION( 1533): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:41.004+0900 I/CAPI_WATCH_APPLICATION( 1533): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:41.690+0900 W/WATCH_CORE( 1533): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-07 22:47:41.690+0900 I/WATCH_CORE( 1533): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-07 22:47:41.725+0900 W/W_HOME  (  707): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-07 22:47:41.725+0900 W/W_HOME  (  707): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-07 22:47:41.725+0900 W/W_HOME  (  707): gesture.c: _manual_render_enable(133) > 1
12-07 22:47:41.725+0900 W/W_HOME  (  707): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-07 22:47:41.725+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:47:41.740+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-07 22:47:41.740+0900 W/STARTER (  691): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-07 22:47:41.740+0900 E/STARTER (  691): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-07 22:47:41.740+0900 W/STARTER (  691): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-07 22:47:41.740+0900 W/STARTER (  691): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-07 22:47:41.745+0900 I/SCONTEXT-LIB(  671): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-07 22:47:41.775+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-07 22:47:41.775+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-07 22:47:41.800+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-07 22:47:41.880+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-07 22:47:41.880+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-07 22:47:41.885+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-07 22:47:41.885+0900 I/HIGEAR  ( 1071): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-07 22:47:41.965+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-07 22:47:41.990+0900 I/SHealth_Common( 1055): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-07 22:47:41.990+0900 I/SHealth_Service( 1055): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-07 22:47:42.005+0900 I/CAPI_WATCH_APPLICATION( 1533): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:42.035+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: PAUSE State: RUNNING
12-07 22:47:42.035+0900 I/CAPI_APPFW_APPLICATION(  707): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-07 22:47:42.035+0900 W/W_HOME  (  707): main.c: _appcore_pause_cb(690) > appcore pause
12-07 22:47:42.035+0900 W/W_HOME  (  707): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-07 22:47:42.035+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:47:42.035+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:47:42.035+0900 W/W_HOME  (  707): main.c: home_pause(751) > clock/widget paused
12-07 22:47:42.040+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-07 22:47:42.040+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-07 22:47:42.040+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-07 22:47:42.040+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-07 22:47:42.050+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:47:42.055+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:42.065+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-07 22:47:42.085+0900 E/CAPI_APPFW_APP_CONTROL( 1020): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-07 22:47:42.085+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1020]   value = [false][0m
12-07 22:47:42.180+0900 W/WATCH_CORE( 1533): appcore-watch.c: __widget_pause(1001) > widget_pause
12-07 22:47:42.565+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: MEM_FLUSH State: PAUSED
12-07 22:47:47.149+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: MEM_FLUSH State: PAUSED
12-07 22:47:59.260+0900 E/PKGMGR_SERVER( 1837): pkgmgr-server.c: main(2126) > package manager server start
12-07 22:47:59.360+0900 E/PKGMGR_SERVER( 1837): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_451278852], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-07 22:47:59.365+0900 E/PKGMGR_SERVER( 1839): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-07 22:47:59.370+0900 E/PKGMGR  ( 1831): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-07 22:47:59.430+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:47:59.440+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1533
12-07 22:47:59.440+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:47:59.445+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 5
12-07 22:47:59.450+0900 W/CAPI_WATCH_APPLICATION( 1533): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-07 22:47:59.450+0900 W/WATCH_CORE( 1533): appcore-watch.c: __widget_destroy(992) > widget_destory
12-07 22:47:59.450+0900 E/WIDGET_PROVIDER_APP( 1533): client.c: client_fini(1175) > Provider is not initialized
12-07 22:47:59.450+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 22:47:59.450+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(884) > app status : 4
12-07 22:47:59.450+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(1533), cmd(4)
12-07 22:47:59.450+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 22:47:59.455+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:47:59.465+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1533
12-07 22:47:59.570+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:47:59.655+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 22:47:59.720+0900 E/AUL_AMD (  530): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-07 22:47:59.750+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(1533), cmd(4)
12-07 22:47:59.750+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:47:59.900+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:47:59.995+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:47:59.995+0900 E/AUL_AMD (  530): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 22:47:59.995+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(1659) > caller pid : 697
12-07 22:48:00.100+0900 E/PKGMGR_SERVER( 1839): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-07 22:48:00.230+0900 E/PKGMGR_SERVER( 1837): pkgmgr-server.c: sighandler(445) > child NORMAL exit [1839]
12-07 22:48:00.250+0900 E/RESOURCED(  532): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 1
12-07 22:48:00.250+0900 E/RESOURCED(  532): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 22:48:00.255+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 22:48:00.255+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-07 22:48:00.255+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 22:48:00.295+0900 I/CAPI_WATCH_APPLICATION( 1690): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 22:48:00.300+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: __on_receive(523) >  Enter
12-07 22:48:00.300+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: __on_receive(525) >  on receive called. payloadLength(854)
12-07 22:48:00.300+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: _handle_sap_msg(142) >  Enter
12-07 22:48:00.300+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1924) >  Enter
12-07 22:48:00.320+0900 W/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1943) >  > Received message id: (email-init-req)
12-07 22:48:00.320+0900 E/TBM     ( 1690): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 22:48:00.320+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _get_is_ack_support(216) >  Enter
12-07 22:48:00.320+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _get_is_ack_support(217) >  Leave
12-07 22:48:00.330+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: _send_sap_msg(265) >  Success sending message
12-07 22:48:00.330+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1981) >  success to send : seqId(125)
12-07 22:48:00.330+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __parse_init_req_ind(1141) >  Enter
12-07 22:48:00.330+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-db.c: _db_check_account_data_by_account_id(1506) >  Leave
12-07 22:48:00.335+0900 I/WEMAIL_COMMON( 1164): wemail-ipc-msg.c: wemail_ipc_serialize_op_data(609) >  Enter
12-07 22:48:00.335+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-db.c: _db_update_account_data(1592) >  Leave
12-07 22:48:00.340+0900 I/WEMAIL_COMMON( 1164): wemail-ipc-msg.c: wemail_ipc_serialize_op_data(609) >  Enter
12-07 22:48:00.345+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _set_is_ack_support(208) >  Enter
12-07 22:48:00.345+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _set_is_ack_support(209) >  ack support: 1
12-07 22:48:00.345+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _set_is_ack_support(211) >  Leave
12-07 22:48:00.345+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_is_network_connection_available(637) >  Enter
12-07 22:48:00.355+0900 I/WECONN  (  512): technology.c: __get_state(83) > W_SERVICE_TYPE_BT
12-07 22:48:00.360+0900 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1533
12-07 22:48:00.400+0900 W/WATCH_CORE( 1690): appcore-watch.c: __widget_create(958) > widget_create
12-07 22:48:00.405+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1712) > [SECURE_LOG] [93.900696] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_93.900696.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263022:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 22:48:00.405+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[93.900696] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_93.900696.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263022:4] gbar_fname[]
12-07 22:48:00.425+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_is_network_connection_available(654) >  network connection state:[17:3]
12-07 22:48:00.425+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-db.c: _db_get_changelog_data_list(1745) >  Leave
12-07 22:48:00.425+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __parse_init_req_ind(1213) >  Leave
12-07 22:48:00.425+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(2060) >  Leave
12-07 22:48:00.425+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: _handle_sap_msg(228) >  Leave
12-07 22:48:00.430+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _refresh_memory_trim_timer(131) >  Enter
12-07 22:48:00.430+0900 E/WIDGET_VIEWER(  707): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 22:48:00.430+0900 E/WIDGET_EVAS(  707): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 22:48:00.430+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _can_be_killed_consumer(450) >  Enter
12-07 22:48:00.430+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_app_status(1128) >  Enter
12-07 22:48:00.430+0900 W/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_app_status(1134) >  app foreground status: [0]
12-07 22:48:00.430+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_app_status(1144) >  Leave
12-07 22:48:00.435+0900 W/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_is_noti_existing(1167) >  Email notification status: [0]
12-07 22:48:00.435+0900 W/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _can_be_killed_consumer(472) >  consumer can be killed: [1]
12-07 22:48:00.435+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _can_be_killed_consumer(473) >  Leave
12-07 22:48:00.435+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _refresh_kill_timer(141) >  Enter
12-07 22:48:00.435+0900 W/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _refresh_kill_timer(142) >  REFRESH kill timer!
12-07 22:48:00.435+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: __on_receive(535) >  Leave
12-07 22:48:00.435+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: __on_receive(523) >  Enter
12-07 22:48:00.440+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: __on_receive(525) >  on receive called. payloadLength(854)
12-07 22:48:00.455+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: _handle_sap_msg(142) >  Enter
12-07 22:48:00.455+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1924) >  Enter
12-07 22:48:00.455+0900 W/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1943) >  > Received message id: (email-init-req)
12-07 22:48:00.455+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _get_is_ack_support(216) >  Enter
12-07 22:48:00.455+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _get_is_ack_support(217) >  Leave
12-07 22:48:00.465+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: _send_sap_msg(265) >  Success sending message
12-07 22:48:00.470+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1981) >  success to send : seqId(129)
12-07 22:48:00.475+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __parse_init_req_ind(1141) >  Enter
12-07 22:48:00.490+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-db.c: _db_check_account_data_by_account_id(1506) >  Leave
12-07 22:48:00.505+0900 I/WEMAIL_COMMON( 1164): wemail-ipc-msg.c: wemail_ipc_serialize_op_data(609) >  Enter
12-07 22:48:00.510+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-db.c: _db_update_account_data(1592) >  Leave
12-07 22:48:00.515+0900 I/WEMAIL_COMMON( 1164): wemail-ipc-msg.c: wemail_ipc_serialize_op_data(609) >  Enter
12-07 22:48:00.525+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _set_is_ack_support(208) >  Enter
12-07 22:48:00.525+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _set_is_ack_support(209) >  ack support: 1
12-07 22:48:00.525+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _set_is_ack_support(211) >  Leave
12-07 22:48:00.525+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_is_network_connection_available(637) >  Enter
12-07 22:48:00.545+0900 I/WECONN  (  512): technology.c: __get_state(83) > W_SERVICE_TYPE_BT
12-07 22:48:00.555+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_is_network_connection_available(654) >  network connection state:[17:3]
12-07 22:48:00.555+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-db.c: _db_get_changelog_data_list(1745) >  Leave
12-07 22:48:00.560+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __parse_init_req_ind(1213) >  Leave
12-07 22:48:00.560+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(2060) >  Leave
12-07 22:48:00.560+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: _handle_sap_msg(228) >  Leave
12-07 22:48:00.560+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _refresh_memory_trim_timer(131) >  Enter
12-07 22:48:00.560+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _can_be_killed_consumer(450) >  Enter
12-07 22:48:00.560+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_app_status(1128) >  Enter
12-07 22:48:00.560+0900 W/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_app_status(1134) >  app foreground status: [0]
12-07 22:48:00.560+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_app_status(1144) >  Leave
12-07 22:48:00.565+0900 W/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_is_noti_existing(1167) >  Email notification status: [0]
12-07 22:48:00.565+0900 W/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _can_be_killed_consumer(472) >  consumer can be killed: [1]
12-07 22:48:00.570+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _can_be_killed_consumer(473) >  Leave
12-07 22:48:00.570+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _refresh_kill_timer(141) >  Enter
12-07 22:48:00.570+0900 W/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _refresh_kill_timer(142) >  REFRESH kill timer!
12-07 22:48:00.570+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: __on_receive(535) >  Leave
12-07 22:48:00.570+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: __on_receive(523) >  Enter
12-07 22:48:00.570+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: __on_receive(525) >  on receive called. payloadLength(854)
12-07 22:48:00.570+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: _handle_sap_msg(142) >  Enter
12-07 22:48:00.570+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1924) >  Enter
12-07 22:48:00.570+0900 W/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1943) >  > Received message id: (email-init-req)
12-07 22:48:00.570+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _get_is_ack_support(216) >  Enter
12-07 22:48:00.570+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _get_is_ack_support(217) >  Leave
12-07 22:48:00.580+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: _send_sap_msg(265) >  Success sending message
12-07 22:48:00.580+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1981) >  success to send : seqId(117)
12-07 22:48:00.580+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __parse_init_req_ind(1141) >  Enter
12-07 22:48:00.580+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-db.c: _db_check_account_data_by_account_id(1506) >  Leave
12-07 22:48:00.585+0900 I/WEMAIL_COMMON( 1164): wemail-ipc-msg.c: wemail_ipc_serialize_op_data(609) >  Enter
12-07 22:48:00.590+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-db.c: _db_update_account_data(1592) >  Leave
12-07 22:48:00.595+0900 I/WEMAIL_COMMON( 1164): wemail-ipc-msg.c: wemail_ipc_serialize_op_data(609) >  Enter
12-07 22:48:00.600+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _set_is_ack_support(208) >  Enter
12-07 22:48:00.600+0900 W/WATCH_CORE( 1690): appcore-watch.c: __widget_create(976) > widget_create done
12-07 22:48:00.600+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _set_is_ack_support(209) >  ack support: 1
12-07 22:48:00.600+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _set_is_ack_support(211) >  Leave
12-07 22:48:00.600+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_is_network_connection_available(637) >  Enter
12-07 22:48:00.610+0900 I/WECONN  (  512): technology.c: __get_state(83) > W_SERVICE_TYPE_BT
12-07 22:48:00.615+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_is_network_connection_available(654) >  network connection state:[17:3]
12-07 22:48:00.615+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-db.c: _db_get_changelog_data_list(1745) >  Leave
12-07 22:48:00.615+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __parse_init_req_ind(1213) >  Leave
12-07 22:48:00.615+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(2060) >  Leave
12-07 22:48:00.615+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-sap-msg-handler.c: _handle_sap_msg(228) >  Leave
12-07 22:48:00.615+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _refresh_memory_trim_timer(131) >  Enter
12-07 22:48:00.615+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _can_be_killed_consumer(450) >  Enter
12-07 22:48:00.615+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_app_status(1128) >  Enter
12-07 22:48:00.620+0900 W/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_app_status(1134) >  app foreground status: [0]
12-07 22:48:00.620+0900 I/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_app_status(1144) >  Leave
12-07 22:48:00.620+0900 W/WEMAIL_COMMON( 1164): wemail-util.c: wemail_util_get_is_noti_existing(1167) >  Email notification status: [0]
12-07 22:48:00.620+0900 W/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _can_be_killed_consumer(472) >  consumer can be killed: [1]
12-07 22:48:00.620+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _can_be_killed_consumer(473) >  Leave
12-07 22:48:00.620+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _refresh_kill_timer(141) >  Enter
12-07 22:48:00.620+0900 W/WEMAIL_CONSUMER( 1164): wemail-consumer.c: _refresh_kill_timer(142) >  REFRESH kill timer!
12-07 22:48:00.620+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer-connection-mgr.c: __on_receive(535) >  Leave
12-07 22:48:00.675+0900 I/WATCH_CORE( 1690): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-07 22:48:00.675+0900 I/WATCH_CORE( 1690): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-07 22:48:00.675+0900 I/WATCH_CORE( 1690): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-07 22:48:01.205+0900 E/PKGMGR_SERVER( 1837): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 22:48:01.205+0900 E/PKGMGR_SERVER( 1837): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 22:48:01.360+0900 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:48:01.360+0900 W/AUL_AMD (  530): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:48:01.375+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:48:01.385+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1690
12-07 22:48:01.385+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:48:01.450+0900 W/AUL_AMD (  530): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 22:48:01.585+0900 I/AUL_PAD ( 1870): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 22:48:11.150+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: __memory_trim_timer_cb(223) >  Enter
12-07 22:48:11.155+0900 I/WEMAIL_CONSUMER( 1164): wemail-consumer.c: __memory_trim_timer_cb(246) >  Leave
12-07 22:48:12.215+0900 E/PKGMGR  ( 1970): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-07 22:48:12.395+0900 E/PKGMGR_SERVER( 1972): pkgmgr-server.c: main(2126) > package manager server start
12-07 22:48:12.475+0900 E/PKGMGR_SERVER( 1972): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_464412883], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_464412883' '-r' 'org.reolab.blackandwhite'], cookie=[PABLe4IkHtcC0j6yiMeRY8LOqJ8=], backend_flag=[0]
12-07 22:48:12.475+0900 E/PKGMGR  ( 1972): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-07 22:48:12.475+0900 E/PKGMGR_SERVER( 1972): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-07 22:48:12.485+0900 E/PKGMGR  ( 1970): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[19700002]
12-07 22:48:12.485+0900 E/PKGMGR_SERVER( 1973): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-07 22:48:12.655+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-07 22:48:12.660+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-07 22:48:12.665+0900 W/AUL_AMD (  530): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 22:48:12.680+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:48:13.240+0900 E/PKGMGR_CERT( 1973): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-07 22:48:13.250+0900 E/PKGMGR_CERT( 1973): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-07 22:48:13.250+0900 E/PKGMGR_CERT( 1973): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-07 22:48:13.250+0900 E/PKGMGR_CERT( 1973): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-07 22:48:13.255+0900 E/PKGMGR_CERT( 1973): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-07 22:48:13.255+0900 E/PKGMGR_CERT( 1973): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-07 22:48:13.255+0900 E/PKGMGR_CERT( 1973): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-07 22:48:13.265+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:48:13.275+0900 E/PKGMGR_CERT( 1973): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-07 22:48:15.015+0900 E/rpm-installer( 1973): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-07 22:48:15.205+0900 E/PKGMGR_SERVER( 1972): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 22:48:17.205+0900 E/PKGMGR_SERVER( 1972): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 22:48:18.045+0900 E/PKGMGR_SERVER( 1972): pkgmgr-server.c: sighandler(445) > child NORMAL exit [1973]
12-07 22:48:18.055+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:48:18.070+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-07 22:48:18.070+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-07 22:48:18.085+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-07 22:48:18.085+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-07 22:48:18.085+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-07 22:48:18.085+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-07 22:48:18.110+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-07 22:48:18.175+0900 E/APPS    (  707): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-07 22:48:18.185+0900 E/PKGMGR_INFO(  527): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-07 22:48:18.525+0900 W/CRASH_MANAGER( 1978): worker.c: worker_job(1199) > 1101690626c61144949609
