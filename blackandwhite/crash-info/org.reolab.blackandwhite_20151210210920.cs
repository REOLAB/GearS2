S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 2758
Date: 2015-12-10 21:09:20+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1d

Register Information
r0   = 0xfe400106, r1   = 0x00000000
r2   = 0x4be56000, r3   = 0x4be56000
r4   = 0xbe947380, r5   = 0x00000168
r6   = 0x00000168, r7   = 0xbe946898
r8   = 0x00000168, r9   = 0x00000168
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x43e06480, sp   = 0xbe946870
lr   = 0x403981e8, pc   = 0x400014da
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:     13684 KB
Buffers:     21532 KB
Cached:     152840 KB
VmPeak:      92612 KB
VmSize:      92100 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14796 KB
VmRSS:       14796 KB
VmData:      37004 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       21004 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 2758 TID = 2758
2758 2760 2767 

Maps Information
40000000 40003000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
4000b000 40028000 r-xp /lib/ld-2.13.so
40031000 40035000 r-xp /usr/lib/libsys-assert.so
4003e000 40042000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
40052000 40059000 r-xp /usr/lib/libappcore-watch.so.1.1
40062000 40064000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4006d000 4009d000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
4009e000 400b2000 r-xp /usr/lib/libcapi-network-nfc.so.0.2.3
400ba000 400c7000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.55
400cf000 400d4000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
400dc000 400de000 r-xp /usr/lib/libdlog.so.0.0.0
400e6000 40220000 r-xp /usr/lib/libelementary.so.1.7.99
40236000 40305000 r-xp /usr/lib/libevas.so.1.7.99
40329000 40444000 r-xp /lib/libc-2.13.so
40452000 4045a000 r-xp /lib/libgcc_s-4.6.so.1
4045b000 4046f000 r-xp /lib/libpthread-2.13.so
4047a000 40485000 r-xp /lib/libunwind.so.8.0.1
404b2000 404b4000 r-xp /lib/libdl-2.13.so
404bd000 404c9000 r-xp /usr/lib/libaul.so.0.1.0
404d3000 404ea000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
404f2000 404ff000 r-xp /usr/lib/libalarm.so.0.0.0
40508000 4053c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40545000 4054a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
40552000 40574000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4057c000 40593000 r-xp /usr/lib/libecore.so.1.7.99
405aa000 405eb000 r-xp /usr/lib/libeina.so.1.7.99
405f4000 40731000 r-xp /usr/lib/libicui18n.so.51.1
40741000 40825000 r-xp /usr/lib/libicuuc.so.51.1
4083a000 4083e000 r-xp /usr/lib/libvconf.so.0.2.45
40846000 40916000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40917000 40941000 r-xp /usr/lib/libdbus-1.so.3.8.12
4094a000 40950000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
40958000 4095e000 r-xp /usr/lib/libwidget.so.1.0.0
40967000 4096c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
40974000 409ab000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
409b4000 409ba000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
409c3000 409dc000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
409e5000 40a0f000 r-xp /usr/lib/libnfc.so.1.0.0
40a18000 40a68000 r-xp /usr/lib/libecore_x.so.1.7.99
40a6a000 40a9b000 r-xp /usr/lib/libmdm.so.1.1.85
40aa3000 40ab9000 r-xp /usr/lib/libnetwork.so.0.0.0
40ac2000 40b95000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40ba0000 40ba5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
40bad000 40c16000 r-xp /lib/libm-2.13.so
40c1f000 40c38000 r-xp /usr/lib/libeet.so.1.7.99
40c49000 40c6b000 r-xp /usr/lib/libecore_evas.so.1.7.99
40c74000 40c79000 r-xp /usr/lib/libecore_file.so.1.7.99
40c81000 40c92000 r-xp /usr/lib/libecore_input.so.1.7.99
40c9a000 40cf7000 r-xp /usr/lib/libedje.so.1.7.99
40d01000 40d0a000 r-xp /usr/lib/libedbus.so.1.7.99
40d12000 40d2c000 r-xp /usr/lib/libecore_con.so.1.7.99
40d35000 40d48000 r-xp /usr/lib/libfribidi.so.0.3.1
40d50000 40d8d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40d96000 40dbe000 r-xp /usr/lib/libfontconfig.so.1.8.0
40dbf000 40e15000 r-xp /usr/lib/libfreetype.so.6.11.3
40e21000 40e77000 r-xp /usr/lib/libpixman-1.so.0.28.2
40e84000 40e87000 r-xp /usr/lib/libbundle.so.0.1.22
40e8f000 40e94000 r-xp /usr/lib/libxdgmime.so.1.1.0
40e9c000 40ed8000 r-xp /usr/lib/libsystemd.so.0.4.0
40ee1000 40ee4000 r-xp /usr/lib/libproc-stat.so.0.2.86
40eec000 40f12000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40f1b000 40f21000 r-xp /usr/lib/libappsvc.so.0.1.0
40f29000 40f2a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40f32000 40f38000 r-xp /lib/librt-2.13.so
40f41000 40f46000 r-xp /usr/lib/libffi.so.5.0.10
40f4e000 40f51000 r-xp /usr/lib/libsmack.so.1.0.0
40f59000 40f6e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40f76000 40feb000 r-xp /usr/lib/libsqlite3.so.0.8.6
40ff5000 41089000 r-xp /usr/lib/libstdc++.so.6.0.16
42623000 4262c000 r-xp /usr/lib/libcom-core.so.0.0.1
42635000 42641000 r-xp /usr/lib/libwidget_service.so.1.0.0
42649000 42652000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4265b000 4273c000 r-xp /usr/lib/libX11.so.6.3.0
42747000 42749000 r-xp /usr/lib/libiniparser.so.0
42752000 4281e000 r-xp /usr/lib/libxml2.so.2.7.8
4282b000 4282d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
42837000 4283d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
42845000 4284d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
42855000 42883000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
4288f000 42896000 r-xp /usr/lib/libXcursor.so.1.0.2
4289e000 428a0000 r-xp /usr/lib/libXdamage.so.1.1.0
428a9000 428ab000 r-xp /usr/lib/libXcomposite.so.1.0.0
428b3000 428b5000 r-xp /usr/lib/libXgesture.so.7.0.0
428bd000 428c0000 r-xp /usr/lib/libXfixes.so.3.1.0
428c8000 428d1000 r-xp /usr/lib/libXi.so.6.1.0
428d9000 428da000 r-xp /usr/lib/libXinerama.so.1.0.0
428e3000 428e9000 r-xp /usr/lib/libXrandr.so.2.2.0
428f2000 428f8000 r-xp /usr/lib/libXrender.so.1.3.0
42900000 42903000 r-xp /usr/lib/libXtst.so.6.1.0
4290c000 42916000 r-xp /usr/lib/libXext.so.6.4.0
4291f000 42927000 r-xp /usr/lib/libmdm-common.so.1.0.89
42928000 4292a000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
42933000 42949000 r-xp /lib/libz.so.1.2.5
42951000 42961000 r-xp /lib/libresolv-2.13.so
42965000 42988000 r-xp /usr/lib/libjpeg.so.8.0.2
429a0000 429a5000 r-xp /usr/lib/libecore_fb.so.1.7.99
429ae000 429b2000 r-xp /usr/lib/libecore_ipc.so.1.7.99
429bc000 429bf000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
429c7000 429ce000 r-xp /usr/lib/libembryo.so.1.7.99
429d6000 429ed000 r-xp /usr/lib/liblua-5.1.so
429f6000 429fc000 r-xp /usr/lib/libecore_imf.so.1.7.99
42a04000 42a05000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
42a0e000 42a52000 r-xp /usr/lib/libcurl.so.4.3.0
42a5b000 42a71000 r-xp /lib/libexpat.so.1.5.2
42a7b000 42a93000 r-xp /usr/lib/libpng12.so.0.50.0
42a9b000 42ab3000 r-xp /usr/lib/liblzma.so.5.0.3
42abb000 42b37000 r-xp /usr/lib/libgcrypt.so.20.0.3
42b44000 42b60000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
42b69000 42b6b000 r-xp /usr/lib/journal/libjournal.so.0.1.0
42b73000 42b7b000 r-xp /usr/lib/libdrm.so.2.4.0
42b83000 42b85000 r-xp /usr/lib/libdri2.so.0.0.0
42b8e000 42b95000 r-xp /usr/lib/libtbm.so.1.0.0
42b9d000 42bb0000 r-xp /usr/lib/libxcb.so.1.1.0
42bb9000 42bd3000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
42bdc000 42d84000 r-xp /usr/lib/libcrypto.so.1.0.0
42d9e000 42da7000 r-xp /usr/lib/libcares.so.2.1.0
42db0000 42dde000 r-xp /usr/lib/libidn.so.11.5.44
42de6000 42e33000 r-xp /usr/lib/libssl.so.1.0.0
42e3f000 42e4a000 r-xp /usr/lib/libgpg-error.so.0.15.0
42e53000 42e55000 r-xp /usr/lib/libiri.so
42e5d000 42e60000 r-xp /lib/libcap.so.2.21
42e68000 42e6f000 r-xp /lib/libcrypt-2.13.so
42e9f000 42ea1000 r-xp /usr/lib/libXau.so.6.0.0
42ea9000 42eb0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
42eba000 42ebc000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
42ec4000 42ecb000 r-xp /usr/lib/libminizip.so.1.0.0
42ed3000 42ee0000 r-xp /usr/lib/libail.so.0.1.0
42ee9000 42eec000 r-xp /lib/libattr.so.1.1.0
4332d000 43b2c000 rw-p [stack:2760]
43b2c000 43b2f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43b37000 43b42000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43e88000 43e9f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
440e9000 440eb000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
450f4000 45a40000 rw-p [stack:2767]
be927000 be948000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2758)
Call Stack Count: 17
 0: getBTStatus + 0x49 (0x400014da) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x14da
 1: update_watch + 0x50 (0x400017ad) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x17ad
 2: create_base_gui + 0x376 (0x40001e07) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1e07
 3: app_create + 0x2c (0x40001669) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1669
 4: (0x400564d5) [/usr/lib/libappcore-watch.so.1] + 0x44d5
 5: (0x4005466b) [/usr/lib/libappcore-watch.so.1] + 0x266b
 6: (0x4094cbff) [/usr/lib/libwidget_provider_app.so.1] + 0x2bff
 7: widget_provider_send_hello_sync + 0x166 (0x42650017) [/usr/lib/libwidget_provider.so.1] + 0x7017
 8: (0x4094cc4b) [/usr/lib/libwidget_provider_app.so.1] + 0x2c4b
 9: widget_provider_init + 0xb8 (0x4264fced) [/usr/lib/libwidget_provider.so.1] + 0x6ced
