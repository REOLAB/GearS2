S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 26978
Date: 2015-12-07 22:04:46+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xba8

Register Information
r0   = 0x4030b9c0, r1   = 0xbe8f45f8
r2   = 0x5c1d7900, r3   = 0x00000000
r4   = 0xbe8f4560, r5   = 0xbe8f42f8
r6   = 0x00000132, r7   = 0x4198a4d0
r8   = 0x4030b9c0, r9   = 0x41460078
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4155c8f8, sp   = 0xbe8f42d0
lr   = 0x41554175, pc   = 0x00000ba8
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     23192 KB
Buffers:     16812 KB
Cached:      96172 KB
VmPeak:      76244 KB
VmSize:      75732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14676 KB
VmRSS:       14676 KB
VmData:      21472 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20468 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 26978 TID = 26978
26978 27396 27402 

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
41553000 41555000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
4155d000 4155f000 r-xp /usr/lib/libdri2.so.0.0.0
41567000 4156c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41574000 41576000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4157f000 41585000 r-xp /usr/lib/libappsvc.so.0.1.0
4158d000 415b1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415ba000 41689000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4169f000 416a9000 r-xp /lib/libnss_files-2.13.so
41970000 41974000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41984000 4198b000 r-xp /usr/lib/libappcore-watch.so.1.1
41994000 419a1000 r-xp /usr/lib/libalarm.so.0.0.0
419aa000 41ae7000 r-xp /usr/lib/libicui18n.so.51.1
41af7000 41bdb000 r-xp /usr/lib/libicuuc.so.51.1
41bf0000 41bf6000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41bfe000 41c04000 r-xp /usr/lib/libwidget.so.1.0.0
43194000 4319d000 r-xp /usr/lib/libcom-core.so.0.0.1
431a6000 431b2000 r-xp /usr/lib/libwidget_service.so.1.0.0
431ba000 431c3000 r-xp /usr/lib/libwidget_provider.so.1.0.0
431cc000 431d4000 r-xp /usr/lib/libdrm.so.2.4.0
431dc000 431e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
431e9000 431f0000 r-xp /usr/lib/libtbm.so.1.0.0
4352a000 43d29000 rw-p [stack:27396]
43d29000 43d2c000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d34000 43d3f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dc7000 43dde000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4401e000 44900000 rw-p [stack:27402]
be8d4000 be8f5000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26978)
Call Stack Count: 1
 0: (0xba8) (null)
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
0 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(96) ev->cur.canvas.y(245)
12-07 22:04:17.869+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:17.874+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(44319a48), locked_x(0)
12-07 22:04:17.874+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3851 _elm_scroll_hold_animator() [DDO] obj(44319a48)
12-07 22:04:17.889+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:17.889+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(96) ev->cur.canvas.y(243)
12-07 22:04:17.889+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:17.889+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:17.889+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(96) ev->cur.canvas.y(240)
12-07 22:04:17.889+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:17.894+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(44319a48), locked_x(0)
12-07 22:04:17.894+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3851 _elm_scroll_hold_animator() [DDO] obj(44319a48)
12-07 22:04:17.909+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:17.909+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(96) ev->cur.canvas.y(238)
12-07 22:04:17.909+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:17.909+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:17.909+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(96) ev->cur.canvas.y(237)
12-07 22:04:17.909+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:17.914+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(44319a48), locked_x(0)
12-07 22:04:17.914+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3851 _elm_scroll_hold_animator() [DDO] obj(44319a48)
12-07 22:04:17.929+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:17.929+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(96) ev->cur.canvas.y(236)
12-07 22:04:17.929+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:17.929+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:17.929+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(96) ev->cur.canvas.y(235)
12-07 22:04:17.929+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:17.934+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(44319a48), locked_x(0)
12-07 22:04:17.934+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3851 _elm_scroll_hold_animator() [DDO] obj(44319a48)
12-07 22:04:17.949+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:17.949+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(95) ev->cur.canvas.y(234)
12-07 22:04:17.949+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:17.954+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(44319a48), locked_x(0)
12-07 22:04:17.954+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3851 _elm_scroll_hold_animator() [DDO] obj(44319a48)
12-07 22:04:17.969+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:17.974+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(94) ev->cur.canvas.y(234)
12-07 22:04:17.974+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:17.974+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:17.974+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(92) ev->cur.canvas.y(234)
12-07 22:04:17.974+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:17.974+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(44319a48), locked_x(0)
12-07 22:04:17.974+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3851 _elm_scroll_hold_animator() [DDO] obj(44319a48)
12-07 22:04:17.984+0900 E/EFL     ( 2543): evas_main<2543> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80598150 button=1 downs=0
12-07 22:04:17.984+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(44319a48), type(elm_genlist)
12-07 22:04:19.714+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-07 22:04:21.074+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-07 22:04:21.079+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-07 22:04:23.084+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:23.084+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(183) ev->cur.canvas.y(69)
12-07 22:04:23.084+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:23.084+0900 E/EFL     ( 2543): evas_main<2543> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80603254 button=1 downs=1
12-07 22:04:23.084+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:23.084+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(187) ev->cur.canvas.y(83)
12-07 22:04:23.084+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:23.089+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:23.089+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(187) ev->cur.canvas.y(105)
12-07 22:04:23.089+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:23.089+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:04:23.089+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(44319a48), type(elm_genlist)
12-07 22:04:23.089+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:04:23.089+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3404 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_y_set : obj(44319a48), type(elm_genlist)
12-07 22:04:23.099+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(44319a48), locked_x(0)
12-07 22:04:23.099+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3851 _elm_scroll_hold_animator() [DDO] obj(44319a48)
12-07 22:04:23.129+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:23.129+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(185) ev->cur.canvas.y(133)
12-07 22:04:23.129+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:23.129+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:23.129+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(182) ev->cur.canvas.y(166)
12-07 22:04:23.129+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:23.129+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:23.129+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(178) ev->cur.canvas.y(200)
12-07 22:04:23.129+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:23.129+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(44319a48), locked_x(0)
12-07 22:04:23.129+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3851 _elm_scroll_hold_animator() [DDO] obj(44319a48)
12-07 22:04:23.154+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:23.154+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(172) ev->cur.canvas.y(236)
12-07 22:04:23.154+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:23.154+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:23.154+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(164) ev->cur.canvas.y(268)
12-07 22:04:23.154+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:23.159+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(44319a48), locked_x(0)
12-07 22:04:23.159+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3851 _elm_scroll_hold_animator() [DDO] obj(44319a48)
12-07 22:04:23.179+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), block(1)
12-07 22:04:23.184+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), ev->cur.canvas.x(153) ev->cur.canvas.y(291)
12-07 22:04:23.184+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(44319a48), hold(0) freeze(0)
12-07 22:04:23.184+0900 E/EFL     ( 2543): evas_main<2543> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80603339 button=1 downs=0
12-07 22:04:23.184+0900 E/EFL     ( 2543): elementary<2543> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(44319a48), type(elm_genlist)
12-07 22:04:23.629+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=52   flick_area=55 ---> SET value to 1
12-07 22:04:23.629+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
12-07 22:04:23.629+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=52   flick_area=55 ---> SET value to 1
12-07 22:04:23.689+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
12-07 22:04:23.719+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:04:23.719+0900 W/AUL_AMD (  495): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-07 22:04:23.764+0900 I/MALI    (  715): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442b6d88] swap changed from sync to async
12-07 22:04:23.834+0900 W/PROCESSMGR(  365): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
12-07 22:04:23.834+0900 W/WATCH_CORE(26823): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
12-07 22:04:23.834+0900 I/WATCH_CORE(26823): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
12-07 22:04:23.834+0900 W/W_HOME  (  715): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
12-07 22:04:23.834+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:04:23.834+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:04:23.834+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:04:23.834+0900 W/W_HOME  (  715): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
12-07 22:04:23.859+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(0)
12-07 22:04:23.859+0900 W/W_HOME  (  715): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
12-07 22:04:23.859+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:04:23.859+0900 W/W_HOME  (  715): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(0)
12-07 22:04:23.859+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: RESUME State: PAUSED
12-07 22:04:23.859+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-07 22:04:23.859+0900 W/W_HOME  (  715): main.c: _appcore_resume_cb(681) > appcore resume
12-07 22:04:23.859+0900 W/W_HOME  (  715): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
12-07 22:04:23.859+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:04:23.859+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:04:23.859+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-07 22:04:23.859+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
12-07 22:04:23.859+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:04:23.864+0900 I/APP_CORE( 2543): appcore-efl.c: __do_app(429) > [APP 2543] Event: PAUSE State: RUNNING
12-07 22:04:23.864+0900 I/CAPI_APPFW_APPLICATION( 2543): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-07 22:04:23.864+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
12-07 22:04:23.864+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:04:23.864+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-07 22:04:23.884+0900 I/RESOURCED(  498): vmpressure-lowmem-handler.c: lowmem_swap_memory(1113) > [lowmem_swap_memory,1113] available = 129
12-07 22:04:23.884+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
12-07 22:04:23.889+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
12-07 22:04:24.254+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=53   flick_area=55 ---> SET value to 1
12-07 22:04:24.254+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=0  value=1
12-07 22:04:24.254+0900 E/GESTURE (  139): gesture.c: GestureHandleButtonPressEvent(3383) > root_y=53   flick_area=55 ---> SET value to 1
12-07 22:04:24.314+0900 I/MALI    (  715): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442b6d88] swap changed from async to sync
12-07 22:04:24.329+0900 E/GESTURE (  139): gesture.c: GestureSetRootProperty(337) > wc1_backkey_region_status=1  value=0
12-07 22:04:24.334+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1182) > Home view event: 0x40000
12-07 22:04:24.334+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_view_event_handler(1228) > On the cover view. Go to home.
12-07 22:04:24.334+0900 W/W_HOME  (  715): noti_broker.c: _noti_broker_back_cb(764) > continue the back key execution
12-07 22:04:24.334+0900 E/W_HOME  (  715): cs_broker.c: _cs_broker_back_cb(240) > (s_info.is_displayed == 0) -> _cs_broker_back_cb() return
12-07 22:04:24.334+0900 W/W_HOME  (  715): scroller.c: _get_index_in_list(1902) > page:0x49c82ba8 idx:2 total11 exist:1
12-07 22:04:24.334+0900 W/W_HOME  (  715): clock_event.c: _back_key_cb(278) > 
12-07 22:04:24.349+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:4005042b
12-07 22:04:24.349+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88128), origin_x(0), origin_y(0)
12-07 22:04:24.364+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,start
12-07 22:04:24.369+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.369+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.384+0900 W/WATCH_CORE(26823): appcore-watch.c: __widget_resume(1012) > widget_resume
12-07 22:04:24.384+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.384+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.384+0900 I/CAPI_WATCH_APPLICATION(26823): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:24.404+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.404+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.424+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.424+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.434+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.434+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.454+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.454+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.469+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.469+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.484+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.489+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.504+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.504+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.519+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.519+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.534+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.534+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.549+0900 W/W_HOME  (  715): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-07 22:04:24.549+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:04:24.559+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.559+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.564+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-07 22:04:24.574+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.574+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.584+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.584+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.599+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.599+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.619+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:04:24.619+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:04:24.639+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-07 22:04:24.639+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88128 : elm_scroller] CurrentPage(2)
12-07 22:04:24.774+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:04:24.869+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:04:24.874+0900 E/CAPI_APPFW_APP_CONTROL( 1081): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-07 22:04:24.874+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1081]   value = [true][0m
12-07 22:04:24.889+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:04:24.909+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 715
12-07 22:04:24.929+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT][0m
12-07 22:04:24.939+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:04:24.939+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:04:24.939+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:04:24.939+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:04:24.939+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:04:24.939+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:04:24.939+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 22:04:24.939+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:04:24.944+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:04:24.944+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:04:24.944+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:04:24.944+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:04:24.944+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:04:24.944+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:04:24.944+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 22:04:24.944+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:04:24.944+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:04:24.944+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:04:24.944+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT][0m
12-07 22:04:24.949+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:04:24.949+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:04:24.949+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:04:24.949+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:04:24.949+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:04:24.949+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:04:24.949+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 22:04:24.949+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 22:04:24.954+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:04:24.954+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:04:24.954+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-07 22:04:24.954+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-07 22:04:24.954+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:04:24.959+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:04:24.959+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:04:24.959+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:04:24.959+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:04:24.959+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:04:24.959+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:04:24.959+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-07 22:04:24.959+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:04:24.959+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:04:24.959+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:04:24.999+0900 I/CAPI_WATCH_APPLICATION(26823): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:25.139+0900 W/W_HOME  (  715): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
12-07 22:04:25.999+0900 I/CAPI_WATCH_APPLICATION(26823): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:26.999+0900 I/CAPI_WATCH_APPLICATION(26823): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:27.999+0900 I/CAPI_WATCH_APPLICATION(26823): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:28.889+0900 I/APP_CORE( 2543): appcore-efl.c: __do_app(429) > [APP 2543] Event: MEM_FLUSH State: PAUSED
12-07 22:04:29.019+0900 I/CAPI_WATCH_APPLICATION(26823): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:30.004+0900 I/CAPI_WATCH_APPLICATION(26823): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:30.414+0900 E/PKGMGR_SERVER(27381): pkgmgr-server.c: main(2126) > package manager server start
12-07 22:04:30.544+0900 E/PKGMGR_SERVER(27381): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_2137437514], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-07 22:04:30.554+0900 E/PKGMGR  (27375): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-07 22:04:30.554+0900 E/PKGMGR_SERVER(27383): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-07 22:04:30.624+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:04:30.629+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26823
12-07 22:04:30.634+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:04:30.639+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 5
12-07 22:04:30.644+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(26823), cmd(4)
12-07 22:04:30.644+0900 W/CAPI_WATCH_APPLICATION(26823): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-07 22:04:30.644+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 22:04:30.644+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(884) > app status : 4
12-07 22:04:30.644+0900 W/WATCH_CORE(26823): appcore-watch.c: __widget_destroy(992) > widget_destory
12-07 22:04:30.644+0900 E/WIDGET_PROVIDER_APP(26823): client.c: client_fini(1175) > Provider is not initialized
12-07 22:04:30.649+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 22:04:30.649+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:04:30.659+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 22:04:30.669+0900 E/PKGMGR_SERVER(27383): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-07 22:04:30.684+0900 E/PKGMGR_SERVER(27381): pkgmgr-server.c: sighandler(445) > child NORMAL exit [27383]
12-07 22:04:30.849+0900 E/AUL_AMD (  495): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-07 22:04:30.849+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(26823), cmd(4)
12-07 22:04:30.869+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:04:31.009+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:04:31.114+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:04:31.114+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 22:04:31.114+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 22:04:31.364+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 22:04:31.364+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 22:04:31.364+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 22:04:31.364+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-07 22:04:31.369+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 22:04:31.389+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 22:04:31.409+0900 E/TBM     (26978): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 22:04:31.469+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 26823
12-07 22:04:31.504+0900 W/WATCH_CORE(26978): appcore-watch.c: __widget_create(958) > widget_create
12-07 22:04:31.514+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [76046.937500] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29360980:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 22:04:31.514+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[76046.937500] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29360980:4] gbar_fname[]
12-07 22:04:31.524+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 22:04:31.524+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 22:04:31.589+0900 W/WATCH_CORE(26978): appcore-watch.c: __widget_create(976) > widget_create done
12-07 22:04:31.669+0900 I/WATCH_CORE(26978): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-07 22:04:31.669+0900 I/WATCH_CORE(26978): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-07 22:04:31.669+0900 I/WATCH_CORE(26978): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-07 22:04:31.704+0900 W/WATCH_CORE(26978): appcore-watch.c: __widget_resume(1012) > widget_resume
12-07 22:04:31.734+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:31.999+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:32.469+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:04:32.469+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:04:32.484+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:04:32.489+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 26978
12-07 22:04:32.494+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:04:32.644+0900 W/AUL_AMD (  495): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 22:04:32.689+0900 I/AUL_PAD (27419): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 22:04:32.829+0900 E/PKGMGR_SERVER(27381): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 22:04:32.829+0900 E/PKGMGR_SERVER(27381): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 22:04:32.999+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:34.004+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:35.004+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:36.009+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:37.004+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:38.009+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:39.004+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:39.999+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:40.999+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:41.999+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:43.004+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:44.004+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:44.999+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:45.329+0900 E/PKGMGR  (27551): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-07 22:04:45.509+0900 E/PKGMGR_SERVER(27553): pkgmgr-server.c: main(2126) > package manager server start
12-07 22:04:45.644+0900 E/PKGMGR_SERVER(27553): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-2142476177], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-2142476177' '-r' 'org.reolab.blackandwhite'], cookie=[UZ+kbW5gM44htg21jcaQ7Nyf65A=], backend_flag=[0]
12-07 22:04:45.644+0900 E/PKGMGR  (27553): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-07 22:04:45.644+0900 E/PKGMGR_SERVER(27553): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-07 22:04:45.654+0900 E/PKGMGR  (27551): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[275510002]
12-07 22:04:45.654+0900 E/PKGMGR_SERVER(27554): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-07 22:04:45.824+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-07 22:04:45.829+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 22:04:45.844+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:04:45.844+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-07 22:04:45.999+0900 I/CAPI_WATCH_APPLICATION(26978): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:04:46.229+0900 W/CRASH_MANAGER(27557): worker.c: worker_job(1199) > 1126978626c61144949348
