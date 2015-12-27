S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 3028
Date: 2015-12-10 20:30:08+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1d

Register Information
r0   = 0x0000001d, r1   = 0x00000000
r2   = 0x4059a250, r3   = 0x00000029
r4   = 0xbeb9f540, r5   = 0x00000168
r6   = 0x00000168, r7   = 0xbeb9ea58
r8   = 0x00000168, r9   = 0x00000168
r10  = 0x00000000, fp   = 0x00000000
ip   = 0x407ffd68, sp   = 0xbeb9ea40
lr   = 0x404e31e8, pc   = 0x41454436
cpsr = 0x20000030

Memory Information
MemTotal:   490732 KB
MemFree:     10824 KB
Buffers:     17608 KB
Cached:     180272 KB
VmPeak:      95280 KB
VmSize:      94768 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15424 KB
VmRSS:       15420 KB
VmData:      38240 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3028 TID = 3028
3028 3422 3430 

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
41a89000 41ac0000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41ac9000 41ae2000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41aeb000 41b15000 r-xp /usr/lib/libnfc.so.1.0.0
41b1e000 41b4f000 r-xp /usr/lib/libmdm.so.1.1.85
41b57000 41b6d000 r-xp /usr/lib/libnetwork.so.0.0.0
41b76000 41b7b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
41b83000 41b8c000 r-xp /usr/lib/libcom-core.so.0.0.1
41b95000 41ba1000 r-xp /usr/lib/libwidget_service.so.1.0.0
41ba9000 41bb2000 r-xp /usr/lib/libwidget_provider.so.1.0.0
41bbb000 41bc1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41bc9000 41bd1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41bd9000 41c07000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
41c13000 41c1b000 r-xp /usr/lib/libdrm.so.2.4.0
41c23000 41c25000 r-xp /usr/lib/libdri2.so.0.0.0
41c2d000 41c34000 r-xp /usr/lib/libtbm.so.1.0.0
41c3c000 41c56000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41c5f000 41c66000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41c6f000 41c71000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41c79000 41c80000 r-xp /usr/lib/libminizip.so.1.0.0
41c88000 41c95000 r-xp /usr/lib/libail.so.0.1.0
41e9e000 41ea1000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
41ea9000 41eb4000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41ecc000 41ece000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41ed6000 41edf000 rw-p [heap]
41edf000 42011000 rw-p [heap]
437ca000 43fc9000 rw-p [stack:3422]
44048000 4405f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
45401000 45cdb000 rw-p [stack:3430]
beb7f000 beba0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3028)
Call Stack Count: 18
 0: getBTStatus + 0x35 (0x41454436) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1436
 1: update_watch + 0x50 (0x41454705) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1705
 2: create_base_gui + 0x376 (0x41454d5f) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1d5f
 3: app_create + 0x2c (0x414545c1) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x15c1
 4: (0x417884d5) [/usr/lib/libappcore-watch.so.1] + 0x44d5
 5: (0x4178666b) [/usr/lib/libappcore-watch.so.1] + 0x266b
 6: (0x41a61bff) [/usr/lib/libwidget_provider_app.so.1] + 0x2bff
 7: widget_provider_send_hello_sync + 0x166 (0x41bb0017) [/usr/lib/libwidget_provider.so.1] + 0x7017
 8: (0x41a61c4b) [/usr/lib/libwidget_provider_app.so.1] + 0x2c4b
 9: widget_provider_init + 0xb8 (0x41bafced) [/usr/lib/libwidget_provider.so.1] + 0x6ced
