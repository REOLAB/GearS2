S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 6046
Date: 2015-12-10 22:04:06+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x323026fa

Register Information
r0   = 0x323026ee, r1   = 0x0000000d
r2   = 0x3230253e, r3   = 0x41553194
r4   = 0x323026ee, r5   = 0x00000000
r6   = 0x414e922c, r7   = 0x414dd608
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbe9dcc54, sp   = 0xbe9dcc08
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   490336 KB
MemFree:     23500 KB
Buffers:     23724 KB
Cached:     148968 KB
VmPeak:     111464 KB
VmSize:     110952 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15972 KB
VmRSS:       15972 KB
VmData:      54424 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6046 TID = 6046
6046 6357 6368 

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
41553000 41556000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
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
43757000 43f56000 rw-p [stack:6357]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45255000 45b00000 rw-p [stack:6368]
be9bd000 be9de000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6046)
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
286) >  Enter
12-10 21:53:57.435+0900 I/WEMAIL_CONSUMER( 6010): wemail-consumer.c: _consumer_deinit(125) >  Leave
12-10 21:53:57.435+0900 I/WEMAIL_CONSUMER( 6010): main.c: __service_app_terminate(44) >  Leave
12-10 21:53:57.640+0900 I/efl-extension( 6010): efl_extension.c: eext_mod_shutdown(46) > Shutdown
12-10 21:53:58.105+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 23
12-10 21:53:58.105+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-10 21:53:58.105+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 6010
12-10 21:53:58.105+0900 W/AUL_AMD (  454): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-10 21:53:58.115+0900 I/AUL_AMD (  454): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 6010
12-10 21:53:59.280+0900 W/AUL_AMD (  454): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-10 21:54:07.210+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 21:54:15.585+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 21:54:15.585+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 21:55:01.135+0900 I/SHealth_Service( 1068): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(628) > [1;35mlength of Array [1][0;m
12-10 21:55:01.165+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 21:55:01.240+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 21:55:01.240+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 21:55:01.240+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 21:55:01.240+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 21:55:01.250+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 21:55:01.250+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 21:55:01.250+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 21:55:01.250+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 21:55:01.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 21:55:01.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 21:55:01.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 21:55:01.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 21:55:01.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 21:55:01.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 21:55:01.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 21:55:01.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 21:55:01.260+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-10 21:55:01.260+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-10 21:55:01.260+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-10 21:55:01.260+0900 E/TIZEN_N_SYSTEM_SETTINGS(  784): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-10 21:55:01.260+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
12-10 21:55:01.285+0900 W/SHealth_Common( 1068): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
12-10 21:55:01.315+0900 W/SHealth_Common( 1068): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
12-10 21:55:01.345+0900 I/CAPI_WIDGET_APPLICATION(  784): widget_app.c: __provider_update_cb(279) > received updating signal
12-10 21:55:01.350+0900 I/HealthDataService(  792): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
12-10 21:55:01.365+0900 I/healthData( 1068): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
12-10 21:55:07.215+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 21:55:15.584+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 21:55:15.584+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 21:55:15.584+0900 I/RESOURCED(  464): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-10 21:56:05.530+0900 W/SHealth_Service( 1068): HostProxy.cpp: SAPNotiOnServiceTerminationIndication(122) > [1;40;33mcurrent status [0][0;m
12-10 21:56:05.530+0900 E/SHealth_Service( 1068): HostProxy.cpp: SAPNotiOnServiceTerminationIndication(126) > [0;40;31mCONNECTION_LOST_PEER_DISCONNECTED[0;m
12-10 21:56:05.535+0900 I/SHealth_Service( 1068): HostProxy.cpp: Reset(651) > [1;35mReset Connection[0;m
12-10 21:56:05.550+0900 E/SHealth_Service( 1068): HostProxy.cpp: WatchSAPConnection(739) > [0;40;31mFailed vconf_ignore_key_changed [-1][0;m
12-10 21:56:07.210+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 21:56:15.575+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 21:56:15.575+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 21:57:07.225+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 21:57:15.630+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 21:57:15.630+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 21:58:07.225+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 21:58:15.630+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 21:58:15.630+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 21:59:07.224+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 21:59:15.629+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 21:59:15.629+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 22:00:07.225+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 22:00:15.630+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 22:00:15.630+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 22:00:15.630+0900 I/RESOURCED(  464): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] cpu cache is empty
12-10 22:01:07.225+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 22:01:15.629+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 22:01:15.629+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 22:01:15.629+0900 I/RESOURCED(  464): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-10 22:02:04.204+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 1 -> 2
12-10 22:02:04.204+0900 E/WMS     (  462): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-10 22:02:04.204+0900 E/WMS     (  462): ==========
12-10 22:02:04.204+0900 E/WMS     (  462): ##WMS SEND : mgr_gear_wear_onoff_req
12-10 22:02:04.204+0900 E/WMS     (  462): ==========
12-10 22:02:04.209+0900 E/WMS     (  462): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-10 22:02:07.230+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 22:02:15.579+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 22:02:15.579+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 22:03:07.224+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 22:03:15.635+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 22:03:15.635+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 22:03:48.195+0900 E/PKGMGR_SERVER( 6344): pkgmgr-server.c: main(2126) > package manager server start
12-10 22:03:48.310+0900 E/PKGMGR_SERVER( 6344): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-697858179], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-10 22:03:48.315+0900 E/PKGMGR_SERVER( 6345): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-10 22:03:48.320+0900 E/PKGMGR  ( 6342): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-10 22:03:48.385+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:03:48.390+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5998
12-10 22:03:48.395+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 22:03:48.400+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 5
12-10 22:03:48.405+0900 W/CAPI_WATCH_APPLICATION( 5998): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-10 22:03:48.405+0900 W/WATCH_CORE( 5998): appcore-watch.c: __widget_destroy(992) > widget_destory
12-10 22:03:48.405+0900 E/WIDGET_PROVIDER_APP( 5998): client.c: client_fini(1175) > Provider is not initialized
12-10 22:03:48.405+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 22
12-10 22:03:48.405+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(884) > app status : 4
12-10 22:03:48.405+0900 W/AUL_AMD (  454): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(5998), cmd(4)
12-10 22:03:48.405+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:03:48.415+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5998
12-10 22:03:48.415+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 4
12-10 22:03:48.525+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:03:48.600+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-10 22:03:48.670+0900 E/AUL_AMD (  454): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-10 22:03:48.670+0900 W/AUL_AMD (  454): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(5998), cmd(4)
12-10 22:03:48.685+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 0
12-10 22:03:48.815+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 22:03:48.930+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 22:03:48.935+0900 E/AUL_AMD (  454): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-10 22:03:48.935+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(1659) > caller pid : 707
12-10 22:03:49.030+0900 E/PKGMGR_SERVER( 6345): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-10 22:03:49.150+0900 E/PKGMGR_SERVER( 6344): pkgmgr-server.c: sighandler(445) > child NORMAL exit [6345]
12-10 22:03:49.170+0900 E/RESOURCED(  464): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 6
12-10 22:03:49.170+0900 E/RESOURCED(  464): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-10 22:03:49.175+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(2026) > pad pid(-5)
12-10 22:03:49.175+0900 W/AUL_PAD ( 1159): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-10 22:03:49.175+0900 W/AUL_PAD ( 1159): launchpad.c: __send_result_to_caller(265) > Check app launching
12-10 22:03:49.220+0900 I/CAPI_WATCH_APPLICATION( 6046): watch_app_main.c: watch_app_main(382) > watch_app_main
12-10 22:03:49.245+0900 E/TBM     ( 6046): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-10 22:03:49.280+0900 I/AUL_AMD (  454): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 5998
12-10 22:03:49.315+0900 W/WATCH_CORE( 6046): appcore-watch.c: __widget_create(958) > widget_create
12-10 22:03:49.320+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1712) > [SECURE_LOG] [1300.401001] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_713_1300.401001.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263076:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-10 22:03:49.320+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[1300.401001] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_713_1300.401001.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263076:4] gbar_fname[]
12-10 22:03:49.340+0900 E/WIDGET_VIEWER(  713): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-10 22:03:49.340+0900 E/WIDGET_EVAS(  713): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-10 22:03:49.490+0900 I/CAPI_NETWORK_WIFI( 6046): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:03:49.505+0900 I/CAPI_NETWORK_WIFI( 6046): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:03:49.685+0900 W/WATCH_CORE( 6046): appcore-watch.c: __widget_create(976) > widget_create done
12-10 22:03:49.715+0900 I/WATCH_CORE( 6046): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-10 22:03:49.715+0900 I/WATCH_CORE( 6046): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-10 22:03:49.715+0900 I/WATCH_CORE( 6046): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-10 22:03:50.205+0900 E/PKGMGR_SERVER( 6344): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-10 22:03:50.205+0900 E/PKGMGR_SERVER( 6344): pkgmgr-server.c: main(2180) > package manager server terminated.
12-10 22:03:50.280+0900 W/AUL_AMD (  454): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-10 22:03:50.280+0900 W/AUL_AMD (  454): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-10 22:03:50.295+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:03:50.305+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6046
12-10 22:03:50.305+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 22:03:50.405+0900 W/AUL_AMD (  454): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-10 22:03:50.505+0900 I/AUL_PAD ( 6383): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-10 22:03:53.085+0900 I/GESTURE (  139): gesture.c: GestureHandleKeyPressEvent(3712) > [GestureHandleKeyPressEvent] Ignore key press in DPMS off (devid:7) keycode=124
12-10 22:03:53.210+0900 W/STARTER (  705): hw_key.c: _key_press_cb(1200) > [_key_press_cb:1200] POWER Key is pressed
12-10 22:03:53.210+0900 W/STARTER (  705): hw_key.c: _key_press_cb(1203) > [_key_press_cb:1203] LCD state : 3
12-10 22:03:53.215+0900 W/STARTER (  705): hw_key.c: _key_press_cb(1210) > [_key_press_cb:1210] PM state : 3
12-10 22:03:53.215+0900 W/STARTER (  705): hw_key.c: _key_press_cb(1224) > [_key_press_cb:1224] powerkey count : 1
12-10 22:03:53.215+0900 W/STARTER (  705): hw_key.c: _key_release_cb(1124) > [_key_release_cb:1124] POWER Key is released
12-10 22:03:53.215+0900 E/W_HOME  (  713): key.c: _key_press_cb(214) > (APP_STATE_PAUSE == main_get_info()->state) -> _key_press_cb() return
12-10 22:03:53.320+0900 W/WATCH_CORE( 6046): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
12-10 22:03:53.320+0900 I/WATCH_CORE( 6046): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-10 22:03:53.355+0900 W/wnotibp ( 1413): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1405) > ::APP:: view state=0, 2, 0
12-10 22:03:53.395+0900 W/W_HOME  (  713): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-10 22:03:53.395+0900 W/W_HOME  (  713): gesture.c: _manual_render_disable_timer_set(161) > timer set
12-10 22:03:53.395+0900 W/W_HOME  (  713): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-10 22:03:53.395+0900 W/W_HOME  (  713): gesture.c: _apps_status_get(123) > apps status:0
12-10 22:03:53.395+0900 W/W_HOME  (  713): gesture.c: _lcd_on_cb(295) > move_to_clock:1 clock_visible:1 info->offtime:821000
12-10 22:03:53.395+0900 W/W_HOME  (  713): gesture.c: _manual_render_schedule(211) > schedule, manual render
12-10 22:03:53.395+0900 W/W_HOME  (  713): event_manager.c: _lcd_on_cb(691) > lcd state: 1
12-10 22:03:53.395+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:03:53.400+0900 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1519) > [_on_lcd_signal_receive_cb:1519] _on_lcd_signal_receive_cb, 1519, Pre LCD on by [powerkey] after screen off time [821000]ms
12-10 22:03:53.400+0900 W/STARTER (  705): clock-mgr.c: _pre_lcd_on(1245) > [_pre_lcd_on:1245] Will LCD ON as reserved app[(null)] alpm mode[0]
12-10 22:03:53.405+0900 I/SCONTEXT-LIB(  662): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 42 (req_id=12)
12-10 22:03:53.410+0900 I/APP_CORE(  713): appcore-efl.c: __do_app(429) > [APP 713] Event: RESUME State: PAUSED
12-10 22:03:53.410+0900 I/CAPI_APPFW_APPLICATION(  713): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-10 22:03:53.410+0900 W/W_HOME  (  713): main.c: _appcore_resume_cb(681) > appcore resume
12-10 22:03:53.410+0900 W/W_HOME  (  713): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
12-10 22:03:53.410+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:03:53.410+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:03:53.410+0900 W/W_HOME  (  713): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-10 22:03:53.410+0900 W/W_HOME  (  713): main.c: home_resume(733) > clock/widget resumed
12-10 22:03:53.410+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:03:53.415+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-10 22:03:53.455+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: OnReceiveDisplayChanged(905) > [0;32mINFO: LCDOn receive data : 1124318408[0;m
12-10 22:03:53.455+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-10 22:03:53.455+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-10 22:03:53.460+0900 I/SHealth_Common( 1068): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-10 22:03:53.460+0900 I/SHealth_Service( 1068): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-10 22:03:53.460+0900 W/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-10 22:03:53.465+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-10 22:03:53.520+0900 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [powerkey]
12-10 22:03:53.520+0900 W/STARTER (  705): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[0]
12-10 22:03:53.545+0900 W/MUSIC_CONTROL_SERVICE( 1067): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1067]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
12-10 22:03:53.570+0900 W/SHealth_Service( 1068): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1003[0;m
12-10 22:03:53.570+0900 W/SHealth_Service( 1068): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1003[0;m
12-10 22:03:53.570+0900 W/SHealth_Service( 1068): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1004[0;m
12-10 22:03:53.570+0900 E/SHealth_Service( 1068): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-10 22:03:53.570+0900 W/SHealth_Common( 1068): SamsungLogManager.cpp: InsertLog(181) > [1;40;33mmLogManagerHandle is NULL[0;m
12-10 22:03:53.595+0900 W/W_HOME  (  713): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
12-10 22:03:53.595+0900 W/W_HOME  (  713): gesture.c: _manual_render_enable(133) > 0
12-10 22:03:53.595+0900 E/WIDGET_EVAS(  713): widget_viewer_evas.c: evas_render_pre_cb(6758) > [SECURE_LOG] Failed to create a resource lock
12-10 22:03:53.615+0900 W/STARTER (  705): hw_key.c: _powerkey_timer_cb(806) > [_powerkey_timer_cb:806] _powerkey_timer_cb, powerkey count[1]
12-10 22:03:53.615+0900 W/STARTER (  705): hw_key.c: _powerkey_timer_cb(961) > [_powerkey_timer_cb:961] clock visibility[1] pressed lcd status[3], current lcd status[1] pressed pm state[3]
12-10 22:03:53.615+0900 W/STARTER (  705): hw_key.c: _powerkey_timer_cb(963) > [_powerkey_timer_cb:963] LCD OFF state => ignore key operation
12-10 22:03:53.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-10 22:03:53.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-10 22:03:53.660+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: preference_get_double(1214) > preference_get_double(1068) : pedometer_inactive_period error
12-10 22:03:53.665+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-10 22:03:53.665+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-10 22:03:53.665+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: preference_get_double(1214) > preference_get_double(1068) : inactive_10min_precaution_millisec error
12-10 22:03:53.665+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-10 22:03:53.665+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-10 22:03:53.665+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: preference_get_double(1214) > preference_get_double(1068) : inactive_before_10min_precaution_millisec error
12-10 22:03:53.680+0900 I/HealthDataService(  792): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
12-10 22:03:53.705+0900 I/healthData( 1068): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
12-10 22:03:53.755+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-10 22:03:53.755+0900 W/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-10 22:03:53.755+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-10 22:03:53.755+0900 I/HIGEAR  ( 1108): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-10 22:03:53.775+0900 W/SHealth_Service( 1068): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
12-10 22:03:53.775+0900 E/SHealth_Service( 1068): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-10 22:03:54.415+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:03:54.415+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:03:54.415+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:03:54.415+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 22:03:54.415+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 22:03:54.415+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:03:54.415+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-10 22:03:54.415+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:03:54.425+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:03:54.425+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:03:54.425+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:03:54.425+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 22:03:54.425+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 22:03:54.425+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:03:54.425+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-10 22:03:54.425+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 22:03:54.425+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 22:03:54.425+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:03:54.440+0900 E/CAPI_APPFW_APP_CONTROL( 1067): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-10 22:03:54.440+0900 W/MUSIC_CONTROL_SERVICE( 1067): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1067]   value = [true][0m
12-10 22:03:54.465+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:03:54.495+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 713
12-10 22:03:54.585+0900 W/MUSIC_CONTROL_SERVICE( 1067): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1067]   [MUSIC_PLAYER_EVENT][0m
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 22:03:54.605+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:03:54.610+0900 W/W_HOME  (  713): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-10 22:03:54.610+0900 E/W_HOME  (  713): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-10 22:03:54.610+0900 W/MUSIC_CONTROL_SERVICE( 1067): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1067]   [MUSIC_PLAYER_EVENT][0m
12-10 22:03:54.615+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:03:54.615+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:03:54.615+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:03:54.615+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 22:03:54.615+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 22:03:54.615+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:03:54.615+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-10 22:03:54.615+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:03:54.620+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:03:54.620+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:03:54.620+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:03:54.620+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 22:03:54.620+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 22:03:54.620+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:03:54.620+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-10 22:03:54.620+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 22:03:54.620+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 22:03:54.620+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:03:54.620+0900 W/W_HOME  (  713): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-10 22:03:54.620+0900 E/W_HOME  (  713): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 22:03:54.625+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:03:59.875+0900 E/PKGMGR  ( 6505): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-10 22:04:00.050+0900 E/PKGMGR_SERVER( 6507): pkgmgr-server.c: main(2126) > package manager server start
12-10 22:04:00.165+0900 E/PKGMGR_SERVER( 6507): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-685964042], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-685964042' '-r' 'org.reolab.blackandwhite'], cookie=[TuHS4ngQW1L1S/svoyaOosE25hc=], backend_flag=[0]
12-10 22:04:00.165+0900 E/PKGMGR  ( 6507): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-10 22:04:00.170+0900 E/PKGMGR_SERVER( 6507): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-10 22:04:00.175+0900 E/PKGMGR_SERVER( 6508): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-10 22:04:00.175+0900 E/PKGMGR  ( 6505): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[65050002]
12-10 22:04:00.385+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-10 22:04:00.395+0900 W/AUL_AMD (  454): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-10 22:04:00.410+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-10 22:04:00.420+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 22:04:00.980+0900 E/PKGMGR_CERT( 6508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-10 22:04:00.990+0900 E/PKGMGR_CERT( 6508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
12-10 22:04:00.990+0900 E/PKGMGR_CERT( 6508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
12-10 22:04:00.990+0900 E/PKGMGR_CERT( 6508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 3
12-10 22:04:00.995+0900 E/PKGMGR_CERT( 6508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 3
12-10 22:04:00.995+0900 E/PKGMGR_CERT( 6508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 3
12-10 22:04:00.995+0900 E/PKGMGR_CERT( 6508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 3
12-10 22:04:01.015+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 22:04:01.030+0900 E/PKGMGR_CERT( 6508): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-10 22:04:01.030+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-10 22:04:01.035+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-10 22:04:01.035+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: preference_get_double(1214) > preference_get_double(1068) : pedometer_inactive_period error
12-10 22:04:01.035+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-10 22:04:01.035+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-10 22:04:01.035+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: preference_get_double(1214) > preference_get_double(1068) : inactive_10min_precaution_millisec error
12-10 22:04:01.035+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-10 22:04:01.035+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-10 22:04:01.035+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1068): preference.c: preference_get_double(1214) > preference_get_double(1068) : inactive_before_10min_precaution_millisec error
12-10 22:04:02.205+0900 E/PKGMGR_SERVER( 6507): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 22:04:02.900+0900 W/WATCH_CORE( 6046): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 1
12-10 22:04:02.900+0900 W/W_HOME  (  713): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
12-10 22:04:02.905+0900 I/WATCH_CORE( 6046): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
12-10 22:04:02.910+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: OnReceiveGestureChanged(928) > [0;32mINFO: wakeup receive data : 1124318360[0;m
12-10 22:04:02.910+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-10 22:04:02.910+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-10 22:04:02.920+0900 W/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-10 22:04:02.925+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-10 22:04:02.925+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-10 22:04:02.925+0900 W/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-10 22:04:02.925+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-10 22:04:02.925+0900 I/HIGEAR  ( 1108): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-10 22:04:03.530+0900 E/rpm-installer( 6508): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-10 22:04:04.205+0900 E/PKGMGR_SERVER( 6507): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 22:04:06.205+0900 E/PKGMGR_SERVER( 6507): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 22:04:06.520+0900 E/PKGMGR_SERVER( 6507): pkgmgr-server.c: sighandler(445) > child NORMAL exit [6508]
12-10 22:04:06.525+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 22:04:06.545+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-10 22:04:06.545+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-10 22:04:06.565+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-10 22:04:06.565+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-10 22:04:06.565+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-10 22:04:06.565+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-10 22:04:06.575+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-10 22:04:06.640+0900 E/APPS    (  713): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-10 22:04:06.690+0900 E/PKGMGR_INFO(  461): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-10 22:04:06.965+0900 W/CRASH_MANAGER( 6510): worker.c: worker_job(1199) > 1106046626c61144975264
