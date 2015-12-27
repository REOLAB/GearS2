S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 28193
Date: 2015-12-07 22:09:55+0900
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
r6   = 0xbee1a7d0, r7   = 0x0000003f
r8   = 0x00000034, r9   = 0x42cd3d10
r10  = 0x40001719, fp   = 0xbee1a7c4
ip   = 0x00000000, sp   = 0xbee1a260
lr   = 0x403055b8, pc   = 0x40338dc4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     11712 KB
Buffers:     17144 KB
Cached:      95504 KB
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
PID = 28193 TID = 28193
28193 28196 

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
43108000 43907000 rw-p [stack:28196]
43907000 4390a000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43912000 4391d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c63000 43c7a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
bedfb000 bee1c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:28193)
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
+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [77] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [78]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [78]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [78] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [84]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [84]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [84] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [85]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [85]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [85] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [86]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [86]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [86] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [79]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [79]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [79] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [80]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [80]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [80] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [81]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [81]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [81] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [82]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [82]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [82] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [83]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [83]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [83] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [87]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [87]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [87] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [88]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [88]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [88] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [89]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [89]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [89] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [90]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [90]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [90] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [91]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [91]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [91] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [92]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [92]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [92] to pending list
12-07 22:10:00.959+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppResume(732) > mFirstResumeDone
12-07 22:10:00.959+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:00.959+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [1] to pending list
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:10:00.959+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [2] to pending list
12-07 22:10:00.969+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-07 22:10:00.989+0900 W/W_HOME  (  715): clock_view.c: clock_view_attach(512) > changed pause/resume option -> manual
12-07 22:10:00.989+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88128), origin_x(0), origin_y(0)
12-07 22:10:00.989+0900 W/W_HOME  (  715): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-07 22:10:00.989+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:10:00.994+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88128), origin_x(0), origin_y(0)
12-07 22:10:00.999+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:00.999+0900 E/watchface-loader(28265): watchface-loader.cpp: OnLoadingDone(812) > 
12-07 22:10:00.999+0900 W/W_HOME  (  715): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-07 22:10:00.999+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:10:01.004+0900 W/W_HOME  (  715): clock_view.c: clock_view_attach(529) > changed pause/resume option -> automatic
12-07 22:10:01.004+0900 W/W_HOME  (  715): clock_manager.c: clock_manager_clock_set(255) > attached clock isn't cleaned-up, yet
12-07 22:10:01.004+0900 E/W_HOME  (  715): page.c: _page_clip_del(240) > (!page_info) -> _page_clip_del() return
12-07 22:10:01.004+0900 E/W_HOME  (  715): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
12-07 22:10:01.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnLoadingDone(815) > idle_watch = [com.samsung.watchface]
12-07 22:10:01.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnLoadingDone(823) > idle_watch = [com.samsung.watchface]
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.watch-face-editor:watch-face-editor::localport]
12-07 22:10:01.009+0900 E/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.009+0900 E/MESSAGE_PORT(28265): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (watch-face-editor::localport) is not found.
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.009+0900 W/W_HOME  (  715): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.009+0900 E/W_HOME  (  715): dbox.c: del_cb(225) > Add viewer has no info: org.reolab.blackandwhite
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.clocksetting.clock:clocksetting::localport]
12-07 22:10:01.009+0900 E/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.009+0900 E/MESSAGE_PORT(28265): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (clocksetting::localport) is not found.
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:w-home::localport]
12-07 22:10:01.009+0900 E/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(242) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-07 22:10:01.009+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.009+0900 E/MESSAGE_PORT(28265): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (w-home::localport) is not found.
12-07 22:10:01.009+0900 E/watchface-loader(28265): watchface-loader.cpp: OnLoadingDone(860) > mFirstLoadingDone
12-07 22:10:01.014+0900 W/W_HOME  (  715): clock_service.c: clock_service_event_handler(821) > scroller freeze off
12-07 22:10:01.014+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:4001f5a7
12-07 22:10:01.014+0900 W/W_HOME  (  715): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: com.samsung.watchface 1 0 0 0
12-07 22:10:01.014+0900 E/W_HOME  (  715): clock_service.c: _clock_service_heartbeat_pump(563) > com.samsung.watchface is already attached to home
12-07 22:10:01.014+0900 W/W_HOME  (  715): cfwd.c: cfwd_get_icon_status(362) > 
12-07 22:10:01.014+0900 W/W_HOME  (  715): ============================
12-07 22:10:01.014+0900 W/W_HOME  (  715): multi_sim_category:0
12-07 22:10:01.014+0900 W/W_HOME  (  715): multi_sim_model:0
12-07 22:10:01.014+0900 W/W_HOME  (  715): support_callforward_auto:0
12-07 22:10:01.014+0900 W/W_HOME  (  715): conn_status:1
12-07 22:10:01.014+0900 W/W_HOME  (  715): remote_call_forward_auto:0
12-07 22:10:01.014+0900 W/W_HOME  (  715): auto_call_forward_status:0
12-07 22:10:01.014+0900 W/W_HOME  (  715): support_callforward_reverse:0
12-07 22:10:01.014+0900 W/W_HOME  (  715): reverse_call_forward_auto:0
12-07 22:10:01.014+0900 W/W_HOME  (  715): fwd_type:
12-07 22:10:01.014+0900 W/W_HOME  (  715): ============================
12-07 22:10:01.014+0900 W/W_HOME  (  715): 
12-07 22:10:01.014+0900 W/W_HOME  (  715): clock_view_indicator.c: _view_call_fw_icon(131) > call fwd status:0
12-07 22:10:01.014+0900 E/W_HOME  (  715): clock_event.c: _flightmode_state_get(417) > Failed to get VCONFKEY_TELEPHONY_FLIGHT_MODE:db/telephony/flight_mode
12-07 22:10:01.014+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 22:10:01.014+0900 W/W_HOME  (  715): noti_broker.c: _clock_attached_cb(804) > 1
12-07 22:10:01.014+0900 W/W_HOME  (  715): cs_broker.c: _clock_view_attached_cb(231) > 
12-07 22:10:01.014+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-07 22:10:01.014+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-07 22:10:01.039+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 6
12-07 22:10:01.039+0900 W/AUL_AMD (  495): amd_request.c: __foward_cmd(153) > __forward_cmd: 1093 1093
12-07 22:10:01.044+0900 I/CAPI_APPFW_APP_CONTROL(28265): app_control.c: app_control_request_result_broker(189) > app_control_request_result_broker, result: 0
12-07 22:10:01.044+0900 I/healthData(28265): health_fw_connection.c: __health_service_appcontrol_cb(151) > [1;35mAppcontrol launch result 0[0;m
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.watchface:com.samsung.watchface], client = 28265
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [health-data-service:HEALTH_SERVICE_PORT]
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [health-data-service:HEALTH_SERVICE_PORT]
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:10:01.044+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.054+0900 I/HealthDataService( 1093): health_ipc_server.c: __health_server_ipc_add_client(340) > [1;35mApplication Information is registered in the map:[425A34B8] [com.samsung.watchface][0;m
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.watchface:com.samsung.watchface]
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.watchface:com.samsung.watchface]
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:10:01.054+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:10:01.074+0900 I/healthData(28265): health_fw_connection.c: __health_service_connection_cb(192) > [1;35mService Connection status Changed : from [6] to [0][0;m
12-07 22:10:01.099+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.109+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.119+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.124+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.134+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.139+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.149+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.159+0900 E/W_HOME  (  715): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
12-07 22:10:01.159+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_ADD_OBSERVER[0;m
12-07 22:10:01.164+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.179+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.184+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.199+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.204+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [74]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [75]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [76]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [78]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [84]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [85]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [86]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [74]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [75]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [76]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [78]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [84]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [85]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [86]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [73]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [74]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [75]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [76]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [77]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [78]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [84]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [85]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [86]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [79]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [80]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [81]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [79]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [82]
12-07 22:10:01.209+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [83]
12-07 22:10:01.214+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.219+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [87]
12-07 22:10:01.219+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [88]
12-07 22:10:01.224+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.229+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [89]
12-07 22:10:01.229+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [90]
12-07 22:10:01.234+0900 I/HealthDataService( 1093): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [91]
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [92]
12-07 22:10:01.239+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:01.239+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [4] to pending list
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-07 22:10:01.239+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: AddPendingChanges(1053) > added [5] to pending list
12-07 22:10:01.339+0900 E/watchface-loader(28265): watchface-loader.cpp: OnDummyModeOffTimerExpired(396) > disable dummy mode
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-impl.cpp: SetDummyMode(95) > dummyMode[0]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [28]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [13]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [73]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [30]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [3]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [27]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [6]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [74]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [75]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [76]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [77]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [78]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [84]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [85]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [86]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [79]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [80]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [81]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [82]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [83]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [87]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [88]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [89]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [90]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [91]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [92]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [1]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [2]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [4]
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: Notify(984) > skip first tick after resume!!
12-07 22:10:01.339+0900 I/watchface-viewer(28265): viewer-data-provider.cpp: FlushPendingChanges(1064) > notify pending [5]
12-07 22:10:01.339+0900 E/EFL     (28265): elementary<28265> elm_layout.c:2207 elm_layout_add() could not add 0x4766a910 as sub object of 0x47668e10
12-07 22:10:01.349+0900 E/EFL     (28265): edje<28265> edje_util.c:3770 edje_object_size_min_restricted_calc() group digital-clock/24 has a non-fixed part 'hour'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: UpdateLayout(1257) > colon 20x118 at (132,0)
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 ']
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 100x46
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(463) > inline-image index[0]
12-07 22:10:01.354+0900 E/BASE_UTILS(28265): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=1 ']
12-07 22:10:01.354+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 152x32
12-07 22:10:01.359+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(754) > cursor 32x2 at (0,29)
12-07 22:10:01.359+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(768) > image 32x37 at (0,-2)
12-07 22:10:01.359+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(463) > inline-image index[0]
12-07 22:10:01.359+0900 E/BASE_UTILS(28265): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=1 ']
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 152x32
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(754) > cursor 32x2 at (0,29)
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(768) > image 32x37 at (0,-2)
12-07 22:10:01.369+0900 E/BASE_UTILS(28265): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(601) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=1 ']
12-07 22:10:01.369+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: CreateTextImage(615) > formatted size 120x32
12-07 22:10:01.374+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:01.429+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:01.429+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:01.624+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:01.624+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:01.824+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:01.824+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:01.889+0900 I/watchface-viewer(28265): viewer-view.cpp: DummyModeAnimationFinished(360) > 
12-07 22:10:02.019+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:02.019+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:02.019+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: StartColonAnimation(1501) > 
12-07 22:10:02.019+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:02.214+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:02.214+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:02.414+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:02.414+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:02.474+0900 I/watchface-viewer(28265): viewer-part-resource-evas.cpp: ColonAnimationTimerExpired(1569) > 
12-07 22:10:02.609+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:02.609+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:02.809+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:02.809+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.009+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:03.009+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.009+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:03.209+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:03.209+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.409+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:03.409+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:03.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:03.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:03.929+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1128098626c611449493794
12-07 22:10:04.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:04.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:04.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:04.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:04.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:04.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:04.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:04.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:04.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:04.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:04.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:05.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:05.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:05.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:05.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:05.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:05.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:05.949+0900 I/RESOURCED(  498): vmpressure-lowmem-handler.c: change_lowmem_state(1093) > [change_lowmem_state,1093] [LOW MEM STATE] mem swap ==> mem normal
12-07 22:10:05.949+0900 I/RESOURCED(  498): vmpressure-lowmem-handler.c: adjust_dynamic_threshold(321) > [adjust_dynamic_threshold,321] dynamic_threshold is changed from 60 to 60, cur_mem_state = mem normal, victim_memcg = 5
12-07 22:10:06.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:06.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:06.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:06.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:06.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:06.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:06.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:06.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:06.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:06.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:06.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:07.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:07.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:07.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:07.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:07.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:07.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:07.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:07.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:07.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:07.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:07.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:08.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:08.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:08.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:08.204+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:08.204+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:08.404+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:08.404+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:08.604+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:08.604+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:08.804+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:08.804+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:09.004+0900 I/CAPI_WATCH_APPLICATION(28265): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:10:09.004+0900 E/watchface-loader(28265): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:10:09.004+0900 I/watchface-viewer(28265): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(454) > ImagesLoadingDoneSignal().Emit();
12-07 22:10:09.164+0900 W/CRASH_MANAGER(27967): worker.c: worker_job(1199) > 1128193626c61144949379
