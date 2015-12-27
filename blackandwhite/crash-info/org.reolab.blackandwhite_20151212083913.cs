S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 17778
Date: 2015-12-12 08:39:13+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xe88

Register Information
r0   = 0x41c3d0d8, r1   = 0x000000ff
r2   = 0x000000ff, r3   = 0x000000ff
r4   = 0xbea655d0, r5   = 0xbea652d0
r6   = 0x00000132, r7   = 0xbea64a00
r8   = 0x4030b9c0, r9   = 0x41b6d078
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4145d5d4, sp   = 0xbea649f0
lr   = 0x41454385, pc   = 0x00000e88
cpsr = 0x20000010

Memory Information
MemTotal:   489992 KB
MemFree:     20528 KB
Buffers:     13732 KB
Cached:     109480 KB
VmPeak:     111700 KB
VmSize:     111188 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16116 KB
VmRSS:       16116 KB
VmData:      54660 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 17778 TID = 17778
17778 17941 17952 

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
41b1e000 41b23000 r-xp /usr/lib/libcsc-feature.so.0.0.0
41b2b000 41b34000 rw-p [heap]
41b34000 41c67000 rw-p [heap]
41c67000 41c98000 r-xp /usr/lib/libmdm.so.1.1.85
41ca0000 41cb6000 r-xp /usr/lib/libnetwork.so.0.0.0
43246000 4324f000 r-xp /usr/lib/libcom-core.so.0.0.1
43258000 43264000 r-xp /usr/lib/libwidget_service.so.1.0.0
4326c000 43275000 r-xp /usr/lib/libwidget_provider.so.1.0.0
4327e000 43284000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4328c000 43294000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4329c000 432ca000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
432d6000 432de000 r-xp /usr/lib/libdrm.so.2.4.0
432e6000 432e8000 r-xp /usr/lib/libdri2.so.0.0.0
432f0000 432f7000 r-xp /usr/lib/libtbm.so.1.0.0
432ff000 43319000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43322000 43329000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43332000 43334000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4333c000 43343000 r-xp /usr/lib/libminizip.so.1.0.0
4334b000 43358000 r-xp /usr/lib/libail.so.0.1.0
43793000 43f92000 rw-p [stack:17941]
43f92000 43f95000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f9d000 43fa8000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43fb1000 43fc8000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
44286000 44288000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45401000 45c00000 rw-p [stack:17952]
bea45000 bea66000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17778)
Call Stack Count: 1
 0: (0xe88) (null)
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
il)
12-12 08:37:15.996+0900 I/CAPI_WATCH_APPLICATION(16734): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:37:16.066+0900 I/CAPI_NETWORK_WIFI(16734): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:37:16.096+0900 I/CAPI_NETWORK_WIFI(16734): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:37:16.416+0900 I/GESTURE (  139): gesture.c: GestureHandleGesture_Hold(704) > [PalmHold] PalmHold success !
12-12 08:37:16.416+0900 I/GESTURE (  139): gesture.c: GestureHandleGesture_Hold(742) > [GroupHold] GestureHold success !
12-12 08:37:16.416+0900 I/GESTURE (  139): gesture.c: GestureHandleGesture_Hold(704) > [PalmHold] PalmHold success !
12-12 08:37:16.416+0900 I/GESTURE (  139): gesture.c: GestureHandleGesture_Hold(742) > [GroupHold] GestureHold success !
12-12 08:37:16.651+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdoff_cb(440) >  event pre lcdoff[1]
12-12 08:37:16.651+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(276) >  enabled[1] status[1]
12-12 08:37:16.661+0900 W/WATCH_CORE(16734): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-12 08:37:16.661+0900 I/WATCH_CORE(16734): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-12 08:37:16.691+0900 W/W_HOME  (  717): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-12 08:37:16.691+0900 W/W_HOME  (  717): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-12 08:37:16.691+0900 W/W_HOME  (  717): gesture.c: _manual_render_enable(133) > 1
12-12 08:37:16.691+0900 W/W_HOME  (  717): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-12 08:37:16.691+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:37:16.696+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [event]
12-12 08:37:16.696+0900 W/STARTER (  693): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-12 08:37:16.701+0900 E/STARTER (  693): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-12 08:37:16.701+0900 W/STARTER (  693): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-12 08:37:16.701+0900 W/STARTER (  693): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-12 08:37:16.716+0900 I/SCONTEXT-LIB(  669): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-12 08:37:16.731+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124317720[0;m
12-12 08:37:16.731+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-12 08:37:16.746+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdoff_cb(492) >  clock start >> [0]
12-12 08:37:16.756+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(1)
12-12 08:37:16.756+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
12-12 08:37:16.756+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:37:16.756+0900 W/W_HOME  (  717): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(1)
12-12 08:37:16.761+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: PAUSE State: RUNNING
12-12 08:37:16.761+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-12 08:37:16.761+0900 W/W_HOME  (  717): main.c: _appcore_pause_cb(690) > appcore pause
12-12 08:37:16.761+0900 W/W_HOME  (  717): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-12 08:37:16.761+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:37:16.761+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:37:16.761+0900 W/W_HOME  (  717): main.c: home_pause(751) > clock/widget paused
12-12 08:37:16.761+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-12 08:37:16.761+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-12 08:37:16.766+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:37:16.766+0900 E/CAPI_APPFW_APP_CONTROL(  834): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-12 08:37:16.766+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:834]   value = [false][0m
12-12 08:37:16.851+0900 I/APP_CORE(  717): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
12-12 08:37:16.851+0900 I/wnotib  (  717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
12-12 08:37:16.851+0900 E/wnotib  (  717): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-12 08:37:16.856+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-12 08:37:16.856+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:834]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-12 08:37:16.866+0900 W/W_HOME  (  717): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
12-12 08:37:16.866+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:37:16.866+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:37:16.871+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:37:16.871+0900 W/W_HOME  (  717): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 0
12-12 08:37:16.876+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdoff_cb(502) >  clock begin >>
12-12 08:37:16.881+0900 I/SHealth_Common( 1061): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-12 08:37:16.881+0900 I/SHealth_Service( 1061): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-12 08:37:16.886+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-12 08:37:16.886+0900 W/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-12 08:37:16.886+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-12 08:37:16.886+0900 I/HIGEAR  ( 1131): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-12 08:37:16.961+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-12 08:37:16.961+0900 W/AUL_AMD (  479): amd_launch.c: __e17_status_handler(2194) > back key ungrab error
12-12 08:37:16.966+0900 W/WATCH_CORE(16734): appcore-watch.c: __signal_alpm_handler(1039) > signal_alpm_handler: ambient mode: 1, state: 2
12-12 08:37:16.966+0900 W/CAPI_WATCH_APPLICATION(16734): watch_app_main.c: _watch_core_ambient_changed(337) > _watch_core_ambient_changed: 1
12-12 08:37:16.966+0900 W/ALARM_MANAGER(16734): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(44), start(12-12-2015, 08:38:01), repeat(1), interval(60), type(-1073741822)
12-12 08:37:17.026+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1721873195, next duetime: 1449877081
12-12 08:37:17.026+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(1721873195)
12-12 08:37:17.026+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449877081), due_time(1449877081)
12-12 08:37:17.026+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:37:17.031+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:38:01 (UTC).
12-12 08:37:17.031+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:37:17.046+0900 I/CAPI_NETWORK_WIFI(16734): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:37:17.056+0900 I/CAPI_NETWORK_WIFI(16734): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:37:17.116+0900 I/WATCH_CORE(16734): appcore-watch-signal.c: _watch_core_send_alpm_update_done(282) > send a alpm update done signal
12-12 08:37:17.116+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_clockdraw_cb(325) >  Clock draw done
12-12 08:37:17.126+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[0]
12-12 08:37:17.126+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[0] lcd[1]
12-12 08:37:17.226+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_check_timer_cb(218) >  Render check timer expired
12-12 08:37:17.226+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_clockend_timer_cb(192) >  clock end << [1]
12-12 08:37:17.241+0900 W/ALARM_MANAGER(15061): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(1800), start(12-12-2015, 09:07:17), repeat(1), interval(1800), type(-1073741822)
12-12 08:37:17.331+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-12 08:37:17.451+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1721873196, next duetime: 1449878837
12-12 08:37:17.456+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(1721873196)
12-12 08:37:17.456+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449877081), due_time(1449878837)
12-12 08:37:17.456+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:37:17.456+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:38:01 (UTC).
12-12 08:37:17.456+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:37:17.476+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdoff_completed_cb(529) >  event lcdoff completed[1][0]
12-12 08:37:17.476+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-util-status.c: clock_viewer_util_status_get_wear_status(276) >  enabled[1] status[1]
12-12 08:37:17.491+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [event]
12-12 08:37:17.491+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[1]
12-12 08:37:17.496+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-12 08:37:17.496+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-12 08:37:20.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:37:20.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:37:21.876+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: MEM_FLUSH State: PAUSED
12-12 08:37:23.111+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 1 -> 2
12-12 08:37:23.111+0900 E/WMS     (  477): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-12 08:37:23.111+0900 E/WMS     (  477): ==========
12-12 08:37:23.111+0900 E/WMS     (  477): ##WMS SEND : mgr_gear_wear_onoff_req
12-12 08:37:23.111+0900 E/WMS     (  477): ==========
12-12 08:37:23.116+0900 E/WMS     (  477): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-12 08:37:23.146+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_monitor_cb(88) >  wearonoff_monitor_cb called error[0], context[45], data[{ "Time" : 1449877043102, "Status" : 2 }], req_id[1]
12-12 08:37:23.146+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-util-status.c: __clock_viewer_util_status_wearonoff_monitor_cb(108) >  status[2] Wear OFF
12-12 08:37:23.146+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-smart-lcdoff.c: __clock_viewer_smart_lcdoff_wear_status_changed_cb(83) >  status[0], alarm[1721873196]
12-12 08:37:23.146+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-smart-lcdoff.c: __clock_viewer_smart_lcdoff_alarm_cb(65) >  clock tick block >>
12-12 08:37:23.146+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-smart-lcdoff.c: __clock_viewer_smart_lcdoff_alarm_cb(68) >  ALPMLCDOff >>
12-12 08:37:23.186+0900 W/WATCH_CORE(16734): appcore-watch.c: __signal_alpm_handler(1039) > signal_alpm_handler: ambient mode: 2, state: 3
12-12 08:37:23.186+0900 W/WATCH_CORE(16734): appcore-watch.c: __signal_alpm_handler(1114) > Disable the alarm
12-12 08:37:23.251+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(1721873196)
12-12 08:37:23.251+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:37:23.256+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:38:01 (UTC).
12-12 08:37:23.261+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:37:23.261+0900 W/ALARM_MANAGER(  475): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[1721873196] is removed.
12-12 08:37:23.286+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(1721873195)
12-12 08:37:23.286+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:37:23.286+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:38:01 (UTC).
12-12 08:37:23.286+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:37:23.291+0900 W/ALARM_MANAGER(  475): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[1721873195] is removed.
12-12 08:37:25.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:37:25.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:37:30.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:37:30.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:37:35.606+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:37:35.651+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:37:40.671+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:37:40.741+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:37:41.996+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-12 08:37:41.996+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-12 08:37:45.696+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:37:45.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:37:50.681+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:37:50.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:37:51.276+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-12 08:37:55.691+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:37:55.756+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:37:56.186+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-12 08:37:56.191+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:37:56.196+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-12 08:37:56.196+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-12 08:38:00.611+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:00.676+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:00.996+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-12 08:38:01.061+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-12 08:38:01.126+0900 E/RESOURCED(  480): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 14859
12-12 08:38:01.146+0900 W/ALARM_MANAGER(16734): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [1681431895]
12-12 08:38:01.151+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[1681431895] is expired.
12-12 08:38:01.156+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1681431895, next duetime: 1449877141
12-12 08:38:01.196+0900 E/RESOURCED(  480): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 16058
12-12 08:38:01.211+0900 W/ALARM_MANAGER(16734): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [603337968]
12-12 08:38:01.211+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[603337968] is expired.
12-12 08:38:01.211+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 603337968, next duetime: 1449877141
12-12 08:38:01.216+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:38:01.216+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:39:01 (UTC).
12-12 08:38:01.216+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:38:01.216+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-12 08:38:01.236+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-12 08:38:05.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:05.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:10.691+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:10.766+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:15.696+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:15.761+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:20.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:20.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:25.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:25.756+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:30.691+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:30.756+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:35.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:35.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:40.691+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:40.756+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:42.021+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-12 08:38:42.021+0900 I/RESOURCED(  480): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-12 08:38:45.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:45.756+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:50.692+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:50.757+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:51.271+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-12 08:38:55.686+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:38:55.751+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:38:56.226+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-12 08:38:56.226+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-12 08:38:56.231+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-12 08:38:56.236+0900 E/TIZEN_N_SYSTEM_SETTINGS(  783): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-12 08:39:00.606+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:39:00.646+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:39:00.996+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-12 08:39:01.086+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-12 08:39:01.166+0900 E/RESOURCED(  480): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 14859
12-12 08:39:01.186+0900 W/ALARM_MANAGER(16734): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [1681431895]
12-12 08:39:01.186+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[1681431895] is expired.
12-12 08:39:01.186+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1681431895, next duetime: 1449877201
12-12 08:39:01.226+0900 E/RESOURCED(  480): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 16058
12-12 08:39:01.236+0900 W/ALARM_MANAGER(16734): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [603337968]
12-12 08:39:01.236+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[603337968] is expired.
12-12 08:39:01.236+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 603337968, next duetime: 1449877201
12-12 08:39:01.241+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:39:01.241+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:40:01 (UTC).
12-12 08:39:01.241+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:39:01.241+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-12 08:39:01.256+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-12 08:39:01.436+0900 E/PKGMGR_SERVER(17935): pkgmgr-server.c: main(2126) > package manager server start
12-12 08:39:01.551+0900 E/PKGMGR_SERVER(17935): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-738600664], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-12 08:39:01.551+0900 E/PKGMGR_SERVER(17936): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-12 08:39:01.561+0900 E/PKGMGR  (17933): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-12 08:39:01.626+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:39:01.631+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16734
12-12 08:39:01.636+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-12 08:39:01.636+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 5
12-12 08:39:01.641+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(16734), cmd(4)
12-12 08:39:01.646+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:39:01.646+0900 W/CAPI_WATCH_APPLICATION(16734): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-12 08:39:01.646+0900 W/WATCH_CORE(16734): appcore-watch.c: __widget_destroy(992) > widget_destory
12-12 08:39:01.646+0900 E/WIDGET_PROVIDER_APP(16734): client.c: client_fini(1175) > Provider is not initialized
12-12 08:39:01.651+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 16734
12-12 08:39:01.656+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 22
12-12 08:39:01.656+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(884) > app status : 4
12-12 08:39:01.656+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 4
12-12 08:39:01.756+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:39:01.816+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-12 08:39:01.856+0900 E/PKGMGR_SERVER(17936): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-12 08:39:01.906+0900 E/AUL_AMD (  479): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-12 08:39:01.906+0900 W/AUL_AMD (  479): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(16734), cmd(4)
12-12 08:39:01.916+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 0
12-12 08:39:01.946+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-12 08:39:01.966+0900 I/AUL_AMD (  479): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-12 08:39:01.966+0900 E/AUL_AMD (  479): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-12 08:39:01.966+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(1659) > caller pid : 698
12-12 08:39:01.996+0900 E/PKGMGR_SERVER(17935): pkgmgr-server.c: sighandler(445) > child NORMAL exit [17936]
12-12 08:39:02.061+0900 E/RESOURCED(  480): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 8
12-12 08:39:02.066+0900 E/RESOURCED(  480): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-12 08:39:02.071+0900 W/AUL_AMD (  479): amd_launch.c: _start_app(2026) > pad pid(-5)
12-12 08:39:02.071+0900 W/AUL_PAD ( 1168): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-12 08:39:02.071+0900 W/AUL_PAD ( 1168): launchpad.c: __send_result_to_caller(265) > Check app launching
12-12 08:39:02.121+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: watch_app_main(382) > watch_app_main
12-12 08:39:02.146+0900 E/TBM     (17778): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-12 08:39:02.171+0900 I/AUL_AMD (  479): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 16734
12-12 08:39:02.216+0900 W/WATCH_CORE(17778): appcore-watch.c: __widget_create(958) > widget_create
12-12 08:39:02.221+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [12280.789062] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_12280.789062.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263174:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-12 08:39:02.221+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[12280.789062] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_12280.789062.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263174:4] gbar_fname[]
12-12 08:39:02.221+0900 E/WIDGET_VIEWER(15061): client.c: master_created(1712) > [SECURE_LOG] [12280.789062] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_12280.789062.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263174:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-12 08:39:02.221+0900 E/WIDGET_VIEWER(15061): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[12280.789062] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_12280.789062.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263174:4] gbar_fname[]
12-12 08:39:02.236+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-12 08:39:02.236+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-12 08:39:02.236+0900 E/WIDGET_VIEWER(15061): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-12 08:39:02.236+0900 E/WIDGET_EVAS(15061): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-12 08:39:02.376+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:02.386+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:02.566+0900 W/WATCH_CORE(17778): appcore-watch.c: __widget_create(976) > widget_create done
12-12 08:39:02.591+0900 I/WATCH_CORE(17778): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-12 08:39:02.591+0900 I/WATCH_CORE(17778): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-12 08:39:02.596+0900 I/WATCH_CORE(17778): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-12 08:39:02.636+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:02.636+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:02.651+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:02.651+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:02.651+0900 W/WATCH_CORE(17778): appcore-watch.c: __widget_resume(1012) > widget_resume
12-12 08:39:02.656+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:02.656+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:02.671+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:02.721+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:02.731+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:02.771+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:02.771+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:03.001+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:03.011+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:03.021+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:03.071+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:03.071+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:03.176+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-12 08:39:03.176+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-12 08:39:03.191+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:39:03.196+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 17778
12-12 08:39:03.201+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-12 08:39:03.406+0900 I/AUL_PAD (17964): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-12 08:39:03.656+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-12 08:39:04.016+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:04.036+0900 E/PKGMGR_SERVER(17935): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-12 08:39:04.036+0900 E/PKGMGR_SERVER(17935): pkgmgr-server.c: main(2180) > package manager server terminated.
12-12 08:39:04.176+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:04.331+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:04.396+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:04.396+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:05.016+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:05.161+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:05.256+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:05.346+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:05.346+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:05.606+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:39:05.641+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:39:06.001+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:06.061+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:06.086+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:06.196+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:06.196+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:07.006+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:07.116+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:07.176+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:07.311+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:07.311+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:08.001+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:08.131+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:08.216+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:08.306+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:08.306+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:09.026+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:09.166+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:09.256+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:09.346+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:09.346+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:10.001+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:10.096+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:10.161+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:10.256+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:10.256+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:10.601+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:39:10.641+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:39:11.001+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:11.071+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:11.096+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:11.166+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:11.166+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:12.001+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:12.166+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:39:12.281+0900 I/CAPI_NETWORK_WIFI(17778): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:39:12.376+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:39:12.376+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:39:12.486+0900 E/PKGMGR  (18108): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-12 08:39:12.646+0900 E/PKGMGR_SERVER(18110): pkgmgr-server.c: main(2126) > package manager server start
12-12 08:39:12.761+0900 E/PKGMGR_SERVER(18110): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-727410588], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-727410588' '-r' 'org.reolab.blackandwhite'], cookie=[X2T4TBUR8JvvLfDJ7RQPxC9ZZHU=], backend_flag=[0]
12-12 08:39:12.766+0900 E/PKGMGR  (18110): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-12 08:39:12.766+0900 E/PKGMGR_SERVER(18110): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-12 08:39:12.771+0900 E/PKGMGR  (18108): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[181080002]
12-12 08:39:12.771+0900 E/PKGMGR_SERVER(18111): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-12 08:39:12.946+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-12 08:39:12.951+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-12 08:39:12.961+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-12 08:39:12.986+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-12 08:39:12.996+0900 I/CAPI_WATCH_APPLICATION(17778): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:39:13.236+0900 W/CRASH_MANAGER(18112): worker.c: worker_job(1199) > 1117778626c61144987715
