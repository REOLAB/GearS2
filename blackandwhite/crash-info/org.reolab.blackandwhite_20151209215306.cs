S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 14705
Date: 2015-12-09 21:53:06+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xe1c

Register Information
r0   = 0xbeda32fc, r1   = 0xbeda35e4
r2   = 0x6d008a00, r3   = 0x6d008a00
r4   = 0xbeda3548, r5   = 0xbeda32e0
r6   = 0x00000132, r7   = 0xbeda32b0
r8   = 0x4030b9c0, r9   = 0x4145fde8
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4155d188, sp   = 0xbeda3248
lr   = 0x41554875, pc   = 0x00000e1c
cpsr = 0x80000010

Memory Information
MemTotal:   491012 KB
MemFree:     29448 KB
Buffers:     31384 KB
Cached:     124072 KB
VmPeak:      78624 KB
VmSize:      78112 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15388 KB
VmRSS:       15388 KB
VmData:      21624 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22096 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 14705 TID = 14705
14705 15005 15015 

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
43757000 43f56000 rw-p [stack:15005]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424b000 44b00000 rw-p [stack:15015]
bed83000 beda4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14705)
Call Stack Count: 1
 0: (0xe1c) (null)
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
gePort SendMessage
12-09 21:52:47.244+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 21:52:47.244+0900 W/W_HOME  (  707): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-09 21:52:47.244+0900 E/W_HOME  (  707): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 21:52:47.244+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:52:48.004+0900 I/CAPI_WATCH_APPLICATION(14524): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:52:49.004+0900 I/CAPI_WATCH_APPLICATION(14524): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:52:50.004+0900 I/CAPI_WATCH_APPLICATION(14524): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:52:50.999+0900 I/CAPI_WATCH_APPLICATION(14524): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:52:51.999+0900 I/CAPI_WATCH_APPLICATION(14524): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:52:52.149+0900 E/PKGMGR_SERVER(14997): pkgmgr-server.c: main(2126) > package manager server start
12-09 21:52:52.234+0900 E/PKGMGR_SERVER(14997): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1854493803], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-09 21:52:52.239+0900 E/PKGMGR_SERVER(14998): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-09 21:52:52.244+0900 E/PKGMGR  (14990): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-09 21:52:52.309+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:52:52.319+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14524
12-09 21:52:52.324+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 21:52:52.324+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 5
12-09 21:52:52.329+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(14524), cmd(4)
12-09 21:52:52.329+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:52:52.334+0900 W/CAPI_WATCH_APPLICATION(14524): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-09 21:52:52.334+0900 W/WATCH_CORE(14524): appcore-watch.c: __widget_destroy(992) > widget_destory
12-09 21:52:52.334+0900 E/WIDGET_PROVIDER_APP(14524): client.c: client_fini(1175) > Provider is not initialized
12-09 21:52:52.339+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14524
12-09 21:52:52.344+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 22
12-09 21:52:52.344+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(884) > app status : 4
12-09 21:52:52.344+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 4
12-09 21:52:52.449+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:52:52.549+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-09 21:52:52.574+0900 E/AUL_AMD (  530): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-09 21:52:52.579+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(14524), cmd(4)
12-09 21:52:52.579+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 0
12-09 21:52:52.644+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 21:52:52.669+0900 W/W_HOME  (  707): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 21:52:52.669+0900 W/W_HOME  (  707): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-09 21:52:52.669+0900 W/W_HOME  (  707): gesture.c: _manual_render_enable(133) > 1
12-09 21:52:52.669+0900 W/W_HOME  (  707): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-09 21:52:52.669+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:52:52.674+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 21:52:52.674+0900 E/AUL_AMD (  530): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-09 21:52:52.674+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(1659) > caller pid : 697
12-09 21:52:52.679+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-09 21:52:52.679+0900 W/STARTER (  691): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-09 21:52:52.679+0900 E/STARTER (  691): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 21:52:52.679+0900 W/STARTER (  691): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-09 21:52:52.679+0900 W/STARTER (  691): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-09 21:52:52.684+0900 I/SCONTEXT-LIB(  671): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-09 21:52:52.699+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-09 21:52:52.699+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-09 21:52:52.704+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-09 21:52:52.709+0900 E/PKGMGR_SERVER(14998): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-09 21:52:52.764+0900 E/PKGMGR_SERVER(14997): pkgmgr-server.c: sighandler(445) > child NORMAL exit [14998]
12-09 21:52:52.794+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-09 21:52:52.794+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-09 21:52:52.794+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-09 21:52:52.794+0900 I/HIGEAR  ( 1071): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-09 21:52:52.869+0900 E/RESOURCED(  532): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-09 21:52:52.869+0900 E/RESOURCED(  532): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-09 21:52:52.869+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(2026) > pad pid(-5)
12-09 21:52:52.874+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-09 21:52:52.874+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(265) > Check app launching
12-09 21:52:52.884+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-09 21:52:52.884+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-09 21:52:52.884+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-09 21:52:52.884+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-09 21:52:52.884+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: PAUSE State: RUNNING
12-09 21:52:52.889+0900 I/CAPI_APPFW_APPLICATION(  707): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-09 21:52:52.889+0900 W/W_HOME  (  707): main.c: _appcore_pause_cb(690) > appcore pause
12-09 21:52:52.889+0900 W/W_HOME  (  707): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-09 21:52:52.889+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:52:52.889+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:52:52.889+0900 W/W_HOME  (  707): main.c: home_pause(751) > clock/widget paused
12-09 21:52:52.889+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 21:52:52.889+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:52:52.889+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-09 21:52:52.929+0900 I/CAPI_WATCH_APPLICATION(14705): watch_app_main.c: watch_app_main(382) > watch_app_main
12-09 21:52:52.934+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-09 21:52:52.934+0900 E/CAPI_APPFW_APP_CONTROL( 1020): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 21:52:52.934+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1020]   value = [false][0m
12-09 21:52:52.954+0900 I/SHealth_Common( 1055): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-09 21:52:52.954+0900 I/SHealth_Service( 1055): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-09 21:52:52.964+0900 E/TBM     (14705): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-09 21:52:52.974+0900 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 14524
12-09 21:52:53.029+0900 W/WATCH_CORE(14705): appcore-watch.c: __widget_create(958) > widget_create
12-09 21:52:53.029+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1712) > [SECURE_LOG] [9879.414062] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_9879.414062.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263126:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-09 21:52:53.029+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[9879.414062] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_9879.414062.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263126:4] gbar_fname[]
12-09 21:52:53.069+0900 E/WIDGET_VIEWER(  707): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-09 21:52:53.069+0900 E/WIDGET_EVAS(  707): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-09 21:52:53.144+0900 F/EFL     (14705): evas_main<14705> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:52:53.144+0900 F/EFL     (14705):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:52:53.144+0900 F/EFL     (14705):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:52:53.144+0900 F/EFL     (14705): evas_main<14705> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:52:53.144+0900 F/EFL     (14705):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:52:53.144+0900 F/EFL     (14705):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:52:53.144+0900 F/EFL     (14705): evas_main<14705> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:52:53.144+0900 F/EFL     (14705):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:52:53.144+0900 F/EFL     (14705):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:52:53.154+0900 W/WATCH_CORE(14705): appcore-watch.c: __widget_create(976) > widget_create done
12-09 21:52:53.224+0900 I/WATCH_CORE(14705): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-09 21:52:53.224+0900 I/WATCH_CORE(14705): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-09 21:52:53.224+0900 I/WATCH_CORE(14705): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-09 21:52:53.394+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: MEM_FLUSH State: PAUSED
12-09 21:52:53.974+0900 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 21:52:53.974+0900 W/AUL_AMD (  530): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-09 21:52:53.989+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:52:53.999+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14705
12-09 21:52:53.999+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 21:52:54.199+0900 I/AUL_PAD (15028): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-09 21:52:54.344+0900 W/AUL_AMD (  530): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-09 21:52:54.884+0900 E/PKGMGR_SERVER(14997): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-09 21:52:54.884+0900 E/PKGMGR_SERVER(14997): pkgmgr-server.c: main(2180) > package manager server terminated.
12-09 21:52:57.894+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: MEM_FLUSH State: PAUSED
12-09 21:53:00.539+0900 I/GESTURE (  139): gesture.c: GestureHandleKeyPressEvent(3712) > [GestureHandleKeyPressEvent] Ignore key press in DPMS off (devid:7) keycode=166
12-09 21:53:00.769+0900 W/WATCH_CORE(14705): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
12-09 21:53:00.774+0900 W/wnotibp (21408): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1405) > ::APP:: view state=0, 2, 0
12-09 21:53:00.824+0900 W/W_HOME  (  707): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-09 21:53:00.824+0900 W/W_HOME  (  707): gesture.c: _manual_render_disable_timer_set(161) > timer set
12-09 21:53:00.824+0900 W/W_HOME  (  707): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-09 21:53:00.824+0900 W/W_HOME  (  707): gesture.c: _apps_status_get(123) > apps status:0
12-09 21:53:00.824+0900 W/W_HOME  (  707): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:1 info->offtime:8109
12-09 21:53:00.824+0900 W/W_HOME  (  707): gesture.c: _manual_render_schedule(211) > schedule, manual render
12-09 21:53:00.824+0900 W/W_HOME  (  707): event_manager.c: _lcd_on_cb(691) > lcd state: 1
12-09 21:53:00.824+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:53:00.829+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1519) > [_on_lcd_signal_receive_cb:1519] _on_lcd_signal_receive_cb, 1519, Pre LCD on by [powerkey] after screen off time [8109]ms
12-09 21:53:00.829+0900 W/STARTER (  691): clock-mgr.c: _pre_lcd_on(1245) > [_pre_lcd_on:1245] Will LCD ON as reserved app[(null)] alpm mode[0]
12-09 21:53:00.829+0900 I/SCONTEXT-LIB(  671): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 42 (req_id=354)
12-09 21:53:00.839+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: RESUME State: PAUSED
12-09 21:53:00.839+0900 I/CAPI_APPFW_APPLICATION(  707): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-09 21:53:00.839+0900 W/W_HOME  (  707): main.c: _appcore_resume_cb(681) > appcore resume
12-09 21:53:00.839+0900 W/W_HOME  (  707): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
12-09 21:53:00.839+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:53:00.844+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:53:00.844+0900 W/W_HOME  (  707): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-09 21:53:00.844+0900 W/W_HOME  (  707): main.c: home_resume(733) > clock/widget resumed
12-09 21:53:00.844+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:53:00.844+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-09 21:53:00.874+0900 I/WATCH_CORE(14705): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-09 21:53:00.874+0900 W/WATCH_CORE(14705): appcore-watch.c: __widget_resume(1012) > widget_resume
12-09 21:53:00.914+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: OnReceiveDisplayChanged(905) > [0;32mINFO: LCDOn receive data : 1124318408[0;m
12-09 21:53:00.914+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-09 21:53:00.914+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-09 21:53:00.919+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [powerkey]
12-09 21:53:00.919+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[0]
12-09 21:53:00.929+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-09 21:53:00.929+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-09 21:53:00.994+0900 I/CAPI_WATCH_APPLICATION(14705): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:53:01.004+0900 I/SHealth_Common( 1055): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-09 21:53:01.009+0900 W/W_HOME  (  707): gesture.c: _widget_updated_cb(190) > widget updated
12-09 21:53:01.009+0900 W/W_HOME  (  707): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-09 21:53:01.009+0900 W/W_HOME  (  707): gesture.c: _manual_render(176) > 
12-09 21:53:01.024+0900 I/CAPI_WATCH_APPLICATION(14705): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:53:01.029+0900 I/SHealth_Service( 1055): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-09 21:53:01.029+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
12-09 21:53:01.059+0900 W/W_HOME  (  707): gesture.c: _manual_render(176) > 
12-09 21:53:01.074+0900 W/W_HOME  (  707): gesture.c: _manual_render_enable(133) > 0
12-09 21:53:01.144+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 2 -> 1
12-09 21:53:01.144+0900 E/WMS     (  528): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-09 21:53:01.144+0900 E/WMS     (  528): ==========
12-09 21:53:01.144+0900 E/WMS     (  528): ##WMS SEND : mgr_gear_wear_onoff_req
12-09 21:53:01.144+0900 E/WMS     (  528): ==========
12-09 21:53:01.144+0900 E/WMS     (  528): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-09 21:53:01.164+0900 W/SCSD    (12812): <util_sms_send:223> Send message('nc-rq') to [SAP_B20AB80536BAB4F59F3EDA41EA7403B1 / 39kc4o8c10] peer
12-09 21:53:01.184+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: sms_e - Call TargetInstanceID( 39kc4o8c10 ), SMS_Size( 5 )
12-09 21:53:01.189+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: send_msg - ( 0x34 ), type( 0x01 ), res( 232 ), seq( 1013 )
12-09 21:53:01.189+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Call()
12-09 21:53:01.189+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Res( 0 )
12-09 21:53:01.189+0900 W/SNL_W   (12812): <presSendNotify_i:987> presSendNotify_w ( 7d3831446264732f3e6c2a3e ) - begin
12-09 21:53:01.194+0900 W/SNL_W   (12812): <presSendNotify_i:992> presSendNotify_w ( 7d3831446264732f3e6c2a3e ) - Interrupt (Not SKA)
12-09 21:53:01.194+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Call()
12-09 21:53:01.194+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Res( 0 )
12-09 21:53:01.194+0900 W/SNL_W   (12812): <releaseAlarm:493> stop alarm_id(279403745)
12-09 21:53:01.194+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-09 21:53:01.194+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-09 21:53:01.194+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-09 21:53:01.194+0900 I/HIGEAR  ( 1071): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-09 21:53:01.204+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(279403745)
12-09 21:53:01.204+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 21:53:01.204+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 9-12-2015, 13:14:04 (UTC).
12-09 21:53:01.204+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 21:53:01.204+0900 W/ALARM_MANAGER(  526): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[279403745] is removed.
12-09 21:53:01.209+0900 W/SNL_W   (12812): <setAlarm:520> setAlarm() - begin 
12-09 21:53:01.209+0900 W/SNL_W   (12812): <initAlarm:505> InitAlarm() - begin
12-09 21:53:01.209+0900 W/SNL_W   (12812): <initAlarm:511> InitAlarm() success - end
12-09 21:53:01.224+0900 I/AUL     (12812): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:01.239+0900 I/AUL     (12812): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:01.239+0900 W/ALARM_MANAGER(12812): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(1195), start(9-12-2015, 22:12:56), repeat(0), interval(0), type(-1073741822)
12-09 21:53:01.269+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:01.279+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: recv_msg(res) - ( 0x34 ), seq( 1013 )
12-09 21:53:01.279+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: sms_e - Res( 0 )
12-09 21:53:01.279+0900 W/SCSD    (12812): <util_scs_send_message:946> success.
12-09 21:53:01.284+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-09 21:53:01.289+0900 W/SHealth_Service( 1055): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
12-09 21:53:01.289+0900 E/SHealth_Service( 1055): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-09 21:53:01.294+0900 W/SCSD    (12812): <util_sms_send:235> send sms success
12-09 21:53:01.299+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:01.309+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:01.324+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:01.334+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:01.344+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:01.344+0900 W/ALARM_MANAGER(  526): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1449666776, Wed Dec  9 22:12:56 2015
12-09 21:53:01.344+0900 W/ALARM_MANAGER(  526): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1631057910, next duetime: 1449666776
12-09 21:53:01.344+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(1631057910)
12-09 21:53:01.344+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449666844), due_time(1449666776)
12-09 21:53:01.344+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 21:53:01.344+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 9-12-2015, 13:12:56 (UTC).
12-09 21:53:01.344+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 21:53:01.349+0900 W/SNL_W   (12812): <setAlarm:569> setAlarm() - end : mStatus ( 2 ) currentInterval( 1200 ) interruptFlag ( 0 ) alarm_id ( 1631057910 )
12-09 21:53:01.349+0900 W/SNL_W   (12812): <presSendNotify_i:1010> presSendNotify_w ( 7d3831446264732f3e6c2a3e ) - end
12-09 21:53:01.349+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: noti_ps_th - Res( )
12-09 21:53:01.464+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: recv_msg(nty) - ( 0x34 )
12-09 21:53:01.464+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: noti_smse - Call()
12-09 21:53:01.464+0900 W/SNL_W   (12812): <smsNotifyEx_i:1067> smsNotifyEx_w - begin 
12-09 21:53:01.464+0900 W/SNL_W   (12812): <getIsLoggedin:911> getIsLoggedin() - isLoggedin ( 1 )
12-09 21:53:01.464+0900 W/SCSD    (12812): <on_smsNotifyEx:493> src_peer_id: SAP_B20AB80536BAB4F59F3EDA41EA7403B1
12-09 21:53:01.464+0900 W/SCSD    (12812): <on_smsNotifyEx:494> src_group_id: 7d3831446264732f3e6c2a3e
12-09 21:53:01.464+0900 W/SCSD    (12812): <on_smsNotifyEx:495> src_instance_id: 39kc4o8c10
12-09 21:53:01.464+0900 W/SCSD    (12812): <on_smsNotifyEx:496> sms_text: nc-rs
12-09 21:53:01.464+0900 W/SCSD    (12812): <on_smsNotifyEx:497> sms_len: 5
12-09 21:53:01.464+0900 W/SNL_W   (12812): <smsNotifyEx_i:1095> smsNotifyEx_w - end 
12-09 21:53:01.469+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: noti_smse - Res( 0 )
12-09 21:53:01.844+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:53:01.844+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:53:01.844+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:53:01.844+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 21:53:01.844+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 21:53:01.844+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:53:01.844+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 21:53:01.844+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:53:01.854+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:53:01.854+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:53:01.854+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:53:01.854+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 21:53:01.854+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 21:53:01.854+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:53:01.854+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 21:53:01.854+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 21:53:01.854+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 21:53:01.859+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:53:01.859+0900 E/CAPI_APPFW_APP_CONTROL( 1020): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 21:53:01.859+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1020]   value = [true][0m
12-09 21:53:01.874+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:53:01.884+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 707
12-09 21:53:01.904+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT][0m
12-09 21:53:01.914+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:53:01.914+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:53:01.914+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:53:01.914+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 21:53:01.914+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 21:53:01.914+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:53:01.914+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 21:53:01.914+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:53:01.919+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:53:01.919+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:53:01.919+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:53:01.919+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 21:53:01.919+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 21:53:01.919+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:53:01.919+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 21:53:01.919+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 21:53:01.919+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 21:53:01.924+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:53:01.924+0900 W/W_HOME  (  707): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-09 21:53:01.924+0900 E/W_HOME  (  707): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 21:53:01.934+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT][0m
12-09 21:53:01.944+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:53:01.944+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:53:01.944+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:53:01.944+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 21:53:01.944+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 21:53:01.944+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:53:01.944+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 21:53:01.944+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:53:01.949+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:53:01.949+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:53:01.949+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:53:01.949+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 21:53:01.949+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 21:53:01.949+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:53:01.949+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 21:53:01.949+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 21:53:01.949+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 21:53:01.949+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:53:01.954+0900 W/W_HOME  (  707): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-09 21:53:01.954+0900 E/W_HOME  (  707): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 21:53:01.999+0900 I/CAPI_WATCH_APPLICATION(14705): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:53:02.294+0900 W/SCSD    (12812): <_message_cb:428> SCS message received !!!
12-09 21:53:02.294+0900 W/SCSD    (12812): <_message_cb:429>  - peer_id: SAP_B20AB80536BAB4F59F3EDA41EA7403B1
12-09 21:53:02.294+0900 W/SCSD    (12812): <_message_cb:430>  - msg: nc-rs
12-09 21:53:02.294+0900 W/SCSD    (12812): <_message_cb:431>  - msg length: 5
12-09 21:53:02.294+0900 W/SCSD    (12812): <util_sms_recv_message:404> msg : nc-rs
12-09 21:53:02.294+0900 W/SCSD    (12812): <util_sms_send:223> Send message('nc-cnf') to [SAP_B20AB80536BAB4F59F3EDA41EA7403B1 / 39kc4o8c10] peer
12-09 21:53:02.399+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: sms_e - Call TargetInstanceID( 39kc4o8c10 ), SMS_Size( 6 )
12-09 21:53:02.424+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: send_msg - ( 0x34 ), type( 0x01 ), res( 232 ), seq( 1014 )
12-09 21:53:02.429+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Call()
12-09 21:53:02.434+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Res( 0 )
12-09 21:53:02.439+0900 W/SNL_W   (12812): <presSendNotify_i:987> presSendNotify_w ( 7d3831446264732f3e6c2a3e ) - begin
12-09 21:53:02.439+0900 W/SNL_W   (12812): <presSendNotify_i:992> presSendNotify_w ( 7d3831446264732f3e6c2a3e ) - Interrupt (Not SKA)
12-09 21:53:02.449+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Call()
12-09 21:53:02.464+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Res( 0 )
12-09 21:53:02.464+0900 W/SNL_W   (12812): <releaseAlarm:493> stop alarm_id(1631057910)
12-09 21:53:02.489+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(1631057910)
12-09 21:53:02.489+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 21:53:02.489+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 9-12-2015, 13:14:04 (UTC).
12-09 21:53:02.489+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 21:53:02.489+0900 W/ALARM_MANAGER(  526): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[1631057910] is removed.
12-09 21:53:02.504+0900 W/SNL_W   (12812): <setAlarm:520> setAlarm() - begin 
12-09 21:53:02.504+0900 W/SNL_W   (12812): <initAlarm:505> InitAlarm() - begin
12-09 21:53:02.504+0900 W/SNL_W   (12812): <initAlarm:511> InitAlarm() success - end
12-09 21:53:02.509+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: recv_msg(res) - ( 0x34 ), seq( 1014 )
12-09 21:53:02.514+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: sms_e - Res( 0 )
12-09 21:53:02.514+0900 W/SCSD    (12812): <util_scs_send_message:946> success.
12-09 21:53:02.544+0900 W/SCSD    (12812): <util_sms_send:235> send sms success
12-09 21:53:02.594+0900 I/AUL     (12812): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:02.619+0900 I/AUL     (12812): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:02.619+0900 W/ALARM_MANAGER(12812): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(1195), start(9-12-2015, 22:12:58), repeat(0), interval(0), type(-1073741822)
12-09 21:53:02.644+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:02.659+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:02.669+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: recv_msg(nty) - ( 0x10 )
12-09 21:53:02.674+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:02.684+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:02.694+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:02.709+0900 I/AUL     (  526): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-09 21:53:02.709+0900 W/ALARM_MANAGER(  526): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1449666778, Wed Dec  9 22:12:58 2015
12-09 21:53:02.709+0900 W/ALARM_MANAGER(  526): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 257639155, next duetime: 1449666778
12-09 21:53:02.709+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(257639155)
12-09 21:53:02.709+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449666844), due_time(1449666778)
12-09 21:53:02.709+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-09 21:53:02.709+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 9-12-2015, 13:12:58 (UTC).
12-09 21:53:02.709+0900 W/ALARM_MANAGER(  526): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-09 21:53:02.714+0900 W/SNL_W   (12812): <setAlarm:569> setAlarm() - end : mStatus ( 2 ) currentInterval( 1200 ) interruptFlag ( 0 ) alarm_id ( 257639155 )
12-09 21:53:02.714+0900 W/SNL_W   (12812): <presSendNotify_i:1010> presSendNotify_w ( 7d3831446264732f3e6c2a3e ) - end
12-09 21:53:02.714+0900 W/SNL     (12812): Scone_Log.cpp: dump(2972) > SNL :: noti_ps_th - Res( )
12-09 21:53:03.004+0900 I/CAPI_WATCH_APPLICATION(14705): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:53:04.004+0900 I/CAPI_WATCH_APPLICATION(14705): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:53:04.789+0900 E/PKGMGR  (15160): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-09 21:53:04.974+0900 E/PKGMGR_SERVER(15162): pkgmgr-server.c: main(2126) > package manager server start
12-09 21:53:04.994+0900 I/CAPI_WATCH_APPLICATION(14705): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:53:05.069+0900 E/PKGMGR_SERVER(15162): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1841700873], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-1841700873' '-r' 'org.reolab.blackandwhite'], cookie=[Vm4Endk9RL/C6/sh1b+qoxUJ7aI=], backend_flag=[0]
12-09 21:53:05.074+0900 E/PKGMGR  (15162): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-09 21:53:05.074+0900 E/PKGMGR_SERVER(15162): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-09 21:53:05.079+0900 E/PKGMGR  (15160): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[151600002]
12-09 21:53:05.079+0900 E/PKGMGR_SERVER(15163): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-09 21:53:05.234+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-09 21:53:05.244+0900 W/AUL_AMD (  530): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-09 21:53:05.264+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 21:53:05.264+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-09 21:53:05.829+0900 E/PKGMGR_CERT(15163): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-09 21:53:05.839+0900 E/PKGMGR_CERT(15163): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-09 21:53:05.849+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 21:53:05.849+0900 E/PKGMGR_CERT(15163): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-09 21:53:05.849+0900 E/PKGMGR_CERT(15163): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-09 21:53:05.849+0900 E/PKGMGR_CERT(15163): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-09 21:53:05.849+0900 E/PKGMGR_CERT(15163): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-09 21:53:05.849+0900 E/PKGMGR_CERT(15163): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-09 21:53:05.869+0900 E/PKGMGR_CERT(15163): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-09 21:53:05.994+0900 I/CAPI_WATCH_APPLICATION(14705): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-09 21:53:06.239+0900 W/CRASH_MANAGER(15165): worker.c: worker_job(1199) > 1114705626c61144966558