10: (0x41a6234d) [/usr/lib/libwidget_provider_app.so.1] + 0x334d
11: widget_provider_app_init_sync + 0x2c (0x41a62f51) [/usr/lib/libwidget_provider_app.so.1] + 0x3f51
12: watch_core_main + 0xb2 (0x417875e3) [/usr/lib/libappcore-watch.so.1] + 0x35e3
13: watch_app_main + 0xca (0x41788753) [/usr/lib/libappcore-watch.so.1] + 0x4753
14: main + 0xc6 (0x4145452f) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x152f
15: create_base_gui + 0x6a (0x40001a53) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1a53
16: __libc_start_main + 0x114 (0x4048b82c) [/lib/libc.so.6] + 0x1782c
17: __libc_csu_init + 0x58 (0x40001e18) [/opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite] + 0x1e18
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
_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(297) ev->cur.canvas.y(213)
12-10 20:30:05.156+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.156+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.156+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(290) ev->cur.canvas.y(205)
12-10 20:30:05.156+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.171+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.171+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(276) ev->cur.canvas.y(198)
12-10 20:30:05.171+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.186+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.186+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(258) ev->cur.canvas.y(198)
12-10 20:30:05.186+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.186+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-10 20:30:05.186+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(487dc808), type(elm_scroller)
12-10 20:30:05.186+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-10 20:30:05.186+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(487dc808), type(elm_scroller)
12-10 20:30:05.186+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.186+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(231) ev->cur.canvas.y(203)
12-10 20:30:05.186+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.191+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(487dc808), locked_x(0)
12-10 20:30:05.191+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(487dc808)
12-10 20:30:05.206+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.206+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(196) ev->cur.canvas.y(211)
12-10 20:30:05.206+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.206+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.206+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(155) ev->cur.canvas.y(220)
12-10 20:30:05.206+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.211+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(487dc808), locked_x(0)
12-10 20:30:05.211+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(487dc808)
12-10 20:30:05.231+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.231+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(111) ev->cur.canvas.y(231)
12-10 20:30:05.231+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.231+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=370716 button=1 downs=0
12-10 20:30:05.231+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(487dc808), type(elm_scroller)
12-10 20:30:05.371+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x487dc808 : elm_scroller] CurrentPage(15)
12-10 20:30:05.431+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.431+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(270) ev->cur.canvas.y(191)
12-10 20:30:05.431+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.431+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=370910 button=1 downs=1
12-10 20:30:05.436+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.436+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(268) ev->cur.canvas.y(188)
12-10 20:30:05.436+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.456+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.456+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(259) ev->cur.canvas.y(186)
12-10 20:30:05.456+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.456+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.456+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(242) ev->cur.canvas.y(185)
12-10 20:30:05.456+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.476+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.476+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(219) ev->cur.canvas.y(184)
12-10 20:30:05.476+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.476+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-10 20:30:05.476+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(487dc808), type(elm_scroller)
12-10 20:30:05.476+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-10 20:30:05.476+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(487dc808), type(elm_scroller)
12-10 20:30:05.481+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.481+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(192) ev->cur.canvas.y(184)
12-10 20:30:05.481+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.481+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(487dc808), locked_x(0)
12-10 20:30:05.481+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(487dc808)
12-10 20:30:05.511+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.511+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(160) ev->cur.canvas.y(188)
12-10 20:30:05.511+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.511+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.511+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(116) ev->cur.canvas.y(201)
12-10 20:30:05.511+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.511+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(487dc808), locked_x(0)
12-10 20:30:05.511+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(487dc808)
12-10 20:30:05.536+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=370996 button=1 downs=0
12-10 20:30:05.541+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(487dc808), type(elm_scroller)
12-10 20:30:05.676+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x487dc808 : elm_scroller] CurrentPage(16)
12-10 20:30:05.696+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.696+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(275) ev->cur.canvas.y(225)
12-10 20:30:05.696+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.696+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=371185 button=1 downs=1
12-10 20:30:05.711+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.711+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(268) ev->cur.canvas.y(222)
12-10 20:30:05.711+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.726+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.726+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(260) ev->cur.canvas.y(219)
12-10 20:30:05.726+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.731+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.731+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(248) ev->cur.canvas.y(219)
12-10 20:30:05.731+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.741+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.741+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(230) ev->cur.canvas.y(219)
12-10 20:30:05.741+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.741+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-10 20:30:05.741+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(487dc808), type(elm_scroller)
12-10 20:30:05.741+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-10 20:30:05.741+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(487dc808), type(elm_scroller)
12-10 20:30:05.741+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(487dc808), locked_x(0)
12-10 20:30:05.741+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(487dc808)
12-10 20:30:05.766+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.766+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(206) ev->cur.canvas.y(220)
12-10 20:30:05.766+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.766+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.766+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(179) ev->cur.canvas.y(222)
12-10 20:30:05.766+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.766+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(487dc808), locked_x(0)
12-10 20:30:05.766+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(487dc808)
12-10 20:30:05.796+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.796+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(147) ev->cur.canvas.y(226)
12-10 20:30:05.796+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.796+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.796+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(110) ev->cur.canvas.y(237)
12-10 20:30:05.796+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.796+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(487dc808), locked_x(0)
12-10 20:30:05.796+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(487dc808)
12-10 20:30:05.816+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=371282 button=1 downs=0
12-10 20:30:05.821+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(487dc808), type(elm_scroller)
12-10 20:30:05.951+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x487dc808 : elm_scroller] CurrentPage(17)
12-10 20:30:05.996+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:05.996+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(282) ev->cur.canvas.y(185)
12-10 20:30:05.996+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:05.996+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=371473 button=1 downs=1
12-10 20:30:06.001+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.001+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(273) ev->cur.canvas.y(179)
12-10 20:30:06.001+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.021+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.021+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(266) ev->cur.canvas.y(177)
12-10 20:30:06.021+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.021+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.021+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(251) ev->cur.canvas.y(176)
12-10 20:30:06.021+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.041+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.041+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(226) ev->cur.canvas.y(176)
12-10 20:30:06.041+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.041+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-10 20:30:06.041+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(487dc808), type(elm_scroller)
12-10 20:30:06.041+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-10 20:30:06.041+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(487dc808), type(elm_scroller)
12-10 20:30:06.041+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.046+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(199) ev->cur.canvas.y(179)
12-10 20:30:06.046+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.046+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(487dc808), locked_x(0)
12-10 20:30:06.046+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(487dc808)
12-10 20:30:06.076+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.076+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(168) ev->cur.canvas.y(185)
12-10 20:30:06.076+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.076+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.076+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(128) ev->cur.canvas.y(193)
12-10 20:30:06.076+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.076+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.076+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(77) ev->cur.canvas.y(202)
12-10 20:30:06.076+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.081+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(487dc808), locked_x(0)
12-10 20:30:06.081+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(487dc808)
12-10 20:30:06.116+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=371570 button=1 downs=0
12-10 20:30:06.116+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(487dc808), type(elm_scroller)
12-10 20:30:06.246+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x487dc808 : elm_scroller] CurrentPage(18)
12-10 20:30:06.606+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.606+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(269) ev->cur.canvas.y(190)
12-10 20:30:06.606+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.606+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=372091 button=1 downs=1
12-10 20:30:06.611+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.611+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(267) ev->cur.canvas.y(187)
12-10 20:30:06.611+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.626+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.626+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(258) ev->cur.canvas.y(187)
12-10 20:30:06.626+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.631+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.631+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(241) ev->cur.canvas.y(188)
12-10 20:30:06.631+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.641+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.641+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(224) ev->cur.canvas.y(189)
12-10 20:30:06.641+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.641+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-10 20:30:06.641+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(487dc808), type(elm_scroller)
12-10 20:30:06.641+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-10 20:30:06.641+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(487dc808), type(elm_scroller)
12-10 20:30:06.646+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(487dc808), locked_x(0)
12-10 20:30:06.646+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(487dc808)
12-10 20:30:06.681+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.681+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(206) ev->cur.canvas.y(190)
12-10 20:30:06.681+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.686+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.686+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(185) ev->cur.canvas.y(191)
12-10 20:30:06.686+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.686+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.686+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(160) ev->cur.canvas.y(193)
12-10 20:30:06.686+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.686+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(487dc808), locked_x(0)
12-10 20:30:06.691+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(487dc808)
12-10 20:30:06.721+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.721+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(128) ev->cur.canvas.y(197)
12-10 20:30:06.721+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.726+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:06.726+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(95) ev->cur.canvas.y(204)
12-10 20:30:06.726+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:06.726+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=372195 button=1 downs=0
12-10 20:30:06.726+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(487dc808), type(elm_scroller)
12-10 20:30:06.866+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x487dc808 : elm_scroller] CurrentPage(19)
12-10 20:30:07.136+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:07.136+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(172) ev->cur.canvas.y(171)
12-10 20:30:07.136+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:07.136+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=372617 button=1 downs=1
12-10 20:30:07.141+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), block(1)
12-10 20:30:07.141+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), ev->cur.canvas.x(170) ev->cur.canvas.y(173)
12-10 20:30:07.141+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(487dc808), hold(0) freeze(0)
12-10 20:30:07.201+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=372690 button=1 downs=0
12-10 20:30:07.336+0900 E/WMS     (  473): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-10 20:30:07.336+0900 E/WMS     (  473): ==========
12-10 20:30:07.336+0900 E/WMS     (  473): ##WMS SEND : mgr_clock_set_widget_req
12-10 20:30:07.336+0900 E/WMS     (  473): ==========
12-10 20:30:07.336+0900 E/WMS     (  473): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 80 MAX Buffer Size: 61440
12-10 20:30:07.366+0900 W/W_HOME  (  715): rotary.c: rotary_deattach(156) > rotary_deattach:0x487dc808
12-10 20:30:07.366+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8a688, elm_box, _activated_obj : 0x49a9aa20, activated : 1
12-10 20:30:07.366+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
12-10 20:30:07.371+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-10 20:30:07.371+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
12-10 20:30:07.376+0900 I/MESSAGE_PORT(  715): MessagePortProxy.cpp: IsLocalPortRegisted(695) > MessagePort name is already registered.
12-10 20:30:07.381+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 20:30:07.381+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 20:30:07.381+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 20:30:07.381+0900 I/MESSAGE_PORT(  437): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
12-10 20:30:07.381+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
12-10 20:30:07.381+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 20:30:07.381+0900 I/MESSAGE_PORT(  437): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.w-home:w-home::localport], client = 715
12-10 20:30:07.381+0900 I/MESSAGE_PORT(  437): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 20:30:07.386+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group page has a non-fixed part 'clipper'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-10 20:30:07.436+0900 W/W_HOME  (  715): clock_service.c: clock_service_event_handler(821) > scroller freeze off
12-10 20:30:07.436+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45c88108), freeze(0)
12-10 20:30:07.436+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45c88108), freeze(0)
12-10 20:30:07.436+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:4001f5a7
12-10 20:30:07.441+0900 W/W_HOME  (  715): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: org.reolab.blackandwhite 1 0 0 1
12-10 20:30:07.441+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-10 20:30:07.441+0900 E/W_HOME  (  715): clock_service.c: _clock_provider_change(396) > clock will be changed to org.reolab.blackandwhite
12-10 20:30:07.461+0900 E/W_HOME  (  715): dbox.c: widget_create(359) > add-viewer info none: org.reolab.blackandwhite
12-10 20:30:07.461+0900 W/W_HOME  (  715): clock_inf_dbox.c: _is_preload_watchface(166) > ret:1
12-10 20:30:07.461+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_resize(5435) > [SECURE_LOG] Failed to get box size
12-10 20:30:07.461+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_is_created_by_user(3452) > [SECURE_LOG] Handler is invalid
12-10 20:30:07.466+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-10 20:30:07.466+0900 E/W_HOME  (  715): clock_service.c: _set_waiting_timer(356) > clock waiting timer is started
12-10 20:30:07.471+0900 E/W_HOME  (  715): dbus_util.c: home_dbus_lcd_on_signal_send(225) > Sending LCD ON request signal wristup:0 result:0
12-10 20:30:07.471+0900 W/W_HOME  (  715): cs_broker.c: _wms_clock_vconf_cb(283) > 
12-10 20:30:07.471+0900 E/CLOCK-LIST(  715): clocklist_main.c: clock_setting_event(3637) > proxy image is not deleted. Ignore event
12-10 20:30:07.471+0900 W/W_HOME  (  715): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,will,hide
12-10 20:30:07.471+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 20:30:07.476+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 20:30:07.476+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-10 20:30:07.476+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
12-10 20:30:07.541+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-10 20:30:07.561+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 20:30:07.576+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 20:30:07.576+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-10 20:30:07.576+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 689
12-10 20:30:07.591+0900 E/RESOURCED(  476): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-10 20:30:07.596+0900 E/RESOURCED(  476): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-10 20:30:07.601+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-10 20:30:07.601+0900 W/AUL_PAD ( 1182): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-10 20:30:07.601+0900 W/AUL_PAD ( 1182): launchpad.c: __send_result_to_caller(265) > Check app launching
12-10 20:30:07.656+0900 I/CAPI_WATCH_APPLICATION( 3028): watch_app_main.c: watch_app_main(382) > watch_app_main
12-10 20:30:07.681+0900 E/TBM     ( 3028): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-10 20:30:07.706+0900 E/RESOURCED(  476): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.reolab.blackandwhite
12-10 20:30:07.706+0900 W/WATCH_CORE( 3034): appcore-watch.c: __widget_resume(1012) > widget_resume
12-10 20:30:07.706+0900 E/watchface-loader( 3034): watchface-loader.cpp: OnAppResume(725) > 
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [2] to pending list
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [7]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [7]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [7] to pending list
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [17]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [17]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [17] to pending list
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [30]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [30] to pending list
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [32]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [32]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [32] to pending list
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [34]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [34]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [34] to pending list
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [73]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [73] to pending list
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [77]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [77] to pending list
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [3]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [3] to pending list
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [1]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [1] to pending list
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [4]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 20:30:07.706+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: AddPendingChanges(1053) > added [4] to pending list
12-10 20:30:07.711+0900 I/CAPI_WATCH_APPLICATION( 3034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 20:30:07.711+0900 E/watchface-loader( 3034): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 20:30:07.711+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 20:30:07.711+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 20:30:07.711+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 20:30:07.711+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 20:30:07.776+0900 W/WATCH_CORE( 3028): appcore-watch.c: __widget_create(958) > widget_create
12-10 20:30:07.786+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [372.954163] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_372.954163.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-10 20:30:07.786+0900 W/W_HOME  (  715): dbox.c: _widget_created_cb(238) > widget resume:0x4a2bd020
12-10 20:30:07.786+0900 E/WIDGET_VIEWER(  715): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
12-10 20:30:07.801+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-10 20:30:07.801+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-10 20:30:07.891+0900 I/CAPI_WATCH_APPLICATION( 3034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 20:30:07.891+0900 E/watchface-loader( 3034): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 20:30:07.891+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 20:30:07.891+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 20:30:07.931+0900 I/CAPI_NETWORK_WIFI( 3028): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 20:30:07.941+0900 I/CAPI_NETWORK_WIFI( 3028): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 20:30:08.071+0900 I/CAPI_WATCH_APPLICATION( 3034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 20:30:08.071+0900 E/watchface-loader( 3034): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 20:30:08.071+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 20:30:08.071+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 20:30:08.071+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-10 20:30:08.071+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-10 20:30:08.261+0900 I/CAPI_WATCH_APPLICATION( 3034): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 20:30:08.261+0900 E/watchface-loader( 3034): watchface-loader.cpp: OnAppTimeTick(744) > 
12-10 20:30:08.261+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-10 20:30:08.261+0900 I/watchface-viewer( 3034): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-10 20:30:08.311+0900 W/CRASH_MANAGER( 3431): worker.c: worker_job(1199) > 1103028626c61144974700
