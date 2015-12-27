S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 15563
Date: 2015-12-12 08:31:41+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1a4

Register Information
r0   = 0x00000198, r1   = 0x0000000d
r2   = 0x00000008, r3   = 0x41553194
r4   = 0x00000198, r5   = 0x00000000
r6   = 0x414e9204, r7   = 0x414dd608
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeaf5c4c, sp   = 0xbeaf5c00
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   489992 KB
MemFree:     13256 KB
Buffers:     28984 KB
Cached:     101604 KB
VmPeak:     119664 KB
VmSize:     119152 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15960 KB
VmRSS:       15960 KB
VmData:      62624 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 15563 TID = 15563
15563 16030 16041 

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
43757000 43f56000 rw-p [stack:16030]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43f75000 43f8c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:16041]
bead6000 beaf7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15563)
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
H_CORE(14859): appcore-watch.c: __signal_alpm_handler(1039) > signal_alpm_handler: ambient mode: 1, state: 2
12-12 08:27:24.546+0900 W/CAPI_WATCH_APPLICATION(14859): watch_app_main.c: _watch_core_ambient_changed(337) > _watch_core_ambient_changed: 1
12-12 08:27:24.546+0900 W/ALARM_MANAGER(14859): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(36), start(12-12-2015, 08:28:01), repeat(1), interval(60), type(-1073741822)
12-12 08:27:24.601+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1681431895, next duetime: 1449876481
12-12 08:27:24.601+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(1681431895)
12-12 08:27:24.601+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449878256), due_time(1449876481)
12-12 08:27:24.601+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:27:24.601+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:28:01 (UTC).
12-12 08:27:24.601+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:27:24.621+0900 I/CAPI_NETWORK_WIFI(14859): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:27:24.631+0900 I/CAPI_NETWORK_WIFI(14859): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:27:24.661+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-12 08:27:24.691+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_clockdraw_cb(325) >  Clock draw done
12-12 08:27:24.696+0900 I/WATCH_CORE(14859): appcore-watch-signal.c: _watch_core_send_alpm_update_done(282) > send a alpm update done signal
12-12 08:27:24.701+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[0]
12-12 08:27:24.701+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[0] lcd[1]
12-12 08:27:24.806+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_check_timer_cb(218) >  Render check timer expired
12-12 08:27:24.806+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_clockend_timer_cb(192) >  clock end << [1]
12-12 08:27:24.831+0900 W/ALARM_MANAGER(15061): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(1800), start(12-12-2015, 08:57:25), repeat(1), interval(1800), type(-1073741822)
12-12 08:27:25.071+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 297347938, next duetime: 1449878245
12-12 08:27:25.071+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(297347938)
12-12 08:27:25.076+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449876481), due_time(1449878245)
12-12 08:27:25.076+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:27:25.076+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:28:01 (UTC).
12-12 08:27:25.076+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:27:25.091+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [event]
12-12 08:27:25.096+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[1]
12-12 08:27:25.096+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-12 08:27:25.096+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[0]
12-12 08:27:25.106+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(529) >  event lcdoff completed[1][0]
12-12 08:27:25.106+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(276) >  enabled[1] status[1]
12-12 08:27:25.131+0900 W/ALARM_MANAGER(  693): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(20), start(12-12-2015, 08:27:45), repeat(1), interval(20), type(-1073741822)
12-12 08:27:25.191+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 297347939, next duetime: 1449876465
12-12 08:27:25.191+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(297347939)
12-12 08:27:25.191+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449876481), due_time(1449876465)
12-12 08:27:25.196+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:27:25.196+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:27:45 (UTC).
12-12 08:27:25.196+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:27:25.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:27:25.686+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:27:29.296+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-12 08:27:30.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:27:30.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:27:35.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:27:35.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:27:40.691+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:27:40.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:27:42.001+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-12 08:27:42.001+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-12 08:27:44.996+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-12 08:27:45.071+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-12 08:27:45.131+0900 E/RESOURCED(  480): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 693
12-12 08:27:45.146+0900 W/ALARM_MANAGER(  693): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [297347939]
12-12 08:27:45.146+0900 W/STARTER (  693): clock-mgr.c: __starter_clock_mgr_homescreen_alarm_cb(926) > [__starter_clock_mgr_homescreen_alarm_cb:926] homescreen alarm timer expired [297347939]
12-12 08:27:45.166+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-12 08:27:45.171+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 693
12-12 08:27:45.181+0900 W/AUL_AMD (  479): amd_launch.c: __nofork_processing(1138) > __nofork_processing, cmd: 0, pid: 717
12-12 08:27:45.186+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(717), cmd(0)
12-12 08:27:45.186+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: RESET State: PAUSED
12-12 08:27:45.186+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_reset(245) > app_appcore_reset
12-12 08:27:45.186+0900 W/W_HOME  (  717): main.c: _app_control(1726) > Service value : show_clock
12-12 08:27:45.186+0900 W/W_HOME  (  717): main.c: _app_control(1762) > Show clock operation
12-12 08:27:45.186+0900 W/W_HOME  (  717): gesture.c: _clock_show(228) > clock show
12-12 08:27:45.206+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[297347939] is expired.
12-12 08:27:45.211+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 297347939, next duetime: 1449876485
12-12 08:27:45.216+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:27:45.221+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:28:01 (UTC).
12-12 08:27:45.221+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:27:45.221+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-12 08:27:45.231+0900 W/W_HOME  (  717): gesture.c: _clock_show(243) > home raise
12-12 08:27:45.236+0900 E/W_HOME  (  717): gesture.c: gesture_win_aux_set(396) > wm.policy.win.do.not.use.deiconify.approve:-1
12-12 08:27:45.241+0900 W/W_HOME  (  717): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
12-12 08:27:45.241+0900 W/W_HOME  (  717): gesture.c: _clock_show(246) > home raise done
12-12 08:27:45.246+0900 W/W_HOME  (  717): gesture.c: _clock_show(253) > show clock
12-12 08:27:45.246+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-12 08:27:45.251+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02400003)
12-12 08:27:45.276+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-12 08:27:45.276+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1721) > [0, 2, 1]
12-12 08:27:45.296+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-12 08:27:45.296+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(297347939)
12-12 08:27:45.296+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:27:45.296+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:28:01 (UTC).
12-12 08:27:45.296+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:27:45.296+0900 W/ALARM_MANAGER(  475): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[297347939] is removed.
12-12 08:27:45.696+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:27:45.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:27:46.191+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-12 08:27:46.191+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-12 08:27:50.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:27:50.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:27:55.691+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:27:55.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:27:56.186+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-12 08:27:56.186+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:27:56.191+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-12 08:27:56.196+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-12 08:27:56.626+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-12 08:28:00.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:00.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:00.996+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-12 08:28:01.061+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-12 08:28:01.136+0900 W/ALARM_MANAGER(14859): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [1681431895]
12-12 08:28:01.136+0900 W/WATCH_CORE(14859): appcore-watch.c: __watch_core_ambient_tick(943) > state: 3
12-12 08:28:01.161+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[1681431895] is expired.
12-12 08:28:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1681431895, next duetime: 1449876541
12-12 08:28:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:28:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:29:01 (UTC).
12-12 08:28:01.176+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:28:01.181+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-12 08:28:01.201+0900 I/CAPI_NETWORK_WIFI(14859): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:28:01.211+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-12 08:28:01.241+0900 I/CAPI_NETWORK_WIFI(14859): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:28:01.321+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:28:01.321+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:28:05.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:05.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:10.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:10.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:15.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:15.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:20.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:20.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:25.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:25.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:30.691+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:30.756+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:35.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:35.671+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:40.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:40.746+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:42.021+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-12 08:28:42.026+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-12 08:28:45.681+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:45.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:50.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:50.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:55.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:28:55.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:28:56.226+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-12 08:28:56.226+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:28:56.231+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-12 08:28:56.231+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-12 08:28:56.631+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-12 08:29:00.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:00.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:00.996+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-12 08:29:01.061+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-12 08:29:01.136+0900 W/ALARM_MANAGER(14859): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [1681431895]
12-12 08:29:01.136+0900 W/WATCH_CORE(14859): appcore-watch.c: __watch_core_ambient_tick(943) > state: 3
12-12 08:29:01.146+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[1681431895] is expired.
12-12 08:29:01.151+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1681431895, next duetime: 1449876601
12-12 08:29:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:29:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:30:01 (UTC).
12-12 08:29:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:29:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-12 08:29:01.201+0900 I/CAPI_NETWORK_WIFI(14859): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:29:01.211+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-12 08:29:01.236+0900 I/CAPI_NETWORK_WIFI(14859): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:29:01.326+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:29:01.326+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:29:05.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:05.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:10.691+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:10.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:15.691+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:15.756+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:20.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:20.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:25.701+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:25.771+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:30.616+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:30.691+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:35.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:35.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:40.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:40.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:42.021+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-12 08:29:42.026+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-12 08:29:45.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:45.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:50.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:50.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:55.701+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:29:55.766+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:29:56.191+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-12 08:29:56.196+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:29:56.201+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-12 08:29:56.201+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-12 08:29:56.626+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-12 08:30:00.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:00.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:00.996+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-12 08:30:01.061+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-12 08:30:01.136+0900 W/ALARM_MANAGER(14859): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [1681431895]
12-12 08:30:01.136+0900 W/WATCH_CORE(14859): appcore-watch.c: __watch_core_ambient_tick(943) > state: 3
12-12 08:30:01.146+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[1681431895] is expired.
12-12 08:30:01.151+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1681431895, next duetime: 1449876661
12-12 08:30:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:30:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:31:01 (UTC).
12-12 08:30:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:30:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-12 08:30:01.206+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-12 08:30:01.211+0900 I/CAPI_NETWORK_WIFI(14859): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:30:01.246+0900 I/CAPI_NETWORK_WIFI(14859): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:30:01.321+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:30:01.321+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:30:05.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:05.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:10.691+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:10.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:15.696+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:15.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:20.681+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:20.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:25.696+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:25.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:30.691+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:30.756+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:35.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:35.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:40.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:40.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:42.021+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-12 08:30:42.026+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-12 08:30:42.041+0900 I/RESOURCED(  480): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-12 08:30:45.696+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:45.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:50.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:50.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:55.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:30:55.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:30:56.226+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-12 08:30:56.226+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:30:56.231+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-12 08:30:56.231+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-12 08:30:56.621+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-12 08:31:00.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:00.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:31:00.996+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-12 08:31:01.061+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-12 08:31:01.136+0900 W/ALARM_MANAGER(14859): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [1681431895]
12-12 08:31:01.136+0900 W/WATCH_CORE(14859): appcore-watch.c: __watch_core_ambient_tick(943) > state: 3
12-12 08:31:01.146+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[1681431895] is expired.
12-12 08:31:01.151+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1681431895, next duetime: 1449876721
12-12 08:31:01.156+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:31:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:32:01 (UTC).
12-12 08:31:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:31:01.171+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-12 08:31:01.206+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-12 08:31:01.211+0900 I/CAPI_NETWORK_WIFI(14859): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:31:01.241+0900 I/CAPI_NETWORK_WIFI(14859): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:31:01.316+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:31:01.316+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:31:05.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:05.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:31:10.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:10.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:31:15.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:15.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:31:20.681+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:20.706+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:31:22.706+0900 E/PKGMGR_SERVER(16026): pkgmgr-server.c: main(2126) > package manager server start
12-12 08:31:22.826+0900 E/PKGMGR_SERVER(16026): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1197332065], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-12 08:31:22.831+0900 E/PKGMGR_SERVER(16027): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-12 08:31:22.836+0900 E/PKGMGR  (16019): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-12 08:31:22.911+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:22.916+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14859
12-12 08:31:22.921+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-12 08:31:22.926+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 5
12-12 08:31:22.926+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(14859), cmd(4)
12-12 08:31:22.931+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 22
12-12 08:31:22.931+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(884) > app status : 4
12-12 08:31:22.931+0900 W/CAPI_WATCH_APPLICATION(14859): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-12 08:31:22.931+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:22.931+0900 W/WATCH_CORE(14859): appcore-watch.c: __widget_destroy(992) > widget_destory
12-12 08:31:22.931+0900 E/WIDGET_PROVIDER_APP(14859): client.c: client_fini(1175) > Provider is not initialized
12-12 08:31:22.941+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14859
12-12 08:31:22.941+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 4
12-12 08:31:23.046+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:23.066+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-12 08:31:23.096+0900 E/PKGMGR_SERVER(16027): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-12 08:31:23.146+0900 E/AUL_AMD (  479): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-12 08:31:23.146+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(14859), cmd(4)
12-12 08:31:23.151+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-12 08:31:23.186+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-12 08:31:23.186+0900 E/PKGMGR_SERVER(16026): pkgmgr-server.c: sighandler(445) > child NORMAL exit [16027]
12-12 08:31:23.206+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-12 08:31:23.206+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-12 08:31:23.206+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 698
12-12 08:31:23.306+0900 E/RESOURCED(  480): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-12 08:31:23.306+0900 E/RESOURCED(  480): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-12 08:31:23.311+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(2026) > pad pid(-5)
12-12 08:31:23.311+0900 W/AUL_PAD ( 1168): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-12 08:31:23.311+0900 W/AUL_PAD ( 1168): launchpad.c: __send_result_to_caller(265) > Check app launching
12-12 08:31:23.356+0900 I/CAPI_WATCH_APPLICATION(15563): watch_app_main.c: watch_app_main(382) > watch_app_main
12-12 08:31:23.381+0900 E/TBM     (15563): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-12 08:31:23.416+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 14859
12-12 08:31:23.451+0900 W/WATCH_CORE(15563): appcore-watch.c: __widget_create(958) > widget_create
12-12 08:31:23.456+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [5251.320801] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_5251.320801.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263146:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-12 08:31:23.456+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[5251.320801] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_5251.320801.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263146:4] gbar_fname[]
12-12 08:31:23.471+0900 E/WIDGET_VIEWER(15061): client.c: master_created(1712) > [SECURE_LOG] [5251.320801] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_5251.320801.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263146:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-12 08:31:23.471+0900 E/WIDGET_VIEWER(15061): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[5251.320801] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_5251.320801.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263146:4] gbar_fname[]
12-12 08:31:23.486+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-12 08:31:23.486+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-12 08:31:23.486+0900 E/WIDGET_VIEWER(15061): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-12 08:31:23.486+0900 E/WIDGET_EVAS(15061): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-12 08:31:23.626+0900 I/CAPI_NETWORK_WIFI(15563): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:31:23.636+0900 I/CAPI_NETWORK_WIFI(15563): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:31:23.811+0900 W/WATCH_CORE(15563): appcore-watch.c: __widget_create(976) > widget_create done
12-12 08:31:23.846+0900 I/WATCH_CORE(15563): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-12 08:31:23.846+0900 I/WATCH_CORE(15563): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-12 08:31:23.846+0900 I/WATCH_CORE(15563): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-12 08:31:23.906+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:31:23.906+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:31:23.911+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:31:23.911+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:31:23.921+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:31:23.921+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:31:24.416+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-12 08:31:24.416+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-12 08:31:24.431+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:24.441+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15563
12-12 08:31:24.441+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-12 08:31:24.651+0900 I/AUL_PAD (16058): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-12 08:31:25.001+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-12 08:31:25.036+0900 E/PKGMGR_SERVER(16026): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-12 08:31:25.036+0900 E/PKGMGR_SERVER(16026): pkgmgr-server.c: main(2180) > package manager server terminated.
12-12 08:31:25.606+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:25.626+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:31:30.606+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:30.621+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:31:35.606+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:35.621+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:31:35.881+0900 E/PKGMGR  (16183): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-12 08:31:36.061+0900 E/PKGMGR_SERVER(16185): pkgmgr-server.c: main(2126) > package manager server start
12-12 08:31:36.181+0900 E/PKGMGR_SERVER(16185): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1184007277], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-1184007277' '-r' 'org.reolab.blackandwhite'], cookie=[pczoHfyiE27aviivu6O+f0Ir+5M=], backend_flag=[0]
12-12 08:31:36.181+0900 E/PKGMGR  (16185): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-12 08:31:36.181+0900 E/PKGMGR_SERVER(16185): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-12 08:31:36.186+0900 E/PKGMGR  (16183): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[161830002]
12-12 08:31:36.196+0900 E/PKGMGR_SERVER(16186): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-12 08:31:36.361+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-12 08:31:36.371+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-12 08:31:36.386+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-12 08:31:36.391+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-12 08:31:37.001+0900 E/PKGMGR_CERT(16186): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-12 08:31:37.011+0900 E/PKGMGR_CERT(16186): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 96
12-12 08:31:37.011+0900 E/PKGMGR_CERT(16186): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 96
12-12 08:31:37.011+0900 E/PKGMGR_CERT(16186): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 4
12-12 08:31:37.011+0900 E/PKGMGR_CERT(16186): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 4
12-12 08:31:37.011+0900 E/PKGMGR_CERT(16186): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 4
12-12 08:31:37.011+0900 E/PKGMGR_CERT(16186): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 4
12-12 08:31:37.021+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-12 08:31:37.031+0900 E/PKGMGR_CERT(16186): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-12 08:31:38.031+0900 E/PKGMGR_SERVER(16185): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-12 08:31:38.891+0900 E/rpm-installer(16186): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-12 08:31:40.031+0900 E/PKGMGR_SERVER(16185): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-12 08:31:40.606+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:31:40.616+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:31:41.941+0900 E/PKGMGR_SERVER(16185): pkgmgr-server.c: sighandler(445) > child NORMAL exit [16186]
12-12 08:31:41.946+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-12 08:31:41.966+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-12 08:31:41.966+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-12 08:31:41.981+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-12 08:31:41.981+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-12 08:31:41.991+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-12 08:31:41.991+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-12 08:31:41.991+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-12 08:31:41.991+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-12 08:31:42.006+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-12 08:31:42.031+0900 E/PKGMGR_SERVER(16185): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-12 08:31:42.031+0900 E/PKGMGR_SERVER(16185): pkgmgr-server.c: main(2180) > package manager server terminated.
12-12 08:31:42.061+0900 E/APPS    (  717): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-12 08:31:42.161+0900 E/PKGMGR_INFO(  476): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-12 08:31:42.481+0900 W/CRASH_MANAGER(16198): worker.c: worker_job(1199) > 1115563626c61144987670
