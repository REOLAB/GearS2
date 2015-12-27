S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 6247
Date: 2015-12-09 22:42:45+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1a1

Register Information
r0   = 0x00000195, r1   = 0x0000000d
r2   = 0x00000005, r3   = 0x41553194
r4   = 0x00000195, r5   = 0x00000000
r6   = 0x414e8eac, r7   = 0x414dd808
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbed3fc5c, sp   = 0xbed3fc10
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   489992 KB
MemFree:     17932 KB
Buffers:     20628 KB
Cached:     182404 KB
VmPeak:     111464 KB
VmSize:     110952 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16032 KB
VmRSS:       16032 KB
VmData:      54424 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6247 TID = 6247
6247 7509 7520 

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
43757000 43f56000 rw-p [stack:7509]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45255000 45b00000 rw-p [stack:7520]
bed20000 bed41000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6247)
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
 bar move:1
12-09 22:42:04.485+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:42:04.485+0900 E/W_INDICATOR(  684): windicator_util.c: _ecore_event_client_message_cb(1030) > [_ecore_event_client_message_cb:1030] quickpanel 1
12-09 22:42:04.570+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.570+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.570+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.580+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.580+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.580+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.595+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.595+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.595+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.605+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.605+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.605+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.615+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.615+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.615+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.625+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.625+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.625+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.640+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.640+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.640+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.650+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.650+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.650+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.670+0900 E/EFL     (  364): <364> e_mod_processmgr.c:495 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
12-09 22:42:04.670+0900 E/EFL     (  364): evas_main<364> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=1584729 button=1 downs=0
12-09 22:42:04.685+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.685+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.685+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.700+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.700+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.700+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.715+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.715+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.715+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.730+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.730+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.730+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.750+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.750+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.750+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.765+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.765+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.765+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.780+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.780+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.780+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.800+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.800+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.800+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.815+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.815+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.815+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.830+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.830+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.830+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.850+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.850+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.850+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.865+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.865+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.865+0900 E/EFL     (  364): evas_main<364> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-09 22:42:04.885+0900 E/W_INDICATOR(  684): windicator_util.c: _ecore_event_client_message_cb(1052) > [_ecore_event_client_message_cb:1052] quickpanel 0
12-09 22:42:04.885+0900 E/W_INDICATOR(  684): windicator_util.c: _ecore_event_client_message_cb(899) > [_ecore_event_client_message_cb:899] quickpanel is closed
12-09 22:42:04.890+0900 W/W_HOME  (  715): event_manager.c: _ecore_x_message_cb(415) > moment bar move:0
12-09 22:42:04.890+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:42:04.890+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:42:04.895+0900 W/W_INDICATOR(  684): windicator_message_port.c: _mp_messageport_register(318) > [_mp_messageport_register:318] Used message-port
12-09 22:42:04.895+0900 E/CAPI_APPFW_APP_CONTROL( 1073): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 22:42:04.895+0900 W/MUSIC_CONTROL_SERVICE( 1073): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1073]   value = [false][0m
12-09 22:42:04.895+0900 I/MESSAGE_PORT(  684): MessagePortProxy.cpp: IsLocalPortRegisted(675) > MessagePort name is already registered.
12-09 22:42:04.895+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:42:04.895+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:42:04.895+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:42:04.895+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
12-09 22:42:04.895+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
12-09 22:42:04.895+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:42:04.895+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.windicator:music-control-service-message-port], client = 684
12-09 22:42:04.895+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:42:04.900+0900 E/W_INDICATOR(  684): windicator_moment_bar.c: windicator_moment_bar_hide(1484) > [windicator_moment_bar_hide:1484] Hide Moment Bar : dynamic_layout(0x445fe4d8)
12-09 22:42:04.900+0900 I/efl-extension(  684): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x445f0e10, elm_layout, _activated_obj : 0x0, activated : 0
12-09 22:42:04.900+0900 I/efl-extension(  684): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-09 22:42:04.900+0900 I/efl-extension(  684): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x445f0e10, elm_layout, func : 0x4000d729
12-09 22:42:04.900+0900 I/efl-extension(  684): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-09 22:42:04.905+0900 E/W_INDICATOR(  684): windicator_connection.c: windi_connection_pause(1552) > [windi_connection_pause:1552] There is no handle
12-09 22:42:04.905+0900 W/PROCESSMGR(  364): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
12-09 22:42:04.910+0900 W/WATCH_CORE( 6043): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
12-09 22:42:04.910+0900 I/WATCH_CORE( 6043): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
12-09 22:42:04.915+0900 W/W_HOME  (  715): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
12-09 22:42:04.915+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:42:04.915+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:42:04.920+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:42:04.920+0900 W/W_HOME  (  715): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
12-09 22:42:04.925+0900 I/GESTURE (  134): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-09 22:42:04.975+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:42:04.990+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 715
12-09 22:42:05.000+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:05.005+0900 I/MALI    (  715): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442b71c0] swap changed from async to sync
12-09 22:42:05.020+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:05.020+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:05.035+0900 I/APP_CORE(  684): appcore-efl.c: __do_app(429) > [APP 684] Event: PAUSE State: RUNNING
12-09 22:42:05.035+0900 I/CAPI_APPFW_APPLICATION(  684): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-09 22:42:06.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:06.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:06.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:06.415+0900 I/APP_CORE( 1161): appcore-efl.c: __do_app(429) > [APP 1161] Event: MEM_FLUSH State: PAUSED
12-09 22:42:07.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:07.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:07.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:08.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:08.050+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:08.050+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:09.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:09.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:09.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:10.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:10.045+0900 I/APP_CORE(  684): appcore-efl.c: __do_app(429) > [APP 684] Event: MEM_FLUSH State: PAUSED
12-09 22:42:10.065+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:10.065+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:11.010+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:11.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:11.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:12.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:12.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:12.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:13.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:13.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:13.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:14.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:14.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:14.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:15.010+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:15.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:15.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:16.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:16.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:16.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:17.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:17.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:17.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:18.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:18.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:18.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:19.010+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:19.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:19.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:20.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:20.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:20.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:21.010+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:21.070+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:21.070+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:22.010+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:22.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:22.065+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:23.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:23.065+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:23.065+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:24.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:24.035+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:24.035+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:25.010+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:25.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:25.055+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:26.010+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:26.025+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:26.025+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:27.005+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:27.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:27.060+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:28.000+0900 I/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:28.025+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:28.025+0900 E/CAPI_NETWORK_WIFI( 6043): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:28.365+0900 E/PKGMGR_SERVER( 7495): pkgmgr-server.c: main(2126) > package manager server start
12-09 22:42:28.445+0900 E/PKGMGR_SERVER( 7495): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1121729982], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-09 22:42:28.450+0900 E/PKGMGR_SERVER( 7496): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-09 22:42:28.455+0900 E/PKGMGR  ( 7493): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-09 22:42:28.515+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:42:28.525+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6043
12-09 22:42:28.530+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 22:42:28.535+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 5
12-09 22:42:28.535+0900 W/CAPI_WATCH_APPLICATION( 6043): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-09 22:42:28.540+0900 W/WATCH_CORE( 6043): appcore-watch.c: __widget_destroy(992) > widget_destory
12-09 22:42:28.540+0900 E/WIDGET_PROVIDER_APP( 6043): client.c: client_fini(1175) > Provider is not initialized
12-09 22:42:28.540+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 22
12-09 22:42:28.540+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(884) > app status : 4
12-09 22:42:28.540+0900 W/AUL_AMD (  534): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(6043), cmd(4)
12-09 22:42:28.540+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 4
12-09 22:42:28.555+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:42:28.565+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-09 22:42:28.570+0900 E/PKGMGR_SERVER( 7496): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-09 22:42:28.590+0900 E/PKGMGR_SERVER( 7495): pkgmgr-server.c: sighandler(445) > child NORMAL exit [7496]
12-09 22:42:28.790+0900 E/AUL_AMD (  534): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-09 22:42:28.795+0900 W/AUL_AMD (  534): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(6043), cmd(4)
12-09 22:42:28.830+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 0
12-09 22:42:28.950+0900 I/AUL_AMD (  534): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 22:42:29.025+0900 I/AUL_AMD (  534): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 22:42:29.025+0900 E/AUL_AMD (  534): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-09 22:42:29.025+0900 W/AUL_AMD (  534): amd_launch.c: _start_app(1659) > caller pid : 685
12-09 22:42:29.265+0900 W/AUL_AMD (  534): amd_launch.c: _start_app(2026) > pad pid(-5)
12-09 22:42:29.265+0900 E/RESOURCED(  535): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 1
12-09 22:42:29.265+0900 E/RESOURCED(  535): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-09 22:42:29.265+0900 W/AUL_PAD ( 1158): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-09 22:42:29.265+0900 W/AUL_PAD ( 1158): launchpad.c: __send_result_to_caller(265) > Check app launching
12-09 22:42:29.310+0900 I/CAPI_WATCH_APPLICATION( 6247): watch_app_main.c: watch_app_main(382) > watch_app_main
12-09 22:42:29.330+0900 E/TBM     ( 6247): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-09 22:42:29.365+0900 I/AUL_AMD (  534): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 6043
12-09 22:42:29.405+0900 W/WATCH_CORE( 6247): appcore-watch.c: __widget_create(958) > widget_create
12-09 22:42:29.405+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [37.319309] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_37.319309.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263070:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-09 22:42:29.405+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[37.319309] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_37.319309.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263070:4] gbar_fname[]
12-09 22:42:29.425+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-09 22:42:29.425+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-09 22:42:29.565+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:29.565+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:29.655+0900 W/WATCH_CORE( 6247): appcore-watch.c: __widget_create(976) > widget_create done
12-09 22:42:29.685+0900 I/WATCH_CORE( 6247): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-09 22:42:29.685+0900 I/WATCH_CORE( 6247): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-09 22:42:29.685+0900 I/WATCH_CORE( 6247): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-09 22:42:29.740+0900 W/WATCH_CORE( 6247): appcore-watch.c: __widget_resume(1012) > widget_resume
12-09 22:42:29.745+0900 I/CAPI_WATCH_APPLICATION( 6247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:29.750+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:29.750+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:30.000+0900 I/CAPI_WATCH_APPLICATION( 6247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:30.000+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:30.000+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:30.370+0900 W/AUL_AMD (  534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 22:42:30.370+0900 W/AUL_AMD (  534): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-09 22:42:30.380+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 22:42:30.390+0900 W/AUL_AMD (  534): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6247
12-09 22:42:30.390+0900 W/AUL_AMD (  534): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 22:42:30.540+0900 W/AUL_AMD (  534): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-09 22:42:30.600+0900 I/AUL_PAD ( 7535): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-09 22:42:30.930+0900 E/PKGMGR_SERVER( 7495): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-09 22:42:30.940+0900 E/PKGMGR_SERVER( 7495): pkgmgr-server.c: main(2180) > package manager server terminated.
12-09 22:42:31.000+0900 I/CAPI_WATCH_APPLICATION( 6247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:31.030+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:31.030+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:32.005+0900 I/CAPI_WATCH_APPLICATION( 6247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:32.025+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:32.030+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:33.000+0900 I/CAPI_WATCH_APPLICATION( 6247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:33.005+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:33.005+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:34.000+0900 I/CAPI_WATCH_APPLICATION( 6247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 22:42:34.035+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 22:42:34.040+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-09 22:42:34.040+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 1
12-09 22:42:34.040+0900 W/W_HOME  (  715): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-09 22:42:34.040+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:42:34.050+0900 W/STARTER (  683): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-09 22:42:34.050+0900 W/STARTER (  683): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-09 22:42:34.050+0900 E/STARTER (  683): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 22:42:34.050+0900 W/STARTER (  683): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-09 22:42:34.050+0900 W/STARTER (  683): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-09 22:42:34.100+0900 I/SCONTEXT-LIB(  644): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-09 22:42:34.100+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_initialize(63) > Access denied
12-09 22:42:34.100+0900 E/CAPI_NETWORK_WIFI( 6247): net_wifi.c: wifi_deinitialize(80) > Not initialized
12-09 22:42:34.150+0900 W/WAKEUP-SERVICE( 1116): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318512[0;m
12-09 22:42:34.185+0900 W/WAKEUP-SERVICE( 1116): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-09 22:42:34.190+0900 I/TIZEN_N_SOUND_MANAGER( 1116): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-09 22:42:34.275+0900 W/WATCH_CORE( 6247): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-09 22:42:34.275+0900 I/WATCH_CORE( 6247): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-09 22:42:34.285+0900 I/TIZEN_N_SOUND_MANAGER( 1116): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-09 22:42:34.285+0900 W/TIZEN_N_SOUND_MANAGER( 1116): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-09 22:42:34.285+0900 W/WAKEUP-SERVICE( 1116): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-09 22:42:34.285+0900 I/HIGEAR  ( 1116): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-09 22:42:34.470+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: PAUSE State: RUNNING
12-09 22:42:34.470+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-09 22:42:34.470+0900 W/W_HOME  (  715): main.c: _appcore_pause_cb(690) > appcore pause
12-09 22:42:34.470+0900 W/W_HOME  (  715): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-09 22:42:34.470+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:42:34.470+0900 W/STARTER (  683): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-09 22:42:34.470+0900 W/STARTER (  683): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-09 22:42:34.470+0900 W/STARTER (  683): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-09 22:42:34.470+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:42:34.470+0900 W/STARTER (  683): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-09 22:42:34.470+0900 W/W_HOME  (  715): main.c: home_pause(751) > clock/widget paused
12-09 22:42:34.470+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 22:42:34.475+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:42:34.475+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:42:34.475+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:42:34.475+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 22:42:34.475+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 22:42:34.475+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:42:34.475+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 22:42:34.475+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:42:34.505+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 22:42:34.505+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 22:42:34.505+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 22:42:34.505+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 22:42:34.505+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 22:42:34.505+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 22:42:34.505+0900 I/MESSAGE_PORT(  443): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 22:42:34.505+0900 I/MESSAGE_PORT(  443): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 22:42:34.505+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 22:42:34.505+0900 I/MESSAGE_PORT(  443): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 22:42:34.525+0900 I/GESTURE (  134): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-09 22:42:34.545+0900 W/MUSIC_CONTROL_SERVICE( 1073): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1073]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-09 22:42:34.590+0900 E/CAPI_APPFW_APP_CONTROL( 1073): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 22:42:34.610+0900 W/MUSIC_CONTROL_SERVICE( 1073): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1073]   value = [false][0m
12-09 22:42:34.655+0900 I/SHealth_Common( 1065): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-09 22:42:34.655+0900 W/WATCH_CORE( 6247): appcore-watch.c: __widget_pause(1001) > widget_pause
12-09 22:42:34.670+0900 I/SHealth_Service( 1065): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-09 22:42:35.020+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-09 22:42:39.520+0900 E/PKGMGR  ( 7658): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-09 22:42:39.535+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-09 22:42:39.680+0900 E/PKGMGR_SERVER( 7660): pkgmgr-server.c: main(2126) > package manager server start
12-09 22:42:39.750+0900 E/PKGMGR_SERVER( 7660): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1133022789], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_1133022789' '-r' 'org.reolab.blackandwhite'], cookie=[m8suCyb7W34c7y1v/JrEnVVcI1Y=], backend_flag=[0]
12-09 22:42:39.755+0900 E/PKGMGR  ( 7660): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-09 22:42:39.755+0900 E/PKGMGR_SERVER( 7660): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-09 22:42:39.760+0900 E/PKGMGR  ( 7658): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[76580002]
12-09 22:42:39.760+0900 E/PKGMGR_SERVER( 7661): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-09 22:42:39.820+0900 E/SHealth_Common( 1065): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-09 22:42:39.925+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-09 22:42:39.930+0900 W/AUL_AMD (  534): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-09 22:42:39.945+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-09 22:42:39.950+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 22:42:40.550+0900 E/PKGMGR_CERT( 7661): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-09 22:42:40.560+0900 E/PKGMGR_CERT( 7661): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-09 22:42:40.560+0900 E/PKGMGR_CERT( 7661): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-09 22:42:40.560+0900 E/PKGMGR_CERT( 7661): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-09 22:42:40.565+0900 E/PKGMGR_CERT( 7661): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-09 22:42:40.565+0900 E/PKGMGR_CERT( 7661): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-09 22:42:40.565+0900 E/PKGMGR_CERT( 7661): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-09 22:42:40.570+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 22:42:40.585+0900 E/PKGMGR_CERT( 7661): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-09 22:42:41.930+0900 E/PKGMGR_SERVER( 7660): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-09 22:42:42.725+0900 E/rpm-installer( 7661): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-09 22:42:43.930+0900 E/PKGMGR_SERVER( 7660): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-09 22:42:45.695+0900 E/PKGMGR_SERVER( 7660): pkgmgr-server.c: sighandler(445) > child NORMAL exit [7661]
12-09 22:42:45.710+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 22:42:45.730+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-09 22:42:45.730+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-09 22:42:45.755+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-09 22:42:45.755+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-09 22:42:45.755+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-09 22:42:45.755+0900 E/WMS     (  529): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-09 22:42:45.830+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-09 22:42:45.895+0900 E/PKGMGR_INFO(  527): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-09 22:42:45.915+0900 E/APPS    (  715): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-09 22:42:45.930+0900 E/PKGMGR_SERVER( 7660): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-09 22:42:45.930+0900 E/PKGMGR_SERVER( 7660): pkgmgr-server.c: main(2180) > package manager server terminated.
12-09 22:42:46.105+0900 W/CRASH_MANAGER( 7665): worker.c: worker_job(1199) > 1106247626c61144966856
