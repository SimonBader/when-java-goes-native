For 64-bit platform application using USB dll,

Note 1 for System_DLL 
Please copy below three dlls to C:\Windows\System32
	msvcr110.dll (VC2012 runtime dll for USBDEV_LIB.DLL and ICPDAS_USBIO.DLL )
	setupapi.dll (Windows DDK for USB device)
	hid.dll (Windows DDK for USB device)

Note 2 for VC_DLL_x64
Please copy DLLs in VC_DLL_x64 to exe file folder
	USBDEV_LIB.DLL and ICPDAS_USBIO.DLL are for USB I/O communication and I/O read write
	

Note 3 for Dotnet_DLL_x64:
Please delete ICPDAS_USBIO_dotNET.dll in C:\Windows\Microsoft.NET\Framework\v2.0.50727\
ICPDAS_USBIO_dotNET.dll is the USB API interface for Dotnet program.
Please copy USBDEV_LIB.DLL,ICPDAS_USBIO.dll and ICPDAS_USBIO_dotNET.dll to the exe file folder (C# or VB.net)	

Note 4 for MFC and VC program:
Please copy USBDEV_LIB.DLL and ICPDAS_USBIO.dll to the exe file folder

Note 5 for Dotnet program:
Please copy USBDEV_LIB.DLL,ICPDAS_USBIO.dll and ICPDAS_USBIO_dotNET.dll to the exe file folder