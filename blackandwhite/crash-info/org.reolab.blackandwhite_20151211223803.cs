S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 17929
Date: 2015-12-11 22:38:03+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1b0

Register Information
r0   = 0x000001a4, r1   = 0x0000000d
r2   = 0x00000004, r3   = 0x41453194
r4   = 0x000001a4, r5   = 0x00000000
r6   = 0x418e5cdc, r7   = 0x418bee08
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeb10c44, sp   = 0xbeb10bf8
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   489992 KB
MemFree:     18236 KB
Buffers:     25224 KB
Cached:     126644 KB
VmPeak:     111680 KB
VmSize:     111168 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16088 KB
VmRSS:       16088 KB
VmData:      54640 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 17929 TID = 17929
17929 18914 18925 

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
417c5000 417cd000 rw-p [heap]
417cd000 418ff000 rw-p [heap]
418ff000 41913000 r-xp /usr/lib/libcapi-network-nfc.so.0.2.3
4191b000 41928000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.55
41930000 41935000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
4193d000 4194a000 r-xp /usr/lib/libalarm.so.0.0.0
41953000 41a90000 r-xp /usr/lib/libicui18n.so.51.1
41aa0000 41b84000 r-xp /usr/lib/libicuuc.so.51.1
41b99000 41b9f000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41ba7000 41bad000 r-xp /usr/lib/libwidget.so.1.0.0
41bb6000 41bbb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41bc3000 41bfa000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41c03000 41c1c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41c25000 41c4f000 r-xp /usr/lib/libnfc.so.1.0.0
41c58000 41c89000 r-xp /usr/lib/libmdm.so.1.1.85
41c91000 41ca7000 r-xp /usr/lib/libnetwork.so.0.0.0
41cb0000 41cb5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
43244000 4324d000 r-xp /usr/lib/libcom-core.so.0.0.1
43256000 43262000 r-xp /usr/lib/libwidget_service.so.1.0.0
4326a000 43273000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4327c000 43282000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4328a000 43292000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4329a000 432c8000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
432d4000 432dc000 r-xp /usr/lib/libdrm.so.2.4.0
432e4000 432e6000 r-xp /usr/lib/libdri2.so.0.0.0
432ee000 432f5000 r-xp /usr/lib/libtbm.so.1.0.0
432fd000 43317000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43320000 43327000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43330000 43332000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4333a000 43341000 r-xp /usr/lib/libminizip.so.1.0.0
43349000 43356000 r-xp /usr/lib/libail.so.0.1.0
43791000 43f90000 rw-p [stack:18914]
43f90000 43f93000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f9b000 43fa6000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4402e000 44045000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44284000 44286000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:18925]
beaf1000 beb12000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17929)
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
v->cur.canvas.x(193) ev->cur.canvas.y(123)
12-11 22:37:21.941+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:21.946+0900 E/EFL     (17690): evas_main<17690> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2879732 button=1 downs=1
12-11 22:37:21.946+0900 E/blackandwhite(17690): blackandwhite.c: multidownCB(190) > MULTI!!
12-11 22:37:21.951+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:21.951+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(191) ev->cur.canvas.y(123)
12-11 22:37:21.951+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:21.961+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:21.961+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(188) ev->cur.canvas.y(123)
12-11 22:37:21.961+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:21.991+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:21.991+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(186) ev->cur.canvas.y(125)
12-11 22:37:21.996+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:21.996+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:22.006+0900 E/EFL     (  717): evas_main<717> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2879814 button=1 downs=0
12-11 22:37:22.026+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:22.041+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:22.096+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-11 22:37:22.096+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.096+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(188) ev->cur.canvas.y(125)
12-11 22:37:22.096+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.101+0900 E/EFL     (  717): evas_main<717> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2879905 button=1 downs=1
12-11 22:37:22.106+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.106+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(187) ev->cur.canvas.y(124)
12-11 22:37:22.106+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.116+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.116+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(185) ev->cur.canvas.y(124)
12-11 22:37:22.116+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.136+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:22.136+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.136+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(185) ev->cur.canvas.y(123)
12-11 22:37:22.136+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.151+0900 E/EFL     (17690): evas_main<17690> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2879818 button=1 downs=0
12-11 22:37:22.151+0900 E/EFL     (17690): evas_main<17690> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2879911 button=1 downs=1
12-11 22:37:22.156+0900 E/blackandwhite(17690): blackandwhite.c: multidownCB(190) > MULTI!!
12-11 22:37:22.171+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.171+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(185) ev->cur.canvas.y(125)
12-11 22:37:22.171+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.181+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.181+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(185) ev->cur.canvas.y(128)
12-11 22:37:22.181+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.191+0900 E/EFL     (  717): evas_main<717> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2880002 button=1 downs=0
12-11 22:37:22.206+0900 E/EFL     (17690): evas_main<17690> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2880004 button=1 downs=0
12-11 22:37:22.271+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-11 22:37:22.271+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.271+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(200) ev->cur.canvas.y(128)
12-11 22:37:22.271+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.271+0900 E/EFL     (  717): evas_main<717> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2880080 button=1 downs=1
12-11 22:37:22.281+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.281+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(202) ev->cur.canvas.y(128)
12-11 22:37:22.281+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.291+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.291+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(203) ev->cur.canvas.y(128)
12-11 22:37:22.291+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.296+0900 E/EFL     (17690): evas_main<17690> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2880083 button=1 downs=1
12-11 22:37:22.296+0900 E/blackandwhite(17690): blackandwhite.c: multidownCB(190) > MULTI!!
12-11 22:37:22.311+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.311+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(202) ev->cur.canvas.y(128)
12-11 22:37:22.311+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.321+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.321+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(199) ev->cur.canvas.y(129)
12-11 22:37:22.321+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.346+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.346+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(196) ev->cur.canvas.y(131)
12-11 22:37:22.346+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.356+0900 E/EFL     (  717): evas_main<717> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2880166 button=1 downs=0
12-11 22:37:22.371+0900 E/EFL     (17690): evas_main<17690> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2880169 button=1 downs=0
12-11 22:37:22.471+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-11 22:37:22.476+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.476+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(188) ev->cur.canvas.y(129)
12-11 22:37:22.476+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.481+0900 E/EFL     (  717): evas_main<717> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2880283 button=1 downs=1
12-11 22:37:22.481+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.481+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(189) ev->cur.canvas.y(130)
12-11 22:37:22.486+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.506+0900 E/EFL     (17690): evas_main<17690> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2880291 button=1 downs=1
12-11 22:37:22.506+0900 E/blackandwhite(17690): blackandwhite.c: multidownCB(190) > MULTI!!
12-11 22:37:22.526+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.526+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(188) ev->cur.canvas.y(130)
12-11 22:37:22.526+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.536+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.536+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(184) ev->cur.canvas.y(130)
12-11 22:37:22.536+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.546+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-11 22:37:22.546+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(177) ev->cur.canvas.y(121)
12-11 22:37:22.546+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-11 22:37:22.556+0900 E/EFL     (  717): evas_main<717> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2880368 button=1 downs=0
12-11 22:37:22.571+0900 E/EFL     (17690): evas_main<17690> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2880371 button=1 downs=0
12-11 22:37:23.006+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:23.061+0900 W/W_HOME  (  717): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
12-11 22:37:23.111+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:23.151+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:23.236+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:23.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:23.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:37:24.006+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:24.111+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:24.161+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:24.261+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:25.006+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:25.106+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:25.161+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:25.266+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:26.011+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:26.111+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:26.156+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:26.271+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:27.006+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:27.111+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:27.151+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:27.261+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:28.011+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:28.111+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:28.151+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:28.271+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:28.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:28.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:37:29.021+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:29.131+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:29.181+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:29.281+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:30.011+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:30.106+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:30.151+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:30.266+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:31.006+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:31.106+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:31.161+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:31.256+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:32.011+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:32.116+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:32.156+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:32.241+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:33.011+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:33.111+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:33.146+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:33.231+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:33.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:33.841+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:37:34.006+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:34.101+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:34.161+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:34.256+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:35.011+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:35.106+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:35.166+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:35.261+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:36.006+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:36.106+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:36.161+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:36.261+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:37.011+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:37.111+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:37.161+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:37.256+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:38.006+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:38.106+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:38.151+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:38.241+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:38.771+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:38.846+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:37:39.006+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:39.106+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:39.166+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:39.266+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:40.006+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:40.106+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:40.161+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:40.251+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:41.011+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:41.116+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:41.166+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:41.251+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:42.006+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:42.111+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:42.166+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:42.281+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:43.001+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:43.136+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:43.236+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:43.311+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:43.766+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:43.781+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:37:44.001+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:44.156+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:44.256+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:44.326+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:45.026+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:45.121+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:45.161+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 22:37:45.161+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 22:37:45.171+0900 I/RESOURCED(  480): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-11 22:37:45.201+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:45.276+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:46.001+0900 I/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 22:37:46.046+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:46.101+0900 I/CAPI_NETWORK_WIFI(17690): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:46.176+0900 E/blackandwhite(17690): blackandwhite.c: update_watch(149) > colorT : 1
12-11 22:37:46.311+0900 E/PKGMGR_SERVER(18907): pkgmgr-server.c: main(2126) > package manager server start
12-11 22:37:46.411+0900 E/PKGMGR_SERVER(18907): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1840976539], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 22:37:46.416+0900 E/PKGMGR_SERVER(18909): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 22:37:46.421+0900 E/PKGMGR  (18901): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 22:37:46.491+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:46.496+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17690
12-11 22:37:46.501+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 22:37:46.506+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 22:37:46.511+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(17690), cmd(4)
12-11 22:37:46.511+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 22:37:46.511+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(884) > app status : 4
12-11 22:37:46.511+0900 W/CAPI_WATCH_APPLICATION(17690): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 22:37:46.511+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:46.516+0900 W/WATCH_CORE(17690): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 22:37:46.516+0900 E/WIDGET_PROVIDER_APP(17690): client.c: client_fini(1175) > Provider is not initialized
12-11 22:37:46.521+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17690
12-11 22:37:46.526+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 22:37:46.626+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:46.641+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 22:37:46.666+0900 E/PKGMGR_SERVER(18909): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 22:37:46.711+0900 E/PKGMGR_SERVER(18907): pkgmgr-server.c: sighandler(445) > child NORMAL exit [18909]
12-11 22:37:46.711+0900 E/AUL_AMD (  479): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 22:37:46.711+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(17690), cmd(4)
12-11 22:37:46.721+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 22:37:46.771+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 22:37:46.791+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 22:37:46.791+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 22:37:46.791+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 698
12-11 22:37:46.896+0900 E/RESOURCED(  480): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-11 22:37:46.896+0900 E/RESOURCED(  480): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 22:37:46.901+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 22:37:46.906+0900 W/AUL_PAD ( 1168): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 22:37:46.906+0900 W/AUL_PAD ( 1168): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 22:37:46.946+0900 I/CAPI_WATCH_APPLICATION(17929): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 22:37:46.976+0900 E/TBM     (17929): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 22:37:47.006+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 17690
12-11 22:37:47.041+0900 W/WATCH_CORE(17929): appcore-watch.c: __widget_create(958) > widget_create
12-11 22:37:47.046+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [633.058716] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_633.058716.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263064:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 22:37:47.046+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[633.058716] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_633.058716.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263064:4] gbar_fname[]
12-11 22:37:47.066+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 22:37:47.066+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 22:37:47.211+0900 I/CAPI_NETWORK_WIFI(17929): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 22:37:47.216+0900 I/CAPI_NETWORK_WIFI(17929): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 22:37:47.386+0900 E/blackandwhite(17929): blackandwhite.c: update_watch(149) > colorT : 0
12-11 22:37:47.396+0900 W/WATCH_CORE(17929): appcore-watch.c: __widget_create(976) > widget_create done
12-11 22:37:47.436+0900 I/WATCH_CORE(17929): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 22:37:47.436+0900 I/WATCH_CORE(17929): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 22:37:47.436+0900 I/WATCH_CORE(17929): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 22:37:48.006+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 22:37:48.006+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 22:37:48.021+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:48.031+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17929
12-11 22:37:48.031+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 22:37:48.191+0900 E/PKGMGR_SERVER(18907): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 22:37:48.191+0900 E/PKGMGR_SERVER(18907): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 22:37:48.246+0900 I/AUL_PAD (18941): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 22:37:48.591+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 22:37:48.761+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:48.791+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:37:51.651+0900 W/WATCH_CORE(17929): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-11 22:37:51.726+0900 W/W_HOME  (  717): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-11 22:37:51.726+0900 W/W_HOME  (  717): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-11 22:37:51.726+0900 W/W_HOME  (  717): gesture.c: _manual_render_enable(133) > 1
12-11 22:37:51.726+0900 W/W_HOME  (  717): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-11 22:37:51.726+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:37:51.736+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-11 22:37:51.736+0900 W/STARTER (  693): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-11 22:37:51.741+0900 E/STARTER (  693): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-11 22:37:51.741+0900 W/STARTER (  693): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-11 22:37:51.741+0900 W/STARTER (  693): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-11 22:37:51.746+0900 I/SCONTEXT-LIB(  669): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-11 22:37:51.766+0900 I/WATCH_CORE(17929): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-11 22:37:51.781+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124317720[0;m
12-11 22:37:51.781+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-11 22:37:51.791+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-11 22:37:51.881+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-11 22:37:51.881+0900 W/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-11 22:37:51.881+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-11 22:37:51.881+0900 I/HIGEAR  ( 1131): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-11 22:37:51.986+0900 I/SHealth_Common( 1061): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-11 22:37:51.986+0900 I/SHealth_Service( 1061): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-11 22:37:51.986+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:834]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-11 22:37:52.026+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-11 22:37:52.026+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-11 22:37:52.026+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-11 22:37:52.031+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-11 22:37:52.041+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: RUNNING
12-11 22:37:52.041+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-11 22:37:52.041+0900 W/W_HOME  (  717): main.c: _appcore_pause_cb(690) > appcore pause
12-11 22:37:52.041+0900 W/W_HOME  (  717): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-11 22:37:52.041+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:37:52.046+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:37:52.046+0900 W/W_HOME  (  717): main.c: home_pause(751) > clock/widget paused
12-11 22:37:52.046+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 22:37:52.046+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:37:52.046+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:37:52.046+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:37:52.046+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-11 22:37:52.046+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-11 22:37:52.046+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:37:52.046+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 22:37:52.046+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:37:52.051+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 22:37:52.051+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 22:37:52.051+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 22:37:52.051+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 22:37:52.051+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 22:37:52.051+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 22:37:52.051+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-11 22:37:52.051+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 22:37:52.051+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 22:37:52.051+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 22:37:52.056+0900 E/CAPI_APPFW_APP_CONTROL(  834): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-11 22:37:52.056+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:834]   value = [false][0m
12-11 22:37:52.056+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-11 22:37:52.556+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-11 22:37:53.761+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:53.791+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:37:57.016+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 22:37:57.016+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 22:37:57.021+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 22:37:57.021+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 22:37:57.096+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-11 22:37:57.481+0900 E/PKGMGR  (19051): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 22:37:57.626+0900 E/PKGMGR_SERVER(19053): pkgmgr-server.c: main(2126) > package manager server start
12-11 22:37:57.711+0900 E/PKGMGR_SERVER(19053): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1852291033], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_1852291033' '-r' 'org.reolab.blackandwhite'], cookie=[eCVzhQ3CdrfgFcW3oy6/eRxz5iE=], backend_flag=[0]
12-11 22:37:57.716+0900 E/PKGMGR  (19053): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 22:37:57.716+0900 E/PKGMGR_SERVER(19053): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 22:37:57.721+0900 E/PKGMGR  (19051): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[190510002]
12-11 22:37:57.721+0900 E/PKGMGR_SERVER(19055): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 22:37:57.861+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 22:37:57.881+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 22:37:57.881+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:37:57.911+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 22:37:58.536+0900 E/PKGMGR_CERT(19055): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 22:37:58.546+0900 E/PKGMGR_CERT(19055): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 96
12-11 22:37:58.546+0900 E/PKGMGR_CERT(19055): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 96
12-11 22:37:58.551+0900 E/PKGMGR_CERT(19055): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 4
12-11 22:37:58.551+0900 E/PKGMGR_CERT(19055): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 4
12-11 22:37:58.551+0900 E/PKGMGR_CERT(19055): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 4
12-11 22:37:58.551+0900 E/PKGMGR_CERT(19055): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 4
12-11 22:37:58.551+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:37:58.571+0900 E/PKGMGR_CERT(19055): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 22:37:58.761+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:37:58.771+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:38:00.191+0900 E/PKGMGR_SERVER(19053): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 22:38:00.436+0900 E/rpm-installer(19055): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-11 22:38:02.191+0900 E/PKGMGR_SERVER(19053): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 22:38:03.521+0900 E/PKGMGR_SERVER(19053): pkgmgr-server.c: sighandler(445) > child NORMAL exit [19055]
12-11 22:38:03.536+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 22:38:03.546+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-11 22:38:03.546+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-11 22:38:03.561+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-11 22:38:03.566+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-11 22:38:03.566+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-11 22:38:03.566+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-11 22:38:03.571+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-11 22:38:03.666+0900 E/APPS    (  717): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-11 22:38:03.691+0900 E/PKGMGR_INFO(  476): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-11 22:38:03.761+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 22:38:03.771+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 22:38:04.056+0900 W/CRASH_MANAGER(19059): worker.c: worker_job(1199) > 1117929626c61144984108