10: (0x4094d34d) [/usr/lib/libwidget_provider_app.so.1] + 0x334d
11: widget_provider_app_init_sync + 0x2c (0x4094df51) [/usr/lib/libwidget_provider_app.so.1] + 0x3f51
12: watch_core_main + 0xb2 (0x400555e3) [/usr/lib/libappcore-watch.so.1] + 0x35e3
13: watch_app_main + 0xca (0x40056753) [/usr/lib/libappcore-watch.so.1] + 0x4753
14: main + 0xc6 (0x400015d7) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x15d7
15: __libc_start_main + 0x114 (0x4034082c) [/lib/libc.so.6] + 0x1782c
16: (0x40001114) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1114
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
-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [80]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [80] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [81]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [81] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [79]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [82]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [82] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [83]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [83] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [87]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [87] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [88]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [88] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [89]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [89] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [90]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [90] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [91]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [91] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [92]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [92] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [32]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [32]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [32] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [34]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [34]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [34] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [73]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [73] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [77]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [77] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [7]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [2] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [30]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [30] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [3]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [3] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [33]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [33]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [33] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [74]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [74]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [74] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [75]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [75]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [75] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [76]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [76]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [76] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [78]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [78]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [78] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [84]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [84]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [84] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [85]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [85]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [85] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [86]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [86]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [86] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [79]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [79]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [79] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [80]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [80]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [80] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [81]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [81]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [81] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [82]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [82]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [82] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [83]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [83]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [83] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [87]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [87]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [87] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [88]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [88]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [88] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [89]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [89]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [89] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [90]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [90]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [90] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [91]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [91]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [91] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [92]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [92]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [92] to pending list
12-10 21:09:23.630+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppResume(732) > mFirstResumeDone
12-10 21:09:23.630+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:23.630+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [1] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [4] to pending list
12-10 21:09:23.630+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:09:23.695+0900 W/AUL_AMD (  464): amd_request.c: __request_handler(640) > __request_handler: 6
12-10 21:09:23.695+0900 W/AUL_AMD (  464): amd_request.c: __foward_cmd(153) > __forward_cmd: 799 799
12-10 21:09:23.705+0900 I/CAPI_APPFW_APP_CONTROL( 2751): app_control.c: app_control_request_result_broker(189) > app_control_request_result_broker, result: 0
12-10 21:09:23.705+0900 I/healthData( 2751): health_fw_connection.c: __health_service_appcontrol_cb(151) > [1;35mAppcontrol launch result 0[0;m
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.watchface:com.samsung.watchface], client = 2751
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [health-data-service:HEALTH_SERVICE_PORT]
12-10 21:09:23.705+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [health-data-service:HEALTH_SERVICE_PORT]
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 21:09:23.710+0900 I/HealthDataService(  799): health_ipc_server.c: __health_server_ipc_add_client(340) > [1;35mApplication Information is registered in the map:[425A34F0] [com.samsung.watchface][0;m
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.watchface:com.samsung.watchface]
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.watchface:com.samsung.watchface]
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 21:09:23.710+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 21:09:23.720+0900 E/W_HOME  (  723): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-10 21:09:23.735+0900 I/watchface-viewer( 2751): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-10 21:09:23.735+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnLoadingDone(812) > 
12-10 21:09:23.740+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnLoadingDone(815) > idle_watch = [com.samsung.watchface]
12-10 21:09:23.740+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnLoadingDone(823) > idle_watch = [com.samsung.watchface]
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.watch-face-editor:watch-face-editor::localport]
12-10 21:09:23.740+0900 E/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 21:09:23.740+0900 E/MESSAGE_PORT( 2751): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (watch-face-editor::localport) is not found.
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.clocksetting.clock:clocksetting::localport]
12-10 21:09:23.740+0900 E/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 21:09:23.740+0900 E/MESSAGE_PORT( 2751): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (clocksetting::localport) is not found.
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:w-home::localport]
12-10 21:09:23.740+0900 E/MESSAGE_PORT(  437): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-10 21:09:23.740+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 21:09:23.740+0900 E/MESSAGE_PORT( 2751): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (w-home::localport) is not found.
12-10 21:09:23.740+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnLoadingDone(860) > mFirstLoadingDone
12-10 21:09:23.745+0900 W/W_HOME  (  723): clock_view.c: clock_view_attach(512) > changed pause/resume option -> manual
12-10 21:09:23.745+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c884b8), origin_x(0), origin_y(0)
12-10 21:09:23.750+0900 W/W_HOME  (  723): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-10 21:09:23.750+0900 W/W_HOME  (  723): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 21:09:23.765+0900 I/healthData( 2751): health_fw_connection.c: __health_service_connection_cb(192) > [1;35mService Connection status Changed : from [6] to [0][0;m
12-10 21:09:23.780+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c884b8), origin_x(0), origin_y(0)
12-10 21:09:23.785+0900 W/W_HOME  (  723): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-10 21:09:23.790+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-10 21:09:23.795+0900 W/W_HOME  (  723): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 21:09:23.800+0900 W/W_HOME  (  723): clock_view.c: clock_view_attach(529) > changed pause/resume option -> automatic
12-10 21:09:23.800+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-10 21:09:23.805+0900 W/W_HOME  (  723): clock_manager.c: clock_manager_clock_set(255) > attached clock isn't cleaned-up, yet
12-10 21:09:23.805+0900 E/W_HOME  (  723): page.c: _page_clip_del(240) > (!page_info) -> _page_clip_del() return
12-10 21:09:23.805+0900 E/W_HOME  (  723): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
12-10 21:09:23.810+0900 W/W_HOME  (  723): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
12-10 21:09:23.810+0900 E/W_HOME  (  723): dbox.c: del_cb(225) > Add viewer has no info: org.reolab.blackandwhite
12-10 21:09:23.815+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-10 21:09:23.820+0900 W/W_HOME  (  723): clock_service.c: clock_service_event_handler(821) > scroller freeze off
12-10 21:09:23.820+0900 W/W_HOME  (  723): scroller.c: scroller_unfreeze(1860) > unfreezed:4001f5a7
12-10 21:09:23.820+0900 W/W_HOME  (  723): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: com.samsung.watchface 1 0 0 0
12-10 21:09:23.820+0900 E/W_HOME  (  723): clock_service.c: _clock_service_heartbeat_pump(563) > com.samsung.watchface is already attached to home
12-10 21:09:23.820+0900 W/W_HOME  (  723): cfwd.c: cfwd_get_icon_status(362) > 
12-10 21:09:23.820+0900 W/W_HOME  (  723): ============================
12-10 21:09:23.820+0900 W/W_HOME  (  723): multi_sim_category:0
12-10 21:09:23.820+0900 W/W_HOME  (  723): multi_sim_model:0
12-10 21:09:23.820+0900 W/W_HOME  (  723): support_callforward_auto:0
12-10 21:09:23.820+0900 W/W_HOME  (  723): conn_status:1
12-10 21:09:23.820+0900 W/W_HOME  (  723): remote_call_forward_auto:0
12-10 21:09:23.820+0900 W/W_HOME  (  723): auto_call_forward_status:0
12-10 21:09:23.820+0900 W/W_HOME  (  723): support_callforward_reverse:0
12-10 21:09:23.820+0900 W/W_HOME  (  723): reverse_call_forward_auto:0
12-10 21:09:23.820+0900 W/W_HOME  (  723): fwd_type:
12-10 21:09:23.820+0900 W/W_HOME  (  723): ============================
12-10 21:09:23.820+0900 W/W_HOME  (  723): 
12-10 21:09:23.820+0900 W/W_HOME  (  723): clock_view_indicator.c: _view_call_fw_icon(131) > call fwd status:0
12-10 21:09:23.825+0900 E/W_HOME  (  723): clock_event.c: _flightmode_state_get(417) > Failed to get VCONFKEY_TELEPHONY_FLIGHT_MODE:db/telephony/flight_mode
12-10 21:09:23.825+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-10 21:09:23.825+0900 E/W_HOME  (  723): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-10 21:09:23.825+0900 W/W_HOME  (  723): noti_broker.c: _clock_attached_cb(804) > 1
12-10 21:09:23.825+0900 W/W_HOME  (  723): cs_broker.c: _clock_view_attached_cb(231) > 
12-10 21:09:23.830+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-10 21:09:23.830+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-10 21:09:23.840+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-10 21:09:23.855+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-10 21:09:23.865+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-10 21:09:23.875+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-10 21:09:23.875+0900 W/AUL_AMD (  464): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 21:09:23.885+0900 W/AUL_AMD (  464): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2751
12-10 21:09:23.885+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-10 21:09:23.890+0900 W/AUL_AMD (  464): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 21:09:23.905+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-10 21:09:23.920+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-10 21:09:23.935+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-10 21:09:23.945+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [74]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [75]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [76]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [78]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [84]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [85]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [86]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [74]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [75]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [76]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [78]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [84]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [85]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [86]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [74]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [75]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [76]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [78]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [84]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [85]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [86]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [79]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [80]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [81]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [79]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [82]
12-10 21:09:23.950+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [83]
12-10 21:09:23.960+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-10 21:09:23.965+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [87]
12-10 21:09:23.965+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [88]
12-10 21:09:23.975+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-10 21:09:23.980+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [89]
12-10 21:09:23.980+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [90]
12-10 21:09:23.985+0900 E/W_HOME  (  723): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
12-10 21:09:23.990+0900 I/HealthDataService(  799): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-10 21:09:23.995+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [91]
12-10 21:09:23.995+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [92]
12-10 21:09:23.995+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:23.995+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:24.000+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:24.000+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:24.000+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 21:09:24.000+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:09:24.070+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnDummyModeOffTimerExpired(396) > disable dummy mode
12-10 21:09:24.070+0900 I/watchface-viewer( 2751): viewer-impl.cpp: SetDummyMode(95) > dummyMode[0]
12-10 21:09:24.070+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
12-10 21:09:24.070+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: AddPendingChanges(1053) > added [6] to pending list
12-10 21:09:24.070+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
12-10 21:09:24.070+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
12-10 21:09:24.070+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [32]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-part-resource.cpp: SetUpdateImage(1825) > new mThread[0x41947198]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [34]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [73]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [77]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [33]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [74]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [75]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [76]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [78]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [84]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [85]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [86]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [79]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [80]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [81]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [82]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [83]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [87]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [88]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [89]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [90]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [91]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [92]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [1]
12-10 21:09:24.075+0900 I/watchface-viewer( 2751): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [4]
12-10 21:09:24.085+0900 I/watchface-viewer( 2751): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 ']
12-10 21:09:24.085+0900 I/watchface-viewer( 2751): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 72x43
12-10 21:09:24.090+0900 I/watchface-viewer( 2751): viewer-part-resource.cpp: ThreadCallback(1952) > thread[0x41947198]
12-10 21:09:24.090+0900 E/BASE_UTILS( 2751): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
12-10 21:09:24.090+0900 I/watchface-viewer( 2751): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 ']
12-10 21:09:24.100+0900 I/watchface-viewer( 2751): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 26x24
12-10 21:09:24.100+0900 I/watchface-viewer( 2751): viewer-part-resource.cpp: ThreadNotifyCallback(2014) > thread[0x41947198]
12-10 21:09:24.105+0900 I/watchface-viewer( 2751): viewer-part-resource.cpp: ThreadEndCallback(2050) > thread[0x41947198]
12-10 21:09:24.105+0900 I/watchface-viewer( 2751): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-10 21:09:24.200+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:24.200+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:24.400+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:24.400+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:24.600+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:24.600+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:24.620+0900 I/watchface-viewer( 2751): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
12-10 21:09:24.620+0900 I/watchface-viewer( 2751): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
12-10 21:09:24.620+0900 I/watchface-viewer( 2751): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
12-10 21:09:24.620+0900 I/watchface-viewer( 2751): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
12-10 21:09:24.620+0900 I/watchface-viewer( 2751): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
12-10 21:09:24.620+0900 I/watchface-viewer( 2751): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
12-10 21:09:24.620+0900 I/watchface-viewer( 2751): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
12-10 21:09:24.620+0900 I/watchface-viewer( 2751): viewer-rotatable.cpp: DummyAnimationFinished(347) > 
12-10 21:09:24.620+0900 I/watchface-viewer( 2751): viewer-view.cpp: DummyModeAnimationFinished(360) > 
12-10 21:09:24.735+0900 I/AUL_PAD ( 2800): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-10 21:09:24.800+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:24.810+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:24.945+0900 W/CRASH_MANAGER( 2697): worker.c: worker_job(1199) > 1102710626c611449749357
12-10 21:09:25.000+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:25.000+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:25.200+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:25.200+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:25.400+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:25.400+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:25.600+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:25.600+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:25.800+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:25.800+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:26.000+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:26.000+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:26.205+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:26.205+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:26.405+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:26.405+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:26.605+0900 I/CAPI_WATCH_APPLICATION( 2751): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:26.605+0900 E/watchface-loader( 2751): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:26.695+0900 W/CRASH_MANAGER( 2697): worker.c: worker_job(1199) > 1102758626c61144974936
