S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 2158
Date: 2015-12-10 21:09:13+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1d

Register Information
r0   = 0xfe400106, r1   = 0x00000000
r2   = 0x8cbad300, r3   = 0x8cbad300
r4   = 0xbe90d540, r5   = 0x00000168
r6   = 0x00000168, r7   = 0xbe90ca58
r8   = 0x00000168, r9   = 0x00000168
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x404e3120, sp   = 0xbe90ca30
lr   = 0x404e31e8, pc   = 0x415544da
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:      9352 KB
Buffers:     21428 KB
Cached:     151792 KB
VmPeak:      95064 KB
VmSize:      94552 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15352 KB
VmRSS:       15348 KB
VmData:      38024 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 2158 TID = 2158
2158 2688 2696 

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
43757000 43f56000 rw-p [stack:2688]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45ca5000 rw-p [stack:2696]
be8ed000 be90e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2158)
Call Stack Count: 18
 0: getBTStatus + 0x49 (0x415544da) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x14da
 1: update_watch + 0x50 (0x415547ad) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x17ad
 2: create_base_gui + 0x376 (0x41554e07) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1e07
 3: app_create + 0x2c (0x41554669) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1669
 4: (0x419884d5) [/usr/lib/libappcore-watch.so.1] + 0x44d5
 5: (0x4198666b) [/usr/lib/libappcore-watch.so.1] + 0x266b
 6: (0x41c61bff) [/usr/lib/libwidget_provider_app.so.1] + 0x2bff
 7: widget_provider_send_hello_sync + 0x166 (0x43337017) [/usr/lib/libwidget_provider.so.1] + 0x7017
 8: (0x41c61c4b) [/usr/lib/libwidget_provider_app.so.1] + 0x2c4b
 9: widget_provider_init + 0xb8 (0x43336ced) [/usr/lib/libwidget_provider.so.1] + 0x6ced
