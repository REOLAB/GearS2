S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 15557
Date: 2015-12-09 21:55:26+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x4a8

Register Information
r0   = 0x0000049c, r1   = 0x0000000d
r2   = 0x000002fc, r3   = 0x41553194
r4   = 0x0000049c, r5   = 0x00000000
r6   = 0x414e922c, r7   = 0x414dd608
r8   = 0x00000082, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbece9c5c, sp   = 0xbece9c10
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     30164 KB
Buffers:     31900 KB
Cached:     124300 KB
VmPeak:      78624 KB
VmSize:      78112 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15384 KB
VmRSS:       15384 KB
VmData:      21624 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22096 KB
VmPTE:          54 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 15557 TID = 15557
15557 15669 15675 

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
43757000 43f56000 rw-p [stack:15669]
43f56000 43f59000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f61000 43f6c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43ff4000 4400b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4424b000 44b00000 rw-p [stack:15675]
becca000 beceb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15557)
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
ibility : 0
12-09 21:54:14.504+0900 W/W_HOME  (  707): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-09 21:54:14.504+0900 W/W_HOME  (  707): main.c: home_resume(733) > clock/widget resumed
12-09 21:54:14.504+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:54:14.509+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-09 21:54:14.554+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
12-09 21:54:14.574+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [gesture]
12-09 21:54:14.574+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[0]
12-09 21:54:14.584+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: OnReceiveGestureChanged(928) > [0;32mINFO: wakeup receive data : 1124318360[0;m
12-09 21:54:14.584+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-09 21:54:14.589+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-09 21:54:14.589+0900 I/SHealth_Common( 1055): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-09 21:54:14.594+0900 I/SHealth_Service( 1055): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-09 21:54:14.619+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-09 21:54:14.619+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-09 21:54:14.689+0900 W/W_HOME  (  707): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
12-09 21:54:14.689+0900 W/W_HOME  (  707): gesture.c: _manual_render_enable(133) > 0
12-09 21:54:14.699+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-09 21:54:14.849+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-09 21:54:14.854+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-09 21:54:14.854+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-09 21:54:14.854+0900 I/HIGEAR  ( 1071): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-09 21:54:14.859+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: OnReceiveDisplayChanged(905) > [0;32mINFO: LCDOn receive data : 1124318408[0;m
12-09 21:54:14.864+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-09 21:54:14.864+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-09 21:54:14.884+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-09 21:54:14.884+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-09 21:54:14.899+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-09 21:54:14.899+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-09 21:54:14.899+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-09 21:54:14.899+0900 I/HIGEAR  ( 1071): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-09 21:54:15.519+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:54:15.519+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:54:15.519+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:54:15.519+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 21:54:15.519+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 21:54:15.519+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:54:15.519+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 21:54:15.519+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:54:15.569+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:54:15.569+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:54:15.569+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:54:15.574+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 21:54:15.574+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 21:54:15.574+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:54:15.574+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 21:54:15.574+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 21:54:15.574+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 21:54:15.574+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:54:15.574+0900 E/CAPI_APPFW_APP_CONTROL( 1020): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 21:54:15.574+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1020]   value = [true][0m
12-09 21:54:15.629+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:54:15.649+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 707
12-09 21:54:15.669+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT][0m
12-09 21:54:15.674+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:54:15.674+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:54:15.674+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:54:15.674+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 21:54:15.674+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 21:54:15.674+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:54:15.674+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 21:54:15.674+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:54:15.679+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:54:15.679+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:54:15.679+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:54:15.679+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 21:54:15.679+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 21:54:15.679+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:54:15.679+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 21:54:15.679+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 21:54:15.679+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 21:54:15.679+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:54:15.684+0900 W/W_HOME  (  707): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-09 21:54:15.684+0900 E/W_HOME  (  707): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 21:54:15.689+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT][0m
12-09 21:54:15.694+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:54:15.694+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:54:15.694+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:54:15.694+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 21:54:15.694+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 21:54:15.694+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:54:15.694+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-09 21:54:15.694+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:54:15.699+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:54:15.699+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:54:15.699+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:54:15.699+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 21:54:15.699+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 21:54:15.699+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:54:15.699+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-09 21:54:15.699+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 21:54:15.699+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 21:54:15.699+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:54:15.699+0900 W/W_HOME  (  707): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-09 21:54:15.699+0900 E/W_HOME  (  707): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-09 21:54:20.124+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(19114) > wear_monitor_status update[0] = 2 -> 1
12-09 21:54:20.124+0900 E/WMS     (  528): wms_msg_broker.c: wms_msg_broker_send(1640) > 
12-09 21:54:20.124+0900 E/WMS     (  528): ==========
12-09 21:54:20.124+0900 E/WMS     (  528): ##WMS SEND : mgr_gear_wear_onoff_req
12-09 21:54:20.124+0900 E/WMS     (  528): ==========
12-09 21:54:20.129+0900 E/WMS     (  528): wms_msg_broker.c: wms_msg_broker_send(1656) > Data size: 52 MAX Buffer Size: 61440
12-09 21:54:20.234+0900 W/SCSD    (12812): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x39)
12-09 21:54:20.234+0900 W/SCSD    (12812): <on_sap_socket_recv:30>  - remain length: 57, crc_size: 4
12-09 21:54:20.234+0900 W/SCSD    (12812): <on_sap_socket_recv:62>  - recv 61 bytes [61 / 61] 
12-09 21:54:20.239+0900 W/SCSD    (12812): <util_scs_send:975> sent [63 / 63] bytes. 
12-09 21:54:20.254+0900 W/SHealth_Service( 1055): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
12-09 21:54:20.254+0900 E/SHealth_Service( 1055): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
12-09 21:54:21.104+0900 W/W_HOME  (  707): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-09 21:54:21.104+0900 W/W_HOME  (  707): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-09 21:54:21.104+0900 W/W_HOME  (  707): gesture.c: _manual_render_enable(133) > 1
12-09 21:54:21.104+0900 W/W_HOME  (  707): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-09 21:54:21.104+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:54:21.109+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-09 21:54:21.109+0900 W/STARTER (  691): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-09 21:54:21.109+0900 E/STARTER (  691): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-09 21:54:21.109+0900 W/STARTER (  691): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-09 21:54:21.109+0900 W/STARTER (  691): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-09 21:54:21.109+0900 I/SCONTEXT-LIB(  671): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-09 21:54:21.144+0900 W/WATCH_CORE(15252): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-09 21:54:21.144+0900 I/WATCH_CORE(15252): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-09 21:54:21.174+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-09 21:54:21.174+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-09 21:54:21.184+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-09 21:54:21.264+0900 I/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-09 21:54:21.264+0900 W/TIZEN_N_SOUND_MANAGER( 1071): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-09 21:54:21.264+0900 W/WAKEUP-SERVICE( 1071): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-09 21:54:21.264+0900 I/HIGEAR  ( 1071): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-09 21:54:21.304+0900 I/SHealth_Common( 1055): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-09 21:54:21.304+0900 I/SHealth_Service( 1055): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-09 21:54:21.309+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1020]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-09 21:54:21.319+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: PAUSE State: RUNNING
12-09 21:54:21.319+0900 I/CAPI_APPFW_APPLICATION(  707): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-09 21:54:21.319+0900 W/W_HOME  (  707): main.c: _appcore_pause_cb(690) > appcore pause
12-09 21:54:21.319+0900 W/W_HOME  (  707): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-09 21:54:21.319+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:54:21.319+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:54:21.319+0900 W/W_HOME  (  707): main.c: home_pause(751) > clock/widget paused
12-09 21:54:21.319+0900 W/W_HOME  (  707): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-09 21:54:21.319+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:54:21.319+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:54:21.319+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:54:21.319+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-09 21:54:21.319+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-09 21:54:21.319+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:54:21.319+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 21:54:21.319+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:54:21.324+0900 W/STARTER (  691): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-09 21:54:21.324+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-09 21:54:21.324+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-09 21:54:21.324+0900 W/STARTER (  691): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-09 21:54:21.324+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-09 21:54:21.324+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-09 21:54:21.324+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-09 21:54:21.324+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-09 21:54:21.324+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-09 21:54:21.324+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-09 21:54:21.324+0900 I/MESSAGE_PORT(  447): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-09 21:54:21.324+0900 I/MESSAGE_PORT(  447): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-09 21:54:21.324+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-09 21:54:21.324+0900 I/MESSAGE_PORT(  447): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-09 21:54:21.324+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-09 21:54:21.329+0900 E/CAPI_APPFW_APP_CONTROL( 1020): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-09 21:54:21.329+0900 W/MUSIC_CONTROL_SERVICE( 1020): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1020]   value = [false][0m
12-09 21:54:21.829+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: MEM_FLUSH State: PAUSED
12-09 21:54:26.444+0900 I/APP_CORE(  707): appcore-efl.c: __do_app(429) > [APP 707] Event: MEM_FLUSH State: PAUSED
12-09 21:54:26.819+0900 I/RESOURCED(  532): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-09 21:54:26.819+0900 I/RESOURCED(  532): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-09 21:54:34.244+0900 E/PKGMGR_SERVER(15528): pkgmgr-server.c: main(2126) > package manager server start
12-09 21:54:34.384+0900 E/PKGMGR_SERVER(15528): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1752426525], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-09 21:54:34.389+0900 E/PKGMGR_SERVER(15530): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-09 21:54:34.404+0900 E/PKGMGR  (15522): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-09 21:54:34.474+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:54:34.484+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15252
12-09 21:54:34.484+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 21:54:34.489+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 5
12-09 21:54:34.494+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(15252), cmd(4)
12-09 21:54:34.494+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 22
12-09 21:54:34.494+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(884) > app status : 4
12-09 21:54:34.494+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:54:34.494+0900 W/CAPI_WATCH_APPLICATION(15252): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-09 21:54:34.494+0900 W/WATCH_CORE(15252): appcore-watch.c: __widget_destroy(992) > widget_destory
12-09 21:54:34.494+0900 E/WIDGET_PROVIDER_APP(15252): client.c: client_fini(1175) > Provider is not initialized
12-09 21:54:34.504+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15252
12-09 21:54:34.504+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 4
12-09 21:54:34.609+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:54:34.624+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-09 21:54:34.654+0900 E/PKGMGR_SERVER(15530): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-09 21:54:34.704+0900 E/PKGMGR_SERVER(15528): pkgmgr-server.c: sighandler(445) > child NORMAL exit [15530]
12-09 21:54:34.739+0900 E/AUL_AMD (  530): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-09 21:54:34.739+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(15252), cmd(4)
12-09 21:54:34.744+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 0
12-09 21:54:34.794+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 21:54:34.834+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 21:54:34.834+0900 E/AUL_AMD (  530): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-09 21:54:34.834+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(1659) > caller pid : 697
12-09 21:54:34.909+0900 E/RESOURCED(  532): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-09 21:54:34.914+0900 E/RESOURCED(  532): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-09 21:54:34.934+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(2026) > pad pid(-5)
12-09 21:54:34.934+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-09 21:54:34.934+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(265) > Check app launching
12-09 21:54:34.974+0900 I/CAPI_WATCH_APPLICATION(15398): watch_app_main.c: watch_app_main(382) > watch_app_main
12-09 21:54:34.999+0900 E/TBM     (15398): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-09 21:54:35.039+0900 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 15252
12-09 21:54:35.084+0900 W/WATCH_CORE(15398): appcore-watch.c: __widget_create(958) > widget_create
12-09 21:54:35.089+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1712) > [SECURE_LOG] [9879.414062] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_9879.414062.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263138:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-09 21:54:35.089+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[9879.414062] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_9879.414062.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263138:4] gbar_fname[]
12-09 21:54:35.104+0900 E/WIDGET_VIEWER(  707): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-09 21:54:35.104+0900 E/WIDGET_EVAS(  707): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-09 21:54:35.174+0900 F/EFL     (15398): evas_main<15398> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:54:35.174+0900 F/EFL     (15398):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:54:35.174+0900 F/EFL     (15398):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:54:35.174+0900 F/EFL     (15398): evas_main<15398> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:54:35.174+0900 F/EFL     (15398):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:54:35.174+0900 F/EFL     (15398):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:54:35.174+0900 F/EFL     (15398): evas_main<15398> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:54:35.174+0900 F/EFL     (15398):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:54:35.174+0900 F/EFL     (15398):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:54:35.184+0900 W/WATCH_CORE(15398): appcore-watch.c: __widget_create(976) > widget_create done
12-09 21:54:35.254+0900 I/WATCH_CORE(15398): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-09 21:54:35.254+0900 I/WATCH_CORE(15398): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-09 21:54:35.259+0900 I/WATCH_CORE(15398): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-09 21:54:35.309+0900 W/W_HOME  (  707): gesture.c: _widget_updated_cb(190) > widget updated
12-09 21:54:35.309+0900 W/W_HOME  (  707): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-09 21:54:35.309+0900 W/W_HOME  (  707): gesture.c: _manual_render(176) > 
12-09 21:54:35.324+0900 W/W_HOME  (  707): gesture.c: _manual_render(176) > 
12-09 21:54:35.349+0900 W/W_HOME  (  707): gesture.c: _manual_render_enable(133) > 0
12-09 21:54:36.039+0900 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 21:54:36.039+0900 W/AUL_AMD (  530): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-09 21:54:36.054+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:54:36.059+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15398
12-09 21:54:36.059+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 21:54:36.269+0900 I/AUL_PAD (15557): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-09 21:54:36.499+0900 W/AUL_AMD (  530): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-09 21:54:36.884+0900 E/PKGMGR_SERVER(15528): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-09 21:54:36.884+0900 E/PKGMGR_SERVER(15528): pkgmgr-server.c: main(2180) > package manager server terminated.
12-09 21:55:01.329+0900 I/SHealth_Service( 1055): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(628) > [1;35mlength of Array [1][0;m
12-09 21:55:01.344+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-09 21:55:01.384+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-09 21:55:01.384+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-09 21:55:01.384+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-09 21:55:01.384+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-09 21:55:01.389+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-09 21:55:01.389+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-09 21:55:01.389+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-09 21:55:01.394+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-09 21:55:01.394+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-09 21:55:01.394+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-09 21:55:01.394+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-09 21:55:01.394+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-09 21:55:01.394+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-09 21:55:01.394+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-09 21:55:01.394+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-09 21:55:01.394+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-09 21:55:01.399+0900 I/CAPI_WIDGET_APPLICATION(  789): widget_app.c: __provider_update_cb(279) > received updating signal
12-09 21:55:01.419+0900 W/SHealth_Common( 1055): SHealthWidgetConnection.cpp: Send(71) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
12-09 21:55:01.449+0900 W/SHealth_Common( 1055): SHealthWidgetConnection.cpp: Send(76) > [1;40;33mFailed request widget notify message [fd0c0008][Not exists][0;m
12-09 21:55:01.479+0900 I/CAPI_WIDGET_APPLICATION(  789): widget_app.c: __provider_update_cb(279) > received updating signal
12-09 21:55:01.484+0900 I/HealthDataService(  783): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
12-09 21:55:01.499+0900 I/healthData( 1055): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
12-09 21:55:01.519+0900 E/SHealth_Common( 1055): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-09 21:55:05.949+0900 E/PKGMGR_SERVER(15665): pkgmgr-server.c: main(2126) > package manager server start
12-09 21:55:06.029+0900 E/PKGMGR_SERVER(15665): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1720700234], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-09 21:55:06.034+0900 E/PKGMGR_SERVER(15667): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-09 21:55:06.039+0900 E/PKGMGR  (15659): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-09 21:55:06.099+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:55:06.104+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15398
12-09 21:55:06.109+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 21:55:06.109+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 5
12-09 21:55:06.114+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(15398), cmd(4)
12-09 21:55:06.119+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:55:06.119+0900 W/CAPI_WATCH_APPLICATION(15398): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-09 21:55:06.119+0900 W/WATCH_CORE(15398): appcore-watch.c: __widget_destroy(992) > widget_destory
12-09 21:55:06.119+0900 E/WIDGET_PROVIDER_APP(15398): client.c: client_fini(1175) > Provider is not initialized
12-09 21:55:06.124+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15398
12-09 21:55:06.124+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 22
12-09 21:55:06.124+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(884) > app status : 4
12-09 21:55:06.124+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 4
12-09 21:55:06.229+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:55:06.244+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-09 21:55:06.269+0900 E/PKGMGR_SERVER(15667): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-09 21:55:06.324+0900 E/PKGMGR_SERVER(15665): pkgmgr-server.c: sighandler(445) > child NORMAL exit [15667]
12-09 21:55:06.344+0900 E/AUL_AMD (  530): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-09 21:55:06.344+0900 W/AUL_AMD (  530): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(15398), cmd(4)
12-09 21:55:06.349+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 0
12-09 21:55:06.379+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 21:55:06.404+0900 I/AUL_AMD (  530): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-09 21:55:06.404+0900 E/AUL_AMD (  530): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-09 21:55:06.404+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(1659) > caller pid : 697
12-09 21:55:06.479+0900 W/AUL_AMD (  530): amd_launch.c: _start_app(2026) > pad pid(-5)
12-09 21:55:06.479+0900 E/RESOURCED(  532): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 2
12-09 21:55:06.484+0900 W/AUL_PAD ( 1161): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-09 21:55:06.484+0900 W/AUL_PAD ( 1161): launchpad.c: __send_result_to_caller(265) > Check app launching
12-09 21:55:06.484+0900 E/RESOURCED(  532): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-09 21:55:06.524+0900 I/CAPI_WATCH_APPLICATION(15557): watch_app_main.c: watch_app_main(382) > watch_app_main
12-09 21:55:06.549+0900 E/TBM     (15557): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-09 21:55:06.584+0900 I/AUL_AMD (  530): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 15398
12-09 21:55:06.619+0900 W/WATCH_CORE(15557): appcore-watch.c: __widget_create(958) > widget_create
12-09 21:55:06.619+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1712) > [SECURE_LOG] [9879.414062] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_9879.414062.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263142:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-09 21:55:06.619+0900 E/WIDGET_VIEWER(  707): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[9879.414062] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_707_9879.414062.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263142:4] gbar_fname[]
12-09 21:55:06.639+0900 E/WIDGET_VIEWER(  707): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-09 21:55:06.639+0900 E/WIDGET_EVAS(  707): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-09 21:55:06.709+0900 F/EFL     (15557): evas_main<15557> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:55:06.709+0900 F/EFL     (15557):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:55:06.709+0900 F/EFL     (15557):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:55:06.709+0900 F/EFL     (15557): evas_main<15557> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:55:06.709+0900 F/EFL     (15557):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:55:06.709+0900 F/EFL     (15557):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:55:06.709+0900 F/EFL     (15557): evas_main<15557> main.c:122 evas_debug_magic_wrong() Input object is wrong type
12-09 21:55:06.709+0900 F/EFL     (15557):     Expected: 747ad76c - Evas_Object (Image)
12-09 21:55:06.709+0900 F/EFL     (15557):     Supplied: 78c7c73f - Evas_Object (Smart)
12-09 21:55:06.724+0900 W/WATCH_CORE(15557): appcore-watch.c: __widget_create(976) > widget_create done
12-09 21:55:06.794+0900 I/WATCH_CORE(15557): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-09 21:55:06.794+0900 I/WATCH_CORE(15557): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-09 21:55:06.794+0900 I/WATCH_CORE(15557): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-09 21:55:07.584+0900 W/AUL_AMD (  530): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-09 21:55:07.584+0900 W/AUL_AMD (  530): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-09 21:55:07.604+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 14
12-09 21:55:07.614+0900 W/AUL_AMD (  530): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 15557
12-09 21:55:07.614+0900 W/AUL_AMD (  530): amd_request.c: __request_handler(640) > __request_handler: 12
12-09 21:55:07.814+0900 I/AUL_PAD (15688): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-09 21:55:07.884+0900 E/PKGMGR_SERVER(15665): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-09 21:55:07.884+0900 E/PKGMGR_SERVER(15665): pkgmgr-server.c: main(2180) > package manager server terminated.
12-09 21:55:08.129+0900 W/AUL_AMD (  530): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-09 21:55:11.334+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-09 21:55:11.334+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-09 21:55:11.344+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-09 21:55:11.344+0900 E/TIZEN_N_SYSTEM_SETTINGS(  789): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-09 21:55:19.944+0900 E/PKGMGR  (15795): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-09 21:55:20.134+0900 E/PKGMGR_SERVER(15798): pkgmgr-server.c: main(2126) > package manager server start
12-09 21:55:20.219+0900 E/PKGMGR_SERVER(15798): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1706549753], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-1706549753' '-r' 'org.reolab.blackandwhite'], cookie=[oZWEqYSlhVHD0ezQdoJpJfpI5+Y=], backend_flag=[0]
12-09 21:55:20.224+0900 E/PKGMGR  (15798): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-09 21:55:20.224+0900 E/PKGMGR_SERVER(15798): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-09 21:55:20.229+0900 E/PKGMGR_SERVER(15799): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-09 21:55:20.229+0900 E/PKGMGR  (15795): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[157950002]
12-09 21:55:20.404+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-09 21:55:20.409+0900 W/AUL_AMD (  530): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-09 21:55:20.429+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 21:55:20.434+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-09 21:55:20.989+0900 E/PKGMGR_CERT(15799): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-09 21:55:20.999+0900 E/PKGMGR_CERT(15799): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 92
12-09 21:55:20.999+0900 E/PKGMGR_CERT(15799): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 92
12-09 21:55:21.004+0900 E/PKGMGR_CERT(15799): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 2
12-09 21:55:21.004+0900 E/PKGMGR_CERT(15799): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 2
12-09 21:55:21.004+0900 E/PKGMGR_CERT(15799): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 2
12-09 21:55:21.004+0900 E/PKGMGR_CERT(15799): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 2
12-09 21:55:21.014+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 21:55:21.024+0900 E/PKGMGR_CERT(15799): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-09 21:55:22.884+0900 E/PKGMGR_SERVER(15798): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-09 21:55:23.054+0900 E/rpm-installer(15799): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-09 21:55:24.884+0900 E/PKGMGR_SERVER(15798): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-09 21:55:26.019+0900 E/PKGMGR_SERVER(15798): pkgmgr-server.c: sighandler(445) > child NORMAL exit [15799]
12-09 21:55:26.019+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-09 21:55:26.044+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-09 21:55:26.044+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-09 21:55:26.064+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-09 21:55:26.064+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-09 21:55:26.064+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-09 21:55:26.064+0900 E/WMS     (  528): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-09 21:55:26.099+0900 W/W_HOME  (  707): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-09 21:55:26.154+0900 E/PKGMGR_INFO(  527): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-09 21:55:26.199+0900 E/APPS    (  707): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-09 21:55:26.469+0900 W/CRASH_MANAGER(15804): worker.c: worker_job(1199) > 1115557626c61144966572
