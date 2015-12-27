S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 28045
Date: 2015-12-07 22:09:42+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x3c

Register Information
r0   = 0x0000003f, r1   = 0x0000003c
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x4145474e
r6   = 0xbe8429a0, r7   = 0x0000003f
r8   = 0x00000034, r9   = 0x41424ec0
r10  = 0x41454719, fp   = 0xbe842994
ip   = 0x00000000, sp   = 0xbe842430
lr   = 0x404b35b8, pc   = 0x404e6dc4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     23732 KB
Buffers:     17852 KB
Cached:      96852 KB
VmPeak:      67228 KB
VmSize:      66716 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13456 KB
VmRSS:       13456 KB
VmData:      12404 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20488 KB
VmPTE:          48 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 28045 TID = 28045
28045 28081 

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
41453000 41455000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
4145d000 4145f000 r-xp /usr/lib/libdri2.so.0.0.0
41467000 4146c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41474000 41476000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4147f000 41485000 r-xp /usr/lib/libappsvc.so.0.1.0
4148d000 414b1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414ba000 414c4000 r-xp /lib/libnss_files-2.13.so
414cd000 414d1000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
414e1000 414e8000 r-xp /usr/lib/libappcore-watch.so.1.1
414f1000 414f6000 rw-p [heap]
414f6000 41517000 rw-p [heap]
41517000 415e6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
418ba000 418bf000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
418c7000 418d4000 r-xp /usr/lib/libalarm.so.0.0.0
418dd000 41a1a000 r-xp /usr/lib/libicui18n.so.51.1
41a2a000 41b0e000 r-xp /usr/lib/libicuuc.so.51.1
41b23000 41b29000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41b31000 41b37000 r-xp /usr/lib/libwidget.so.1.0.0
41b40000 41b45000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
430d4000 430dd000 r-xp /usr/lib/libcom-core.so.0.0.1
430e6000 430f2000 r-xp /usr/lib/libwidget_service.so.1.0.0
430fa000 43103000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4310c000 43114000 r-xp /usr/lib/libdrm.so.2.4.0
4311c000 43123000 r-xp /usr/lib/libtbm.so.1.0.0
4355d000 43d5c000 rw-p [stack:28081]
43d5c000 43d5f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d67000 43d72000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dfa000 43e11000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
be823000 be844000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28045)
Call Stack Count: 1
 0: strlen + 0x4 (0x404e6dc4) [/lib/libc.so.6] + 0x72dc4
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
vent_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:50.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(58) ev->cur.canvas.y(189)
12-07 22:09:50.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:50.509+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80930633 button=1 downs=0
12-07 22:09:50.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:50.659+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x4ac3b6e0 : elm_scroller] CurrentPage(10)
12-07 22:09:50.714+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:50.714+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(246) ev->cur.canvas.y(216)
12-07 22:09:50.714+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:50.714+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80930873 button=1 downs=1
12-07 22:09:50.724+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:50.724+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(243) ev->cur.canvas.y(213)
12-07 22:09:50.724+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:50.734+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:50.734+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(226) ev->cur.canvas.y(209)
12-07 22:09:50.734+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:50.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:50.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(202) ev->cur.canvas.y(206)
12-07 22:09:50.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:50.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:50.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:50.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:50.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:50.754+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:50.754+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(175) ev->cur.canvas.y(201)
12-07 22:09:50.754+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:50.754+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:50.754+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:50.779+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:50.779+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(146) ev->cur.canvas.y(196)
12-07 22:09:50.779+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:50.779+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:50.779+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(114) ev->cur.canvas.y(188)
12-07 22:09:50.779+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:50.784+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:50.784+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:50.839+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:50.844+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(78) ev->cur.canvas.y(181)
12-07 22:09:50.844+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:50.844+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80930969 button=1 downs=0
12-07 22:09:50.844+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.009+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x4ac3b6e0 : elm_scroller] CurrentPage(11)
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(240) ev->cur.canvas.y(226)
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.039+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80931172 button=1 downs=1
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(238) ev->cur.canvas.y(225)
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(233) ev->cur.canvas.y(224)
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(218) ev->cur.canvas.y(220)
12-07 22:09:51.039+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(195) ev->cur.canvas.y(213)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(169) ev->cur.canvas.y(205)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(140) ev->cur.canvas.y(201)
12-07 22:09:51.064+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.069+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:51.069+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:51.104+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.104+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(107) ev->cur.canvas.y(195)
12-07 22:09:51.104+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.104+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.104+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(71) ev->cur.canvas.y(190)
12-07 22:09:51.104+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.104+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80931269 button=1 downs=0
12-07 22:09:51.104+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.264+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x4ac3b6e0 : elm_scroller] CurrentPage(12)
12-07 22:09:51.304+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.304+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(253) ev->cur.canvas.y(221)
12-07 22:09:51.304+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.304+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80931464 button=1 downs=1
12-07 22:09:51.309+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.309+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(250) ev->cur.canvas.y(217)
12-07 22:09:51.309+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.319+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.319+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(242) ev->cur.canvas.y(213)
12-07 22:09:51.319+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(224) ev->cur.canvas.y(208)
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(198) ev->cur.canvas.y(203)
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:51.334+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:51.359+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.359+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(167) ev->cur.canvas.y(198)
12-07 22:09:51.359+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.359+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:51.359+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:51.379+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.379+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(136) ev->cur.canvas.y(193)
12-07 22:09:51.379+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.379+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.379+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(105) ev->cur.canvas.y(183)
12-07 22:09:51.379+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.379+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.379+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(66) ev->cur.canvas.y(172)
12-07 22:09:51.379+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.384+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:51.384+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:51.404+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80931561 button=1 downs=0
12-07 22:09:51.404+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.534+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x4ac3b6e0 : elm_scroller] CurrentPage(13)
12-07 22:09:51.579+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.579+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(241) ev->cur.canvas.y(224)
12-07 22:09:51.579+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.584+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80931749 button=1 downs=1
12-07 22:09:51.599+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.604+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(237) ev->cur.canvas.y(223)
12-07 22:09:51.604+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.604+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.604+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(223) ev->cur.canvas.y(221)
12-07 22:09:51.604+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(199) ev->cur.canvas.y(214)
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(173) ev->cur.canvas.y(209)
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:51.624+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:51.664+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.669+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(143) ev->cur.canvas.y(208)
12-07 22:09:51.669+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.669+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.669+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(110) ev->cur.canvas.y(206)
12-07 22:09:51.669+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.669+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.669+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(73) ev->cur.canvas.y(201)
12-07 22:09:51.669+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.669+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:51.669+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:51.739+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80931835 button=1 downs=0
12-07 22:09:51.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.889+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.889+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(235) ev->cur.canvas.y(226)
12-07 22:09:51.889+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.889+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80932031 button=1 downs=1
12-07 22:09:51.889+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.889+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(229) ev->cur.canvas.y(226)
12-07 22:09:51.889+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.889+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.889+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(216) ev->cur.canvas.y(223)
12-07 22:09:51.889+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(194) ev->cur.canvas.y(215)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(165) ev->cur.canvas.y(209)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(136) ev->cur.canvas.y(207)
12-07 22:09:51.914+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.919+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:51.919+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:51.954+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.954+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(107) ev->cur.canvas.y(207)
12-07 22:09:51.954+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.954+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:51.954+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(72) ev->cur.canvas.y(203)
12-07 22:09:51.954+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:51.954+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80932117 button=1 downs=0
12-07 22:09:51.959+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:52.109+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x4ac3b6e0 : elm_scroller] CurrentPage(15)
12-07 22:09:52.154+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.154+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(233) ev->cur.canvas.y(214)
12-07 22:09:52.154+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.154+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80932311 button=1 downs=1
12-07 22:09:52.154+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.154+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(233) ev->cur.canvas.y(211)
12-07 22:09:52.154+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.174+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.174+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(223) ev->cur.canvas.y(209)
12-07 22:09:52.174+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.174+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.174+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(200) ev->cur.canvas.y(203)
12-07 22:09:52.174+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(173) ev->cur.canvas.y(198)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(144) ev->cur.canvas.y(195)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(112) ev->cur.canvas.y(190)
12-07 22:09:52.204+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.209+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:52.209+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:52.244+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.244+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(78) ev->cur.canvas.y(184)
12-07 22:09:52.244+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.244+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.244+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(45) ev->cur.canvas.y(172)
12-07 22:09:52.244+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.244+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80932408 button=1 downs=0
12-07 22:09:52.244+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:52.394+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x4ac3b6e0 : elm_scroller] CurrentPage(16)
12-07 22:09:52.434+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.434+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(240) ev->cur.canvas.y(222)
12-07 22:09:52.434+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.434+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80932602 button=1 downs=1
12-07 22:09:52.454+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.454+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(237) ev->cur.canvas.y(220)
12-07 22:09:52.454+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.459+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.459+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(223) ev->cur.canvas.y(218)
12-07 22:09:52.459+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(196) ev->cur.canvas.y(212)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(161) ev->cur.canvas.y(206)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(131) ev->cur.canvas.y(206)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.484+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:52.494+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:52.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(96) ev->cur.canvas.y(206)
12-07 22:09:52.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(61) ev->cur.canvas.y(201)
12-07 22:09:52.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:52.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:52.534+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80932687 button=1 downs=0
12-07 22:09:52.534+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:52.679+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x4ac3b6e0 : elm_scroller] CurrentPage(17)
12-07 22:09:52.719+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.719+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(218) ev->cur.canvas.y(219)
12-07 22:09:52.719+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.719+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80932878 button=1 downs=1
12-07 22:09:52.719+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.719+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(215) ev->cur.canvas.y(217)
12-07 22:09:52.719+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(206) ev->cur.canvas.y(215)
12-07 22:09:52.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(187) ev->cur.canvas.y(208)
12-07 22:09:52.744+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(162) ev->cur.canvas.y(205)
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(136) ev->cur.canvas.y(204)
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0), locked_x(0)
12-07 22:09:52.764+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(4ac3b6e0)
12-07 22:09:52.799+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.799+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(105) ev->cur.canvas.y(200)
12-07 22:09:52.799+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.799+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), block(1)
12-07 22:09:52.799+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), ev->cur.canvas.x(69) ev->cur.canvas.y(195)
12-07 22:09:52.799+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(4ac3b6e0), hold(0) freeze(0)
12-07 22:09:52.799+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80932964 button=1 downs=0
12-07 22:09:52.804+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(4ac3b6e0), type(elm_scroller)
12-07 22:09:52.969+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x4ac3b6e0 : elm_scroller] CurrentPage(18)
12-07 22:09:53.139+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1128045626c61144949378
