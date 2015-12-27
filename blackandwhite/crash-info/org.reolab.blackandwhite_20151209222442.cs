S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 2991
Date: 2015-12-09 22:24:42+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xe14

Register Information
r0   = 0xbebcbc28, r1   = 0xbebcc5e4
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbebcc548, r5   = 0xbebcc2e0
r6   = 0x00000132, r7   = 0xbebcbc30
r8   = 0x4030b9c0, r9   = 0x4145ff30
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4155d1c4, sp   = 0xbebcbc18
lr   = 0x4155433f, pc   = 0x00000e14
cpsr = 0x60000010

Memory Information
MemTotal:   489992 KB
MemFree:     14368 KB
Buffers:     24716 KB
Cached:     190512 KB
VmPeak:     103264 KB
VmSize:     102752 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15536 KB
VmRSS:       15536 KB
VmData:      46224 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22104 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 2991 TID = 2991
2991 3401 3410 

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
4155e000 41566000 r-xp /usr/lib/libmdm-common.so.1.0.89
41567000 4156c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41574000 41576000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4157f000 41585000 r-xp /usr/lib/libappsvc.so.0.1.0
4158d000 415b1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415ba000 41689000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4169f000 416a9000 r-xp /lib/libnss_files-2.13.so
41970000 41974000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41984000 4198b000 r-xp /usr/lib/libappcore-watch.so.1.1
41994000 419c4000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
419c5000 419d9000 r-xp /usr/lib/libcapi-network-nfc.so.0.2.3
419e1000 419ee000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.55
419f6000 419fb000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
41a03000 41a10000 r-xp /usr/lib/libalarm.so.0.0.0
41a19000 41b56000 r-xp /usr/lib/libicui18n.so.51.1
41b66000 41c4a000 r-xp /usr/lib/libicuuc.so.51.1
41c5f000 41c65000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41c6d000 41c73000 r-xp /usr/lib/libwidget.so.1.0.0
41c7c000 41c81000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41c89000 41cc0000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41cc9000 41ce2000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41ceb000 41d15000 r-xp /usr/lib/libnfc.so.1.0.0
41d1e000 41d4f000 r-xp /usr/lib/libmdm.so.1.1.85
41d57000 41d6d000 r-xp /usr/lib/libnetwork.so.0.0.0
41d76000 41d7b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
4330a000 43313000 r-xp /usr/lib/libcom-core.so.0.0.1
4331c000 43328000 r-xp /usr/lib/libwidget_service.so.1.0.0
43330000 43339000 r-xp /usr/lib/libwidget_provider.so.1.0.0
43342000 43348000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43350000 43358000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43360000 4338e000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
4339a000 433a2000 r-xp /usr/lib/libdrm.so.2.4.0
433aa000 433ac000 r-xp /usr/lib/libdri2.so.0.0.0
433b4000 433bb000 r-xp /usr/lib/libtbm.so.1.0.0
433c3000 433dd000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
433e6000 433ed000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
433f6000 433f8000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43400000 43407000 r-xp /usr/lib/libminizip.so.1.0.0
4340f000 4341c000 r-xp /usr/lib/libail.so.0.1.0
43757000 43f56000 rw-p [stack:3401]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45c01000 464a7000 rw-p [stack:3410]
bebac000 bebcd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2991)
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
gePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:24:16.485+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:24:16.485+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-09 22:24:16.485+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 22:24:16.490+0900 W/MUSIC_CONTROL_SERVICE( 1073): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1073]   [MUSIC_PLAYER_EVENT][0m
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:24:16.495+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:24:16.495+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-09 22:24:16.495+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:24:16.500+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:24:17.005+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:17.090+0900 I/GESTURE (  134): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-09 22:24:17.090+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.090+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(257) ev->cur.canvas.y(238)
12-09 22:24:17.090+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.090+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=517160 button=1 downs=1
12-09 22:24:17.095+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.095+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(251) ev->cur.canvas.y(237)
12-09 22:24:17.095+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.105+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.105+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(235) ev->cur.canvas.y(236)
12-09 22:24:17.105+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.120+0900 E/EFL     ( 2711): evas_main<2711> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=517165 button=1 downs=1
12-09 22:24:17.120+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.120+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(212) ev->cur.canvas.y(234)
12-09 22:24:17.120+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.120+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-09 22:24:17.120+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c885c8), type(elm_scroller)
12-09 22:24:17.120+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-09 22:24:17.120+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c885c8), type(elm_scroller)
12-09 22:24:17.130+0900 W/W_HOME  (  715): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0x49b11df8 -> 360 0 0x47b83ad0
12-09 22:24:17.135+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,start
12-09 22:24:17.135+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.135+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(184) ev->cur.canvas.y(232)
12-09 22:24:17.135+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.135+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c885c8), locked_x(0)
12-09 22:24:17.135+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c885c8)
12-09 22:24:17.135+0900 W/W_HOME  (  715): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-09 22:24:17.135+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:24:17.135+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.135+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.140+0900 I/GESTURE (  134): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-09 22:24:17.145+0900 E/EFL     ( 2711): evas_main<2711> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=517200 button=1 downs=0
12-09 22:24:17.145+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.145+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(157) ev->cur.canvas.y(232)
12-09 22:24:17.145+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.150+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.150+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(133) ev->cur.canvas.y(232)
12-09 22:24:17.150+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.150+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c885c8), locked_x(0)
12-09 22:24:17.150+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c885c8)
12-09 22:24:17.155+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.155+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.165+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.165+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(117) ev->cur.canvas.y(233)
12-09 22:24:17.165+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.165+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c885c8), locked_x(0)
12-09 22:24:17.165+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c885c8)
12-09 22:24:17.165+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.165+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.175+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.175+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(88) ev->cur.canvas.y(235)
12-09 22:24:17.175+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.180+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=517253 button=1 downs=0
12-09 22:24:17.185+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c885c8), type(elm_scroller)
12-09 22:24:17.185+0900 W/W_HOME  (  715): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
12-09 22:24:17.185+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.185+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.200+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.200+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.220+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.220+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.240+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.240+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.255+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.255+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.270+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.270+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.290+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.290+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.310+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.310+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.315+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-09 22:24:17.315+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c885c8 : elm_scroller] CurrentPage(2)
12-09 22:24:17.330+0900 W/WATCH_CORE( 2711): appcore-watch.c: __widget_pause(1001) > widget_pause
12-09 22:24:17.465+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
12-09 22:24:17.490+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.490+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(33) ev->cur.canvas.y(213)
12-09 22:24:17.490+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.490+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=517549 button=1 downs=1
12-09 22:24:17.490+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.490+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(43) ev->cur.canvas.y(221)
12-09 22:24:17.490+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.510+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.510+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(57) ev->cur.canvas.y(226)
12-09 22:24:17.510+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.510+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.510+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(74) ev->cur.canvas.y(226)
12-09 22:24:17.510+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.510+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-09 22:24:17.510+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c885c8), type(elm_scroller)
12-09 22:24:17.510+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-09 22:24:17.510+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c885c8), type(elm_scroller)
12-09 22:24:17.520+0900 W/W_HOME  (  715): home_navigation.c: _is_rightedge(188) > (720 360) not right edge: 0 0 0x47b83ad0 -> 360 0 0x485a62c0
12-09 22:24:17.520+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,start
12-09 22:24:17.520+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c885c8), locked_x(0)
12-09 22:24:17.520+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c885c8)
12-09 22:24:17.525+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.525+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.530+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.530+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(102) ev->cur.canvas.y(226)
12-09 22:24:17.530+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.530+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.535+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(139) ev->cur.canvas.y(225)
12-09 22:24:17.535+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.535+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c885c8), locked_x(0)
12-09 22:24:17.535+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c885c8)
12-09 22:24:17.535+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.535+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.535+0900 E/EFL     (  789): evas_main<789> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=517548 button=1 downs=1
12-09 22:24:17.535+0900 E/EFL     (  789): evas_main<789> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:24:17.535+0900 E/EFL     (  789): evas_main<789> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:24:17.535+0900 E/EFL     (  789): evas_main<789> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:24:17.540+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.540+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(188) ev->cur.canvas.y(225)
12-09 22:24:17.540+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.545+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c885c8), locked_x(0)
12-09 22:24:17.545+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c885c8)
12-09 22:24:17.545+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.545+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.550+0900 E/EFL     (  789): evas_main<789> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=517587 button=1 downs=0
12-09 22:24:17.555+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), block(2)
12-09 22:24:17.555+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), ev->cur.canvas.x(234) ev->cur.canvas.y(228)
12-09 22:24:17.555+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c885c8), hold(0) freeze(0)
12-09 22:24:17.555+0900 W/WATCH_CORE( 2711): appcore-watch.c: __widget_resume(1012) > widget_resume
12-09 22:24:17.555+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:17.570+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=517635 button=1 downs=0
12-09 22:24:17.570+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c885c8), type(elm_scroller)
12-09 22:24:17.570+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.570+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.580+0900 W/W_HOME  (  715): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
12-09 22:24:17.580+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.580+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.600+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.600+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.615+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.615+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.635+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.635+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.650+0900 W/W_HOME  (  715): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-09 22:24:17.650+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:24:17.650+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.650+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.655+0900 I/GESTURE (  134): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-09 22:24:17.665+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.665+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.685+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-09 22:24:17.685+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-09 22:24:17.705+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-09 22:24:17.710+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c885c8 : elm_scroller] CurrentPage(1)
12-09 22:24:17.840+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
12-09 22:24:18.000+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:18.210+0900 W/W_HOME  (  715): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
12-09 22:24:19.000+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:20.005+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:21.000+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:22.010+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:23.010+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:24.005+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:25.005+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:26.000+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:27.000+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:28.000+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:29.000+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:29.650+0900 E/PKGMGR_SERVER( 3393): pkgmgr-server.c: main(2126) > package manager server start
12-09 22:24:29.725+0900 E/PKGMGR_SERVER( 3393): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_42975421], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-09 22:24:29.730+0900 E/PKGMGR_SERVER( 3395): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-09 22:24:29.735+0900 E/PKGMGR  ( 3391): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-09 22:24:29.805+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:24:29.815+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2711
12-09 22:24:29.815+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 22:24:29.820+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 5
12-09 22:24:29.825+0900 W/AUL_AMD (  534): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(2711), cmd(4)
12-09 22:24:29.825+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 22
12-09 22:24:29.825+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(884) > app status : 4
12-09 22:24:29.825+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:24:29.830+0900 W/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-09 22:24:29.830+0900 W/WATCH_CORE( 2711): appcore-watch.c: __widget_destroy(992) > widget_destory
12-09 22:24:29.830+0900 E/WIDGET_PROVIDER_APP( 2711): client.c: client_fini(1175) > Provider is not initialized
12-09 22:24:29.830+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2711
12-09 22:24:29.830+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 4
12-09 22:24:29.935+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:24:29.995+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-09 22:24:30.035+0900 E/PKGMGR_SERVER( 3395): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-09 22:24:30.070+0900 E/AUL_AMD (  534): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-09 22:24:30.075+0900 W/AUL_AMD (  534): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(2711), cmd(4)
12-09 22:24:30.080+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 0
12-09 22:24:30.105+0900 I/AUL_AMD (  534): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 22:24:30.125+0900 I/AUL_AMD (  534): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 22:24:30.125+0900 E/AUL_AMD (  534): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-09 22:24:30.125+0900 W/AUL_AMD (  534): amd_launch.c: _start_app(1659) > caller pid : 685
12-09 22:24:30.155+0900 E/PKGMGR_SERVER( 3393): pkgmgr-server.c: sighandler(445) > child NORMAL exit [3395]
12-09 22:24:30.265+0900 E/RESOURCED(  535): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 1
12-09 22:24:30.265+0900 E/RESOURCED(  535): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-09 22:24:30.270+0900 W/AUL_AMD (  534): amd_launch.c: _start_app(2026) > pad pid(-5)
12-09 22:24:30.270+0900 W/AUL_PAD ( 1158): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-09 22:24:30.270+0900 W/AUL_PAD ( 1158): launchpad.c: __send_result_to_caller(265) > Check app launching
12-09 22:24:30.310+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: watch_app_main(382) > watch_app_main
12-09 22:24:30.330+0900 E/TBM     ( 2991): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-09 22:24:30.370+0900 I/AUL_AMD (  534): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2711
12-09 22:24:30.415+0900 W/WATCH_CORE( 2991): appcore-watch.c: __widget_create(958) > widget_create
12-09 22:24:30.415+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [37.319309] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_37.319309.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263038:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-09 22:24:30.415+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[37.319309] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_37.319309.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263038:4] gbar_fname[]
12-09 22:24:30.430+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-09 22:24:30.430+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-09 22:24:30.525+0900 W/WATCH_CORE( 2991): appcore-watch.c: __widget_create(976) > widget_create done
12-09 22:24:30.620+0900 I/WATCH_CORE( 2991): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-09 22:24:30.620+0900 I/WATCH_CORE( 2991): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-09 22:24:30.620+0900 I/WATCH_CORE( 2991): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-09 22:24:30.665+0900 W/WATCH_CORE( 2991): appcore-watch.c: __widget_resume(1012) > widget_resume
12-09 22:24:30.695+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:30.995+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-09 22:24:31.000+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:31.005+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-09 22:24:31.020+0900 E/RESOURCED(  535): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 1273
12-09 22:24:31.030+0900 W/ALARM_MANAGER( 1273): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.acom.asamsung.ascsd] : Alarm id [782406002]
12-09 22:24:31.030+0900 W/SNL_W   ( 1273): <on_alarm_event:642> Awake to sendKeepAlive_Alarm() - begin,  mCurrentIntervalSeconds ( 480 )
12-09 22:24:31.030+0900 W/SNL_W   ( 1273): <on_alarm_event:652> sendKeepAlive_alarmthread detached successfully
12-09 22:24:31.030+0900 W/SNL_W   ( 1273): <on_alarm_event:656> sendKeepAlive_alarmthread - end 
12-09 22:24:31.035+0900 W/SNL_W   ( 1273): <sendKeepAliveAllGroup:670> sendKeepAliveAllGroup() - begin
12-09 22:24:31.035+0900 W/SNL     ( 1273): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Call()
12-09 22:24:31.035+0900 W/SNL     ( 1273): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Res( 0 )
12-09 22:24:31.035+0900 W/SNL_W   ( 1273): <util_pm_lock:1125> util_pm_lock() LOCK
12-09 22:24:31.035+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_expired(1325) > alarm_id[782406002] is expired.
12-09 22:24:31.035+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(782406002)
12-09 22:24:31.040+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 22:24:31.040+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 9-12-2015, 13:43:00 (UTC).
12-09 22:24:31.045+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 22:24:31.045+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-09 22:24:31.045+0900 W/SNL_W   ( 1273): <sendKeepAliveAllGroup:706> releaseWakeLockinTimeThread detached successfully
12-09 22:24:31.045+0900 W/SNL_W   ( 1273): <sendKeepAliveAllGroup:719> 0 sendKeepAliveThread detached successfully
12-09 22:24:31.050+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-09 22:24:31.050+0900 W/SNL     ( 1273): Scone_Log.cpp: dump(2972) > SNL :: sKA - group( 7d3831446264732f3e6c2a3e ) mtype( 0 ) timeout( 30000 )
12-09 22:24:31.050+0900 W/SNL     ( 1273): Scone_Log.cpp: dump(2972) > SNL :: sKA
12-09 22:24:31.050+0900 W/SNL     ( 1273): Scone_Log.cpp: dump(2972) > SNL :: send_msg - ( 0xfc ), type( 0x01 ), res( 152 ), seq( 1007 )
12-09 22:24:31.050+0900 W/SNL     ( 1273): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Call()
12-09 22:24:31.050+0900 W/SNL     ( 1273): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Res( 0 )
12-09 22:24:31.050+0900 W/SNL_W   ( 1273): <presSendNotify_i:987> presSendNotify_w ( 7d3831446264732f3e6c2a3e ) - begin
12-09 22:24:31.050+0900 W/SNL_W   ( 1273): <presSendNotify_i:1010> presSendNotify_w ( 7d3831446264732f3e6c2a3e ) - end
12-09 22:24:31.050+0900 W/SNL     ( 1273): Scone_Log.cpp: dump(2972) > SNL :: noti_ps_th - Res( )
12-09 22:24:31.145+0900 W/SNL     ( 1273): Scone_Log.cpp: dump(2972) > SNL :: recv_msg(res) - ( 0xfc ), seq( 1007 )
12-09 22:24:31.145+0900 W/SNL     ( 1273): Scone_Log.cpp: dump(2972) > SNL :: sKA - res( 0 )
12-09 22:24:31.145+0900 W/SNL_W   ( 1273): <sendKeepAliveThread:866> sendKeepAliveAllGroup() - group_id ( 7d3831446264732f3e6c2a3e ) sendKeepAliveType ( 0 ), PING_CNT ( 0 ) 
12-09 22:24:31.145+0900 W/SCSD    ( 1273): <on_presSendNotify:426> sent keepalive (group_id: 7d3831446264732f3e6c2a3e) (S:1/F:0/T:1) (msg_id: 0)
12-09 22:24:31.245+0900 W/SNL_W   ( 1273): <sendKeepAliveAllGroup:731> sendKeepAliveAllgroup() - groupList.size() : 0(f) + 1(p)
12-09 22:24:31.245+0900 W/SNL_W   ( 1273): <setAlarm:520> setAlarm() - begin 
12-09 22:24:31.245+0900 W/SNL_W   ( 1273): <initAlarm:505> InitAlarm() - begin
12-09 22:24:31.245+0900 W/SNL_W   ( 1273): <initAlarm:511> InitAlarm() success - end
12-09 22:24:31.255+0900 I/AUL     ( 1273): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 22:24:31.260+0900 I/AUL     ( 1273): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 22:24:31.260+0900 W/ALARM_MANAGER( 1273): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(715), start(9-12-2015, 22:36:26), repeat(0), interval(0), type(-1073741822)
12-09 22:24:31.275+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 22:24:31.285+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 22:24:31.295+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 22:24:31.300+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 22:24:31.310+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 22:24:31.320+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 22:24:31.320+0900 W/ALARM_MANAGER(  526): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1449668186, Wed Dec  9 22:36:26 2015
12-09 22:24:31.320+0900 W/ALARM_MANAGER(  526): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 202474152, next duetime: 1449668186
12-09 22:24:31.320+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(202474152)
12-09 22:24:31.320+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449668580), due_time(1449668186)
12-09 22:24:31.320+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 22:24:31.320+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 9-12-2015, 13:36:26 (UTC).
12-09 22:24:31.320+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 22:24:31.325+0900 W/SNL_W   ( 1273): <setAlarm:569> setAlarm() - end : mStatus ( 1 ) currentInterval( 720 ) interruptFlag ( 0 ) alarm_id ( 202474152 )
12-09 22:24:31.325+0900 W/SNL_W   ( 1273): <sendKeepAliveAllGroup:750> sendKeepAliveAllGroup() - set last interval ( 480 )
12-09 22:24:31.325+0900 W/SNL_W   ( 1273): <util_pm_unlock:1147> util_pm_unlock() UNLOCK
12-09 22:24:31.330+0900 W/SNL_W   ( 1273): <sendKeepAliveAllGroup:756> sendKeepAliveAllGroup () - WakeLock release
12-09 22:24:31.330+0900 W/SNL_W   ( 1273): <sendKeepAliveAllGroup:768> sendKeepAliveAllGroup() - end Error ( 0 )
12-09 22:24:31.350+0900 W/SNL_W   ( 1273): <releaseWakeLockinTimeThread:813> releaseWakeLockinTimeThread () - WakeLock already released
12-09 22:24:31.375+0900 W/AUL_AMD (  534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 22:24:31.375+0900 W/AUL_AMD (  534): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-09 22:24:31.385+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:24:31.390+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2991
12-09 22:24:31.395+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 22:24:31.590+0900 I/AUL_PAD ( 3426): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-09 22:24:31.825+0900 W/AUL_AMD (  534): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-09 22:24:31.930+0900 E/PKGMGR_SERVER( 3393): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-09 22:24:31.930+0900 E/PKGMGR_SERVER( 3393): pkgmgr-server.c: main(2180) > package manager server terminated.
12-09 22:24:32.000+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:33.000+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:34.000+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:34.450+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 1 -> 2
12-09 22:24:34.450+0900 E/WMS     (  529): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-09 22:24:34.450+0900 E/WMS     (  529): ==========
12-09 22:24:34.450+0900 E/WMS     (  529): ##WMS SEND : mgr_gear_wear_onoff_req
12-09 22:24:34.450+0900 E/WMS     (  529): ==========
12-09 22:24:34.455+0900 E/WMS     (  529): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-09 22:24:34.500+0900 W/SCSD    ( 1273): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
12-09 22:24:34.500+0900 W/SCSD    ( 1273): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
12-09 22:24:34.500+0900 W/SCSD    ( 1273): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
12-09 22:24:34.515+0900 W/SCSD    ( 1273): <util_scs_send:975> sent [63 / 63] bytes. 
12-09 22:24:34.520+0900 W/SHealth_Service( 1065): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
12-09 22:24:34.525+0900 E/SHealth_Service( 1065): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-09 22:24:35.000+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:36.005+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:37.005+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:38.005+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:39.000+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:40.005+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:40.940+0900 E/PKGMGR  ( 3569): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-09 22:24:41.000+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:41.110+0900 E/PKGMGR_SERVER( 3571): pkgmgr-server.c: main(2126) > package manager server start
12-09 22:24:41.180+0900 E/PKGMGR_SERVER( 3571): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_54443460], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_54443460' '-r' 'org.reolab.blackandwhite'], cookie=[trWmaMhaB9aYcYLhRFXVE43pvqw=], backend_flag=[0]
12-09 22:24:41.185+0900 E/PKGMGR  ( 3571): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-09 22:24:41.185+0900 E/PKGMGR_SERVER( 3571): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-09 22:24:41.190+0900 E/PKGMGR_SERVER( 3572): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-09 22:24:41.190+0900 E/PKGMGR  ( 3569): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[35690002]
12-09 22:24:41.365+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-09 22:24:41.375+0900 W/AUL_AMD (  534): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-09 22:24:41.390+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 22:24:41.400+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-09 22:24:41.970+0900 E/PKGMGR_CERT( 3572): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-09 22:24:41.980+0900 E/PKGMGR_CERT( 3572): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-09 22:24:41.980+0900 E/PKGMGR_CERT( 3572): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-09 22:24:41.980+0900 E/PKGMGR_CERT( 3572): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-09 22:24:41.980+0900 E/PKGMGR_CERT( 3572): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-09 22:24:41.985+0900 E/PKGMGR_CERT( 3572): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-09 22:24:41.985+0900 E/PKGMGR_CERT( 3572): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-09 22:24:41.995+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 22:24:42.000+0900 I/CAPI_WATCH_APPLICATION( 2991): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:24:42.005+0900 E/PKGMGR_CERT( 3572): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-09 22:24:42.295+0900 W/CRASH_MANAGER( 3575): worker.c: worker_job(1199) > 1102991626c61144966748