10: (0x41c6234d) [/usr/lib/libwidget_provider_app.so.1] + 0x334d
11: widget_provider_app_init_sync + 0x2c (0x41c62f51) [/usr/lib/libwidget_provider_app.so.1] + 0x3f51
12: watch_core_main + 0xb2 (0x419875e3) [/usr/lib/libappcore-watch.so.1] + 0x35e3
13: watch_app_main + 0xca (0x41988753) [/usr/lib/libappcore-watch.so.1] + 0x4753
14: main + 0xc6 (0x415545d7) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x15d7
15: update_watch + 0x2f6 (0x40001a53) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1a53
16: __libc_start_main + 0x114 (0x4048b82c) [/lib/libc.so.6] + 0x1782c
17: create_base_gui + 0x387 (0x40001e18) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1e18
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
ove_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(265) ev->cur.canvas.y(189)
12-10 21:09:10.775+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:10.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:10.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(260) ev->cur.canvas.y(189)
12-10 21:09:10.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:10.795+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:10.795+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(251) ev->cur.canvas.y(190)
12-10 21:09:10.795+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:10.805+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:10.805+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(239) ev->cur.canvas.y(190)
12-10 21:09:10.805+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:10.815+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:10.815+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(220) ev->cur.canvas.y(190)
12-10 21:09:10.815+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:10.815+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-10 21:09:10.815+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(49ab91c8), type(elm_scroller)
12-10 21:09:10.815+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-10 21:09:10.815+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(49ab91c8), type(elm_scroller)
12-10 21:09:10.825+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(49ab91c8), locked_x(0)
12-10 21:09:10.825+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(49ab91c8)
12-10 21:09:10.855+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:10.855+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(201) ev->cur.canvas.y(190)
12-10 21:09:10.860+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:10.860+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:10.860+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(175) ev->cur.canvas.y(190)
12-10 21:09:10.860+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:10.865+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:10.865+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(141) ev->cur.canvas.y(193)
12-10 21:09:10.865+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:10.865+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(49ab91c8), locked_x(0)
12-10 21:09:10.865+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(49ab91c8)
12-10 21:09:10.900+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:10.905+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(104) ev->cur.canvas.y(194)
12-10 21:09:10.905+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:10.905+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:10.905+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(64) ev->cur.canvas.y(196)
12-10 21:09:10.905+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:10.905+0900 E/EFL     (  723): evas_main<723> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=514193 button=1 downs=0
12-10 21:09:10.910+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(49ab91c8), type(elm_scroller)
12-10 21:09:11.045+0900 I/efl-extension(  723): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x49ab91c8 : elm_scroller] CurrentPage(18)
12-10 21:09:11.175+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.175+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(268) ev->cur.canvas.y(185)
12-10 21:09:11.175+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.175+0900 E/EFL     (  723): evas_main<723> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=514484 button=1 downs=1
12-10 21:09:11.185+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.185+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(266) ev->cur.canvas.y(184)
12-10 21:09:11.185+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.195+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.195+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(261) ev->cur.canvas.y(184)
12-10 21:09:11.195+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.205+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.205+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(250) ev->cur.canvas.y(185)
12-10 21:09:11.205+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.215+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.215+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(234) ev->cur.canvas.y(188)
12-10 21:09:11.215+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.225+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.225+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(215) ev->cur.canvas.y(188)
12-10 21:09:11.225+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.225+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-10 21:09:11.225+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(49ab91c8), type(elm_scroller)
12-10 21:09:11.230+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-10 21:09:11.230+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(49ab91c8), type(elm_scroller)
12-10 21:09:11.240+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(49ab91c8), locked_x(0)
12-10 21:09:11.240+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(49ab91c8)
12-10 21:09:11.270+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.270+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(184) ev->cur.canvas.y(188)
12-10 21:09:11.275+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.275+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.275+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(146) ev->cur.canvas.y(192)
12-10 21:09:11.275+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.275+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.280+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(109) ev->cur.canvas.y(193)
12-10 21:09:11.280+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.285+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(49ab91c8), locked_x(0)
12-10 21:09:11.285+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(49ab91c8)
12-10 21:09:11.325+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.325+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(71) ev->cur.canvas.y(193)
12-10 21:09:11.325+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.325+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.325+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(44) ev->cur.canvas.y(193)
12-10 21:09:11.325+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.325+0900 E/EFL     (  723): evas_main<723> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=514602 button=1 downs=0
12-10 21:09:11.330+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(49ab91c8), type(elm_scroller)
12-10 21:09:11.455+0900 I/efl-extension(  723): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x49ab91c8 : elm_scroller] CurrentPage(19)
12-10 21:09:11.735+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.735+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(258) ev->cur.canvas.y(167)
12-10 21:09:11.735+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.740+0900 E/EFL     (  723): evas_main<723> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=515048 button=1 downs=1
12-10 21:09:11.750+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.750+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(249) ev->cur.canvas.y(170)
12-10 21:09:11.750+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.760+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.760+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(244) ev->cur.canvas.y(171)
12-10 21:09:11.760+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.775+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.775+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(228) ev->cur.canvas.y(173)
12-10 21:09:11.780+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.780+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(209) ev->cur.canvas.y(177)
12-10 21:09:11.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-10 21:09:11.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(49ab91c8), type(elm_scroller)
12-10 21:09:11.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-10 21:09:11.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(49ab91c8), type(elm_scroller)
12-10 21:09:11.790+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(49ab91c8), locked_x(0)
12-10 21:09:11.790+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(49ab91c8)
12-10 21:09:11.825+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.825+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(189) ev->cur.canvas.y(178)
12-10 21:09:11.825+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.825+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.825+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(169) ev->cur.canvas.y(180)
12-10 21:09:11.825+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.830+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.830+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(145) ev->cur.canvas.y(183)
12-10 21:09:11.830+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.830+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.830+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(123) ev->cur.canvas.y(185)
12-10 21:09:11.830+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.830+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(49ab91c8), locked_x(0)
12-10 21:09:11.830+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(49ab91c8)
12-10 21:09:11.890+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.890+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(105) ev->cur.canvas.y(188)
12-10 21:09:11.890+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.890+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.890+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(85) ev->cur.canvas.y(191)
12-10 21:09:11.890+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.895+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:11.895+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(61) ev->cur.canvas.y(194)
12-10 21:09:11.895+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:11.895+0900 E/EFL     (  723): evas_main<723> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=515175 button=1 downs=0
12-10 21:09:11.895+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(49ab91c8), type(elm_scroller)
12-10 21:09:12.025+0900 I/efl-extension(  723): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x49ab91c8 : elm_scroller] CurrentPage(20)
12-10 21:09:12.185+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.185+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(49) ev->cur.canvas.y(197)
12-10 21:09:12.185+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.185+0900 E/EFL     (  723): evas_main<723> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=515493 button=1 downs=1
12-10 21:09:12.190+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.190+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(62) ev->cur.canvas.y(199)
12-10 21:09:12.190+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.200+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.200+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(74) ev->cur.canvas.y(204)
12-10 21:09:12.200+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.215+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.215+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(86) ev->cur.canvas.y(205)
12-10 21:09:12.215+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.215+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-10 21:09:12.215+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(49ab91c8), type(elm_scroller)
12-10 21:09:12.215+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-10 21:09:12.215+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(49ab91c8), type(elm_scroller)
12-10 21:09:12.225+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.225+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(103) ev->cur.canvas.y(209)
12-10 21:09:12.225+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.225+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(49ab91c8), locked_x(0)
12-10 21:09:12.225+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(49ab91c8)
12-10 21:09:12.250+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.255+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(117) ev->cur.canvas.y(214)
12-10 21:09:12.255+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.255+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.255+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(130) ev->cur.canvas.y(218)
12-10 21:09:12.260+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.260+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(49ab91c8), locked_x(0)
12-10 21:09:12.260+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(49ab91c8)
12-10 21:09:12.285+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.285+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(146) ev->cur.canvas.y(222)
12-10 21:09:12.285+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.290+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.290+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(166) ev->cur.canvas.y(225)
12-10 21:09:12.290+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.290+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.290+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(183) ev->cur.canvas.y(229)
12-10 21:09:12.290+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.295+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(49ab91c8), locked_x(0)
12-10 21:09:12.295+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(49ab91c8)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(204) ev->cur.canvas.y(233)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(226) ev->cur.canvas.y(236)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(248) ev->cur.canvas.y(236)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(270) ev->cur.canvas.y(237)
12-10 21:09:12.365+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.370+0900 E/EFL     (  723): evas_main<723> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=515642 button=1 downs=0
12-10 21:09:12.370+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(49ab91c8), type(elm_scroller)
12-10 21:09:12.495+0900 I/efl-extension(  723): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x49ab91c8 : elm_scroller] CurrentPage(19)
12-10 21:09:12.745+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.745+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(176) ev->cur.canvas.y(173)
12-10 21:09:12.745+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.750+0900 E/EFL     (  723): evas_main<723> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=516048 button=1 downs=1
12-10 21:09:12.750+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.750+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(172) ev->cur.canvas.y(173)
12-10 21:09:12.750+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), block(1)
12-10 21:09:12.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), ev->cur.canvas.x(173) ev->cur.canvas.y(173)
12-10 21:09:12.785+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49ab91c8), hold(0) freeze(0)
12-10 21:09:12.830+0900 E/EFL     (  723): evas_main<723> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=516139 button=1 downs=0
12-10 21:09:12.910+0900 E/WMS     (  470): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-10 21:09:12.910+0900 E/WMS     (  470): ==========
12-10 21:09:12.910+0900 E/WMS     (  470): ##WMS SEND : mgr_clock_set_widget_req
12-10 21:09:12.910+0900 E/WMS     (  470): ==========
12-10 21:09:12.910+0900 E/WMS     (  470): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 80 MAX Buffer Size: 61440
12-10 21:09:12.910+0900 W/W_HOME  (  723): rotary.c: rotary_deattach(156) > rotary_deattach:0x49ab91c8
12-10 21:09:12.910+0900 I/efl-extension(  723): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8aa38, elm_box, _activated_obj : 0x49c42090, activated : 1
12-10 21:09:12.910+0900 I/efl-extension(  723): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
12-10 21:09:12.910+0900 E/wnotib  (  723): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-10 21:09:12.910+0900 I/wnotib  (  723): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5125) > Return true for 262, 10653.
12-10 21:09:12.910+0900 I/wnotib  (  723): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
12-10 21:09:12.910+0900 I/MESSAGE_PORT(  723): MessagePortProxy.cpp: IsLocalPortRegisted(695) > MessagePort name is already registered.
12-10 21:09:12.910+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 21:09:12.910+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 21:09:12.910+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 21:09:12.910+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
12-10 21:09:12.910+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
12-10 21:09:12.910+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 21:09:12.910+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.w-home:w-home::localport], client = 723
12-10 21:09:12.910+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 21:09:12.910+0900 E/EFL     (  723): edje<723> edje_util.c:3770 edje_object_size_min_restricted_calc() group page has a non-fixed part 'clipper'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-10 21:09:12.975+0900 W/W_HOME  (  723): clock_service.c: clock_service_event_handler(821) > scroller freeze off
12-10 21:09:12.975+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45c884b8), freeze(0)
12-10 21:09:12.975+0900 E/EFL     (  723): elementary<723> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45c884b8), freeze(0)
12-10 21:09:12.975+0900 W/W_HOME  (  723): scroller.c: scroller_unfreeze(1860) > unfreezed:4001f5a7
12-10 21:09:12.975+0900 W/W_HOME  (  723): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: org.reolab.blackandwhite 1 0 0 1
12-10 21:09:12.975+0900 E/W_HOME  (  723): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-10 21:09:12.975+0900 E/W_HOME  (  723): clock_service.c: _clock_provider_change(396) > clock will be changed to org.reolab.blackandwhite
12-10 21:09:12.995+0900 E/W_HOME  (  723): dbox.c: widget_create(359) > add-viewer info none: org.reolab.blackandwhite
12-10 21:09:12.995+0900 W/W_HOME  (  723): clock_inf_dbox.c: _is_preload_watchface(166) > ret:1
12-10 21:09:13.000+0900 E/WIDGET_EVAS(  723): widget_viewer_evas.c: __widget_resize(5435) > [SECURE_LOG] Failed to get box size
12-10 21:09:13.000+0900 E/WIDGET_VIEWER(  723): widget.c: widget_viewer_is_created_by_user(3452) > [SECURE_LOG] Handler is invalid
12-10 21:09:13.005+0900 E/W_HOME  (  723): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-10 21:09:13.005+0900 E/W_HOME  (  723): clock_service.c: _set_waiting_timer(356) > clock waiting timer is started
12-10 21:09:13.005+0900 E/W_HOME  (  723): dbus_util.c: home_dbus_lcd_on_signal_send(225) > Sending LCD ON request signal wristup:0 result:0
12-10 21:09:13.005+0900 W/W_HOME  (  723): cs_broker.c: _wms_clock_vconf_cb(283) > 
12-10 21:09:13.005+0900 E/CLOCK-LIST(  723): clocklist_main.c: clock_setting_event(3637) > proxy image is not deleted. Ignore event
12-10 21:09:13.005+0900 W/W_HOME  (  723): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,will,hide
12-10 21:09:13.005+0900 W/W_HOME  (  723): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 21:09:13.005+0900 W/W_HOME  (  723): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 21:09:13.010+0900 W/W_HOME  (  723): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-10 21:09:13.010+0900 W/W_HOME  (  723): main.c: home_resume(733) > clock/widget resumed
12-10 21:09:13.070+0900 W/AUL_AMD (  464): amd_request.c: __request_handler(640) > __request_handler: 0
12-10 21:09:13.085+0900 I/AUL_AMD (  464): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 21:09:13.095+0900 I/AUL_AMD (  464): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 21:09:13.095+0900 E/AUL_AMD (  464): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-10 21:09:13.095+0900 W/AUL_AMD (  464): amd_launch.c: _start_app(1659) > caller pid : 695
12-10 21:09:13.110+0900 E/RESOURCED(  471): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-10 21:09:13.110+0900 E/RESOURCED(  471): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-10 21:09:13.115+0900 W/AUL_AMD (  464): amd_launch.c: _start_app(2026) > pad pid(-5)
12-10 21:09:13.115+0900 W/AUL_PAD ( 1164): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-10 21:09:13.115+0900 W/AUL_PAD ( 1164): launchpad.c: __send_result_to_caller(265) > Check app launching
12-10 21:09:13.165+0900 I/CAPI_WATCH_APPLICATION( 2158): watch_app_main.c: watch_app_main(382) > watch_app_main
12-10 21:09:13.195+0900 E/TBM     ( 2158): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-10 21:09:13.220+0900 W/WATCH_CORE( 1393): appcore-watch.c: __widget_resume(1012) > widget_resume
12-10 21:09:13.220+0900 E/RESOURCED(  471): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.reolab.blackandwhite
12-10 21:09:13.220+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppResume(725) > 
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [2] to pending list
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [7]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [17]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [17]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [17] to pending list
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [30]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [30] to pending list
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [32]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [32]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [32] to pending list
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [34]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [34]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [34] to pending list
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [73]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [73] to pending list
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [77]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [77] to pending list
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [3]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [3] to pending list
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [1]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [1] to pending list
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [4]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: AddPendingChanges(1053) > added [4] to pending list
12-10 21:09:13.220+0900 I/CAPI_WATCH_APPLICATION( 1393): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:13.220+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 21:09:13.220+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:09:13.270+0900 W/WATCH_CORE( 2158): appcore-watch.c: __widget_create(958) > widget_create
12-10 21:09:13.275+0900 E/WIDGET_VIEWER(  723): client.c: master_created(1712) > [SECURE_LOG] [516.312073] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_723_516.312073.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-10 21:09:13.275+0900 W/W_HOME  (  723): dbox.c: _widget_created_cb(238) > widget resume:0x49c903e0
12-10 21:09:13.275+0900 E/WIDGET_VIEWER(  723): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
12-10 21:09:13.305+0900 E/WIDGET_VIEWER(  723): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-10 21:09:13.305+0900 E/WIDGET_EVAS(  723): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-10 21:09:13.415+0900 I/CAPI_WATCH_APPLICATION( 1393): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:13.415+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:13.415+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:13.415+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:13.455+0900 I/CAPI_NETWORK_WIFI( 2158): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 21:09:13.470+0900 I/CAPI_NETWORK_WIFI( 2158): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 21:09:13.610+0900 I/CAPI_WATCH_APPLICATION( 1393): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:13.610+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:13.610+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:13.610+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:13.810+0900 I/CAPI_WATCH_APPLICATION( 1393): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:13.810+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:13.810+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:13.810+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:13.940+0900 W/CRASH_MANAGER( 2697): worker.c: worker_job(1199) > 1102158626c61144974935
