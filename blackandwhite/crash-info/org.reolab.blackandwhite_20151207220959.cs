S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 28237
Date: 2015-12-07 22:09:59+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x3c

Register Information
r0   = 0x0000003f, r1   = 0x0000003c
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x4000174e
r6   = 0xbe9157d0, r7   = 0x0000003f
r8   = 0x00000034, r9   = 0x42cd3d10
r10  = 0x40001719, fp   = 0xbe9157c4
ip   = 0x00000000, sp   = 0xbe915260
lr   = 0x403055b8, pc   = 0x40338dc4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     16896 KB
Buffers:     17284 KB
Cached:      96956 KB
VmPeak:      65608 KB
VmSize:      65096 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12788 KB
VmRSS:       12788 KB
VmData:      12216 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       19388 KB
VmPTE:          46 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 28237 TID = 28237
28237 28242 

Maps Information
40000000 40002000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
4000a000 40027000 r-xp /lib/ld-2.13.so
40030000 40034000 r-xp /usr/lib/libsys-assert.so
4003d000 40041000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
40051000 40058000 r-xp /usr/lib/libappcore-watch.so.1.1
40061000 40063000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4006c000 40071000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
40079000 4007b000 r-xp /usr/lib/libdlog.so.0.0.0
40083000 401bd000 r-xp /usr/lib/libelementary.so.1.7.99
401d3000 402a2000 r-xp /usr/lib/libevas.so.1.7.99
402c6000 403e1000 r-xp /lib/libc-2.13.so
403ef000 403f7000 r-xp /lib/libgcc_s-4.6.so.1
403f8000 4040c000 r-xp /lib/libpthread-2.13.so
40417000 40422000 r-xp /lib/libunwind.so.8.0.1
4044f000 40451000 r-xp /lib/libdl-2.13.so
4045a000 40466000 r-xp /usr/lib/libaul.so.0.1.0
40470000 40487000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4048f000 4049c000 r-xp /usr/lib/libalarm.so.0.0.0
404a5000 404d9000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
404e2000 404e7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
404ef000 40511000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40519000 40530000 r-xp /usr/lib/libecore.so.1.7.99
40547000 40588000 r-xp /usr/lib/libeina.so.1.7.99
40591000 406ce000 r-xp /usr/lib/libicui18n.so.51.1
406de000 407c2000 r-xp /usr/lib/libicuuc.so.51.1
407d7000 407db000 r-xp /usr/lib/libvconf.so.0.2.45
407e3000 408b3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
408b4000 408de000 r-xp /usr/lib/libdbus-1.so.3.8.12
408e7000 408ed000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
408f5000 408fb000 r-xp /usr/lib/libwidget.so.1.0.0
40904000 40909000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
40911000 409e4000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
409ef000 40a58000 r-xp /lib/libm-2.13.so
40a61000 40a7a000 r-xp /usr/lib/libeet.so.1.7.99
40a8b000 40aad000 r-xp /usr/lib/libecore_evas.so.1.7.99
40ab6000 40abb000 r-xp /usr/lib/libecore_file.so.1.7.99
40ac3000 40ad4000 r-xp /usr/lib/libecore_input.so.1.7.99
40adc000 40b39000 r-xp /usr/lib/libedje.so.1.7.99
40b43000 40b93000 r-xp /usr/lib/libecore_x.so.1.7.99
40b95000 40b9e000 r-xp /usr/lib/libedbus.so.1.7.99
40ba6000 40bc0000 r-xp /usr/lib/libecore_con.so.1.7.99
40bc9000 40bdc000 r-xp /usr/lib/libfribidi.so.0.3.1
40be4000 40c21000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40c2a000 40c52000 r-xp /usr/lib/libfontconfig.so.1.8.0
40c53000 40ca9000 r-xp /usr/lib/libfreetype.so.6.11.3
40cb5000 40d0b000 r-xp /usr/lib/libpixman-1.so.0.28.2
40d18000 40d1b000 r-xp /usr/lib/libbundle.so.0.1.22
40d23000 40d28000 r-xp /usr/lib/libxdgmime.so.1.1.0
40d30000 40d6c000 r-xp /usr/lib/libsystemd.so.0.4.0
40d75000 40d78000 r-xp /usr/lib/libproc-stat.so.0.2.86
40d80000 40da6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40daf000 40db5000 r-xp /usr/lib/libappsvc.so.0.1.0
40dbd000 40dbe000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40dc6000 40dcc000 r-xp /lib/librt-2.13.so
40dd5000 40dda000 r-xp /usr/lib/libffi.so.5.0.10
40de2000 40de5000 r-xp /usr/lib/libsmack.so.1.0.0
40ded000 40e02000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40e0a000 40e7f000 r-xp /usr/lib/libsqlite3.so.0.8.6
40e89000 40f1d000 r-xp /usr/lib/libstdc++.so.6.0.16
424b7000 424c0000 r-xp /usr/lib/libcom-core.so.0.0.1
424c9000 424d5000 r-xp /usr/lib/libwidget_service.so.1.0.0
424dd000 424e3000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
424ec000 424f5000 r-xp /usr/lib/libwidget_provider.so.1.0.0
424fe000 425df000 r-xp /usr/lib/libX11.so.6.3.0
425ea000 425ec000 r-xp /usr/lib/libiniparser.so.0
425f5000 426c1000 r-xp /usr/lib/libxml2.so.2.7.8
426ce000 426d0000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
426d8000 426ee000 r-xp /lib/libz.so.1.2.5
426f6000 42706000 r-xp /lib/libresolv-2.13.so
4270a000 4272d000 r-xp /usr/lib/libjpeg.so.8.0.2
42745000 4274a000 r-xp /usr/lib/libecore_fb.so.1.7.99
42753000 42757000 r-xp /usr/lib/libecore_ipc.so.1.7.99
42760000 42763000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
4276b000 42772000 r-xp /usr/lib/libembryo.so.1.7.99
4277a000 42791000 r-xp /usr/lib/liblua-5.1.so
4279a000 427a0000 r-xp /usr/lib/libecore_imf.so.1.7.99
427a9000 427aa000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
427b2000 427b9000 r-xp /usr/lib/libXcursor.so.1.0.2
427c1000 427c3000 r-xp /usr/lib/libXdamage.so.1.1.0
427cb000 427cd000 r-xp /usr/lib/libXcomposite.so.1.0.0
427d5000 427d7000 r-xp /usr/lib/libXgesture.so.7.0.0
427e0000 427e3000 r-xp /usr/lib/libXfixes.so.3.1.0
427eb000 427f4000 r-xp /usr/lib/libXi.so.6.1.0
427fc000 427fd000 r-xp /usr/lib/libXinerama.so.1.0.0
42806000 4280c000 r-xp /usr/lib/libXrandr.so.2.2.0
42814000 4281a000 r-xp /usr/lib/libXrender.so.1.3.0
42822000 42825000 r-xp /usr/lib/libXtst.so.6.1.0
4282f000 42839000 r-xp /usr/lib/libXext.so.6.4.0
42842000 42886000 r-xp /usr/lib/libcurl.so.4.3.0
4288f000 428a5000 r-xp /lib/libexpat.so.1.5.2
428af000 428c7000 r-xp /usr/lib/libpng12.so.0.50.0
428cf000 428e7000 r-xp /usr/lib/liblzma.so.5.0.3
428f0000 4296c000 r-xp /usr/lib/libgcrypt.so.20.0.3
42978000 42994000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
4299d000 4299f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
429a8000 429aa000 r-xp /usr/lib/journal/libjournal.so.0.1.0
429b3000 429bb000 r-xp /usr/lib/libdrm.so.2.4.0
429c3000 429c5000 r-xp /usr/lib/libdri2.so.0.0.0
429cd000 429d4000 r-xp /usr/lib/libtbm.so.1.0.0
429dc000 429ef000 r-xp /usr/lib/libxcb.so.1.1.0
429f9000 42a02000 r-xp /usr/lib/libcares.so.2.1.0
42a0b000 42a39000 r-xp /usr/lib/libidn.so.11.5.44
42a41000 42a8e000 r-xp /usr/lib/libssl.so.1.0.0
42a9a000 42c42000 r-xp /usr/lib/libcrypto.so.1.0.0
42c5b000 42c66000 r-xp /usr/lib/libgpg-error.so.0.15.0
42c6f000 42c71000 r-xp /usr/lib/libiri.so
42c79000 42c7c000 r-xp /lib/libcap.so.2.21
42c84000 42c8b000 r-xp /lib/libcrypt-2.13.so
42cbb000 42cbd000 r-xp /usr/lib/libXau.so.6.0.0
42cc5000 42cc8000 r-xp /lib/libattr.so.1.1.0
43108000 43907000 rw-p [stack:28242]
43907000 4390a000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43912000 4391d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c63000 43c7a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
be8f6000 be917000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28237)
Call Stack Count: 1
 0: strlen + 0x4 (0x40338dc4) [/lib/libc.so.6] + 0x72dc4
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
equestReceived(147) > MessagePort message received
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.watchface:com.samsung.watchface], client = 28265
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [health-data-service:HEALTH_SERVICE_PORT]
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [health-data-service:HEALTH_SERVICE_PORT]
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.054+0900 I/HealthDataService( 1093): health_ipc_server.c: __health_server_ipc_add_client(340) > [1;35mApplication Information is registered in the map:[425A34B8] [com.samsung.watchface][0;m
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.watchface:com.samsung.watchface]
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.watchface:com.samsung.watchface]
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.074+0900 I/healthData(28265): health_fw_connection.c: __health_service_connection_cb(192) > [1;35mService Connection status Changed : from [6] to [0][0;m
12-07 22:10:01.099+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.109+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.119+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.124+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.134+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.139+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.149+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.159+0900 E/W_HOME  (  715): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
12-07 22:10:01.159+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.164+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.179+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.184+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.199+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.204+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [74]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [75]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [76]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [78]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [84]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [85]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [86]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [74]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [75]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [76]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [78]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [84]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [85]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [86]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [74]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [75]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [76]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [78]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [84]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [85]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [86]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [79]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [80]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [81]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [79]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [82]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [83]
12-07 22:10:01.214+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.219+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [87]
12-07 22:10:01.219+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [88]
12-07 22:10:01.224+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.229+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [89]
12-07 22:10:01.229+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [90]
12-07 22:10:01.234+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [91]
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [92]
12-07 22:10:01.239+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:01.239+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [4] to pending list
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
12-07 22:10:01.339+0900 E/watchface-loader(28265): watchface-loader.cpp: OnDummyModeOffTimerExpired(396) > disable dummy mode
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-impl.cpp: SetDummyMode(95) > dummyMode[0]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [28]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [13]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [73]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [27]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [74]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [75]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [76]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [77]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [78]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [84]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [85]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [86]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [79]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [80]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [81]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [82]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [83]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [87]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [88]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [89]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [90]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [91]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [92]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [1]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [4]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: Notify(984) > skip first tick after resume!!
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
12-07 22:10:01.339+0900 E/EFL     (28265): elementary<28265> elm_layout.c:2207 elm_layout_add() could not add 0x4766a910 as sub object of 0x47668e10
12-07 22:10:01.349+0900 E/EFL     (28265): edje<28265> edje_util.c:3770 edje_object_size_min_restricted_calc() group digital-clock/24 has a non-fixed part 'hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: UpdateLayout(1257) > colon 20x118 at (132,0)
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 ']
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 100x46
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(463) > inline-image index[0]
12-07 22:10:01.354+0900 E/BASE_UTILS(28265): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=1 ']
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 152x32
12-07 22:10:01.359+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(754) > cursor 32x2 at (0,29)
12-07 22:10:01.359+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(768) > image 32x37 at (0,-2)
12-07 22:10:01.359+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(463) > inline-image index[0]
12-07 22:10:01.359+0900 E/BASE_UTILS(28265): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=1 ']
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 152x32
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(754) > cursor 32x2 at (0,29)
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(768) > image 32x37 at (0,-2)
12-07 22:10:01.369+0900 E/BASE_UTILS(28265): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=1 ']
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 120x32
12-07 22:10:01.374+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:01.429+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:01.429+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:01.624+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:01.624+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:01.824+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:01.824+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:01.889+0900 I/watchface-viewer(28265): viewer-view.cpp: DummyModeAnimationFinished(360) > 
12-07 22:10:02.019+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:02.019+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:02.019+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: StartColonAnimation(1501) > 
12-07 22:10:02.019+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:02.214+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:02.214+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:02.414+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:02.414+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:02.474+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: ColonAnimationTimerExpired(1569) > 
12-07 22:10:02.609+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:02.609+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:02.809+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:02.809+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.009+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:03.009+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.009+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:03.209+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:03.209+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.409+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:03.409+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:03.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:03.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.929+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1128098626c611449493794
12-07 22:10:04.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:04.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:04.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:04.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:04.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:04.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:04.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:04.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:04.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:04.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:04.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:05.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:05.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:05.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:05.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:05.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:05.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.949+0900 I/RESOURCED(  498): vmpressure-lowmem-handler.c: change_lowmem_state(1093) > [change_lowmem_state,1093] [LOW MEM STATE] mem swap ==> mem normal
12-07 22:10:05.949+0900 I/RESOURCED(  498): vmpressure-lowmem-handler.c: adjust_dynamic_threshold(321) > [adjust_dynamic_threshold,321] dynamic_threshold is changed from 60 to 60, cur_mem_state = mem normal, victim_memcg = 5
12-07 22:10:06.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:06.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:06.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:06.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:06.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:06.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:06.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:06.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:06.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:06.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:06.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:07.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:07.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:07.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:07.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:07.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:07.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:07.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:07.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:07.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:07.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:07.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:08.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:08.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:08.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:08.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:08.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:08.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:08.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:08.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:08.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:08.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:08.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:09.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:09.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:09.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:09.164+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1128193626c611449493795
12-07 22:10:09.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:09.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:09.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:09.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:09.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:09.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:09.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:09.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:10.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:10.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:10.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:10.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:10.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:10.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:10.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:10.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:10.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:10.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:10.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:11.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:11.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:11.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:11.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:11.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:11.409+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:11.409+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:11.609+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:11.609+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:11.809+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:11.809+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:12.009+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:12.009+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:12.009+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:12.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:12.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:12.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:12.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:12.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:12.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:12.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:12.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:13.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:13.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:13.009+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1128203626c611449493796
12-07 22:10:13.014+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:13.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:13.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:13.409+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:13.409+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:13.609+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:13.609+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:13.809+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:13.809+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:14.009+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:14.009+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:14.009+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:14.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:14.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:14.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:14.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:14.609+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:14.609+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:14.809+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:14.809+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:15.009+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:15.009+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:15.009+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:15.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:15.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:15.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:15.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:15.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:15.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:15.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:15.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:16.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:16.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:16.009+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:16.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:16.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:16.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:16.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:16.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:16.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:16.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:16.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:17.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:17.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:17.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:17.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:17.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:17.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:17.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:17.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:17.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:17.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:17.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:18.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:18.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:18.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:18.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:18.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:18.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:18.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:18.599+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1128192626c611449493797
12-07 22:10:18.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:18.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:18.809+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:18.809+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:19.009+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:19.009+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:19.009+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:19.209+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:19.209+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:19.409+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:19.409+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:19.609+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:19.609+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:19.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:19.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:20.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:20.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:20.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:20.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:20.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:20.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:20.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:20.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:20.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:20.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:20.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:21.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:21.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:21.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:21.074+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 22:10:21.074+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 22:10:21.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:21.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:21.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:21.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:21.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:21.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:21.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:21.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:22.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:22.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:22.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:22.029+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1128237626c61144949379
