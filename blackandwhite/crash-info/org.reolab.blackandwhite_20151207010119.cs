S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 9400
Date: 2015-12-07 01:01:19+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xa54

Register Information
r0   = 0xbefca2f8, r1   = 0xbefca198
r2   = 0x00000000, r3   = 0x00000000
r4   = 0xbefca560, r5   = 0xbefca2f8
r6   = 0x00000132, r7   = 0xbefca2a8
r8   = 0x4030b9c0, r9   = 0x41a3c4f0
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4145c6a0, sp   = 0xbefca168
lr   = 0x41454177, pc   = 0x00000a54
cpsr = 0xa0000010

Memory Information
MemTotal:   491012 KB
MemFree:     29080 KB
Buffers:     11588 KB
Cached:      92328 KB
VmPeak:      76460 KB
VmSize:      75948 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14676 KB
VmRSS:       14676 KB
VmData:      21688 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20468 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9400 TID = 9400
9400 9538 9550 

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
4145d000 4145f000 r-xp /usr/lib/libdri2.so.0.0.0
41467000 4146c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41474000 41476000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4147f000 41485000 r-xp /usr/lib/libappsvc.so.0.1.0
4148d000 414b1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
414ba000 41589000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4159f000 415a9000 r-xp /lib/libnss_files-2.13.so
41770000 41774000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41784000 4178b000 r-xp /usr/lib/libappcore-watch.so.1.1
41794000 417a1000 r-xp /usr/lib/libalarm.so.0.0.0
417aa000 418e7000 r-xp /usr/lib/libicui18n.so.51.1
418f7000 419db000 r-xp /usr/lib/libicuuc.so.51.1
419f0000 419f6000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
419fe000 41a04000 rw-p [heap]
41a04000 41b36000 rw-p [heap]
41b36000 41b3c000 r-xp /usr/lib/libwidget.so.1.0.0
430cc000 430d5000 r-xp /usr/lib/libcom-core.so.0.0.1
430de000 430ea000 r-xp /usr/lib/libwidget_service.so.1.0.0
430f2000 430fb000 r-xp /usr/lib/libwidget_provider.so.1.0.0
43104000 4310c000 r-xp /usr/lib/libdrm.so.2.4.0
43114000 43119000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
43121000 43128000 r-xp /usr/lib/libtbm.so.1.0.0
43562000 43d61000 rw-p [stack:9538]
43d61000 43d64000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d6c000 43d77000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dff000 43e16000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44056000 44900000 rw-p [stack:9550]
befaa000 befcb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9400)
Call Stack Count: 1
 0: (0xa54) (null)
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
), hold(0) freeze(0)
12-07 01:01:10.885+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=40925757 button=1 downs=0
12-07 01:01:10.970+0900 E/EFL     (  715): evas_main<715> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x4b096640 is not stable during recalc loop
12-07 01:01:11.030+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group elm/popup/base/circle has a non-fixed part 'elm.swallow.content'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:11.030+0900 E/EFL     (  715): evas_main<715> evas_object_smart.c:751 evas_object_smart_need_recalculate_set() Object 0x4b096640 is not stable during recalc loop
12-07 01:01:11.130+0900 E/PKGMGR_SERVER( 9525): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 01:01:11.130+0900 E/PKGMGR_SERVER( 9525): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 01:01:11.530+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=40926400 button=1 downs=1
12-07 01:01:11.600+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=40926460 button=1 downs=0
12-07 01:01:11.645+0900 E/PKGMGR  (  715): pkgmgr.c: __pkgmgr_client_uninstall(1944) > uninstall pkg start.
12-07 01:01:11.695+0900 E/PKGMGR  (  715): pkgmgr.c: __pkgmgr_client_uninstall(2007) > caller pkgid = com.samsung.w-home
12-07 01:01:11.855+0900 E/PKGMGR_SERVER( 9529): pkgmgr-server.c: main(2126) > package manager server start
12-07 01:01:11.940+0900 E/PKGMGR_SERVER( 9529): pkgmgr-server.c: req_cb(686) > req_id=[g9oohd8Jkk_-646748326], req_type=[2], pkg_type=[wgt], pkgid=[g9oohd8Jkk], args=[/usr/etc/package-manager/backend/wgt '-k' 'g9oohd8Jkk_-646748326' '-d' 'g9oohd8Jkk' '-p' 'com.samsung.w-home'], cookie=[dmOhgDRuvJoPNyp1CjZLjT3ICfA=], backend_flag=[0]
12-07 01:01:11.955+0900 E/PKGMGR  (  715): pkgmgr.c: __pkgmgr_client_uninstall(2069) > uninstall pkg finish, ret=[7150015]
12-07 01:01:11.955+0900 E/PKGMGR_SERVER( 9530): pkgmgr-server.c: queue_job(1838) > UNINSTALL start, pkgid=[g9oohd8Jkk]
12-07 01:01:11.955+0900 E/CLOCK-LIST(  715): clocklist_db.c: _setting_create_list_update(651) > g9oohd8Jkk is not exist in DB
12-07 01:01:12.215+0900 I/AUL     ( 9530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/etc/package-manager/backend/wgt, ret : 0
12-07 01:01:12.230+0900 I/AUL     ( 9530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/pkgmgr-server, ret : 0
12-07 01:01:12.230+0900 E/CAPI_APPFW_APPLICATION( 9530): app_error.c: app_error(64) > [app_get_id] INVALID_CONTEXT(0xfef00001) : failed to get the application ID
12-07 01:01:12.230+0900 E/CAPI_APPFW_APPLICATION( 9530): app_error.c: app_error(64) > [ui_app_main] INVALID_CONTEXT(0xfef00001) : failed to get the package
12-07 01:01:12.355+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 01:01:12.365+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-07 01:01:12.370+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 01:01:12.380+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/etc/package-manager/backend/wgt, ret : 0
12-07 01:01:12.390+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/pkgmgr-server, ret : 0
12-07 01:01:12.390+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 01:01:12.390+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 9530
12-07 01:01:12.390+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UNINSTALL, STARTED]
12-07 01:01:12.395+0900 W/AUL_AMD (  495): amd_launch.c: __nofork_processing(1138) > __nofork_processing, cmd: 0, pid: 3968
12-07 01:01:12.395+0900 I/APP_CORE( 3968): appcore-efl.c: __do_app(429) > [APP 3968] Event: RESET State: RUNNING
12-07 01:01:12.395+0900 I/CAPI_APPFW_APPLICATION( 3968): app_main.c: app_appcore_reset(245) > app_appcore_reset
12-07 01:01:12.395+0900 W/CAPI_APPFW_APP_CONTROL( 3968): app_control.c: app_control_error(138) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
12-07 01:01:12.400+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(3968), cmd(0)
12-07 01:01:12.400+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(193) > Pkg:g9oohd8Jkk is being uninstalled
12-07 01:01:12.400+0900 W/W_HOME  (  715): dbox.c: uninstall_cb(1201) > uninstalled:g9oohd8Jkk
12-07 01:01:12.400+0900 I/APP_CORE( 3968): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
12-07 01:01:12.400+0900 I/APP_CORE( 3968): appcore-efl.c: __do_app(481) > [APP 3968] App already running, raise the window
12-07 01:01:12.405+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 01:01:12.410+0900 W/W_HOME  (  715): dbox.c: _widget_list_by_pkgid_cb(1188) > adding [g9oohd8Jkk.MrTime98]
12-07 01:01:12.410+0900 E/PKGMGR_PARSER( 9530): pkgmgr_parser_signature.c: __ps_check_mdm_policy(977) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
12-07 01:01:12.440+0900 E/PKGMGR_PARSER( 9530): pkgmgr_parser_signature.c: __ps_check_mdm_policy(977) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
12-07 01:01:12.450+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 01:01:12.450+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 6-12-2015, 16:06:27 (UTC).
12-07 01:01:12.450+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 01:01:12.550+0900 I/efl-extension( 9530): efl_extension.c: eext_mod_init(40) > Init
12-07 01:01:12.550+0900 I/efl-extension( 9530): efl_extension.c: eext_mod_shutdown(46) > Shutdown
12-07 01:01:12.615+0900 E/PKGMGR_CERT( 9530): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
12-07 01:01:12.615+0900 E/PKGMGR_CERT( 9530): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
12-07 01:01:12.625+0900 E/PKGMGR_CERT( 9530): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
12-07 01:01:12.755+0900 I/RESOURCED(  498): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] abnormal cache is empty
12-07 01:01:12.755+0900 I/RESOURCED(  498): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] cpu cache is empty
12-07 01:01:12.755+0900 I/RESOURCED(  498): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] battery cache is empty
12-07 01:01:12.755+0900 I/RESOURCED(  498): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-07 01:01:13.370+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UNINSTALL, COMPLETED]
12-07 01:01:13.370+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6750) > package uninstall complete
12-07 01:01:13.370+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6756) > disabled_pkg_list : 
12-07 01:01:13.370+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_package_uninstall_event(4568) > 
12-07 01:01:13.370+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-07 01:01:13.370+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_package_uninstall_event(4574) > installe_req_list is NULL.
12-07 01:01:13.375+0900 E/APP_SHORTCUT(  803): pkgmgr.c: _end(346) >  Remove the g9oohd8Jkk from the shortcut because of uninstall
12-07 01:01:13.385+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(819) > g_hash_table_foreach_remove, 1
12-07 01:01:13.390+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-07 01:01:13.390+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 6-12-2015, 16:06:27 (UTC).
12-07 01:01:13.390+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-07 01:01:13.395+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 01:01:13.395+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 01:01:13.410+0900 E/WMS     (  491): wms_db.c: wms_db_package_event_insert_record(178) > 
12-07 01:01:13.530+0900 E/PKGMGR_SERVER( 9529): pkgmgr-server.c: sighandler(445) > child NORMAL exit [9530]
12-07 01:01:13.565+0900 E/EFL     (  715): elementary<715> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0x49a8b4d8 into part 'elm.swallow.event.0'
12-07 01:01:13.610+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.615+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.615+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.615+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.620+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.620+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.620+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.625+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.625+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.625+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.630+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.630+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.630+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.630+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.635+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.635+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.635+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.640+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.640+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.640+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.645+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.655+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.655+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.660+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.660+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.660+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.660+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.665+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.665+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.665+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.670+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.670+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.675+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.675+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.675+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.680+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.680+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.680+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.680+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.685+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.685+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.695+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group setting/layout/body_thumbnail_circle/home has a non-fixed part 'edit.btn.line'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:13.745+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(225) > Pkg:g9oohd8Jkk is uninstalled, delete related resource
12-07 01:01:13.745+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(229) > attacheck clock:WqpvTWhGk0
12-07 01:01:13.745+0900 W/W_HOME  (  715): dbox.c: uninstall_cb(1201) > uninstalled:g9oohd8Jkk
12-07 01:01:14.130+0900 E/PKGMGR_SERVER( 9529): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-07 01:01:14.130+0900 E/PKGMGR_SERVER( 9529): pkgmgr-server.c: main(2180) > package manager server terminated.
12-07 01:01:14.250+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), block(1)
12-07 01:01:14.250+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), ev->cur.canvas.x(187) ev->cur.canvas.y(158)
12-07 01:01:14.250+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), hold(0) freeze(0)
12-07 01:01:14.255+0900 E/EFL     (  715): evas_main<715> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=40929103 button=1 downs=1
12-07 01:01:14.260+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), block(1)
12-07 01:01:14.260+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), ev->cur.canvas.x(186) ev->cur.canvas.y(158)
12-07 01:01:14.260+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), hold(0) freeze(0)
12-07 01:01:14.280+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), block(1)
12-07 01:01:14.280+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), ev->cur.canvas.x(185) ev->cur.canvas.y(158)
12-07 01:01:14.280+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), hold(0) freeze(0)
12-07 01:01:14.280+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3964 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), block(1)
12-07 01:01:14.280+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3978 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), ev->cur.canvas.x(182) ev->cur.canvas.y(158)
12-07 01:01:14.280+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:3979 _elm_scroll_mouse_move_event_cb() [DDO] obj(49a85730), hold(0) freeze(0)
12-07 01:01:14.295+0900 E/EFL     (  715): evas_main<715> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=40929155 button=1 downs=0
12-07 01:01:14.370+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_vconf_clocks_set_idle(6366) > ConnectionType[16] is not BT, ignore this callback.
12-07 01:01:14.380+0900 W/W_HOME  (  715): rotary.c: rotary_deattach(156) > rotary_deattach:0x49a85730
12-07 01:01:14.380+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8a6a8, elm_box, _activated_obj : 0x4b000948, activated : 1
12-07 01:01:14.380+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
12-07 01:01:14.380+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 01:01:14.380+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5125) > Return true for 199, 218.
12-07 01:01:14.380+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
12-07 01:01:14.380+0900 I/MESSAGE_PORT(  715): MessagePortProxy.cpp: IsLocalPortRegisted(695) > MessagePort name is already registered.
12-07 01:01:14.380+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 01:01:14.380+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 01:01:14.380+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 01:01:14.380+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnUnregisterMessagePort(103) > _MessagePortStub::OnUnregisterMessagePort.
12-07 01:01:14.380+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: UnregisterMessagePort(152) > _MessagePortService::UnregisterMessagePort
12-07 01:01:14.380+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 01:01:14.380+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: UnregisterMessagePort(162) > Unregister a message port: [com.samsung.w-home:w-home::localport], client = 715
12-07 01:01:14.380+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 01:01:14.380+0900 E/EFL     (  715): edje<715> edje_util.c:3770 edje_object_size_min_restricted_calc() group page has a non-fixed part 'clipper'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
12-07 01:01:14.435+0900 W/W_HOME  (  715): clock_service.c: clock_service_event_handler(821) > scroller freeze off
12-07 01:01:14.435+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45c88128), freeze(0)
12-07 01:01:14.435+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:5302 _elm_scroll_freeze_set() [DDO] obj(45c88128), freeze(0)
12-07 01:01:14.435+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:4001f5a7
12-07 01:01:14.435+0900 W/W_HOME  (  715): clock_service.c: _clock_service_heartbeat_pump(527) > clock service pump: org.reolab.blackandwhite 1 0 0 1
12-07 01:01:14.435+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-07 01:01:14.435+0900 E/W_HOME  (  715): clock_service.c: _clock_provider_change(396) > clock will be changed to org.reolab.blackandwhite
12-07 01:01:14.450+0900 E/W_HOME  (  715): dbox.c: widget_create(359) > add-viewer info none: org.reolab.blackandwhite
12-07 01:01:14.455+0900 W/W_HOME  (  715): clock_inf_dbox.c: _is_preload_watchface(166) > ret:1
12-07 01:01:14.455+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_resize(5435) > [SECURE_LOG] Failed to get box size
12-07 01:01:14.455+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_is_created_by_user(3452) > [SECURE_LOG] Handler is invalid
12-07 01:01:14.460+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-07 01:01:14.460+0900 E/W_HOME  (  715): clock_service.c: _set_waiting_timer(356) > clock waiting timer is started
12-07 01:01:14.460+0900 E/W_HOME  (  715): dbus_util.c: home_dbus_lcd_on_signal_send(225) > Sending LCD ON request signal wristup:0 result:0
12-07 01:01:14.460+0900 W/W_HOME  (  715): cs_broker.c: _wms_clock_vconf_cb(283) > 
12-07 01:01:14.460+0900 E/CLOCK-LIST(  715): clocklist_main.c: clock_setting_event(3637) > proxy image is not deleted. Ignore event
12-07 01:01:14.460+0900 W/W_HOME  (  715): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,will,hide
12-07 01:01:14.460+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 01:01:14.460+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 01:01:14.460+0900 W/W_HOME  (  715): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-07 01:01:14.460+0900 W/W_HOME  (  715): main.c: home_resume(733) > clock/widget resumed
12-07 01:01:14.525+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-07 01:01:14.540+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 01:01:14.550+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-07 01:01:14.550+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-07 01:01:14.550+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-07 01:01:14.565+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-07 01:01:14.565+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-07 01:01:14.570+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-07 01:01:14.570+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-07 01:01:14.570+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-07 01:01:14.600+0900 I/CAPI_WATCH_APPLICATION( 9400): watch_app_main.c: watch_app_main(382) > watch_app_main
12-07 01:01:14.630+0900 E/TBM     ( 9400): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-07 01:01:14.675+0900 W/WATCH_CORE(24695): appcore-watch.c: __widget_resume(1012) > widget_resume
12-07 01:01:14.675+0900 E/RESOURCED(  498): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.reolab.blackandwhite
12-07 01:01:14.675+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
12-07 01:01:14.675+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
12-07 01:01:14.685+0900 I/CAPI_WATCH_APPLICATION(24695): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 01:01:14.765+0900 W/WATCH_CORE( 9400): appcore-watch.c: __widget_create(958) > widget_create
12-07 01:01:14.795+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [40929.328125] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_40929.328125.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-07 01:01:14.795+0900 W/W_HOME  (  715): dbox.c: _widget_created_cb(238) > widget resume:0x49c4d338
12-07 01:01:14.795+0900 E/WIDGET_VIEWER(  715): fb.c: fb_is_created(425) > [SECURE_LOG] access: 2 ((null))
12-07 01:01:14.865+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-07 01:01:14.865+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-07 01:01:14.920+0900 W/WATCH_CORE( 9400): appcore-watch.c: __widget_create(976) > widget_create done
12-07 01:01:15.000+0900 I/CAPI_WATCH_APPLICATION(24695): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 01:01:15.015+0900 I/WATCH_CORE( 9400): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-07 01:01:15.015+0900 I/WATCH_CORE( 9400): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-07 01:01:15.015+0900 I/WATCH_CORE( 9400): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-07 01:01:15.050+0900 W/WATCH_CORE( 9400): appcore-watch.c: __widget_resume(1012) > widget_resume
12-07 01:01:15.080+0900 I/CAPI_WATCH_APPLICATION( 9400): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 01:01:15.675+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-07 01:01:15.675+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-07 01:01:15.690+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-07 01:01:15.695+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 9400
12-07 01:01:15.695+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-07 01:01:15.955+0900 I/AUL_PAD ( 9557): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-07 01:01:15.995+0900 I/CAPI_WATCH_APPLICATION( 9400): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 01:01:16.000+0900 E/W_HOME  (  715): clock_service.c: _del_waiting_timer(347) > clock waiting timer is deleted
12-07 01:01:16.005+0900 I/CAPI_WATCH_APPLICATION(24695): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 01:01:16.025+0900 W/W_HOME  (  715): clock_view.c: clock_view_attach(512) > changed pause/resume option -> manual
12-07 01:01:16.025+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88128), origin_x(0), origin_y(0)
12-07 01:01:16.030+0900 W/W_HOME  (  715): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
12-07 01:01:16.030+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 01:01:16.035+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88128), origin_x(0), origin_y(0)
12-07 01:01:16.040+0900 W/W_HOME  (  715): event_manager.c: _clock_view_visible_cb(608) > state: 0 -> 1
12-07 01:01:16.040+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:1, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 01:01:16.045+0900 W/W_HOME  (  715): clock_view.c: clock_view_attach(529) > changed pause/resume option -> automatic
12-07 01:01:16.045+0900 W/W_HOME  (  715): clock_manager.c: clock_manager_clock_set(255) > attached clock isn't cleaned-up, yet
12-07 01:01:16.045+0900 E/W_HOME  (  715): page.c: _page_clip_del(240) > (!page_info) -> _page_clip_del() return
12-07 01:01:16.045+0900 E/W_HOME  (  715): page.c: _destroy_page_line(218) > (!box) -> _destroy_page_line() return
12-07 01:01:16.050+0900 W/W_HOME  (  715): clock_inf_dbox.c: del_cleanup_cb(373) > deleted
12-07 01:01:16.050+0900 E/W_HOME  (  715): dbox.c: del_cb(225) > Add viewer has no info: WqpvTWhGk0.gearoclockswisssense
12-07 01:01:16.050+0900 W/W_HOME  (  715): cfwd.c: cfwd_get_icon_status(362) > 
12-07 01:01:16.050+0900 W/W_HOME  (  715): ============================
12-07 01:01:16.050+0900 W/W_HOME  (  715): multi_sim_category:0
12-07 01:01:16.050+0900 W/W_HOME  (  715): multi_sim_model:0
12-07 01:01:16.050+0900 W/W_HOME  (  715): support_callforward_auto:0
12-07 01:01:16.050+0900 W/W_HOME  (  715): conn_status:16
12-07 01:01:16.050+0900 W/W_HOME  (  715): remote_call_forward_auto:0
12-07 01:01:16.050+0900 W/W_HOME  (  715): auto_call_forward_status:0
12-07 01:01:16.050+0900 W/W_HOME  (  715): support_callforward_reverse:0
12-07 01:01:16.050+0900 W/W_HOME  (  715): reverse_call_forward_auto:0
12-07 01:01:16.050+0900 W/W_HOME  (  715): fwd_type:
12-07 01:01:16.050+0900 W/W_HOME  (  715): ============================
12-07 01:01:16.050+0900 W/W_HOME  (  715): 
12-07 01:01:16.050+0900 W/W_HOME  (  715): clock_view_indicator.c: _view_call_fw_icon(131) > call fwd status:0
12-07 01:01:16.055+0900 E/W_HOME  (  715): clock_event.c: _flightmode_state_get(417) > Failed to get VCONFKEY_TELEPHONY_FLIGHT_MODE:db/telephony/flight_mode
12-07 01:01:16.055+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-07 01:01:16.055+0900 W/W_HOME  (  715): noti_broker.c: _clock_attached_cb(804) > 0
12-07 01:01:16.055+0900 W/W_HOME  (  715): cs_broker.c: _clock_view_attached_cb(231) > 
12-07 01:01:16.060+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:40043c11
12-07 01:01:16.060+0900 W/W_HOME  (  715): event_manager.c: _home_layout_clocklist_cb(521) > clocklist,hide
12-07 01:01:16.060+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 01:01:16.060+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-07 01:01:16.060+0900 I/CLOCK-LIST(  715): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(264) > send watch_list_event, watch_list_out
12-07 01:01:16.060+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-07 01:01:16.060+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-07 01:01:16.060+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-07 01:01:16.060+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-07 01:01:16.060+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-07 01:01:16.060+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-07 01:01:16.060+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [org.reolab.blackandwhite:watchface::messageport::event]
12-07 01:01:16.060+0900 E/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(354) > _MessagePortService::SendMessage: Failed :MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
12-07 01:01:16.060+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-07 01:01:16.060+0900 E/MESSAGE_PORT(  715): MessagePortProxy.cpp: SendMessageInternal(533) > The remote message port is not found.
12-07 01:01:16.060+0900 E/CLOCK-LIST(  715): clocklist_main.c: __setting_clock_list_send_message_port_watch_list_out_event(268) > message_port_send_message returns -18022399(feed0001)
12-07 01:01:16.070+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45c8a6a8, elm_box, _activated_obj : 0x45c8a6a8, activated : 1
12-07 01:01:16.070+0900 E/wnotib  (  715): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-07 01:01:16.070+0900 I/wnotib  (  715): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5125) > Return true for 199, 218.
12-07 01:01:16.070+0900 I/wnotib  (  715): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1108) > No second depth view available.
12-07 01:01:16.070+0900 I/efl-extension(  715): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x49a85730, obj: 0x49a85730
12-07 01:01:16.070+0900 I/efl-extension(  715): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-07 01:01:16.070+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 01:01:16.070+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x49a85730, elm_scroller, func : 0x4072fe19
12-07 01:01:16.070+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 01:01:16.070+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-07 01:01:16.070+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4b000948, elm_image, func : 0x4072fe19
12-07 01:01:16.070+0900 I/efl-extension(  715): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-07 01:01:16.070+0900 I/efl-extension(  715): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(841) > [0x49a85730 : elm_scroller] rotary callabck is deleted
12-07 01:01:16.165+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-07 01:01:16.190+0900 W/WATCH_CORE(24695): appcore-watch.c: __widget_pause(1001) > widget_pause
12-07 01:01:16.330+0900 E/W_HOME  (  715): page_indicator.c: page_indicator_item_at(248) > (index < 0 || index >= PAGE_INDICATOR_MAX) -> page_indicator_item_at() return
12-07 01:01:16.355+0900 W/WATCH_CORE(24695): appcore-watch.c: __widget_destroy(992) > widget_destory
12-07 01:01:16.355+0900 E/W_HOME  (  715): move.c: move_back_to_home_no_anim(270) > home is already on position
12-07 01:01:16.355+0900 W/W_HOME  (  715): scroller.c: _get_index_in_list(1902) > page:0x4ade0ef0 idx:1 total11 exist:1
12-07 01:01:16.355+0900 W/W_HOME  (  715): scroller.c: scroller_unfreeze(1860) > unfreezed:4005277b
12-07 01:01:16.355+0900 E/EFL     (  715): elementary<715> elm_interface_scrollable.c:1270 _elm_scroll_origin_reverse_set() [DDO] obj(45c88128), origin_x(0), origin_y(0)
12-07 01:01:16.355+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 22
12-07 01:01:16.355+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(884) > app status : 4
12-07 01:01:16.360+0900 W/CAPI_WATCH_APPLICATION(24695): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-07 01:01:16.360+0900 I/efl-extension( 1172): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-07 01:01:16.360+0900 W/wnotibp ( 1172): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1721) > [0, 2, 1]
12-07 01:01:16.360+0900 E/TIZEN_N_SYSTEM_SETTINGS(24695): system_settings.c: system_settings_unset_changed_cb(571) > Enter [system_settings_unset_changed_cb]
12-07 01:01:16.360+0900 E/TIZEN_N_SYSTEM_SETTINGS(24695): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
12-07 01:01:16.360+0900 E/TIZEN_N_SYSTEM_SETTINGS(24695): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
12-07 01:01:16.360+0900 W/W_HOME  (  715): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
12-07 01:01:16.365+0900 I/efl-extension(24695): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x47003720
12-07 01:01:16.365+0900 I/efl-extension(24695): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x47003720, obj: 0x47003720
12-07 01:01:16.365+0900 I/efl-extension(24695): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
12-07 01:01:16.365+0900 I/efl-extension(24695): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
12-07 01:01:16.365+0900 I/efl-extension(24695): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
12-07 01:01:16.365+0900 I/efl-extension(24695): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-07 01:01:16.370+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02400003)
12-07 01:01:16.370+0900 E/EFL     (24695): EvasGL<24695> evas_gl_api_ext.c:113 _evgl_egl_display_get() _evgl_evasglDestroyImage: Unable to retrive Current Engine
12-07 01:01:16.370+0900 E/EFL     (24695): EvasGL<24695> evas_gl_api_ext.c:113 _evgl_egl_display_get() _evgl_evasglDestroyImage: Unable to retrive Current Engine
12-07 01:01:16.375+0900 E/EFL     (24695): EvasGL<24695> evas_gl_api_ext.c:113 _evgl_egl_display_get() _evgl_evasglDestroyImage: Unable to retrive Current Engine
12-07 01:01:16.395+0900 E/CAPI_LOCATION_MANAGER(24695): locations.c: location_manager_destroy(711) > LOCATIONS_ERROR_INVALID_PARAMETER(0xffffffea)
12-07 01:01:16.425+0900 E/WIDGET_PROVIDER_APP(24695): client.c: client_fini(1175) > Provider is not initialized
12-07 01:01:16.505+0900 I/UXT     (24695): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
12-07 01:01:16.735+0900 I/efl-extension(24695): efl_extension.c: eext_mod_shutdown(46) > Shutdown
12-07 01:01:16.750+0900 I/MALI    (24695): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
12-07 01:01:16.750+0900 I/MALI    (24695): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=24695   close drm_fd=29 
12-07 01:01:16.750+0900 I/MALI    (24695): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
12-07 01:01:17.000+0900 I/CAPI_WATCH_APPLICATION( 9400): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 01:01:17.020+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 24695
12-07 01:01:17.930+0900 E/PKGMGR  ( 9590): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-07 01:01:18.000+0900 I/CAPI_WATCH_APPLICATION( 9400): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 01:01:18.160+0900 E/PKGMGR_SERVER( 9592): pkgmgr-server.c: main(2126) > package manager server start
12-07 01:01:18.300+0900 E/PKGMGR_SERVER( 9592): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-640460591], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-640460591' '-r' 'org.reolab.blackandwhite'], cookie=[bMTPzB/RXZIBLmhW67EeW/2jIGs=], backend_flag=[0]
12-07 01:01:18.300+0900 E/PKGMGR  ( 9592): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-07 01:01:18.300+0900 E/PKGMGR_SERVER( 9592): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-07 01:01:18.310+0900 E/PKGMGR_SERVER( 9593): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-07 01:01:18.310+0900 E/PKGMGR  ( 9590): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[95900002]
12-07 01:01:18.360+0900 W/AUL_AMD (  495): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-07 01:01:18.455+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-07 01:01:18.460+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-07 01:01:18.475+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-07 01:01:18.500+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-07 01:01:19.000+0900 I/CAPI_WATCH_APPLICATION( 9400): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-07 01:01:19.245+0900 W/CRASH_MANAGER( 9595): worker.c: worker_job(1199) > 1109400626c61144941767
