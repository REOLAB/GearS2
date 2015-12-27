S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 14112
Date: 2015-12-09 21:39:25+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x4a4

Register Information
r0   = 0x00000498, r1   = 0x0000000d
r2   = 0x000002f8, r3   = 0x41453194
r4   = 0x00000498, r5   = 0x00000000
r6   = 0x41c27cf4, r7   = 0x41c00e08
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeb4ac5c, sp   = 0xbeb4ac10
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     33796 KB
Buffers:     30016 KB
Cached:     122740 KB
VmPeak:      78840 KB
VmSize:      78328 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15408 KB
VmRSS:       15408 KB
VmData:      21840 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22096 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 14112 TID = 14112
14112 14202 14211 

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
41aeb000 41b01000 r-xp /usr/lib/libnetwork.so.0.0.0
41b0a000 41b0f000 rw-p [heap]
41b0f000 41c41000 rw-p [heap]
41c41000 41c6b000 r-xp /usr/lib/libnfc.so.1.0.0
41c74000 41ca5000 r-xp /usr/lib/libmdm.so.1.1.85
41cad000 41cb2000 r-xp /usr/lib/libcsc-feature.so.0.0.0
43241000 4324a000 r-xp /usr/lib/libcom-core.so.0.0.1
43253000 4325f000 r-xp /usr/lib/libwidget_service.so.1.0.0
43267000 43270000 r-xp /usr/lib/libwidget_provider.so.1.0.0
43279000 4327f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43287000 4328f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43297000 432c5000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
432d1000 432d9000 r-xp /usr/lib/libdrm.so.2.4.0
432e1000 432e3000 r-xp /usr/lib/libdri2.so.0.0.0
432eb000 432f2000 r-xp /usr/lib/libtbm.so.1.0.0
432fa000 43314000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
4331d000 43324000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
4332d000 4332f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43337000 4333e000 r-xp /usr/lib/libminizip.so.1.0.0
43346000 43353000 r-xp /usr/lib/libail.so.0.1.0
4378e000 43f8d000 rw-p [stack:14202]
43f8d000 43f90000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f98000 43fa3000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
4402b000 44042000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44282000 44b00000 rw-p [stack:14211]
beb2b000 beb4c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14112)
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
5) > Check app launching
12-09 21:37:44.484+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: watch_app_main(382) > watch_app_main
12-09 21:37:44.519+0900 E/TBM     (13958): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-09 21:37:44.539+0900 E/RESOURCED(  532): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.reolab.blackandwhite
12-09 21:37:44.539+0900 W/WATCH_CORE( 6326): appcore-watch.c: __widget_resume(1012) > widget_resume
12-09 21:37:44.539+0900 I/CAPI_WATCH_APPLICATION( 6326): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:44.624+0900 W/WATCH_CORE(13958): appcore-watch.c: __widget_create(958) > widget_create
12-09 21:37:44.829+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1712) > [SECURE_LOG] [9879.414062] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_9879.414062.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-09 21:37:44.839+0900 W/W_HOME  (  707): dbox.c: _widget_created_cb(238) > widget resume:0x487653c0
12-09 21:37:44.839+0900 E/WIDGET_VIEWER(  707): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
12-09 21:37:44.864+0900 E/WIDGET_VIEWER(  707): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-09 21:37:44.864+0900 E/WIDGET_EVAS(  707): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-09 21:37:44.999+0900 I/CAPI_WATCH_APPLICATION( 6326): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:45.154+0900 F/EFL     (13958): evas_main<13958> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:37:45.154+0900 F/EFL     (13958):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:37:45.154+0900 F/EFL     (13958):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:37:45.154+0900 F/EFL     (13958): evas_main<13958> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:37:45.154+0900 F/EFL     (13958):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:37:45.154+0900 F/EFL     (13958):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:37:45.159+0900 F/EFL     (13958): evas_main<13958> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:37:45.159+0900 F/EFL     (13958):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:37:45.159+0900 F/EFL     (13958):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:37:45.179+0900 W/WATCH_CORE(13958): appcore-watch.c: __widget_create(976) > widget_create done
12-09 21:37:45.339+0900 I/WATCH_CORE(13958): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-09 21:37:45.344+0900 I/WATCH_CORE(13958): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-09 21:37:45.344+0900 I/WATCH_CORE(13958): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-09 21:37:45.454+0900 W/WATCH_CORE(13958): appcore-watch.c: __widget_resume(1012) > widget_resume
12-09 21:37:45.504+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:45.539+0900 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 21:37:45.539+0900 W/AUL_AMD (  530): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-09 21:37:45.629+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:37:45.639+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13958
12-09 21:37:45.654+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 21:37:45.994+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:46.004+0900 I/CAPI_WATCH_APPLICATION( 6326): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:46.014+0900 E/W_HOME  (  707): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-09 21:37:46.034+0900 W/W_HOME  (  707): clock_view.c: clock_view_attach(512) > changed pause/resume option -> manual
12-09 21:37:46.034+0900 E/EFL     (  707): elementary<707> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88058), origin_x(0), origin_y(0)
12-09 21:37:46.034+0900 W/W_HOME  (  707): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-09 21:37:46.034+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:37:46.044+0900 E/EFL     (  707): elementary<707> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88058), origin_x(0), origin_y(0)
12-09 21:37:46.049+0900 W/W_HOME  (  707): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-09 21:37:46.049+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:37:46.054+0900 W/W_HOME  (  707): clock_view.c: clock_view_attach(529) > changed pause/resume option -> automatic
12-09 21:37:46.054+0900 W/W_HOME  (  707): clock_manager.c: clock_manager_clock_set(255) > attached clock isn't cleaned-up, yet
12-09 21:37:46.054+0900 E/W_HOME  (  707): page.c: _page_clip_del(240) > (!page_info) -> _page_clip_del() return
12-09 21:37:46.054+0900 E/W_HOME  (  707): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
12-09 21:37:46.059+0900 W/W_HOME  (  707): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
12-09 21:37:46.059+0900 E/W_HOME  (  707): dbox.c: del_cb(225) > Add viewer has no info: WqpvTWhGk0.gearoclockswisssense
12-09 21:37:46.069+0900 W/W_HOME  (  707): cfwd.c: cfwd_get_icon_status(362) > 
12-09 21:37:46.069+0900 W/W_HOME  (  707): ============================
12-09 21:37:46.069+0900 W/W_HOME  (  707): multi_sim_category:0
12-09 21:37:46.069+0900 W/W_HOME  (  707): multi_sim_model:0
12-09 21:37:46.069+0900 W/W_HOME  (  707): support_callforward_auto:0
12-09 21:37:46.069+0900 W/W_HOME  (  707): conn_status:16
12-09 21:37:46.069+0900 W/W_HOME  (  707): remote_call_forward_auto:0
12-09 21:37:46.069+0900 W/W_HOME  (  707): auto_call_forward_status:0
12-09 21:37:46.069+0900 W/W_HOME  (  707): support_callforward_reverse:0
12-09 21:37:46.069+0900 W/W_HOME  (  707): reverse_call_forward_auto:0
12-09 21:37:46.069+0900 W/W_HOME  (  707): fwd_type:
12-09 21:37:46.069+0900 W/W_HOME  (  707): ============================
12-09 21:37:46.069+0900 W/W_HOME  (  707): 
12-09 21:37:46.069+0900 W/W_HOME  (  707): clock_view_indicator.c: _view_call_fw_icon(131) > call fwd status:0
12-09 21:37:46.069+0900 E/W_HOME  (  707): clock_event.c: _flightmode_state_get(417) > Failed to get VCONFKEY_TELEPHONY_FLIGHT_MODE:db/telephony/flight_mode
12-09 21:37:46.069+0900 E/W_HOME  (  707): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 21:37:46.074+0900 W/W_HOME  (  707): noti_broker.c: _clock_attached_cb(804) > 0
12-09 21:37:46.074+0900 W/W_HOME  (  707): cs_broker.c: _clock_view_attached_cb(231) > 
12-09 21:37:46.074+0900 W/W_HOME  (  707): scroller.c: scroller_unfreeze(1860) > unfreezed:40043c11
12-09 21:37:46.079+0900 W/W_HOME  (  707): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,hide
12-09 21:37:46.079+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:37:46.084+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:37:46.084+0900 I/CLOCK-LIST(  707): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(264) > send watch_list_event, watch_list_out
12-09 21:37:46.084+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:37:46.084+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:37:46.084+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:37:46.084+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 21:37:46.084+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 21:37:46.084+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:37:46.084+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [org.reolab.blackandwhite:watchface::messageport::event]
12-09 21:37:46.084+0900 E/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(354) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-09 21:37:46.084+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:37:46.084+0900 E/MESSAGE_PORT(  707): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
12-09 21:37:46.084+0900 E/CLOCK-LIST(  707): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(268) > message_port_send_message returns -18022399(feed0001)
12-09 21:37:46.099+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8a5d8, elm_box, _activated_obj : 0x45c8a5d8, activated : 1
12-09 21:37:46.099+0900 E/wnotib  (  707): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-09 21:37:46.099+0900 I/wnotib  (  707): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5125) > Return true for 245, 102.
12-09 21:37:46.099+0900 I/wnotib  (  707): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
12-09 21:37:46.099+0900 I/efl-extension(  707): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4acec0f8, obj: 0x4acec0f8
12-09 21:37:46.099+0900 I/efl-extension(  707): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-09 21:37:46.104+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-09 21:37:46.104+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4acec0f8, elm_scroller, func : 0x4072fe19
12-09 21:37:46.104+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-09 21:37:46.104+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-09 21:37:46.104+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4ac63070, elm_image, func : 0x4072fe19
12-09 21:37:46.104+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-09 21:37:46.104+0900 I/efl-extension(  707): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(841) > [0x4acec0f8 : elm_scroller] rotary callabck is deleted
12-09 21:37:46.224+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-09 21:37:46.244+0900 W/WATCH_CORE( 6326): appcore-watch.c: __widget_pause(1001) > widget_pause
12-09 21:37:46.319+0900 E/W_HOME  (  707): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
12-09 21:37:46.334+0900 E/WIDGET_VIEWER(  707): client.c: master_widget_updated(787) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/WqpvTWhGk0.gearoclockswisssense_707_9873.978516.png) is not exists, but updated
12-09 21:37:46.339+0900 W/WATCH_CORE( 6326): appcore-watch.c: __widget_destroy(992) > widget_destory
12-09 21:37:46.339+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 22
12-09 21:37:46.339+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(884) > app status : 4
12-09 21:37:46.344+0900 W/CAPI_WATCH_APPLICATION( 6326): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-09 21:37:46.344+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6326): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
12-09 21:37:46.344+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6326): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
12-09 21:37:46.344+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6326): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
12-09 21:37:46.344+0900 I/efl-extension( 6326): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x47001738
12-09 21:37:46.344+0900 I/efl-extension( 6326): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x47001738, obj: 0x47001738
12-09 21:37:46.344+0900 I/efl-extension( 6326): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
12-09 21:37:46.344+0900 I/efl-extension( 6326): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
12-09 21:37:46.344+0900 I/efl-extension( 6326): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
12-09 21:37:46.344+0900 I/efl-extension( 6326): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-09 21:37:46.349+0900 E/EFL     ( 6326): EvasGL<6326> evas_gl_api_ext.c:113 _evgl_egl_display_get() _evgl_evasglDestroyImage: Unable to retrive Current Engine
12-09 21:37:46.349+0900 E/EFL     ( 6326): EvasGL<6326> evas_gl_api_ext.c:113 _evgl_egl_display_get() _evgl_evasglDestroyImage: Unable to retrive Current Engine
12-09 21:37:46.349+0900 E/EFL     ( 6326): EvasGL<6326> evas_gl_api_ext.c:113 _evgl_egl_display_get() _evgl_evasglDestroyImage: Unable to retrive Current Engine
12-09 21:37:46.364+0900 E/CAPI_LOCATION_MANAGER( 6326): locations.c: location_manager_destroy(711) > LOCATIONS_ERROR_INVALID_PARAMETER(0xffffffea)
12-09 21:37:46.369+0900 E/WIDGET_VIEWER(  707): client.c: master_extra_updated(704) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/WqpvTWhGk0.gearoclockswisssense_707_9873.978516.png) is not exists, but updated
12-09 21:37:46.369+0900 E/W_HOME  (  707): move.c: move_back_to_home_no_anim(270) > home is already on position
12-09 21:37:46.369+0900 W/W_HOME  (  707): scroller.c: _get_index_in_list(1902) > page:0x4a086d58 idx:2 total11 exist:1
12-09 21:37:46.369+0900 W/W_HOME  (  707): scroller.c: scroller_unfreeze(1860) > unfreezed:4005277b
12-09 21:37:46.369+0900 E/EFL     (  707): elementary<707> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88058), origin_x(0), origin_y(0)
12-09 21:37:46.369+0900 W/W_HOME  (  707): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
12-09 21:37:46.369+0900 I/efl-extension(21408): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-09 21:37:46.369+0900 W/wnotibp (21408): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1721) > [0, 2, 1]
12-09 21:37:46.379+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02400003)
12-09 21:37:46.384+0900 E/WIDGET_VIEWER(  707): client.c: master_widget_updated(787) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/WqpvTWhGk0.gearoclockswisssense_707_9873.978516.png) is not exists, but updated
12-09 21:37:46.389+0900 E/WIDGET_PROVIDER_APP( 6326): client.c: client_fini(1175) > Provider is not initialized
12-09 21:37:46.389+0900 E/WIDGET_VIEWER(  707): client.c: master_extra_updated(704) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/WqpvTWhGk0.gearoclockswisssense_707_9873.978516.png) is not exists, but updated
12-09 21:37:46.389+0900 E/WIDGET_VIEWER(  707): client.c: master_widget_updated(787) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/WqpvTWhGk0.gearoclockswisssense_707_9873.978516.png) is not exists, but updated
12-09 21:37:46.389+0900 E/WIDGET_VIEWER(  707): client.c: master_extra_updated(704) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/WqpvTWhGk0.gearoclockswisssense_707_9873.978516.png) is not exists, but updated
12-09 21:37:46.389+0900 E/WIDGET_VIEWER(  707): client.c: master_widget_updated(787) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/WqpvTWhGk0.gearoclockswisssense_707_9873.978516.png) is not exists, but updated
12-09 21:37:46.394+0900 E/WIDGET_VIEWER(  707): client.c: master_extra_updated(704) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/WqpvTWhGk0.gearoclockswisssense_707_9873.978516.png) is not exists, but updated
12-09 21:37:46.394+0900 E/WIDGET_VIEWER(  707): client.c: master_widget_updated(787) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/WqpvTWhGk0.gearoclockswisssense_707_9873.978516.png) is not exists, but updated
12-09 21:37:46.394+0900 E/WIDGET_VIEWER(  707): client.c: master_extra_updated(704) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/WqpvTWhGk0.gearoclockswisssense_707_9873.978516.png) is not exists, but updated
12-09 21:37:46.394+0900 E/WIDGET_VIEWER(  707): client.c: master_widget_updated(787) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/WqpvTWhGk0.gearoclockswisssense_707_9873.978516.png) is not exists, but updated
12-09 21:37:46.454+0900 I/UXT     ( 6326): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
12-09 21:37:46.539+0900 I/AUL_PAD (14112): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-09 21:37:46.574+0900 I/efl-extension( 6326): efl_extension.c: eext_mod_shutdown(46) > Shutdown
12-09 21:37:46.584+0900 I/MALI    ( 6326): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
12-09 21:37:46.584+0900 I/MALI    ( 6326): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=6326   close drm_fd=29 
12-09 21:37:46.584+0900 I/MALI    ( 6326): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
12-09 21:37:46.799+0900 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 6326
12-09 21:37:46.999+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:48.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:48.349+0900 W/AUL_AMD (  530): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-09 21:37:48.999+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:50.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:51.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:51.999+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:53.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:54.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:55.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:56.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:56.999+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:57.999+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:37:59.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:00.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:00.999+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:01.119+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-09 21:38:01.119+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-09 21:38:01.124+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : pedometer_inactive_period error
12-09 21:38:01.124+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 21:38:01.124+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 21:38:01.129+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_10min_precaution_millisec error
12-09 21:38:01.129+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-09 21:38:01.134+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-09 21:38:01.134+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_before_10min_precaution_millisec error
12-09 21:38:02.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:03.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:04.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:05.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:06.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:07.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:08.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:08.999+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:10.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:10.999+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:11.329+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-09 21:38:11.329+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-09 21:38:11.339+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-09 21:38:11.339+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-09 21:38:12.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:13.004+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:13.954+0900 W/WATCH_CORE(13958): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-09 21:38:13.954+0900 I/WATCH_CORE(13958): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-09 21:38:13.994+0900 I/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:38:14.004+0900 W/W_HOME  (  707): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 21:38:14.004+0900 W/W_HOME  (  707): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-09 21:38:14.004+0900 W/W_HOME  (  707): gesture.c: _manual_render_enable(133) > 1
12-09 21:38:14.004+0900 W/W_HOME  (  707): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-09 21:38:14.004+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:38:14.014+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-09 21:38:14.014+0900 W/STARTER (  691): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-09 21:38:14.014+0900 E/STARTER (  691): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 21:38:14.014+0900 W/STARTER (  691): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-09 21:38:14.014+0900 W/STARTER (  691): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-09 21:38:14.024+0900 I/SCONTEXT-LIB(  671): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-09 21:38:14.079+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-09 21:38:14.094+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-09 21:38:14.094+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-09 21:38:14.184+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-09 21:38:14.184+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-09 21:38:14.184+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-09 21:38:14.184+0900 I/HIGEAR  ( 1071): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-09 21:38:14.194+0900 I/SHealth_Common( 1055): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-09 21:38:14.199+0900 I/SHealth_Service( 1055): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-09 21:38:14.199+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-09 21:38:14.214+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-09 21:38:14.214+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-09 21:38:14.214+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-09 21:38:14.214+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-09 21:38:14.214+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: PAUSE State: RUNNING
12-09 21:38:14.214+0900 I/CAPI_APPFW_APPLICATION(  707): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-09 21:38:14.214+0900 W/W_HOME  (  707): main.c: _appcore_pause_cb(690) > appcore pause
12-09 21:38:14.214+0900 W/W_HOME  (  707): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-09 21:38:14.214+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:38:14.214+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:38:14.214+0900 W/W_HOME  (  707): main.c: home_pause(751) > clock/widget paused
12-09 21:38:14.214+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 21:38:14.214+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 21:38:14.219+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 21:38:14.219+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:38:14.219+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-09 21:38:14.219+0900 E/CAPI_APPFW_APP_CONTROL( 1020): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 21:38:14.219+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1020]   value = [false][0m
12-09 21:38:14.264+0900 W/WATCH_CORE(13958): appcore-watch.c: __widget_pause(1001) > widget_pause
12-09 21:38:14.719+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: MEM_FLUSH State: PAUSED
12-09 21:38:19.019+0900 I/RESOURCED(  532): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 87 -> 86 1449664699 331
12-09 21:38:19.019+0900 I/RESOURCED(  532): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 86 1824 237 2614
12-09 21:38:19.019+0900 I/RESOURCED(  532): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 86 0 0 3212
12-09 21:38:19.019+0900 I/RESOURCED(  532): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 86 2058 367 2950
12-09 21:38:19.034+0900 I/RESOURCED(  532): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 86 3573 5 5121
12-09 21:38:19.034+0900 I/RESOURCED(  532): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 86 3573 5 5121
12-09 21:38:19.379+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: MEM_FLUSH State: PAUSED
12-09 21:38:26.859+0900 I/RESOURCED(  532): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-09 21:38:26.859+0900 I/RESOURCED(  532): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-09 21:38:26.859+0900 I/RESOURCED(  532): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] cpu cache is empty
12-09 21:38:36.704+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-09 21:39:03.679+0900 E/PKGMGR_SERVER(14189): pkgmgr-server.c: main(2126) > package manager server start
12-09 21:39:03.784+0900 E/PKGMGR_SERVER(14189): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1611948680], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-09 21:39:03.789+0900 E/PKGMGR_SERVER(14190): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-09 21:39:03.794+0900 E/PKGMGR  (14187): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-09 21:39:03.864+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:39:03.869+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13958
12-09 21:39:03.874+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 21:39:03.879+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 5
12-09 21:39:03.879+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(13958), cmd(4)
12-09 21:39:03.879+0900 W/CAPI_WATCH_APPLICATION(13958): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-09 21:39:03.879+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 22
12-09 21:39:03.879+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(884) > app status : 4
12-09 21:39:03.879+0900 W/WATCH_CORE(13958): appcore-watch.c: __widget_destroy(992) > widget_destory
12-09 21:39:03.879+0900 E/WIDGET_PROVIDER_APP(13958): client.c: client_fini(1175) > Provider is not initialized
12-09 21:39:03.884+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 4
12-09 21:39:03.894+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:39:03.904+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-09 21:39:03.914+0900 E/PKGMGR_SERVER(14190): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-09 21:39:03.929+0900 E/PKGMGR_SERVER(14189): pkgmgr-server.c: sighandler(445) > child NORMAL exit [14190]
12-09 21:39:04.074+0900 E/AUL_AMD (  530): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-09 21:39:04.074+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(13958), cmd(4)
12-09 21:39:04.114+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 0
12-09 21:39:04.219+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 21:39:04.359+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 21:39:04.359+0900 E/AUL_AMD (  530): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-09 21:39:04.364+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(1659) > caller pid : 697
12-09 21:39:04.689+0900 E/RESOURCED(  532): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-09 21:39:04.689+0900 E/RESOURCED(  532): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-09 21:39:04.694+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(2026) > pad pid(-5)
12-09 21:39:04.694+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-09 21:39:04.694+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(265) > Check app launching
12-09 21:39:04.734+0900 I/CAPI_WATCH_APPLICATION(14112): watch_app_main.c: watch_app_main(382) > watch_app_main
12-09 21:39:04.759+0900 E/TBM     (14112): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-09 21:39:04.794+0900 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 13958
12-09 21:39:04.839+0900 W/WATCH_CORE(14112): appcore-watch.c: __widget_create(958) > widget_create
12-09 21:39:04.844+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1712) > [SECURE_LOG] [9879.414062] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_9879.414062.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263110:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-09 21:39:04.844+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[9879.414062] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_9879.414062.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263110:4] gbar_fname[]
12-09 21:39:04.859+0900 E/WIDGET_VIEWER(  707): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-09 21:39:04.859+0900 E/WIDGET_EVAS(  707): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-09 21:39:04.939+0900 F/EFL     (14112): evas_main<14112> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:39:04.939+0900 F/EFL     (14112):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:39:04.939+0900 F/EFL     (14112):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:39:04.939+0900 F/EFL     (14112): evas_main<14112> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:39:04.939+0900 F/EFL     (14112):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:39:04.939+0900 F/EFL     (14112):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:39:04.939+0900 F/EFL     (14112): evas_main<14112> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:39:04.939+0900 F/EFL     (14112):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:39:04.939+0900 F/EFL     (14112):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:39:04.949+0900 W/WATCH_CORE(14112): appcore-watch.c: __widget_create(976) > widget_create done
12-09 21:39:05.024+0900 I/WATCH_CORE(14112): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-09 21:39:05.024+0900 I/WATCH_CORE(14112): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-09 21:39:05.024+0900 I/WATCH_CORE(14112): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-09 21:39:05.799+0900 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 21:39:05.799+0900 W/AUL_AMD (  530): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-09 21:39:05.834+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:39:05.839+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14112
12-09 21:39:05.839+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 21:39:05.879+0900 W/AUL_AMD (  530): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-09 21:39:05.884+0900 E/PKGMGR_SERVER(14189): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-09 21:39:05.884+0900 E/PKGMGR_SERVER(14189): pkgmgr-server.c: main(2180) > package manager server terminated.
12-09 21:39:06.034+0900 I/AUL_PAD (14221): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-09 21:39:11.364+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-09 21:39:11.369+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-09 21:39:11.369+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-09 21:39:11.369+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-09 21:39:19.889+0900 E/PKGMGR  (14322): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-09 21:39:20.064+0900 E/PKGMGR_SERVER(14324): pkgmgr-server.c: main(2126) > package manager server start
12-09 21:39:20.164+0900 E/PKGMGR_SERVER(14324): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_1628365135], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_1628365135' '-r' 'org.reolab.blackandwhite'], cookie=[abnPiKCUBeQYfe1f7GOyqhf6hTM=], backend_flag=[0]
12-09 21:39:20.169+0900 E/PKGMGR  (14324): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-09 21:39:20.169+0900 E/PKGMGR_SERVER(14324): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-09 21:39:20.174+0900 E/PKGMGR  (14322): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[143220002]
12-09 21:39:20.174+0900 E/PKGMGR_SERVER(14325): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-09 21:39:20.374+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-09 21:39:20.379+0900 W/AUL_AMD (  530): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-09 21:39:20.399+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 21:39:20.404+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-09 21:39:20.969+0900 E/PKGMGR_CERT(14325): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-09 21:39:20.979+0900 E/PKGMGR_CERT(14325): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-09 21:39:20.979+0900 E/PKGMGR_CERT(14325): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-09 21:39:20.979+0900 E/PKGMGR_CERT(14325): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-09 21:39:20.984+0900 E/PKGMGR_CERT(14325): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-09 21:39:20.984+0900 E/PKGMGR_CERT(14325): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-09 21:39:20.984+0900 E/PKGMGR_CERT(14325): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-09 21:39:20.989+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 21:39:21.009+0900 E/PKGMGR_CERT(14325): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-09 21:39:22.764+0900 E/rpm-installer(14325): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-09 21:39:22.884+0900 E/PKGMGR_SERVER(14324): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-09 21:39:24.884+0900 E/PKGMGR_SERVER(14324): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-09 21:39:25.679+0900 E/PKGMGR_SERVER(14324): pkgmgr-server.c: sighandler(445) > child NORMAL exit [14325]
12-09 21:39:25.694+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 21:39:25.714+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-09 21:39:25.714+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-09 21:39:25.759+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-09 21:39:25.759+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-09 21:39:25.759+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-09 21:39:25.759+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-09 21:39:25.774+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-09 21:39:25.819+0900 E/PKGMGR_INFO(  527): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-09 21:39:25.864+0900 E/APPS    (  707): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-09 21:39:26.149+0900 W/CRASH_MANAGER(14329): worker.c: worker_job(1199) > 1114112626c61144966476
