S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 2711
Date: 2015-12-10 21:09:15+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1d

Register Information
r0   = 0xfe400106, r1   = 0x00000000
r2   = 0x8b960e00, r3   = 0x8b960e00
r4   = 0xbed54380, r5   = 0x00000168
r6   = 0x00000168, r7   = 0xbed53898
r8   = 0x00000168, r9   = 0x00000168
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x4044f27c, sp   = 0xbed53870
lr   = 0x403981e8, pc   = 0x400014da
cpsr = 0x60000030

Memory Information
MemTotal:   491012 KB
MemFree:      8756 KB
Buffers:     21432 KB
Cached:     148680 KB
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
PID = 2711 TID = 2711
2711 2713 2721 

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
40316000 40329000 rw-p [heap]
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
4332d000 43b2c000 rw-p [stack:2713]
43b2c000 43b2f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43b37000 43b42000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43e88000 43e9f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
440e9000 440eb000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
450f4000 45a40000 rw-p [stack:2721]
bed34000 bed55000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2711)
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
 [DDO] obj(49ab91c8), block(1)
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
12-10 21:09:13.940+0900 W/CRASH_MANAGER( 2697): worker.c: worker_job(1199) > 1102158626c611449749353
12-10 21:09:14.010+0900 I/CAPI_WATCH_APPLICATION( 1393): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:14.010+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:14.010+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:14.010+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:14.010+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 21:09:14.010+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:09:14.045+0900 W/AUL_AMD (  464): amd_request.c: __request_handler(640) > __request_handler: 4
12-10 21:09:14.045+0900 E/AUL_AMD (  464): amd_request.c: __app_process_by_pid(193) > pid(2158) is dead. cmd(4) is canceled
12-10 21:09:14.045+0900 W/AUL_AMD (  464): amd_request.c: __request_handler(640) > __request_handler: 0
12-10 21:09:14.060+0900 I/AUL_AMD (  464): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 21:09:14.070+0900 I/AUL_AMD (  464): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 21:09:14.070+0900 E/AUL_AMD (  464): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-10 21:09:14.070+0900 W/AUL_AMD (  464): amd_launch.c: _start_app(1659) > caller pid : 695
12-10 21:09:14.120+0900 E/RESOURCED(  471): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-10 21:09:14.120+0900 E/RESOURCED(  471): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-10 21:09:14.125+0900 W/AUL_AMD (  464): amd_launch.c: _start_app(2026) > pad pid(-5)
12-10 21:09:14.205+0900 I/CAPI_WATCH_APPLICATION( 1393): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:14.205+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:14.205+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:14.205+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:14.220+0900 W/AUL_PAD ( 1164): launchpad.c: __launchpad_main_loop(526) > Candidate is not prepared, enter legacy logic
12-10 21:09:14.220+0900 W/AUL_PAD ( 1164): launchpad.c: __send_result_to_caller(265) > Check app launching
12-10 21:09:14.220+0900 W/AUL_AMD (  464): amd_launch.c: _start_app(2037) > Launch with legacy way : no launchpad
12-10 21:09:14.220+0900 W/AUL_AMD (  464): amd_launch.c: start_process(573) > child process: 2711
12-10 21:09:14.225+0900 E/RESOURCED( 1078): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
12-10 21:09:14.225+0900 E/AUL     ( 1078): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
12-10 21:09:14.225+0900 E/CAPI_APPFW_APP_MANAGER( 1078): app_manager.c: app_manager_error(76) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
12-10 21:09:14.310+0900 W/AUL_AMD (  464): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 2711
12-10 21:09:14.315+0900 W/AUL_AMD (  464): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-10 21:09:14.315+0900 W/AUL_AMD (  464): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-10 21:09:14.315+0900 I/AUL_AMD (  464): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2158
12-10 21:09:14.350+0900 I/CAPI_WATCH_APPLICATION( 2711): watch_app_main.c: watch_app_main(382) > watch_app_main
12-10 21:09:14.375+0900 W/AUL_AMD (  464): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 21:09:14.380+0900 W/AUL_AMD (  464): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2711
12-10 21:09:14.385+0900 W/AUL_AMD (  464): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 21:09:14.405+0900 I/CAPI_WATCH_APPLICATION( 1393): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:14.405+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:14.405+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:14.405+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:14.525+0900 I/AUL_PAD ( 2710): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-10 21:09:14.575+0900 E/TBM     ( 2711): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-10 21:09:14.605+0900 I/CAPI_WATCH_APPLICATION( 1393): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:14.605+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:14.605+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:14.605+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:14.625+0900 W/WATCH_CORE( 2711): appcore-watch.c: __widget_create(958) > widget_create
12-10 21:09:14.630+0900 E/WIDGET_VIEWER(  723): client.c: master_created(1712) > [SECURE_LOG] [516.312073] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_723_516.312073.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263032:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-10 21:09:14.630+0900 E/WIDGET_VIEWER(  723): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[516.312073] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_723_516.312073.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263032:4] gbar_fname[]
12-10 21:09:14.645+0900 E/WIDGET_VIEWER(  723): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-10 21:09:14.645+0900 E/WIDGET_EVAS(  723): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-10 21:09:14.805+0900 I/CAPI_WATCH_APPLICATION( 1393): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:14.805+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:14.805+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:14.805+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:14.915+0900 I/CAPI_NETWORK_WIFI( 2711): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 21:09:14.930+0900 I/CAPI_NETWORK_WIFI( 2711): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 21:09:15.005+0900 I/CAPI_WATCH_APPLICATION( 1393): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:15.005+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:15.005+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:15.005+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:15.005+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 21:09:15.005+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 21:09:15.200+0900 I/CAPI_WATCH_APPLICATION( 1393): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 21:09:15.200+0900 E/watchface-loader( 1393): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 21:09:15.200+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 21:09:15.200+0900 I/watchface-viewer( 1393): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 21:09:15.310+0900 W/AUL_AMD (  464): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-10 21:09:15.310+0900 W/AUL_AMD (  464): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-10 21:09:15.370+0900 W/CRASH_MANAGER( 2697): worker.c: worker_job(1199) > 1102711626c61144974935
