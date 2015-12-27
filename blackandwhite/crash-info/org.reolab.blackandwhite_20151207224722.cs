S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 1411
Date: 2015-12-07 22:47:22+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x45c

Register Information
r0   = 0x00000450, r1   = 0x0000000d
r2   = 0x000002d0, r3   = 0x41553194
r4   = 0x00000450, r5   = 0x00000000
r6   = 0x414e103c, r7   = 0x414dd608
r8   = 0x00000070, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbe951c6c, sp   = 0xbe951c20
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     14872 KB
Buffers:     24116 KB
Cached:     189564 KB
VmPeak:      76304 KB
VmSize:      75792 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14728 KB
VmRSS:       14728 KB
VmData:      21480 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20488 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 1411 TID = 1411
1411 1506 1516 

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
41023000 4102a000 rw-p [heap]
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
41994000 41999000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
419a1000 419ae000 r-xp /usr/lib/libalarm.so.0.0.0
419b7000 41af4000 r-xp /usr/lib/libicui18n.so.51.1
41b04000 41be8000 r-xp /usr/lib/libicuuc.so.51.1
41bfd000 41c03000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41c0b000 41c11000 r-xp /usr/lib/libwidget.so.1.0.0
41c1a000 41c1f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
431ae000 431b7000 r-xp /usr/lib/libcom-core.so.0.0.1
431c0000 431cc000 r-xp /usr/lib/libwidget_service.so.1.0.0
431d4000 431dd000 r-xp /usr/lib/libwidget_provider.so.1.0.0
431e6000 431ee000 r-xp /usr/lib/libdrm.so.2.4.0
431f6000 431fd000 r-xp /usr/lib/libtbm.so.1.0.0
43537000 43d36000 rw-p [stack:1506]
43d36000 43d39000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d41000 43d4c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dd4000 43deb000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4402b000 44900000 rw-p [stack:1516]
be932000 be953000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1411)
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
PortService.cpp: SendMessage(299) > Sends a message to a remote message port [org.reolab.blackandwhite:watchface::messageport::event]
12-07 22:46:37.050+0900 E/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(354) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-07 22:46:37.050+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:46:37.050+0900 E/MESSAGE_PORT(  707): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
12-07 22:46:37.050+0900 E/CLOCK-LIST(  707): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(268) > message_port_send_message returns -18022399(feed0001)
12-07 22:46:37.055+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8a5d8, elm_box, _activated_obj : 0x45c8a5d8, activated : 1
12-07 22:46:37.055+0900 E/wnotib  (  707): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 22:46:37.055+0900 I/wnotib  (  707): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5125) > Return true for 217, 10653.
12-07 22:46:37.055+0900 I/wnotib  (  707): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
12-07 22:46:37.055+0900 I/efl-extension(  707): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x492aba98, obj: 0x492aba98
12-07 22:46:37.055+0900 I/efl-extension(  707): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-07 22:46:37.055+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 22:46:37.055+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x492aba98, elm_scroller, func : 0x4072fe19
12-07 22:46:37.055+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 22:46:37.055+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 22:46:37.055+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x492b7808, elm_image, func : 0x4072fe19
12-07 22:46:37.055+0900 I/efl-extension(  707): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 22:46:37.055+0900 I/efl-extension(  707): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(841) > [0x492aba98 : elm_scroller] rotary callabck is deleted
12-07 22:46:37.060+0900 I/CAPI_WATCH_APPLICATION(  746): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:37.060+0900 E/watchface-loader(  746): watchface-loader.cpp: OnAppTimeTick(744) > 
12-07 22:46:37.060+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [1]
12-07 22:46:37.060+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [2]
12-07 22:46:37.060+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [4]
12-07 22:46:37.060+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: NotifyListeners(617) > dummy mode!! ignored!! [5]
12-07 22:46:37.120+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-07 22:46:37.135+0900 W/WATCH_CORE(  746): appcore-watch.c: __widget_pause(1001) > widget_pause
12-07 22:46:37.135+0900 E/watchface-loader(  746): watchface-loader.cpp: OnAppPause(717) > 
12-07 22:46:37.135+0900 E/watchface-viewer(  746): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:46:37.135+0900 E/watchface-viewer(  746): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:46:37.135+0900 E/watchface-viewer(  746): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:46:37.135+0900 E/watchface-viewer(  746): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:46:37.135+0900 E/watchface-viewer(  746): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:46:37.135+0900 E/watchface-viewer(  746): viewer-group.cpp: RenewClickDownState(473) > Clear all ClickDownState as initial value
12-07 22:46:37.200+0900 E/W_HOME  (  707): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
12-07 22:46:37.215+0900 W/WATCH_CORE(  746): appcore-watch.c: __widget_destroy(992) > widget_destory
12-07 22:46:37.215+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 22:46:37.215+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(884) > app status : 4
12-07 22:46:37.215+0900 W/CAPI_WATCH_APPLICATION(  746): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-07 22:46:37.215+0900 E/watchface-loader(  746): watchface-loader.cpp: OnAppTerminated(579) > 
12-07 22:46:37.215+0900 I/watchface-viewer(  746): viewer-view.cpp: CleanTrash(800) > Flush 6 groups
12-07 22:46:37.215+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x45e7f4a8] for [32]
12-07 22:46:37.215+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x45e7fcf0] for [32]
12-07 22:46:37.220+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x45e85e78] for [34]
12-07 22:46:37.220+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x45e71aa0] for [73]
12-07 22:46:37.220+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x4808a320] for [73]
12-07 22:46:37.220+0900 I/watchface-viewer(  746): viewer-part-resource-evas.cpp: DestroyEvasBuffer(94) > removed mEvas!!
12-07 22:46:37.225+0900 I/watchface-viewer(  746): viewer-util.cpp: Destroy(884) > reference decreased locale[ko_KR] impl[0x48094ae8] refcount[0]
12-07 22:46:37.225+0900 I/watchface-viewer(  746): viewer-util.cpp: Destroy(888) > removed I18NStringUtilityImpl[0x48094ae8]
12-07 22:46:37.225+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48092ec0] for [17]
12-07 22:46:37.225+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48092f18] for [30]
12-07 22:46:37.225+0900 I/watchface-viewer(  746): viewer-part-resource-evas.cpp: DestroyEvasBuffer(94) > removed mEvas!!
12-07 22:46:37.230+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x4809340c] for [7]
12-07 22:46:37.230+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x48094b9c] for [7]
12-07 22:46:37.230+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x45e8f8a4] for [5]
12-07 22:46:37.230+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x45e90c74] for [5]
12-07 22:46:37.230+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x45e84c1c] for [2]
12-07 22:46:37.230+0900 I/watchface-viewer(  746): viewer-data-provider.cpp: DelListener(592) > removed listener[0x45e809c4] for [2]
12-07 22:46:37.230+0900 I/watchface-viewer(  746): viewer-data-broker.cpp: DelListener(1305) > removed listener[0x45e81f44] for [7]
12-07 22:46:37.230+0900 I/watchface-viewer(  746): viewer-data-broker.cpp: DelListener(1305) > removed listener[0x45e756e4] for [6]
12-07 22:46:37.230+0900 I/watchface-viewer(  746): viewer-bitmap-font-manager.cpp: ~BitmapFontManager(124) > 
12-07 22:46:37.230+0900 I/watchface-viewer(  746): viewer-group-manager.cpp: Clear(32) > 
12-07 22:46:37.230+0900 I/watchface-viewer(  746): viewer-shader-manager.cpp: ~ShaderEffect(396) > 
12-07 22:46:37.240+0900 I/MALI    (  746): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
12-07 22:46:37.240+0900 I/MALI    (  746): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=746   close drm_fd=41 
12-07 22:46:37.240+0900 I/MALI    (  746): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
12-07 22:46:37.240+0900 E/UXT     (  746): uxt_theme.c: uxt_theme_delete_changed_callback(492) > failed to get the callback from list
12-07 22:46:37.240+0900 I/DALI    (  746): slp-logging.cpp: LogMessage(36) > >~Adaptor()
12-07 22:46:37.240+0900 I/DALI    (  746): slp-logging.cpp: LogMessage(36) > >~Core()
12-07 22:46:37.245+0900 I/DALI    (  746): slp-logging.cpp: LogMessage(36) > <~ResourceClient()
12-07 22:46:37.245+0900 I/DALI    (  746): slp-logging.cpp: LogMessage(36) > <~ResourceManager()
12-07 22:46:37.250+0900 I/DALI    (  746): slp-logging.cpp: LogMessage(36) > <~Core()
12-07 22:46:37.250+0900 I/DALI    (  746): slp-logging.cpp: LogMessage(36) > <~SlpPlatformAbstraction()
12-07 22:46:37.250+0900 I/DALI    (  746): slp-logging.cpp: LogMessage(36) > <~Adaptor()
12-07 22:46:37.255+0900 I/watchface-common-util(  746): common-util-ipc-control.cpp: ~CommonUtilIPCControl(197) > 
12-07 22:46:37.255+0900 I/MESSAGE_PORT(  746): MessagePortProxy.cpp: IsLocalPortRegisted(675) > MessagePort name is already registered.
12-07 22:46:37.255+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:46:37.255+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:46:37.255+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:46:37.255+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
12-07 22:46:37.255+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
12-07 22:46:37.255+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:46:37.255+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.watchface:watchface::messageport::event], client = 746
12-07 22:46:37.255+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:46:37.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  746): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
12-07 22:46:37.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  746): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
12-07 22:46:37.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  746): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
12-07 22:46:37.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  746): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
12-07 22:46:37.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  746): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=16
12-07 22:46:37.255+0900 E/TIZEN_N_SYSTEM_SETTINGS(  746): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 16, key = 16, type = 1
12-07 22:46:37.255+0900 E/WIDGET_PROVIDER_APP(  746): client.c: client_fini(1175) > Provider is not initialized
12-07 22:46:37.280+0900 I/UXT     (  746): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
12-07 22:46:37.335+0900 E/W_HOME  (  707): move.c: move_back_to_home_no_anim(270) > home is already on position
12-07 22:46:37.335+0900 W/W_HOME  (  707): scroller.c: _get_index_in_list(1902) > page:0x49bf2c50 idx:2 total11 exist:1
12-07 22:46:37.335+0900 W/W_HOME  (  707): scroller.c: scroller_unfreeze(1860) > unfreezed:4005277b
12-07 22:46:37.335+0900 E/EFL     (  707): elementary<707> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88058), origin_x(0), origin_y(0)
12-07 22:46:37.335+0900 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:46:37.335+0900 W/AUL_AMD (  530): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:46:37.340+0900 W/W_HOME  (  707): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
12-07 22:46:37.345+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02400003)
12-07 22:46:37.365+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:46:37.370+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1219
12-07 22:46:37.370+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:46:37.390+0900 I/efl-extension(  746): efl_extension.c: eext_mod_shutdown(46) > Shutdown
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:46:37.540+0900 E/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
12-07 22:46:37.540+0900 E/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(746) are closed. delete client info
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
12-07 22:46:37.540+0900 E/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  746
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: UnregisterMessagePortByDiscon(280) > _MessagePortService::UnregisterMessagePortByDiscon
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.540+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:46:37.565+0900 E/HealthDataService(  783): server_dbus_connection.c: __on_client_vanished(187) > [0;40;31mclient vanished :1.71
12-07 22:46:37.565+0900 E/HealthDataService(  783): [0;m
12-07 22:46:37.565+0900 I/HealthDataService(  783): health_ipc_server.c: __health_server_ipc_remove_client(349) > [1;35mApplication info [com.samsung.watchface] is removed from the map [425A34B8][0;m
12-07 22:46:37.570+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 23
12-07 22:46:37.570+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-07 22:46:37.570+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 746
12-07 22:46:37.570+0900 W/AUL_AMD (  530): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-07 22:46:37.615+0900 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 746
12-07 22:46:37.620+0900 I/AUL_PAD ( 1411): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 22:46:37.770+0900 W/W_HOME  (  707): main.c: _init_timer_cb(1138) > home init
12-07 22:46:38.000+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:39.004+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:39.220+0900 W/AUL_AMD (  530): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 22:46:39.964+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-07 22:46:40.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:41.010+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:42.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:43.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:44.004+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:45.004+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:46.004+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:47.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:48.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:49.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:50.004+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:51.009+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:52.009+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:53.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:54.009+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:55.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:56.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:57.004+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:58.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:46:58.530+0900 E/AUL_AMD (  530): amd_main.c: __platform_ready_handler(370) > [Info]__platform_ready_handler
12-07 22:46:59.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:00.005+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:01.000+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:01.140+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-07 22:47:01.185+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-07 22:47:01.185+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : pedometer_inactive_period error
12-07 22:47:01.185+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-07 22:47:01.185+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-07 22:47:01.185+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_10min_precaution_millisec error
12-07 22:47:01.190+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-07 22:47:01.190+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-07 22:47:01.190+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1055): preference.c: preference_get_double(1214) > preference_get_double(1055) : inactive_before_10min_precaution_millisec error
12-07 22:47:02.000+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:03.000+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:04.000+0900 I/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 22:47:04.085+0900 E/PKGMGR_SERVER( 1492): pkgmgr-server.c: main(2126) > package manager server start
12-07 22:47:04.160+0900 E/PKGMGR_SERVER( 1492): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_396126873], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-07 22:47:04.165+0900 E/PKGMGR_SERVER( 1494): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-07 22:47:04.170+0900 E/PKGMGR  ( 1486): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-07 22:47:04.230+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:47:04.235+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1219
12-07 22:47:04.240+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:47:04.240+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 5
12-07 22:47:04.245+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(1219), cmd(4)
12-07 22:47:04.245+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 22:47:04.245+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(884) > app status : 4
12-07 22:47:04.245+0900 W/CAPI_WATCH_APPLICATION( 1219): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-07 22:47:04.250+0900 W/WATCH_CORE( 1219): appcore-watch.c: __widget_destroy(992) > widget_destory
12-07 22:47:04.250+0900 E/WIDGET_PROVIDER_APP( 1219): client.c: client_fini(1175) > Provider is not initialized
12-07 22:47:04.250+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 4
12-07 22:47:04.255+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:47:04.265+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1219
12-07 22:47:04.370+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:47:04.470+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 22:47:04.505+0900 E/AUL_AMD (  530): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-07 22:47:04.515+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(1219), cmd(4)
12-07 22:47:04.515+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 22:47:04.640+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:47:04.695+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 22:47:04.695+0900 E/AUL_AMD (  530): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 22:47:04.695+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(1659) > caller pid : 697
12-07 22:47:04.785+0900 E/PKGMGR_SERVER( 1494): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-07 22:47:04.885+0900 E/PKGMGR_SERVER( 1492): pkgmgr-server.c: sighandler(445) > child NORMAL exit [1494]
12-07 22:47:04.915+0900 E/RESOURCED(  532): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 1
12-07 22:47:04.915+0900 E/RESOURCED(  532): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 22:47:04.920+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 22:47:04.920+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-07 22:47:04.920+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 22:47:04.955+0900 I/CAPI_WATCH_APPLICATION( 1411): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 22:47:04.980+0900 E/TBM     ( 1411): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 22:47:05.025+0900 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1219
12-07 22:47:05.060+0900 W/WATCH_CORE( 1411): appcore-watch.c: __widget_create(958) > widget_create
12-07 22:47:05.060+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1712) > [SECURE_LOG] [93.900696] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_93.900696.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263014:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 22:47:05.060+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[93.900696] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_93.900696.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263014:4] gbar_fname[]
12-07 22:47:05.085+0900 E/WIDGET_VIEWER(  707): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 22:47:05.085+0900 E/WIDGET_EVAS(  707): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 22:47:05.165+0900 W/WATCH_CORE( 1411): appcore-watch.c: __widget_create(976) > widget_create done
12-07 22:47:05.235+0900 I/WATCH_CORE( 1411): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-07 22:47:05.235+0900 I/WATCH_CORE( 1411): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-07 22:47:05.235+0900 I/WATCH_CORE( 1411): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-07 22:47:05.635+0900 W/WATCH_CORE( 1411): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-07 22:47:05.635+0900 I/WATCH_CORE( 1411): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-07 22:47:05.640+0900 W/W_HOME  (  707): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-07 22:47:05.640+0900 W/W_HOME  (  707): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-07 22:47:05.640+0900 W/W_HOME  (  707): gesture.c: _manual_render_enable(133) > 1
12-07 22:47:05.640+0900 W/W_HOME  (  707): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-07 22:47:05.640+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:47:05.640+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-07 22:47:05.640+0900 W/STARTER (  691): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-07 22:47:05.645+0900 E/STARTER (  691): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-07 22:47:05.645+0900 W/STARTER (  691): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-07 22:47:05.645+0900 W/STARTER (  691): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-07 22:47:05.645+0900 I/SCONTEXT-LIB(  671): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-07 22:47:05.650+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-07 22:47:05.650+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-07 22:47:05.655+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-07 22:47:05.705+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-07 22:47:05.705+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-07 22:47:05.705+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-07 22:47:05.705+0900 I/HIGEAR  ( 1071): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-07 22:47:05.790+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-07 22:47:05.795+0900 I/SHealth_Common( 1055): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-07 22:47:05.795+0900 I/SHealth_Service( 1055): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-07 22:47:05.800+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-07 22:47:05.800+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-07 22:47:05.800+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-07 22:47:05.800+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-07 22:47:05.805+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: PAUSE State: RUNNING
12-07 22:47:05.805+0900 I/CAPI_APPFW_APPLICATION(  707): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-07 22:47:05.805+0900 W/W_HOME  (  707): main.c: _appcore_pause_cb(690) > appcore pause
12-07 22:47:05.805+0900 W/W_HOME  (  707): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-07 22:47:05.805+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:47:05.805+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:47:05.805+0900 W/W_HOME  (  707): main.c: home_pause(751) > clock/widget paused
12-07 22:47:05.805+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 22:47:05.805+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:05.805+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:05.805+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:05.805+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-07 22:47:05.805+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-07 22:47:05.805+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:05.805+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 22:47:05.805+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:05.810+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:05.810+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:05.810+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 22:47:05.810+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 22:47:05.810+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 22:47:05.810+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 22:47:05.810+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-07 22:47:05.810+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-07 22:47:05.810+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-07 22:47:05.810+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 22:47:05.810+0900 E/CAPI_APPFW_APP_CONTROL( 1020): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-07 22:47:05.810+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1020]   value = [false][0m
12-07 22:47:05.810+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-07 22:47:06.055+0900 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 22:47:06.055+0900 W/AUL_AMD (  530): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 22:47:06.060+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 22:47:06.065+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1411
12-07 22:47:06.065+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 22:47:06.070+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-07 22:47:06.070+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-07 22:47:06.070+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-07 22:47:06.070+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-07 22:47:06.070+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: PAUSE State: PAUSED
12-07 22:47:06.205+0900 E/PKGMGR_SERVER( 1492): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 22:47:06.205+0900 E/PKGMGR_SERVER( 1492): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 22:47:06.245+0900 W/AUL_AMD (  530): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 22:47:06.295+0900 I/AUL_PAD ( 1533): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 22:47:06.350+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: MEM_FLUSH State: PAUSED
12-07 22:47:10.830+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: MEM_FLUSH State: PAUSED
12-07 22:47:12.630+0900 E/W-CONTACTS2-CONSUMER( 1153): ct-sap-svc-client.c: __ct_sap_svc_client_exit_consumer(691) > [0;31m* Critical * Total allocated space (uordblks):244432
12-07 22:47:12.630+0900 E/W-CONTACTS2-CONSUMER( 1153): [0;m
12-07 22:47:12.630+0900 I/CAPI_APPFW_APPLICATION( 1153): service_app_main.c: service_app_exit(441) > service_app_exit
12-07 22:47:12.655+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 22:47:12.655+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(884) > app status : 4
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 22:47:12.945+0900 E/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(588) > Connection closed
12-07 22:47:12.945+0900 E/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(610) > All connections of client(1153) are closed. delete client info
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcClientDisconnected(178) > MessagePort Ipc disconnected
12-07 22:47:12.945+0900 E/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcClientDisconnected(181) > Unregister - client =  1153
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: UnregisterMessagePortByDiscon(280) > _MessagePortService::UnregisterMessagePortByDiscon
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:12.945+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: unregistermessageport(264) > unregistermessageport
12-07 22:47:13.035+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 23
12-07 22:47:13.035+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
12-07 22:47:13.035+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(917) > pkg_status: installed, dead pid: 1153
12-07 22:47:13.035+0900 W/AUL_AMD (  530): amd_request.c: __send_app_termination_signal(507) > send dead signal done
12-07 22:47:13.040+0900 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 1153
12-07 22:47:14.660+0900 W/AUL_AMD (  530): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 22:47:15.550+0900 E/PKGMGR  ( 1645): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-07 22:47:15.710+0900 E/PKGMGR_SERVER( 1647): pkgmgr-server.c: main(2126) > package manager server start
12-07 22:47:15.795+0900 E/PKGMGR_SERVER( 1647): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_407748605], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_407748605' '-r' 'org.reolab.blackandwhite'], cookie=[/IUjwmBiQzIwypup/3iWUQeLBgA=], backend_flag=[0]
12-07 22:47:15.795+0900 E/PKGMGR  ( 1647): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-07 22:47:15.795+0900 E/PKGMGR_SERVER( 1647): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-07 22:47:15.800+0900 E/PKGMGR  ( 1645): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[16450002]
12-07 22:47:15.805+0900 E/PKGMGR_SERVER( 1649): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-07 22:47:15.990+0900 W/AUL_AMD (  530): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 22:47:16.000+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-07 22:47:16.005+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:47:16.035+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-07 22:47:16.730+0900 E/PKGMGR_CERT( 1649): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-07 22:47:16.740+0900 E/PKGMGR_CERT( 1649): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-07 22:47:16.740+0900 E/PKGMGR_CERT( 1649): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-07 22:47:16.745+0900 E/PKGMGR_CERT( 1649): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-07 22:47:16.745+0900 E/PKGMGR_CERT( 1649): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-07 22:47:16.745+0900 E/PKGMGR_CERT( 1649): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-07 22:47:16.745+0900 E/PKGMGR_CERT( 1649): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-07 22:47:16.750+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:47:16.770+0900 E/PKGMGR_CERT( 1649): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-07 22:47:18.205+0900 E/PKGMGR_SERVER( 1647): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 22:47:19.085+0900 E/rpm-installer( 1649): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-07 22:47:20.205+0900 E/PKGMGR_SERVER( 1647): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-07 22:47:21.975+0900 E/PKGMGR_SERVER( 1647): pkgmgr-server.c: sighandler(445) > child NORMAL exit [1649]
12-07 22:47:21.985+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 22:47:22.005+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-07 22:47:22.005+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-07 22:47:22.025+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-07 22:47:22.025+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-07 22:47:22.025+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-07 22:47:22.025+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-07 22:47:22.065+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-07 22:47:22.135+0900 E/PKGMGR_INFO(  527): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-07 22:47:22.140+0900 E/APPS    (  707): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-07 22:47:22.205+0900 E/PKGMGR_SERVER( 1647): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 22:47:22.205+0900 E/PKGMGR_SERVER( 1647): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 22:47:22.410+0900 W/CRASH_MANAGER( 1653): worker.c: worker_job(1199) > 1101411626c61144949604
