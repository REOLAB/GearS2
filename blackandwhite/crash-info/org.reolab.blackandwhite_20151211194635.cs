S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 3081
Date: 2015-12-11 19:46:35+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1084

Register Information
r0   = 0x00001078, r1   = 0x0000000d
r2   = 0x00000ec8, r3   = 0x41453194
r4   = 0x00001078, r5   = 0x00000000
r6   = 0x416a36bc, r7   = 0x4169a008
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbecd2c4c, sp   = 0xbecd2c00
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     15280 KB
Buffers:     17680 KB
Cached:     180944 KB
VmPeak:     112652 KB
VmSize:     112140 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16156 KB
VmRSS:       16156 KB
VmData:      55612 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3081 TID = 3081
3081 3564 3575 

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
414ba000 414c4000 r-xp /lib/libnss_files-2.13.so
414cd000 414d1000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
414e1000 414e8000 r-xp /usr/lib/libappcore-watch.so.1.1
414f1000 414f6000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
414fe000 41520000 rw-p [heap]
41520000 415ef000 r-xp /usr/lib/libscim-1.0.so.8.2.3
418c3000 418f3000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
418f4000 41908000 r-xp /usr/lib/libcapi-network-nfc.so.0.2.3
41910000 4191d000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.55
41925000 41932000 r-xp /usr/lib/libalarm.so.0.0.0
4193b000 41a78000 r-xp /usr/lib/libicui18n.so.51.1
41a88000 41b6c000 r-xp /usr/lib/libicuuc.so.51.1
41b81000 41b87000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41b8f000 41b95000 r-xp /usr/lib/libwidget.so.1.0.0
41b9e000 41ba3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41bab000 41be2000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41beb000 41c04000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41c0d000 41c37000 r-xp /usr/lib/libnfc.so.1.0.0
41c40000 41c71000 r-xp /usr/lib/libmdm.so.1.1.85
41c79000 41c8f000 r-xp /usr/lib/libnetwork.so.0.0.0
41c98000 41c9d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
4322c000 43235000 r-xp /usr/lib/libcom-core.so.0.0.1
4323e000 4324a000 r-xp /usr/lib/libwidget_service.so.1.0.0
43252000 4325b000 r-xp /usr/lib/libwidget_provider.so.1.0.0
43264000 4326a000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43272000 4327a000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43282000 432b0000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
432bc000 432c4000 r-xp /usr/lib/libdrm.so.2.4.0
432cc000 432ce000 r-xp /usr/lib/libdri2.so.0.0.0
432d6000 432dd000 r-xp /usr/lib/libtbm.so.1.0.0
432e5000 432ff000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43308000 4330f000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43318000 4331a000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43322000 43329000 r-xp /usr/lib/libminizip.so.1.0.0
43331000 4333e000 r-xp /usr/lib/libail.so.0.1.0
43779000 43f78000 rw-p [stack:3564]
43f78000 43f7b000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f83000 43f8e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
44016000 4402d000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4426c000 4426e000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:3575]
becb3000 becd4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3081)
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
tification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:46:10.425+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:46:10.425+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:46:10.425+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:46:10.425+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:46:10.425+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:46:10.425+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:46:10.425+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:46:10.425+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 13
12-11 19:46:10.425+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 286, application_id: 203, type: 13
12-11 19:46:10.425+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 287, application_id: 101, type: 13
12-11 19:46:10.425+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1370) > This noti will be removed from panel: 287, message application.
12-11 19:46:10.430+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 287, application_id: 101, type: 2
12-11 19:46:10.430+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2960) > We don't need to delete the item for second_depth_type: 0.
12-11 19:46:10.430+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_gl_item_del(3554) > card[0x487e2198]
12-11 19:46:10.430+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_destroy(4969) > Destory panel, panel application_id [101], panel category_id [287]
12-11 19:46:10.445+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88018), origin_x(1), origin_y(1)
12-11 19:46:10.450+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_destroy(5104) > Destory panel, -------> Done
12-11 19:46:10.450+0900 W/wnotib  (  714): w-notification-board-panel-manager.c: w_notification_board_panel_manager_destroy_panel(333) > page_instance 287, 0x4872bfb8 is destoryed!
12-11 19:46:10.450+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 12
12-11 19:46:10.450+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 286, application_id: 203, type: 12
12-11 19:46:10.450+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 2, num total noti: 4
12-11 19:46:10.450+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-11 19:46:10.450+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-11 19:46:10.455+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-11 19:46:10.455+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-11 19:46:10.455+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 2, setting_power_saving_mode: 0, show_summary_board: 0
12-11 19:46:10.455+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-11 19:46:10.455+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 2.
12-11 19:46:10.455+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_update(562) > 0x2
12-11 19:46:10.535+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 2
12-11 19:46:10.540+0900 W/W_HOME  (  714): noti_broker.c: _handler_noti_indicator_show(478) > 
12-11 19:46:10.540+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_update(562) > 0x2
12-11 19:46:10.615+0900 W/APPS    (  714): AppsItem.cpp: onItemBadgeShow(598) >  badge show:[0:0]
12-11 19:46:11.210+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_hide(552) > 
12-11 19:46:11.210+0900 W/W_HOME  (  714): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
12-11 19:46:11.305+0900 E/PKGMGR_SERVER( 3550): pkgmgr-server.c: main(2126) > package manager server start
12-11 19:46:11.390+0900 E/PKGMGR_SERVER( 3550): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_135859177], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-11 19:46:11.395+0900 E/PKGMGR_SERVER( 3552): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-11 19:46:11.400+0900 E/PKGMGR  ( 3544): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-11 19:46:11.460+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:46:11.465+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2917
12-11 19:46:11.470+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:46:11.470+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 5
12-11 19:46:11.475+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(2917), cmd(4)
12-11 19:46:11.480+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:46:11.480+0900 W/CAPI_WATCH_APPLICATION( 2917): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-11 19:46:11.480+0900 W/WATCH_CORE( 2917): appcore-watch.c: __widget_destroy(992) > widget_destory
12-11 19:46:11.480+0900 E/WIDGET_PROVIDER_APP( 2917): client.c: client_fini(1175) > Provider is not initialized
12-11 19:46:11.490+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2917
12-11 19:46:11.490+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 22
12-11 19:46:11.490+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(884) > app status : 4
12-11 19:46:11.490+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 4
12-11 19:46:11.595+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:46:11.670+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 19:46:11.740+0900 E/AUL_AMD (  475): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-11 19:46:11.745+0900 W/AUL_AMD (  475): amd_launch.c: __reply_handler(909) > listen fd(29) , send fd(28), pid(2917), cmd(4)
12-11 19:46:11.765+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 0
12-11 19:46:11.885+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:46:12.015+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-11 19:46:12.015+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 19:46:12.015+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 703
12-11 19:46:12.135+0900 E/PKGMGR_SERVER( 3552): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-11 19:46:12.255+0900 E/PKGMGR_SERVER( 3550): pkgmgr-server.c: sighandler(445) > child NORMAL exit [3552]
12-11 19:46:12.285+0900 E/RESOURCED(  481): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-11 19:46:12.290+0900 E/RESOURCED(  481): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-11 19:46:12.290+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(2026) > pad pid(-5)
12-11 19:46:12.295+0900 W/AUL_PAD ( 1208): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-11 19:46:12.295+0900 W/AUL_PAD ( 1208): launchpad.c: __send_result_to_caller(265) > Check app launching
12-11 19:46:12.335+0900 I/CAPI_WATCH_APPLICATION( 3081): watch_app_main.c: watch_app_main(382) > watch_app_main
12-11 19:46:12.360+0900 E/TBM     ( 3081): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-11 19:46:12.395+0900 I/AUL_AMD (  475): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2917
12-11 19:46:12.430+0900 W/WATCH_CORE( 3081): appcore-watch.c: __widget_create(958) > widget_create
12-11 19:46:12.435+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1712) > [SECURE_LOG] [14.824063] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263036:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-11 19:46:12.435+0900 E/WIDGET_VIEWER(  714): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[14.824063] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_714_14.824063.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263036:4] gbar_fname[]
12-11 19:46:12.450+0900 E/WIDGET_VIEWER(  714): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-11 19:46:12.450+0900 E/WIDGET_EVAS(  714): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-11 19:46:12.515+0900 F/EFL     ( 3081): evas_main<3081> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-11 19:46:12.515+0900 F/EFL     ( 3081):     Expected: 70777770 - Evas
12-11 19:46:12.515+0900 F/EFL     ( 3081):     Supplied: 71737723 - Evas_Object
12-11 19:46:12.600+0900 I/CAPI_NETWORK_WIFI( 3081): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-11 19:46:12.610+0900 I/CAPI_NETWORK_WIFI( 3081): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-11 19:46:12.760+0900 W/WATCH_CORE( 3081): appcore-watch.c: __widget_create(976) > widget_create done
12-11 19:46:12.795+0900 I/WATCH_CORE( 3081): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-11 19:46:12.795+0900 I/WATCH_CORE( 3081): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-11 19:46:12.795+0900 I/WATCH_CORE( 3081): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-11 19:46:12.925+0900 E/wnoti-service(  862): wnoti-consumer.c: on_receive(503) > on receive called. payloadLength(54)
12-11 19:46:12.930+0900 E/wnoti-service(  862): wnoti-sap-client.c: publish_received_noti(1848) > 2, category : 0, source : 7, feedback : -1, popup_type(RICH) : 0, application_id : 203, seq_num : 230241, noti_flag : 0, g_span_version : 1
12-11 19:46:12.930+0900 E/wnoti-service(  862): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-11 19:46:12.955+0900 I/wnoti-service(  862): wnoti-msg-builder.c: _publish_notification(1453) > operation_type : 0, source : 0, application_id : 203, display_count : 0
12-11 19:46:12.965+0900 E/wnoti-proxy( 2286): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2286, caller_id : 0, listener_type : 0
12-11 19:46:12.965+0900 I/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1488) > Handle this change type in idler.
12-11 19:46:12.965+0900 I/wnotibp ( 2286): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(918) > ::DATA:: remove notification data, 2815
12-11 19:46:12.965+0900 I/wnotibp ( 2286): wnotiboard-popup-data.c: wnotibp_free_alert_data_by_db_id(948) > ::DATA:: CHECK DATA : 0, 0
12-11 19:46:12.965+0900 E/wnoti-service(  862): wnoti-db-server.c: set_global_noti_count(1555) > pre_count : 1, count : 1
12-11 19:46:12.965+0900 E/wnoti-proxy(  714): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 714, caller_id : 0, listener_type : 0
12-11 19:46:12.965+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 0, op_type: 0, category_id: 203, display count: 0
12-11 19:46:12.965+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1548) > Handle this change type in idler.
12-11 19:46:12.965+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1572) > App tray not displayed and edit mode is off.
12-11 19:46:12.965+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1051) > idler for type: 0
12-11 19:46:12.970+0900 E/wnoti-service(  862): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 19:46:12.990+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:46:12.995+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:46:12.995+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:46:12.995+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1098) > unread_count: 3
12-11 19:46:12.995+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(622) > category_id: 285, application_id: 218, application_name: 카카오톡, time_stamp: 1449830580, content_id: 0, spannable_string_version: 1
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:46:13.000+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:46:13.005+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:46:13.005+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:46:13.005+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:46:13.005+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:46:13.005+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:46:13.005+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:46:13.005+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 13
12-11 19:46:13.005+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 286, application_id: 203, type: 13
12-11 19:46:13.005+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1370) > This noti will be removed from panel: 286, Facebook.
12-11 19:46:13.010+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 286, application_id: 203, type: 2
12-11 19:46:13.010+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(2960) > We don't need to delete the item for second_depth_type: 0.
12-11 19:46:13.010+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_coverview_gl_item_del(3554) > card[0x487e4700]
12-11 19:46:13.010+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_delete_card(3062) > Hide the drawer for the current panel.
12-11 19:46:13.010+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_destroy(4969) > Destory panel, panel application_id [203], panel category_id [286]
12-11 19:46:13.020+0900 E/EFL     (  714): elementary<714> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88018), origin_x(1), origin_y(1)
12-11 19:46:13.020+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_destroy(5104) > Destory panel, -------> Done
12-11 19:46:13.020+0900 W/wnotib  (  714): w-notification-board-panel-manager.c: w_notification_board_panel_manager_destroy_panel(333) > page_instance 286, 0x477d3810 is destoryed!
12-11 19:46:13.020+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 12
12-11 19:46:13.020+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 1, num total noti: 3
12-11 19:46:13.020+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-11 19:46:13.020+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-11 19:46:13.025+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-11 19:46:13.025+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-11 19:46:13.025+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
12-11 19:46:13.025+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-11 19:46:13.025+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 1.
12-11 19:46:13.025+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_update(562) > 0x1
12-11 19:46:13.065+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 1
12-11 19:46:13.065+0900 W/W_HOME  (  714): noti_broker.c: _handler_noti_indicator_show(478) > 
12-11 19:46:13.065+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_update(562) > 0x1
12-11 19:46:13.065+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-11 19:46:13.065+0900 I/RESOURCED(  481): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-11 19:46:13.065+0900 I/RESOURCED(  481): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-11 19:46:13.395+0900 W/AUL_AMD (  475): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-11 19:46:13.395+0900 W/AUL_AMD (  475): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-11 19:46:13.430+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:46:13.440+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3081
12-11 19:46:13.440+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:46:13.490+0900 W/AUL_AMD (  475): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-11 19:46:13.515+0900 E/PKGMGR_SERVER( 3550): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 19:46:13.515+0900 E/PKGMGR_SERVER( 3550): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 19:46:13.655+0900 I/AUL_PAD ( 3584): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-11 19:46:13.705+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_hide(552) > 
12-11 19:46:13.705+0900 W/W_HOME  (  714): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
12-11 19:46:19.905+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:46:19.970+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-11 19:46:19.975+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 26
12-11 19:46:20.010+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
12-11 19:46:20.040+0900 I/AUL_AMD (  475): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/sapd, ret : 0
12-11 19:46:20.040+0900 E/AUL_AMD (  475): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-11 19:46:20.040+0900 W/AUL_AMD (  475): amd_launch.c: _start_app(1659) > caller pid : 479
12-11 19:46:20.065+0900 W/AUL_AMD (  475): amd_launch.c: start_process(573) > child process: 3633
12-11 19:46:20.120+0900 W/AUL_AMD (  475): amd_launch.c: __send_app_launch_signal(376) > send launch signal done: 3633
12-11 19:46:20.125+0900 E/RESOURCED(  481): proc-main.c: proc_add_app_list(272) > [proc_add_app_list,272] not found previous pai : com.samsung.w-contacts2.consumer
12-11 19:46:20.125+0900 E/RESOURCED(  481): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : com.samsung.w-contacts2
12-11 19:46:20.155+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 14
12-11 19:46:20.165+0900 W/AUL_AMD (  475): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3633
12-11 19:46:20.165+0900 W/AUL_AMD (  475): amd_request.c: __request_handler(640) > __request_handler: 12
12-11 19:46:20.220+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
12-11 19:46:20.230+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnIpcClientConnected(172) > MessagePort Ipc connected
12-11 19:46:20.230+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: OnConnectionRequest(411) > _MessagePortIpcServer::OnConnectionRequest
12-11 19:46:20.245+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 19:46:20.245+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 19:46:20.245+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 19:46:20.245+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnRegisterMessagePort(91) > _MessagePortStub::OnRegisterMessagePort.
12-11 19:46:20.245+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: RegisterMessagePort(83) > _MessagePortService::RegisterMessagePort
12-11 19:46:20.245+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 19:46:20.245+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: RegisterMessagePort(95) > Register a message port: [com.samsung.w-contacts2.consumer:w-contacts2-consumer], client = 3633
12-11 19:46:20.245+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 19:46:20.365+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_client_find_peer_agent(1011) > [0;31m* Critical * connectivity_type 0[0;m
12-11 19:46:20.365+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):124264
12-11 19:46:20.365+0900 E/W-CONTACTS2-CONSUMER( 3633): [0;m
12-11 19:46:20.370+0900 W/CAPI_APPFW_APP_CONTROL( 3633): app_control.c: app_control_error(138) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
12-11 19:46:20.370+0900 W/CAPI_APPFW_APP_CONTROL( 3633): app_control.c: app_control_error(138) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
12-11 19:46:20.375+0900 I/WECONN  (  470): esap.c: __sap_service_signal_peeragent_added_cb(1627) > path: /Application/com_2E_samsung_2E_w_2D_contacts2_2E_consumer/b2_contacts_consumer, [sig: PeerAgentAdded]
12-11 19:46:20.385+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __on_create(1797) > [0;31m* Critical * create service connection failed as unknown error 7[0;m
12-11 19:46:22.045+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __on_receive(1204) > [0;31m* Critical * crypt_key for encrypt version !!![0;m
12-11 19:46:22.105+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):127728
12-11 19:46:22.105+0900 E/W-CONTACTS2-CONSUMER( 3633): [0;m
12-11 19:46:22.420+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_client_set_logs_sync_status(1045) > [0;35mlogs_sync_status on reconnection: (3) -> (1)[0;m
12-11 19:46:22.420+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):127208
12-11 19:46:22.420+0900 E/W-CONTACTS2-CONSUMER( 3633): [0;m
12-11 19:46:22.630+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-composer-logs.c: __mark_as_read(654) > [0;35m0 logs has been marked as read[0;m
12-11 19:46:22.660+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-composer-logs.c: ct_sap_svc_composer_logs_reset_notification(555) > [0;35mmissed: 0 / total_missed: 34[0;m
12-11 19:46:22.765+0900 E/wnoti-service(  862): wnoti-db-utility.c: lock_pm(490) > >> lock_pm status : 2
12-11 19:46:22.765+0900 E/wnoti-service(  862): wnoti-server-mgr-stub.c: __wnoti_remove_notification_cards_stub(507) > Remove Card, application_id : 100, source : 0, identifier : 11111111, count : 1
12-11 19:46:22.765+0900 E/wnoti-service(  862): wnoti-db-server.c: wnoti_remove_mini_app_image(2162) > _query_step failed(NO ROW)
12-11 19:46:22.785+0900 I/wnoti-service(  862): wnoti-msg-builder.c: _publish_notification(1453) > operation_type : 0, source : 1, application_id : 100, display_count : 0
12-11 19:46:22.790+0900 E/wnoti-proxy( 2286): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2286, caller_id : 0, listener_type : 0
12-11 19:46:22.790+0900 I/wnotibp ( 2286): wnotiboard-popup-view.c: _wnotibp_noti_manager_data_changed_cb(1488) > Handle this change type in idler.
12-11 19:46:22.790+0900 E/wnoti-proxy(  714): wnoti-client.c: on_wnoti_event(659) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 714, caller_id : 0, listener_type : 0
12-11 19:46:22.790+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1493) > Change type : 0, op_type: 1, category_id: 100, display count: 0
12-11 19:46:22.790+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1548) > Handle this change type in idler.
12-11 19:46:22.790+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_data_changed_cb(1572) > App tray not displayed and edit mode is off.
12-11 19:46:22.790+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1051) > idler for type: 0
12-11 19:46:22.800+0900 E/wnoti-service(  862): wnoti-db-server.c: set_global_noti_count(1555) > pre_count : 1, count : 1
12-11 19:46:22.800+0900 E/wnoti-service(  862): wnoti-db-utility.c: unlock_pm(505) > >> unlock_pm status : 0
12-11 19:46:22.830+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:46:22.830+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:46:22.835+0900 I/wnoti-proxy(  714): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-11 19:46:22.835+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1098) > unread_count: 3
12-11 19:46:22.835+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(622) > category_id: 285, application_id: 218, application_name: 카카오톡, time_stamp: 1449830580, content_id: 0, spannable_string_version: 1
12-11 19:46:22.835+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:46:22.835+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:46:22.835+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:46:22.840+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:46:22.840+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:46:22.840+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:46:22.840+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:46:22.840+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:46:22.840+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:46:22.845+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:46:22.845+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:46:22.845+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:46:22.845+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-11 19:46:22.845+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-11 19:46:22.845+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-11 19:46:22.845+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-11 19:46:22.845+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-11 19:46:22.845+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-11 19:46:22.845+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 13
12-11 19:46:22.850+0900 I/wnotib  (  714): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 285, application_id: 218, type: 12
12-11 19:46:22.850+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 1, num total noti: 3
12-11 19:46:22.850+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-11 19:46:22.850+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-11 19:46:22.850+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-11 19:46:22.850+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-11 19:46:22.850+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
12-11 19:46:22.850+0900 I/wnotib  (  714): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-11 19:46:22.850+0900 I/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 1.
12-11 19:46:22.850+0900 W/W_HOME  (  714): noti_broker.c: _handler_indicator_update(562) > 0x1
12-11 19:46:22.920+0900 W/wnotib  (  714): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 1
12-11 19:46:22.920+0900 W/W_HOME  (  714): noti_broker.c: _handler_noti_indicator_show(478) > 
12-11 19:46:22.950+0900 W/APPS    (  714): AppsItem.cpp: onItemBadgeShow(598) >  badge show:[2:0]
12-11 19:46:22.955+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-composer-logs.c: ct_sap_svc_composer_logs_clear_notification_by_host(692) > [0;35m0 logs updated[0;m
12-11 19:46:22.955+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):133200
12-11 19:46:22.955+0900 E/W-CONTACTS2-CONSUMER( 3633): [0;m
12-11 19:46:23.025+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-composer-logs.c: __log_get_from_db(273) > [0;35mget 1000 records(err:0)[0;m
12-11 19:46:23.060+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_client_set_logs_sync_status(1045) > [0;35mlogs_sync_status on reconnection: (1) -> (2)[0;m
12-11 19:46:23.060+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):241360
12-11 19:46:23.060+0900 E/W-CONTACTS2-CONSUMER( 3633): [0;m
12-11 19:46:23.065+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_client_log_db_noti_changed_cb_for_notification_update(1094) > [0;31m* Critical * current log_sync_status : 3 (SYNC_NONE: 0, SYNC_SUCCESS:2, SYNC_SHOWN:3)[0;m
12-11 19:46:23.900+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __on_ft_receive_complete(2489) > [0;35m1 first_sync_status 5[0;m
12-11 19:46:24.095+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_unzip(490) > [0;31m* Critical * unzip fail (10)[0;m
12-11 19:46:24.100+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_decrypt_data(563) > [0;31m* Critical * EVP_CipherInit_ex - err:1[0;m
12-11 19:46:24.125+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):256328
12-11 19:46:24.125+0900 E/W-CONTACTS2-CONSUMER( 3633): [0;m
12-11 19:46:24.130+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-parser-logs.c: __ct_sap_svc_parser_logs_parse_json_array(467) > [0;35m[PARSER] parser_db_operation_e = 0[0;m
12-11 19:46:24.130+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-parser-logs.c: __ct_sap_svc_parser_logs_parse_json_array(468) > [0;35m[PARSER] single_contact_info array_count = 1[0;m
12-11 19:46:24.165+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-parser-logs.c: __ct_sap_svc_parser_logs_parse_json_array(566) > [0;35moperation completed.(inserted:1, updated:0, deleted:0, result:0)[0;m
12-11 19:46:24.165+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):257872
12-11 19:46:24.165+0900 E/W-CONTACTS2-CONSUMER( 3633): [0;m
12-11 19:46:24.165+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_client_log_db_noti_changed_cb_for_notification_update(1094) > [0;31m* Critical * current log_sync_status : 3 (SYNC_NONE: 0, SYNC_SUCCESS:2, SYNC_SHOWN:3)[0;m
12-11 19:46:24.170+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_client_sync_deleted_logs(1069) > [0;35mnothing to upload[0;m
12-11 19:46:24.170+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_client_set_logs_sync_status(1045) > [0;35mlogs_sync_status on reconnection: (2) -> (3)[0;m
12-11 19:46:24.175+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3633): preference.c: _preference_check_retry_err(507) > key(calllog-markasread-pending), check retry err: -21/(2/No such file or directory).
12-11 19:46:24.175+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3633): preference.c: _preference_get_key(1101) > _preference_get_key(calllog-markasread-pending) step(-17825744) failed(2 / No such file or directory)
12-11 19:46:24.175+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3633): preference.c: preference_get_boolean(1173) > preference_get_boolean(3633) : calllog-markasread-pending error
12-11 19:46:24.175+0900 W/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_client_sync_noti_clear_on_host(208) > [0;35msynced already.[0;m
12-11 19:46:24.180+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_client_read_file(858) > [0;31m* Critical * [PERFORMANCE] __ct_sap_svc_client_read_file end[0;m
12-11 19:46:24.230+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_client_read_files_end(904) > [0;31m* Critical * CALLING __ct_sap_svc_client_exit_consumer - only log[0;m
12-11 19:46:24.610+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-parser-contacts.c: ct_sap_svc_parser_contacts_get_buddylist(2513) > [0;31m* Critical * json_object_has_member(rawContacts) is failed[0;m
12-11 19:46:24.610+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-parser-contacts.c: ct_sap_svc_parser_contacts_get_buddylist(2561) > [0;31m* Critical * json_array_get_length(0)[0;m
12-11 19:46:24.615+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_free_foreach_data(1338) > [0;31m* Critical * foreach_data is NULL[0;m
12-11 19:46:24.615+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-parser-contacts.c: __ct_sap_svc_parser_free_contacts_record_hash_table_for_buddy(1485) > [0;31m* Critical * (NULL == __hash_table_contacts_for_buddy)[0;m
12-11 19:46:24.635+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: ct_sap_svc_client_mem_info(2885) > [0;31m* Critical * Total allocated space (uordblks):255544
12-11 19:46:24.635+0900 E/W-CONTACTS2-CONSUMER( 3633): [0;m
12-11 19:46:24.635+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-11 19:46:24.635+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-11 19:46:24.640+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-11 19:46:24.640+0900 I/MESSAGE_PORT(  438): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-11 19:46:24.640+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-11 19:46:24.640+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-11 19:46:24.640+0900 I/MESSAGE_PORT(  438): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-buddy:w-buddy]
12-11 19:46:24.640+0900 E/MESSAGE_PORT(  438): MessagePortService.cpp: SendMessage(354) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-11 19:46:24.640+0900 I/MESSAGE_PORT(  438): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-11 19:46:24.640+0900 E/MESSAGE_PORT( 3633): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
12-11 19:46:24.650+0900 E/SHealth_Common( 1049): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-11 19:46:25.290+0900 E/W-CONTACTS2-CONSUMER( 3633): ct-sap-svc-client.c: __ct_sap_svc_decrypt_data(563) > [0;31m* Critical * EVP_CipherInit_ex - err:1[0;m
12-11 19:46:28.210+0900 I/RESOURCED(  481): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 95 -> 94 1449830788 511
12-11 19:46:28.215+0900 I/RESOURCED(  481): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 1151 40 1803
12-11 19:46:28.220+0900 I/RESOURCED(  481): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 0 0 1508
12-11 19:46:28.220+0900 I/RESOURCED(  481): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 1359 240 2129
12-11 19:46:28.220+0900 I/RESOURCED(  481): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 534 5 837
12-11 19:46:28.220+0900 I/RESOURCED(  481): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 94 534 5 837
12-11 19:46:29.155+0900 E/PKGMGR  ( 3703): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-11 19:46:29.350+0900 E/PKGMGR_SERVER( 3705): pkgmgr-server.c: main(2126) > package manager server start
12-11 19:46:29.430+0900 E/PKGMGR_SERVER( 3705): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_153912344], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_153912344' '-r' 'org.reolab.blackandwhite'], cookie=[2UZ1kdMPFpDhwlNd8lDv145SbN0=], backend_flag=[0]
12-11 19:46:29.435+0900 E/PKGMGR  ( 3705): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-11 19:46:29.435+0900 E/PKGMGR_SERVER( 3705): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-11 19:46:29.440+0900 E/PKGMGR  ( 3703): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[37030002]
12-11 19:46:29.440+0900 E/PKGMGR_SERVER( 3706): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-11 19:46:29.625+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-11 19:46:29.635+0900 W/AUL_AMD (  475): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-11 19:46:29.650+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:46:29.655+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-11 19:46:30.230+0900 E/PKGMGR_CERT( 3706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-11 19:46:30.240+0900 E/PKGMGR_CERT( 3706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 94
12-11 19:46:30.240+0900 E/PKGMGR_CERT( 3706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 94
12-11 19:46:30.240+0900 E/PKGMGR_CERT( 3706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-11 19:46:30.240+0900 E/PKGMGR_CERT( 3706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-11 19:46:30.245+0900 E/PKGMGR_CERT( 3706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-11 19:46:30.245+0900 E/PKGMGR_CERT( 3706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-11 19:46:30.255+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:46:30.270+0900 E/PKGMGR_CERT( 3706): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-11 19:46:31.515+0900 E/PKGMGR_SERVER( 3705): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:46:32.090+0900 E/rpm-installer( 3706): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-11 19:46:33.515+0900 E/PKGMGR_SERVER( 3705): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-11 19:46:35.095+0900 E/PKGMGR_SERVER( 3705): pkgmgr-server.c: sighandler(445) > child NORMAL exit [3706]
12-11 19:46:35.100+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-11 19:46:35.115+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-11 19:46:35.115+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-11 19:46:35.135+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-11 19:46:35.135+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-11 19:46:35.135+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-11 19:46:35.135+0900 E/WMS     (  480): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-11 19:46:35.145+0900 W/W_HOME  (  714): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-11 19:46:35.200+0900 E/PKGMGR_INFO(  479): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-11 19:46:35.255+0900 E/APPS    (  714): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-11 19:46:35.515+0900 E/PKGMGR_SERVER( 3705): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-11 19:46:35.515+0900 E/PKGMGR_SERVER( 3705): pkgmgr-server.c: main(2180) > package manager server terminated.
12-11 19:46:35.600+0900 W/CRASH_MANAGER( 3710): worker.c: worker_job(1199) > 1103081626c61144983079
