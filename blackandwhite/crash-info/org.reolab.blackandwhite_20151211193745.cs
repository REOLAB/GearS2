S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 1942
Date: 2015-12-11 19:37:45+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x700

Register Information
r0   = 0x000006f4, r1   = 0x0000000d
r2   = 0x00000544, r3   = 0x41453194
r4   = 0x000006f4, r5   = 0x00000000
r6   = 0x41bd1ce4, r7   = 0x41bab008
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbe8c0c4c, sp   = 0xbe8c0c00
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     14380 KB
Buffers:     24796 KB
Cached:     193704 KB
VmPeak:     119876 KB
VmSize:     119364 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15972 KB
VmRSS:       15972 KB
VmData:      62836 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 1942 TID = 1942
1942 2101 2113 

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
41819000 41956000 r-xp /usr/lib/libicui18n.so.51.1
41966000 41a4a000 r-xp /usr/lib/libicuuc.so.51.1
41a5f000 41a65000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41a6d000 41a73000 r-xp /usr/lib/libwidget.so.1.0.0
41a7c000 41a81000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a89000 41aa2000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41aab000 41ab0000 r-xp /usr/lib/libcsc-feature.so.0.0.0
41ab8000 41bec000 rw-p [heap]
41bec000 41c23000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41c2c000 41c56000 r-xp /usr/lib/libnfc.so.1.0.0
41c5f000 41c90000 r-xp /usr/lib/libmdm.so.1.1.85
41c98000 41cae000 r-xp /usr/lib/libnetwork.so.0.0.0
4323e000 43247000 r-xp /usr/lib/libcom-core.so.0.0.1
43250000 4325c000 r-xp /usr/lib/libwidget_service.so.1.0.0
43264000 4326d000 r-xp /usr/lib/libwidget_provider.so.1.0.0
43276000 4327c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43284000 4328c000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43294000 432c2000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
432ce000 432d6000 r-xp /usr/lib/libdrm.so.2.4.0
432de000 432e0000 r-xp /usr/lib/libdri2.so.0.0.0
432e8000 432ef000 r-xp /usr/lib/libtbm.so.1.0.0
432f7000 43311000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4331a000 43321000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4332a000 4332c000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43334000 4333b000 r-xp /usr/lib/libminizip.so.1.0.0
43343000 43350000 r-xp /usr/lib/libail.so.0.1.0
4378b000 43f8a000 rw-p [stack:2101]
43f8a000 43f8d000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f95000 43fa0000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
44028000 4403f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4427e000 44280000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45a89000 46300000 rw-p [stack:2113]
be8a1000 be8c2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1942)
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
interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:13.325+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(226) ev->cur.canvas.y(180)
12-11 19:36:13.325+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:13.335+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=141817 button=1 downs=1
12-11 19:36:13.340+0900 E/EFL     (  714): evas_main<714> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=141817 device=10 downs=0
12-11 19:36:13.350+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=141765 button=1 downs=1
12-11 19:36:13.350+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=141765 device=10 downs=2
12-11 19:36:13.360+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=141828 button=1 downs=1
12-11 19:36:13.380+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=141828 device=10 downs=0
12-11 19:36:13.540+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-11 19:36:13.540+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:13.540+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(92) ev->cur.canvas.y(173)
12-11 19:36:13.540+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:13.540+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=142025 button=1 downs=1
12-11 19:36:13.545+0900 E/EFL     (  714): evas_main<714> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=142025 device=10 downs=2
12-11 19:36:13.550+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:13.550+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(93) ev->cur.canvas.y(173)
12-11 19:36:13.550+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:13.565+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=142029 button=1 downs=1
12-11 19:36:13.585+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=142030 device=10 downs=2
12-11 19:36:13.590+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:13.590+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(94) ev->cur.canvas.y(175)
12-11 19:36:13.590+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:13.605+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=142089 button=1 downs=1
12-11 19:36:13.605+0900 E/EFL     (  714): evas_main<714> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=142089 device=10 downs=0
12-11 19:36:13.610+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=142092 button=1 downs=1
12-11 19:36:13.630+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=142092 device=10 downs=0
12-11 19:36:13.810+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-11 19:36:13.810+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:13.810+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(100) ev->cur.canvas.y(180)
12-11 19:36:13.810+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:13.815+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=142296 button=1 downs=1
12-11 19:36:13.815+0900 E/EFL     (  714): evas_main<714> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=142296 device=10 downs=2
12-11 19:36:13.820+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:13.820+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(100) ev->cur.canvas.y(179)
12-11 19:36:13.820+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:13.835+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=142300 button=1 downs=1
12-11 19:36:13.855+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=142301 device=10 downs=2
12-11 19:36:13.865+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:13.865+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(100) ev->cur.canvas.y(180)
12-11 19:36:13.865+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:13.875+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=142361 button=1 downs=1
12-11 19:36:13.875+0900 E/EFL     (  714): evas_main<714> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=142361 device=10 downs=0
12-11 19:36:13.880+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=142363 button=1 downs=1
12-11 19:36:13.900+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=142364 device=10 downs=0
12-11 19:36:14.050+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-11 19:36:14.055+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:14.055+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(97) ev->cur.canvas.y(183)
12-11 19:36:14.055+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:14.055+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=142538 button=1 downs=1
12-11 19:36:14.060+0900 E/EFL     (  714): evas_main<714> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=142539 device=10 downs=2
12-11 19:36:14.060+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:14.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(97) ev->cur.canvas.y(182)
12-11 19:36:14.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:14.080+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=142545 button=1 downs=1
12-11 19:36:14.100+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=142547 device=10 downs=2
12-11 19:36:14.115+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=142602 button=1 downs=1
12-11 19:36:14.120+0900 E/EFL     (  714): evas_main<714> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=142602 device=10 downs=0
12-11 19:36:14.125+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=142604 button=1 downs=1
12-11 19:36:14.145+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=142605 device=10 downs=0
12-11 19:36:14.290+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-11 19:36:14.295+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:14.295+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(98) ev->cur.canvas.y(180)
12-11 19:36:14.295+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:14.295+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=142778 button=1 downs=1
12-11 19:36:14.295+0900 E/EFL     (  714): evas_main<714> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=142778 device=10 downs=2
12-11 19:36:14.300+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:14.300+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(98) ev->cur.canvas.y(178)
12-11 19:36:14.300+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:14.320+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=142782 button=1 downs=1
12-11 19:36:14.340+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=142783 device=10 downs=2
12-11 19:36:14.355+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=142842 button=1 downs=1
12-11 19:36:14.360+0900 E/EFL     (  714): evas_main<714> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=142842 device=10 downs=0
12-11 19:36:14.360+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=142844 button=1 downs=1
12-11 19:36:14.380+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=142846 device=10 downs=0
12-11 19:36:14.480+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
12-11 19:36:14.480+0900 W/WATCH_CORE( 1210): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 1
12-11 19:36:14.480+0900 I/WATCH_CORE( 1210): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
12-11 19:36:14.480+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: OnReceiveGestureChanged(928) > [0;32mINFO: wakeup receive data : 1124318360[0;m
12-11 19:36:14.480+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-11 19:36:14.480+0900 I/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-11 19:36:14.490+0900 W/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-11 19:36:14.490+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-11 19:36:14.495+0900 I/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-11 19:36:14.495+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:14.495+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(115) ev->cur.canvas.y(179)
12-11 19:36:14.495+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:14.500+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=142979 button=1 downs=1
12-11 19:36:14.500+0900 I/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-11 19:36:14.500+0900 E/EFL     (  714): evas_main<714> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=142979 device=10 downs=2
12-11 19:36:14.505+0900 W/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-11 19:36:14.505+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-11 19:36:14.505+0900 I/HIGEAR  ( 1106): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-11 19:36:14.515+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:14.515+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(116) ev->cur.canvas.y(179)
12-11 19:36:14.515+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:14.525+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=142989 button=1 downs=1
12-11 19:36:14.545+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 19:36:14.545+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(111) ev->cur.canvas.y(179)
12-11 19:36:14.545+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 19:36:14.545+0900 E/EFL     (  714): evas_main<714> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=143031 device=10 downs=1
12-11 19:36:14.550+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=142990 device=10 downs=2
12-11 19:36:14.555+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=143042 button=1 downs=0
12-11 19:36:14.570+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=143033 device=10 downs=1
12-11 19:36:14.590+0900 E/EFL     ( 1210): evas_main<1210> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=143046 button=1 downs=0
12-11 19:36:15.060+0900 W/W_HOME  (  714): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
12-11 19:36:19.135+0900 I/DOWNLOAD_PROVIDER(  845): download-provider-client-manager.c: dp_client_manager(738) > client-manager's working is done
12-11 19:36:19.140+0900 W/WIFI_DIRECT_MANAGER( 1019): wifi-direct-client.c: wfd_client_process_request(869) > Client request [3:WIFI_DIRECT_CMD_DEREGISTER], 28 bytes read from socket[6]
12-11 19:36:19.245+0900 I/CAPI_NETWORK_CONNECTION(  845): connection.c: __connection_set_type_changed_callback(163) > Successfully de-registered(0)
12-11 19:36:19.285+0900 I/CAPI_NETWORK_CONNECTION(  845): connection.c: __connection_set_ip_changed_callback(248) > Successfully de-registered(0)
12-11 19:36:19.320+0900 I/CAPI_NETWORK_CONNECTION(  845): connection.c: connection_destroy(390) > Destroy handle: 0x4250e5c0
12-11 19:36:19.355+0900 I/DOWNLOAD_PROVIDER(  845): download-provider-main.c: main(64) > download-provider's working is done
12-11 19:36:21.115+0900 W/WATCH_CORE( 1210): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-11 19:36:21.140+0900 W/W_HOME  (  714): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-11 19:36:21.140+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-11 19:36:21.140+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 1
12-11 19:36:21.140+0900 W/W_HOME  (  714): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-11 19:36:21.140+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:36:21.160+0900 W/STARTER (  701): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-11 19:36:21.160+0900 W/STARTER (  701): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-11 19:36:21.160+0900 E/STARTER (  701): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-11 19:36:21.160+0900 W/STARTER (  701): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-11 19:36:21.160+0900 W/STARTER (  701): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-11 19:36:21.160+0900 I/WATCH_CORE( 1210): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-11 19:36:21.165+0900 I/SCONTEXT-LIB(  648): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-11 19:36:21.195+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-11 19:36:21.195+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-11 19:36:21.220+0900 I/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-11 19:36:21.300+0900 I/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-11 19:36:21.305+0900 W/TIZEN_N_SOUND_MANAGER( 1106): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-11 19:36:21.305+0900 W/WAKEUP-SERVICE( 1106): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-11 19:36:21.305+0900 I/HIGEAR  ( 1106): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-11 19:36:21.395+0900 I/SHealth_Common( 1049): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-11 19:36:21.395+0900 I/SHealth_Service( 1049): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-11 19:36:21.395+0900 W/MUSIC_CONTROL_SERVICE(  819): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:819]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-11 19:36:21.455+0900 W/STARTER (  701): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-11 19:36:21.455+0900 W/STARTER (  701): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-11 19:36:21.455+0900 W/STARTER (  701): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-11 19:36:21.455+0900 W/STARTER (  701): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-11 19:36:21.465+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: PAUSE State: RUNNING
12-11 19:36:21.465+0900 I/CAPI_APPFW_APPLICATION(  714): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-11 19:36:21.465+0900 W/W_HOME  (  714): main.c: _appcore_pause_cb(690) > appcore pause
12-11 19:36:21.465+0900 W/W_HOME  (  714): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-11 19:36:21.465+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:36:21.480+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:36:21.480+0900 W/W_HOME  (  714): main.c: home_pause(751) > clock/widget paused
12-11 19:36:21.480+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 19:36:21.485+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 19:36:21.490+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 19:36:21.490+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 19:36:21.490+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 19:36:21.490+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 19:36:21.490+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 19:36:21.490+0900 E/CAPI_APPFW_APP_CONTROL(  819): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-11 19:36:21.490+0900 W/MUSIC_CONTROL_SERVICE(  819): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:819]   value = [false][0m
12-11 19:36:21.495+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 19:36:21.515+0900 I/GESTURE (  143): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-11 19:36:22.010+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: MEM_FLUSH State: PAUSED
12-11 19:36:24.580+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 19:36:26.605+0900 I/APP_CORE(  714): appcore-efl.c: __do_app(429) > [APP 714] Event: MEM_FLUSH State: PAUSED
12-11 19:36:30.945+0900 E/PKGMGR  ( 1909): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 19:36:31.115+0900 E/PKGMGR_SERVER( 1911): pkgmgr-server.c: main(2126) > package manager server start
12-11 19:36:31.195+0900 E/PKGMGR_SERVER( 1911): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-444305153], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-444305153' '-r' 'org.reolab.blackandwhite'], cookie=[U/ZZxfZw5MZ0/CsZ1eBmjVv75Hg=], backend_flag=[0]
12-11 19:36:31.200+0900 E/PKGMGR  ( 1911): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 19:36:31.200+0900 E/PKGMGR_SERVER( 1911): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 19:36:31.205+0900 E/PKGMGR  ( 1909): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[19090002]
12-11 19:36:31.205+0900 E/PKGMGR_SERVER( 1912): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 19:36:31.395+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 19:36:31.405+0900 W/AUL_AMD (  475): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 19:36:31.415+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 19:36:31.420+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:36:32.160+0900 E/PKGMGR_CERT( 1912): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 19:36:32.165+0900 E/PKGMGR_CERT( 1912): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
12-11 19:36:32.170+0900 E/PKGMGR_CERT( 1912): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
12-11 19:36:32.170+0900 E/PKGMGR_CERT( 1912): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-11 19:36:32.170+0900 E/PKGMGR_CERT( 1912): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-11 19:36:32.170+0900 E/PKGMGR_CERT( 1912): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-11 19:36:32.175+0900 E/PKGMGR_CERT( 1912): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-11 19:36:32.180+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:36:32.195+0900 E/PKGMGR_CERT( 1912): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 19:36:33.515+0900 E/PKGMGR_SERVER( 1911): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:36:34.485+0900 E/rpm-installer( 1912): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-11 19:36:35.515+0900 E/PKGMGR_SERVER( 1911): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:36:37.490+0900 E/PKGMGR_SERVER( 1911): pkgmgr-server.c: sighandler(445) > child NORMAL exit [1912]
12-11 19:36:37.500+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:36:37.550+0900 E/PKGMGR_SERVER( 1911): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 19:36:37.550+0900 E/PKGMGR_SERVER( 1911): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 19:36:37.575+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-11 19:36:37.575+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-11 19:36:37.575+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-11 19:36:37.575+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-11 19:36:37.575+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-11 19:36:37.575+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-11 19:36:37.630+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-11 19:36:37.750+0900 E/PKGMGR_INFO(  479): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-11 19:36:37.760+0900 E/APPS    (  714): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-11 19:36:37.925+0900 W/CRASH_MANAGER( 1916): worker.c: worker_job(1199) > 1101210626c611449830197
12-11 19:36:38.000+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 19:36:38.000+0900 E/AUL_AMD (  475): amd_request.c: __app_process_by_pid(193) > pid(1210) is dead. cmd(4) is canceled
12-11 19:36:38.005+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 19:36:38.025+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:36:38.040+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:36:38.040+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 19:36:38.040+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 703
12-11 19:36:38.160+0900 E/RESOURCED(  481): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-11 19:36:38.160+0900 E/RESOURCED(  481): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 19:36:38.165+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 19:36:38.170+0900 W/AUL_PAD ( 1208): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 19:36:38.170+0900 W/AUL_PAD ( 1208): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 19:36:38.215+0900 I/CAPI_WATCH_APPLICATION( 1711): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 19:36:38.235+0900 E/TBM     ( 1711): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 19:36:38.270+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1210
12-11 19:36:38.315+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1712) > [SECURE_LOG] [14.824063] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263016:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 19:36:38.315+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[14.824063] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263016:4] gbar_fname[]
12-11 19:36:38.315+0900 W/WATCH_CORE( 1711): appcore-watch.c: __widget_create(958) > widget_create
12-11 19:36:38.330+0900 E/WIDGET_VIEWER(  714): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 19:36:38.330+0900 E/WIDGET_EVAS(  714): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 19:36:38.460+0900 I/CAPI_NETWORK_WIFI( 1711): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:36:38.470+0900 I/CAPI_NETWORK_WIFI( 1711): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:36:38.635+0900 W/WATCH_CORE( 1711): appcore-watch.c: __widget_create(976) > widget_create done
12-11 19:36:38.660+0900 I/WATCH_CORE( 1711): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 19:36:38.660+0900 I/WATCH_CORE( 1711): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 19:36:38.660+0900 I/WATCH_CORE( 1711): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 19:36:38.705+0900 W/W_HOME  (  714): gesture.c: _widget_updated_cb(190) > widget updated
12-11 19:36:38.705+0900 W/W_HOME  (  714): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-11 19:36:38.705+0900 W/W_HOME  (  714): gesture.c: _manual_render(176) > 
12-11 19:36:38.715+0900 W/W_HOME  (  714): gesture.c: _manual_render(176) > 
12-11 19:36:38.740+0900 W/W_HOME  (  714): gesture.c: _manual_render_enable(133) > 0
12-11 19:36:39.270+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 19:36:39.270+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 19:36:39.285+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:36:39.295+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1711
12-11 19:36:39.295+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:36:39.510+0900 I/AUL_PAD ( 1942): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 19:37:13.100+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 19:37:13.100+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 19:37:22.855+0900 E/PKGMGR_SERVER( 2098): pkgmgr-server.c: main(2126) > package manager server start
12-11 19:37:22.945+0900 E/PKGMGR_SERVER( 2098): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-392620028], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 19:37:22.950+0900 E/PKGMGR_SERVER( 2099): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 19:37:22.955+0900 E/PKGMGR  ( 2096): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 19:37:23.020+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:37:23.030+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1711
12-11 19:37:23.035+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:37:23.035+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 19:37:23.040+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(15), pid(1711), cmd(4)
12-11 19:37:23.045+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:37:23.045+0900 W/CAPI_WATCH_APPLICATION( 1711): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 19:37:23.045+0900 W/WATCH_CORE( 1711): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 19:37:23.045+0900 E/WIDGET_PROVIDER_APP( 1711): client.c: client_fini(1175) > Provider is not initialized
12-11 19:37:23.055+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1711
12-11 19:37:23.055+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 19:37:23.055+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(884) > app status : 4
12-11 19:37:23.055+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 19:37:23.160+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:37:23.185+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 19:37:23.210+0900 E/PKGMGR_SERVER( 2099): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 19:37:23.275+0900 E/AUL_AMD (  475): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 19:37:23.275+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(15), pid(1711), cmd(4)
12-11 19:37:23.275+0900 E/PKGMGR_SERVER( 2098): pkgmgr-server.c: sighandler(445) > child NORMAL exit [2099]
12-11 19:37:23.290+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 19:37:23.325+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:37:23.350+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:37:23.350+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 19:37:23.350+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 703
12-11 19:37:23.455+0900 E/RESOURCED(  481): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-11 19:37:23.455+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 19:37:23.455+0900 E/RESOURCED(  481): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 19:37:23.460+0900 W/AUL_PAD ( 1208): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 19:37:23.460+0900 W/AUL_PAD ( 1208): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 19:37:23.500+0900 I/CAPI_WATCH_APPLICATION( 1942): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 19:37:23.525+0900 E/TBM     ( 1942): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 19:37:23.565+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1711
12-11 19:37:23.600+0900 W/WATCH_CORE( 1942): appcore-watch.c: __widget_create(958) > widget_create
12-11 19:37:23.605+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1712) > [SECURE_LOG] [14.824063] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263020:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 19:37:23.605+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[14.824063] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263020:4] gbar_fname[]
12-11 19:37:23.620+0900 E/WIDGET_VIEWER(  714): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 19:37:23.620+0900 E/WIDGET_EVAS(  714): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 19:37:23.755+0900 I/CAPI_NETWORK_WIFI( 1942): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:37:23.765+0900 I/CAPI_NETWORK_WIFI( 1942): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:37:23.930+0900 W/WATCH_CORE( 1942): appcore-watch.c: __widget_create(976) > widget_create done
12-11 19:37:23.975+0900 I/WATCH_CORE( 1942): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 19:37:23.975+0900 I/WATCH_CORE( 1942): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 19:37:23.975+0900 I/WATCH_CORE( 1942): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 19:37:24.450+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 19:37:24.565+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 19:37:24.565+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 19:37:24.580+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:37:24.590+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1942
12-11 19:37:24.590+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:37:24.790+0900 I/AUL_PAD ( 2131): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 19:37:25.060+0900 W/AUL_AMD (  475): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 19:37:25.515+0900 E/PKGMGR_SERVER( 2098): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 19:37:25.515+0900 E/PKGMGR_SERVER( 2098): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 19:37:39.385+0900 E/PKGMGR  ( 2241): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 19:37:39.535+0900 E/PKGMGR_SERVER( 2243): pkgmgr-server.c: main(2126) > package manager server start
12-11 19:37:39.610+0900 E/PKGMGR_SERVER( 2243): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-375865199], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-375865199' '-r' 'org.reolab.blackandwhite'], cookie=[cocKjoQkDdKEW1e/C7kegYXxJyg=], backend_flag=[0]
12-11 19:37:39.610+0900 E/PKGMGR  ( 2243): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 19:37:39.610+0900 E/PKGMGR_SERVER( 2243): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 19:37:39.615+0900 E/PKGMGR  ( 2241): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[22410002]
12-11 19:37:39.615+0900 E/PKGMGR_SERVER( 2244): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 19:37:39.770+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 19:37:39.775+0900 W/AUL_AMD (  475): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 19:37:39.780+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 19:37:39.795+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:37:40.425+0900 E/PKGMGR_CERT( 2244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 19:37:40.440+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:37:40.440+0900 E/PKGMGR_CERT( 2244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
12-11 19:37:40.440+0900 E/PKGMGR_CERT( 2244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
12-11 19:37:40.440+0900 E/PKGMGR_CERT( 2244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-11 19:37:40.445+0900 E/PKGMGR_CERT( 2244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-11 19:37:40.445+0900 E/PKGMGR_CERT( 2244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-11 19:37:40.445+0900 E/PKGMGR_CERT( 2244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-11 19:37:40.470+0900 E/PKGMGR_CERT( 2244): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 19:37:41.515+0900 E/PKGMGR_SERVER( 2243): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:37:42.485+0900 E/rpm-installer( 2244): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-11 19:37:43.515+0900 E/PKGMGR_SERVER( 2243): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:37:45.515+0900 E/PKGMGR_SERVER( 2243): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:37:45.645+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:37:45.660+0900 E/PKGMGR_SERVER( 2243): pkgmgr-server.c: sighandler(445) > child NORMAL exit [2244]
12-11 19:37:45.665+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-11 19:37:45.665+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-11 19:37:45.685+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-11 19:37:45.685+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-11 19:37:45.685+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-11 19:37:45.685+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-11 19:37:45.745+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-11 19:37:45.785+0900 E/PKGMGR_INFO(  479): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-11 19:37:45.815+0900 E/APPS    (  714): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-11 19:37:46.175+0900 W/CRASH_MANAGER( 2248): worker.c: worker_job(1199) > 1101942626c61144983026
