S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 16238
Date: 2015-12-12 08:33:32+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xe88

Register Information
r0   = 0x414ec888, r1   = 0x000000ff
r2   = 0x000000ff, r3   = 0x000000ff
r4   = 0xbe9305d0, r5   = 0xbe9302d0
r6   = 0x00000132, r7   = 0xbe92fa00
r8   = 0x4030b9c0, r9   = 0x41460078
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4155d580, sp   = 0xbe92f9f0
lr   = 0x41554385, pc   = 0x00000e88
cpsr = 0x20000010

Memory Information
MemTotal:   489992 KB
MemFree:     12448 KB
Buffers:     28040 KB
Cached:     101800 KB
VmPeak:     119664 KB
VmSize:     119152 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16096 KB
VmRSS:       16096 KB
VmData:      62624 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 16238 TID = 16238
16238 16491 16502 

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
43757000 43f56000 rw-p [stack:16491]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43f75000 43f8c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:16502]
be910000 be931000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16238)
Call Stack Count: 1
 0: (0xe88) (null)
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
_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:32:09.036+0900 I/CAPI_NETWORK_WIFI(16058): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:32:09.511+0900 I/APP_CORE( 1171): appcore-efl.c: __do_app(429) > [APP 1171] Event: MEM_FLUSH State: PAUSED
12-12 08:32:09.996+0900 I/CAPI_WATCH_APPLICATION(16058): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:32:10.031+0900 I/CAPI_NETWORK_WIFI(16058): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:32:10.056+0900 I/CAPI_NETWORK_WIFI(16058): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:32:10.306+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-12 08:32:10.306+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-12 08:32:10.306+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(16) ev->cur.canvas.y(169)
12-12 08:32:10.306+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-12 08:32:10.306+0900 E/EFL     (  717): evas_main<717> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11991274 button=1 downs=1
12-12 08:32:10.306+0900 E/EFL     (  717): evas_main<717> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=11991274 device=10 downs=2
12-12 08:32:10.316+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-12 08:32:10.316+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(18) ev->cur.canvas.y(169)
12-12 08:32:10.316+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-12 08:32:10.326+0900 I/GESTURE (  139): gesture.c: GestureHandleGesture_Hold(704) > [PalmHold] PalmHold success !
12-12 08:32:10.326+0900 I/GESTURE (  139): gesture.c: GestureHandleGesture_Hold(742) > [GroupHold] GestureHold success !
12-12 08:32:10.326+0900 I/GESTURE (  139): gesture.c: GestureHandleGesture_Hold(704) > [PalmHold] PalmHold success !
12-12 08:32:10.326+0900 I/GESTURE (  139): gesture.c: GestureHandleGesture_Hold(742) > [GroupHold] GestureHold success !
12-12 08:32:10.326+0900 E/EFL     (  717): ecore_x<717> ecore_x_xi2.c:273 _ecore_x_input_handler() TouchCancel ButtonEvent: cancel time=0
12-12 08:32:10.326+0900 E/EFL     (  717): ecore_x<717> ecore_x_xi2.c:273 _ecore_x_input_handler() TouchCancel ButtonEvent: cancel time=0
12-12 08:32:10.326+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), block(2)
12-12 08:32:10.326+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), ev->cur.canvas.x(180) ev->cur.canvas.y(180)
12-12 08:32:10.326+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c87f00), hold(0) freeze(0)
12-12 08:32:10.326+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:4248 _elm_scroll_mouse_move_event_cb() [DDO] animator
12-12 08:32:10.326+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3352 _elm_scroll_post_event_move() [DDO] obj(45c87f00), type(elm_scroller)
12-12 08:32:10.326+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3353 _elm_scroll_post_event_move() [DDO] hold_parent(0)
12-12 08:32:10.326+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:3381 _elm_scroll_post_event_move() [DDO] elm_widget_drag_lock_x_set : obj(45c87f00), type(elm_scroller)
12-12 08:32:10.351+0900 W/W_HOME  (  717): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0x4aa54828 -> 360 0 0x45d25290
12-12 08:32:10.361+0900 E/EFL     (  717): evas_main<717> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=0 button=1 downs=1
12-12 08:32:10.361+0900 E/EFL     (  717): elementary<717> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c87f00), type(elm_scroller)
12-12 08:32:10.361+0900 E/EFL     (  717): evas_main<717> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=0 device=10 downs=0
12-12 08:32:10.361+0900 W/W_HOME  (  717): event_manager.c: _home_scroll_cb(564) > scroll,start
12-12 08:32:10.366+0900 E/EFL     (16058): evas_main<16058> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=11991279 button=1 downs=1
12-12 08:32:10.381+0900 W/WATCH_CORE(16058): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-12 08:32:10.381+0900 I/WATCH_CORE(16058): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-12 08:32:10.381+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdoff_cb(440) >  event pre lcdoff[1]
12-12 08:32:10.381+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(276) >  enabled[1] status[1]
12-12 08:32:10.386+0900 E/EFL     (16058): evas_main<16058> evas_events.c:2103 evas_event_feed_multi_down() ButtonEvent:multi down time=11991280 device=10 downs=2
12-12 08:32:10.401+0900 W/W_HOME  (  717): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-12 08:32:10.401+0900 W/W_HOME  (  717): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-12 08:32:10.401+0900 W/W_HOME  (  717): gesture.c: _manual_render_enable(133) > 1
12-12 08:32:10.401+0900 W/W_HOME  (  717): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-12 08:32:10.401+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:32:10.401+0900 W/W_HOME  (  717): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
12-12 08:32:10.401+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [event]
12-12 08:32:10.401+0900 W/STARTER (  693): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-12 08:32:10.401+0900 E/STARTER (  693): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-12 08:32:10.401+0900 W/STARTER (  693): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-12 08:32:10.401+0900 W/STARTER (  693): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-12 08:32:10.406+0900 I/SCONTEXT-LIB(  669): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-12 08:32:10.406+0900 E/EFL     (16058): evas_main<16058> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=11991304 button=1 downs=1
12-12 08:32:10.411+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(1)
12-12 08:32:10.411+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
12-12 08:32:10.411+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:32:10.411+0900 W/W_HOME  (  717): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(1)
12-12 08:32:10.446+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: RUNNING
12-12 08:32:10.446+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-12 08:32:10.446+0900 W/W_HOME  (  717): main.c: _appcore_pause_cb(690) > appcore pause
12-12 08:32:10.446+0900 W/W_HOME  (  717): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-12 08:32:10.446+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:32:10.446+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:32:10.446+0900 W/W_HOME  (  717): main.c: home_pause(751) > clock/widget paused
12-12 08:32:10.446+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:32:10.446+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdoff_cb(492) >  clock start >> [0]
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-12 08:32:10.446+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:32:10.451+0900 E/CAPI_APPFW_APP_CONTROL(  834): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-12 08:32:10.451+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:834]   value = [false][0m
12-12 08:32:10.451+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdoff_cb(502) >  clock begin >>
12-12 08:32:10.451+0900 I/APP_CORE(  717): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
12-12 08:32:10.451+0900 I/wnotib  (  717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
12-12 08:32:10.451+0900 E/wnotib  (  717): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-12 08:32:10.456+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-12 08:32:10.456+0900 W/W_HOME  (  717): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
12-12 08:32:10.456+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:32:10.456+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:32:10.461+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:32:10.461+0900 W/W_HOME  (  717): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
12-12 08:32:10.481+0900 E/EFL     (16058): evas_main<16058> evas_events.c:2209 evas_event_feed_multi_up() ButtonEvent:multi up time=11991306 device=10 downs=0
12-12 08:32:10.481+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-12 08:32:10.481+0900 W/AUL_AMD (  479): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-12 08:32:10.481+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124317720[0;m
12-12 08:32:10.496+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-12 08:32:10.501+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-12 08:32:10.501+0900 W/WATCH_CORE(16058): appcore-watch.c: __signal_alpm_handler(1039) > signal_alpm_handler: ambient mode: 1, state: 2
12-12 08:32:10.501+0900 W/CAPI_WATCH_APPLICATION(16058): watch_app_main.c: _watch_core_ambient_changed(337) > _watch_core_ambient_changed: 1
12-12 08:32:10.501+0900 W/ALARM_MANAGER(16058): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(50), start(12-12-2015, 08:33:01), repeat(1), interval(60), type(-1073741822)
12-12 08:32:10.556+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:834]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-12 08:32:10.576+0900 I/SHealth_Common( 1061): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-12 08:32:10.576+0900 I/SHealth_Service( 1061): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-12 08:32:10.576+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-12 08:32:10.581+0900 W/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-12 08:32:10.581+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-12 08:32:10.581+0900 I/HIGEAR  ( 1131): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-12 08:32:10.601+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:32:10.606+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:32:10.616+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 603337968, next duetime: 1449876781
12-12 08:32:10.616+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(603337968)
12-12 08:32:10.616+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449876781), due_time(1449876781)
12-12 08:32:10.616+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:32:10.616+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:33:01 (UTC).
12-12 08:32:10.616+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:32:10.631+0900 I/CAPI_NETWORK_WIFI(16058): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:32:10.651+0900 I/CAPI_NETWORK_WIFI(16058): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:32:10.701+0900 I/WATCH_CORE(16058): appcore-watch-signal.c: _watch_core_send_alpm_update_done(282) > send a alpm update done signal
12-12 08:32:10.701+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_clockdraw_cb(325) >  Clock draw done
12-12 08:32:10.706+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[0]
12-12 08:32:10.706+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[0] lcd[1]
12-12 08:32:10.791+0900 W/W_HOME  (  717): event_manager.c: _home_scroll_cb(564) > scroll,done
12-12 08:32:10.806+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_check_timer_cb(218) >  Render check timer expired
12-12 08:32:10.806+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_clockend_timer_cb(192) >  clock end << [1]
12-12 08:32:10.816+0900 W/ALARM_MANAGER(15061): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(1800), start(12-12-2015, 09:02:11), repeat(1), interval(1800), type(-1073741822)
12-12 08:32:10.861+0900 W/W_HOME  (  717): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
12-12 08:32:10.956+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-12 08:32:10.966+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 603337969, next duetime: 1449878531
12-12 08:32:10.966+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(603337969)
12-12 08:32:10.986+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449876781), due_time(1449878531)
12-12 08:32:10.986+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:32:10.991+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:33:01 (UTC).
12-12 08:32:10.991+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:32:11.011+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [event]
12-12 08:32:11.011+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[1]
12-12 08:32:11.011+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-12 08:32:11.011+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-12 08:32:11.026+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(529) >  event lcdoff completed[1][0]
12-12 08:32:11.026+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(276) >  enabled[1] status[1]
12-12 08:32:15.456+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-12 08:32:15.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:32:15.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:32:20.681+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:32:20.741+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:32:25.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:32:25.756+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:32:30.696+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:32:30.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:32:35.687+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:32:35.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:32:40.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:32:40.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:32:41.996+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-12 08:32:42.001+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-12 08:32:45.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:32:45.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:32:50.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:32:50.746+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:32:55.681+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:32:55.746+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:32:56.206+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-12 08:32:56.211+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:32:56.216+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-12 08:32:56.216+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-12 08:32:56.646+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-12 08:33:00.616+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:33:00.681+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:33:00.996+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-12 08:33:01.061+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-12 08:33:01.126+0900 E/RESOURCED(  480): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 14859
12-12 08:33:01.141+0900 W/ALARM_MANAGER(16058): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [1681431895]
12-12 08:33:01.146+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[1681431895] is expired.
12-12 08:33:01.146+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1681431895, next duetime: 1449876841
12-12 08:33:01.196+0900 W/ALARM_MANAGER(16058): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [603337968]
12-12 08:33:01.196+0900 W/WATCH_CORE(16058): appcore-watch.c: __watch_core_ambient_tick(943) > state: 3
12-12 08:33:01.216+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[603337968] is expired.
12-12 08:33:01.216+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 603337968, next duetime: 1449876841
12-12 08:33:01.221+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:33:01.226+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:34:01 (UTC).
12-12 08:33:01.226+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:33:01.226+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-12 08:33:01.241+0900 I/CAPI_NETWORK_WIFI(16058): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:01.256+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-12 08:33:01.281+0900 I/CAPI_NETWORK_WIFI(16058): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:01.351+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:01.351+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:05.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:33:05.671+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:33:10.687+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:33:10.752+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:33:15.676+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:33:15.701+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:33:18.486+0900 E/PKGMGR_SERVER(16488): pkgmgr-server.c: main(2126) > package manager server start
12-12 08:33:18.591+0900 E/PKGMGR_SERVER(16488): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1081574759], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-12 08:33:18.596+0900 E/PKGMGR_SERVER(16489): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-12 08:33:18.601+0900 E/PKGMGR  (16486): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-12 08:33:18.661+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:33:18.666+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16058
12-12 08:33:18.671+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-12 08:33:18.671+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 5
12-12 08:33:18.676+0900 W/CAPI_WATCH_APPLICATION(16058): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-12 08:33:18.676+0900 W/WATCH_CORE(16058): appcore-watch.c: __widget_destroy(992) > widget_destory
12-12 08:33:18.676+0900 E/WIDGET_PROVIDER_APP(16058): client.c: client_fini(1175) > Provider is not initialized
12-12 08:33:18.676+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 22
12-12 08:33:18.676+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(884) > app status : 4
12-12 08:33:18.676+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(16058), cmd(4)
12-12 08:33:18.681+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 4
12-12 08:33:18.681+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:33:18.691+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16058
12-12 08:33:18.791+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:33:18.816+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-12 08:33:18.846+0900 E/PKGMGR_SERVER(16489): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-12 08:33:18.906+0900 E/PKGMGR_SERVER(16488): pkgmgr-server.c: sighandler(445) > child NORMAL exit [16489]
12-12 08:33:18.926+0900 E/AUL_AMD (  479): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-12 08:33:18.931+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(27) , send fd(13), pid(16058), cmd(4)
12-12 08:33:18.941+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-12 08:33:18.986+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-12 08:33:19.016+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-12 08:33:19.016+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-12 08:33:19.016+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 698
12-12 08:33:19.126+0900 E/RESOURCED(  480): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-12 08:33:19.126+0900 E/RESOURCED(  480): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-12 08:33:19.131+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(2026) > pad pid(-5)
12-12 08:33:19.131+0900 W/AUL_PAD ( 1168): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-12 08:33:19.131+0900 W/AUL_PAD ( 1168): launchpad.c: __send_result_to_caller(265) > Check app launching
12-12 08:33:19.176+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: watch_app_main(382) > watch_app_main
12-12 08:33:19.201+0900 E/TBM     (16238): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-12 08:33:19.236+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 16058
12-12 08:33:19.281+0900 W/WATCH_CORE(16238): appcore-watch.c: __widget_create(958) > widget_create
12-12 08:33:19.281+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [5251.320801] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_5251.320801.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263154:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-12 08:33:19.281+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[5251.320801] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_5251.320801.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263154:4] gbar_fname[]
12-12 08:33:19.281+0900 E/WIDGET_VIEWER(15061): client.c: master_created(1712) > [SECURE_LOG] [5251.320801] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_5251.320801.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263154:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-12 08:33:19.281+0900 E/WIDGET_VIEWER(15061): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[5251.320801] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_5251.320801.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263154:4] gbar_fname[]
12-12 08:33:19.296+0900 E/WIDGET_VIEWER(15061): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-12 08:33:19.296+0900 E/WIDGET_EVAS(15061): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-12 08:33:19.296+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-12 08:33:19.296+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-12 08:33:19.441+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:19.446+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:19.626+0900 W/WATCH_CORE(16238): appcore-watch.c: __widget_create(976) > widget_create done
12-12 08:33:19.661+0900 I/WATCH_CORE(16238): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-12 08:33:19.666+0900 I/WATCH_CORE(16238): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-12 08:33:19.666+0900 I/WATCH_CORE(16238): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-12 08:33:19.701+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:19.701+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:19.706+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:19.706+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:19.711+0900 W/WATCH_CORE(16238): appcore-watch.c: __widget_resume(1012) > widget_resume
12-12 08:33:19.711+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:19.721+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:19.721+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:19.741+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:19.761+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:19.821+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:19.821+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:19.996+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:20.011+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:20.016+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:20.066+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:20.066+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:20.236+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-12 08:33:20.236+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-12 08:33:20.251+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:33:20.261+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16238
12-12 08:33:20.261+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-12 08:33:20.471+0900 I/AUL_PAD (16515): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-12 08:33:20.601+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:33:20.606+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:33:20.681+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-12 08:33:21.001+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:21.031+0900 E/PKGMGR_SERVER(16488): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-12 08:33:21.031+0900 E/PKGMGR_SERVER(16488): pkgmgr-server.c: main(2180) > package manager server terminated.
12-12 08:33:21.091+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:21.271+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:21.331+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:21.331+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:22.001+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:22.121+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:22.241+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:22.316+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:22.316+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:23.001+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:23.151+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:23.246+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:23.341+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:23.341+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:24.001+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:24.046+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:24.081+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:24.196+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:24.196+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:25.006+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:25.121+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:25.246+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:25.321+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:25.321+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:25.606+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:33:25.651+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:33:26.001+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:26.156+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:26.256+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:26.336+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:26.336+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:27.011+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:27.116+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:27.201+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:27.291+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:27.291+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:28.001+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:28.136+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:28.236+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:28.336+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:28.336+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:29.001+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:29.156+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:29.306+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:29.381+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:29.381+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:30.001+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:30.116+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:30.191+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:30.281+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:30.281+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:30.601+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:33:30.616+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:33:30.711+0900 E/PKGMGR  (16673): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-12 08:33:30.876+0900 E/PKGMGR_SERVER(16675): pkgmgr-server.c: main(2126) > package manager server start
12-12 08:33:30.981+0900 E/PKGMGR_SERVER(16675): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1069181316], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-1069181316' '-r' 'org.reolab.blackandwhite'], cookie=[MEcwA0/uHrJUj+3cnyqFHsIwBsc=], backend_flag=[0]
12-12 08:33:30.981+0900 E/PKGMGR  (16675): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-12 08:33:30.981+0900 E/PKGMGR_SERVER(16675): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-12 08:33:30.991+0900 E/PKGMGR  (16673): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[166730002]
12-12 08:33:30.991+0900 E/PKGMGR_SERVER(16677): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-12 08:33:30.996+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:31.016+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:33:31.031+0900 I/CAPI_NETWORK_WIFI(16238): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:33:31.111+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:33:31.111+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:33:31.191+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-12 08:33:31.201+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-12 08:33:31.206+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-12 08:33:31.221+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-12 08:33:31.796+0900 E/PKGMGR_CERT(16677): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-12 08:33:31.806+0900 E/PKGMGR_CERT(16677): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 96
12-12 08:33:31.806+0900 E/PKGMGR_CERT(16677): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 96
12-12 08:33:31.806+0900 E/PKGMGR_CERT(16677): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 4
12-12 08:33:31.811+0900 E/PKGMGR_CERT(16677): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 4
12-12 08:33:31.811+0900 E/PKGMGR_CERT(16677): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 4
12-12 08:33:31.811+0900 E/PKGMGR_CERT(16677): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 4
12-12 08:33:31.816+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-12 08:33:31.831+0900 E/PKGMGR_CERT(16677): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-12 08:33:31.996+0900 I/CAPI_WATCH_APPLICATION(16238): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:33:32.256+0900 W/CRASH_MANAGER(16678): worker.c: worker_job(1199) > 1116238626c61144987681
