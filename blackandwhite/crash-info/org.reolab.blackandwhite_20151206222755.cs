S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 3617
Date: 2015-12-06 22:27:55+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x380

Register Information
r0   = 0x00000374, r1   = 0x0000000d
r2   = 0x00000274, r3   = 0x41553194
r4   = 0x00000374, r5   = 0x00000000
r6   = 0x414e0ccc, r7   = 0x414dd608
r8   = 0x0000006f, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0x40031dc0
ip   = 0xbefdcc74, sp   = 0xbefdcc28
lr   = 0x400170d0, pc   = 0x400169dc
cpsr = 0x20000010

Memory Information
MemTotal:   491012 KB
MemFree:     14392 KB
Buffers:     20488 KB
Cached:     107252 KB
VmPeak:      76244 KB
VmSize:      75732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14652 KB
VmRSS:       14652 KB
VmData:      21472 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       20468 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 3617 TID = 3617
3617 3798 3807 

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
4155d000 4155f000 r-xp /usr/lib/libdri2.so.0.0.0
41567000 4156c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41574000 41576000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4157f000 41585000 r-xp /usr/lib/libappsvc.so.0.1.0
4158d000 415b1000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
415ba000 41689000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4169f000 416a9000 r-xp /lib/libnss_files-2.13.so
41970000 41974000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
41984000 4198b000 r-xp /usr/lib/libappcore-watch.so.1.1
41994000 419a1000 r-xp /usr/lib/libalarm.so.0.0.0
419aa000 41ae7000 r-xp /usr/lib/libicui18n.so.51.1
41af7000 41bdb000 r-xp /usr/lib/libicuuc.so.51.1
41bf0000 41bf6000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41bfe000 41c04000 r-xp /usr/lib/libwidget.so.1.0.0
43194000 4319d000 r-xp /usr/lib/libcom-core.so.0.0.1
431a6000 431b2000 r-xp /usr/lib/libwidget_service.so.1.0.0
431ba000 431c3000 r-xp /usr/lib/libwidget_provider.so.1.0.0
431cc000 431d4000 r-xp /usr/lib/libdrm.so.2.4.0
431dc000 431e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
431e9000 431f0000 r-xp /usr/lib/libtbm.so.1.0.0
4352a000 43d29000 rw-p [stack:3798]
43d29000 43d2c000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43d34000 43d3f000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43dc7000 43dde000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
4401e000 44900000 rw-p [stack:3807]
befbd000 befde000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3617)
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
alth_Common( 1078): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-06 22:25:23.860+0900 I/SHealth_Service( 1078): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-06 22:25:23.915+0900 I/CAPI_WATCH_APPLICATION( 3464): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:25:23.925+0900 W/W_HOME  (  715): gesture.c: _widget_updated_cb(190) > widget updated
12-06 22:25:23.925+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-06 22:25:23.925+0900 W/W_HOME  (  715): gesture.c: _manual_render(176) > 
12-06 22:25:23.925+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: evas_render_pre_cb(6758) > [SECURE_LOG] Failed to create a resource lock
12-06 22:25:23.930+0900 W/STARTER (  707): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [gesture]
12-06 22:25:23.930+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[0]
12-06 22:25:23.955+0900 W/W_HOME  (  715): gesture.c: _manual_render(176) > 
12-06 22:25:23.990+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 0
12-06 22:25:23.995+0900 I/CAPI_WATCH_APPLICATION( 3464): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:25:24.010+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_resume_cb(314) > widget obj was resumed
12-06 22:25:24.020+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
12-06 22:25:24.100+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-06 22:25:24.100+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-06 22:25:24.100+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-06 22:25:24.100+0900 I/HIGEAR  ( 1107): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-06 22:25:24.100+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: OnReceiveDisplayChanged(905) > [0;32mINFO: LCDOn receive data : 1124318408[0;m
12-06 22:25:24.100+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-06 22:25:24.100+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-06 22:25:24.105+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-06 22:25:24.105+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-06 22:25:24.110+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-06 22:25:24.110+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-06 22:25:24.110+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-06 22:25:24.110+0900 I/HIGEAR  ( 1107): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-06 22:25:24.130+0900 E/SHealth_Common( 1078): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-06 22:25:24.780+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-06 22:25:24.780+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-06 22:25:24.780+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-06 22:25:24.780+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-06 22:25:24.780+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-06 22:25:24.780+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-06 22:25:24.780+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-06 22:25:24.780+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-06 22:25:24.795+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-06 22:25:24.795+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-06 22:25:24.795+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-06 22:25:24.795+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-06 22:25:24.795+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-06 22:25:24.795+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-06 22:25:24.795+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-06 22:25:24.795+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-06 22:25:24.795+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-06 22:25:24.795+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-06 22:25:24.800+0900 E/CAPI_APPFW_APP_CONTROL( 1081): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-06 22:25:24.800+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1081]   value = [true][0m
12-06 22:25:24.895+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-06 22:25:24.915+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 715
12-06 22:25:24.940+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT][0m
12-06 22:25:24.945+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-06 22:25:24.945+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-06 22:25:24.945+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-06 22:25:24.945+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-06 22:25:24.945+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-06 22:25:24.945+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-06 22:25:24.945+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-06 22:25:24.945+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-06 22:25:24.950+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-06 22:25:24.950+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-06 22:25:24.950+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-06 22:25:24.950+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-06 22:25:24.950+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-06 22:25:24.950+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-06 22:25:24.950+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-06 22:25:24.950+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-06 22:25:24.950+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-06 22:25:24.950+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-06 22:25:24.955+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-06 22:25:24.955+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-06 22:25:24.960+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT][0m
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-06 22:25:24.965+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-06 22:25:24.970+0900 W/W_HOME  (  715): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
12-06 22:25:24.970+0900 E/W_HOME  (  715): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-06 22:25:25.000+0900 I/CAPI_WATCH_APPLICATION( 3464): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:25:26.000+0900 I/CAPI_WATCH_APPLICATION( 3464): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:25:26.435+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-06 22:25:26.445+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-06 22:25:27.010+0900 I/CAPI_WATCH_APPLICATION( 3464): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:25:28.005+0900 I/CAPI_WATCH_APPLICATION( 3464): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:25:29.005+0900 I/CAPI_WATCH_APPLICATION( 3464): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:25:30.005+0900 I/CAPI_WATCH_APPLICATION( 3464): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-06 22:25:30.335+0900 W/WATCH_CORE( 3464): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
12-06 22:25:30.340+0900 I/WATCH_CORE( 3464): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-06 22:25:30.385+0900 W/W_HOME  (  715): dbus.c: _dbus_message_recv_cb(204) > LCD off
12-06 22:25:30.385+0900 W/W_HOME  (  715): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-06 22:25:30.385+0900 W/W_HOME  (  715): gesture.c: _manual_render_enable(133) > 1
12-06 22:25:30.385+0900 W/W_HOME  (  715): event_manager.c: _lcd_off_cb(699) > lcd state: 0
12-06 22:25:30.385+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-06 22:25:30.395+0900 W/STARTER (  707): clock-mgr.c: _on_lcd_signal_receive_cb(1541) > [_on_lcd_signal_receive_cb:1541] _on_lcd_signal_receive_cb, 1541, Pre LCD off by [timeout]
12-06 22:25:30.395+0900 W/STARTER (  707): clock-mgr.c: _pre_lcd_off(1325) > [_pre_lcd_off:1325] Will LCD OFF as wake_up_setting[1]
12-06 22:25:30.400+0900 E/STARTER (  707): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
12-06 22:25:30.400+0900 W/STARTER (  707): clock-mgr.c: _check_reserved_popup_status(255) > [_check_reserved_popup_status:255] Current reserved apps status : 0
12-06 22:25:30.400+0900 W/STARTER (  707): clock-mgr.c: _check_reserved_apps_status(291) > [_check_reserved_apps_status:291] Current reserved apps status : 0
12-06 22:25:30.405+0900 I/SCONTEXT-LIB(  687): scontext.c: remove_changed_cb(145) > UnSet Changed CB: 42
12-06 22:25:30.445+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: OnReceiveDisplayChanged(913) > [0;32mINFO: LCDOff receive data : 1124318408[0;m
12-06 22:25:30.455+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupServiceStop(387) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
12-06 22:25:30.460+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Disable start
12-06 22:25:30.535+0900 I/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Disable end. (ret: 0x0)
12-06 22:25:30.535+0900 W/TIZEN_N_SOUND_MANAGER( 1107): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-06 22:25:30.535+0900 W/WAKEUP-SERVICE( 1107): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 0[0;m
12-06 22:25:30.535+0900 I/HIGEAR  ( 1107): WakeupService.cpp: WakeupServiceStop(391) > [svoice:Application:WakeupServiceStop:IN]
12-06 22:25:30.585+0900 I/SHealth_Common( 1078): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
12-06 22:25:30.585+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1081]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
12-06 22:25:30.585+0900 I/SHealth_Service( 1078): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-06 22:25:30.595+0900 W/STARTER (  707): clock-mgr.c: _on_lcd_signal_receive_cb(1552) > [_on_lcd_signal_receive_cb:1552] _on_lcd_signal_receive_cb, 1552, Post LCD off by [timeout]
12-06 22:25:30.595+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1451) > [_post_lcd_off:1451] LCD OFF as reserved app[(null)] alpm mode[0]
12-06 22:25:30.595+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1458) > [_post_lcd_off:1458] Current reserved apps status : 0
12-06 22:25:30.595+0900 W/STARTER (  707): clock-mgr.c: _post_lcd_off(1476) > [_post_lcd_off:1476] raise homescreen after 20 sec. home_visible[1]
12-06 22:25:30.595+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: PAUSE State: RUNNING
12-06 22:25:30.595+0900 I/CAPI_APPFW_APPLICATION(  715): app_main.c: app_appcore_pause(202) > app_appcore_pause
12-06 22:25:30.595+0900 W/W_HOME  (  715): main.c: _appcore_pause_cb(690) > appcore pause
12-06 22:25:30.595+0900 W/W_HOME  (  715): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
12-06 22:25:30.595+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-06 22:25:30.595+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-06 22:25:30.595+0900 W/W_HOME  (  715): main.c: home_pause(751) > clock/widget paused
12-06 22:25:30.595+0900 W/W_HOME  (  715): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-06 22:25:30.595+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-06 22:25:30.595+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-06 22:25:30.595+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-06 22:25:30.595+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-06 22:25:30.595+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-06 22:25:30.595+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-06 22:25:30.595+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-06 22:25:30.595+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-06 22:25:30.600+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-06 22:25:30.600+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-06 22:25:30.600+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-06 22:25:30.600+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-06 22:25:30.600+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-06 22:25:30.600+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-06 22:25:30.600+0900 I/MESSAGE_PORT(  444): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-06 22:25:30.600+0900 I/MESSAGE_PORT(  444): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-06 22:25:30.600+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-06 22:25:30.600+0900 I/MESSAGE_PORT(  444): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-06 22:25:30.600+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4502) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
12-06 22:25:30.635+0900 E/CAPI_APPFW_APP_CONTROL( 1081): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-06 22:25:30.635+0900 W/MUSIC_CONTROL_SERVICE( 1081): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:1081]   value = [false][0m
12-06 22:25:30.680+0900 W/WATCH_CORE( 3464): appcore-watch.c: __widget_pause(1001) > widget_pause
12-06 22:25:30.680+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __provider_pause_cb(296) > widget obj was paused
12-06 22:25:30.680+0900 I/CAPI_WIDGET_APPLICATION(21992): widget_app.c: __check_status_for_cgroup(145) > enter background group
12-06 22:25:31.100+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-06 22:25:31.535+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-06 22:25:31.535+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-06 22:25:31.540+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-06 22:25:31.545+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-06 22:25:31.565+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-06 22:25:31.565+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-06 22:25:31.580+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-06 22:25:31.580+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-06 22:25:35.605+0900 I/APP_CORE(  715): appcore-efl.c: __do_app(429) > [APP 715] Event: MEM_FLUSH State: PAUSED
12-06 22:25:59.190+0900 W/LFE      ( 1173): [01289] 55:35:52.036[F:lfeWatchdog.cpp  L:  119][01][HIGH] Send Notify to Main thread. 658th=1
12-06 22:25:59.195+0900 W/LFE      ( 1173): [01173] 55:35:52.040[F:lfeWatchdog.cpp  L:   90][01][HIGH] Got thread notify. g_MainThreadLockup=1 g_write_lock=0
12-06 22:26:26.430+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-06 22:26:26.430+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-06 22:26:26.430+0900 I/RESOURCED(  498): logging.c: logging_save_to_storage(969) > [logging_save_to_storage,969] storage cache is empty
12-06 22:26:31.600+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-06 22:26:31.600+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-06 22:26:31.605+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-06 22:26:31.610+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-06 22:26:31.635+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-06 22:26:31.635+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-06 22:26:31.635+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-06 22:26:31.650+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-06 22:26:37.030+0900 W/SNL_W   (29264): <checkTimeStamp:264> checkTimeStamp delete timestamp ( 1449408097 ) of conn_id( 4 ) - Current ( 1449408397 )
12-06 22:26:37.030+0900 W/SNL_W   (29264): <d2d_timeout_notify_callback:428> d2d_timeout_notify - begin conn_id ( 4 )
12-06 22:26:37.030+0900 W/SCSD    (29264): <on_d2dTimeoutNotify:522> conn_id: 4
12-06 22:26:37.030+0900 W/SCSD    (29264): <_disconnected_cb:492> SCS Peer Disconnected !!!
12-06 22:26:37.030+0900 W/SCSD    (29264): <_disconnected_cb:493>  - conn_id: 4
12-06 22:26:37.030+0900 W/SCSD    (29264): <util_dbus_set_connection_status:267> set connection_status: 0
12-06 22:26:37.080+0900 W/SNL_W   (29264): <d2d_timeout_notify_callback:430> d2d_timeout_notify - end conn_id ( 4 )
12-06 22:26:37.080+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: close - Call ConnID( 4 ), Timeout ( 1 )
12-06 22:26:37.110+0900 W/W_INDICATOR(  708): windicator_scs.c: windicator_scs_update(39) > [windicator_scs_update:39] sales code : 0
12-06 22:26:37.110+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: release_conn(4) read(19160), sent(2608)
12-06 22:26:37.130+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: send_msg - ( 0xf7 ), type( 0x03 ), res( 296 ), seq( 0 )
12-06 22:26:37.130+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Call()
12-06 22:26:37.140+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: noti_ps - Res( 0 )
12-06 22:26:37.140+0900 W/W_INDICATOR(  708): windicator_scs.c: windicator_scs_update(46) > [windicator_scs_update:46] sap connected : 1
12-06 22:26:37.145+0900 W/SNL_W   (29264): <presSendNotify_i:987> presSendNotify_w ( 7d3831446264732f3e6c2a3e ) - begin
12-06 22:26:37.145+0900 W/SNL_W   (29264): <presSendNotify_i:992> presSendNotify_w ( 7d3831446264732f3e6c2a3e ) - Interrupt (Not SKA)
12-06 22:26:37.145+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Call()
12-06 22:26:37.150+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: get_glist - Res( 0 )
12-06 22:26:37.150+0900 W/SNL_W   (29264): <releaseAlarm:493> stop alarm_id(1715280200)
12-06 22:26:37.170+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(1715280200)
12-06 22:26:37.170+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-06 22:26:37.170+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 6-12-2015, 13:36:27 (UTC).
12-06 22:26:37.175+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-06 22:26:37.175+0900 W/ALARM_MANAGER(  482): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[1715280200] is removed.
12-06 22:26:37.185+0900 W/SNL_W   (29264): <setAlarm:520> setAlarm() - begin 
12-06 22:26:37.185+0900 W/SNL_W   (29264): <initAlarm:505> InitAlarm() - begin
12-06 22:26:37.190+0900 W/SNL_W   (29264): <initAlarm:511> InitAlarm() success - end
12-06 22:26:37.200+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: recv - ConnID( 4 ), Res( -1 )
12-06 22:26:37.200+0900 E/SCSD    (29264): <recv_thread:183> sec_recv() ret: -1
12-06 22:26:37.200+0900 W/SNL_W   (29264): <sec_close_w:321> sec_close_w - sec_close_w begin()
12-06 22:26:37.200+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: close - Call ConnID( 4 ), Timeout ( 0 )
12-06 22:26:37.200+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: dcc - id( 4 )
12-06 22:26:37.200+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: d_c_s_l - con_candidate seq( 1 )
12-06 22:26:37.200+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: d_c_s_l - con_candidate seq( 1 ), connid( 4 )
12-06 22:26:37.200+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: scs_dis-connid( 4 ), peer( 1099003872 )
12-06 22:26:37.205+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: sc_dis connid( 4 ), way( 4)
12-06 22:26:37.205+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: sc_dis .
12-06 22:26:37.205+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: scs_dis-res
12-06 22:26:37.205+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: dcc - end(0)
12-06 22:26:37.205+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: close - Res( 0 )
12-06 22:26:37.205+0900 W/SNL_W   (29264): <deleteConnIdData:205> ==== deleteConnIdData Start conn_id[4] ====
12-06 22:26:37.205+0900 W/SNL_W   (29264): <deleteConnIdData:218> deleteConnIdData timestamp( 1449408097 )
12-06 22:26:37.205+0900 W/SNL_W   (29264): <deleteConnIdData:233> ==== deleteConnIdData end res[0] ====
12-06 22:26:37.205+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: close - Res( -1 )
12-06 22:26:37.205+0900 W/SNL_W   (29264): <deleteConnIdData:205> ==== deleteConnIdData Start conn_id[4] ====
12-06 22:26:37.205+0900 W/SNL_W   (29264): <deleteConnIdData:233> ==== deleteConnIdData end res[0] ====
12-06 22:26:37.205+0900 W/SNL_W   (29264): <sec_close_w:325> sec_close_w - D2D close is Running -conn_id ( 4) deleted 
12-06 22:26:37.205+0900 W/SNL_W   (29264): <sec_close_w:328> sec_close_w - sec_close_w res( -1 )
12-06 22:26:37.205+0900 E/SCSD    (29264): <util_scs_close:1227> sec_close() failed. (ret:-1)
12-06 22:26:37.205+0900 E/SCSD    (29264): <util_scs_close:1231> message: Object Not Found
12-06 22:26:37.205+0900 W/SCSD    (29264): <_disconnected_cb:492> SCS Peer Disconnected !!!
12-06 22:26:37.205+0900 W/SCSD    (29264): <_disconnected_cb:493>  - conn_id: 4
12-06 22:26:37.205+0900 W/SCSD    (29264): <util_dbus_set_connection_status:263> same status(0)
12-06 22:26:37.230+0900 W/W_INDICATOR(  708): windicator_scs.c: windicator_scs_update(53) > [windicator_scs_update:53] sap connectivity type : 16
12-06 22:26:37.230+0900 W/W_INDICATOR(  708): windicator_scs.c: windicator_scs_update(60) > [windicator_scs_update:60] network status : 2
12-06 22:26:37.240+0900 I/AUL     (29264): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-06 22:26:37.255+0900 W/W_INDICATOR(  708): windicator_scs.c: windicator_scs_update(75) > [windicator_scs_update:75] scs login : 1
12-06 22:26:37.265+0900 I/AUL     (29264): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-06 22:26:37.265+0900 W/ALARM_MANAGER(29264): alarm-lib.c: alarmmgr_add_alarm_withcb(1160) > trigger_at_time(1195), start(6-12-2015, 22:46:32), repeat(0), interval(0), type(-1073741822)
12-06 22:26:37.275+0900 I/W_INDICATOR(  708): windicator.c: windicator_is_lo_connected(682) > [windicator_is_lo_connected:682] Connected target vendor : samsung
12-06 22:26:37.275+0900 W/W_INDICATOR(  708): windicator_scs.c: windicator_scs_update(93) > [windicator_scs_update:93] network connection via WIFI : no checking svc_type
12-06 22:26:37.285+0900 W/W_INDICATOR(  708): windicator_scs.c: windicator_scs_update(130) > [windicator_scs_update:130] ciss_request_type : 0
12-06 22:26:37.285+0900 I/W_INDICATOR(  708): windicator_scs.c: windicator_scs_update(140) > [windicator_scs_update:140] Hide (Callforwarding requested)
12-06 22:26:37.305+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-06 22:26:37.320+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-06 22:26:37.335+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-06 22:26:37.345+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-06 22:26:37.355+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-06 22:26:37.370+0900 I/AUL     (  482): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
12-06 22:26:37.370+0900 W/ALARM_MANAGER(  482): alarm-manager-schedule.c: __alarm_next_duetime_once(224) > Final due_time = 1449409592, Sun Dec  6 22:46:32 2015
12-06 22:26:37.370+0900 W/ALARM_MANAGER(  482): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 494506378, next duetime: 1449409592
12-06 22:26:37.370+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __alarm_add_to_list(375) > [alarm-server]: After add alarm_id(494506378)
12-06 22:26:37.370+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __alarm_create(941) > [alarm-server]:alarm_context.c_due_time(1449408987), due_time(1449409592)
12-06 22:26:37.370+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-06 22:26:37.370+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 6-12-2015, 13:36:27 (UTC).
12-06 22:26:37.370+0900 W/ALARM_MANAGER(  482): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-06 22:26:37.375+0900 W/SNL_W   (29264): <setAlarm:569> setAlarm() - end : mStatus ( 2 ) currentInterval( 1200 ) interruptFlag ( 0 ) alarm_id ( 494506378 )
12-06 22:26:37.375+0900 W/SNL_W   (29264): <presSendNotify_i:1010> presSendNotify_w ( 7d3831446264732f3e6c2a3e ) - end
12-06 22:26:37.375+0900 W/SNL     (29264): Scone_Log.cpp: dump(2972) > SNL :: noti_ps_th - Res( )
12-06 22:26:39.300+0900 W/LFE      ( 1173): [01289] 55:36:32.141[F:lfeWatchdog.cpp  L:  119][01][HIGH] Send Notify to Main thread. 659th=1
12-06 22:26:39.310+0900 W/LFE      ( 1173): [01173] 55:36:32.153[F:lfeWatchdog.cpp  L:   90][01][HIGH] Got thread notify. g_MainThreadLockup=1 g_write_lock=0
12-06 22:27:19.375+0900 W/LFE      ( 1173): [01289] 55:37:12.219[F:lfeWatchdog.cpp  L:  119][01][HIGH] Send Notify to Main thread. 660th=1
12-06 22:27:19.375+0900 W/LFE      ( 1173): [01173] 55:37:12.222[F:lfeWatchdog.cpp  L:   90][01][HIGH] Got thread notify. g_MainThreadLockup=1 g_write_lock=0
12-06 22:27:26.420+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
12-06 22:27:26.420+0900 I/RESOURCED(  498): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
12-06 22:27:31.620+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-06 22:27:31.620+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-06 22:27:31.625+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-06 22:27:31.635+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-06 22:27:31.660+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
12-06 22:27:31.660+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
12-06 22:27:31.665+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
12-06 22:27:31.670+0900 E/TIZEN_N_SYSTEM_SETTINGS(  808): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
12-06 22:27:34.180+0900 E/PKGMGR_SERVER( 3784): pkgmgr-server.c: main(2126) > package manager server start
12-06 22:27:34.300+0900 E/PKGMGR_SERVER( 3784): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1274439335], req_type=[12], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[], cookie=[], backend_flag=[0]
12-06 22:27:34.305+0900 E/PKGMGR_SERVER( 3786): pkgmgr-server.c: queue_job(1954) > KILL/CHECK APP, pkgid=[org.reolab.blackandwhite]
12-06 22:27:34.310+0900 E/PKGMGR  ( 3778): pkgmgr.c: __check_sync_process(842) > file is can not remove[/tmp/org.reolab.blackandwhite, -1]
12-06 22:27:34.385+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-06 22:27:34.395+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3464
12-06 22:27:34.395+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-06 22:27:34.400+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 5
12-06 22:27:34.405+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(3464), cmd(4)
12-06 22:27:34.405+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-06 22:27:34.410+0900 W/CAPI_WATCH_APPLICATION( 3464): watch_app_main.c: _watch_core_terminate(283) > _watch_core_terminate
12-06 22:27:34.410+0900 W/WATCH_CORE( 3464): appcore-watch.c: __widget_destroy(992) > widget_destory
12-06 22:27:34.410+0900 E/WIDGET_PROVIDER_APP( 3464): client.c: client_fini(1175) > Provider is not initialized
12-06 22:27:34.415+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3464
12-06 22:27:34.415+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 22
12-06 22:27:34.415+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(884) > app status : 4
12-06 22:27:34.415+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 4
12-06 22:27:34.520+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-06 22:27:34.590+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
12-06 22:27:34.670+0900 E/AUL_AMD (  495): amd_launch.c: __reply_handler(885) > recv error : Connection reset by peer
12-06 22:27:34.690+0900 W/AUL_AMD (  495): amd_launch.c: __reply_handler(909) > listen fd(28) , send fd(27), pid(3464), cmd(4)
12-06 22:27:34.695+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 0
12-06 22:27:34.855+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-06 22:27:34.920+0900 I/AUL_AMD (  495): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
12-06 22:27:34.920+0900 E/AUL_AMD (  495): amd_launch.c: _start_app(1649) > no caller appid info, ret: -1
12-06 22:27:34.920+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(1659) > caller pid : 709
12-06 22:27:34.960+0900 E/PKGMGR_SERVER( 3786): pkgmgr-server.c: queue_job(1976) > KILL/CHECK_APP end.
12-06 22:27:35.125+0900 E/PKGMGR_SERVER( 3784): pkgmgr-server.c: sighandler(445) > child NORMAL exit [3786]
12-06 22:27:35.135+0900 E/RESOURCED(  498): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.reolab.blackandwhite, table num : 7
12-06 22:27:35.140+0900 E/RESOURCED(  498): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
12-06 22:27:35.150+0900 W/AUL_AMD (  495): amd_launch.c: _start_app(2026) > pad pid(-5)
12-06 22:27:35.150+0900 W/AUL_PAD ( 1170): launchpad.c: __launchpad_main_loop(512) > Launch on type-based process-pool
12-06 22:27:35.150+0900 W/AUL_PAD ( 1170): launchpad.c: __send_result_to_caller(265) > Check app launching
12-06 22:27:35.175+0900 I/CAPI_WATCH_APPLICATION( 3617): watch_app_main.c: watch_app_main(382) > watch_app_main
12-06 22:27:35.200+0900 E/TBM     ( 3617): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
12-06 22:27:35.250+0900 I/AUL_AMD (  495): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3464
12-06 22:27:35.290+0900 W/WATCH_CORE( 3617): appcore-watch.c: __widget_create(958) > widget_create
12-06 22:27:35.295+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1712) > [SECURE_LOG] [30617.568359] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_30617.568359.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://29360846:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-06 22:27:35.295+0900 E/WIDGET_VIEWER(  715): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[30617.568359] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_715_30617.568359.png] content[] cluster[user,created] category[default] widget_fname[pixmap://29360846:4] gbar_fname[]
12-06 22:27:35.315+0900 E/WIDGET_VIEWER(  715): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-06 22:27:35.315+0900 E/WIDGET_EVAS(  715): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-06 22:27:35.385+0900 W/WATCH_CORE( 3617): appcore-watch.c: __widget_create(976) > widget_create done
12-06 22:27:35.470+0900 I/WATCH_CORE( 3617): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-06 22:27:35.470+0900 I/WATCH_CORE( 3617): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-06 22:27:35.470+0900 I/WATCH_CORE( 3617): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-06 22:27:36.130+0900 E/PKGMGR_SERVER( 3784): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-06 22:27:36.130+0900 E/PKGMGR_SERVER( 3784): pkgmgr-server.c: main(2180) > package manager server terminated.
12-06 22:27:36.255+0900 W/AUL_AMD (  495): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-06 22:27:36.255+0900 W/AUL_AMD (  495): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-06 22:27:36.270+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 14
12-06 22:27:36.275+0900 W/AUL_AMD (  495): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3617
12-06 22:27:36.280+0900 W/AUL_AMD (  495): amd_request.c: __request_handler(640) > __request_handler: 12
12-06 22:27:36.415+0900 W/AUL_AMD (  495): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-06 22:27:36.465+0900 I/AUL_PAD ( 3817): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-06 22:27:49.275+0900 E/PKGMGR  ( 3923): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-06 22:27:49.425+0900 E/PKGMGR_SERVER( 3925): pkgmgr-server.c: main(2126) > package manager server start
12-06 22:27:49.540+0900 E/PKGMGR_SERVER( 3925): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-1259184509], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-1259184509' '-r' 'org.reolab.blackandwhite'], cookie=[s+HRDBYZAQul7RwqYxOqv/Jwcv8=], backend_flag=[0]
12-06 22:27:49.540+0900 E/PKGMGR  ( 3925): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-06 22:27:49.545+0900 E/PKGMGR_SERVER( 3925): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-06 22:27:49.550+0900 E/PKGMGR_SERVER( 3926): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-06 22:27:49.560+0900 E/PKGMGR  ( 3923): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[39230002]
12-06 22:27:49.720+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-06 22:27:49.730+0900 W/AUL_AMD (  495): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-06 22:27:49.750+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-06 22:27:49.750+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-06 22:27:50.340+0900 E/PKGMGR_CERT( 3926): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-06 22:27:50.350+0900 E/PKGMGR_CERT( 3926): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 99
12-06 22:27:50.350+0900 E/PKGMGR_CERT( 3926): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 99
12-06 22:27:50.350+0900 E/PKGMGR_CERT( 3926): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 3
12-06 22:27:50.350+0900 E/PKGMGR_CERT( 3926): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 3
12-06 22:27:50.350+0900 E/PKGMGR_CERT( 3926): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 3
12-06 22:27:50.355+0900 E/PKGMGR_CERT( 3926): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 3
12-06 22:27:50.365+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-06 22:27:50.375+0900 E/PKGMGR_CERT( 3926): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-06 22:27:52.130+0900 E/PKGMGR_SERVER( 3925): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-06 22:27:52.255+0900 E/rpm-installer( 3926): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
12-06 22:27:54.130+0900 E/PKGMGR_SERVER( 3925): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=0, queue_status=1] 
12-06 22:27:55.415+0900 E/PKGMGR_SERVER( 3925): pkgmgr-server.c: sighandler(445) > child NORMAL exit [3926]
12-06 22:27:55.425+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-06 22:27:55.445+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.reolab.blackandwhite is updated, need to check validation
12-06 22:27:55.445+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.reolab.blackandwhite
12-06 22:27:55.470+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, COMPLETED]
12-06 22:27:55.470+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6799) > package install complete
12-06 22:27:55.470+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_package_install_event(4679) > 
12-06 22:27:55.470+0900 E/WMS     (  491): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1742) > Found in install_req_list?[0], index[-1]
12-06 22:27:55.485+0900 W/W_HOME  (  715): clock_event.c: _pkgmgr_event_cb(249) > clock org.reolab.blackandwhite is updated, preload:0 update:0 event->update:0
12-06 22:27:55.590+0900 E/APPS    (  715): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
12-06 22:27:55.590+0900 E/PKGMGR_INFO(  483): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
12-06 22:27:55.885+0900 W/CRASH_MANAGER( 3928): worker.c: worker_job(1199) > 1103617626c61144940847
