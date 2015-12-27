S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 28046
Date: 2015-12-07 22:09:41+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x3c

Register Information
r0   = 0x0000003f, r1   = 0x0000003c
r2   = 0x00000073, r3   = 0x00000000
r4   = 0x00000000, r5   = 0x4000174e
r6   = 0xbef897d0, r7   = 0x0000003f
r8   = 0x00000034, r9   = 0x42cd3d10
r10  = 0x40001719, fp   = 0xbef897c4
ip   = 0x00000000, sp   = 0xbef89260
lr   = 0x403055b8, pc   = 0x40338dc4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     19696 KB
Buffers:     17752 KB
Cached:      99608 KB
VmPeak:      65608 KB
VmSize:      65096 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12780 KB
VmRSS:       12780 KB
VmData:      12216 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       19388 KB
VmPTE:          46 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 28046 TID = 28046
28046 28053 

Maps Information
40000000 40002000 r-xp /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
4000a000 40027000 r-xp /lib/ld-2.13.so
40030000 40034000 r-xp /usr/lib/libsys-assert.so
4003d000 40041000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
40051000 40058000 r-xp /usr/lib/libappcore-watch.so.1.1
40061000 40063000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4006c000 40071000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
40079000 4007b000 r-xp /usr/lib/libdlog.so.0.0.0
40083000 401bd000 r-xp /usr/lib/libelementary.so.1.7.99
401d3000 402a2000 r-xp /usr/lib/libevas.so.1.7.99
402c6000 403e1000 r-xp /lib/libc-2.13.so
403ef000 403f7000 r-xp /lib/libgcc_s-4.6.so.1
403f8000 4040c000 r-xp /lib/libpthread-2.13.so
40417000 40422000 r-xp /lib/libunwind.so.8.0.1
4044f000 40451000 r-xp /lib/libdl-2.13.so
4045a000 40466000 r-xp /usr/lib/libaul.so.0.1.0
40470000 40487000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4048f000 4049c000 r-xp /usr/lib/libalarm.so.0.0.0
404a5000 404d9000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
404e2000 404e7000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
404ef000 40511000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40519000 40530000 r-xp /usr/lib/libecore.so.1.7.99
40547000 40588000 r-xp /usr/lib/libeina.so.1.7.99
40591000 406ce000 r-xp /usr/lib/libicui18n.so.51.1
406de000 407c2000 r-xp /usr/lib/libicuuc.so.51.1
407d7000 407db000 r-xp /usr/lib/libvconf.so.0.2.45
407e3000 408b3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
408b4000 408de000 r-xp /usr/lib/libdbus-1.so.3.8.12
408e7000 408ed000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
408f5000 408fb000 r-xp /usr/lib/libwidget.so.1.0.0
40904000 40909000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
40911000 409e4000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
409ef000 40a58000 r-xp /lib/libm-2.13.so
40a61000 40a7a000 r-xp /usr/lib/libeet.so.1.7.99
40a8b000 40aad000 r-xp /usr/lib/libecore_evas.so.1.7.99
40ab6000 40abb000 r-xp /usr/lib/libecore_file.so.1.7.99
40ac3000 40ad4000 r-xp /usr/lib/libecore_input.so.1.7.99
40adc000 40b39000 r-xp /usr/lib/libedje.so.1.7.99
40b43000 40b93000 r-xp /usr/lib/libecore_x.so.1.7.99
40b95000 40b9e000 r-xp /usr/lib/libedbus.so.1.7.99
40ba6000 40bc0000 r-xp /usr/lib/libecore_con.so.1.7.99
40bc9000 40bdc000 r-xp /usr/lib/libfribidi.so.0.3.1
40be4000 40c21000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40c2a000 40c52000 r-xp /usr/lib/libfontconfig.so.1.8.0
40c53000 40ca9000 r-xp /usr/lib/libfreetype.so.6.11.3
40cb5000 40d0b000 r-xp /usr/lib/libpixman-1.so.0.28.2
40d18000 40d1b000 r-xp /usr/lib/libbundle.so.0.1.22
40d23000 40d28000 r-xp /usr/lib/libxdgmime.so.1.1.0
40d30000 40d6c000 r-xp /usr/lib/libsystemd.so.0.4.0
40d75000 40d78000 r-xp /usr/lib/libproc-stat.so.0.2.86
40d80000 40da6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40daf000 40db5000 r-xp /usr/lib/libappsvc.so.0.1.0
40dbd000 40dbe000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40dc6000 40dcc000 r-xp /lib/librt-2.13.so
40dd5000 40dda000 r-xp /usr/lib/libffi.so.5.0.10
40de2000 40de5000 r-xp /usr/lib/libsmack.so.1.0.0
40ded000 40e02000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40e0a000 40e7f000 r-xp /usr/lib/libsqlite3.so.0.8.6
40e89000 40f1d000 r-xp /usr/lib/libstdc++.so.6.0.16
424b7000 424c0000 r-xp /usr/lib/libcom-core.so.0.0.1
424c9000 424d5000 r-xp /usr/lib/libwidget_service.so.1.0.0
424dd000 424e3000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
424ec000 424f5000 r-xp /usr/lib/libwidget_provider.so.1.0.0
424fe000 425df000 r-xp /usr/lib/libX11.so.6.3.0
425ea000 425ec000 r-xp /usr/lib/libiniparser.so.0
425f5000 426c1000 r-xp /usr/lib/libxml2.so.2.7.8
426ce000 426d0000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
426d8000 426ee000 r-xp /lib/libz.so.1.2.5
426f6000 42706000 r-xp /lib/libresolv-2.13.so
4270a000 4272d000 r-xp /usr/lib/libjpeg.so.8.0.2
42745000 4274a000 r-xp /usr/lib/libecore_fb.so.1.7.99
42753000 42757000 r-xp /usr/lib/libecore_ipc.so.1.7.99
42760000 42763000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
4276b000 42772000 r-xp /usr/lib/libembryo.so.1.7.99
4277a000 42791000 r-xp /usr/lib/liblua-5.1.so
4279a000 427a0000 r-xp /usr/lib/libecore_imf.so.1.7.99
427a9000 427aa000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
427b2000 427b9000 r-xp /usr/lib/libXcursor.so.1.0.2
427c1000 427c3000 r-xp /usr/lib/libXdamage.so.1.1.0
427cb000 427cd000 r-xp /usr/lib/libXcomposite.so.1.0.0
427d5000 427d7000 r-xp /usr/lib/libXgesture.so.7.0.0
427e0000 427e3000 r-xp /usr/lib/libXfixes.so.3.1.0
427eb000 427f4000 r-xp /usr/lib/libXi.so.6.1.0
427fc000 427fd000 r-xp /usr/lib/libXinerama.so.1.0.0
42806000 4280c000 r-xp /usr/lib/libXrandr.so.2.2.0
42814000 4281a000 r-xp /usr/lib/libXrender.so.1.3.0
42822000 42825000 r-xp /usr/lib/libXtst.so.6.1.0
4282f000 42839000 r-xp /usr/lib/libXext.so.6.4.0
42842000 42886000 r-xp /usr/lib/libcurl.so.4.3.0
4288f000 428a5000 r-xp /lib/libexpat.so.1.5.2
428af000 428c7000 r-xp /usr/lib/libpng12.so.0.50.0
428cf000 428e7000 r-xp /usr/lib/liblzma.so.5.0.3
428f0000 4296c000 r-xp /usr/lib/libgcrypt.so.20.0.3
42978000 42994000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
4299d000 4299f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
429a8000 429aa000 r-xp /usr/lib/journal/libjournal.so.0.1.0
429b3000 429bb000 r-xp /usr/lib/libdrm.so.2.4.0
429c3000 429c5000 r-xp /usr/lib/libdri2.so.0.0.0
429cd000 429d4000 r-xp /usr/lib/libtbm.so.1.0.0
429dc000 429ef000 r-xp /usr/lib/libxcb.so.1.1.0
429f9000 42a02000 r-xp /usr/lib/libcares.so.2.1.0
42a0b000 42a39000 r-xp /usr/lib/libidn.so.11.5.44
42a41000 42a8e000 r-xp /usr/lib/libssl.so.1.0.0
42a9a000 42c42000 r-xp /usr/lib/libcrypto.so.1.0.0
42c5b000 42c66000 r-xp /usr/lib/libgpg-error.so.0.15.0
42c6f000 42c71000 r-xp /usr/lib/libiri.so
42c79000 42c7c000 r-xp /lib/libcap.so.2.21
42c84000 42c8b000 r-xp /lib/libcrypt-2.13.so
42cbb000 42cbd000 r-xp /usr/lib/libXau.so.6.0.0
42cc5000 42cc8000 r-xp /lib/libattr.so.1.1.0
43108000 43907000 rw-p [stack:28053]
43907000 4390a000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43912000 4391d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c63000 43c7a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
bef6a000 bef8b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28046)
Call Stack Count: 1
 0: strlen + 0x4 (0x40338dc4) [/lib/libc.so.6] + 0x72dc4
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
TION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:28.004+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:29.004+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:29.469+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(307) ev->cur.canvas.y(238)
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.479+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80909644 button=1 downs=1
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(298) ev->cur.canvas.y(238)
12-07 22:09:29.479+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.489+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.489+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(286) ev->cur.canvas.y(234)
12-07 22:09:29.489+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.499+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.499+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(278) ev->cur.canvas.y(231)
12-07 22:09:29.499+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.504+0900 E/EFL     (27627): evas_main<27627> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80909656 button=1 downs=1
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(270) ev->cur.canvas.y(231)
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88128), type(elm_scroller)
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:29.509+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88128), type(elm_scroller)
12-07 22:09:29.524+0900 W/W_HOME  (  715): home_navigation.c: _is_rightedge(188) > (720 360) not right edge: 0 0 0x49c82ba8 -> 360 0 0x477101f8
12-07 22:09:29.529+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,start
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(264) ev->cur.canvas.y(231)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(256) ev->cur.canvas.y(231)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.529+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.534+0900 W/W_HOME  (  715): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-07 22:09:29.534+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:29.534+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.534+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.539+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-07 22:09:29.554+0900 E/EFL     (27627): evas_main<27627> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80909687 button=1 downs=0
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(249) ev->cur.canvas.y(230)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(242) ev->cur.canvas.y(230)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.554+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.554+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.554+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.569+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.569+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(233) ev->cur.canvas.y(229)
12-07 22:09:29.569+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.569+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.569+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.569+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.569+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.579+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.579+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(221) ev->cur.canvas.y(228)
12-07 22:09:29.579+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.579+0900 W/W_HOME  (  715): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
12-07 22:09:29.584+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.584+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(204) ev->cur.canvas.y(228)
12-07 22:09:29.584+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.584+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.584+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.584+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.584+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.594+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.594+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(188) ev->cur.canvas.y(228)
12-07 22:09:29.594+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.599+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.599+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.604+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.604+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.609+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.609+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(174) ev->cur.canvas.y(227)
12-07 22:09:29.609+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.614+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.614+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(160) ev->cur.canvas.y(225)
12-07 22:09:29.614+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.619+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.619+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.619+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.619+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.629+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.629+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(147) ev->cur.canvas.y(225)
12-07 22:09:29.629+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.634+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.634+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.634+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.634+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(135) ev->cur.canvas.y(225)
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(121) ev->cur.canvas.y(225)
12-07 22:09:29.654+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.664+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:29.664+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:29.664+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.664+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(103) ev->cur.canvas.y(225)
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(90) ev->cur.canvas.y(227)
12-07 22:09:29.684+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:29.684+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80909853 button=1 downs=0
12-07 22:09:29.689+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88128), type(elm_scroller)
12-07 22:09:29.694+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.694+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.714+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.714+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.729+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.729+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.744+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.744+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.754+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.754+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.769+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.769+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.819+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:29.819+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:29.824+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-07 22:09:29.824+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88128 : elm_scroller] CurrentPage(3)
12-07 22:09:29.859+0900 W/WATCH_CORE(27627): appcore-watch.c: __widget_pause(1001) > widget_pause
12-07 22:09:29.954+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
12-07 22:09:30.004+0900 E/PKGMGR  (27962): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-07 22:09:30.114+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.114+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(63) ev->cur.canvas.y(261)
12-07 22:09:30.114+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.114+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80910283 button=1 downs=1
12-07 22:09:30.124+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.124+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(70) ev->cur.canvas.y(260)
12-07 22:09:30.124+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.134+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.134+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(86) ev->cur.canvas.y(261)
12-07 22:09:30.134+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(102) ev->cur.canvas.y(264)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c88128), type(elm_scroller)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-07 22:09:30.144+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c88128), type(elm_scroller)
12-07 22:09:30.154+0900 W/W_HOME  (  715): home_navigation.c: _is_rightedge(188) > (1080 360) not right edge: 0 0 0x477101f8 -> 360 0 0x47ba86b0
12-07 22:09:30.154+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,start
12-07 22:09:30.159+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.159+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(118) ev->cur.canvas.y(265)
12-07 22:09:30.159+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.159+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.159+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.159+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.159+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.159+0900 E/PKGMGR_SERVER(27964): pkgmgr-server.c: main(2126) > package manager server start
12-07 22:09:30.169+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.169+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(130) ev->cur.canvas.y(268)
12-07 22:09:30.169+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.169+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.169+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.174+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.174+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.179+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.179+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(143) ev->cur.canvas.y(269)
12-07 22:09:30.179+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.184+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.184+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.184+0900 E/EFL     (  803): evas_main<803> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=80910282 button=1 downs=1
12-07 22:09:30.184+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.184+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.184+0900 E/EFL     (  803): evas_main<803> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-07 22:09:30.184+0900 E/EFL     (  803): evas_main<803> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-07 22:09:30.184+0900 E/EFL     (  803): evas_main<803> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-07 22:09:30.189+0900 E/EFL     (  803): evas_main<803> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80910320 button=1 downs=0
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(159) ev->cur.canvas.y(269)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(172) ev->cur.canvas.y(270)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.199+0900 W/WATCH_CORE(27627): appcore-watch.c: __widget_resume(1012) > widget_resume
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.199+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.199+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:30.199+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.199+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.214+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.214+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(183) ev->cur.canvas.y(271)
12-07 22:09:30.214+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.214+0900 W/W_HOME  (  715): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
12-07 22:09:30.214+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.214+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.214+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.214+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(202) ev->cur.canvas.y(271)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(221) ev->cur.canvas.y(271)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.234+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.234+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.234+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.249+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.249+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(234) ev->cur.canvas.y(271)
12-07 22:09:30.249+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.249+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88128), locked_x(0)
12-07 22:09:30.249+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88128)
12-07 22:09:30.249+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.249+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.279+0900 E/PKGMGR_SERVER(27964): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1857806329], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-1857806329' '-r' 'org.reolab.blackandwhite'], cookie=[D837MbYDFmw5J3C+ozB67vYCCgo=], backend_flag=[0]
12-07 22:09:30.279+0900 E/PKGMGR  (27964): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-07 22:09:30.279+0900 E/PKGMGR_SERVER(27964): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(250) ev->cur.canvas.y(271)
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), block(2)
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), ev->cur.canvas.x(265) ev->cur.canvas.y(271)
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88128), hold(0) freeze(0)
12-07 22:09:30.294+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=80910444 button=1 downs=0
12-07 22:09:30.294+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88128), type(elm_scroller)
12-07 22:09:30.299+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.299+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.299+0900 E/PKGMGR_SERVER(27966): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-07 22:09:30.309+0900 E/PKGMGR  (27962): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[279620002]
12-07 22:09:30.324+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.324+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.334+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.334+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.359+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.359+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.379+0900 W/W_HOME  (  715): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-07 22:09:30.379+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:30.384+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.384+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.389+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-07 22:09:30.404+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-07 22:09:30.404+0900 I/ELM_RPANEL(  715): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-07 22:09:30.419+0900 W/wnotib  (  715): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-07 22:09:30.419+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88128 : elm_scroller] CurrentPage(2)
12-07 22:09:30.519+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-07 22:09:30.524+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-07 22:09:30.529+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 22:09:30.539+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:09:30.584+0900 W/W_HOME  (  715): event_manager.c: _home_scroll_cb(564) > scroll,done
12-07 22:09:30.919+0900 W/W_HOME  (  715): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
12-07 22:09:30.994+0900 I/CAPI_WATCH_APPLICATION(27627): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:31.189+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-07 22:09:31.194+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-07 22:09:31.199+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-07 22:09:31.214+0900 E/PKGMGR_CERT(27966): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-07 22:09:31.339+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1127627626c611449493771
12-07 22:09:31.589+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 27627
12-07 22:09:32.829+0900 E/PKGMGR_SERVER(27964): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 22:09:33.339+0900 E/rpm-installer(27966): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-07 22:09:34.829+0900 E/PKGMGR_SERVER(27964): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 22:09:36.284+0900 E/PKGMGR_SERVER(27964): pkgmgr-server.c: sighandler(445) > child NORMAL exit [27966]
12-07 22:09:36.294+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:09:36.329+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-07 22:09:36.329+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-07 22:09:36.334+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:09:36.339+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-07 22:09:36.339+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-07 22:09:36.339+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-07 22:09:36.339+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-07 22:09:36.344+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-07 22:09:36.349+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:36.359+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:36.359+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 22:09:36.359+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 22:09:36.429+0900 E/APPS    (  715): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-07 22:09:36.519+0900 E/PKGMGR_INFO(  483): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-07 22:09:36.829+0900 E/PKGMGR_SERVER(27964): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 22:09:36.829+0900 E/PKGMGR_SERVER(27964): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 22:09:39.364+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:09:39.379+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:39.394+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:39.394+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 22:09:39.394+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 22:09:39.404+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 22:09:39.404+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 22:09:39.409+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 22:09:39.409+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-07 22:09:39.409+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 22:09:39.444+0900 I/CAPI_WATCH_APPLICATION(27788): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 22:09:39.469+0900 E/TBM     (27788): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 22:09:39.519+0900 E/RESOURCED(  498): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.reolab.blackandwhite
12-07 22:09:39.564+0900 W/WATCH_CORE(27788): appcore-watch.c: __widget_create(958) > widget_create
12-07 22:09:39.569+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [76046.937500] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29360992:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 22:09:39.569+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[76046.937500] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29360992:4] gbar_fname[]
12-07 22:09:39.579+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 22:09:39.579+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 22:09:39.724+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1127788626c611449493779
12-07 22:09:39.979+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 22:09:39.979+0900 E/AUL_AMD (  495): amd_request.c: __app_process_by_pid(193) > pid(27788) is dead. cmd(4) is canceled
12-07 22:09:39.984+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:09:39.994+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:40.004+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:40.004+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 22:09:40.004+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 22:09:40.024+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 22:09:40.024+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 22:09:40.024+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 22:09:40.519+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(526) > Candidate is not prepared, enter legacy logic
12-07 22:09:40.519+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 22:09:40.519+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2037) > Launch with legacy way : no launchpad
12-07 22:09:40.524+0900 W/AUL_AMD (  495): amd_launch.c: start_process(573) > child process: 28046
12-07 22:09:40.539+0900 E/RESOURCED( 1078): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
12-07 22:09:40.539+0900 E/AUL     ( 1078): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
12-07 22:09:40.539+0900 E/CAPI_APPFW_APP_MANAGER( 1078): app_manager.c: app_manager_error(76) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
12-07 22:09:40.574+0900 W/AUL_AMD (  495): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 28046
12-07 22:09:40.574+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:09:40.574+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:09:40.574+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 27788
12-07 22:09:40.644+0900 I/CAPI_WATCH_APPLICATION(28046): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 22:09:40.844+0900 E/TBM     (28046): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 22:09:40.874+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:09:40.884+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28046
12-07 22:09:40.924+0900 W/WATCH_CORE(28046): appcore-watch.c: __widget_create(958) > widget_create
12-07 22:09:40.934+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [76046.937500] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29360996:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 22:09:40.934+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[76046.937500] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_76046.937500.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29360996:4] gbar_fname[]
12-07 22:09:40.989+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 22:09:40.989+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 22:09:41.089+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:09:41.584+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:09:41.584+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:09:41.734+0900 I/AUL_PAD (28045): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 22:09:41.829+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 22:09:41.834+0900 E/AUL     (  495): app_sock.c: __connect_client_sock(194) > connect error: 111
12-07 22:09:41.834+0900 E/AUL     (  495): app_sock.c: __create_client_sock(160) > cannot connect the client socket: 111
12-07 22:09:41.934+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1128046626c61144949378
