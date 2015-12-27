S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 13795
Date: 2015-12-11 21:15:09+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xfac

Register Information
r0   = 0xbecd09f8, r1   = 0xbecd15cc
r2   = 0x00000000, r3   = 0xbecd0a6c
r4   = 0xbecd15cc, r5   = 0xbecd12c8
r6   = 0x00000132, r7   = 0xbecd0a00
r8   = 0x4030b9c0, r9   = 0x4145fa10
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4155d804, sp   = 0xbecd09e8
lr   = 0x41554553, pc   = 0x00000fac
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     24480 KB
Buffers:     32124 KB
Cached:     139244 KB
VmPeak:     112000 KB
VmSize:     111992 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15628 KB
VmRSS:       15628 KB
VmData:      55464 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 13795 TID = 13795
13795 13896 13906 

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
43757000 43f56000 rw-p [stack:13896]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43f75000 43f77000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
45401000 45c00000 rw-p [stack:13906]
becb1000 becd2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13795)
Call Stack Count: 1
 0: (0xfac) (null)
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
obj(45c88018), ev->cur.canvas.x(142) ev->cur.canvas.y(185)
12-11 21:15:00.335+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:00.345+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=6067311 button=1 downs=0
12-11 21:15:00.430+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-11 21:15:00.430+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:00.430+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(137) ev->cur.canvas.y(186)
12-11 21:15:00.430+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:00.435+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=6067396 button=1 downs=1
12-11 21:15:00.440+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:00.440+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(137) ev->cur.canvas.y(183)
12-11 21:15:00.440+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:00.450+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:00.450+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(138) ev->cur.canvas.y(182)
12-11 21:15:00.450+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:00.470+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:00.470+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(138) ev->cur.canvas.y(181)
12-11 21:15:00.470+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:00.515+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:00.515+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(137) ev->cur.canvas.y(181)
12-11 21:15:00.515+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:00.525+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=6067492 button=1 downs=0
12-11 21:15:01.030+0900 W/W_HOME  (  714): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
12-11 21:15:01.065+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-11 21:15:01.070+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.070+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(63) ev->cur.canvas.y(197)
12-11 21:15:01.070+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.070+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=6068033 button=1 downs=1
12-11 21:15:01.075+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.075+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(77) ev->cur.canvas.y(201)
12-11 21:15:01.075+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.085+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.085+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(87) ev->cur.canvas.y(202)
12-11 21:15:01.085+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.095+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.095+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(99) ev->cur.canvas.y(205)
12-11 21:15:01.095+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.095+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-11 21:15:01.095+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88018), type(elm_scroller)
12-11 21:15:01.095+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-11 21:15:01.095+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88018), type(elm_scroller)
12-11 21:15:01.110+0900 W/W_HOME  (  714): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0x47bfadc8 -> 360 0 0x47cb1920
12-11 21:15:01.110+0900 W/W_HOME  (  714): event_manager.c: _home_scroll_cb(564) > scroll,start
12-11 21:15:01.115+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.115+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(117) ev->cur.canvas.y(211)
12-11 21:15:01.115+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.115+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88018), locked_x(0)
12-11 21:15:01.115+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88018)
12-11 21:15:01.115+0900 W/W_HOME  (  714): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-11 21:15:01.115+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 21:15:01.120+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.120+0900 E/W_HOME  (  714): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
12-11 21:15:01.130+0900 I/GESTURE (  143): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-11 21:15:01.155+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.155+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(145) ev->cur.canvas.y(216)
12-11 21:15:01.160+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.160+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.160+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(183) ev->cur.canvas.y(221)
12-11 21:15:01.160+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.160+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.160+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(219) ev->cur.canvas.y(228)
12-11 21:15:01.160+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.160+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.160+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(244) ev->cur.canvas.y(231)
12-11 21:15:01.160+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.160+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88018), locked_x(0)
12-11 21:15:01.165+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88018)
12-11 21:15:01.165+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_activate(2674) > page_index: 0.
12-11 21:15:01.165+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_select(581) > 0
12-11 21:15:01.165+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_select(591) > select index:1
12-11 21:15:01.165+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_show(541) > 
12-11 21:15:01.165+0900 W/W_HOME  (  714): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
12-11 21:15:01.165+0900 W/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_activate(2684) > Hide home indicator.
12-11 21:15:01.165+0900 W/W_HOME  (  714): noti_broker.c: _handler_noti_indicator_hide(498) > 
12-11 21:15:01.170+0900 E/wnoti-service(  862): wnoti-server-mgr-stub.c: __wnoti_change_new_flag_stub(2269) > change_type : 0, value : 0
12-11 21:15:01.175+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.190+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.190+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(266) ev->cur.canvas.y(234)
12-11 21:15:01.190+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.190+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.190+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(282) ev->cur.canvas.y(235)
12-11 21:15:01.190+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.190+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=6068147 button=1 downs=0
12-11 21:15:01.195+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88018), type(elm_scroller)
12-11 21:15:01.195+0900 W/W_HOME  (  714): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:0x49a97bb8
12-11 21:15:01.200+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.215+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.230+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.240+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.255+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.270+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.285+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.315+0900 W/WATCH_CORE(13795): appcore-watch.c: __widget_pause(1001) > widget_pause
12-11 21:15:01.320+0900 E/WATCH_CORE(13795): appcore-watch.c: __do_app(322) > Invalid state
12-11 21:15:01.320+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-11 21:15:01.325+0900 I/efl-extension(  714): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88018 : elm_scroller] CurrentPage(0)
12-11 21:15:01.445+0900 W/W_HOME  (  714): event_manager.c: _home_scroll_cb(564) > scroll,done
12-11 21:15:01.505+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.505+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(288) ev->cur.canvas.y(194)
12-11 21:15:01.505+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.510+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=6068470 button=1 downs=1
12-11 21:15:01.520+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.520+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(268) ev->cur.canvas.y(185)
12-11 21:15:01.520+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.525+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.525+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(244) ev->cur.canvas.y(183)
12-11 21:15:01.525+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.525+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-11 21:15:01.525+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88018), type(elm_scroller)
12-11 21:15:01.525+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-11 21:15:01.525+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88018), type(elm_scroller)
12-11 21:15:01.535+0900 E/WIDGET_EVAS(  714): widget_viewer_evas.c: widget_viewer_evas_is_widget(7974) > [SECURE_LOG] Invalid object
12-11 21:15:01.540+0900 W/W_HOME  (  714): home_navigation.c: _is_rightedge(188) > (0 360) not right edge: 0 0 0x47758648 -> 360 0 0x47bfadc8
12-11 21:15:01.540+0900 W/W_HOME  (  714): event_manager.c: _home_scroll_cb(564) > scroll,start
12-11 21:15:01.540+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.540+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(215) ev->cur.canvas.y(183)
12-11 21:15:01.545+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.545+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88018), locked_x(0)
12-11 21:15:01.545+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88018)
12-11 21:15:01.545+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.555+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.555+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(182) ev->cur.canvas.y(186)
12-11 21:15:01.560+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.560+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.560+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(144) ev->cur.canvas.y(196)
12-11 21:15:01.560+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.560+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88018), locked_x(0)
12-11 21:15:01.560+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88018)
12-11 21:15:01.560+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.570+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:01.570+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(104) ev->cur.canvas.y(208)
12-11 21:15:01.575+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:01.575+0900 W/WATCH_CORE(13795): appcore-watch.c: __widget_resume(1012) > widget_resume
12-11 21:15:01.575+0900 I/CAPI_WATCH_APPLICATION(13795): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 21:15:01.580+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88018), locked_x(0)
12-11 21:15:01.580+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88018)
12-11 21:15:01.580+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.595+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=6068545 button=1 downs=0
12-11 21:15:01.595+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88018), type(elm_scroller)
12-11 21:15:01.595+0900 W/W_HOME  (  714): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
12-11 21:15:01.595+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 21:15:01.595+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.610+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 21:15:01.625+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.635+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.650+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.665+0900 W/W_HOME  (  714): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-11 21:15:01.665+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 21:15:01.665+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.675+0900 I/GESTURE (  143): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-11 21:15:01.685+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.700+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.710+0900 E/blackandwhite(13795): blackandwhite.c: update_watch(149) > colorT : 0
12-11 21:15:01.715+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 21:15:01.715+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:01.720+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-11 21:15:01.720+0900 I/efl-extension(  714): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88018 : elm_scroller] CurrentPage(1)
12-11 21:15:01.745+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-11 21:15:01.745+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-11 21:15:01.745+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: preference_get_double(1214) > preference_get_double(1049) : pedometer_inactive_period error
12-11 21:15:01.745+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-11 21:15:01.745+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-11 21:15:01.745+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: preference_get_double(1214) > preference_get_double(1049) : inactive_10min_precaution_millisec error
12-11 21:15:01.745+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-11 21:15:01.745+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-11 21:15:01.745+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1049): preference.c: preference_get_double(1214) > preference_get_double(1049) : inactive_before_10min_precaution_millisec error
12-11 21:15:01.845+0900 W/W_HOME  (  714): event_manager.c: _home_scroll_cb(564) > scroll,done
12-11 21:15:02.000+0900 I/CAPI_WATCH_APPLICATION(13795): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 21:15:02.040+0900 I/GESTURE (  143): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-11 21:15:02.045+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.045+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(22) ev->cur.canvas.y(189)
12-11 21:15:02.045+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.050+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=6069009 button=1 downs=1
12-11 21:15:02.060+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.060+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(44) ev->cur.canvas.y(199)
12-11 21:15:02.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(71) ev->cur.canvas.y(209)
12-11 21:15:02.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-11 21:15:02.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88018), type(elm_scroller)
12-11 21:15:02.065+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-11 21:15:02.070+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88018), type(elm_scroller)
12-11 21:15:02.075+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 21:15:02.080+0900 W/W_HOME  (  714): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0x47bfadc8 -> 360 0 0x47cb1920
12-11 21:15:02.080+0900 W/W_HOME  (  714): event_manager.c: _home_scroll_cb(564) > scroll,start
12-11 21:15:02.085+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88018), locked_x(0)
12-11 21:15:02.085+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88018)
12-11 21:15:02.085+0900 W/W_HOME  (  714): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-11 21:15:02.085+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 21:15:02.085+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.095+0900 I/GESTURE (  143): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-11 21:15:02.100+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 21:15:02.105+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.105+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(99) ev->cur.canvas.y(213)
12-11 21:15:02.105+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.105+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.105+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(142) ev->cur.canvas.y(224)
12-11 21:15:02.105+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.105+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.105+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(196) ev->cur.canvas.y(236)
12-11 21:15:02.105+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.110+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.110+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(239) ev->cur.canvas.y(242)
12-11 21:15:02.110+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.110+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88018), locked_x(0)
12-11 21:15:02.110+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88018)
12-11 21:15:02.110+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_activate(2674) > page_index: 0.
12-11 21:15:02.110+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_select(581) > 0
12-11 21:15:02.115+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_select(591) > select index:1
12-11 21:15:02.115+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_show(541) > 
12-11 21:15:02.115+0900 W/W_HOME  (  714): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
12-11 21:15:02.120+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.135+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.135+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(265) ev->cur.canvas.y(243)
12-11 21:15:02.135+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.135+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.135+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(291) ev->cur.canvas.y(243)
12-11 21:15:02.135+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.140+0900 W/W_HOME  (  714): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
12-11 21:15:02.140+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88018), locked_x(0)
12-11 21:15:02.140+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88018)
12-11 21:15:02.140+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.160+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=6069101 button=1 downs=0
12-11 21:15:02.170+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88018), type(elm_scroller)
12-11 21:15:02.175+0900 E/blackandwhite(13795): blackandwhite.c: update_watch(149) > colorT : 0
12-11 21:15:02.180+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.190+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.200+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.210+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.225+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.245+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.260+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.295+0900 W/WATCH_CORE(13795): appcore-watch.c: __widget_pause(1001) > widget_pause
12-11 21:15:02.295+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-11 21:15:02.300+0900 I/efl-extension(  714): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88018 : elm_scroller] CurrentPage(0)
12-11 21:15:02.425+0900 W/W_HOME  (  714): event_manager.c: _home_scroll_cb(564) > scroll,done
12-11 21:15:02.825+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.825+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(311) ev->cur.canvas.y(235)
12-11 21:15:02.825+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.830+0900 E/EFL     (  714): evas_main<714> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=6069792 button=1 downs=1
12-11 21:15:02.835+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.835+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(288) ev->cur.canvas.y(228)
12-11 21:15:02.835+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.845+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.845+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(259) ev->cur.canvas.y(220)
12-11 21:15:02.845+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.845+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-11 21:15:02.845+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88018), type(elm_scroller)
12-11 21:15:02.845+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-11 21:15:02.845+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88018), type(elm_scroller)
12-11 21:15:02.850+0900 E/WIDGET_EVAS(  714): widget_viewer_evas.c: widget_viewer_evas_is_widget(7974) > [SECURE_LOG] Invalid object
12-11 21:15:02.855+0900 W/W_HOME  (  714): home_navigation.c: _is_rightedge(188) > (0 360) not right edge: 0 0 0x47758648 -> 360 0 0x47bfadc8
12-11 21:15:02.860+0900 W/W_HOME  (  714): event_manager.c: _home_scroll_cb(564) > scroll,start
12-11 21:15:02.860+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.860+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(232) ev->cur.canvas.y(216)
12-11 21:15:02.860+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.860+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88018), locked_x(0)
12-11 21:15:02.860+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88018)
12-11 21:15:02.860+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.875+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.875+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(195) ev->cur.canvas.y(216)
12-11 21:15:02.875+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.875+0900 W/WATCH_CORE(13795): appcore-watch.c: __widget_resume(1012) > widget_resume
12-11 21:15:02.875+0900 I/CAPI_WATCH_APPLICATION(13795): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 21:15:02.885+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88018), locked_x(0)
12-11 21:15:02.885+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88018)
12-11 21:15:02.890+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.890+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 21:15:02.900+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), block(2)
12-11 21:15:02.900+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), ev->cur.canvas.x(144) ev->cur.canvas.y(219)
12-11 21:15:02.900+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88018), hold(0) freeze(0)
12-11 21:15:02.900+0900 E/EFL     (  714): evas_main<714> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=6069852 button=1 downs=0
12-11 21:15:02.900+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88018), type(elm_scroller)
12-11 21:15:02.905+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.915+0900 W/W_HOME  (  714): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
12-11 21:15:02.915+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.930+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.935+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 21:15:02.955+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.975+0900 W/W_HOME  (  714): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-11 21:15:02.975+0900 W/W_HOME  (  714): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 21:15:02.980+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:02.990+0900 I/GESTURE (  143): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-11 21:15:02.995+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:03.005+0900 E/blackandwhite(13795): blackandwhite.c: update_watch(149) > colorT : 0
12-11 21:15:03.005+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:03.010+0900 I/CAPI_WATCH_APPLICATION(13795): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 21:15:03.025+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-11 21:15:03.025+0900 I/ELM_RPANEL(  714): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-11 21:15:03.030+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 21:15:03.030+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-11 21:15:03.035+0900 I/efl-extension(  714): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88018 : elm_scroller] CurrentPage(1)
12-11 21:15:03.045+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 21:15:03.090+0900 E/blackandwhite(13795): blackandwhite.c: update_watch(149) > colorT : 0
12-11 21:15:03.150+0900 W/W_HOME  (  714): event_manager.c: _home_scroll_cb(564) > scroll,done
12-11 21:15:03.535+0900 W/W_HOME  (  714): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
12-11 21:15:04.000+0900 I/CAPI_WATCH_APPLICATION(13795): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 21:15:04.155+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 21:15:04.225+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 21:15:04.340+0900 E/blackandwhite(13795): blackandwhite.c: update_watch(149) > colorT : 0
12-11 21:15:05.015+0900 I/CAPI_WATCH_APPLICATION(13795): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 21:15:05.135+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 21:15:05.270+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 21:15:05.315+0900 E/blackandwhite(13795): blackandwhite.c: update_watch(149) > colorT : 0
12-11 21:15:06.000+0900 I/CAPI_WATCH_APPLICATION(13795): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 21:15:06.125+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 21:15:06.220+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 21:15:06.295+0900 E/blackandwhite(13795): blackandwhite.c: update_watch(149) > colorT : 0
12-11 21:15:07.005+0900 I/CAPI_WATCH_APPLICATION(13795): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 21:15:07.120+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 21:15:07.195+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 21:15:07.275+0900 E/blackandwhite(13795): blackandwhite.c: update_watch(149) > colorT : 0
12-11 21:15:08.000+0900 I/CAPI_WATCH_APPLICATION(13795): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 21:15:08.020+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 21:15:08.045+0900 I/CAPI_NETWORK_WIFI(13795): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 21:15:08.110+0900 E/blackandwhite(13795): blackandwhite.c: update_watch(149) > colorT : 0
12-11 21:15:08.165+0900 E/PKGMGR  (14038): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 21:15:08.345+0900 E/PKGMGR_SERVER(14040): pkgmgr-server.c: main(2126) > package manager server start
12-11 21:15:08.450+0900 E/PKGMGR_SERVER(14040): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1177942696], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_1177942696' '-r' 'org.reolab.blackandwhite'], cookie=[vlKJaojqC1I98iFlpxOgm2+UzAA=], backend_flag=[0]
12-11 21:15:08.450+0900 E/PKGMGR  (14040): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 21:15:08.450+0900 E/PKGMGR_SERVER(14040): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 21:15:08.460+0900 E/PKGMGR  (14038): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[140380002]
12-11 21:15:08.460+0900 E/PKGMGR_SERVER(14041): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 21:15:08.640+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 21:15:08.640+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 21:15:08.650+0900 W/AUL_AMD (  475): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 21:15:08.665+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 21:15:08.670+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 1 -> 2
12-11 21:15:08.670+0900 E/WMS     (  480): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-11 21:15:08.670+0900 E/WMS     (  480): ==========
12-11 21:15:08.670+0900 E/WMS     (  480): ##WMS SEND : mgr_gear_wear_onoff_req
12-11 21:15:08.670+0900 E/WMS     (  480): ==========
12-11 21:15:08.670+0900 E/WMS     (  480): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-11 21:15:08.715+0900 W/SHealth_Service( 1049): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
12-11 21:15:08.715+0900 E/SHealth_Service( 1049): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-11 21:15:09.000+0900 I/CAPI_WATCH_APPLICATION(13795): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-11 21:15:09.270+0900 W/CRASH_MANAGER(14043): worker.c: worker_job(1199) > 1113795626c61144983610
