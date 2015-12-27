S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 27641
Date: 2015-12-11 23:10:28+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x190

Register Information
r0   = 0x00000184, r1   = 0x0000000d
r2   = 0x00000004, r3   = 0x41453194
r4   = 0x00000184, r5   = 0x00000000
r6   = 0x41f42cdc, r7   = 0x41f1be08
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbea8ec4c, sp   = 0xbea8ec00
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   489992 KB
MemFree:     15204 KB
Buffers:     28264 KB
Cached:     108992 KB
VmPeak:     111680 KB
VmSize:     111168 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16088 KB
VmRSS:       16088 KB
VmData:      54640 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 27641 TID = 27641
27641 326 339 

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
41803000 41810000 r-xp /usr/lib/libalarm.so.0.0.0
41819000 41956000 r-xp /usr/lib/libicui18n.so.51.1
41966000 41a4a000 r-xp /usr/lib/libicuuc.so.51.1
41a5f000 41a65000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41a6d000 41a73000 r-xp /usr/lib/libwidget.so.1.0.0
41a7c000 41a81000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a89000 41ac0000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41ac9000 41ae2000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41aeb000 41b15000 r-xp /usr/lib/libnfc.so.1.0.0
41b1e000 41b4f000 r-xp /usr/lib/libmdm.so.1.1.85
41b57000 41b6d000 r-xp /usr/lib/libnetwork.so.0.0.0
41b76000 41b7b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
41b83000 41b8c000 r-xp /usr/lib/libcom-core.so.0.0.1
41b95000 41ba1000 r-xp /usr/lib/libwidget_service.so.1.0.0
41ba9000 41bb2000 r-xp /usr/lib/libwidget_provider.so.1.0.0
41bbb000 41bc1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
41bc9000 41bd1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
41bd9000 41c07000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
41c13000 41c1b000 r-xp /usr/lib/libdrm.so.2.4.0
41c23000 41c25000 r-xp /usr/lib/libdri2.so.0.0.0
41c2d000 41c34000 r-xp /usr/lib/libtbm.so.1.0.0
41c3c000 41c56000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
41c5f000 41c66000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
41c6f000 41c71000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
41c79000 41c80000 r-xp /usr/lib/libminizip.so.1.0.0
41c88000 41c95000 r-xp /usr/lib/libail.so.0.1.0
41dcf000 41dd2000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
41dda000 41de5000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
41dee000 41e05000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
41e21000 41e2a000 rw-p [heap]
41e2a000 41f5c000 rw-p [heap]
437e4000 43fe3000 rw-p [stack:326]
44285000 44287000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:339]
bea6f000 bea90000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27641)
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
eck_asset_images(3974) > summary_bg_image : /opt/usr/data/wnoti/.crop_510.png
12-11 23:10:19.080+0900 E/wnoti-service(  871): wnoti-db-server.c: wnoti_is_check_notification_update(4451) > 0/0
12-11 23:10:19.085+0900 E/wnoti-service(  871): wnoti-sap-client.c: _add_exception_handling(581) > type : 0, application_id : 218
12-11 23:10:19.100+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 0, category : 1000, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 230496, noti_flag : 528, g_span_version : 1
12-11 23:10:19.100+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-11 23:10:19.110+0900 E/wnoti-service(  871): wnoti-db-server.c: _wnoti_update_category(804) > Reuse category, application_id : 218
12-11 23:10:19.155+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1891) > group summary & grouping_id
12-11 23:10:19.155+0900 E/wnoti-service(  871): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 1
12-11 23:10:19.160+0900 E/wnoti-service(  871): wnoti-db-server.c: set_global_noti_count(1555) > pre_count : 0, count : 1
12-11 23:10:19.175+0900 I/AUL     (  871): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-11 23:10:19.190+0900 I/AUL     (  871): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-11 23:10:19.205+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 1
12-11 23:10:19.205+0900 E/wnoti-service(  871): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(2137)
12-11 23:10:19.205+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
12-11 23:10:19.205+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 1
12-11 23:10:19.205+0900 E/wnoti-service(  871): wnoti-db-server.c: insert_panel_asset(3440) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-11 23:10:19.205+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_noti_extender(793) > noti_info->label : 3,6,8,9
12-11 23:10:19.210+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/582
12-11 23:10:19.210+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 2
12-11 23:10:19.210+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 1759
12-11 23:10:19.210+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-11 23:10:19.210+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/582
12-11 23:10:19.210+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3974) > summary_bg_image : /opt/usr/data/wnoti/.crop_382.png
12-11 23:10:19.210+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/580
12-11 23:10:19.215+0900 E/APPS    (  717): AppsBadge.cpp: onBadgeChange(215) >  (!pAppsItem) -> onBadgeChange() return
12-11 23:10:19.220+0900 E/wnoti-service(  871): wnoti-db-server.c: _clear_summary_noti(946) > summary popup : 2880, seq_num : 230496
12-11 23:10:19.235+0900 E/wnoti-service(  871): wnoti-db-server.c: wnoti_is_check_notification_update(4451) > 5/0
12-11 23:10:19.235+0900 E/wnoti-service(  871): wnoti-sap-client.c: _add_exception_handling(581) > type : 5, application_id : 218
12-11 23:10:19.235+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1839) > application status : 0
12-11 23:10:19.235+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 5, category : 0, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 230497, noti_flag : 0, g_span_version : 1
12-11 23:10:19.235+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 1
12-11 23:10:19.255+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 1
12-11 23:10:19.660+0900 E/wnoti-service(  871): wnoti-sap-client.c: _get_latest_notification_card(1700) > id : 2881, status : 0
12-11 23:10:19.690+0900 I/wnoti-service(  871): wnoti-sap-client.c: launch_alert_view(398) > timer_id : 0, emergency_cb_mode : 0, blocking_mode : 0 
12-11 23:10:19.690+0900 E/wnoti-service(  871): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 1
12-11 23:10:19.690+0900 I/wnoti-service(  871): wnoti-msg-builder.c: _publish_notification(1453) > operation_type : 0, source : 0, application_id : 0, display_count : 0
12-11 23:10:19.710+0900 E/wnoti-proxy( 2501): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2501, caller_id : 0, listener_type : 0
12-11 23:10:19.710+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1488) > Handle this change type in idler.
12-11 23:10:19.715+0900 E/wnoti-service(  871): wnoti-sap-client.c: observe_pm_lock_timer(383) > >> observe_pm_lock_timer, is_finish : 0
12-11 23:10:19.715+0900 E/wnoti-service(  871): wnoti-db-utility.c: set_pm_lock(474) > >> set_pm_lock status : 2
12-11 23:10:19.720+0900 E/wnoti-proxy(  717): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 717, caller_id : 0, listener_type : 0
12-11 23:10:19.720+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 0, op_type: 0, category_id: 0, display count: 0
12-11 23:10:19.720+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1548) > Handle this change type in idler.
12-11 23:10:19.720+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1553) > Home is background. Postpone the board update.
12-11 23:10:19.725+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 23:10:19.725+0900 E/wnoti-service(  871): wnoti-sap-client.c: on_timer(291) > is_exist_alert_list : 0, g_launch_popup_time : 1449843019, g_use_aul_launch : 0
12-11 23:10:19.725+0900 E/wnoti-service(  871): wnoti-sap-client.c: on_timer(293) > >> launching notification popup
12-11 23:10:19.730+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 23:10:19.765+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-11 23:10:19.785+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-11 23:10:19.785+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 23:10:19.785+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 871
12-11 23:10:19.805+0900 W/AUL_AMD (  479): amd_launch.c: __nofork_processing(1138) > __nofork_processing, cmd: 0, pid: 2501
12-11 23:10:19.805+0900 I/APP_CORE( 2501): appcore-efl.c: __do_app(429) > [APP 2501] Event: RESET State: RUNNING
12-11 23:10:19.805+0900 I/CAPI_APPFW_APPLICATION( 2501): app_main.c: app_appcore_reset(245) > app_appcore_reset
12-11 23:10:19.810+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(2501), cmd(0)
12-11 23:10:19.815+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(267) > fg_app : 10
12-11 23:10:19.820+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 23:10:19.830+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 23:10:19.830+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_get_block_mode(2328) > Returning false.
12-11 23:10:19.840+0900 E/wnoti-service(  871): wnoti-db-client.c: wnoti_get_alert_categories(712) > !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! application_id : 218, db_id : 2881, is_duplicated : 0
12-11 23:10:19.840+0900 E/wnoti-service(  871): wnoti-db-client.c: wnoti_get_alert_categories(851) > view_type : 1, turn_screen_on : 0, allow_gesture : 1, is_used_popup : 0, feedback : 0
12-11 23:10:19.860+0900 I/wnoti-proxy( 2501): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 23:10:19.860+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_get_alert_list(805) > application_name: 카카오톡, application_id: 218, category_id: 285, time: 1449843018, launch_app_id: (null), bg_image: /opt/usr/data/wnoti/.app_icon_218.jpg, icon_color: -5730296
12-11 23:10:19.860+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_get_alert_list(812) > noti_type: 1
12-11 23:10:19.860+0900 W/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(77) > db_id = 2881, alert_type: 1, app_feedback_type: 0
12-11 23:10:19.860+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(364) > Activity fetch finished: -1
12-11 23:10:19.860+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(369) > activity action count: 1
12-11 23:10:19.860+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(374) > 1 activities retrieved.
12-11 23:10:19.865+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(465) > Page fetch finished: -1
12-11 23:10:19.865+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(470) > wearable_page_cnt: 1
12-11 23:10:19.865+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_convert_alert_data(475) > 1 pages retrieved.
12-11 23:10:19.865+0900 W/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_get_alert_list(911) > ::DATA:: read alert list : 1, list count : 2
12-11 23:10:19.865+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_app_control(1130) > ::DATA:: CHECK IN APP CONTROL : 2, 1, 1
12-11 23:10:19.865+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_app_control(1142) > ::APP:: CHECK STATE : 5, 1, 0|com.kakao.talk|-1629588220|null|10242
12-11 23:10:19.865+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_app_control(1151) > cancel destory popup
12-11 23:10:19.865+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 23:10:19.865+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 23:10:19.865+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(627) > [2881, 2, 2, 25, 0000]
12-11 23:10:19.865+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(628) > [0, 3, 0, 0]
12-11 23:10:19.865+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_draw_noti_view(629) > [10, 0, 1, 46c1d468]
12-11 23:10:19.870+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 23:10:19.870+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 285, 218
12-11 23:10:19.870+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 23:10:19.895+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_lock(858) > ::UI:: [[[ ===> [simple popup] is LOCK, 0001 ]]]
12-11 23:10:19.895+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4351) > wnotiboard_popup_vi_type: 1
12-11 23:10:19.895+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_create_detail_layout(4357) > (2881, 2881)
12-11 23:10:19.900+0900 I/efl-extension( 2501): efl_extension_circle_surface.c: eext_circle_surface_layout_add(1293) > Put the surface[0x44399d88]'s widget[0x46c016c8] to layout widget[0x46c007c8]
12-11 23:10:19.940+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_create_genlist(4285) > (2881, 2881)
12-11 23:10:19.950+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_callback_add(147) > In
12-11 23:10:19.965+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_create_card_data(3908) > 0x43a91310, 0x43a91190, 0x43a91310
12-11 23:10:19.965+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 23:10:19.965+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 23:10:19.965+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 23:10:19.965+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 23:10:19.975+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_draw_simple_popup(3290) > alert_type : 1, is_source_companion: 1
12-11 23:10:19.980+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_draw_simple_popup(3296) > Manually lock the display.
12-11 23:10:19.980+0900 I/efl-extension( 2501): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0x44399d88 = w: 0 h: 0  obj 0x46c016c8 w: 360 h: 360
12-11 23:10:19.985+0900 I/efl-extension( 2501): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
12-11 23:10:19.995+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_turn_on_lcd(2801) > ::APP:: alert_type: 1
12-11 23:10:19.995+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_set_smart_relay(1055) > Set the smart relay for 1, 285, 218, 카카오톡
12-11 23:10:19.995+0900 E/wnoti-proxy( 2501): wnoti.c: wnoti_set_smart_relay(1149) > smart_relay setting : 0
12-11 23:10:19.995+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: wnotiboard_popup_change_win_level(1170) > current : 12, 1, 1, 1
12-11 23:10:19.995+0900 I/APP_CORE( 2501): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
12-11 23:10:20.000+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x0660000a)
12-11 23:10:20.025+0900 W/wnotibp ( 2501): w-notification-board-panel-basic-common.c: _wnotib_basic_panel_expand_basic_gl_group_content_get(2215) > Unhandled part: stack.separator
12-11 23:10:20.025+0900 I/wnotibp ( 2501): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 23:10:20.025+0900 I/wnotibp ( 2501): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 23:10:20.030+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 23:10:20.030+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 23:10:20.030+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 23:10:20.030+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 23:10:20.040+0900 W/wnotibp ( 2501): w-notification-board-action-drawer.c: wnotib_action_drawer_set_item_info(4618) > category_id: 285, application_id: 218, db_id: 2881, clear_all_items: 1
12-11 23:10:20.040+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_w_input_selector(4847) > No need to close w-input-selector.
12-11 23:10:20.045+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 23:10:20.055+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 23:10:20.055+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_notifiboard_selector(4882) > ret : 0, is_running : 0
12-11 23:10:20.055+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_items_clear(517) > called!!
12-11 23:10:20.055+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_items_clear(2167) > called!!
12-11 23:10:20.055+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 23:10:20.060+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 23:10:20.065+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 23:10:20.065+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 23:10:20.070+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_del_cb(1084) > called!!
12-11 23:10:20.070+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(3879) > Create drawer pages for 285, 218
12-11 23:10:20.070+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(4304) > action list lengh is [1]
12-11 23:10:20.070+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 23:10:20.070+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 23:10:20.075+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 23:10:20.080+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 23:10:20.080+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 23:10:20.080+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 23:10:20.085+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(2199) > called!!
12-11 23:10:20.085+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 23:10:20.085+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 23:10:20.085+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 23:10:20.090+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 23:10:20.090+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 23:10:20.090+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 23:10:20.090+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 23:10:20.095+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 23:10:20.095+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 23:10:20.100+0900 I/wnotibp ( 2501): w-notification-board-common.c: wnotib_common_get_category_name(2172) > application_id: 218, default_name: 카카오톡
12-11 23:10:20.100+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_item_append(403) > called!!
12-11 23:10:20.100+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_append(1959) > called!!
12-11 23:10:20.105+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_domain_translatable_part_text_set(2273) > called!!
12-11 23:10:20.105+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(2332) > called!!
12-11 23:10:20.105+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_create_pages(4465) > Number of pages: 4 for 218
12-11 23:10:20.105+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 23:10:20.115+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 23:10:20.130+0900 I/efl-extension( 2501): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
12-11 23:10:20.130+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_update_animator_cb(1376) > called
12-11 23:10:20.130+0900 I/efl-extension( 2501): efl_extension_rotary_selector.c: _item_update_animator_cb(1385) > item_list(0x1144303640), count(5)
12-11 23:10:20.150+0900 E/EFL     ( 2501): evas_main<2501> evas_object_main.c:1353 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 23:10:20.150+0900 E/EFL     ( 2501): evas_main<2501> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 23:10:20.150+0900 E/EFL     ( 2501): evas_main<2501> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
12-11 23:10:20.150+0900 I/wnotibp ( 2501): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 23:10:20.150+0900 I/wnotibp ( 2501): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-11 23:10:20.155+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-11 23:10:20.155+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-11 23:10:20.155+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-11 23:10:20.155+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2501): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-11 23:10:20.195+0900 E/EFL     ( 2501): evas_main<2501> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x4431a7d8 is not stable during recalc loop
12-11 23:10:20.195+0900 E/EFL     ( 2501): evas_main<2501> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x4431a7d8 is not stable during recalc loop
12-11 23:10:20.210+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3641) > ::UI:: VI TYPE : 1
12-11 23:10:20.210+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_vi_setup_idler_cb(3647) > alert_type : 1, is_source_companion: 1
12-11 23:10:20.210+0900 W/TIZEN_N_RECORDER( 2501): recorder_product.c: recorder_is_in_recording(82) > pid =/proc/0 , state =0, alive=0
12-11 23:10:20.210+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1258) > ::APP:: application_id: 218, is_disaster: 0, is_CMAS: 0, disaster_info: (null), app_feedback_type: 0 is_recording: 0
12-11 23:10:20.210+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1267) > Gear side feedback setting is_sound_on: 0, is_vibration_on: 1, is_vibrate_when_noti_on: 0
12-11 23:10:20.210+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1301) > ::APP:: Determined feedback: sound 0, vibration: 0
12-11 23:10:20.210+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_play_feedback(1305) > No feedback.
12-11 23:10:20.575+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_show_finished_cb(1009) > ::UI:: popup effect is finished (2881, 4686fcb0)
12-11 23:10:20.575+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_unlock(908) > ::UI:: [[[ [simple popup] is UNLOCK , 0000 <=== ]]]
12-11 23:10:20.575+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 2 2
12-11 23:10:20.605+0900 E/wnoti-service(  871): wnoti-db-client.c: wnoti_get_alert_categories(546) > _query_step failed(NO ROW)
12-11 23:10:20.625+0900 E/wnoti-proxy( 2501): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
12-11 23:10:20.625+0900 E/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_get_alert_list(908) > ::DATA:: No categories available.
12-11 23:10:20.625+0900 W/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_get_alert_list(911) > ::DATA:: read alert list : 0, list count : 2
12-11 23:10:20.625+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_del_cb(424) > ::UI:: (3, 46c1d468, 4686fcb0, 0)
12-11 23:10:20.625+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(918) > ::DATA:: remove notification data, 2879
12-11 23:10:20.625+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(948) > ::DATA:: CHECK DATA : 1, 1
12-11 23:10:20.625+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_del_cb(467) > ::UI:: this object is not current popup 1183251632, 1187107944
12-11 23:10:20.625+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_del_cb(480) > ::UI:: drawer is existed but elm.swallow.drawer content is NULL
12-11 23:10:20.655+0900 I/efl-extension( 2501): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x46c05640, obj: 0x46c05640
12-11 23:10:20.660+0900 I/efl-extension( 2501): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-11 23:10:20.690+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-11 23:10:20.690+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46c05640, elm_genlist, func : 0x41841e59
12-11 23:10:20.690+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-11 23:10:20.710+0900 I/efl-extension( 2501): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
12-11 23:10:20.810+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 23:10:20.810+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 23:10:22.210+0900 E/PKGMGR  (  500): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 23:10:22.380+0900 E/PKGMGR_SERVER(  502): pkgmgr-server.c: main(2126) > package manager server start
12-11 23:10:22.490+0900 E/PKGMGR_SERVER(  502): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-497945317], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-497945317' '-r' 'org.reolab.blackandwhite'], cookie=[t676s3jJ2XVVwIz+x4kLXu6vLPM=], backend_flag=[0]
12-11 23:10:22.495+0900 E/PKGMGR  (  502): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 23:10:22.495+0900 E/PKGMGR_SERVER(  502): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 23:10:22.500+0900 E/PKGMGR  (  500): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[5000002]
12-11 23:10:22.500+0900 E/PKGMGR_SERVER(  504): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 23:10:22.685+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 23:10:22.695+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 23:10:22.700+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 23:10:22.710+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 23:10:23.305+0900 E/PKGMGR_CERT(  504): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 23:10:23.315+0900 E/PKGMGR_CERT(  504): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 97
12-11 23:10:23.315+0900 E/PKGMGR_CERT(  504): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 97
12-11 23:10:23.315+0900 E/PKGMGR_CERT(  504): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 5
12-11 23:10:23.315+0900 E/PKGMGR_CERT(  504): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 5
12-11 23:10:23.315+0900 E/PKGMGR_CERT(  504): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 5
12-11 23:10:23.320+0900 E/PKGMGR_CERT(  504): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 5
12-11 23:10:23.330+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 23:10:23.340+0900 E/PKGMGR_CERT(  504): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 23:10:24.500+0900 E/PKGMGR_SERVER(  502): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 23:10:25.070+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 23:10:25.085+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-11 23:10:25.220+0900 E/rpm-installer(  504): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-11 23:10:26.500+0900 E/PKGMGR_SERVER(  502): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 23:10:26.875+0900 E/wnoti-service(  871): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(37)
12-11 23:10:26.880+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 2, category : 0, source : 7, feedback : -1, popup_type(RICH) : 0, application_id : -1, seq_num : 230496, noti_flag : 0, g_span_version : 1
12-11 23:10:26.880+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-11 23:10:26.880+0900 E/wnoti-service(  871): wnoti-db-server.c: clear_notification_card(2929) > _query_step failed()
12-11 23:10:26.880+0900 E/wnoti-service(  871): wnoti-db-server.c: clear_notification_card_by_window_id(2854) > _query_step failed()
12-11 23:10:26.885+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 23:10:26.895+0900 E/wnoti-service(  871): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(47)
12-11 23:10:26.900+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 2, category : 0, source : 7, feedback : -1, popup_type(RICH) : 0, application_id : 218, seq_num : 230497, noti_flag : 0, g_span_version : 1
12-11 23:10:26.900+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-11 23:10:26.935+0900 I/wnoti-service(  871): wnoti-msg-builder.c: _publish_notification(1453) > operation_type : 0, source : 0, application_id : 218, display_count : 0
12-11 23:10:26.940+0900 E/wnoti-proxy( 2501): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2501, caller_id : 0, listener_type : 0
12-11 23:10:26.940+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1488) > Handle this change type in idler.
12-11 23:10:26.940+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1667) > This notification's category is expired!!!
12-11 23:10:26.940+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1670) > ::APP:: This notification is removed by wnotification service :(2881),(1)
12-11 23:10:26.940+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1673) > ::APP:: delete_reserved_category_id=285, win_id=(null)
12-11 23:10:26.940+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1890) > state : (5, 1, 1)
12-11 23:10:26.940+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1903) > simple popup=4686fcb0, view_state=1
12-11 23:10:26.940+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1927) > ::APP:: this notification is removed by service, wating ack from host. or more option excution timeout.
12-11 23:10:26.945+0900 E/wnoti-proxy(  717): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 717, caller_id : 0, listener_type : 0
12-11 23:10:26.945+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 0, op_type: 0, category_id: 218, display count: 0
12-11 23:10:26.945+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1548) > Handle this change type in idler.
12-11 23:10:26.945+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1553) > Home is background. Postpone the board update.
12-11 23:10:26.950+0900 E/wnoti-service(  871): wnoti-db-server.c: set_global_noti_count(1555) > pre_count : 1, count : 0
12-11 23:10:26.965+0900 I/AUL     (  871): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-11 23:10:26.975+0900 I/AUL     (  871): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-11 23:10:26.995+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 23:10:27.000+0900 E/APPS    (  717): AppsBadge.cpp: onBadgeChange(215) >  (!pAppsItem) -> onBadgeChange() return
12-11 23:10:28.500+0900 E/PKGMGR_SERVER(  502): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 23:10:28.740+0900 E/PKGMGR_SERVER(  502): pkgmgr-server.c: sighandler(445) > child NORMAL exit [504]
12-11 23:10:28.755+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 23:10:28.795+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-11 23:10:28.795+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-11 23:10:28.800+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-11 23:10:28.800+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-11 23:10:28.800+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-11 23:10:28.800+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-11 23:10:28.865+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-11 23:10:28.920+0900 E/PKGMGR_INFO(  476): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-11 23:10:28.925+0900 E/APPS    (  717): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-11 23:10:28.945+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1890) > state : (2, 5, 1)
12-11 23:10:28.945+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1903) > simple popup=4686fcb0, view_state=1
12-11 23:10:28.945+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 23:10:28.945+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_reset_view_lock(997) > ::UI:: lock state = 0000
12-11 23:10:28.945+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1963) > device_power_release_lock CPU>>>>>>>
12-11 23:10:28.945+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 23:10:28.945+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 285, 218
12-11 23:10:28.945+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 23:10:28.945+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_goto_pause(1998) > ::INFO:: call lower
12-11 23:10:28.950+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotiboard_popup_simple_popup_del_cb(424) > ::UI:: (3, 4686fcb0, 4686fcb0, 0)
12-11 23:10:28.955+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(918) > ::DATA:: remove notification data, 2881
12-11 23:10:28.955+0900 I/wnotibp ( 2501): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(948) > ::DATA:: CHECK DATA : 0, 0
12-11 23:10:28.955+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_unlock(910) > ::UI:: [[[ [simple popup] is not in lock state , 0000  <===]]]
12-11 23:10:28.955+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_view_unlock(918) > ::DATA:: CHECK LIST : 0 0
12-11 23:10:28.955+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46c53b68, elm_genlist, _activated_obj : 0x0, activated : 0
12-11 23:10:28.955+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 23:10:28.955+0900 W/AUL_AMD (  479): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-11 23:10:28.960+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_w_input_selector(4847) > No need to close w-input-selector.
12-11 23:10:28.965+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 23:10:28.980+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 23:10:28.980+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: _wnotib_action_drawer_terminate_notifiboard_selector(4882) > ret : 0, is_running : 0
12-11 23:10:28.980+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 23:10:28.980+0900 I/wnotibp ( 2501): w-notification-board-action-drawer.c: wnotib_action_drawer_hide(4588) > Panel open state: 0 for 285, 218
12-11 23:10:28.980+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-11 23:10:28.995+0900 I/efl-extension( 2501): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x46c53b68, obj: 0x46c53b68
12-11 23:10:28.995+0900 I/efl-extension( 2501): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-11 23:10:29.020+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-11 23:10:29.020+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46c53b68, elm_genlist, func : 0x41841e59
12-11 23:10:29.020+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-11 23:10:29.035+0900 I/MALI    ( 2501): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43aa8980] swap changed from sync to async
12-11 23:10:29.040+0900 I/efl-extension( 2501): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
12-11 23:10:29.040+0900 W/APP_CORE( 2501): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:660000a
12-11 23:10:29.040+0900 I/APP_CORE( 2501): appcore-efl.c: __do_app(429) > [APP 2501] Event: PAUSE State: RUNNING
12-11 23:10:29.040+0900 I/CAPI_APPFW_APPLICATION( 2501): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-11 23:10:29.045+0900 E/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_get_win_pid(194) > 
12-11 23:10:29.045+0900 E/AUL     ( 2501): pkginfo.c: aul_app_get_appid_bypid(250) > invalid parameter
12-11 23:10:29.045+0900 E/CAPI_APPFW_APP_MANAGER( 2501): app_manager.c: app_manager_error(72) > [app_manager_get_app_id] Invalid parameter(0xffffffea) : Invalid process ID
12-11 23:10:29.045+0900 E/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(264) > get app id failed...!
12-11 23:10:29.045+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_get_focus_app(267) > fg_app : 0
12-11 23:10:29.045+0900 W/wnotibp ( 2501): wnotiboard-popup.c: wnotiboard_popup_get_view_lock_state(960) > ::UI:: lock state=0000
12-11 23:10:29.045+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1368) > [0, 0, 25, 0000]
12-11 23:10:29.045+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1369) > [0, 0]
12-11 23:10:29.045+0900 W/wnotibp ( 2501): wnotiboard-popup.c: _wnotiboard_popup_app_pause(1370) > [1, 3, 0, 2, 0]
12-11 23:10:29.065+0900 W/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(331) > body is NULL and no attachments found.
12-11 23:10:29.075+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: evas_render_pre_cb(6758) > [SECURE_LOG] Failed to create a resource lock
12-11 23:10:29.085+0900 I/MALI    (  717): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x442b6d88] swap changed from sync to async
12-11 23:10:29.110+0900 W/W_HOME  (  717): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
12-11 23:10:29.110+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 23:10:29.110+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 23:10:29.110+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 23:10:29.110+0900 W/W_HOME  (  717): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
12-11 23:10:29.150+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(0)
12-11 23:10:29.150+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
12-11 23:10:29.150+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-11 23:10:29.150+0900 W/W_HOME  (  717): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(0)
12-11 23:10:29.150+0900 I/APP_CORE(  717): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
12-11 23:10:29.150+0900 I/wnotib  (  717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
12-11 23:10:29.150+0900 E/wnotib  (  717): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-11 23:10:29.150+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1684) > Do the postponed update job.
12-11 23:10:29.150+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1051) > idler for type: 0
12-11 23:10:29.160+0900 E/wnoti-service(  871): wnoti-db-client.c: wnoti_get_categories_info(206) > _query_step failed(not SQLITE_ROW)
12-11 23:10:29.165+0900 E/wnoti-proxy(  717): wnoti.c: wnoti_get_category_list(1249) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
12-11 23:10:29.165+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1384) > No categories available. Num old_notifications: 1
12-11 23:10:29.165+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 2
12-11 23:10:29.165+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2960) > We don't need to delete the item for second_depth_type: 0.
12-11 23:10:29.175+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_gl_item_del(3554) > card[0x46e50f98]
12-11 23:10:29.180+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(3062) > Hide the drawer for the current panel.
12-11 23:10:29.180+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_destroy(4969) > Destory panel, panel application_id [218], panel category_id [285]
12-11 23:10:29.200+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_destroy(5104) > Destory panel, -------> Done
12-11 23:10:29.200+0900 W/wnotib  (  717): w-notification-board-panel-manager.c: w_notification_board_panel_manager_destroy_panel(333) > page_instance 285, 0x49ad9a68 is destoryed!
12-11 23:10:29.205+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-11 23:10:29.205+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-11 23:10:29.205+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-11 23:10:29.205+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-11 23:10:29.205+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 0, setting_power_saving_mode: 0, show_summary_board: 0
12-11 23:10:29.205+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(161) > Put empty view into panel body
12-11 23:10:29.205+0900 W/W_HOME  (  717): noti_broker.c: _handler_indicator_select(581) > 0
12-11 23:10:29.205+0900 W/W_HOME  (  717): noti_broker.c: _handler_indicator_select(591) > select index:1
12-11 23:10:29.205+0900 W/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(175) > Hide home indicator.
12-11 23:10:29.205+0900 W/W_HOME  (  717): noti_broker.c: _handler_noti_indicator_hide(498) > 
12-11 23:10:29.215+0900 E/wnoti-service(  871): wnoti-server-mgr-stub.c: __wnoti_change_new_flag_stub(2269) > change_type : 0, value : 0
12-11 23:10:29.220+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-11 23:10:29.220+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1401) > Set num_total_panel to default value 1 from 0.
12-11 23:10:29.220+0900 W/W_HOME  (  717): noti_broker.c: _handler_indicator_update(562) > 0x1
12-11 23:10:29.295+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 0
12-11 23:10:29.295+0900 W/W_HOME  (  717): noti_broker.c: _handler_noti_indicator_hide(498) > 
12-11 23:10:29.295+0900 W/W_HOME  (  717): noti_broker.c: _handler_indicator_update(562) > 0x1
12-11 23:10:29.325+0900 W/CRASH_MANAGER(  514): worker.c: worker_job(1199) > 1127641626c61144984302
