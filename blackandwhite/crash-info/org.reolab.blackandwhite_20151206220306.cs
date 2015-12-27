S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 30821
Date: 2015-12-06 22:03:06+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x111

Register Information
r0   = 0x00000105, r1   = 0x0000000d
r2   = 0x00000005, r3   = 0x41553194
r4   = 0x00000105, r5   = 0x00000000
r6   = 0x414e0ccc, r7   = 0x414dd608
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbee7dc74, sp   = 0xbee7dc28
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     15740 KB
Buffers:     21048 KB
Cached:     110316 KB
VmPeak:      76244 KB
VmSize:      75732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14652 KB
VmRSS:       14652 KB
VmData:      21472 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20468 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 30821 TID = 30821
30821 31002 31008 

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
4352a000 43d29000 rw-p [stack:31002]
43d29000 43d2c000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d34000 43d3f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dc7000 43dde000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4401e000 44900000 rw-p [stack:31008]
bee5e000 bee7f000 rw-p [stack]
End of Maps Information

Callstack Information (PID:30821)
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
 : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-06 22:01:37.215+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.215+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.225+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-06 22:01:37.255+0900 E/EFL     (30685): evas_main<30685> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=30152054 button=1 downs=0
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(220) ev->cur.canvas.y(200)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(184) ev->cur.canvas.y(195)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(149) ev->cur.canvas.y(193)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(114) ev->cur.canvas.y(191)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(84) ev->cur.canvas.y(187)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.255+0900 W/W_HOME  (  715): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-06 22:01:37.255+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-06 22:01:37.260+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.260+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.275+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.275+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(60) ev->cur.canvas.y(176)
12-06 22:01:37.275+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.275+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=30152145 button=1 downs=0
12-06 22:01:37.275+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88128), type(elm_scroller)
12-06 22:01:37.280+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.280+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.290+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.290+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.300+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.300+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.315+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.315+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.330+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.330+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.345+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.345+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.365+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.365+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.380+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.380+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.395+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.395+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.400+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-06 22:01:37.400+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88128 : elm_scroller] CurrentPage(2)
12-06 22:01:37.410+0900 W/WATCH_CORE(30685): appcore-watch.c: __widget_pause(1001) > widget_pause
12-06 22:01:37.440+0900 E/WATCH_CORE(30685): appcore-watch.c: __do_app(322) > Invalid state
12-06 22:01:37.520+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
12-06 22:01:37.570+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.575+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(35) ev->cur.canvas.y(164)
12-06 22:01:37.575+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.580+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=30152434 button=1 downs=1
12-06 22:01:37.620+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.620+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(39) ev->cur.canvas.y(169)
12-06 22:01:37.620+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.625+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.625+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(50) ev->cur.canvas.y(174)
12-06 22:01:37.625+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.625+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.630+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(68) ev->cur.canvas.y(174)
12-06 22:01:37.630+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.630+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.630+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(85) ev->cur.canvas.y(175)
12-06 22:01:37.630+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.630+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-06 22:01:37.630+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88128), type(elm_scroller)
12-06 22:01:37.630+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-06 22:01:37.630+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88128), type(elm_scroller)
12-06 22:01:37.640+0900 W/W_HOME  (  715): home_navigation.c: _is_rightedge(188) > (720 360) not right edge: 0 0 0x477101f8 -> 360 0 0x47ba86b0
12-06 22:01:37.645+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.645+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(110) ev->cur.canvas.y(178)
12-06 22:01:37.645+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.645+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,start
12-06 22:01:37.650+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-06 22:01:37.650+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-06 22:01:37.650+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.650+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.660+0900 E/EFL     (  803): evas_main<803> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=30152432 button=1 downs=1
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(148) ev->cur.canvas.y(178)
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.665+0900 E/EFL     (  803): evas_main<803> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(193) ev->cur.canvas.y(178)
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(241) ev->cur.canvas.y(178)
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(283) ev->cur.canvas.y(182)
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-06 22:01:37.665+0900 E/EFL     (  803): evas_main<803> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-06 22:01:37.665+0900 E/EFL     (  803): evas_main<803> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-06 22:01:37.665+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-06 22:01:37.670+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.670+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.680+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=30152540 button=1 downs=0
12-06 22:01:37.680+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88128), type(elm_scroller)
12-06 22:01:37.680+0900 E/EFL     (  803): evas_main<803> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=30152509 button=1 downs=0
12-06 22:01:37.685+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.685+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.695+0900 W/W_HOME  (  715): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
12-06 22:01:37.695+0900 W/WATCH_CORE(30685): appcore-watch.c: __widget_resume(1012) > widget_resume
12-06 22:01:37.695+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.695+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.705+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:37.715+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.715+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.735+0900 W/W_HOME  (  715): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-06 22:01:37.735+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-06 22:01:37.735+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.735+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.745+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-06 22:01:37.745+0900 W/W_HOME  (  715): gesture.c: _widget_updated_cb(190) > widget updated
12-06 22:01:37.745+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-06 22:01:37.745+0900 W/W_HOME  (  715): gesture.c: _manual_render(176) > 
12-06 22:01:37.760+0900 W/W_HOME  (  715): gesture.c: _manual_render(176) > 
12-06 22:01:37.775+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 0
12-06 22:01:37.780+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.780+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.795+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-06 22:01:37.795+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-06 22:01:37.810+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-06 22:01:37.815+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88128 : elm_scroller] CurrentPage(1)
12-06 22:01:37.945+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
12-06 22:01:38.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:38.315+0900 W/W_HOME  (  715): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
12-06 22:01:38.945+0900 E/SHealth_Common( 1078): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-06 22:01:38.995+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:40.005+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:41.005+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:41.205+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 1 -> 2
12-06 22:01:41.230+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-06 22:01:41.230+0900 E/WMS     (  491): ==========
12-06 22:01:41.230+0900 E/WMS     (  491): ##WMS SEND : mgr_gear_wear_onoff_req
12-06 22:01:41.230+0900 E/WMS     (  491): ==========
12-06 22:01:41.235+0900 E/WMS     (  491): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-06 22:01:41.300+0900 W/SCSD    (29264): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
12-06 22:01:41.300+0900 W/SCSD    (29264): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
12-06 22:01:41.300+0900 W/SCSD    (29264): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
12-06 22:01:41.310+0900 W/SCSD    (29264): <util_scs_send:975> sent [63 / 63] bytes. 
12-06 22:01:41.325+0900 W/SHealth_Service( 1078): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
12-06 22:01:41.325+0900 E/SHealth_Service( 1078): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-06 22:01:42.005+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:43.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:44.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:45.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:46.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:47.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:48.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:49.005+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:50.005+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:51.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:52.005+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:53.005+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:54.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:55.010+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:55.545+0900 W/LFE      ( 1173): [01289] 55:11:48.391[F:lfeWatchdog.cpp  L:  119][01][HIGH] Send Notify to Main thread. 622th=1
12-06 22:01:55.550+0900 W/LFE      ( 1173): [01173] 55:11:48.394[F:lfeWatchdog.cpp  L:   90][01][HIGH] Got thread notify. g_MainThreadLockup=1 g_write_lock=0
12-06 22:01:56.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:57.005+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:58.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:01:59.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:02:00.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:02:01.005+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:02:01.315+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-06 22:02:01.315+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-06 22:02:01.325+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: preference_get_double(1214) > preference_get_double(1078) : pedometer_inactive_period error
12-06 22:02:01.330+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-06 22:02:01.355+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-06 22:02:01.355+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: preference_get_double(1214) > preference_get_double(1078) : inactive_10min_precaution_millisec error
12-06 22:02:01.355+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-06 22:02:01.360+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-06 22:02:01.365+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1078): preference.c: preference_get_double(1214) > preference_get_double(1078) : inactive_before_10min_precaution_millisec error
12-06 22:02:02.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:02:03.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:02:04.005+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:02:05.005+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:02:06.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:02:06.795+0900 W/WATCH_CORE(30685): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-06 22:02:06.795+0900 I/WATCH_CORE(30685): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-06 22:02:06.840+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-06 22:02:06.840+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-06 22:02:06.840+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 1
12-06 22:02:06.840+0900 W/W_HOME  (  715): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-06 22:02:06.840+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-06 22:02:06.850+0900 W/STARTER (  707): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-06 22:02:06.850+0900 W/STARTER (  707): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-06 22:02:06.855+0900 E/STARTER (  707): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-06 22:02:06.855+0900 W/STARTER (  707): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-06 22:02:06.855+0900 W/STARTER (  707): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-06 22:02:06.860+0900 I/SCONTEXT-LIB(  687): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-06 22:02:06.970+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-06 22:02:06.980+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-06 22:02:06.985+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-06 22:02:07.000+0900 I/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:02:07.045+0900 I/SHealth_Common( 1078): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-06 22:02:07.045+0900 I/SHealth_Service( 1078): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-06 22:02:07.050+0900 W/STARTER (  707): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-06 22:02:07.050+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-06 22:02:07.050+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-06 22:02:07.050+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-06 22:02:07.055+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: PAUSE State: RUNNING
12-06 22:02:07.055+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-06 22:02:07.055+0900 W/W_HOME  (  715): main.c: _appcore_pause_cb(690) > appcore pause
12-06 22:02:07.055+0900 W/W_HOME  (  715): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-06 22:02:07.055+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-06 22:02:07.060+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-06 22:02:07.060+0900 W/W_HOME  (  715): main.c: home_pause(751) > clock/widget paused
12-06 22:02:07.060+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-06 22:02:07.060+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-06 22:02:07.065+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-06 22:02:07.065+0900 E/CAPI_APPFW_APP_CONTROL( 1081): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-06 22:02:07.065+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1081]   value = [false][0m
12-06 22:02:07.065+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-06 22:02:07.070+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-06 22:02:07.075+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-06 22:02:07.075+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-06 22:02:07.075+0900 I/HIGEAR  ( 1107): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-06 22:02:07.110+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_pause_cb(296) > widget obj was paused
12-06 22:02:07.110+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(145) > enter background group
12-06 22:02:07.115+0900 W/WATCH_CORE(30685): appcore-watch.c: __widget_pause(1001) > widget_pause
12-06 22:02:07.565+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-06 22:02:12.155+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-06 22:02:26.450+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-06 22:02:26.450+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-06 22:02:26.520+0900 I/RESOURCED(  498): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-06 22:02:31.560+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-06 22:02:31.560+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-06 22:02:31.590+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-06 22:02:31.590+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-06 22:02:31.610+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-06 22:02:31.610+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-06 22:02:31.615+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-06 22:02:31.620+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-06 22:02:35.650+0900 W/LFE      ( 1173): [01289] 55:12:28.496[F:lfeWatchdog.cpp  L:  119][01][HIGH] Send Notify to Main thread. 623th=1
12-06 22:02:35.655+0900 W/LFE      ( 1173): [01173] 55:12:28.499[F:lfeWatchdog.cpp  L:   90][01][HIGH] Got thread notify. g_MainThreadLockup=1 g_write_lock=0
12-06 22:02:38.905+0900 E/SHealth_Common( 1078): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-06 22:02:47.695+0900 E/PKGMGR_SERVER(30988): pkgmgr-server.c: main(2126) > package manager server start
12-06 22:02:47.810+0900 E/PKGMGR_SERVER(30988): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1534061587], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-06 22:02:47.815+0900 E/PKGMGR_SERVER(30989): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-06 22:02:47.825+0900 E/PKGMGR  (30982): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-06 22:02:47.880+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-06 22:02:47.890+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 30685
12-06 22:02:47.890+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-06 22:02:47.895+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 5
12-06 22:02:47.900+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(30685), cmd(4)
12-06 22:02:47.900+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 22
12-06 22:02:47.900+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(884) > app status : 4
12-06 22:02:47.900+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-06 22:02:47.905+0900 W/CAPI_WATCH_APPLICATION(30685): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-06 22:02:47.905+0900 W/WATCH_CORE(30685): appcore-watch.c: __widget_destroy(992) > widget_destory
12-06 22:02:47.905+0900 E/WIDGET_PROVIDER_APP(30685): client.c: client_fini(1175) > Provider is not initialized
12-06 22:02:47.910+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 30685
12-06 22:02:47.910+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-06 22:02:48.015+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-06 22:02:48.180+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-06 22:02:48.190+0900 E/AUL_AMD (  495): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-06 22:02:48.195+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(30685), cmd(4)
12-06 22:02:48.200+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-06 22:02:48.345+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-06 22:02:48.405+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-06 22:02:48.405+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-06 22:02:48.405+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-06 22:02:48.510+0900 E/PKGMGR_SERVER(30989): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-06 22:02:48.625+0900 E/PKGMGR_SERVER(30988): pkgmgr-server.c: sighandler(445) > child NORMAL exit [30989]
12-06 22:02:48.665+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-06 22:02:48.670+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-06 22:02:48.670+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-06 22:02:48.670+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-06 22:02:48.670+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-06 22:02:48.695+0900 I/CAPI_WATCH_APPLICATION(30821): watch_app_main.c: watch_app_main(382) > watch_app_main
12-06 22:02:48.720+0900 E/TBM     (30821): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-06 22:02:48.775+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 30685
12-06 22:02:48.810+0900 W/WATCH_CORE(30821): appcore-watch.c: __widget_create(958) > widget_create
12-06 22:02:48.815+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [29937.230469] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_29937.230469.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29360726:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-06 22:02:48.815+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[29937.230469] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_29937.230469.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29360726:4] gbar_fname[]
12-06 22:02:48.835+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-06 22:02:48.835+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-06 22:02:48.905+0900 W/WATCH_CORE(30821): appcore-watch.c: __widget_create(976) > widget_create done
12-06 22:02:48.990+0900 I/WATCH_CORE(30821): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-06 22:02:48.990+0900 I/WATCH_CORE(30821): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-06 22:02:48.990+0900 I/WATCH_CORE(30821): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-06 22:02:49.775+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-06 22:02:49.775+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-06 22:02:49.790+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-06 22:02:49.795+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 30821
12-06 22:02:49.800+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-06 22:02:49.905+0900 W/AUL_AMD (  495): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-06 22:02:50.000+0900 I/AUL_PAD (31024): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-06 22:02:50.130+0900 E/PKGMGR_SERVER(30988): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-06 22:02:50.130+0900 E/PKGMGR_SERVER(30988): pkgmgr-server.c: main(2180) > package manager server terminated.
12-06 22:02:59.650+0900 E/PKGMGR  (31124): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-06 22:02:59.805+0900 E/PKGMGR_SERVER(31126): pkgmgr-server.c: main(2126) > package manager server start
12-06 22:02:59.930+0900 E/PKGMGR_SERVER(31126): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1546159712], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_1546159712' '-r' 'org.reolab.blackandwhite'], cookie=[jMbi9LNcQ4co4FJKG3+osQEe0gA=], backend_flag=[0]
12-06 22:02:59.930+0900 E/PKGMGR  (31126): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-06 22:02:59.935+0900 E/PKGMGR_SERVER(31126): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-06 22:02:59.940+0900 E/PKGMGR  (31124): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[311240002]
12-06 22:02:59.940+0900 E/PKGMGR_SERVER(31127): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-06 22:03:00.100+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-06 22:03:00.110+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-06 22:03:00.120+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-06 22:03:00.130+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-06 22:03:00.685+0900 E/PKGMGR_CERT(31127): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-06 22:03:00.695+0900 E/PKGMGR_CERT(31127): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 99
12-06 22:03:00.695+0900 E/PKGMGR_CERT(31127): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 99
12-06 22:03:00.700+0900 E/PKGMGR_CERT(31127): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 3
12-06 22:03:00.700+0900 E/PKGMGR_CERT(31127): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 3
12-06 22:03:00.700+0900 E/PKGMGR_CERT(31127): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 3
12-06 22:03:00.705+0900 E/PKGMGR_CERT(31127): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 3
12-06 22:03:00.710+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-06 22:03:00.725+0900 E/PKGMGR_CERT(31127): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-06 22:03:02.130+0900 E/PKGMGR_SERVER(31126): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-06 22:03:02.630+0900 E/rpm-installer(31127): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-06 22:03:04.130+0900 E/PKGMGR_SERVER(31126): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-06 22:03:05.965+0900 E/PKGMGR_SERVER(31126): pkgmgr-server.c: sighandler(445) > child NORMAL exit [31127]
12-06 22:03:05.985+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-06 22:03:06.010+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-06 22:03:06.010+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-06 22:03:06.030+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-06 22:03:06.030+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-06 22:03:06.035+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-06 22:03:06.035+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-06 22:03:06.070+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-06 22:03:06.130+0900 E/PKGMGR_SERVER(31126): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-06 22:03:06.130+0900 E/PKGMGR_SERVER(31126): pkgmgr-server.c: main(2180) > package manager server terminated.
12-06 22:03:06.160+0900 E/PKGMGR_INFO(  483): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-06 22:03:06.215+0900 E/APPS    (  715): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-06 22:03:06.575+0900 W/CRASH_MANAGER(31131): worker.c: worker_job(1199) > 1130821626c61144940698
