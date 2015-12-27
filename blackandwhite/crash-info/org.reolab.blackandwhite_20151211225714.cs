S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 22872
Date: 2015-12-11 22:57:14+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2188

Register Information
r0   = 0x0000217c, r1   = 0x0000000d
r2   = 0x00001ffc, r3   = 0x41453194
r4   = 0x0000217c, r5   = 0x00000000
r6   = 0x41a16ce4, r7   = 0x419efe08
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeab8c4c, sp   = 0xbeab8c00
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   489992 KB
MemFree:     16400 KB
Buffers:     28524 KB
Cached:     109736 KB
VmPeak:     111688 KB
VmSize:     111176 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16116 KB
VmRSS:       16116 KB
VmData:      54648 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 22872 TID = 22872
22872 27440 27451 

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
41843000 4187a000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41883000 4189c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
418a5000 418cf000 r-xp /usr/lib/libnfc.so.1.0.0
418d8000 418ee000 r-xp /usr/lib/libnetwork.so.0.0.0
418f7000 418fe000 rw-p [heap]
418fe000 41a30000 rw-p [heap]
41a30000 41b6d000 r-xp /usr/lib/libicui18n.so.51.1
41b7d000 41c61000 r-xp /usr/lib/libicuuc.so.51.1
41c76000 41ca7000 r-xp /usr/lib/libmdm.so.1.1.85
41caf000 41cb4000 r-xp /usr/lib/libcsc-feature.so.0.0.0
43243000 4324c000 r-xp /usr/lib/libcom-core.so.0.0.1
43255000 43261000 r-xp /usr/lib/libwidget_service.so.1.0.0
43269000 43272000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4327b000 43281000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43289000 43291000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43299000 432c7000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
432d3000 432db000 r-xp /usr/lib/libdrm.so.2.4.0
432e3000 432e5000 r-xp /usr/lib/libdri2.so.0.0.0
432ed000 432f4000 r-xp /usr/lib/libtbm.so.1.0.0
432fc000 43316000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4331f000 43326000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4332f000 43331000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43339000 43340000 r-xp /usr/lib/libminizip.so.1.0.0
43348000 43355000 r-xp /usr/lib/libail.so.0.1.0
43790000 43f8f000 rw-p [stack:27440]
43f8f000 43f92000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f9a000 43fa5000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43fae000 43fc5000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44283000 44285000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
4548e000 45c8d000 rw-p [stack:27451]
bea99000 beaba000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22872)
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
55): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:55:50.175+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:55:50.265+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:55:51.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:55:51.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:55:51.155+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:55:51.265+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:55:51.360+0900 I/APP_CORE( 2501): appcore-efl.c: __do_app(429) > [APP 2501] Event: MEM_FLUSH State: PAUSED
12-11 22:55:52.000+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:55:52.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:55:52.200+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:55:52.400+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:55:52.995+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:55:53.025+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:55:53.050+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:55:53.115+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:55:54.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:55:54.125+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:55:54.180+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:55:54.275+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:55:55.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:55:55.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:55:55.115+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:55:55.145+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:55:55.180+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:55:55.270+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:55:55.999+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:55:56.100+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:55:56.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:55:56.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:55:57.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:55:57.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:55:57.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:55:57.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:55:57.999+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:55:58.100+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:55:58.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:55:58.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:55:58.370+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 22:55:58.370+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 22:55:58.370+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 22:55:58.370+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 22:55:59.009+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:55:59.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:55:59.150+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:55:59.270+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:00.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:00.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:00.115+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:00.140+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:00.170+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:00.270+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:01.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:01.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:01.145+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:01.230+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:02.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:02.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:02.155+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:02.235+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:03.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:03.115+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:03.165+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:03.260+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:04.000+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:04.100+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:04.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:04.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:05.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:05.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:05.115+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:05.140+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:05.170+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:05.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:06.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:06.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:06.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:06.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:07.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:07.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:07.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:07.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:08.004+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:08.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:08.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:08.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:09.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:09.125+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:09.180+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:09.280+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:10.000+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:10.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:10.110+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:10.140+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:10.180+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:10.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:11.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:11.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:11.155+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:11.265+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:12.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:12.115+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:12.165+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:12.265+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:13.004+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:13.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:13.150+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:13.240+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:14.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:14.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:14.145+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:14.230+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:15.009+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:15.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:15.110+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:15.145+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:15.170+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:15.260+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:15.680+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 22:56:16.000+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:16.115+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:16.165+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:16.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:17.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:17.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:17.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:17.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:18.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:18.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:18.150+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:18.240+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:19.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:19.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:19.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:19.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:20.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:20.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:20.110+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:20.140+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:20.175+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:20.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:21.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:21.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:21.150+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:21.240+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:22.009+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:22.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:22.155+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:22.265+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:23.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:23.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:23.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:23.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:24.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:24.125+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:24.170+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:24.275+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:25.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:25.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:25.115+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:25.145+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:25.180+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:25.270+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:26.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:26.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:26.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:26.245+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:27.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:27.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:27.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:27.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:28.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:28.115+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:28.170+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:28.260+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:29.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:29.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:29.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:29.245+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:30.004+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:30.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:30.115+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:30.145+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:30.170+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:30.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:31.009+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:31.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:31.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:31.245+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:32.009+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:32.120+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:32.150+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:32.270+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:33.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:33.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:33.150+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:33.235+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:34.004+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:34.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:34.145+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:34.230+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:35.009+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:35.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:35.110+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:35.140+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:35.170+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:35.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:36.009+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:36.115+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:36.150+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:36.270+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:37.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:37.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:37.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:37.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:38.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:38.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:38.145+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:38.230+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:39.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:39.135+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:39.195+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:39.295+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:40.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:40.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:40.115+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:40.145+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:40.170+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:40.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:41.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:41.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:41.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:41.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:42.004+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:42.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:42.150+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:42.270+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:43.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:43.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:43.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:43.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:44.004+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:44.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:44.165+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:44.265+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:45.004+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:45.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:45.110+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:45.140+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:45.175+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:45.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:46.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:46.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:46.165+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:46.265+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:46.505+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 22:56:46.505+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 22:56:47.004+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:47.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:47.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:47.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:48.004+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:48.100+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:48.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:48.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:49.004+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:49.105+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:49.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:49.250+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:50.000+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:50.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:50.110+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:50.140+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:50.175+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:50.265+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:51.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:51.115+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:51.165+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:51.255+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:52.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:52.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:52.145+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:52.235+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:53.010+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:53.115+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:53.170+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:53.285+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:54.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:54.150+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:54.260+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:54.330+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:55.000+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:55.075+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:55.105+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:56:55.160+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:55.265+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:55.320+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:56.005+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:56.135+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:56.220+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:56.295+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:57.000+0900 I/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:56:57.110+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:57.190+0900 I/CAPI_NETWORK_WIFI(22655): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:57.240+0900 E/blackandwhite(22655): blackandwhite.c: update_watch(146) > colorT : 1
12-11 22:56:57.750+0900 E/PKGMGR_SERVER(27436): pkgmgr-server.c: main(2126) > package manager server start
12-11 22:56:57.850+0900 E/PKGMGR_SERVER(27436): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1302555096], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 22:56:57.855+0900 E/PKGMGR_SERVER(27437): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 22:56:57.860+0900 E/PKGMGR  (27434): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 22:56:57.925+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:57.930+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22655
12-11 22:56:57.935+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 22:56:57.940+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 22:56:57.940+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(22655), cmd(4)
12-11 22:56:57.945+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 22:56:57.945+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(884) > app status : 4
12-11 22:56:57.945+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:57.945+0900 W/CAPI_WATCH_APPLICATION(22655): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 22:56:57.950+0900 W/WATCH_CORE(22655): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 22:56:57.950+0900 E/WIDGET_PROVIDER_APP(22655): client.c: client_fini(1175) > Provider is not initialized
12-11 22:56:57.955+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22655
12-11 22:56:57.955+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 22:56:58.060+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:58.135+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 22:56:58.180+0900 E/PKGMGR_SERVER(27437): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 22:56:58.195+0900 E/AUL_AMD (  479): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 22:56:58.195+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(22655), cmd(4)
12-11 22:56:58.200+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 22:56:58.240+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 22:56:58.260+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 22:56:58.260+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 22:56:58.260+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 698
12-11 22:56:58.295+0900 E/PKGMGR_SERVER(27436): pkgmgr-server.c: sighandler(445) > child NORMAL exit [27437]
12-11 22:56:58.335+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 22:56:58.335+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 22:56:58.335+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 22:56:58.335+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 22:56:58.365+0900 E/RESOURCED(  480): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-11 22:56:58.365+0900 E/RESOURCED(  480): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 22:56:58.370+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 22:56:58.370+0900 W/AUL_PAD ( 1168): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 22:56:58.370+0900 W/AUL_PAD ( 1168): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 22:56:58.415+0900 I/CAPI_WATCH_APPLICATION(22872): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 22:56:58.440+0900 E/TBM     (22872): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 22:56:58.475+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 22655
12-11 22:56:58.520+0900 W/WATCH_CORE(22872): appcore-watch.c: __widget_create(958) > widget_create
12-11 22:56:58.520+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [633.058716] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_633.058716.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263096:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 22:56:58.520+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[633.058716] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_633.058716.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263096:4] gbar_fname[]
12-11 22:56:58.540+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 22:56:58.540+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 22:56:58.670+0900 I/CAPI_NETWORK_WIFI(22872): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:56:58.685+0900 I/CAPI_NETWORK_WIFI(22872): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:56:58.855+0900 E/blackandwhite(22872): blackandwhite.c: update_watch(146) > colorT : 0
12-11 22:56:58.870+0900 W/WATCH_CORE(22872): appcore-watch.c: __widget_create(976) > widget_create done
12-11 22:56:58.925+0900 I/WATCH_CORE(22872): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 22:56:58.925+0900 I/WATCH_CORE(22872): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 22:56:58.925+0900 I/WATCH_CORE(22872): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 22:56:59.475+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 22:56:59.475+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 22:56:59.495+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:56:59.505+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 22872
12-11 22:56:59.505+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 22:56:59.735+0900 I/AUL_PAD (27466): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 22:56:59.945+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 22:57:00.075+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:57:00.155+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:57:00.500+0900 E/PKGMGR_SERVER(27436): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 22:57:00.505+0900 E/PKGMGR_SERVER(27436): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 22:57:05.170+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:57:05.260+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:57:08.630+0900 E/PKGMGR  (27577): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 22:57:08.800+0900 E/PKGMGR_SERVER(27579): pkgmgr-server.c: main(2126) > package manager server start
12-11 22:57:08.920+0900 E/PKGMGR_SERVER(27579): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1291520807], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-1291520807' '-r' 'org.reolab.blackandwhite'], cookie=[xizctkiejlU7rF0/6K6OFUYg2SE=], backend_flag=[0]
12-11 22:57:08.925+0900 E/PKGMGR  (27579): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 22:57:08.925+0900 E/PKGMGR_SERVER(27579): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 22:57:08.930+0900 E/PKGMGR  (27577): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[275770002]
12-11 22:57:08.930+0900 E/PKGMGR_SERVER(27580): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 22:57:09.085+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 22:57:09.095+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 22:57:09.095+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:57:09.135+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 22:57:09.755+0900 E/PKGMGR_CERT(27580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 22:57:09.765+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:57:09.770+0900 E/PKGMGR_CERT(27580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 97
12-11 22:57:09.770+0900 E/PKGMGR_CERT(27580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 97
12-11 22:57:09.770+0900 E/PKGMGR_CERT(27580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 5
12-11 22:57:09.775+0900 E/PKGMGR_CERT(27580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 5
12-11 22:57:09.780+0900 E/PKGMGR_CERT(27580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 5
12-11 22:57:09.780+0900 E/PKGMGR_CERT(27580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 5
12-11 22:57:09.800+0900 E/PKGMGR_CERT(27580): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 22:57:10.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:57:10.080+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:57:11.500+0900 E/PKGMGR_SERVER(27579): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 22:57:11.680+0900 E/rpm-installer(27580): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-11 22:57:13.500+0900 E/PKGMGR_SERVER(27579): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 22:57:14.900+0900 E/PKGMGR_SERVER(27579): pkgmgr-server.c: sighandler(445) > child NORMAL exit [27580]
12-11 22:57:14.900+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:57:14.920+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-11 22:57:14.920+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-11 22:57:14.975+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-11 22:57:14.975+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-11 22:57:14.975+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-11 22:57:14.975+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-11 22:57:15.005+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-11 22:57:15.060+0900 E/PKGMGR_INFO(  476): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-11 22:57:15.065+0900 E/APPS    (  717): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-11 22:57:15.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:57:15.080+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:57:15.305+0900 W/CRASH_MANAGER(27591): worker.c: worker_job(1199) > 1122872626c61144984223
