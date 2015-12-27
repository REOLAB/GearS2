S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 4372
Date: 2015-12-11 22:30:07+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xea0

Register Information
r0   = 0xbed5e2f0, r1   = 0xbed5e5cc
r2   = 0xbb513000, r3   = 0xbb513000
r4   = 0xbed5e530, r5   = 0xbed5e2c8
r6   = 0x00000132, r7   = 0xbed5e298
r8   = 0x4030b9c0, r9   = 0x4145ff30
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4155d630, sp   = 0xbed5e238
lr   = 0x41554ce1, pc   = 0x00000ea0
cpsr = 0x80000010

Memory Information
MemTotal:   489992 KB
MemFree:     31484 KB
Buffers:     22104 KB
Cached:     123004 KB
VmPeak:     111464 KB
VmSize:     110952 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16052 KB
VmRSS:       16052 KB
VmData:      54424 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 4372 TID = 4372
4372 15416 15424 

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
43757000 43f56000 rw-p [stack:15416]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45255000 45b00000 rw-p [stack:15424]
bed3e000 bed5f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4372)
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
client(83) > __send_result_to_client, pid: 2502
12-11 22:28:54.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:28:54.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:28:54.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:28:54.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:28:55.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:28:55.136+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:28:55.191+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:28:55.281+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:28:56.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:28:56.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:28:56.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:28:56.251+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:28:57.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:28:57.046+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 22:28:57.046+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 22:28:57.051+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 22:28:57.056+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 22:28:57.136+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:28:57.166+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:28:57.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:28:58.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:28:58.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:28:58.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:28:58.251+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:28:58.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:28:58.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:28:59.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:28:59.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:28:59.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:28:59.251+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:00.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:00.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:00.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:00.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:01.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:01.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:01.166+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:01.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:02.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:02.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:02.146+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:02.231+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:03.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:03.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:03.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:03.246+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:03.766+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:03.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:04.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:04.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:04.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:04.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:05.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:05.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:05.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:05.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:06.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:06.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:06.146+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:06.236+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:07.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:07.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:07.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:07.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:08.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:08.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:08.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:08.266+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:08.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:08.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:09.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:09.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:09.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:09.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:10.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:10.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:10.166+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:10.271+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:10.721+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 22:29:11.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:11.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:11.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:11.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:12.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:12.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:12.166+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:12.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:13.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:13.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:13.156+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:13.266+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:13.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:13.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:14.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:14.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:14.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:14.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:15.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:15.116+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:15.176+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:15.281+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:16.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:16.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:16.156+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:16.231+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:17.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:17.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:17.146+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:17.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:18.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:18.076+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:18.126+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:18.206+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:18.766+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:18.831+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:19.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:19.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:19.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:19.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:20.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:20.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:20.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:20.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:21.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:21.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:21.151+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:21.241+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:22.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:22.116+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:22.156+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:22.271+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:23.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:23.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:23.141+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:23.246+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:23.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:23.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:24.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:24.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:24.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:24.251+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:25.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:25.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:25.166+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:25.271+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:26.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:26.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:26.156+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:26.266+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:27.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:27.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:27.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:27.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:28.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:28.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:28.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:28.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:28.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:28.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:29.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:29.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:29.146+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:29.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:30.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:30.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:30.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:30.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:31.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:31.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:31.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:31.251+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:32.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:32.116+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:32.151+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:32.236+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:33.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:33.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:33.146+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:33.241+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:33.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:33.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:34.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:34.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:34.156+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:34.241+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:35.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:35.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:35.166+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:35.251+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:36.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:36.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:36.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:36.251+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:37.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:37.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:37.166+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:37.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:38.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:38.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:38.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:38.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:38.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:38.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:39.041+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:39.141+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:39.191+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:39.276+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:40.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:40.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:40.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:40.251+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:41.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:41.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:41.156+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:41.266+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:42.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:42.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:42.166+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:42.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:43.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:43.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:43.156+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:43.231+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:43.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:43.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:44.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:44.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:44.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:44.266+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:45.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:45.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:45.156+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:45.196+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 22:29:45.196+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 22:29:45.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:46.011+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:46.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:46.161+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:46.261+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:47.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:47.106+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:47.166+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:47.256+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:48.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:48.111+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:48.136+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:48.231+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:48.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:48.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:49.051+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:49.151+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:49.211+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:49.301+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:50.006+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:50.131+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:50.231+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:50.301+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:51.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:51.116+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:51.246+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:51.291+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:52.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:52.101+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:52.186+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:52.266+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:53.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:53.046+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:53.071+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:53.131+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:53.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:53.836+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:54.001+0900 I/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:54.056+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:54.136+0900 I/CAPI_NETWORK_WIFI( 2980): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:54.231+0900 E/blackandwhite( 2980): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:54.356+0900 E/PKGMGR_SERVER(15412): pkgmgr-server.c: main(2126) > package manager server start
12-11 22:29:54.451+0900 E/PKGMGR_SERVER(15412): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1369022034], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 22:29:54.456+0900 E/PKGMGR_SERVER(15414): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 22:29:54.506+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:54.516+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2980
12-11 22:29:54.521+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 22:29:54.521+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 22:29:54.526+0900 W/CAPI_WATCH_APPLICATION( 2980): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 22:29:54.531+0900 W/WATCH_CORE( 2980): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 22:29:54.531+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(2980), cmd(4)
12-11 22:29:54.531+0900 E/WIDGET_PROVIDER_APP( 2980): client.c: client_fini(1175) > Provider is not initialized
12-11 22:29:54.531+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 22:29:54.531+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(884) > app status : 4
12-11 22:29:54.531+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:54.541+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2980
12-11 22:29:54.541+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 22:29:54.646+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:54.706+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 22:29:54.756+0900 E/PKGMGR_SERVER(15414): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 22:29:54.766+0900 E/PKGMGR  (15405): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 22:29:54.806+0900 E/AUL_AMD (  479): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 22:29:54.806+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(2980), cmd(4)
12-11 22:29:54.811+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 22:29:54.841+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 22:29:54.861+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 22:29:54.861+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 22:29:54.861+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 698
12-11 22:29:54.891+0900 E/PKGMGR_SERVER(15412): pkgmgr-server.c: sighandler(445) > child NORMAL exit [15414]
12-11 22:29:54.926+0900 E/RESOURCED(  480): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-11 22:29:54.926+0900 E/RESOURCED(  480): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 22:29:54.941+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 22:29:54.941+0900 W/AUL_PAD ( 1168): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 22:29:54.941+0900 W/AUL_PAD ( 1168): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 22:29:54.986+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 22:29:55.011+0900 E/TBM     ( 4372): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 22:29:55.046+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2980
12-11 22:29:55.091+0900 W/WATCH_CORE( 4372): appcore-watch.c: __widget_create(958) > widget_create
12-11 22:29:55.096+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [633.058716] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_633.058716.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263024:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 22:29:55.096+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[633.058716] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_633.058716.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263024:4] gbar_fname[]
12-11 22:29:55.106+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 22:29:55.106+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 22:29:55.236+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:55.246+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:55.401+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:55.416+0900 W/WATCH_CORE( 4372): appcore-watch.c: __widget_create(976) > widget_create done
12-11 22:29:55.446+0900 I/WATCH_CORE( 4372): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 22:29:55.446+0900 I/WATCH_CORE( 4372): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 22:29:55.446+0900 I/WATCH_CORE( 4372): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 22:29:55.491+0900 W/WATCH_CORE( 4372): appcore-watch.c: __widget_resume(1012) > widget_resume
12-11 22:29:55.491+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:55.516+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:55.526+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:55.586+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:55.996+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:56.006+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:56.016+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:56.051+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 22:29:56.051+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 22:29:56.061+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:56.076+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:56.086+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4372
12-11 22:29:56.086+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 22:29:56.296+0900 I/AUL_PAD (15437): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 22:29:56.531+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 22:29:57.006+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:57.086+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 22:29:57.086+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 22:29:57.091+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 22:29:57.091+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 22:29:57.161+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:57.191+0900 E/PKGMGR_SERVER(15412): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 22:29:57.191+0900 E/PKGMGR_SERVER(15412): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 22:29:57.301+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:57.346+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:58.001+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:58.076+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:58.176+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:58.241+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:29:58.766+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:29:58.821+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:29:59.036+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:29:59.061+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:29:59.071+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:29:59.126+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:30:00.001+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:30:00.121+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:30:00.256+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:30:00.311+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:30:01.001+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:30:01.101+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:30:01.221+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:30:01.286+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:30:02.001+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:30:02.131+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:30:02.271+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:30:02.326+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:30:03.001+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:30:03.106+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:30:03.186+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:30:03.266+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:30:03.786+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:30:03.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:30:04.001+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:30:04.046+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:30:04.091+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:30:04.171+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:30:05.001+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:30:05.066+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:30:05.116+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:30:05.201+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:30:05.996+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:30:06.021+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:30:06.061+0900 E/PKGMGR  (15593): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 22:30:06.076+0900 I/CAPI_NETWORK_WIFI( 4372): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:30:06.156+0900 E/blackandwhite( 4372): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:30:06.226+0900 E/PKGMGR_SERVER(15595): pkgmgr-server.c: main(2126) > package manager server start
12-11 22:30:06.331+0900 E/PKGMGR_SERVER(15595): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1380874296], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_1380874296' '-r' 'org.reolab.blackandwhite'], cookie=[XnePK8Kn8N0NR71CJ8g4ZNW5Dgk=], backend_flag=[0]
12-11 22:30:06.336+0900 E/PKGMGR  (15595): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 22:30:06.336+0900 E/PKGMGR_SERVER(15595): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 22:30:06.341+0900 E/PKGMGR  (15593): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[155930002]
12-11 22:30:06.341+0900 E/PKGMGR_SERVER(15596): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 22:30:06.501+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 22:30:06.506+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 22:30:06.516+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 22:30:06.531+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:30:06.996+0900 I/CAPI_WATCH_APPLICATION( 4372): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:30:07.116+0900 E/PKGMGR_CERT(15596): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 22:30:07.121+0900 E/PKGMGR_CERT(15596): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 96
12-11 22:30:07.121+0900 E/PKGMGR_CERT(15596): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 96
12-11 22:30:07.121+0900 E/PKGMGR_CERT(15596): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 4
12-11 22:30:07.126+0900 E/PKGMGR_CERT(15596): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 4
12-11 22:30:07.126+0900 E/PKGMGR_CERT(15596): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 4
12-11 22:30:07.126+0900 E/PKGMGR_CERT(15596): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 4
12-11 22:30:07.136+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:30:07.141+0900 E/PKGMGR_CERT(15596): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 22:30:07.256+0900 W/CRASH_MANAGER(15597): worker.c: worker_job(1199) > 1104372626c61144984060
