S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 14704
Date: 2015-12-12 08:24:33+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x32c

Register Information
r0   = 0x00000320, r1   = 0x0000000d
r2   = 0x00000190, r3   = 0x41553194
r4   = 0x00000320, r5   = 0x00000000
r6   = 0x414e9204, r7   = 0x414dd608
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbeb53c4c, sp   = 0xbeb53c00
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   489992 KB
MemFree:     13860 KB
Buffers:     31944 KB
Cached:     100012 KB
VmPeak:     111464 KB
VmSize:     110952 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16096 KB
VmRSS:       16096 KB
VmData:      54424 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 14704 TID = 14704
14704 14836 14847 

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
43757000 43f56000 rw-p [stack:14836]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43f75000 43f8c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424a000 4424c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45255000 45b00000 rw-p [stack:14847]
beb34000 beb55000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14704)
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
0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
12-12 08:24:09.416+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 142
12-12 08:24:09.416+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-12 08:24:09.416+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/688
12-12 08:24:09.416+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3979) > image is not in gear
12-12 08:24:09.416+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3990) > images are not completed
12-12 08:24:09.416+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 1000, category : 1000, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229391, noti_flag : 528, g_span_version : 1
12-12 08:24:09.416+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-12 08:24:09.416+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(2149) > req_app_data_timer : 0
12-12 08:24:09.416+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_received_noti(2772) > INCOMPLETE IMAGES, application_id : 218, seq_num : 229391
12-12 08:24:09.421+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-12 08:24:09.421+0900 E/wnoti-service(  871): wnoti-sap-client.c: on_app_data(143) > source : 0, protocol : 0, seq_num : 229391, duplicated_seq_num_count : 0, g_slot_id : 0
12-12 08:24:09.421+0900 E/wnoti-service(  871): wnoti-consumer.c: wnoti_consumer_send(785) > connect: 1, upsm : 0, connection_type : 1, len : 4, SEND HOST: [23][3][80][f][0][0]
12-12 08:24:09.431+0900 E/wnoti-service(  871): wnoti-consumer.c: wnoti_consumer_send(823) > send data success
12-12 08:24:09.556+0900 E/wnoti-service(  871): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(10320)
12-12 08:24:09.556+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
12-12 08:24:09.576+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-12 08:24:09.581+0900 E/wnoti-service(  871): wnoti-db-server.c: insert_panel_asset(3440) > [panel noti, cache image]attr_type : 18, uri : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-12 08:24:09.601+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/582
12-12 08:24:09.601+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 2
12-12 08:24:09.606+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 9330
12-12 08:24:09.611+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-12 08:24:09.621+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/582
12-12 08:24:09.621+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3974) > summary_bg_image : /opt/usr/data/wnoti/.crop_382.png
12-12 08:24:09.621+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/580
12-12 08:24:09.651+0900 E/wnoti-service(  871): wnoti-db-server.c: _clear_summary_noti(933) > _query_step failed(no row)
12-12 08:24:09.651+0900 E/wnoti-service(  871): wnoti-db-server.c: wnoti_is_check_notification_update(4451) > 5/0
12-12 08:24:09.651+0900 E/wnoti-service(  871): wnoti-sap-client.c: _add_exception_handling(581) > type : 5, application_id : 218
12-12 08:24:09.661+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1839) > application status : 0
12-12 08:24:09.661+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 5, category : 0, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229392, noti_flag : 0, g_span_version : 1
12-12 08:24:09.661+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-12 08:24:09.671+0900 E/wnoti-service(  871): wnoti-db-server.c: _wnoti_update_category(804) > Reuse category, application_id : 218
12-12 08:24:09.701+0900 E/wnoti-service(  871): wnoti-db-server.c: set_global_noti_count(1555) > pre_count : 0, count : 1
12-12 08:24:09.726+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-12 08:24:09.741+0900 I/AUL     (  871): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-12 08:24:09.756+0900 I/AUL     (  871): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
12-12 08:24:09.791+0900 E/APPS    (  717): AppsBadge.cpp: onBadgeChange(215) >  (!pAppsItem) -> onBadgeChange() return
12-12 08:24:09.806+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-12 08:24:10.006+0900 I/CAPI_WATCH_APPLICATION( 4119): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:10.091+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:10.126+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:10.201+0900 I/wnoti-service(  871): wnoti-msg-builder.c: _publish_notification(1453) > operation_type : 0, source : 0, application_id : 0, display_count : 0
12-12 08:24:10.211+0900 E/wnoti-proxy( 2501): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2501, caller_id : 0, listener_type : 0
12-12 08:24:10.211+0900 I/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1488) > Handle this change type in idler.
12-12 08:24:10.211+0900 E/wnoti-proxy(  717): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 717, caller_id : 0, listener_type : 0
12-12 08:24:10.211+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 0, op_type: 0, category_id: 0, display count: 0
12-12 08:24:10.211+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1548) > Handle this change type in idler.
12-12 08:24:10.216+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1572) > App tray not displayed and edit mode is off.
12-12 08:24:10.216+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1051) > idler for type: 0
12-12 08:24:10.266+0900 I/wnoti-proxy(  717): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-12 08:24:10.271+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1098) > unread_count: 1
12-12 08:24:10.271+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(622) > category_id: 289, application_id: 218, application_name: 카카오톡, time_stamp: 1449875409, content_id: 0, spannable_string_version: 1
12-12 08:24:10.271+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-12 08:24:10.271+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-12 08:24:10.271+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-12 08:24:10.276+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-12 08:24:10.276+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-12 08:24:10.276+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-12 08:24:10.276+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1335) > New noti is here. Add it on panel  289, 카카오톡.
12-12 08:24:10.276+0900 W/wnotib  (  717): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(260) > Create a panel for panel_id: 1, instance_id: 289
12-12 08:24:10.276+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_initialize(4750) > Initialize the panel with id: 289
12-12 08:24:10.276+0900 W/wnotib  (  717): w-notification-board-panel-manager.c: w_notification_board_panel_manager_create_page_instance_with_instance_id(275) > Page instance, instance_id [289] has been created.
12-12 08:24:10.276+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 289, application_id: 218, type: 1
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.301+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.306+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4398) > Skip adding the new noti to the second depth genlist. second_depth_type: 0.
12-12 08:24:10.306+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 289, application_id: 218, type: 13
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
12-12 08:24:10.306+0900 E/TIZEN_N_SYSTEM_SETTINGS(  717): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
12-12 08:24:10.316+0900 I/wnotib  (  717): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-12 08:24:10.316+0900 I/wnotib  (  717): w-notification-board-common.c: wnotib_common_get_application_icon(2219) > application_id: 218, thumbnail path: /opt/usr/data/wnoti/.app_icon_218.jpg, width: 58, height: 58
12-12 08:24:10.321+0900 W/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4577) > Show home indicator.
12-12 08:24:10.321+0900 W/W_HOME  (  717): noti_broker.c: _handler_noti_indicator_show(478) > 
12-12 08:24:10.326+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 289, application_id: 218, type: 12
12-12 08:24:10.326+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 1, num total noti: 1
12-12 08:24:10.326+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-12 08:24:10.326+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-12 08:24:10.326+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-12 08:24:10.326+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-12 08:24:10.326+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
12-12 08:24:10.326+0900 W/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(206) > Summary board was disabled. But receive update request
12-12 08:24:10.326+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-12 08:24:10.326+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 1.
12-12 08:24:10.326+0900 W/W_HOME  (  717): noti_broker.c: _handler_indicator_update(562) > 0x1
12-12 08:24:10.356+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 1
12-12 08:24:10.356+0900 W/W_HOME  (  717): noti_broker.c: _handler_noti_indicator_show(478) > 
12-12 08:24:10.386+0900 W/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(331) > body is NULL and no attachments found.
12-12 08:24:10.471+0900 W/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_basic_gl_group_text_get(331) > body is NULL and no attachments found.
12-12 08:24:10.601+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:24:10.616+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:24:10.971+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 1 -> 2
12-12 08:24:10.971+0900 E/WMS     (  477): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-12 08:24:10.971+0900 E/WMS     (  477): ==========
12-12 08:24:10.971+0900 E/WMS     (  477): ##WMS SEND : mgr_gear_wear_onoff_req
12-12 08:24:10.971+0900 E/WMS     (  477): ==========
12-12 08:24:10.971+0900 E/WMS     (  477): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-12 08:24:11.001+0900 I/CAPI_WATCH_APPLICATION( 4119): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:11.011+0900 E/wnoti-service(  871): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(235572)
12-12 08:24:11.011+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_received_noti(2311) > application_id : 218
12-12 08:24:11.016+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-12 08:24:11.016+0900 E/wnoti-service(  871): wnoti-db-utility.c: logging_image(1656) > [89][50][4e][47]
12-12 08:24:11.021+0900 E/wnoti-service(  871): wnoti-db-utility.c: logging_image(1656) > [89][50][4e][47]
12-12 08:24:11.036+0900 E/wnoti-service(  871): wnoti-db-server.c: insert_asset(3795) > [Replace] content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-12 08:24:11.056+0900 E/wnoti-service(  871): wnoti-db-utility.c: logging_image(1656) > [89][50][4e][47]
12-12 08:24:11.056+0900 W/SHealth_Service( 1061): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1008[0;m
12-12 08:24:11.056+0900 E/SHealth_Service( 1061): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-12 08:24:11.061+0900 E/wnoti-service(  871): wnoti-db-server.c: insert_asset(3790) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/688
12-12 08:24:11.066+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:11.076+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_action(536) > background : content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/688
12-12 08:24:11.076+0900 E/wnoti-service(  871): wnoti-json-parser.c: wnoti_parse_android_wear_action(578) > noti_info->action_type : 0
12-12 08:24:11.076+0900 E/wnoti-service(  871): wnoti-sap-client.c: _parse_normal_attribute(1124) > ATTR_ANDROID_WEARABLE, len : 142
12-12 08:24:11.076+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/581
12-12 08:24:11.076+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3943) > content://com.samsung.accessory.goproviders.sanotificationservice.panel_notification/image/688
12-12 08:24:11.081+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:11.491+0900 E/wnoti-service(  871): wnoti-db-server.c: check_asset_images(3974) > summary_bg_image : /opt/usr/data/wnoti/.crop_512.png
12-12 08:24:11.501+0900 E/wnoti-service(  871): wnoti-db-server.c: wnoti_is_check_notification_update(4451) > 1001/0
12-12 08:24:11.501+0900 E/wnoti-service(  871): wnoti-sap-client.c: _add_exception_handling(581) > type : 1001, application_id : 218
12-12 08:24:11.506+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(1848) > 1001, category : 1000, source : 0, feedback : 0, popup_type(RICH) : 0, application_id : 218, seq_num : 229391, noti_flag : 528, g_span_version : 1
12-12 08:24:11.506+0900 E/wnoti-service(  871): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-12 08:24:11.506+0900 E/wnoti-service(  871): wnoti-sap-client.c: publish_received_noti(2157) > NOT HANDLE, 1001, application_id : 218, sequence_number : 229391
12-12 08:24:11.506+0900 E/wnoti-service(  871): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-12 08:24:12.001+0900 I/CAPI_WATCH_APPLICATION( 4119): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:12.131+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:12.176+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:12.246+0900 I/APP_CORE(13608): appcore-efl.c: __do_app(429) > [APP 13608] Event: MEM_FLUSH State: PAUSED
12-12 08:24:13.001+0900 I/CAPI_WATCH_APPLICATION( 4119): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:13.106+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:13.141+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:14.001+0900 I/CAPI_WATCH_APPLICATION( 4119): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:14.151+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:14.241+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:15.001+0900 I/CAPI_WATCH_APPLICATION( 4119): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:15.071+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:15.116+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:15.601+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:24:15.626+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:24:15.891+0900 E/PKGMGR_SERVER(14830): pkgmgr-server.c: main(2126) > package manager server start
12-12 08:24:15.996+0900 I/CAPI_WATCH_APPLICATION( 4119): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:16.006+0900 E/PKGMGR_SERVER(14830): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1624173746], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-12 08:24:16.016+0900 E/PKGMGR_SERVER(14831): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-12 08:24:16.026+0900 E/PKGMGR  (14828): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-12 08:24:16.031+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:16.076+0900 I/CAPI_NETWORK_WIFI( 4119): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:16.101+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:24:16.111+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4119
12-12 08:24:16.116+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-12 08:24:16.116+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 5
12-12 08:24:16.141+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(4119), cmd(4)
12-12 08:24:16.146+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:24:16.151+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4119
12-12 08:24:16.156+0900 W/CAPI_WATCH_APPLICATION( 4119): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-12 08:24:16.156+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 22
12-12 08:24:16.156+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(884) > app status : 4
12-12 08:24:16.161+0900 W/WATCH_CORE( 4119): appcore-watch.c: __widget_destroy(992) > widget_destory
12-12 08:24:16.161+0900 E/WIDGET_PROVIDER_APP( 4119): client.c: client_fini(1175) > Provider is not initialized
12-12 08:24:16.161+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 4
12-12 08:24:16.256+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:24:16.321+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-12 08:24:16.371+0900 E/PKGMGR_SERVER(14831): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-12 08:24:16.406+0900 E/AUL_AMD (  479): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-12 08:24:16.406+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(4119), cmd(4)
12-12 08:24:16.431+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-12 08:24:16.486+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-12 08:24:16.511+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-12 08:24:16.511+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-12 08:24:16.511+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 698
12-12 08:24:16.541+0900 E/PKGMGR_SERVER(14830): pkgmgr-server.c: sighandler(445) > child NORMAL exit [14831]
12-12 08:24:16.631+0900 E/RESOURCED(  480): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-12 08:24:16.631+0900 E/RESOURCED(  480): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-12 08:24:16.636+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(2026) > pad pid(-5)
12-12 08:24:16.636+0900 W/AUL_PAD ( 1168): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-12 08:24:16.636+0900 W/AUL_PAD ( 1168): launchpad.c: __send_result_to_caller(265) > Check app launching
12-12 08:24:16.686+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: watch_app_main(382) > watch_app_main
12-12 08:24:16.721+0900 E/TBM     (14704): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-12 08:24:16.741+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4119
12-12 08:24:16.776+0900 W/WATCH_CORE(14704): appcore-watch.c: __widget_create(958) > widget_create
12-12 08:24:16.786+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [5251.320801] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_5251.320801.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263134:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-12 08:24:16.786+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[5251.320801] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_5251.320801.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263134:4] gbar_fname[]
12-12 08:24:16.801+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-12 08:24:16.801+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-12 08:24:16.931+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:16.941+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:17.126+0900 W/WATCH_CORE(14704): appcore-watch.c: __widget_create(976) > widget_create done
12-12 08:24:17.166+0900 I/WATCH_CORE(14704): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-12 08:24:17.166+0900 I/WATCH_CORE(14704): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-12 08:24:17.166+0900 I/WATCH_CORE(14704): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-12 08:24:17.211+0900 W/WATCH_CORE(14704): appcore-watch.c: __widget_resume(1012) > widget_resume
12-12 08:24:17.226+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:17.241+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:17.251+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:17.741+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-12 08:24:17.741+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-12 08:24:17.756+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:24:17.766+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 14704
12-12 08:24:17.766+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-12 08:24:17.966+0900 I/AUL_PAD (14859): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-12 08:24:17.996+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:18.006+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:18.016+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:18.031+0900 E/PKGMGR_SERVER(14830): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-12 08:24:18.031+0900 E/PKGMGR_SERVER(14830): pkgmgr-server.c: main(2180) > package manager server terminated.
12-12 08:24:18.156+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-12 08:24:19.001+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:19.106+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:19.131+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:20.001+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:20.151+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:20.201+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:20.601+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:24:20.636+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:24:21.001+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:21.046+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:21.106+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:22.001+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:22.126+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:22.161+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:23.001+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:23.106+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:23.251+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:24.001+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:24.121+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:24.226+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:25.001+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:25.076+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:25.116+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:25.601+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:24:25.611+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:24:26.001+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:26.081+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:26.096+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:26.996+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:27.031+0900 E/PKGMGR  (15006): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-12 08:24:27.031+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:24:27.046+0900 I/CAPI_NETWORK_WIFI(14704): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:24:27.196+0900 E/PKGMGR_SERVER(15008): pkgmgr-server.c: main(2126) > package manager server start
12-12 08:24:27.296+0900 E/PKGMGR_SERVER(15008): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1612860772], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-1612860772' '-r' 'org.reolab.blackandwhite'], cookie=[WPY2o5Sy2z8RcTUUDuSHJeRudL4=], backend_flag=[0]
12-12 08:24:27.301+0900 E/PKGMGR  (15008): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-12 08:24:27.301+0900 E/PKGMGR_SERVER(15008): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-12 08:24:27.306+0900 E/PKGMGR_SERVER(15009): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-12 08:24:27.311+0900 E/PKGMGR  (15006): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[150060002]
12-12 08:24:27.461+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-12 08:24:27.486+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-12 08:24:27.486+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-12 08:24:27.496+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-12 08:24:27.996+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:28.121+0900 E/PKGMGR_CERT(15009): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-12 08:24:28.131+0900 E/PKGMGR_CERT(15009): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 96
12-12 08:24:28.131+0900 E/PKGMGR_CERT(15009): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 96
12-12 08:24:28.131+0900 E/PKGMGR_CERT(15009): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 4
12-12 08:24:28.131+0900 E/PKGMGR_CERT(15009): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 4
12-12 08:24:28.131+0900 E/PKGMGR_CERT(15009): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 4
12-12 08:24:28.131+0900 E/PKGMGR_CERT(15009): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 4
12-12 08:24:28.141+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-12 08:24:28.151+0900 E/PKGMGR_CERT(15009): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-12 08:24:28.996+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:30.001+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:30.001+0900 E/rpm-installer(15009): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-12 08:24:30.031+0900 E/PKGMGR_SERVER(15008): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-12 08:24:30.601+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:24:30.611+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:24:30.996+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:32.001+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:32.031+0900 E/PKGMGR_SERVER(15008): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-12 08:24:33.001+0900 I/CAPI_WATCH_APPLICATION(14704): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:24:33.346+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-12 08:24:33.361+0900 E/PKGMGR_SERVER(15008): pkgmgr-server.c: sighandler(445) > child NORMAL exit [15009]
12-12 08:24:33.416+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-12 08:24:33.416+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-12 08:24:33.416+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-12 08:24:33.416+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-12 08:24:33.436+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-12 08:24:33.436+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-12 08:24:33.486+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-12 08:24:33.541+0900 E/APPS    (  717): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-12 08:24:33.551+0900 E/PKGMGR_INFO(  476): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-12 08:24:33.851+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 4
12-12 08:24:33.856+0900 E/AUL_AMD (  479): amd_request.c: __app_process_by_pid(193) > pid(14704) is dead. cmd(4) is canceled
12-12 08:24:33.856+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-12 08:24:33.871+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-12 08:24:33.886+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-12 08:24:33.886+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-12 08:24:33.886+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 698
12-12 08:24:33.911+0900 W/CRASH_MANAGER(15017): worker.c: worker_job(1199) > 1114704626c61144987627
