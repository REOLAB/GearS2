S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 6794
Date: 2015-12-10 22:08:14+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1c7

Register Information
r0   = 0x000001bb, r1   = 0x0000000d
r2   = 0x0000000b, r3   = 0x41553194
r4   = 0x000001bb, r5   = 0x00000000
r6   = 0x41893424, r7   = 0x414dd608
r8   = 0x00000087, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbe8fbc54, sp   = 0xbe8fbc08
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   490336 KB
MemFree:     29936 KB
Buffers:     21572 KB
Cached:     150304 KB
VmPeak:     111968 KB
VmSize:     111456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16400 KB
VmRSS:       16400 KB
VmData:      54476 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22388 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6794 TID = 6794
6794 7516 7527 

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
41a03000 41a09000 r-xp /usr/lib/libcore-context-manager.so.1.1.2
41a11000 41a1e000 r-xp /usr/lib/libalarm.so.0.0.0
41a27000 41b64000 r-xp /usr/lib/libicui18n.so.51.1
41b74000 41c58000 r-xp /usr/lib/libicuuc.so.51.1
41c6d000 41c73000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41c7b000 41c81000 r-xp /usr/lib/libwidget.so.1.0.0
41c8a000 41c8f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41c97000 41cce000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41cd7000 41cf0000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41cf9000 41d23000 r-xp /usr/lib/libnfc.so.1.0.0
41d2c000 41d5d000 r-xp /usr/lib/libmdm.so.1.1.85
41d65000 41d7b000 r-xp /usr/lib/libnetwork.so.0.0.0
41d84000 41d89000 r-xp /usr/lib/libcsc-feature.so.0.0.0
41d91000 41daf000 r-xp /usr/lib/libsensor.so.1.1.0
41db9000 41dc5000 r-xp /usr/lib/libcapi-context-manager.so.1.2.5
43355000 4335e000 r-xp /usr/lib/libcom-core.so.0.0.1
43367000 43373000 r-xp /usr/lib/libwidget_service.so.1.0.0
4337b000 43384000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4338d000 43393000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4339b000 433a3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
433ab000 433d9000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
433e5000 433ec000 r-xp /usr/lib/libsensord-share.so
433f4000 43403000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
4340c000 43414000 r-xp /usr/lib/libdrm.so.2.4.0
4341c000 4341e000 r-xp /usr/lib/libdri2.so.0.0.0
43426000 4342d000 r-xp /usr/lib/libtbm.so.1.0.0
43435000 4344f000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43458000 4345f000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43468000 4346a000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43472000 43479000 r-xp /usr/lib/libminizip.so.1.0.0
43481000 4348e000 r-xp /usr/lib/libail.so.0.1.0
437c9000 43fc8000 rw-p [stack:7516]
43fc8000 43fcb000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43fd3000 43fde000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
44066000 4407d000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
442bc000 442be000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
452c7000 45b00000 rw-p [stack:7527]
be8dc000 be8fd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6794)
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
(45c88300), ev->cur.canvas.x(136) ev->cur.canvas.y(157)
12-10 22:06:18.740+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:18.740+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88300), locked_x(0)
12-10 22:06:18.740+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88300)
12-10 22:06:18.740+0900 W/W_HOME  (  713): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-10 22:06:18.740+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:06:18.745+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:18.750+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-10 22:06:18.760+0900 E/EFL     ( 6552): evas_main<6552> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2304521 button=1 downs=0
12-10 22:06:18.760+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:18.760+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(159) ev->cur.canvas.y(160)
12-10 22:06:18.760+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:18.760+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:18.760+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(192) ev->cur.canvas.y(166)
12-10 22:06:18.760+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:18.760+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88300), locked_x(0)
12-10 22:06:18.760+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88300)
12-10 22:06:18.765+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:18.775+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:18.775+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(239) ev->cur.canvas.y(175)
12-10 22:06:18.775+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:18.775+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:18.775+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(285) ev->cur.canvas.y(183)
12-10 22:06:18.775+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:18.780+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88300), locked_x(0)
12-10 22:06:18.780+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88300)
12-10 22:06:18.780+0900 I/wnotib  (  713): w-notification-board-panel-basic.c: _wnotib_basic_panel_activate(2674) > page_index: 0.
12-10 22:06:18.780+0900 W/W_HOME  (  713): noti_broker.c: _handler_indicator_select(581) > 0
12-10 22:06:18.780+0900 W/W_HOME  (  713): noti_broker.c: _handler_indicator_select(591) > select index:1
12-10 22:06:18.780+0900 W/W_HOME  (  713): noti_broker.c: _handler_indicator_show(541) > 
12-10 22:06:18.780+0900 W/W_HOME  (  713): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
12-10 22:06:18.780+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:18.790+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2304582 button=1 downs=0
12-10 22:06:18.790+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88300), type(elm_scroller)
12-10 22:06:18.790+0900 W/W_HOME  (  713): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:0x47778288
12-10 22:06:18.795+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:18.805+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:18.815+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:18.830+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:18.845+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:18.865+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:18.880+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:18.895+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:18.920+0900 W/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-10 22:06:18.920+0900 I/efl-extension(  713): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88300 : elm_scroller] CurrentPage(0)
12-10 22:06:18.935+0900 W/WATCH_CORE( 6552): appcore-watch.c: __widget_pause(1001) > widget_pause
12-10 22:06:19.025+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:19.025+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(303) ev->cur.canvas.y(186)
12-10 22:06:19.025+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:19.025+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2304819 button=1 downs=1
12-10 22:06:19.045+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:19.045+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(289) ev->cur.canvas.y(182)
12-10 22:06:19.045+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:19.045+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:19.045+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(275) ev->cur.canvas.y(172)
12-10 22:06:19.045+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:19.060+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:19.060+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(249) ev->cur.canvas.y(166)
12-10 22:06:19.060+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:19.060+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-10 22:06:19.060+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88300), type(elm_scroller)
12-10 22:06:19.060+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-10 22:06:19.060+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88300), type(elm_scroller)
12-10 22:06:19.065+0900 E/W_HOME  (  713): home_navigation.c: _vi_init(939) > (scroller_info->vi_info.on == 1) -> _vi_init() return
12-10 22:06:19.065+0900 W/W_HOME  (  713): home_navigation.c: _is_rightedge(188) > (0 360) not right edge: 0 0 0x49b84b00 -> 360 0 0x47e12c38
12-10 22:06:19.065+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88300), locked_x(0)
12-10 22:06:19.065+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88300)
12-10 22:06:19.065+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.080+0900 W/WATCH_CORE( 6552): appcore-watch.c: __widget_resume(1012) > widget_resume
12-10 22:06:19.085+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(210) ev->cur.canvas.y(162)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(179) ev->cur.canvas.y(157)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(148) ev->cur.canvas.y(149)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(112) ev->cur.canvas.y(142)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88300), locked_x(0)
12-10 22:06:19.100+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88300)
12-10 22:06:19.100+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:19.115+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:06:19.115+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(80) ev->cur.canvas.y(140)
12-10 22:06:19.115+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:06:19.115+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88300), locked_x(0)
12-10 22:06:19.115+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88300)
12-10 22:06:19.115+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.135+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2304916 button=1 downs=0
12-10 22:06:19.135+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88300), type(elm_scroller)
12-10 22:06:19.140+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.150+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:19.150+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.165+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.180+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.195+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.215+0900 W/W_HOME  (  713): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-10 22:06:19.215+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:06:19.215+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.220+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-10 22:06:19.230+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.240+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.265+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:06:19.265+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:06:19.265+0900 W/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-10 22:06:19.265+0900 I/efl-extension(  713): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88300 : elm_scroller] CurrentPage(1)
12-10 22:06:19.405+0900 W/W_HOME  (  713): event_manager.c: _home_scroll_cb(564) > scroll,done
12-10 22:06:19.770+0900 W/W_HOME  (  713): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
12-10 22:06:20.000+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:20.040+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:20.070+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:21.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:21.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:21.150+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:22.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:22.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:22.150+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:23.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:23.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:23.160+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:24.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:24.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:24.155+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:25.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:25.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:25.140+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:26.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:26.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:26.165+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:27.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:27.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:27.160+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:28.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:28.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:28.160+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:29.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:29.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:29.150+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:30.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:30.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:30.160+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:31.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:31.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:31.160+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:32.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:32.100+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:32.165+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:33.004+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:33.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:33.160+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:34.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:34.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:34.170+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:35.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:35.115+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:35.150+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:36.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:36.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:36.150+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:37.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:37.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:37.165+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:38.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:38.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:38.165+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:39.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:39.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:39.165+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:40.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:40.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:40.155+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:41.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:41.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:41.145+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:42.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:42.125+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:42.180+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:43.000+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:43.140+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:43.175+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:44.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:44.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:44.155+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:45.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:45.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:45.145+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:46.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:46.110+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:46.165+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:47.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:47.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:47.140+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:48.010+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:48.105+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:48.145+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:48.675+0900 W/WATCH_CORE( 6552): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-10 22:06:48.675+0900 I/WATCH_CORE( 6552): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-10 22:06:48.715+0900 W/W_HOME  (  713): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-10 22:06:48.715+0900 W/W_HOME  (  713): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-10 22:06:48.715+0900 W/W_HOME  (  713): gesture.c: _manual_render_enable(133) > 1
12-10 22:06:48.715+0900 W/W_HOME  (  713): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-10 22:06:48.715+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:06:48.720+0900 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-10 22:06:48.720+0900 W/STARTER (  705): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-10 22:06:48.725+0900 E/STARTER (  705): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-10 22:06:48.725+0900 W/STARTER (  705): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-10 22:06:48.725+0900 W/STARTER (  705): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-10 22:06:48.730+0900 I/SCONTEXT-LIB(  662): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-10 22:06:48.760+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-10 22:06:48.780+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-10 22:06:48.780+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-10 22:06:48.860+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-10 22:06:48.860+0900 W/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-10 22:06:48.860+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-10 22:06:48.860+0900 I/HIGEAR  ( 1108): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-10 22:06:48.940+0900 I/SHealth_Common( 1068): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-10 22:06:48.940+0900 I/SHealth_Service( 1068): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-10 22:06:49.005+0900 I/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:06:49.010+0900 W/MUSIC_CONTROL_SERVICE( 1067): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1067]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-10 22:06:49.045+0900 I/APP_CORE(  713): appcore-efl.c: __do_app(429) > [APP 713] Event: PAUSE State: RUNNING
12-10 22:06:49.050+0900 I/CAPI_APPFW_APPLICATION(  713): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-10 22:06:49.050+0900 W/W_HOME  (  713): main.c: _appcore_pause_cb(690) > appcore pause
12-10 22:06:49.050+0900 W/W_HOME  (  713): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-10 22:06:49.050+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:06:49.050+0900 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-10 22:06:49.050+0900 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-10 22:06:49.050+0900 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-10 22:06:49.050+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:06:49.050+0900 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-10 22:06:49.050+0900 W/W_HOME  (  713): main.c: home_pause(751) > clock/widget paused
12-10 22:06:49.050+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:06:49.050+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:06:49.050+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:06:49.050+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:06:49.050+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 22:06:49.050+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 22:06:49.050+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:06:49.055+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-10 22:06:49.055+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:06:49.065+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:06:49.065+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:06:49.065+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:06:49.065+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 22:06:49.065+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 22:06:49.065+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:06:49.065+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-10 22:06:49.065+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 22:06:49.065+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 22:06:49.065+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:06:49.080+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-10 22:06:49.100+0900 E/CAPI_APPFW_APP_CONTROL( 1067): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-10 22:06:49.100+0900 W/MUSIC_CONTROL_SERVICE( 1067): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1067]   value = [false][0m
12-10 22:06:49.125+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:06:49.170+0900 I/CAPI_NETWORK_WIFI( 6552): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:06:49.245+0900 W/WATCH_CORE( 6552): appcore-watch.c: __widget_pause(1001) > widget_pause
12-10 22:06:49.575+0900 I/APP_CORE(  713): appcore-efl.c: __do_app(429) > [APP 713] Event: MEM_FLUSH State: PAUSED
12-10 22:06:54.179+0900 I/APP_CORE(  713): appcore-efl.c: __do_app(429) > [APP 713] Event: MEM_FLUSH State: PAUSED
12-10 22:07:07.224+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 22:07:15.649+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 22:07:15.649+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 22:07:15.649+0900 I/RESOURCED(  464): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-10 22:07:54.935+0900 E/PKGMGR_SERVER( 7502): pkgmgr-server.c: main(2126) > package manager server start
12-10 22:07:55.055+0900 E/PKGMGR_SERVER( 7502): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-451076549], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-10 22:07:55.060+0900 E/PKGMGR_SERVER( 7504): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-10 22:07:55.070+0900 E/PKGMGR  ( 7496): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-10 22:07:55.130+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:07:55.135+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6552
12-10 22:07:55.140+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 22:07:55.145+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 5
12-10 22:07:55.150+0900 W/AUL_AMD (  454): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(6552), cmd(4)
12-10 22:07:55.150+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:07:55.150+0900 W/CAPI_WATCH_APPLICATION( 6552): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-10 22:07:55.150+0900 W/WATCH_CORE( 6552): appcore-watch.c: __widget_destroy(992) > widget_destory
12-10 22:07:55.150+0900 E/WIDGET_PROVIDER_APP( 6552): client.c: client_fini(1175) > Provider is not initialized
12-10 22:07:55.160+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6552
12-10 22:07:55.160+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 22
12-10 22:07:55.160+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(884) > app status : 4
12-10 22:07:55.160+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 4
12-10 22:07:55.270+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:07:55.345+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-10 22:07:55.420+0900 E/AUL_AMD (  454): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-10 22:07:55.425+0900 W/AUL_AMD (  454): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(6552), cmd(4)
12-10 22:07:55.450+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 0
12-10 22:07:55.565+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 22:07:55.660+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 22:07:55.660+0900 E/AUL_AMD (  454): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-10 22:07:55.665+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(1659) > caller pid : 707
12-10 22:07:55.760+0900 E/PKGMGR_SERVER( 7504): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-10 22:07:55.875+0900 E/PKGMGR_SERVER( 7502): pkgmgr-server.c: sighandler(445) > child NORMAL exit [7504]
12-10 22:07:55.920+0900 E/RESOURCED(  464): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-10 22:07:55.920+0900 E/RESOURCED(  464): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-10 22:07:55.930+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(2026) > pad pid(-5)
12-10 22:07:55.930+0900 W/AUL_PAD ( 1159): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-10 22:07:55.930+0900 W/AUL_PAD ( 1159): launchpad.c: __send_result_to_caller(265) > Check app launching
12-10 22:07:55.980+0900 I/CAPI_WATCH_APPLICATION( 6794): watch_app_main.c: watch_app_main(382) > watch_app_main
12-10 22:07:56.005+0900 E/TBM     ( 6794): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-10 22:07:56.030+0900 I/AUL_AMD (  454): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 6552
12-10 22:07:56.070+0900 W/WATCH_CORE( 6794): appcore-watch.c: __widget_create(958) > widget_create
12-10 22:07:56.070+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1712) > [SECURE_LOG] [2238.428467] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_713_2238.428467.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263096:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-10 22:07:56.070+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[2238.428467] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_713_2238.428467.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263096:4] gbar_fname[]
12-10 22:07:56.090+0900 E/WIDGET_VIEWER(  713): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-10 22:07:56.090+0900 E/WIDGET_EVAS(  713): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-10 22:07:56.230+0900 I/CAPI_NETWORK_WIFI( 6794): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:07:56.245+0900 I/CAPI_NETWORK_WIFI( 6794): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:07:56.440+0900 W/WATCH_CORE( 6794): appcore-watch.c: __widget_create(976) > widget_create done
12-10 22:07:56.470+0900 I/WATCH_CORE( 6794): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-10 22:07:56.470+0900 I/WATCH_CORE( 6794): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-10 22:07:56.470+0900 I/WATCH_CORE( 6794): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-10 22:07:57.035+0900 W/AUL_AMD (  454): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-10 22:07:57.035+0900 W/AUL_AMD (  454): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-10 22:07:57.050+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:07:57.055+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 6794
12-10 22:07:57.060+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 22:07:57.165+0900 W/AUL_AMD (  454): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-10 22:07:57.205+0900 E/PKGMGR_SERVER( 7502): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-10 22:07:57.205+0900 E/PKGMGR_SERVER( 7502): pkgmgr-server.c: main(2180) > package manager server terminated.
12-10 22:07:57.285+0900 I/AUL_PAD ( 7544): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-10 22:08:07.210+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 22:08:08.030+0900 E/PKGMGR  ( 7648): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-10 22:08:08.185+0900 E/PKGMGR_SERVER( 7650): pkgmgr-server.c: main(2126) > package manager server start
12-10 22:08:08.315+0900 E/PKGMGR_SERVER( 7650): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-437814051], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-437814051' '-r' 'org.reolab.blackandwhite'], cookie=[OIMSY1YGF4cwqRMKzqFm4uv4ss8=], backend_flag=[0]
12-10 22:08:08.320+0900 E/PKGMGR  ( 7650): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-10 22:08:08.320+0900 E/PKGMGR_SERVER( 7650): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-10 22:08:08.325+0900 E/PKGMGR  ( 7648): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[76480002]
12-10 22:08:08.330+0900 E/PKGMGR_SERVER( 7651): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-10 22:08:08.510+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-10 22:08:08.520+0900 W/AUL_AMD (  454): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-10 22:08:08.535+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-10 22:08:08.535+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 22:08:09.130+0900 E/PKGMGR_CERT( 7651): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-10 22:08:09.140+0900 E/PKGMGR_CERT( 7651): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
12-10 22:08:09.145+0900 E/PKGMGR_CERT( 7651): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
12-10 22:08:09.145+0900 E/PKGMGR_CERT( 7651): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 3
12-10 22:08:09.150+0900 E/PKGMGR_CERT( 7651): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 3
12-10 22:08:09.150+0900 E/PKGMGR_CERT( 7651): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 3
12-10 22:08:09.150+0900 E/PKGMGR_CERT( 7651): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 3
12-10 22:08:09.155+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 22:08:09.180+0900 E/PKGMGR_CERT( 7651): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-10 22:08:10.205+0900 E/PKGMGR_SERVER( 7650): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 22:08:10.995+0900 E/rpm-installer( 7651): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-10 22:08:12.205+0900 E/PKGMGR_SERVER( 7650): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 22:08:14.035+0900 E/PKGMGR_SERVER( 7650): pkgmgr-server.c: sighandler(445) > child NORMAL exit [7651]
12-10 22:08:14.045+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 22:08:14.065+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-10 22:08:14.065+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-10 22:08:14.075+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-10 22:08:14.075+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-10 22:08:14.075+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-10 22:08:14.075+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-10 22:08:14.115+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-10 22:08:14.205+0900 E/PKGMGR_SERVER( 7650): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-10 22:08:14.205+0900 E/PKGMGR_SERVER( 7650): pkgmgr-server.c: main(2180) > package manager server terminated.
12-10 22:08:14.295+0900 E/PKGMGR_INFO(  461): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-10 22:08:14.305+0900 E/APPS    (  713): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-10 22:08:14.440+0900 W/CRASH_MANAGER( 7655): worker.c: worker_job(1199) > 1106794626c61144975289
