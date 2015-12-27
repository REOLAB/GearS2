S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.1.2
Build-Number: R732XXU2BOKK
Build-Date: 2015.11.27 18:16:12

Crash Information
Process Name: blackandwhite
PID: 18182
Date: 2015-12-12 08:43:09+0900
Executable File Path: /opt/usr/apps/org.reolab.blackandwhite/bin/blackandwhite
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xe88

Register Information
r0   = 0x418ae300, r1   = 0x000000ff
r2   = 0x000000ff, r3   = 0x000000ff
r4   = 0xbec355d0, r5   = 0xbec352d0
r6   = 0x00000132, r7   = 0xbec349f8
r8   = 0x4030b9c0, r9   = 0x4161ff30
r10  = 0x40319b18, fp   = 0x0000017e
ip   = 0x4145d6f0, sp   = 0xbec349e8
lr   = 0x41454385, pc   = 0x00000e88
cpsr = 0x20000010

Memory Information
MemTotal:   489992 KB
MemFree:      8660 KB
Buffers:     14280 KB
Cached:     111996 KB
VmPeak:     119352 KB
VmSize:     118840 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16064 KB
VmRSS:       16064 KB
VmData:      62312 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22108 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 18182 TID = 18182
18182 18570 18582 

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
415b2000 415b6000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
415c6000 415cd000 r-xp /usr/lib/libappcore-watch.so.1.1
415d6000 415db000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
415e3000 415e7000 rw-p [heap]
415e7000 41695000 rw-p [heap]
41953000 41983000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
41984000 41998000 r-xp /usr/lib/libcapi-network-nfc.so.0.2.3
419a0000 419ad000 r-xp /usr/lib/libcapi-network-wifi.so.1.0.55
419b5000 419c2000 r-xp /usr/lib/libalarm.so.0.0.0
419cb000 41b08000 r-xp /usr/lib/libicui18n.so.51.1
41b18000 41bfc000 r-xp /usr/lib/libicuuc.so.51.1
41c11000 41c17000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
41c1f000 41c25000 r-xp /usr/lib/libwidget.so.1.0.0
41c2e000 41c33000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41c3b000 41c72000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
41c7b000 41c94000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
41c9d000 41cc7000 r-xp /usr/lib/libnfc.so.1.0.0
41cd0000 41d01000 r-xp /usr/lib/libmdm.so.1.1.85
41d09000 41d1f000 r-xp /usr/lib/libnetwork.so.0.0.0
41d28000 41d2d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
432bc000 432c5000 r-xp /usr/lib/libcom-core.so.0.0.1
432ce000 432da000 r-xp /usr/lib/libwidget_service.so.1.0.0
432e2000 432eb000 r-xp /usr/lib/libwidget_provider.so.1.0.0
432f4000 432fa000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43302000 4330a000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43312000 43340000 r-xp /usr/lib/libnfc-common-lib.so.1.0.0
4334c000 43354000 r-xp /usr/lib/libdrm.so.2.4.0
4335c000 4335e000 r-xp /usr/lib/libdri2.so.0.0.0
43366000 4336d000 r-xp /usr/lib/libtbm.so.1.0.0
43375000 4338f000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43398000 4339f000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
433a8000 433aa000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
433b2000 433b9000 r-xp /usr/lib/libminizip.so.1.0.0
433c1000 433ce000 r-xp /usr/lib/libail.so.0.1.0
43709000 43f08000 rw-p [stack:18570]
43f08000 43f0b000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
43f13000 43f1e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43f27000 43f3e000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
441fc000 441fe000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
45c01000 46400000 rw-p [stack:18582]
bec15000 bec36000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18182)
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
64
12-12 08:42:57.086+0900 I/efl-extension( 2501): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x46c5bc18, obj: 0x46c5bc18
12-12 08:42:57.086+0900 I/efl-extension( 2501): efl_extension_rotary.c: _object_deleted_cb(601) > done
12-12 08:42:57.096+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
12-12 08:42:57.096+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46c5bc18, elm_genlist, func : 0x41841e59
12-12 08:42:57.096+0900 I/efl-extension( 2501): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
12-12 08:42:57.111+0900 I/efl-extension( 2501): efl_extension_more_option.c: _cue_hide_cb(234) > called!!
12-12 08:42:57.111+0900 W/APP_CORE( 2501): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:660000a
12-12 08:42:57.121+0900 W/WATCH_CORE(18182): appcore-watch.c: __widget_create(958) > widget_create
12-12 08:42:57.126+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1712) > [SECURE_LOG] [12280.789062] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_12280.789062.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263182:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-12 08:42:57.126+0900 E/WIDGET_VIEWER(  717): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[12280.789062] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_12280.789062.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263182:4] gbar_fname[]
12-12 08:42:57.136+0900 E/WIDGET_VIEWER(15061): client.c: master_created(1712) > [SECURE_LOG] [12280.789062] pkgname: org.reolab.blackandwhite, id: file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_12280.789062.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://27263182:4", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 0, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
12-12 08:42:57.136+0900 E/WIDGET_VIEWER(15061): client.c: master_created(1751) > [SECURE_LOG] Already created: timestamp[12280.789062] pkgname[org.reolab.blackandwhite], id[file:///opt/usr/share/live_magazine/org.reolab.blackandwhite_717_12280.789062.png] content[] cluster[user,created] category[default] widget_fname[pixmap://27263182:4] gbar_fname[]
12-12 08:42:57.141+0900 E/WIDGET_VIEWER(  717): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-12 08:42:57.146+0900 E/WIDGET_EVAS(  717): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-12 08:42:57.146+0900 E/WIDGET_VIEWER(15061): widget.c: widget_viewer_get_size_type(2686) > [SECURE_LOG] widget_service_get_size_type failed : -22
12-12 08:42:57.146+0900 E/WIDGET_EVAS(15061): widget_viewer_evas.c: __widget_event_widget_updated(5859) > [SECURE_LOG] Size is not valid FFFF
12-12 08:42:57.281+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:42:57.296+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:42:57.466+0900 W/WATCH_CORE(18182): appcore-watch.c: __widget_create(976) > widget_create done
12-12 08:42:57.496+0900 I/WATCH_CORE(18182): appcore-watch.c: __watch_core_set_metadata(807) > No metadata info for the tick per second
12-12 08:42:57.496+0900 I/WATCH_CORE(18182): appcore-watch.c: __watch_core_set_metadata(827) > No metadata info for the background tick update
12-12 08:42:57.496+0900 I/WATCH_CORE(18182): appcore-watch.c: __watch_core_set_metadata(839) > No metadata info for the watchface
12-12 08:42:57.536+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:42:57.536+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:42:57.546+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:42:57.546+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:42:57.546+0900 W/WATCH_CORE(18182): appcore-watch.c: __widget_resume(1012) > widget_resume
12-12 08:42:57.556+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:42:57.561+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:42:57.561+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:42:57.596+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:42:57.641+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:42:57.681+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:42:57.681+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:42:57.996+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:42:58.006+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:42:58.021+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:42:58.066+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:42:58.066+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:42:58.071+0900 W/AUL_AMD (  479): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
12-12 08:42:58.071+0900 W/AUL_AMD (  479): amd_launch.c: __grab_timeout_handler(1362) > back key ungrab error
12-12 08:42:58.091+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:42:58.096+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 18182
12-12 08:42:58.101+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 12
12-12 08:42:58.311+0900 I/AUL_PAD (18594): launchpad_loader.c: main(603) > [candidate] elm init, returned: 1
12-12 08:42:58.476+0900 W/AUL_AMD (  479): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
12-12 08:42:59.001+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:42:59.031+0900 E/PKGMGR_SERVER(18563): pkgmgr-server.c: exit_server(1338) > exit_server Start [backend_status=1, queue_status=1] 
12-12 08:42:59.036+0900 E/PKGMGR_SERVER(18563): pkgmgr-server.c: main(2180) > package manager server terminated.
12-12 08:42:59.116+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:42:59.226+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:42:59.301+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:42:59.301+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:43:00.001+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:43:00.116+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:43:00.271+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:43:00.336+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_pre_cb(241) >  RENDER PRE [2] timer[1]
12-12 08:43:00.336+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_render_post_cb(269) >  RENDER POST [2] timer[1] lcd[1]
12-12 08:43:00.606+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:43:00.691+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:43:01.001+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1363) > Lock the display not to enter LCD OFF
12-12 08:43:01.006+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:43:01.086+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_lock_state(1702) > Lock LCD OFF is successfully done
12-12 08:43:01.171+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:43:01.231+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:834]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
12-12 08:43:01.301+0900 I/SHealth_Common( 1061): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-12 08:43:01.301+0900 I/SHealth_Service( 1061): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(668) > [1;35m ###[0;m
12-12 08:43:01.321+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[1681431895] is expired.
12-12 08:43:01.321+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1681431895, next duetime: 1449877441
12-12 08:43:01.326+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdon_cb(365) >  event lcdon[1][0]
12-12 08:43:01.326+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-dbox.c: clock_viewer_widget_set_black_cover(315) >  Set black cover[1] ani[0]
12-12 08:43:01.326+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdon_cb(392) >  lcdon by [touch] time[156066]
12-12 08:43:01.336+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1405) > ::APP:: view state=0, 3, 0
12-12 08:43:01.366+0900 I/SCONTEXT-LIB(  669): scontext.c: context_add_changed_cb(211) > [SUCCESS] Set Changed CB: 42 (req_id=72)
12-12 08:43:01.371+0900 E/RESOURCED(  480): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 14859
12-12 08:43:01.386+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:834]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
12-12 08:43:01.386+0900 W/W_HOME  (  717): dbus.c: _dbus_message_recv_cb(186) > LCD on
12-12 08:43:01.386+0900 W/W_HOME  (  717): gesture.c: _manual_render_disable_timer_set(161) > timer set
12-12 08:43:01.386+0900 W/W_HOME  (  717): gesture.c: _manual_render_disable_timer_del(151) > timer del
12-12 08:43:01.391+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1519) > [_on_lcd_signal_receive_cb:1519] _on_lcd_signal_receive_cb, 1519, Pre LCD on by [touch] after screen off time [156066]ms
12-12 08:43:01.391+0900 W/STARTER (  693): clock-mgr.c: _pre_lcd_on(1245) > [_pre_lcd_on:1245] Will LCD ON as reserved app[(null)] alpm mode[1]
12-12 08:43:01.391+0900 W/STARTER (  693): clock-mgr.c: _on_lcd_signal_receive_cb(1530) > [_on_lcd_signal_receive_cb:1530] _on_lcd_signal_receive_cb, 1530, Post LCD on by [touch]
12-12 08:43:01.391+0900 W/STARTER (  693): clock-mgr.c: _post_lcd_on(1291) > [_post_lcd_on:1291] LCD ON as reserved app[(null)] alpm mode[1]
12-12 08:43:01.396+0900 W/W_HOME  (  717): gesture.c: _apps_status_get(123) > apps status:0
12-12 08:43:01.396+0900 W/W_HOME  (  717): gesture.c: _lcd_on_cb(295) > move_to_clock:1 clock_visible:0 info->offtime:156066
12-12 08:43:01.396+0900 W/W_HOME  (  717): gesture.c: _lcd_on_cb(299) > clock isn't on top, place a clock to top
12-12 08:43:01.396+0900 W/W_HOME  (  717): gesture.c: _clock_show(228) > clock show
12-12 08:43:01.406+0900 W/W_HOME  (  717): gesture.c: _clock_show(243) > home raise
12-12 08:43:01.406+0900 E/W_HOME  (  717): gesture.c: gesture_win_aux_set(396) > wm.policy.win.do.not.use.deiconify.approve:-1
12-12 08:43:01.406+0900 W/W_HOME  (  717): dbus_util.c: home_dbus_home_raise_signal_send(260) > Sending HOME RAISE signal, result:0
12-12 08:43:01.406+0900 W/W_HOME  (  717): gesture.c: _clock_show(246) > home raise done
12-12 08:43:01.406+0900 W/W_HOME  (  717): gesture.c: _clock_show(253) > show clock
12-12 08:43:01.406+0900 W/W_HOME  (  717): event_manager.c: _lcd_on_cb(691) > lcd state: 1
12-12 08:43:01.406+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:43:01.421+0900 E/E17     (  365): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02400003)
12-12 08:43:01.426+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:43:01.496+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[603337968] is expired.
12-12 08:43:01.496+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 603337968, next duetime: 1449877441
12-12 08:43:01.501+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: OnReceiveDisplayChanged(905) > [0;32mINFO: LCDOn receive data : 1124317720[0;m
12-12 08:43:01.501+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-12 08:43:01.501+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-12 08:43:01.516+0900 I/efl-extension( 2501): efl_extension_more_option.c: eext_more_option_opened_get(600) > called!!
12-12 08:43:01.516+0900 W/wnotibp ( 2501): wnotiboard-popup-view.c: _wnotibp_event_home_raise_cb(1721) > [0, 3, 1]
12-12 08:43:01.546+0900 E/RESOURCED(  480): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 16058
12-12 08:43:01.561+0900 E/RESOURCED(  480): freezer-process.c: freezer_process_pid_set(146) > [freezer_process_pid_set,146] Cant find process info for 17964
12-12 08:43:01.566+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_expired(1325) > alarm_id[1452463420] is expired.
12-12 08:43:01.566+0900 W/ALARM_MANAGER(  475): alarm-manager-schedule.c: _alarm_next_duetime(497) > alarm_id: 1452463420, next duetime: 1449877441
12-12 08:43:01.566+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:43:01.566+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:44:01 (UTC).
12-12 08:43:01.566+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:43:01.566+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_handler_idle(1389) > Unlock the display from LCD OFF
12-12 08:43:01.576+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:834]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
12-12 08:43:01.586+0900 W/W_HOME  (  717): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
12-12 08:43:01.586+0900 W/W_HOME  (  717): gesture.c: _manual_render_enable(133) > 0
12-12 08:43:01.596+0900 W/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-12 08:43:01.606+0900 I/SHealth_Common( 1061): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-12 08:43:01.606+0900 I/SHealth_Common( 1061): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
12-12 08:43:01.611+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __display_unlock_state(1745) > Unlock LCD OFF is successfully done
12-12 08:43:01.616+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __alarm_remove_from_list(454) > [alarm-server]:Remove alarm id(70013618)
12-12 08:43:01.616+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(227) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
12-12 08:43:01.616+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(234) > Setted RTC Alarm date/time is 11-12-2015, 23:44:01 (UTC).
12-12 08:43:01.616+0900 W/ALARM_MANAGER(  475): alarm-manager.c: __rtc_set(249) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
12-12 08:43:01.616+0900 W/ALARM_MANAGER(  475): alarm-manager.c: alarm_manager_alarm_delete(2219) > alarm_id[70013618] is removed.
12-12 08:43:01.621+0900 E/EFL     (15061): evas_main<15061> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=12642317 button=1 downs=1
12-12 08:43:01.621+0900 E/EFL     (15061): evas_main<15061> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=12642402 button=1 downs=0
12-12 08:43:01.631+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdon_completed_cb(420) >  event lcdon completed[1]
12-12 08:43:01.631+0900 W/W_CLOCK_VIEWER(15061): clock-viewer-dbox.c: clock_viewer_widget_set_black_cover(315) >  Set black cover[0] ani[1]
12-12 08:43:01.631+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: clock_viewer_hide(951) >  reservied[0], gesture[1], clock visible[1]
12-12 08:43:01.631+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: _clock_viewer_send_clock_stop(733) >  clock stop <<
12-12 08:43:01.636+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-12 08:43:01.706+0900 W/ALARM_MANAGER(18182): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [1681431895]
12-12 08:43:01.706+0900 W/ALARM_MANAGER(18182): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [603337968]
12-12 08:43:01.706+0900 W/ALARM_MANAGER(18182): alarm-lib.c: __handle_expiry_method_call(154) > [alarm-lib] : Alarm expired for [ALARM.aorg.areolab.ablackandwhite] : Alarm id [1452463420]
12-12 08:43:01.711+0900 W/WATCH_CORE(18182): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
12-12 08:43:01.711+0900 I/WATCH_CORE(18182): appcore-watch.c: __signal_lcd_status_handler(1134) > Skip the background tick update
12-12 08:43:01.716+0900 W/WATCH_CORE(18182): appcore-watch.c: __signal_alpm_handler(1039) > signal_alpm_handler: ambient mode: 0, state: 2
12-12 08:43:01.716+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1061): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
12-12 08:43:01.716+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1061): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
12-12 08:43:01.716+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1061): preference.c: preference_get_double(1214) > preference_get_double(1061) : pedometer_inactive_period error
12-12 08:43:01.716+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1061): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-12 08:43:01.716+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1061): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-12 08:43:01.716+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1061): preference.c: preference_get_double(1214) > preference_get_double(1061) : inactive_10min_precaution_millisec error
12-12 08:43:01.716+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1061): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
12-12 08:43:01.716+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1061): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
12-12 08:43:01.716+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1061): preference.c: preference_get_double(1214) > preference_get_double(1061) : inactive_before_10min_precaution_millisec error
12-12 08:43:01.721+0900 E/WATCH_CORE(18182): appcore-watch.c: __signal_alpm_handler(1043) > invalid state
12-12 08:43:01.836+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_lcdon_vi_timer_cb(139) >  lcdon vi wait timer
12-12 08:43:01.836+0900 E/WIDGET_VIEWER(15061): widget.c: widget_viewer_set_visibility(3853) > [SECURE_LOG] CA Livebox is not able to change the visibility
12-12 08:43:01.851+0900 W/PROCESSMGR(  365): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
12-12 08:43:01.851+0900 W/W_HOME  (  717): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
12-12 08:43:01.851+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:43:01.851+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:43:01.851+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:43:01.851+0900 W/W_HOME  (  717): main.c: _ecore_x_message_cb(1222) > main_info.is_win_on_top: 1
12-12 08:43:01.856+0900 W/WATCH_CORE(18182): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
12-12 08:43:01.856+0900 I/WATCH_CORE(18182): appcore-watch.c: __signal_process_manager_handler(1167) > Skip the background tick update
12-12 08:43:01.876+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(0)
12-12 08:43:01.876+0900 W/W_HOME  (  717): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
12-12 08:43:01.876+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:43:01.876+0900 W/W_HOME  (  717): main.c: _window_visibility_cb(1189) > Window [0x2400003] is now visible(0)
12-12 08:43:01.876+0900 I/APP_CORE(  717): appcore-efl.c: __do_app(429) > [APP 717] Event: RESUME State: PAUSED
12-12 08:43:01.876+0900 I/CAPI_APPFW_APPLICATION(  717): app_main.c: app_appcore_resume(223) > app_appcore_resume
12-12 08:43:01.876+0900 W/W_HOME  (  717): main.c: _appcore_resume_cb(681) > appcore resume
12-12 08:43:01.876+0900 W/W_HOME  (  717): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
12-12 08:43:01.876+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:43:01.891+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:43:01.891+0900 W/W_HOME  (  717): main.c: home_resume(729) > journal_appcore_app_fully_loaded called
12-12 08:43:01.891+0900 W/W_HOME  (  717): main.c: home_resume(733) > clock/widget resumed
12-12 08:43:01.891+0900 W/W_HOME  (  717): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
12-12 08:43:01.896+0900 I/wnotib  (  717): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
12-12 08:43:01.896+0900 E/wnotib  (  717): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4570) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
12-12 08:43:01.896+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1684) > Do the postponed update job.
12-12 08:43:01.896+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1051) > idler for type: 0
12-12 08:43:01.896+0900 I/GESTURE (  139): gesture.c: BackGestureSetProperty(4497) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
12-12 08:43:01.921+0900 I/wnoti-proxy(  717): wnoti-client.c: is_mini_app(1739) > is_mini_app : 0
12-12 08:43:01.921+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1098) > unread_count: 1
12-12 08:43:01.921+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_add_category_data(622) > category_id: 289, application_id: 218, application_name: 카카오톡, time_stamp: 1449875409, content_id: 0, spannable_string_version: 1
12-12 08:43:01.926+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(408) > Activity fetch finished: -1
12-12 08:43:01.926+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(413) > activity action count: 1
12-12 08:43:01.926+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(418) > 1 activities retrieved.
12-12 08:43:01.931+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: __clock_viewer_clock_changed_timer_cb(131) >  clock changed timer
12-12 08:43:01.931+0900 W/W_CLOCK_VIEWER(15061): clock-viewer.c: _clock_viewer_send_clock_changed(747) >  clock changed <<
12-12 08:43:01.931+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(508) > Page fetch finished: -1
12-12 08:43:01.941+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(513) > wearable_page_cnt: 1
12-12 08:43:01.941+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: wnotib_noti_manager_add_detail_data(518) > 1 pages retrieved. start_scroll_bottom: 1
12-12 08:43:01.941+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 289, application_id: 218, type: 13
12-12 08:43:01.941+0900 I/wnotib  (  717): w-notification-board-panel-basic.c: _wnotib_basic_panel_message_receive(4081) > New event with category_id: 289, application_id: 218, type: 12
12-12 08:43:01.941+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1379) > Num categories: 1, num total noti: 1
12-12 08:43:01.941+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(863) > Free noti manager data.
12-12 08:43:01.946+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(868) > Free previous notifications.
12-12 08:43:01.946+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_free_data(889) > Free previous categories.
12-12 08:43:01.946+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(134) > type: 0
12-12 08:43:01.946+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(155) > Number of uncleared categories: 1, setting_power_saving_mode: 0, show_summary_board: 0
12-12 08:43:01.946+0900 I/wnotib  (  717): w-notification-board-panel-summary.c: _wnotib_summary_panel_message_receive(212) > is_notification_enabled: 1, blocking mode: 0
12-12 08:43:01.946+0900 I/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1404) > num_total_panel: 1.
12-12 08:43:01.946+0900 W/W_HOME  (  717): noti_broker.c: _handler_indicator_update(562) > 0x1
12-12 08:43:01.996+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:43:01.996+0900 W/wnotib  (  717): w-notification-board-noti-manager.c: _wnotib_noti_manager_idler_cb(1408) > unread_count_for_home: 0
12-12 08:43:01.996+0900 W/W_HOME  (  717): noti_broker.c: _handler_noti_indicator_hide(498) > 
12-12 08:43:02.011+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:43:02.021+0900 I/MALI    (  717): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442b6d88] swap changed from async to sync
12-12 08:43:02.021+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-12 08:43:02.021+0900 W/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-12 08:43:02.021+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-12 08:43:02.021+0900 I/HIGEAR  ( 1131): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-12 08:43:02.031+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:43:02.896+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:43:02.896+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:43:02.896+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:43:02.896+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-12 08:43:02.896+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-12 08:43:02.896+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:43:02.896+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-12 08:43:02.896+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:43:02.896+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:43:02.901+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:43:02.901+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:43:02.901+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-12 08:43:02.901+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-12 08:43:02.901+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:43:02.901+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
12-12 08:43:02.901+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-12 08:43:02.901+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-12 08:43:02.901+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:43:02.901+0900 E/CAPI_APPFW_APP_CONTROL(  834): app_control.c: app_control_error(133) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
12-12 08:43:02.901+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-service.c: _music_control_service_pasre_request(409) > [33m[TID:834]   value = [true][0m
12-12 08:43:02.906+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:43:02.921+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 717
12-12 08:43:02.936+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:834]   [MUSIC_PLAYER_EVENT][0m
12-12 08:43:02.941+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:43:02.941+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:43:02.941+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:43:02.941+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-12 08:43:02.941+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-12 08:43:02.941+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:43:02.941+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-12 08:43:02.941+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:43:02.946+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:43:02.946+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:43:02.946+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:43:02.946+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-12 08:43:02.946+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-12 08:43:02.946+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:43:02.946+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-12 08:43:02.946+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-12 08:43:02.951+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-12 08:43:02.951+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:43:02.951+0900 W/W_HOME  (  717): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-12 08:43:02.951+0900 E/W_HOME  (  717): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-12 08:43:02.956+0900 W/MUSIC_CONTROL_SERVICE(  834): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:834]   [MUSIC_PLAYER_EVENT][0m
12-12 08:43:02.966+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:43:02.966+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:43:02.966+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-12 08:43:02.971+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:43:02.976+0900 W/W_HOME  (  717): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:paused 
12-12 08:43:02.976+0900 E/W_HOME  (  717): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
12-12 08:43:02.976+0900 I/MESSAGE_PORT(  432): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
12-12 08:43:02.981+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
12-12 08:43:02.981+0900 I/MESSAGE_PORT(  432): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
12-12 08:43:03.001+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:43:03.026+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:43:03.051+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:43:03.071+0900 W/W_HOME  (  717): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
12-12 08:43:03.071+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: OnReceiveGestureChanged(928) > [0;32mINFO: wakeup receive data : 1124317672[0;m
12-12 08:43:03.071+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupServiceStart(357) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
12-12 08:43:03.071+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_set_param(1239) > [SVOICE] set param [keyword length] : 0
12-12 08:43:03.086+0900 W/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
12-12 08:43:03.091+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1207) > [SVOICE] Wake up Enable start
12-12 08:43:03.106+0900 I/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1210) > [SVOICE] Wake up Enable end. (ret: 0x0)
12-12 08:43:03.106+0900 W/TIZEN_N_SOUND_MANAGER( 1131): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
12-12 08:43:03.106+0900 W/WAKEUP-SERVICE( 1131): WakeupService.cpp: WakeupSetSeamlessValue(350) > [0;32mINFO: WAKEUP SET : 1[0;m
12-12 08:43:03.106+0900 I/HIGEAR  ( 1131): WakeupService.cpp: WakeupServiceStart(381) > [svoice:Application:WakeupServiceStart:IN]
12-12 08:43:03.161+0900 W/WATCH_CORE(18182): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 2
12-12 08:43:03.161+0900 I/WATCH_CORE(18182): appcore-watch.c: __signal_context_handler(1196) > Skip the background tick update
12-12 08:43:03.201+0900 E/SHealth_Common( 1061): SHealthMessagePortConnection.cpp: Send(344) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
12-12 08:43:04.001+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:43:04.181+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:43:04.281+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:43:05.001+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:43:05.136+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:43:05.236+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:43:05.621+0900 W/AUL_AMD (  479): amd_request.c: __request_handler(640) > __request_handler: 14
12-12 08:43:05.696+0900 W/AUL_AMD (  479): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 2502
12-12 08:43:06.001+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:43:06.106+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:43:06.156+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:43:07.001+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:43:07.141+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:43:07.226+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:43:07.796+0900 E/PKGMGR  (18746): pkgmgr.c: pkgmgr_client_reinstall(1823) > reinstall pkg start.
12-12 08:43:07.981+0900 E/PKGMGR_SERVER(18748): pkgmgr-server.c: main(2126) > package manager server start
12-12 08:43:07.996+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:43:08.076+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_initialize(72) > Wi-Fi successfully initialized
12-12 08:43:08.126+0900 I/CAPI_NETWORK_WIFI(18182): net_wifi.c: wifi_deinitialize(94) > Wi-Fi successfully de-initialized
12-12 08:43:08.131+0900 E/PKGMGR_SERVER(18748): pkgmgr-server.c: req_cb(686) > req_id=[org.reolab.blackandwhite_-492093895], req_type=[1], pkg_type=[rpm], pkgid=[org.reolab.blackandwhite], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.reolab.blackandwhite_-492093895' '-r' 'org.reolab.blackandwhite'], cookie=[eZqzwiaxv5CIZghhx8ZRlBlLU74=], backend_flag=[0]
12-12 08:43:08.136+0900 E/PKGMGR  (18748): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.reolab.blackandwhite]
12-12 08:43:08.136+0900 E/PKGMGR_SERVER(18748): pkgmgr-server.c: __get_type_from_msg(364) > pkgtype is null for org.reolab.blackandwhite 
12-12 08:43:08.151+0900 E/PKGMGR_SERVER(18749): pkgmgr-server.c: queue_job(1820) > INSTALL start, pkg path=[org.reolab.blackandwhite]
12-12 08:43:08.156+0900 E/PKGMGR  (18746): pkgmgr.c: pkgmgr_client_reinstall(1935) > reinstall pkg finish, ret=[187460002]
12-12 08:43:08.331+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, STARTED]
12-12 08:43:08.336+0900 W/AUL_AMD (  479): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
12-12 08:43:08.341+0900 W/W_HOME  (  717): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.reolab.blackandwhite is being updateded:0
12-12 08:43:08.356+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-12 08:43:08.961+0900 E/PKGMGR_CERT(18749): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
12-12 08:43:08.971+0900 E/PKGMGR_CERT(18749): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 96
12-12 08:43:08.971+0900 E/PKGMGR_CERT(18749): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 96
12-12 08:43:08.971+0900 E/PKGMGR_CERT(18749): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 22 4
12-12 08:43:08.976+0900 E/PKGMGR_CERT(18749): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 4
12-12 08:43:08.976+0900 E/PKGMGR_CERT(18749): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 4
12-12 08:43:08.976+0900 E/PKGMGR_CERT(18749): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 4
12-12 08:43:08.981+0900 E/WMS     (  477): wms_event_handler.c: _wms_event_handler_cb_log_package(4451) > package [_________] callback : [UPDATE, PROCESSING]
12-12 08:43:08.996+0900 E/PKGMGR_CERT(18749): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
12-12 08:43:08.996+0900 I/CAPI_WATCH_APPLICATION(18182): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
12-12 08:43:09.266+0900 W/CRASH_MANAGER(18750): worker.c: worker_job(1199) > 1118182626c61144987738
