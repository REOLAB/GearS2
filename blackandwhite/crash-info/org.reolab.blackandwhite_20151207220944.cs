S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 28099
Date: 2015-12-07 22:09:44+0900
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
r6   = 0xbed737d0, r7   = 0x0000003f
r8   = 0x00000034, r9   = 0x42cd3d10
r10  = 0x40001719, fp   = 0xbed737c4
ip   = 0x00000000, sp   = 0xbed73260
lr   = 0x403055b8, pc   = 0x40338dc4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     21576 KB
Buffers:     17876 KB
Cached:      98328 KB
VmPeak:      65608 KB
VmSize:      65096 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12788 KB
VmRSS:       12788 KB
VmData:      12216 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       19388 KB
VmPTE:          46 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 28099 TID = 28099
28099 28105 

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
43108000 43907000 rw-p [stack:28105]
43907000 4390a000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43912000 4391d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c63000 43c7a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
bed54000 bed75000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28099)
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
ewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [27]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: AddPendingChanges(1053) > added [27] to pending list
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [28]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [28]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: AddPendingChanges(1053) > added [28] to pending list
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [30]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: AddPendingChanges(1053) > added [30] to pending list
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [73]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: AddPendingChanges(1053) > added [73] to pending list
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [3]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: AddPendingChanges(1053) > added [3] to pending list
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [1]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: AddPendingChanges(1053) > added [1] to pending list
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: AddPendingChanges(1053) > added [2] to pending list
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-07 22:09:54.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
12-07 22:09:54.219+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:54.219+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:54.219+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:54.219+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:54.219+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-07 22:09:54.219+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-07 22:09:54.264+0900 W/WATCH_CORE(28098): appcore-watch.c: __widget_create(958) > widget_create
12-07 22:09:54.269+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
12-07 22:09:54.269+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
12-07 22:09:54.284+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [80934.125000] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_80934.125000.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 22:09:54.284+0900 W/W_HOME  (  715): dbox.c: _widget_created_cb(238) > widget resume:0x476fc890
12-07 22:09:54.284+0900 E/WIDGET_VIEWER(  715): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
12-07 22:09:54.349+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 22:09:54.349+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 22:09:54.414+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:54.414+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:54.414+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:54.414+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:54.609+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:54.609+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:54.609+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:54.609+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:54.739+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 22:09:54.739+0900 E/AUL_AMD (  495): amd_request.c: __app_process_by_pid(193) > pid(28098) is dead. cmd(4) is canceled
12-07 22:09:54.744+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:09:54.754+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:54.764+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:54.764+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 22:09:54.764+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 22:09:54.774+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 22:09:54.774+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 22:09:54.774+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 22:09:54.809+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:54.809+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:54.809+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:54.809+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:55.009+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:55.009+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:55.009+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:55.009+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:55.009+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-07 22:09:55.009+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-07 22:09:55.199+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(526) > Candidate is not prepared, enter legacy logic
12-07 22:09:55.199+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 22:09:55.199+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2037) > Launch with legacy way : no launchpad
12-07 22:09:55.204+0900 W/AUL_AMD (  495): amd_launch.c: start_process(573) > child process: 28193
12-07 22:09:55.204+0900 E/RESOURCED( 1078): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
12-07 22:09:55.204+0900 E/AUL     ( 1078): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
12-07 22:09:55.204+0900 E/CAPI_APPFW_APP_MANAGER( 1078): app_manager.c: app_manager_error(76) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
12-07 22:09:55.204+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:55.204+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:55.204+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:55.204+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:55.254+0900 W/AUL_AMD (  495): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 28193
12-07 22:09:55.254+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:09:55.254+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:09:55.254+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 28098
12-07 22:09:55.314+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:09:55.319+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28193
12-07 22:09:55.324+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:09:55.329+0900 I/CAPI_WATCH_APPLICATION(28193): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 22:09:55.404+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:55.404+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:55.404+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:55.404+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:55.504+0900 E/TBM     (28193): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 22:09:55.574+0900 W/WATCH_CORE(28193): appcore-watch.c: __widget_create(958) > widget_create
12-07 22:09:55.574+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [80934.125000] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_80934.125000.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29361014:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 22:09:55.574+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[80934.125000] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_80934.125000.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29361014:4] gbar_fname[]
12-07 22:09:55.589+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 22:09:55.589+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 22:09:55.609+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:55.609+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:55.609+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:55.609+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:55.804+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:55.804+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:55.804+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:55.804+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:56.004+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:56.004+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:56.004+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:56.004+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:56.004+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-07 22:09:56.004+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-07 22:09:56.204+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 22:09:56.204+0900 E/AUL_AMD (  495): amd_request.c: __app_process_by_pid(193) > pid(28193) is dead. cmd(4) is canceled
12-07 22:09:56.204+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:09:56.214+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:56.214+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:56.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:56.214+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:56.214+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:56.229+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:56.229+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 22:09:56.229+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 22:09:56.239+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 22:09:56.239+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 22:09:56.239+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 22:09:56.244+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(526) > Candidate is not prepared, enter legacy logic
12-07 22:09:56.244+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 22:09:56.244+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2037) > Launch with legacy way : no launchpad
12-07 22:09:56.244+0900 W/AUL_AMD (  495): amd_launch.c: start_process(573) > child process: 28203
12-07 22:09:56.294+0900 W/AUL_AMD (  495): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 28203
12-07 22:09:56.294+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 23
12-07 22:09:56.299+0900 E/AUL_AMD (  495): amd_request.c: __release_srv(368) > Not releasable
12-07 22:09:56.299+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 22:09:56.299+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 28193
12-07 22:09:56.299+0900 W/AUL_AMD (  495): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-07 22:09:56.299+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:09:56.299+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:09:56.304+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 28193
12-07 22:09:56.304+0900 E/AUL     (28202): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
12-07 22:09:56.349+0900 I/CAPI_WATCH_APPLICATION(28203): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 22:09:56.359+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:09:56.369+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 28203
12-07 22:09:56.379+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:09:56.419+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:56.419+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:56.419+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:56.419+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:56.459+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-07 22:09:56.474+0900 W/W_HOME  (  715): clock_view.c: clock_view_attach(512) > changed pause/resume option -> manual
12-07 22:09:56.474+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88128), origin_x(0), origin_y(0)
12-07 22:09:56.474+0900 W/W_HOME  (  715): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-07 22:09:56.474+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:56.494+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88128), origin_x(0), origin_y(0)
12-07 22:09:56.494+0900 W/W_HOME  (  715): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-07 22:09:56.494+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:56.499+0900 W/W_HOME  (  715): clock_view.c: clock_view_attach(529) > changed pause/resume option -> automatic
12-07 22:09:56.499+0900 W/W_HOME  (  715): clock_manager.c: clock_manager_clock_set(255) > attached clock isn't cleaned-up, yet
12-07 22:09:56.499+0900 E/W_HOME  (  715): page.c: _page_clip_del(240) > (!page_info) -> _page_clip_del() return
12-07 22:09:56.499+0900 E/W_HOME  (  715): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
12-07 22:09:56.499+0900 W/W_HOME  (  715): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
12-07 22:09:56.499+0900 E/W_HOME  (  715): dbox.c: del_cb(225) > Add viewer has no info: com.samsung.watchface
12-07 22:09:56.514+0900 W/W_HOME  (  715): cfwd.c: cfwd_get_icon_status(362) > 
12-07 22:09:56.514+0900 W/W_HOME  (  715): ============================
12-07 22:09:56.514+0900 W/W_HOME  (  715): multi_sim_category:0
12-07 22:09:56.514+0900 W/W_HOME  (  715): multi_sim_model:0
12-07 22:09:56.514+0900 W/W_HOME  (  715): support_callforward_auto:0
12-07 22:09:56.514+0900 W/W_HOME  (  715): conn_status:1
12-07 22:09:56.514+0900 W/W_HOME  (  715): remote_call_forward_auto:0
12-07 22:09:56.514+0900 W/W_HOME  (  715): auto_call_forward_status:0
12-07 22:09:56.514+0900 W/W_HOME  (  715): support_callforward_reverse:0
12-07 22:09:56.514+0900 W/W_HOME  (  715): reverse_call_forward_auto:0
12-07 22:09:56.514+0900 W/W_HOME  (  715): fwd_type:
12-07 22:09:56.514+0900 W/W_HOME  (  715): ============================
12-07 22:09:56.514+0900 W/W_HOME  (  715): 
12-07 22:09:56.514+0900 W/W_HOME  (  715): clock_view_indicator.c: _view_call_fw_icon(131) > call fwd status:0
12-07 22:09:56.514+0900 E/W_HOME  (  715): clock_event.c: _flightmode_state_get(417) > Failed to get VCONFKEY_TELEPHONY_FLIGHT_MODE:db/telephony/flight_mode
12-07 22:09:56.514+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 22:09:56.514+0900 W/W_HOME  (  715): noti_broker.c: _clock_attached_cb(804) > 1
12-07 22:09:56.519+0900 W/W_HOME  (  715): cs_broker.c: _clock_view_attached_cb(231) > 
12-07 22:09:56.524+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:40043c11
12-07 22:09:56.524+0900 W/W_HOME  (  715): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,hide
12-07 22:09:56.524+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:56.524+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:09:56.539+0900 I/CLOCK-LIST(  715): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(264) > send watch_list_event, watch_list_out
12-07 22:09:56.539+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:09:56.539+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:09:56.539+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:09:56.539+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:09:56.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:09:56.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:09:56.539+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [org.reolab.blackandwhite:watchface::messageport::event]
12-07 22:09:56.539+0900 E/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(354) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-07 22:09:56.539+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:09:56.539+0900 E/MESSAGE_PORT(  715): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
12-07 22:09:56.539+0900 E/CLOCK-LIST(  715): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(268) > message_port_send_message returns -18022399(feed0001)
12-07 22:09:56.559+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8a6a8, elm_box, _activated_obj : 0x45c8a6a8, activated : 1
12-07 22:09:56.559+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:09:56.559+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5125) > Return true for 215, 218.
12-07 22:09:56.559+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
12-07 22:09:56.559+0900 I/efl-extension(  715): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x4ac3b6e0, obj: 0x4ac3b6e0
12-07 22:09:56.559+0900 I/efl-extension(  715): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-07 22:09:56.559+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 22:09:56.559+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4ac3b6e0, elm_scroller, func : 0x4072fe19
12-07 22:09:56.559+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 22:09:56.559+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 22:09:56.559+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x49cabb80, elm_image, func : 0x4072fe19
12-07 22:09:56.559+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 22:09:56.559+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(841) > [0x4ac3b6e0 : elm_scroller] rotary callabck is deleted
12-07 22:09:56.579+0900 E/TBM     (28203): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 22:09:56.614+0900 I/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:09:56.614+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:09:56.614+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:09:56.614+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:09:56.634+0900 W/WATCH_CORE(28203): appcore-watch.c: __widget_create(958) > widget_create
12-07 22:09:56.674+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-07 22:09:56.684+0900 W/WATCH_CORE(28118): appcore-watch.c: __widget_pause(1001) > widget_pause
12-07 22:09:56.684+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppPause(717) > 
12-07 22:09:56.684+0900 E/watchface-viewer(28118): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:09:56.684+0900 E/watchface-viewer(28118): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:09:56.684+0900 E/watchface-viewer(28118): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:09:56.684+0900 E/watchface-viewer(28118): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:09:56.684+0900 I/watchface-viewer(28118): viewer-part-resource-evas.cpp: StopColonAnimation(1544) > 
12-07 22:09:56.684+0900 E/watchface-viewer(28118): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:09:56.684+0900 E/watchface-viewer(28118): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:09:56.774+0900 E/W_HOME  (  715): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
12-07 22:09:56.789+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [80934.125000] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_80934.125000.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29361018:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 22:09:56.789+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[80934.125000] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_80934.125000.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29361018:4] gbar_fname[]
12-07 22:09:56.789+0900 W/WATCH_CORE(28118): appcore-watch.c: __widget_destroy(992) > widget_destory
12-07 22:09:56.789+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 22:09:56.789+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(884) > app status : 4
12-07 22:09:56.789+0900 W/CAPI_WATCH_APPLICATION(28118): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-07 22:09:56.789+0900 E/watchface-loader(28118): watchface-loader.cpp: OnAppTerminated(579) > 
12-07 22:09:56.794+0900 I/watchface-viewer(28118): viewer-view.cpp: CleanTrash(800) > Flush 6 groups
12-07 22:09:56.794+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x477a06b8] for [73]
12-07 22:09:56.794+0900 I/watchface-viewer(28118): viewer-part-resource-evas.cpp: DestroyEvasBuffer(94) > removed mEvas!!
12-07 22:09:56.794+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x4783d9e8] for [28]
12-07 22:09:56.794+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x4783dae0] for [13]
12-07 22:09:56.794+0900 I/watchface-viewer(28118): viewer-util.cpp: Destroy(884) > reference decreased locale[ko_KR] impl[0x48aba368] refcount[2]
12-07 22:09:56.794+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47848ff8] for [17]
12-07 22:09:56.794+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47849058] for [23]
12-07 22:09:56.794+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47849048] for [30]
12-07 22:09:56.799+0900 I/watchface-viewer(28118): viewer-part-resource-evas.cpp: DestroyEvasBuffer(94) > removed mEvas!!
12-07 22:09:56.799+0900 I/watchface-viewer(28118): viewer-util.cpp: Destroy(884) > reference decreased locale[ko_KR] impl[0x48aba368] refcount[1]
12-07 22:09:56.799+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48a120b0] for [17]
12-07 22:09:56.799+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48a12100] for [23]
12-07 22:09:56.799+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x47848fe8] for [30]
12-07 22:09:56.799+0900 E/W_HOME  (  715): move.c: move_back_to_home_no_anim(270) > home is already on position
12-07 22:09:56.799+0900 I/watchface-viewer(28118): viewer-part-resource-evas.cpp: DestroyEvasBuffer(94) > removed mEvas!!
12-07 22:09:56.799+0900 W/W_HOME  (  715): scroller.c: _get_index_in_list(1902) > page:0x4a63dfb8 idx:2 total11 exist:1
12-07 22:09:56.799+0900 I/watchface-viewer(28118): viewer-util.cpp: Destroy(884) > reference decreased locale[ko_KR] impl[0x48aba368] refcount[0]
12-07 22:09:56.799+0900 I/watchface-viewer(28118): viewer-util.cpp: Destroy(888) > removed I18NStringUtilityImpl[0x48aba368]
12-07 22:09:56.799+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:4005277b
12-07 22:09:56.799+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48a210b8] for [17]
12-07 22:09:56.799+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48a210a8] for [23]
12-07 22:09:56.799+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88128), origin_x(0), origin_y(0)
12-07 22:09:56.799+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48a120a0] for [30]
12-07 22:09:56.799+0900 W/W_HOME  (  715): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
12-07 22:09:56.799+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02400003)
12-07 22:09:56.804+0900 I/efl-extension(13736): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 22:09:56.804+0900 W/wnotibp (13736): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1721) > [0, 2, 1]
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-part-resource-evas.cpp: DestroyEvasBuffer(94) > removed mEvas!!
12-07 22:09:56.804+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 22:09:56.804+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-part-resource-evas.cpp: StopColonAnimation(1544) > 
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48a22728] for [27]
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48a22640] for [13]
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48a225d0] for [6]
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48a22688] for [4]
12-07 22:09:56.804+0900 E/WIDGET_VIEWER(  715): client.c: master_widget_updated(787) > [SECURE_LOG] (file:///opt/usr/share/live_magazine/com.samsung.watchface_715_80925.054688.png) is not exists, but updated
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-part-resource-evas.cpp: DestroyEvasBuffer(94) > removed mEvas!!
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-data-broker.cpp: DelListener(1305) > removed listener[0x4779dda0] for [27]
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-data-broker.cpp: DelListener(1305) > removed listener[0x4779dca8] for [13]
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-data-broker.cpp: DelListener(1305) > removed listener[0x48a295a8] for [6]
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-part-resource-evas.cpp: DestroyEvasBuffer(94) > removed mEvas!!
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-bitmap-font-manager.cpp: ~BitmapFontManager(124) > 
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-group-manager.cpp: Clear(32) > 
12-07 22:09:56.804+0900 I/watchface-viewer(28118): viewer-shader-manager.cpp: ~ShaderEffect(396) > 
12-07 22:09:56.809+0900 I/MALI    (28118): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
12-07 22:09:56.809+0900 I/MALI    (28118): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=28118   close drm_fd=39 
12-07 22:09:56.809+0900 I/MALI    (28118): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
12-07 22:09:56.809+0900 E/UXT     (28118): uxt_theme.c: uxt_theme_delete_changed_callback(492) > failed to get the callback from list
12-07 22:09:56.809+0900 I/DALI    (28118): slp-logging.cpp: LogMessage(36) > >~Adaptor()
12-07 22:09:56.809+0900 I/DALI    (28118): slp-logging.cpp: LogMessage(36) > >~Core()
12-07 22:09:56.814+0900 I/DALI    (28118): slp-logging.cpp: LogMessage(36) > <~ResourceClient()
12-07 22:09:56.814+0900 I/DALI    (28118): slp-logging.cpp: LogMessage(36) > <~ResourceManager()
12-07 22:09:56.814+0900 I/DALI    (28118): slp-logging.cpp: LogMessage(36) > <~Core()
12-07 22:09:56.814+0900 I/DALI    (28118): slp-logging.cpp: LogMessage(36) > <~SlpPlatformAbstraction()
12-07 22:09:56.814+0900 I/DALI    (28118): slp-logging.cpp: LogMessage(36) > <~Adaptor()
12-07 22:09:56.824+0900 I/watchface-common-util(28118): common-util-ipc-control.cpp: ~CommonUtilIPCControl(197) > 
12-07 22:09:56.824+0900 I/MESSAGE_PORT(28118): MessagePortProxy.cpp: IsLocalPortRegisted(675) > MessagePort name is already registered.
12-07 22:09:56.824+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:09:56.824+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:09:56.824+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:09:56.824+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
12-07 22:09:56.824+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
12-07 22:09:56.824+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:09:56.824+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.watchface:watchface::messageport::event], client = 28118
12-07 22:09:56.824+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:09:56.824+0900 E/TIZEN_N_SYSTEM_SETTINGS(28118): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
12-07 22:09:56.824+0900 E/TIZEN_N_SYSTEM_SETTINGS(28118): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
12-07 22:09:56.824+0900 E/TIZEN_N_SYSTEM_SETTINGS(28118): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
12-07 22:09:56.824+0900 E/TIZEN_N_SYSTEM_SETTINGS(28118): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
12-07 22:09:56.824+0900 E/TIZEN_N_SYSTEM_SETTINGS(28118): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=16
12-07 22:09:56.824+0900 E/TIZEN_N_SYSTEM_SETTINGS(28118): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 16, key = 16, type = 1
12-07 22:09:56.824+0900 E/WIDGET_PROVIDER_APP(28118): client.c: client_fini(1175) > Provider is not initialized
12-07 22:09:56.849+0900 I/UXT     (28118): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
12-07 22:09:56.979+0900 I/efl-extension(28118): efl_extension.c: eext_mod_shutdown(46) > Shutdown
12-07 22:09:57.129+0900 I/AUL_PAD (28192): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:09:57.139+0900 E/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
12-07 22:09:57.139+0900 E/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(28118) are closed. delete client info
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
12-07 22:09:57.139+0900 E/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  28118
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: UnregisterMessagePortByDiscon(280) > _MessagePortService::UnregisterMessagePortByDiscon
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.139+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:09:57.169+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 23
12-07 22:09:57.169+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-07 22:09:57.169+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 28118
12-07 22:09:57.169+0900 W/AUL_AMD (  495): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-07 22:09:57.209+0900 E/HealthDataService( 1093): server_dbus_connection.c: __on_client_vanished(187) > [0;40;31mclient vanished :1.1670
12-07 22:09:57.209+0900 E/HealthDataService( 1093): [0;m
12-07 22:09:57.209+0900 I/HealthDataService( 1093): health_ipc_server.c: __health_server_ipc_remove_client(349) > [1;35mApplication info [com.samsung.watchface] is removed from the map [425A34B8][0;m
12-07 22:09:57.214+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 28118
12-07 22:09:57.299+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:09:57.299+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:09:57.324+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 22:09:57.324+0900 E/AUL_AMD (  495): amd_request.c: __app_process_by_pid(193) > pid(28203) is dead. cmd(4) is canceled
12-07 22:09:57.324+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:09:57.334+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:57.344+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:57.344+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 22:09:57.344+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 22:09:57.354+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 22:09:57.354+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 22:09:57.354+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-07 22:09:57.354+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 22:09:57.354+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 22:09:57.394+0900 I/CAPI_WATCH_APPLICATION(28192): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 22:09:57.419+0900 E/TBM     (28192): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 22:09:57.459+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 23
12-07 22:09:57.459+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-07 22:09:57.459+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 28203
12-07 22:09:57.459+0900 W/AUL_AMD (  495): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-07 22:09:57.459+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 28203
12-07 22:09:57.519+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [80934.125000] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_80934.125000.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29361022:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 22:09:57.519+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[80934.125000] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_80934.125000.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29361022:4] gbar_fname[]
12-07 22:09:57.519+0900 W/WATCH_CORE(28192): appcore-watch.c: __widget_create(958) > widget_create
12-07 22:09:57.539+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 22:09:57.539+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 22:09:57.899+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 22:09:57.899+0900 E/AUL_AMD (  495): amd_request.c: __app_process_by_pid(193) > pid(28192) is dead. cmd(4) is canceled
12-07 22:09:57.904+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:09:57.914+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:57.924+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:09:57.924+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 22:09:57.924+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 22:09:57.934+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 22:09:57.934+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 22:09:57.934+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 22:09:58.119+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1128099626c61144949378
