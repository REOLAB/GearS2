S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 7700
Date: 2015-12-10 22:10:04+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x25203edc

Register Information
r0   = 0x25203ed0, r1   = 0x0000000d
r2   = 0x25203d20, r3   = 0x41453194
r4   = 0x25203ed0, r5   = 0x00000000
r6   = 0x4209da24, r7   = 0x4206be08
r8   = 0x00000087, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbefa1c2c, sp   = 0xbefa1be0
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   490336 KB
MemFree:     28720 KB
Buffers:     22204 KB
Cached:     149372 KB
VmPeak:     112184 KB
VmSize:     111672 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16332 KB
VmRSS:       16332 KB
VmData:      54692 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22388 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 7700 TID = 7700
7700 7907 7915 

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
41803000 41809000 r-xp /usr/lib/libcore-context-manager.so.1.1.2
41811000 4181e000 r-xp /usr/lib/libalarm.so.0.0.0
41827000 41964000 r-xp /usr/lib/libicui18n.so.51.1
41974000 41a58000 r-xp /usr/lib/libicuuc.so.51.1
41a6d000 41a73000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41a7b000 41a81000 r-xp /usr/lib/libwidget.so.1.0.0
41a8a000 41a8f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a97000 41ace000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41ad7000 41af0000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41af9000 41b23000 r-xp /usr/lib/libnfc.so.1.0.0
41b2c000 41b5d000 r-xp /usr/lib/libmdm.so.1.1.85
41b65000 41b7b000 r-xp /usr/lib/libnetwork.so.0.0.0
41b84000 41b89000 r-xp /usr/lib/libcsc-feature.so.0.0.0
41b91000 41baf000 r-xp /usr/lib/libsensor.so.1.1.0
41bb9000 41bc5000 r-xp /usr/lib/libcapi-context-manager.so.1.2.5
41bce000 41bd7000 r-xp /usr/lib/libcom-core.so.0.0.1
41be0000 41bec000 r-xp /usr/lib/libwidget_service.so.1.0.0
41bf4000 41bfd000 r-xp /usr/lib/libwidget_provider.so.1.0.0
41c06000 41c0c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41c14000 41c1c000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41c24000 41c52000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
41c5e000 41c65000 r-xp /usr/lib/libsensord-share.so
41c6d000 41c7c000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41c85000 41c8d000 r-xp /usr/lib/libdrm.so.2.4.0
41c95000 41c97000 r-xp /usr/lib/libdri2.so.0.0.0
41c9f000 41ca6000 r-xp /usr/lib/libtbm.so.1.0.0
41cae000 41cc8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41cd1000 41cd8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41ce1000 41ce3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41ceb000 41cf2000 r-xp /usr/lib/libminizip.so.1.0.0
41cfa000 41d07000 r-xp /usr/lib/libail.so.0.1.0
41f10000 41f13000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
41f1b000 41f26000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41f2f000 41f46000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
41f62000 41f64000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
41f6c000 41f7a000 rw-p [heap]
41f7a000 420ac000 rw-p [heap]
43865000 44064000 rw-p [stack:7907]
45501000 45d00000 rw-p [stack:7915]
bef82000 befa3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7700)
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
0 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:08:37.395+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:08:37.405+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.410+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(242) ev->cur.canvas.y(190)
12-10 22:08:37.410+0900 W/WATCH_CORE( 7544): appcore-watch.c: __widget_resume(1012) > widget_resume
12-10 22:08:37.410+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.410+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3616 _elm_scroll_hold_animator() [DDO] obj(45c88300), locked_x(0)
12-10 22:08:37.410+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3842 _elm_scroll_hold_animator() [DDO] obj(45c88300)
12-10 22:08:37.415+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:08:37.415+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:08:37.415+0900 I/CAPI_WATCH_APPLICATION( 7544): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:08:37.425+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.430+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(284) ev->cur.canvas.y(191)
12-10 22:08:37.430+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.430+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2443216 button=1 downs=0
12-10 22:08:37.430+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:2277 _elm_scroll_post_event_up() [DDO] lock set false. : obj(45c88300), type(elm_scroller)
12-10 22:08:37.435+0900 W/W_HOME  (  713): index.c: index_show(299) > is_paused:0 show VI:1 visibility:1 vi:(nil)
12-10 22:08:37.435+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:08:37.435+0900 I/CAPI_NETWORK_WIFI( 7544): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:08:37.440+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:08:37.450+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:08:37.450+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:08:37.460+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:08:37.460+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:08:37.475+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:08:37.475+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:08:37.485+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:08:37.485+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:08:37.485+0900 I/CAPI_NETWORK_WIFI( 7544): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:08:37.505+0900 W/W_HOME  (  713): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-10 22:08:37.505+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:08:37.505+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:08:37.505+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:08:37.515+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-10 22:08:37.520+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:08:37.520+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:08:37.535+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:08:37.535+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:08:37.555+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2829) > tobj_item_01 is null
12-10 22:08:37.555+0900 I/ELM_RPANEL(  713): elm-rpanel.c: _panel_swap_effect(2884) > tobj_item_02 is null
12-10 22:08:37.560+0900 W/wnotib  (  713): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1695) > No postponed update.
12-10 22:08:37.565+0900 I/efl-extension(  713): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0x45c88300 : elm_scroller] CurrentPage(1)
12-10 22:08:37.700+0900 W/W_HOME  (  713): event_manager.c: _home_scroll_cb(564) > scroll,done
12-10 22:08:37.705+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-10 22:08:37.720+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.720+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(152) ev->cur.canvas.y(161)
12-10 22:08:37.720+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.720+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2443502 button=1 downs=1
12-10 22:08:37.725+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.725+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(153) ev->cur.canvas.y(158)
12-10 22:08:37.725+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.735+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.735+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(153) ev->cur.canvas.y(157)
12-10 22:08:37.735+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.750+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2443520 button=1 downs=1
12-10 22:08:37.785+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.785+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(153) ev->cur.canvas.y(156)
12-10 22:08:37.785+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.790+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.790+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(149) ev->cur.canvas.y(158)
12-10 22:08:37.790+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.805+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2443598 button=1 downs=0
12-10 22:08:37.820+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2443607 button=1 downs=0
12-10 22:08:37.900+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-10 22:08:37.900+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.900+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(178) ev->cur.canvas.y(138)
12-10 22:08:37.900+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.900+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2443696 button=1 downs=1
12-10 22:08:37.910+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.910+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(178) ev->cur.canvas.y(135)
12-10 22:08:37.910+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.920+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.920+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(179) ev->cur.canvas.y(134)
12-10 22:08:37.925+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.930+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2443701 button=1 downs=1
12-10 22:08:37.955+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.955+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(178) ev->cur.canvas.y(134)
12-10 22:08:37.955+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.965+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.965+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(177) ev->cur.canvas.y(134)
12-10 22:08:37.965+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.975+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:37.975+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(175) ev->cur.canvas.y(137)
12-10 22:08:37.975+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:37.985+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2443782 button=1 downs=0
12-10 22:08:38.000+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2443786 button=1 downs=0
12-10 22:08:38.000+0900 I/CAPI_WATCH_APPLICATION( 7544): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:08:38.020+0900 I/CAPI_NETWORK_WIFI( 7544): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:08:38.045+0900 I/CAPI_NETWORK_WIFI( 7544): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:08:38.180+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-10 22:08:38.185+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.185+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(170) ev->cur.canvas.y(142)
12-10 22:08:38.185+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.185+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2443978 button=1 downs=1
12-10 22:08:38.190+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.190+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(173) ev->cur.canvas.y(140)
12-10 22:08:38.190+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.200+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.200+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(173) ev->cur.canvas.y(138)
12-10 22:08:38.200+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.210+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2443982 button=1 downs=1
12-10 22:08:38.220+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.220+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(173) ev->cur.canvas.y(137)
12-10 22:08:38.220+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.245+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.245+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(172) ev->cur.canvas.y(137)
12-10 22:08:38.245+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.255+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2444050 button=1 downs=0
12-10 22:08:38.270+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2444054 button=1 downs=0
12-10 22:08:38.360+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.360+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(164) ev->cur.canvas.y(135)
12-10 22:08:38.360+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.365+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.365+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(164) ev->cur.canvas.y(133)
12-10 22:08:38.365+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.375+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.380+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(164) ev->cur.canvas.y(132)
12-10 22:08:38.380+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.420+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-10 22:08:38.420+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2444216 button=1 downs=1
12-10 22:08:38.430+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.430+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(159) ev->cur.canvas.y(132)
12-10 22:08:38.430+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.445+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2444238 button=1 downs=0
12-10 22:08:38.445+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2444218 button=1 downs=1
12-10 22:08:38.455+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2444242 button=1 downs=0
12-10 22:08:38.530+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-10 22:08:38.535+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.535+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(153) ev->cur.canvas.y(131)
12-10 22:08:38.535+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.535+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2444327 button=1 downs=1
12-10 22:08:38.540+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.540+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(153) ev->cur.canvas.y(127)
12-10 22:08:38.540+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.560+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2444332 button=1 downs=1
12-10 22:08:38.585+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.585+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(152) ev->cur.canvas.y(128)
12-10 22:08:38.585+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.595+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.595+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(151) ev->cur.canvas.y(130)
12-10 22:08:38.595+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.605+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2444402 button=1 downs=0
12-10 22:08:38.625+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2444406 button=1 downs=0
12-10 22:08:38.695+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.695+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(160) ev->cur.canvas.y(132)
12-10 22:08:38.700+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.705+0900 I/GESTURE (  139): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
12-10 22:08:38.710+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.710+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(156) ev->cur.canvas.y(128)
12-10 22:08:38.710+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.710+0900 E/EFL     (  713): evas_main<713> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2444502 button=1 downs=1
12-10 22:08:38.730+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=2444507 button=1 downs=1
12-10 22:08:38.760+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), block(2)
12-10 22:08:38.760+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), ev->cur.canvas.x(155) ev->cur.canvas.y(129)
12-10 22:08:38.760+0900 E/EFL     (  713): elementary<713> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(45c88300), hold(0) freeze(0)
12-10 22:08:38.770+0900 E/EFL     (  713): evas_main<713> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2444567 button=1 downs=0
12-10 22:08:38.785+0900 E/EFL     ( 7544): evas_main<7544> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=2444570 button=1 downs=0
12-10 22:08:39.000+0900 I/CAPI_WATCH_APPLICATION( 7544): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:08:39.125+0900 I/CAPI_NETWORK_WIFI( 7544): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:08:39.165+0900 I/CAPI_NETWORK_WIFI( 7544): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:08:39.275+0900 W/W_HOME  (  713): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
12-10 22:08:39.590+0900 W/WATCH_CORE( 7544): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 2
12-10 22:08:39.590+0900 I/WATCH_CORE( 7544): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
12-10 22:08:39.610+0900 W/WATCH_CORE( 7544): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-10 22:08:39.610+0900 I/WATCH_CORE( 7544): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-10 22:08:39.620+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-10 22:08:39.620+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-10 22:08:39.625+0900 W/W_HOME  (  713): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-10 22:08:39.625+0900 W/W_HOME  (  713): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-10 22:08:39.625+0900 W/W_HOME  (  713): gesture.c: _manual_render_enable(133) > 1
12-10 22:08:39.625+0900 W/W_HOME  (  713): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-10 22:08:39.625+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:08:39.635+0900 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [gesture]
12-10 22:08:39.635+0900 W/STARTER (  705): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-10 22:08:39.635+0900 E/STARTER (  705): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-10 22:08:39.635+0900 W/STARTER (  705): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-10 22:08:39.635+0900 W/STARTER (  705): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-10 22:08:39.635+0900 I/SCONTEXT-LIB(  662): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-10 22:08:39.645+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-10 22:08:39.710+0900 I/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-10 22:08:39.710+0900 W/TIZEN_N_SOUND_MANAGER( 1108): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-10 22:08:39.710+0900 W/WAKEUP-SERVICE( 1108): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-10 22:08:39.710+0900 I/HIGEAR  ( 1108): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-10 22:08:39.895+0900 W/MUSIC_CONTROL_SERVICE( 1067): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1067]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-10 22:08:39.895+0900 I/SHealth_Common( 1068): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-10 22:08:39.900+0900 I/SHealth_Service( 1068): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-10 22:08:39.920+0900 W/STARTER (  705): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [gesture]
12-10 22:08:39.920+0900 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-10 22:08:39.920+0900 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-10 22:08:39.920+0900 W/STARTER (  705): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-10 22:08:39.925+0900 I/APP_CORE(  713): appcore-efl.c: __do_app(429) > [APP 713] Event: PAUSE State: RUNNING
12-10 22:08:39.925+0900 I/CAPI_APPFW_APPLICATION(  713): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-10 22:08:39.925+0900 W/W_HOME  (  713): main.c: _appcore_pause_cb(690) > appcore pause
12-10 22:08:39.925+0900 W/W_HOME  (  713): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-10 22:08:39.925+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:08:39.930+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:08:39.930+0900 W/W_HOME  (  713): main.c: home_pause(751) > clock/widget paused
12-10 22:08:39.930+0900 W/W_HOME  (  713): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-10 22:08:39.930+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-10 22:08:39.935+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-10 22:08:39.940+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-10 22:08:39.995+0900 I/CAPI_WATCH_APPLICATION( 7544): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-10 22:08:40.020+0900 I/CAPI_NETWORK_WIFI( 7544): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:08:40.035+0900 E/CAPI_APPFW_APP_CONTROL( 1067): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-10 22:08:40.040+0900 W/MUSIC_CONTROL_SERVICE( 1067): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1067]   value = [false][0m
12-10 22:08:40.065+0900 I/CAPI_NETWORK_WIFI( 7544): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:08:40.115+0900 W/WATCH_CORE( 7544): appcore-watch.c: __widget_pause(1001) > widget_pause
12-10 22:08:40.440+0900 I/APP_CORE(  713): appcore-efl.c: __do_app(429) > [APP 713] Event: MEM_FLUSH State: PAUSED
12-10 22:08:42.520+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 1 -> 2
12-10 22:08:42.520+0900 E/WMS     (  462): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-10 22:08:42.520+0900 E/WMS     (  462): ==========
12-10 22:08:42.520+0900 E/WMS     (  462): ##WMS SEND : mgr_gear_wear_onoff_req
12-10 22:08:42.520+0900 E/WMS     (  462): ==========
12-10 22:08:42.525+0900 E/WMS     (  462): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-10 22:08:45.025+0900 I/APP_CORE(  713): appcore-efl.c: __do_app(429) > [APP 713] Event: MEM_FLUSH State: PAUSED
12-10 22:09:15.590+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-10 22:09:15.590+0900 I/RESOURCED(  464): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-10 22:09:25.489+0900 E/SHealth_Common( 1068): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-10 22:09:44.925+0900 E/PKGMGR_SERVER( 7898): pkgmgr-server.c: main(2126) > package manager server start
12-10 22:09:45.050+0900 E/PKGMGR_SERVER( 7898): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-341071135], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-10 22:09:45.055+0900 E/PKGMGR_SERVER( 7900): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-10 22:09:45.060+0900 E/PKGMGR  ( 7890): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-10 22:09:45.125+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:09:45.130+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7544
12-10 22:09:45.135+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 22:09:45.140+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 5
12-10 22:09:45.145+0900 W/AUL_AMD (  454): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(7544), cmd(4)
12-10 22:09:45.145+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:09:45.145+0900 W/CAPI_WATCH_APPLICATION( 7544): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-10 22:09:45.145+0900 W/WATCH_CORE( 7544): appcore-watch.c: __widget_destroy(992) > widget_destory
12-10 22:09:45.145+0900 E/WIDGET_PROVIDER_APP( 7544): client.c: client_fini(1175) > Provider is not initialized
12-10 22:09:45.150+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7544
12-10 22:09:45.155+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 22
12-10 22:09:45.155+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(884) > app status : 4
12-10 22:09:45.155+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 4
12-10 22:09:45.260+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:09:45.325+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-10 22:09:45.365+0900 E/PKGMGR_SERVER( 7900): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-10 22:09:45.385+0900 E/AUL_AMD (  454): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-10 22:09:45.390+0900 W/AUL_AMD (  454): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(7544), cmd(4)
12-10 22:09:45.400+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 0
12-10 22:09:45.450+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 22:09:45.475+0900 I/AUL_AMD (  454): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-10 22:09:45.475+0900 E/AUL_AMD (  454): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-10 22:09:45.475+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(1659) > caller pid : 707
12-10 22:09:45.560+0900 E/PKGMGR_SERVER( 7898): pkgmgr-server.c: sighandler(445) > child NORMAL exit [7900]
12-10 22:09:45.605+0900 E/RESOURCED(  464): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-10 22:09:45.605+0900 E/RESOURCED(  464): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-10 22:09:45.605+0900 W/AUL_AMD (  454): amd_launch.c: _start_app(2026) > pad pid(-5)
12-10 22:09:45.605+0900 W/AUL_PAD ( 1159): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-10 22:09:45.605+0900 W/AUL_PAD ( 1159): launchpad.c: __send_result_to_caller(265) > Check app launching
12-10 22:09:45.655+0900 I/CAPI_WATCH_APPLICATION( 7700): watch_app_main.c: watch_app_main(382) > watch_app_main
12-10 22:09:45.680+0900 E/TBM     ( 7700): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-10 22:09:45.710+0900 I/AUL_AMD (  454): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7544
12-10 22:09:45.745+0900 W/WATCH_CORE( 7700): appcore-watch.c: __widget_create(958) > widget_create
12-10 22:09:45.750+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1712) > [SECURE_LOG] [2238.428467] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_713_2238.428467.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263104:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-10 22:09:45.750+0900 E/WIDGET_VIEWER(  713): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[2238.428467] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_713_2238.428467.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263104:4] gbar_fname[]
12-10 22:09:45.765+0900 E/WIDGET_VIEWER(  713): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-10 22:09:45.765+0900 E/WIDGET_EVAS(  713): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-10 22:09:45.895+0900 I/CAPI_NETWORK_WIFI( 7700): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-10 22:09:45.905+0900 I/CAPI_NETWORK_WIFI( 7700): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-10 22:09:46.090+0900 W/WATCH_CORE( 7700): appcore-watch.c: __widget_create(976) > widget_create done
12-10 22:09:46.120+0900 I/WATCH_CORE( 7700): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-10 22:09:46.120+0900 I/WATCH_CORE( 7700): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-10 22:09:46.120+0900 I/WATCH_CORE( 7700): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-10 22:09:46.710+0900 W/AUL_AMD (  454): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-10 22:09:46.710+0900 W/AUL_AMD (  454): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-10 22:09:46.725+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 14
12-10 22:09:46.735+0900 W/AUL_AMD (  454): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 7700
12-10 22:09:46.735+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 12
12-10 22:09:46.940+0900 I/AUL_PAD ( 7930): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-10 22:09:47.155+0900 W/AUL_AMD (  454): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-10 22:09:47.205+0900 E/PKGMGR_SERVER( 7898): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-10 22:09:47.205+0900 E/PKGMGR_SERVER( 7898): pkgmgr-server.c: main(2180) > package manager server terminated.
12-10 22:09:58.135+0900 E/PKGMGR  ( 8037): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-10 22:09:58.320+0900 E/PKGMGR_SERVER( 8039): pkgmgr-server.c: main(2126) > package manager server start
12-10 22:09:58.460+0900 E/PKGMGR_SERVER( 8039): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-327701173], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-327701173' '-r' 'org.reolab.blackandwhite'], cookie=[2Q6ATCZG+88SvFtwZF45Q4VSeb8=], backend_flag=[0]
12-10 22:09:58.460+0900 E/PKGMGR  ( 8039): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-10 22:09:58.465+0900 E/PKGMGR_SERVER( 8039): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-10 22:09:58.465+0900 E/PKGMGR  ( 8037): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[80370002]
12-10 22:09:58.470+0900 E/PKGMGR_SERVER( 8040): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-10 22:09:58.645+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-10 22:09:58.650+0900 W/AUL_AMD (  454): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-10 22:09:58.665+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-10 22:09:58.675+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 22:09:58.725+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 74 -> 73 1449752998 240
12-10 22:09:58.725+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 73 494 19 601
12-10 22:09:58.725+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 73 0 0 1659
12-10 22:09:58.725+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 73 1332 274 1621
12-10 22:09:58.725+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 73 360 5 438
12-10 22:09:58.725+0900 I/RESOURCED(  464): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 73 508 18 618
12-10 22:09:59.260+0900 E/PKGMGR_CERT( 8040): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-10 22:09:59.270+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 22:09:59.275+0900 E/PKGMGR_CERT( 8040): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
12-10 22:09:59.275+0900 E/PKGMGR_CERT( 8040): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
12-10 22:09:59.275+0900 E/PKGMGR_CERT( 8040): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 3
12-10 22:09:59.280+0900 E/PKGMGR_CERT( 8040): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 3
12-10 22:09:59.280+0900 E/PKGMGR_CERT( 8040): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 3
12-10 22:09:59.280+0900 E/PKGMGR_CERT( 8040): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 3
12-10 22:09:59.300+0900 E/PKGMGR_CERT( 8040): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-10 22:10:01.125+0900 E/rpm-installer( 8040): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-10 22:10:01.205+0900 E/PKGMGR_SERVER( 8039): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 22:10:03.205+0900 E/PKGMGR_SERVER( 8039): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-10 22:10:04.165+0900 E/PKGMGR_SERVER( 8039): pkgmgr-server.c: sighandler(445) > child NORMAL exit [8040]
12-10 22:10:04.180+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-10 22:10:04.210+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-10 22:10:04.210+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-10 22:10:04.225+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-10 22:10:04.225+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-10 22:10:04.225+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-10 22:10:04.225+0900 E/WMS     (  462): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-10 22:10:04.255+0900 W/W_HOME  (  713): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-10 22:10:04.310+0900 E/APPS    (  713): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-10 22:10:04.315+0900 E/PKGMGR_INFO(  461): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-10 22:10:04.680+0900 W/AUL_AMD (  454): amd_request.c: __request_handler(640) > __request_handler: 4
12-10 22:10:04.690+0900 E/AUL     (  454): app_sock.c: __connect_client_sock(194) > connect error: 111
12-10 22:10:04.690+0900 E/AUL     (  454): app_sock.c: __create_client_sock(160) > cannot connect the client socket: 111
12-10 22:10:04.795+0900 E/AUL     (  454): app_sock.c: __connect_client_sock(194) > connect error: 111
12-10 22:10:04.795+0900 E/AUL     (  454): app_sock.c: __create_client_sock(160) > cannot connect the client socket: 111
12-10 22:10:04.815+0900 E/RESOURCED(  464): procfs.c: proc_get_oom_score_adj(124) > [proc_get_oom_score_adj,124] fopen /proc/7700/oom_score_adj failed
12-10 22:10:04.815+0900 E/RESOURCED(  464): proc-main.c: resourced_proc_status_change(860) > [resourced_proc_status_change,860] Empty pid or process not exists. 7700
12-10 22:10:05.090+0900 W/CRASH_MANAGER( 8051): worker.c: worker_job(1199) > 1107700626c61144975300
