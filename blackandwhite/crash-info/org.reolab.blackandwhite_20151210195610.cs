S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 1206
Date: 2015-12-10 19:56:10+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1f1c

Register Information
r0   = 0x00001f10, r1   = 0x0000000d
r2   = 0x00001d90, r3   = 0x41453194
r4   = 0x00001f10, r5   = 0x00000000
r6   = 0x41983cf4, r7   = 0x4195ce08
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeda9c54, sp   = 0xbeda9c08
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     15088 KB
Buffers:     15584 KB
Cached:     183656 KB
VmPeak:     111688 KB
VmSize:     111176 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16088 KB
VmRSS:       16088 KB
VmData:      54648 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 1206 TID = 1206
1206 1848 1856 

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
41819000 4181f000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41827000 4182d000 r-xp /usr/lib/libwidget.so.1.0.0
41836000 4183b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41843000 4185c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41865000 4186b000 rw-p [heap]
4186b000 4199d000 rw-p [heap]
4199d000 41ada000 r-xp /usr/lib/libicui18n.so.51.1
41aea000 41bce000 r-xp /usr/lib/libicuuc.so.51.1
41be3000 41c1a000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
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
4378f000 43f8e000 rw-p [stack:1848]
43f8e000 43f91000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f99000 43fa4000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4402c000 44043000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44283000 44a82000 rw-p [stack:1856]
44a82000 44a84000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
bed8a000 bedab000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1206)
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
y
12-10 19:52:59.910+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-10 19:52:59.910+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 19:52:59.915+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 19:52:59.915+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 19:52:59.915+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 19:52:59.915+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 19:52:59.915+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 19:52:59.915+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 19:52:59.915+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-10 19:52:59.915+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 19:52:59.915+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 19:52:59.915+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 19:52:59.915+0900 E/CAPI_APPFW_APP_CONTROL(  880): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-10 19:52:59.915+0900 W/MUSIC_CONTROL_SERVICE(  880): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:880]   value = [false][0m
12-10 19:52:59.920+0900 I/GESTURE (  141): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-10 19:53:00.000+0900 I/CAPI_WATCH_APPLICATION( 1129): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 19:53:00.035+0900 I/CAPI_NETWORK_WIFI( 1129): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 19:53:00.050+0900 I/CAPI_NETWORK_WIFI( 1129): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 19:53:00.115+0900 W/WATCH_CORE( 1129): appcore-watch.c: __widget_pause(1001) > widget_pause
12-10 19:55:00.544+0900 I/CAPI_APPFW_APPLICATION( 1207): service_app_main.c: service_app_exit(441) > service_app_exit
12-10 19:55:00.559+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 22
12-10 19:55:00.559+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(884) > app status : 4
12-10 19:55:00.564+0900 I/SkmsAgent( 1207): info: SKMSA application terminated
12-10 19:55:00.634+0900 I/SHealth_Service( 1072): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(628) > [1;35mlength of Array [1][0;m
12-10 19:55:00.644+0900 E/SHealth_Common( 1072): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 19:55:00.729+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 19:55:00.729+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 19:55:00.729+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 19:55:00.729+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 19:55:00.734+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 19:55:00.734+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 19:55:00.734+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 19:55:00.734+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 19:55:00.734+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 19:55:00.734+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 19:55:00.734+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 19:55:00.734+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 19:55:00.739+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 19:55:00.739+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 19:55:00.739+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 19:55:00.739+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 19:55:00.739+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 19:55:00.739+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 19:55:00.739+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 19:55:00.739+0900 E/TIZEN_N_SYSTEM_SETTINGS(  788): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 19:55:00.739+0900 I/CAPI_WIDGET_APPLICATION(  788): widget_app.c: __provider_update_cb(279) > received updating signal
12-10 19:55:00.764+0900 W/SHealth_Common( 1072): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
12-10 19:55:00.769+0900 I/APP_CORE(  716): appcore-efl.c: __do_app(429) > [APP 716] Event: MEM_FLUSH State: PAUSED
12-10 19:55:00.799+0900 W/SHealth_Common( 1072): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
12-10 19:55:00.829+0900 I/CAPI_WIDGET_APPLICATION(  788): widget_app.c: __provider_update_cb(279) > received updating signal
12-10 19:55:00.834+0900 I/HealthDataService(  804): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
12-10 19:55:00.849+0900 I/healthData( 1072): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
12-10 19:55:00.849+0900 E/SHealth_Common( 1072): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 19:55:10.745+0900 E/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
12-10 19:55:10.745+0900 E/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(1207) are closed. delete client info
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
12-10 19:55:10.745+0900 E/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  1207
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: UnregisterMessagePortByDiscon(280) > _MessagePortService::UnregisterMessagePortByDiscon
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.745+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:10.805+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 23
12-10 19:55:10.805+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-10 19:55:10.805+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 1207
12-10 19:55:10.805+0900 W/AUL_AMD (  475): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-10 19:55:10.815+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1207
12-10 19:55:13.150+0900 I/APP_CORE(  716): appcore-efl.c: __do_app(429) > [APP 716] Event: MEM_FLUSH State: PAUSED
12-10 19:55:19.670+0900 E/AUL_AMD (  475): amd_main.c: __platform_ready_handler(370) > [Info]__platform_ready_handler
12-10 19:55:20.965+0900 E/W-CONTACTS2-CONSUMER( 1187): ct-sap-svc-client.c: __ct_sap_svc_client_exit_consumer(691) > [0;31m* Critical * Total allocated space (uordblks):248480
12-10 19:55:20.965+0900 E/W-CONTACTS2-CONSUMER( 1187): [0;m
12-10 19:55:20.970+0900 I/CAPI_APPFW_APPLICATION( 1187): service_app_main.c: service_app_exit(441) > service_app_exit
12-10 19:55:20.975+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 22
12-10 19:55:20.980+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(884) > app status : 4
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 19:55:21.370+0900 E/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
12-10 19:55:21.370+0900 E/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(1187) are closed. delete client info
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
12-10 19:55:21.370+0900 E/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  1187
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: UnregisterMessagePortByDiscon(280) > _MessagePortService::UnregisterMessagePortByDiscon
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.370+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-10 19:55:21.605+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 23
12-10 19:55:21.605+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-10 19:55:21.605+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 1187
12-10 19:55:21.605+0900 W/AUL_AMD (  475): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-10 19:55:21.615+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1187
12-10 19:55:22.985+0900 W/AUL_AMD (  475): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-10 19:55:35.520+0900 E/PKGMGR_SERVER( 1845): pkgmgr-server.c: main(2126) > package manager server start
12-10 19:55:35.610+0900 E/PKGMGR_SERVER( 1845): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_199442919], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-10 19:55:35.610+0900 E/PKGMGR_SERVER( 1847): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-10 19:55:35.665+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:35.675+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1129
12-10 19:55:35.675+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 19:55:35.680+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 5
12-10 19:55:35.685+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(1129), cmd(4)
12-10 19:55:35.685+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 22
12-10 19:55:35.685+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(884) > app status : 4
12-10 19:55:35.685+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:35.685+0900 W/CAPI_WATCH_APPLICATION( 1129): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-10 19:55:35.685+0900 W/WATCH_CORE( 1129): appcore-watch.c: __widget_destroy(992) > widget_destory
12-10 19:55:35.685+0900 E/WIDGET_PROVIDER_APP( 1129): client.c: client_fini(1175) > Provider is not initialized
12-10 19:55:35.695+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1129
12-10 19:55:35.695+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-10 19:55:35.700+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(1129), cmd(4)
12-10 19:55:35.700+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-10 19:55:35.715+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 19:55:35.725+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 19:55:35.725+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-10 19:55:35.725+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 705
12-10 19:55:35.735+0900 E/RESOURCED(  477): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-10 19:55:35.735+0900 E/RESOURCED(  477): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-10 19:55:35.740+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-10 19:55:35.740+0900 W/AUL_PAD ( 1120): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-10 19:55:35.740+0900 W/AUL_PAD ( 1120): launchpad.c: __send_result_to_caller(265) > Check app launching
12-10 19:55:35.790+0900 I/CAPI_WATCH_APPLICATION( 1206): watch_app_main.c: watch_app_main(382) > watch_app_main
12-10 19:55:35.815+0900 E/TBM     ( 1206): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-10 19:55:35.860+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:35.865+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:35.870+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 23
12-10 19:55:35.870+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-10 19:55:35.870+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 1129
12-10 19:55:35.870+0900 W/AUL_AMD (  475): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-10 19:55:35.870+0900 E/AUL     ( 1849): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
12-10 19:55:35.870+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1129
12-10 19:55:35.920+0900 W/WATCH_CORE( 1206): appcore-watch.c: __widget_create(958) > widget_create
12-10 19:55:35.920+0900 E/WIDGET_VIEWER(  716): client.c: master_created(1712) > [SECURE_LOG] [40.194832] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_716_40.194832.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263014:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-10 19:55:35.920+0900 E/WIDGET_VIEWER(  716): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[40.194832] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_716_40.194832.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263014:4] gbar_fname[]
12-10 19:55:35.935+0900 E/WIDGET_VIEWER(  716): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-10 19:55:35.935+0900 E/WIDGET_EVAS(  716): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-10 19:55:35.970+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:35.975+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:36.075+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:36.085+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:36.135+0900 I/CAPI_NETWORK_WIFI( 1206): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 19:55:36.145+0900 I/CAPI_NETWORK_WIFI( 1206): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 19:55:36.185+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:36.190+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:36.250+0900 W/WATCH_CORE( 1206): appcore-watch.c: __widget_create(976) > widget_create done
12-10 19:55:36.290+0900 I/WATCH_CORE( 1206): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-10 19:55:36.290+0900 I/WATCH_CORE( 1206): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-10 19:55:36.290+0900 I/WATCH_CORE( 1206): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-10 19:55:36.290+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:36.300+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:36.400+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:36.405+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:36.510+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:36.515+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:36.615+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:36.620+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:36.725+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:36.725+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:36.830+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:36.835+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:36.860+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-10 19:55:36.860+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-10 19:55:36.875+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:36.885+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:36.885+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 19:55:36.935+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:36.940+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:37.045+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:37.050+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:37.080+0900 I/AUL_PAD ( 1861): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-10 19:55:37.155+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:37.160+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:37.260+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:37.275+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:37.380+0900 E/PKGMGR_SERVER( 1845): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 19:55:37.415+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:37.485+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:37.590+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:37.685+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:37.685+0900 W/AUL_AMD (  475): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-10 19:55:37.795+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:37.880+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:37.990+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:38.050+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:38.160+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:38.235+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:38.340+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:38.415+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:38.525+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:38.605+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:38.720+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:38.790+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:38.895+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:38.975+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:39.080+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:39.155+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:39.265+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:39.335+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:39.380+0900 E/PKGMGR_SERVER( 1845): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 19:55:39.440+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:39.515+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:39.630+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:39.725+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:39.830+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:39.855+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:39.965+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:40.040+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:40.150+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:40.225+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:40.330+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:40.410+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:40.515+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:40.590+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:40.700+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:40.775+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:40.890+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:40.950+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:41.060+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:41.140+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:41.245+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:41.315+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:41.385+0900 E/PKGMGR_SERVER( 1845): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 19:55:41.420+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:41.480+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:41.585+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:41.665+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:41.775+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:41.845+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:41.950+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:42.025+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:42.135+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:42.220+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:42.335+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:42.415+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:42.525+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:42.590+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:42.695+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:42.770+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:42.880+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:42.975+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:43.080+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:43.155+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:43.265+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:43.345+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:43.380+0900 E/PKGMGR_SERVER( 1845): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 19:55:43.455+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:43.530+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:43.640+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 19:55:43.700+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1206
12-10 19:55:43.860+0900 E/PKGMGR_SERVER( 1847): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-10 19:55:43.895+0900 E/PKGMGR  ( 1839): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-10 19:55:44.030+0900 I/RESOURCED(  477): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 19:55:44.030+0900 I/RESOURCED(  477): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 19:55:44.055+0900 E/PKGMGR_SERVER( 1845): pkgmgr-server.c: sighandler(445) > child NORMAL exit [1847]
12-10 19:55:45.380+0900 E/PKGMGR_SERVER( 1845): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-10 19:55:45.380+0900 E/PKGMGR_SERVER( 1845): pkgmgr-server.c: main(2180) > package manager server terminated.
12-10 19:55:53.865+0900 I/DOWNLOAD_PROVIDER(  834): download-provider-client-manager.c: dp_client_manager(738) > client-manager's working is done
12-10 19:55:53.870+0900 W/WIFI_DIRECT_MANAGER( 1049): wifi-direct-client.c: wfd_client_process_request(869) > Client request [3:WIFI_DIRECT_CMD_DEREGISTER], 28 bytes read from socket[6]
12-10 19:55:53.880+0900 E/WIFI_DIRECT(  834): wifi-direct-client-proxy.c: __wfd_client_check_socket(530) > Error! POLLHUP from socket[8]
12-10 19:55:53.880+0900 E/WIFI_DIRECT(  834): wifi-direct-client-proxy.c: __wfd_client_read_socket(590) > Socket error
12-10 19:55:53.880+0900 E/WIFI_DIRECT(  834): wifi-direct-client-proxy.c: __wfd_client_send_request(639) > Failed to read socket [-29753342]
12-10 19:55:54.040+0900 I/CAPI_NETWORK_CONNECTION(  834): connection.c: __connection_set_type_changed_callback(163) > Successfully de-registered(0)
12-10 19:55:54.220+0900 I/CAPI_NETWORK_CONNECTION(  834): connection.c: __connection_set_ip_changed_callback(248) > Successfully de-registered(0)
12-10 19:55:54.250+0900 I/CAPI_NETWORK_CONNECTION(  834): connection.c: connection_destroy(390) > Destroy handle: 0x42e00650
12-10 19:55:54.260+0900 I/DOWNLOAD_PROVIDER(  834): download-provider-main.c: main(64) > download-provider's working is done
12-10 19:55:56.370+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-connection-mgr.c: __on_receive(523) >  Enter
12-10 19:55:56.370+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-connection-mgr.c: __on_receive(525) >  on receive called. payloadLength(852)
12-10 19:55:56.375+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-sap-msg-handler.c: _handle_sap_msg(142) >  Enter
12-10 19:55:56.375+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1924) >  Enter
12-10 19:55:56.375+0900 W/WEMAIL_CONSUMER( 1209): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1943) >  > Received message id: (email-init-req)
12-10 19:55:56.375+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer.c: _get_is_ack_support(216) >  Enter
12-10 19:55:56.375+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer.c: _get_is_ack_support(217) >  Leave
12-10 19:55:56.390+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-connection-mgr.c: _send_sap_msg(265) >  Success sending message
12-10 19:55:56.395+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(1981) >  success to send : seqId(8)
12-10 19:55:56.395+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-sap-msg-handler.c: __parse_init_req_ind(1141) >  Enter
12-10 19:55:56.395+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-db.c: _db_check_account_data_by_account_id(1506) >  Leave
12-10 19:55:56.400+0900 I/WEMAIL_COMMON( 1209): wemail-ipc-msg.c: wemail_ipc_serialize_op_data(609) >  Enter
12-10 19:55:56.405+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-db.c: _db_update_account_data(1592) >  Leave
12-10 19:55:56.410+0900 I/WEMAIL_COMMON( 1209): wemail-ipc-msg.c: wemail_ipc_serialize_op_data(609) >  Enter
12-10 19:55:56.410+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer.c: _set_is_ack_support(208) >  Enter
12-10 19:55:56.410+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer.c: _set_is_ack_support(209) >  ack support: 1
12-10 19:55:56.410+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer.c: _set_is_ack_support(211) >  Leave
12-10 19:55:56.410+0900 I/WEMAIL_COMMON( 1209): wemail-util.c: wemail_util_get_is_network_connection_available(637) >  Enter
12-10 19:55:56.420+0900 I/WECONN  (  515): technology.c: __get_state(83) > W_SERVICE_TYPE_BT
12-10 19:55:56.425+0900 I/WEMAIL_COMMON( 1209): wemail-util.c: wemail_util_get_is_network_connection_available(654) >  network connection state:[17:3]
12-10 19:55:56.425+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-db.c: _db_get_changelog_data_list(1745) >  Leave
12-10 19:55:56.430+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-sap-msg-handler.c: __parse_init_req_ind(1213) >  Leave
12-10 19:55:56.430+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-sap-msg-handler.c: __do_parse_received_msg(2060) >  Leave
12-10 19:55:56.430+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-sap-msg-handler.c: _handle_sap_msg(228) >  Leave
12-10 19:55:56.430+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer.c: _refresh_memory_trim_timer(131) >  Enter
12-10 19:55:56.430+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer.c: _can_be_killed_consumer(450) >  Enter
12-10 19:55:56.430+0900 I/WEMAIL_COMMON( 1209): wemail-util.c: wemail_util_get_app_status(1128) >  Enter
12-10 19:55:56.430+0900 W/WEMAIL_COMMON( 1209): wemail-util.c: wemail_util_get_app_status(1134) >  app foreground status: [0]
12-10 19:55:56.430+0900 I/WEMAIL_COMMON( 1209): wemail-util.c: wemail_util_get_app_status(1144) >  Leave
12-10 19:55:56.430+0900 W/WEMAIL_COMMON( 1209): wemail-util.c: wemail_util_get_is_noti_existing(1167) >  Email notification status: [0]
12-10 19:55:56.430+0900 W/WEMAIL_CONSUMER( 1209): wemail-consumer.c: _can_be_killed_consumer(472) >  consumer can be killed: [1]
12-10 19:55:56.430+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer.c: _can_be_killed_consumer(473) >  Leave
12-10 19:55:56.430+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer.c: _refresh_kill_timer(141) >  Enter
12-10 19:55:56.430+0900 W/WEMAIL_CONSUMER( 1209): wemail-consumer.c: _refresh_kill_timer(142) >  REFRESH kill timer!
12-10 19:55:56.430+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer-connection-mgr.c: __on_receive(535) >  Leave
12-10 19:55:58.065+0900 W/WG-CONSUMER( 1189): [32m[F:SAPProxy.cpp     L:  620][_WARN][Phone->Gear] Got Disconnect. uwServiceHandle(1) wStatusCode(0)[0m
12-10 19:55:58.065+0900 W/WG-CONSUMER( 1189): [32m[F:ConnectionInfo.c L: 1238][_WARN][TX][Phone->Gear] Got Disconnect. uwServiceHandle(1) wStatusCode(0)[0m
12-10 19:55:58.070+0900 W/WG-CONSUMER( 1189): [32m[F:ConnectionInfo.c L: 1239][_WARN][TX]Connection Info. AgentID(41540) ServiceHandle(1) CurrentState=SM_STATE_ESTABLISHED[0m
12-10 19:55:58.070+0900 W/WG-CONSUMER( 1189): [34m[F:PeerList.cpp     L:  171][_HIGH][TX]Clear PeerList. Count=1 pConnected=0x42eafca8[0m
12-10 19:55:58.070+0900 W/WG-CONSUMER( 1189): [34m[F:PeerList.cpp     L:  103][_HIGH][TX]This=0x42eafca8 PeerAgent(0x42eafcac) bSet(1)[0m
12-10 19:55:58.075+0900 W/WG-CONSUMER( 1189): [34m[F:PeerList.cpp     L:  104][_HIGH][TX]  DeviceID=1 PeerAgentID=49677 ServiceHandle=1[0m
12-10 19:55:58.075+0900 W/WG-CONSUMER( 1189): [34m[F:PeerList.cpp     L:  106][_HIGH][TX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=2.1[0m
12-10 19:55:58.075+0900 W/WG-CONSUMER( 1189): [34m[F:PeerList.cpp     L:  107][_HIGH][TX]  ConnectType(1) : BT|[0m
12-10 19:55:58.080+0900 W/WG-CONSUMER( 1189): [34m[F:ConnectionInfo.c L:  618][_HIGH][TX]State changed: SM_STATE_ESTABLISHED->SM_STATE_REGISTER_AGENT[0m
12-10 19:55:58.080+0900 W/WG-CONSUMER( 1189): [34m[F:TransferCtrl.cpp L:  210][_HIGH]CTransferCtrl::OnTerminated. Cause=TERMINATION_FROM_PEER[0m
12-10 19:55:58.085+0900 W/WG-CONSUMER( 1189): [34m[F:TransferCtrl.cpp L:  218][_HIGH]Malloc Trimmed[0m
12-10 19:55:58.175+0900 W/WG-CONSUMER( 1189): [32m[F:SAPProxy.cpp     L:  620][_WARN][Phone->Gear] Got Disconnect. uwServiceHandle(2) wStatusCode(0)[0m
12-10 19:55:58.175+0900 W/WG-CONSUMER( 1189): [32m[F:ConnectionInfo.c L: 1238][_WARN][RX][Phone->Gear] Got Disconnect. uwServiceHandle(2) wStatusCode(0)[0m
12-10 19:55:58.180+0900 W/WG-CONSUMER( 1189): [32m[F:ConnectionInfo.c L: 1239][_WARN][RX]Connection Info. AgentID(41541) ServiceHandle(2) CurrentState=SM_STATE_ESTABLISHED[0m
12-10 19:55:58.180+0900 W/WG-CONSUMER( 1189): [34m[F:PeerList.cpp     L:  171][_HIGH][RX]Clear PeerList. Count=1 pConnected=0x42eb8f78[0m
12-10 19:55:58.195+0900 W/WG-CONSUMER( 1189): [34m[F:PeerList.cpp     L:  103][_HIGH][RX]This=0x42eb8f78 PeerAgent(0x42eb8f7c) bSet(1)[0m
12-10 19:55:58.200+0900 W/WG-CONSUMER( 1189): [34m[F:PeerList.cpp     L:  104][_HIGH][RX]  DeviceID=1 PeerAgentID=23056 ServiceHandle=2[0m
12-10 19:55:58.205+0900 W/WG-CONSUMER( 1189): [34m[F:PeerList.cpp     L:  106][_HIGH][RX]  DeviceName=* MAC=* ALE=HostManager ASPID=* Version=3.0[0m
12-10 19:55:58.205+0900 W/WG-CONSUMER( 1189): [34m[F:PeerList.cpp     L:  107][_HIGH][RX]  ConnectType(1) : BT|[0m
12-10 19:55:58.210+0900 W/WG-CONSUMER( 1189): [34m[F:ConnectionInfo.c L:  618][_HIGH][RX]State changed: SM_STATE_ESTABLISHED->SM_STATE_REGISTER_AGENT[0m
12-10 19:55:58.220+0900 W/WG-CONSUMER( 1189): [34m[F:ReceiverCtrl.cpp L:  460][_HIGH]CReceiverCtrl::OnTerminated. Cause=TERMINATION_FROM_PEER[0m
12-10 19:56:03.150+0900 E/PKGMGR  ( 2005): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-10 19:56:03.335+0900 E/PKGMGR_SERVER( 2007): pkgmgr-server.c: main(2126) > package manager server start
12-10 19:56:03.420+0900 E/PKGMGR_SERVER( 2007): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_227246462], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_227246462' '-r' 'org.reolab.blackandwhite'], cookie=[WWCZwoA9Qne9Wku0W9TsJolVLZQ=], backend_flag=[0]
12-10 19:56:03.425+0900 E/PKGMGR  ( 2007): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-10 19:56:03.425+0900 E/PKGMGR_SERVER( 2007): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-10 19:56:03.425+0900 E/PKGMGR  ( 2005): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[20050002]
12-10 19:56:03.430+0900 E/PKGMGR_SERVER( 2008): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-10 19:56:03.615+0900 E/WMS     (  473): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-10 19:56:03.620+0900 W/AUL_AMD (  475): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-10 19:56:03.635+0900 E/WMS     (  473): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 19:56:03.675+0900 W/W_HOME  (  716): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-10 19:56:04.380+0900 E/PKGMGR_CERT( 2008): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-10 19:56:04.390+0900 E/PKGMGR_CERT( 2008): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 93
12-10 19:56:04.395+0900 E/PKGMGR_CERT( 2008): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 93
12-10 19:56:04.395+0900 E/PKGMGR_CERT( 2008): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-10 19:56:04.395+0900 E/PKGMGR_CERT( 2008): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-10 19:56:04.400+0900 E/PKGMGR_CERT( 2008): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-10 19:56:04.400+0900 E/PKGMGR_CERT( 2008): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-10 19:56:04.400+0900 E/WMS     (  473): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 19:56:04.420+0900 E/PKGMGR_CERT( 2008): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-10 19:56:05.380+0900 E/PKGMGR_SERVER( 2007): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 19:56:06.325+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer.c: __memory_trim_timer_cb(223) >  Enter
12-10 19:56:06.325+0900 I/WEMAIL_CONSUMER( 1209): wemail-consumer.c: __memory_trim_timer_cb(246) >  Leave
12-10 19:56:06.625+0900 E/rpm-installer( 2008): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-10 19:56:07.380+0900 E/PKGMGR_SERVER( 2007): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 19:56:09.380+0900 E/PKGMGR_SERVER( 2007): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 19:56:10.175+0900 E/PKGMGR_SERVER( 2007): pkgmgr-server.c: sighandler(445) > child NORMAL exit [2008]
12-10 19:56:10.185+0900 E/WMS     (  473): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 19:56:10.220+0900 W/W_HOME  (  716): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-10 19:56:10.220+0900 W/W_HOME  (  716): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-10 19:56:10.230+0900 E/WMS     (  473): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-10 19:56:10.230+0900 E/WMS     (  473): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-10 19:56:10.230+0900 E/WMS     (  473): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-10 19:56:10.230+0900 E/WMS     (  473): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-10 19:56:10.250+0900 W/W_HOME  (  716): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-10 19:56:10.290+0900 E/APPS    (  716): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-10 19:56:10.410+0900 E/PKGMGR_INFO(  472): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-10 19:56:10.695+0900 W/CRASH_MANAGER( 2013): worker.c: worker_job(1199) > 1101206626c61144974497
