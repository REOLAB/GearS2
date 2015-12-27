S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 10427
Date: 2015-12-11 20:41:58+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xdf0

Register Information
r0   = 0x00000de4, r1   = 0x0000000d
r2   = 0x00000c44, r3   = 0x41553194
r4   = 0x00000de4, r5   = 0x00000000
r6   = 0x414e9204, r7   = 0x414dd608
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeddec4c, sp   = 0xbeddec00
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     24948 KB
Buffers:     32988 KB
Cached:     149012 KB
VmPeak:     119664 KB
VmSize:     119152 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15980 KB
VmRSS:       15980 KB
VmData:      62624 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 10427 TID = 10427
10427 11095 11103 

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
40d20000 40d30000 rw-p [heap]
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
43757000 43f56000 rw-p [stack:11095]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:11103]
bedbf000 bede0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10427)
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
LARM_MANAGER(  478): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-11 20:34:24.204+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.229+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.249+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.269+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.284+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.294+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.294+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1449835464, Fri Dec 11 21:04:24 2015
12-11 20:34:24.294+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1714719876, next duetime: 1449835464
12-11 20:34:24.294+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(1714719876)
12-11 20:34:24.294+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449841380), due_time(1449835464)
12-11 20:34:24.294+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-11 20:34:24.294+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 12:04:24 (UTC).
12-11 20:34:24.294+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-11 20:34:24.304+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(1714719876)
12-11 20:34:24.304+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-11 20:34:24.304+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 13:43:00 (UTC).
12-11 20:34:24.304+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-11 20:34:24.304+0900 W/ALARM_MANAGER(  478): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[1714719876] is removed.
12-11 20:34:24.324+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.339+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.349+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.364+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.374+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.385+0900 I/AUL     (  478): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/sbin/connmand, ret : 0
12-11 20:34:24.390+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1449837264, Fri Dec 11 21:34:24 2015
12-11 20:34:24.390+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1714719876, next duetime: 1449837264
12-11 20:34:24.390+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(1714719876)
12-11 20:34:24.390+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449841380), due_time(1449837264)
12-11 20:34:24.390+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-11 20:34:24.390+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 12:34:24 (UTC).
12-11 20:34:24.390+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-11 20:35:00.344+0900 I/SHealth_Service( 1049): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(628) > [1;35mlength of Array [1][0;m
12-11 20:35:00.379+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:35:00.470+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 20:35:00.470+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:35:00.470+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 20:35:00.470+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 20:35:00.480+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 20:35:00.480+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:35:00.480+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 20:35:00.480+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 20:35:00.485+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 20:35:00.485+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:35:00.485+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 20:35:00.485+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 20:35:00.485+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 20:35:00.490+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:35:00.490+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 20:35:00.490+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 20:35:00.490+0900 I/CAPI_WIDGET_APPLICATION(  779): widget_app.c: __provider_update_cb(279) > received updating signal
12-11 20:35:00.520+0900 W/SHealth_Common( 1049): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
12-11 20:35:00.550+0900 W/SHealth_Common( 1049): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
12-11 20:35:00.580+0900 I/CAPI_WIDGET_APPLICATION(  779): widget_app.c: __provider_update_cb(279) > received updating signal
12-11 20:35:00.585+0900 I/HealthDataService( 1070): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
12-11 20:35:00.600+0900 I/healthData( 1049): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
12-11 20:35:00.600+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:35:13.079+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:35:13.079+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:36:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:36:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:37:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:37:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:38:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:38:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:39:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:39:13.130+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:40:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:40:13.129+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:40:13.139+0900 I/RESOURCED(  481): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] cpu cache is empty
12-11 20:40:13.184+0900 I/RESOURCED(  481): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-11 20:41:01.760+0900 E/WMS     (  480): wms_event_handler.c: wms_event_handler_routine(19932) > 
12-11 20:41:01.760+0900 E/WMS     (  480): ==========
12-11 20:41:01.760+0900 E/WMS     (  480): ##WMS RECEIVED : mgr_only_sync_date_time_req
12-11 20:41:01.760+0900 E/WMS     (  480): ==========
12-11 20:41:01.760+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_only_sync_date_time_req(11163) > datetime epoch: 1449834062134
12-11 20:41:01.765+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_send_time_sync_req(7016) > t1 [1449834061767]
12-11 20:41:01.775+0900 E/WMS     (  480): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-11 20:41:01.775+0900 E/WMS     (  480): ==========
12-11 20:41:01.775+0900 E/WMS     (  480): ##WMS SEND : mgr_time_req
12-11 20:41:01.775+0900 E/WMS     (  480): ==========
12-11 20:41:01.775+0900 E/WMS     (  480): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 50 MAX Buffer Size: 61440
12-11 20:41:01.780+0900 E/WMS     (  480): wms_event_handler.c: wms_event_handler_routine(19948) > [mgr_only_sync_date_time_req] handler success.
12-11 20:41:01.855+0900 E/WMS     (  480): wms_event_handler.c: wms_event_handler_routine(19932) > 
12-11 20:41:01.855+0900 E/WMS     (  480): ==========
12-11 20:41:01.855+0900 E/WMS     (  480): ##WMS RECEIVED : mgr_sync_time_1224_time
12-11 20:41:01.855+0900 E/WMS     (  480): ==========
12-11 20:41:01.855+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_sync_time_1224_time(11250) > data : 24
12-11 20:41:01.865+0900 W/W_HOME  (  714): util_time.c: _util_time_vconf_changed_cb(619) > tick by 2
12-11 20:41:01.870+0900 E/WMS     (  480): wms_event_handler.c: wms_event_handler_routine(19948) > [mgr_sync_time_1224_time] handler success.
12-11 20:41:01.875+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1021): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
12-11 20:41:01.930+0900 E/WMS     (  480): wms_event_handler.c: wms_event_handler_routine(19932) > 
12-11 20:41:01.930+0900 E/WMS     (  480): ==========
12-11 20:41:01.930+0900 E/WMS     (  480): ##WMS RECEIVED : mgr_clocks_get_datestring_req
12-11 20:41:01.930+0900 E/WMS     (  480): ==========
12-11 20:41:01.930+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_clocks_get_datestring_req(17240) > skeleton[EEE, MMMM d], bestpattern[true], timestamp[1449834062140]
12-11 20:41:01.935+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 20:41:01.935+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 20:41:01.935+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 20:41:01.935+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 20:41:01.935+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 20:41:01.935+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 20:41:01.935+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.watchface-service:watchface-service::localport]
12-11 20:41:01.935+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 20:41:01.935+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 20:41:01.935+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 20:41:01.935+0900 E/WMS     (  480): wms_event_handler.c: wms_event_handler_routine(19948) > [mgr_clocks_get_datestring_req] handler success.
12-11 20:41:01.955+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1021): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
12-11 20:41:01.955+0900 I/watchface-service( 1021): watchface-service-app.c: __watchface_service_timeformat_changed_cb(129) > WFS_START>>>>>>>>Begin.
12-11 20:41:01.955+0900 I/watchface-service( 1021): watchface-service-app.c: __watchface_service_timeformat_changed_cb(135) > 
12-11 20:41:01.960+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1021): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
12-11 20:41:01.960+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1021): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:41:01.960+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1021): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
12-11 20:41:01.960+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1021): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
12-11 20:41:01.960+0900 E/watchface-common-util( 1021): common-util-ipc-control.cpp: OnMessageReceived(272) > Message port id[1] Remote app id[com.samsung.w-manager-service] Remote port[] Trusted port[0]
12-11 20:41:01.960+0900 I/watchface-service( 1021): watchface-service-msg-control.c: watchface_msg_control_trusted_message_cb(1090) > WFS_START>>>>>>>>Begin.
12-11 20:41:01.970+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 11->11
12-11 20:41:01.980+0900 E/BASE_UTILS( 1021): utils_i18n_udate.c: i18n_udate_format_date(52) > err(-22020089): A result would not fit in the supplied buffer
12-11 20:41:01.980+0900 I/watchface-service( 1021): watchface-service-msg-control.c: watchface_msg_control_trusted_message_cb(1150) > formattedString = [12월 11일 (금)]
12-11 20:41:01.980+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 20:41:01.980+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 20:41:01.980+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 20:41:01.980+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 20:41:01.980+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 20:41:01.980+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 20:41:01.980+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-manager-service:w-manager-service::localport]
12-11 20:41:01.980+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-11 20:41:01.980+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-11 20:41:01.980+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 20:41:01.980+0900 E/WMS     (  480): wms_msg_port.c: __wms_msg_port_message_cb(53) > type[watch-icu-convert]
12-11 20:41:01.980+0900 E/WMS     (  480): wms_event_handler.c: wms_event_handler_send_mgr_clocks_get_datestring_res(9293) > 
12-11 20:41:01.985+0900 E/WMS     (  480): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-11 20:41:01.985+0900 E/WMS     (  480): ==========
12-11 20:41:01.985+0900 E/WMS     (  480): ##WMS SEND : mgr_clocks_get_datestring_res
12-11 20:41:01.985+0900 E/WMS     (  480): ==========
12-11 20:41:01.985+0900 E/WMS     (  480): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 86 MAX Buffer Size: 61440
12-11 20:41:02.200+0900 E/WMS     (  480): wms_event_handler.c: wms_event_handler_routine(19932) > 
12-11 20:41:02.200+0900 E/WMS     (  480): ==========
12-11 20:41:02.200+0900 E/WMS     (  480): ##WMS RECEIVED : mgr_time_res
12-11 20:41:02.200+0900 E/WMS     (  480): ==========
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16569) > time sync mode : NTP (autotimesync[1] opt_ntp[1] ntp_available[1])
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16591) > opt_time_test_mod[0] opt_timesync[1] opt_ntp[1] opt_logging[0] opt_interval[0]
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16605) > =================================================
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16606) > t1[1449834061767] t2[1449834062845] t3[1449834062900] ntp_t2[1449834063481] ntp_t3[1449834063536] t4[1449834062207]
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16607) > -------------------------------------------------
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16608) > TimeOff Mobile(636): NTP time(1449834063536) - Mobile's system time(1449834062900)
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16609) > TimeOff Gear(1521): NTP time(1449834063728) - Gear's system time(1449834062207)
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16610) > TimeOff Mobile-Gear(-885)
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16611) > transmission delay(192) roundtrip(440)
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16612) > =================================================
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16622) > system t3 [2015-12-11 20:41:02 Fri KST]
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16627) > ntp t3 [2015-12-11 20:41:03 Fri KST]
12-11 20:41:02.205+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_set_datetime(3719) > requested [1449834063]sec[728000000]nsec, received[1449834062]sec[207347196]nsec
12-11 20:41:04.009+0900 W/ALARM_MANAGER(  478): alarm-manager.c: alarm_manager_alarm_set_time_with_propagation_delay(1971) > [TIMESTAMP]Current time(1449834062.256028585), New time(1449834063.728000000), Real Newtime(1449834064), diff_time(2.000000)
12-11 20:41:04.034+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(375) > 14:49:0. duetime = 1449812940, isdst = 0
12-11 20:41:04.034+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(378) > duetime is less than or equal to current time. current_dst = 0
12-11 20:41:04.034+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(404) > before_dst = 0, 14:49:0. duetime = 1449812940
12-11 20:41:04.034+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(438) > after_dst = 0, 14:49:0. duetime = 1449899340
12-11 20:41:04.034+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(447) > Final due_time = 1449899340
12-11 20:41:04.034+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 296261155, next duetime: 1449899340
12-11 20:41:04.034+0900 W/W_HOME  (  714): util_time.c: _util_time_vconf_changed_cb(619) > tick by 1
12-11 20:41:04.034+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1449846000, Sat Dec 12 00:00:00 2015
12-11 20:41:04.034+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 559332908, next duetime: 1449846000
12-11 20:41:04.064+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(375) > 22:43:0. duetime = 1449841380, isdst = 0
12-11 20:41:04.064+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(404) > before_dst = 0, 22:43:0. duetime = 1449841380
12-11 20:41:04.064+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(438) > after_dst = 0, 22:43:0. duetime = 1449841380
12-11 20:41:04.064+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(447) > Final due_time = 1449841380
12-11 20:41:04.064+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 653505324, next duetime: 1449841380
12-11 20:41:04.064+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(375) > 9:34:0. duetime = 1449794040, isdst = 0
12-11 20:41:04.064+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(378) > duetime is less than or equal to current time. current_dst = 0
12-11 20:41:04.064+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(404) > before_dst = 0, 9:34:0. duetime = 1449794040
12-11 20:41:04.064+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(438) > after_dst = 0, 9:34:0. duetime = 1449880440
12-11 20:41:04.064+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(447) > Final due_time = 1449880440
12-11 20:41:04.064+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 876785042, next duetime: 1449880440
12-11 20:41:04.099+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1229922925, next duetime: 1449835202
12-11 20:41:04.099+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(375) > 22:44:0. duetime = 1449841440, isdst = 0
12-11 20:41:04.099+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(404) > before_dst = 0, 22:44:0. duetime = 1449841440
12-11 20:41:04.099+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(438) > after_dst = 0, 22:44:0. duetime = 1449841440
12-11 20:41:04.099+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(447) > Final due_time = 1449841440
12-11 20:41:04.099+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1402701349, next duetime: 1449841440
12-11 20:41:04.104+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(375) > 20:30:0. duetime = 1449833400, isdst = 0
12-11 20:41:04.104+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(378) > duetime is less than or equal to current time. current_dst = 0
12-11 20:41:04.104+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(404) > before_dst = 0, 20:30:0. duetime = 1449833400
12-11 20:41:04.104+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(438) > after_dst = 0, 20:30:0. duetime = 1449919800
12-11 20:41:04.104+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_weekly(447) > Final due_time = 1449919800
12-11 20:41:04.104+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1896333612, next duetime: 1449919800
12-11 20:41:04.109+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1449837266, Fri Dec 11 21:34:26 2015
12-11 20:41:04.109+0900 W/ALARM_MANAGER(  478): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1714719876, next duetime: 1449837266
12-11 20:41:04.114+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-11 20:41:04.114+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 12:34:26 (UTC).
12-11 20:41:04.114+0900 W/ALARM_MANAGER(  478): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-11 20:41:04.129+0900 E/WMS     (  480): wms_event_handler.c: handle_mgr_time_res(16642) > timezone flag[0]
12-11 20:41:04.129+0900 E/WMS     (  480): wms_event_handler.c: wms_event_handler_routine(19948) > [mgr_time_res] handler success.
12-11 20:41:04.154+0900 E/weather-widget(  783): WidgetMain.cpp: RequestUpdateForEachInstances(158) > [0;40;31mhomerun[0;m
12-11 20:41:04.169+0900 W/APPS    (  714): apps_main.c: _time_changed_cb(295) >  date : 11->11
12-11 20:41:04.169+0900 W/wnotib  (  714): w-notification-board-broker-main.c: _wnotib_system_time_changed_cb(126) > New timezone: Asia/Seoul
12-11 20:41:04.169+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 8
12-11 20:41:04.169+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4659) > W_NOTIFICATION_BOARD_PANEL_PARAM_TYPE_SYSTEM_EVENT, event_type: 2
12-11 20:41:04.174+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 8
12-11 20:41:04.174+0900 E/EFL     (  714): <714> elm_main.c:1162 elm_object_part_text_set() safety check failed: obj == NULL
12-11 20:41:04.184+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1049): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=16
12-11 20:41:04.189+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1049): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 16, key = 16, type = 1
12-11 20:41:04.194+0900 I/SHealth_Service( 1049): ServiceMainTimer.cpp: OnSystemTimeChanged(68) > [1;35m[0;m
12-11 20:41:04.194+0900 I/SHealth_Service( 1049): ServiceMainTimer.cpp: RestartDailyTimer(39) > [1;35m ###[0;m
12-11 20:41:04.194+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1049): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 20:41:04.204+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1049): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:41:04.204+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1049): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=15
12-11 20:41:04.204+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1049): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 15, key = 15, type = 0
12-11 20:41:04.219+0900 E/weather-widget(  783): WidgetMain.cpp: UpdateWidgetInstance(1673) > [0;40;31mUpdateWidgetInstance[0;m
12-11 20:41:04.219+0900 E/weather-widget(  783): WidgetMain.cpp: DeleteUpdateTimerData(266) > [0;40;31m[DeleteUpdateTimerData(): 266] (size < 1) [return][0;m
12-11 20:41:04.219+0900 I/CAPI_WIDGET_APPLICATION(  783): widget_app.c: __provider_update_cb(279) > received updating signal
12-11 20:41:04.219+0900 I/SHealth_Service( 1049): SHealthServiceController.cpp: OnSystemTimeChanged(628) > [1;35mtimezone is changed [Asia/Seoul][0;m
12-11 20:41:04.269+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 20:41:04.304+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 20:41:04.304+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:41:04.304+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 20:41:04.304+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 20:41:04.309+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 20:41:04.309+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:41:04.309+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 20:41:04.309+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 20:41:04.309+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 20:41:04.314+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:41:04.314+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 20:41:04.314+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 20:41:04.314+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-11 20:41:04.314+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 20:41:04.314+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-11 20:41:04.314+0900 E/TIZEN_N_SYSTEM_SETTINGS(  779): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-11 20:41:04.319+0900 I/CAPI_WIDGET_APPLICATION(  779): widget_app.c: __provider_update_cb(279) > received updating signal
12-11 20:41:04.344+0900 W/SHealth_Common( 1049): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
12-11 20:41:04.374+0900 W/SHealth_Common( 1049): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
12-11 20:41:04.399+0900 I/CAPI_WIDGET_APPLICATION(  779): widget_app.c: __provider_update_cb(279) > received updating signal
12-11 20:41:04.404+0900 I/HealthDataService( 1070): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
12-11 20:41:04.424+0900 I/healthData( 1049): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
12-11 20:41:04.524+0900 E/weather-widget(  783): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1556) > [0;40;31mUpdateWidgetInstanceTimerCb[0;m
12-11 20:41:04.599+0900 E/weather-widget(  783): WidgetMain.cpp: UpdateWidgetInstanceTimerCb(1597) > [0;40;31mcontent is NULL[0;m
12-11 20:41:04.619+0900 E/weather-widget(  783): WidgetView.cpp: CreateCityNameLayout(543) > [0;40;31mlanguageCode : ko_KR.UTF-8[0;m
12-11 20:41:04.694+0900 E/weather-widget(  783): WidgetView.cpp: UpdateViewPage(299) > [0;40;31mUpdateViewPage locationId : 4111700000[0;m
12-11 20:41:04.804+0900 E/weather-widget(  783): WidgetView.cpp: SetBackgroundImage(155) > [0;40;31mbackground color code:AO096[0;m
12-11 20:41:04.809+0900 E/weather-widget(  783): WidgetView.cpp: SetBackgroundImage(165) > [0;40;31mbackground image color code:AO0951[0;m
12-11 20:41:04.824+0900 W/LOCATION(  783): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
12-11 20:41:04.829+0900 E/weather-common(  783): Location.cpp: IsLocationServiceAvailable(297) > [0;40;31menabled : 1[0;m
12-11 20:41:04.839+0900 E/weather-widget(  783): WidgetMain.cpp: CheckAndRequestAutoRefresh(1169) > [0;40;31mnow : 1449834064, lastRefreshedTime : 1449830086, refreshInterval : 10800[0;m
12-11 20:41:04.839+0900 E/weather-widget(  783): WidgetMain.cpp: CheckAndRequestAutoRefresh(1185) > [0;40;31mwe don't need to refresh[0;m
12-11 20:41:04.839+0900 E/EFL     (  783): edje<783> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'timeSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-11 20:41:04.849+0900 E/EFL     (  783): edje<783> edje_util.c:3770 edje_object_size_min_restricted_calc() group highLowTemperature has a non-fixed part 'low'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-11 20:41:04.849+0900 E/EFL     (  783): edje<783> edje_util.c:3770 edje_object_size_min_restricted_calc() group widgetViewPage has a non-fixed part 'weatherIconSwallow'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-11 20:41:14.599+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 20:41:14.599+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 20:41:37.449+0900 E/PKGMGR_SERVER(11088): pkgmgr-server.c: main(2126) > package manager server start
12-11 20:41:37.519+0900 E/PKGMGR_SERVER(11088): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-832926706], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 20:41:37.524+0900 E/PKGMGR_SERVER(11090): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 20:41:37.529+0900 E/PKGMGR  (11082): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 20:41:37.599+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 20:41:37.609+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10274
12-11 20:41:37.609+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 20:41:37.614+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 20:41:37.619+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(10274), cmd(4)
12-11 20:41:37.619+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 20:41:37.619+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(884) > app status : 4
12-11 20:41:37.619+0900 W/CAPI_WATCH_APPLICATION(10274): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 20:41:37.619+0900 W/WATCH_CORE(10274): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 20:41:37.619+0900 E/WIDGET_PROVIDER_APP(10274): client.c: client_fini(1175) > Provider is not initialized
12-11 20:41:37.624+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 20:41:37.634+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 20:41:37.639+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10274
12-11 20:41:37.744+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 20:41:37.814+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 20:41:37.854+0900 E/AUL_AMD (  475): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 20:41:37.854+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(10274), cmd(4)
12-11 20:41:37.864+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 20:41:37.929+0900 E/PKGMGR_SERVER(11090): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 20:41:37.929+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:41:37.959+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:41:37.959+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 20:41:37.959+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 703
12-11 20:41:38.044+0900 E/PKGMGR_SERVER(11088): pkgmgr-server.c: sighandler(445) > child NORMAL exit [11090]
12-11 20:41:38.099+0900 E/RESOURCED(  481): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-11 20:41:38.099+0900 E/RESOURCED(  481): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 20:41:38.104+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 20:41:38.104+0900 W/AUL_PAD ( 1208): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 20:41:38.104+0900 W/AUL_PAD ( 1208): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 20:41:38.144+0900 I/CAPI_WATCH_APPLICATION(10427): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 20:41:38.169+0900 E/TBM     (10427): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 20:41:38.204+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 10274
12-11 20:41:38.239+0900 W/WATCH_CORE(10427): appcore-watch.c: __widget_create(958) > widget_create
12-11 20:41:38.244+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1712) > [SECURE_LOG] [14.824063] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263160:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 20:41:38.244+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[14.824063] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263160:4] gbar_fname[]
12-11 20:41:38.264+0900 E/WIDGET_VIEWER(  714): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 20:41:38.264+0900 E/WIDGET_EVAS(  714): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 20:41:38.394+0900 I/CAPI_NETWORK_WIFI(10427): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 20:41:38.409+0900 I/CAPI_NETWORK_WIFI(10427): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 20:41:38.574+0900 E/blackandwhite(10427): blackandwhite.c: update_watch(149) > colorT : 1
12-11 20:41:38.594+0900 W/WATCH_CORE(10427): appcore-watch.c: __widget_create(976) > widget_create done
12-11 20:41:38.624+0900 I/WATCH_CORE(10427): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 20:41:38.624+0900 I/WATCH_CORE(10427): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 20:41:38.624+0900 I/WATCH_CORE(10427): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 20:41:39.209+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 20:41:39.209+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 20:41:39.219+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 20:41:39.229+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 10427
12-11 20:41:39.229+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 20:41:39.439+0900 I/AUL_PAD (11122): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 20:41:39.619+0900 W/AUL_AMD (  475): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 20:41:40.034+0900 E/PKGMGR_SERVER(11088): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 20:41:40.034+0900 E/PKGMGR_SERVER(11088): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 20:41:51.819+0900 E/PKGMGR  (11220): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 20:41:52.019+0900 E/PKGMGR_SERVER(11222): pkgmgr-server.c: main(2126) > package manager server start
12-11 20:41:52.129+0900 E/PKGMGR_SERVER(11222): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-818396459], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-818396459' '-r' 'org.reolab.blackandwhite'], cookie=[uH8BgXDilQQznNfBvBSKJ0YnnOI=], backend_flag=[0]
12-11 20:41:52.134+0900 E/PKGMGR  (11222): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 20:41:52.134+0900 E/PKGMGR_SERVER(11222): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 20:41:52.139+0900 E/PKGMGR  (11220): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[112200002]
12-11 20:41:52.139+0900 E/PKGMGR_SERVER(11223): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 20:41:52.309+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 20:41:52.319+0900 W/AUL_AMD (  475): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 20:41:52.334+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 20:41:52.334+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 20:41:52.959+0900 E/PKGMGR_CERT(11223): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 20:41:52.974+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 20:41:52.979+0900 E/PKGMGR_CERT(11223): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
12-11 20:41:52.979+0900 E/PKGMGR_CERT(11223): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
12-11 20:41:52.984+0900 E/PKGMGR_CERT(11223): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-11 20:41:52.984+0900 E/PKGMGR_CERT(11223): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-11 20:41:52.984+0900 E/PKGMGR_CERT(11223): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-11 20:41:52.994+0900 E/PKGMGR_CERT(11223): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-11 20:41:53.014+0900 E/PKGMGR_CERT(11223): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 20:41:54.034+0900 E/PKGMGR_SERVER(11222): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 20:41:54.839+0900 E/rpm-installer(11223): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-11 20:41:56.034+0900 E/PKGMGR_SERVER(11222): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 20:41:57.899+0900 E/PKGMGR_SERVER(11222): pkgmgr-server.c: sighandler(445) > child NORMAL exit [11223]
12-11 20:41:57.914+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 20:41:57.959+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-11 20:41:57.959+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-11 20:41:58.014+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-11 20:41:58.014+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-11 20:41:58.014+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-11 20:41:58.014+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-11 20:41:58.034+0900 E/PKGMGR_SERVER(11222): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 20:41:58.034+0900 E/PKGMGR_SERVER(11222): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 20:41:58.069+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-11 20:41:58.134+0900 E/APPS    (  714): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-11 20:41:58.154+0900 E/PKGMGR_INFO(  479): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-11 20:41:58.494+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 20:41:58.509+0900 E/AUL_AMD (  475): amd_request.c: __app_process_by_pid(193) > pid(10427) is dead. cmd(4) is canceled
12-11 20:41:58.534+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 20:41:58.629+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:41:58.799+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 20:41:58.804+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 20:41:58.804+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 703
12-11 20:41:59.139+0900 E/RESOURCED(  481): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-11 20:41:59.139+0900 E/RESOURCED(  481): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 20:41:59.139+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 20:41:59.144+0900 W/AUL_PAD ( 1208): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 20:41:59.144+0900 W/AUL_PAD ( 1208): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 20:41:59.189+0900 W/CRASH_MANAGER(11231): worker.c: worker_job(1199) > 1110427626c61144983411
