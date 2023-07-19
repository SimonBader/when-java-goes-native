from ctypes import *

lib = windll.LoadLibrary('./ICPDAS_USBIO.dll')
lib.CreateInstance.restype = c_void_p
#bFlag = c_bool()
#bCh = c_char()
#bVal = c_char()

#wVal = c_int()
#dwVal = c_ulong()
#fVal = c_float()

#byteArr = (c_char * 8)() #
#bytePrt = (c_char * 1)()
#strBuf = (c_char * 128)()

#wArr = (c_int*8)()
#wPtr = (c_int*1)()
#dwArr = (c_ulong * 32)() # max 32 ch DI Counter
#dwPtr = (c_ulong * 1)()

#fArr = (c_float * 8)()
#fPtr = (c_float * 1)()

class USBIO(object): 
    def __init__(self):        
        lib.OpenDevice.argtypes = [c_void_p, c_int , c_char ]
        lib.OpenDevice.restype = c_int
    	
        lib.CloseDevice.argtypes = [c_void_p]
        lib.CloseDevice.restype = c_int
	
        lib.SYNCDevice.argtypes = [c_void_p]
        lib.SYNCDevice.restype = c_int
            
        lib.SetCommTimeout.argtypes = [c_void_p, c_ulong ]
        lib.SetCommTimeout.restype = c_int
            
        lib.GetCommTimeout.argtypes = [c_void_p, POINTER(c_ulong)]
        lib.GetCommTimeout.restype = c_int
	
        lib.SetAutoResetWDT.argtypes = [c_void_p, c_bool ]
        lib.SetAutoResetWDT.restype = c_int


        lib.RefreshDeviceInfo.argtypes = [c_void_p]
        lib.RefreshDeviceInfo.restype = c_int

        lib.GetSoftWDTTimeout.argtypes = [c_void_p, POINTER(c_ulong)]
        lib.GetSoftWDTTimeout.restype = c_int

        lib.GetDeviceID.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.GetDeviceID.restype = c_int

        lib.GetFwVer.argtypes = [c_void_p, POINTER(c_int) ]
        lib.GetFwVer.restype = c_int

        lib.GetDeviceNickName.argtypes = [c_void_p, POINTER(c_char) ]
        lib.GetDeviceNickName.restype = c_int

        lib.GetDeviceSN.argtypes = [c_void_p, POINTER(c_char) ]
        lib.GetDeviceSN.restype = c_int

        lib.GetSupportIOMask.argtypes = [c_void_p, POINTER(c_char) ]
        lib.GetSupportIOMask.restype = c_int

        lib.GetDITotal.argtypes = [c_void_p, POINTER(c_char) ]
        lib.GetDITotal.restype = c_int

        lib.GetDOTotal.argtypes = [c_void_p, POINTER(c_char) ]
        lib.GetDOTotal.restype = c_int

        lib.GetAITotal.argtypes = [c_void_p, POINTER(c_char) ]
        lib.GetAITotal.restype = c_int

        lib.GetAOTotal.argtypes = [c_void_p, POINTER(c_char) ]
        lib.GetAOTotal.restype = c_int

        lib.GetPITotal.argtypes = [c_void_p, POINTER(c_char) ]
        lib.GetPITotal.restype = c_int

        lib.GetPOTotal.argtypes = [c_void_p, POINTER(c_char) ]
        lib.GetPOTotal.restype = c_int


        lib.SetUserDefinedBoardID.argtypes = [c_void_p, c_char]
        lib.SetUserDefinedBoardID.restype = c_int

        lib.SetDeviceNickName.argtypes = [c_void_p, POINTER(c_char) ]
        lib.SetDeviceNickName.restype = c_int

        lib.SetSoftWDTTimeout.argtypes = [c_void_p, c_ulong ]
        lib.SetSoftWDTTimeout.restype = c_int

        lib.LoadDefault.argtypes = [c_void_p]
        lib.LoadDefault.restype = c_int



        lib.DO_GetPowerOnEnable.argtypes = [c_void_p, POINTER(c_char) ]
        lib.DO_GetPowerOnEnable.restype = c_int

        lib.DO_GetSafetyEnable.argtypes = [c_void_p, POINTER(c_char) ]
        lib.DO_GetSafetyEnable.restype = c_int

        lib.DO_GetSafetyValue.argtypes = [c_void_p, POINTER(c_char) ]
        lib.DO_GetSafetyValue.restype = c_int

        lib.DO_GetDigitalOutputInverse.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.DO_GetDigitalOutputInverse.restype = c_int

        lib.DO_ReadValue.argtypes = [c_void_p, POINTER(c_char) ]
        lib.DO_ReadValue.restype = c_int


        lib.DO_SetPowerOnEnable.argtypes = [c_void_p, c_char , c_char ]
        lib.DO_SetPowerOnEnable.restype = c_int

        lib.DO_SetPowerOnEnables.argtypes = [c_void_p, POINTER(c_char) ]
        lib.DO_SetPowerOnEnables.restype = c_int

        lib.DO_SetSafetyEnable.argtypes = [c_void_p, POINTER(c_char) ]
        lib.DO_SetSafetyEnable.restype = c_int

        lib.DO_SetSafetyValue.argtypes = [c_void_p, POINTER(c_char) ]
        lib.DO_SetSafetyValue.restype = c_int

        lib.DO_SetDigitalOutputInverse.argtypes = [c_void_p, c_ulong ]
        lib.DO_SetDigitalOutputInverse.restype = c_int

        lib.DO_WriteValue.argtypes = [c_void_p, POINTER(c_char) ]
        lib.DO_WriteValue.restype = c_int

        lib.DO_WriteChannelValue.argtypes = [c_void_p, c_char , c_char ]
        lib.DO_WriteChannelValue.restype = c_int	

        lib.DI_GetDigitalFilterWidth.argtypes = [c_void_p, POINTER(c_int) ]
        lib.DI_GetDigitalFilterWidth.restype = c_int

        lib.DI_GetDigitalValueInverse.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.DI_GetDigitalValueInverse.restype = c_int

        lib.DI_GetCntEdgeTrigger.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.DI_GetCntEdgeTrigger.restype = c_int

        lib.DI_ReadValue.argtypes = [c_void_p, POINTER(c_char) ]
        lib.DI_ReadValue.restype = c_int

        lib.DI_ReadCounterValue.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.DI_ReadCounterValue.restype = c_int	

        lib.DI_SetDigitalFilterWidth.argtypes = [c_void_p, c_int ]
        lib.DI_SetDigitalFilterWidth.restype = c_int

        lib.DI_SetDigitalValueInverse.argtypes = [c_void_p, c_ulong ]
        lib.DI_SetDigitalValueInverse.restype = c_int

        lib.DI_SetCntEdgeTrigger.argtypes = [c_void_p, c_ulong ]
        lib.DI_SetCntEdgeTrigger.restype = c_int

        lib.DI_WriteClearCounter.argtypes = [c_void_p, c_char ]
        lib.DI_WriteClearCounter.restype = c_int

        lib.DI_WriteClearCounters.argtypes = [c_void_p, c_ulong ]
        lib.DI_WriteClearCounters.restype = c_int	

        lib.AI_GetTotalSupportType.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.AI_GetTotalSupportType.restype = c_int

        lib.AI_GetSupportTypeCode.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.AI_GetSupportTypeCode.restype = c_int

        lib.AI_GetTypeCode.argtypes = [c_void_p, POINTER(c_char) ]
        lib.AI_GetTypeCode.restype = c_int

        lib.AI_GetChCJCOffset.argtypes = [c_void_p, POINTER(c_float) ]
        lib.AI_GetChCJCOffset.restype = c_int

        lib.AI_GetChEnable.argtypes = [c_void_p, POINTER(c_char) ]
        lib.AI_GetChEnable.restype = c_int


        lib.AI_GetFilterRejection.argtypes = [c_void_p, POINTER(c_char) ]
        lib.AI_GetFilterRejection.restype = c_int

        lib.AI_GetCJCOffset.argtypes = [c_void_p, POINTER(c_float) ]
        lib.AI_GetCJCOffset.restype = c_int

        lib.AI_GetCJCEnable.argtypes = [c_void_p, POINTER(c_char) ]
        lib.AI_GetCJCEnable.restype = c_int

        lib.AI_GetWireDetectEnable.argtypes = [c_void_p, POINTER(c_char) ]
        lib.AI_GetWireDetectEnable.restype = c_int

        lib.AI_GetResolution.argtypes = [c_void_p, POINTER(c_char) ]
        lib.AI_GetResolution.restype = c_int

        lib.AI_ReadValueDigital.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.AI_ReadValueDigital.restype = c_int

        lib.AI_ReadValueDigitalWithChSta.argtypes = [c_void_p, POINTER(c_ulong) , POINTER(c_char) ]
        lib.AI_ReadValueDigitalWithChSta.restype = c_int

        lib.AI_ReadValueAnalog.argtypes = [c_void_p, POINTER(c_float) ]
        lib.AI_ReadValueAnalog.restype = c_int

        lib.AI_ReadValueAnalogWithChSta.argtypes = [c_void_p, POINTER(c_float) , POINTER(c_char) ]
        lib.AI_ReadValueAnalogWithChSta.restype = c_int
            
        lib.AI_ReadCJCValue.argtypes = [c_void_p, POINTER(c_float) ]
        lib.AI_ReadCJCValue.restype = c_int

        lib.AI_GetChSampleRate.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.AI_GetChSampleRate.restype = c_int	

        lib.AI_SetTypeCode.argtypes = [c_void_p, c_char , c_char ]
        lib.AI_SetTypeCode.restype = c_int

        lib.AI_SetTypeCodes.argtypes = [c_void_p, POINTER(c_char) ]
        lib.AI_SetTypeCodes.restype = c_int

        lib.AI_SetChCJCOffset.argtypes = [c_void_p, c_char , c_float ]
        lib.AI_SetChCJCOffset.restype = c_int

        lib.AI_SetChCJCOffsets.argtypes = [c_void_p, POINTER(c_float) ]
        lib.AI_SetChCJCOffsets.restype = c_int

        lib.AI_SetChEnable.argtypes = [c_void_p, POINTER(c_char) ]
        lib.AI_SetChEnable.restype = c_int	

        lib.AI_SetFilterRejection.argtypes = [c_void_p, c_char ]
        lib.AI_SetFilterRejection.restype = c_int

        lib.AI_SetCJCOffset.argtypes = [c_void_p, c_float ]
        lib.AI_SetCJCOffset.restype = c_int

        lib.AI_SetCJCEnable.argtypes = [c_void_p, c_char ]
        lib.AI_SetCJCEnable.restype = c_int

        lib.AI_SetWireDetectEnable.argtypes = [c_void_p, c_char ]
        lib.AI_SetWireDetectEnable.restype = c_int

        lib.AI_SetChSampleRate.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.AI_SetChSampleRate.restype = c_int


        lib.AO_GetTotalSupportType.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.AO_GetTotalSupportType.restype = c_int

        lib.AO_GetSupportTypeCode.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.AO_GetSupportTypeCode.restype = c_int

        lib.AO_GetTypeCode.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.AO_GetTypeCode.restype = c_int

        lib.AO_GetChEnable.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.AO_GetChEnable.restype = c_int

        lib.AO_GetResolution.argtypes = [c_void_p, POINTER(c_char) ]
        lib.AO_GetResolution.restype = c_int

        lib.AO_ReadExpValueDigital.argtypes = [c_void_p, POINTER(c_ulong)  ]
        lib.AO_ReadExpValueDigital.restype = c_int

        lib.AO_ReadExpValueAnalog.argtypes = [c_void_p, POINTER(c_float)  ]
        lib.AO_ReadExpValueAnalog.restype = c_int

        lib.AO_ReadCurValueDigital.argtypes = [c_void_p, POINTER(c_ulong)  ]
        lib.AO_ReadCurValueDigital.restype = c_int

        lib.AO_ReadCurValueAnalog.argtypes = [c_void_p, POINTER(c_float)  ]
        lib.AO_ReadCurValueAnalog.restype = c_int

        lib.AO_GetPowerOnEnable.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.AO_GetPowerOnEnable.restype = c_int

        lib.AO_GetSafetyEnable.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.AO_GetSafetyEnable.restype = c_int

        lib.AO_GetPowerOnValueDigital.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.AO_GetPowerOnValueDigital.restype = c_int

        lib.AO_GetPowerOnValueAnalog.argtypes = [c_void_p, POINTER(c_float) ]
        lib.AO_GetPowerOnValueAnalog.restype = c_int

        lib.AO_GetSafetyValueDigital.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.AO_GetSafetyValueDigital.restype = c_int

        lib.AO_GetSafetyValueAnalog.argtypes = [c_void_p, POINTER(c_float) ]
        lib.AO_GetSafetyValueAnalog.restype = c_int

        lib.AO_GetSlewRate.argtypes = [c_void_p, POINTER(c_char) ]
        lib.AO_GetSlewRate.restype = c_int	

        lib.AO_SetTypeCode.argtypes = [c_void_p, c_char , c_char  ]
        lib.AO_SetTypeCode.restype = c_int

        lib.AO_SetTypeCodes.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.AO_SetTypeCodes.restype = c_int

        lib.AO_SetChEnable.argtypes = [c_void_p,POINTER(c_char)  ]
        lib.AO_SetChEnable.restype = c_int

        lib.AO_WriteChannelValueDigital.argtypes = [c_void_p, c_char , c_ulong  ]
        lib.AO_WriteChannelValueDigital.restype = c_int

        lib.AO_WriteValueDigital.argtypes = [c_void_p, POINTER(c_ulong)  ]
        lib.AO_WriteValueDigital.restype = c_int
                                        
        lib.AO_WriteChannelValueAnalog.argtypes = [c_void_p, c_char , c_float  ]
        lib.AO_WriteChannelValueAnalog.restype = c_int

        lib.AO_WriteValueAnalog.argtypes = [c_void_p, POINTER(c_float)  ]
        lib.AO_WriteValueAnalog.restype = c_int

        lib.AO_SetPowerOnEnable.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.AO_SetPowerOnEnable.restype = c_int

        lib.AO_SetSafetyEnable.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.AO_SetSafetyEnable.restype = c_int

        lib.AO_SetPowerOnValueDigital.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.AO_SetPowerOnValueDigital.restype = c_int

        lib.AO_SetPowerOnChannelValueDigital.argtypes = [c_void_p, c_char , c_ulong ]
        lib.AO_SetPowerOnChannelValueDigital.restype = c_int

        lib.AO_SetPowerOnValueAnalog.argtypes = [c_void_p, POINTER(c_float) ]
        lib.AO_SetPowerOnValueAnalog.restype = c_int

        lib.AO_SetPowerOnChannelValueAnalog.argtypes = [c_void_p, c_char , c_float ]
        lib.AO_SetPowerOnChannelValueAnalog.restype = c_int

        lib.AO_SetSafetyValueDigital.argtypes = [c_void_p, POINTER(c_ulong) ]
        lib.AO_SetSafetyValueDigital.restype = c_int

        lib.AO_SetSafetyChannelValueDigital.argtypes = [c_void_p, c_char , c_ulong ]
        lib.AO_SetSafetyChannelValueDigital.restype = c_int

        lib.AO_SetSafetyValueAnalog.argtypes = [c_void_p, POINTER(c_float) ]
        lib.AO_SetSafetyValueAnalog.restype = c_int

        lib.AO_SetSafetyChannelValueAnalog.argtypes = [c_void_p, c_char , c_float ]
        lib.AO_SetSafetyChannelValueAnalog.restype = c_int

        lib.AO_SetSlewRate.argtypes = [c_void_p, POINTER(c_char) ]
        lib.AO_SetSlewRate.restype = c_int

        lib.PI_GetTotalSupportType.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.PI_GetTotalSupportType.restype = c_int

        lib.PI_GetSupportTypeCode.argtypes = [c_void_p, POINTER(c_char)  ]
        lib.PI_GetSupportTypeCode.restype = c_int

        lib.PI_GetTypeCode.argtypes = [c_void_p, POINTER(c_char) ]
        lib.PI_GetTypeCode.restype = c_int

        lib.PI_GetTriggerMode.argtypes = [c_void_p, POINTER(c_char) ]
        lib.PI_GetTriggerMode.restype = c_int

        lib.PI_GetChIsolatedFlag.argtypes = [c_void_p, POINTER(c_char) ]
        lib.PI_GetChIsolatedFlag.restype = c_int

        lib.PI_GetLPFilterEnable.argtypes = [c_void_p, POINTER(c_char) ]
        lib.PI_GetLPFilterEnable.restype = c_int

        lib.PI_GetLPFilterWidth.argtypes = [c_void_p, POINTER(c_int) ]
        lib.PI_GetLPFilterWidth.restype = c_int

        lib.PI_ReadValue.argtypes = [c_void_p, POINTER(c_ulong) , POINTER(c_char) ]
        lib.PI_ReadValue.restype = c_int

        lib.PI_ReadCntValue.argtypes = [c_void_p, POINTER(c_ulong) , POINTER(c_char) ]
        lib.PI_ReadCntValue.restype = c_int

        lib.PI_ReadFreqValue.argtypes = [c_void_p, POINTER(c_float) , POINTER(c_char) ]
        lib.PI_ReadFreqValue.restype = c_int	

        lib.PI_SetTypeCode.argtypes = [c_void_p, c_char , c_char ]
        lib.PI_SetTypeCode.restype = c_int

        lib.PI_SetTypeCodes.argtypes = [c_void_p, POINTER(c_char) ]
        lib.PI_SetTypeCodes.restype = c_int

        lib.PI_ClearSingleChCount.argtypes = [c_void_p, c_char ]
        lib.PI_ClearSingleChCount.restype = c_int

        lib.PI_ClearChCount.argtypes = [c_void_p, POINTER(c_char) ]
        lib.PI_ClearChCount.restype = c_int

        lib.PI_ClearSingleChStatus.argtypes = [c_void_p, c_char ]
        lib.PI_ClearSingleChStatus.restype = c_int

        lib.PI_ClearChStatus.argtypes = [c_void_p, POINTER(c_char) ]
        lib.PI_ClearChStatus.restype = c_int	

        lib.PI_SetTriggerMode.argtypes = [c_void_p, c_char , c_char ]
        lib.PI_SetTriggerMode.restype = c_int

        lib.PI_SetTriggerModes.argtypes = [c_void_p, POINTER(c_char) ]
        lib.PI_SetTriggerModes.restype = c_int

        lib.PI_SetChIsolatedFlag.argtypes = [c_void_p, c_char , c_bool ]
        lib.PI_SetChIsolatedFlag.restype = c_int

        lib.PI_SetChIsolatedFlags.argtypes = [c_void_p, POINTER(c_char) ]
        lib.PI_SetChIsolatedFlags.restype = c_int

        lib.PI_SetLPFilterEnable.argtypes = [c_void_p, c_char , c_bool ]
        lib.PI_SetLPFilterEnable.restype = c_int

        lib.PI_SetLPFilterEnables.argtypes = [c_void_p, POINTER(c_char) ]
        lib.PI_SetLPFilterEnables.restype = c_int

        lib.PI_SetLPFilterWidth.argtypes = [c_void_p, c_char , c_int ]
        lib.PI_SetLPFilterWidth.restype = c_int

        lib.PI_SetLPFilterWidths.argtypes = [c_void_p, POINTER(c_int) ]  
        lib.PI_SetLPFilterWidths.restype = c_int
               
        self.obj = lib.CreateInstance() 
		
		

    # OpenDevice(ICPDAS_USBIO* pInstance, WORD wUSBIO_DID, BYTE byUSBIO_BID)
    def OpenDevice(self, wVal , bVal ): 
        return lib.OpenDevice(self.obj, wVal , bVal )
        
    # CloseDevice(ICPDAS_USBIO* pInstance)	
    def CloseDevice(self):
        return lib.CloseDevice(self.obj)
        
    # SYNCDevice(ICPDAS_USBIO* pInstance)
    def SYNCDevice(self):
        return lib.SYNCDevice(self.obj)
        
    # SetCommTimeout(ICPDAS_USBIO* pInstance, DWORD i_dwCommTimeout)	
    def SetCommTimeout(self, dwVal ):
        return lib.SetCommTimeout(self.obj,dwVal )
        
    # GetCommTimeout(ICPDAS_USBIO* pInstance, DWORD* o_dwCommTimeout)	
    def GetCommTimeout(self, dwPtr):
        return lib.GetCommTimeout(self.obj,dwPtr)
    
    # SetAutoResetWDT(ICPDAS_USBIO* pInstance, BOOL i_bEnable)	
    def SetAutoResetWDT(self, bFlag ):
        return lib.SetAutoResetWDT(self.obj,bFlag )
    	
    # RefreshDeviceInfo(ICPDAS_USBIO* pInstance)	
    def RefreshDeviceInfo(self):
        return lib.RefreshDeviceInfo(self.obj)
    
    # GetSoftWDTTimeout(ICPDAS_USBIO* pInstance, DWORD* o_dwSoftWDTTimeout)	
    def GetSoftWDTTimeout(self, dwPtr):
        return lib.GetSoftWDTTimeout(self.obj,dwPtr)
    
    # GetDeviceID(ICPDAS_USBIO* pInstance, DWORD* o_dwDeviceID)	
    def GetDeviceID(self, dwPtr):
        return lib.GetDeviceID(self.obj,dwPtr)
    
    # GetFwVer(ICPDAS_USBIO* pInstance, WORD* o_wFwVer)	
    def GetFwVer(self, wPrt):
        return lib.GetFwVer(self.obj,wPtr)
    
    # GetDeviceNickName(ICPDAS_USBIO* pInstance, BYTE* o_byDeviceNickName)	
    def GetDeviceNickName(self, strBuf):
        return lib.GetDeviceNickName(self.obj, strBuf)
    
    # GetDeviceSN(ICPDAS_USBIO* pInstance, BYTE* o_byDeviceSN)	
    def GetDeviceSN(self, strBuf):
        return lib.GetDeviceSN(self.obj,strBuf)
    
    # GetSupportIOMask(ICPDAS_USBIO* pInstance, BYTE* o_bySupportIOMask)	
    def GetSupportIOMask(self, bytePtr ):
        return lib.GetSupportIOMask(self.obj, bytePtr )
    
    # GetDITotal(ICPDAS_USBIO* pInstance, BYTE* o_byDITotal)	
    def GetDITotal(self, bytePtr):
        return lib.GetDITotal(self.obj,bytePtr )
    
    # GetDOTotal(ICPDAS_USBIO* pInstance, BYTE* o_byDOTotal)	
    def GetDOTotal(self, bytePtr):
        return lib.GetDOTotal(self.obj,bytePtr)
        
    # GetAITotal(ICPDAS_USBIO* pInstance, BYTE* o_byAITotal)	
    def GetAITotal(self, bytePtr):
        return lib.GetAITotal(self.obj,bytePtr )
        
    # GetAOTotal(ICPDAS_USBIO* pInstance, BYTE* o_byAOTotal)	
    def GetAOTotal(self, bytePtr ):
        return lib.GetAOTotal(self.obj,bytePtr )
    
    # GetPITotal(ICPDAS_USBIO* pInstance, BYTE* o_byPITotal)	
    def GetPITotal(self,bytePtr):
        return lib.GetPITotal(self.obj,bytePtr)
    
    # GetPOTotal(ICPDAS_USBIO* pInstance, BYTE* o_byPOTotal)	
    def GetPOTotal(self, bytePtr):
        return lib.GetPOTotal(self.obj,bytePtr)
    	
    # SetUserDefinedBoardID(ICPDAS_USBIO* pInstance, BYTE i_byBID)	
    def SetUserDefinedBoardID(self, bVal):
        return lib.SetUserDefinedBoardID(self.obj,bVal)
    
    # SetDeviceNickName(ICPDAS_USBIO* pInstance, BYTE* i_byDeviceNickName)	
    def SetDeviceNickName(self, strBuf):
        return lib.SetDeviceNickName(self.obj,strBuf)
    
    # SetSoftWDTTimeout(ICPDAS_USBIO* pInstance, DWORD i_dwSoftWDTTimeout)	
    def SetSoftWDTTimeout(self, dwVal ):
        return lib.SetSoftWDTTimeout(self.obj,dwVal )
    
    # LoadDefault(ICPDAS_USBIO* pInstance)	
    def LoadDefault(self):
        return lib.LoadDefault(self.obj)		
    	
    # DO_GetPowerOnEnable(ICPDAS_USBIO* pInstance, BYTE* o_byPowerOnEnable)	
    def DO_GetPowerOnEnable(self, byteArr):
        return lib.DO_GetPowerOnEnable(self.obj, byteArr)
    
    # DO_GetSafetyEnable(ICPDAS_USBIO* pInstance, BYTE* o_bySafetyEnable)	
    def DO_GetSafetyEnable(self, byteArr):
        return lib.DO_GetSafetyEnable(self.obj, byteArr)
        
    # DO_GetSafetyValue(ICPDAS_USBIO* pInstance, BYTE* o_bySafetyValue)	
    def DO_GetSafetyValue(self, byteArr):
        return lib.DO_GetSafetyValue(self.obj,byteArr)
    
    # DO_GetDigitalOutputInverse(ICPDAS_USBIO* pInstance, DWORD* o_dwInverse)	
    def DO_GetDigitalOutputInverse(self, dwPtr):
        return lib.DO_GetDigitalOutputInverse(self.obj,dwPtr)
    
    # DO_ReadValue(ICPDAS_USBIO* pInstance, BYTE* o_byDOValue)	
    def DO_ReadValue(self, byteArr):
        return lib.DO_ReadValue(self.obj, byteArr)
    	
    # DO_SetPowerOnEnable(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, BYTE i_byPowerOnEnable)	
    def DO_SetPowerOnEnable(self, bCh , bVal ):
        return lib.DO_SetPowerOnEnable(self.obj, bCh, bVal )
    
    # DO_SetPowerOnEnables(ICPDAS_USBIO* pInstance, BYTE* i_byPowerOnEnables)	
    def DO_SetPowerOnEnables(self, byteArr):
        return lib.DO_SetPowerOnEnables(self.obj, byteArr)
    
    # DO_SetSafetyEnable(ICPDAS_USBIO* pInstance, BYTE* i_bySafetyEnable)	
    def DO_SetSafetyEnable(self, byteArr):
        return lib.DO_SetSafetyEnable(self.obj, byteArr)
    
    # DO_SetSafetyValue(ICPDAS_USBIO* pInstance, BYTE* i_bySafetyValue)	
    def DO_SetSafetyValue(self, byteArr):
        return lib.DO_SetSafetyValue(self.obj,byteArr)
    
    # DO_SetDigitalOutputInverse(ICPDAS_USBIO* pInstance, DWORD i_dwInverse)	
    def DO_SetDigitalOutputInverse(self, dwVal ):
        return lib.DO_SetDigitalOutputInverse(self.obj,dwVal )
    
    # DO_WriteValue(ICPDAS_USBIO* pInstance, BYTE* i_byDOValue)	
    def DO_WriteValue(self, byteArr):
        return lib.DO_WriteValue(self.obj,byteArr)
    
    # DO_WriteChannelValue(ICPDAS_USBIO* pInstance, BYTE i_byChannel, BYTE i_byValue)	
    def DO_WriteChannelValue(self, bCh , bVal ):
        return lib.DO_WriteChannelValue(self.obj, bCh , bVal )	
    
    # DI_GetDigitalFilterWidth(ICPDAS_USBIO* pInstance, WORD* o_wFilterWidth)	
    def DI_GetDigitalFilterWidth(self, wPtr ):
        return lib.DI_GetDigitalFilterWidth(self.obj,wPtr)
    
    # DI_GetDigitalValueInverse(ICPDAS_USBIO* pInstance, DWORD* o_dwInverse)	
    def DI_GetDigitalValueInverse(self, dwPtr):
        return lib.DI_GetDigitalValueInverse(self.obj,dwPtr)
    
    # DI_GetCntEdgeTrigger(ICPDAS_USBIO* pInstance, DWORD* o_dwEdgeTrig)	
    def DI_GetCntEdgeTrigger(self, dwPtr ):
        return lib.DI_GetCntEdgeTrigger(self.obj,dwPtr)
    
    # DI_ReadValue(ICPDAS_USBIO* pInstance, BYTE* o_byDIValue)	
    def DI_ReadValue(self, byteArr):
        return lib.DI_ReadValue(self.obj, byteArr)
    
    # DI_ReadCounterValue(ICPDAS_USBIO* pInstance, DWORD* o_dwDICntValue)	
    def DI_ReadCounterValue(self, dwArr):
        return lib.DI_ReadCounterValue(self.obj, dwArr)	
    
    # DI_SetDigitalFilterWidth(ICPDAS_USBIO* pInstance, WORD i_wFilterWidth)	
    def DI_SetDigitalFilterWidth(self, wVal ):
        return lib.DI_SetDigitalFilterWidth(self.obj,wVal )
    
    # DI_SetDigitalValueInverse(ICPDAS_USBIO* pInstance, DWORD i_dwInverse)	
    def DI_SetDigitalValueInverse(self, dwVal ):
        return lib.DI_SetDigitalValueInverse(self.obj, dwVal )
    
    # DI_SetCntEdgeTrigger(ICPDAS_USBIO* pInstance, DWORD i_dwEdgeTrig)	
    def DI_SetCntEdgeTrigger(self, dwVal ):
        return lib.DI_SetCntEdgeTrigger(self.obj, dwVal )
    
    # DI_WriteClearCounter(ICPDAS_USBIO* pInstance, BYTE i_byChToClr)	
    def DI_WriteClearCounter(self, bCh ):
        return lib.DI_WriteClearCounter(self.obj, bCh )
    
    # DI_WriteClearCounters(ICPDAS_USBIO* pInstance, DWORD i_dwCntClrMask)	
    def DI_WriteClearCounters(self, dwVal ):
        return lib.DI_WriteClearCounters(self.obj,dwVal )	
    	
    # AI_GetTotalSupportType( ICPDAS_USBIO* pInstance, BYTE* o_byTotalSupportType )
    def AI_GetTotalSupportType(self, byteArr):
        return lib.AI_GetTotalSupportType(self.obj, byteArr)
    
    # AI_GetSupportTypeCode( ICPDAS_USBIO* pInstance, BYTE* o_bySupportTypeCode )	
    def AI_GetSupportTypeCode(self, byteArr):
        return lib.AI_GetSupportTypeCode(self.obj, byteArr)
    
    # AI_GetTypeCode(ICPDAS_USBIO* pInstance, BYTE* o_byTypeCode)	
    def AI_GetTypeCode(self, byteArr):
        return lib.AI_GetTypeCode(self.obj, byteArr)
    
    # AI_GetChCJCOffset(ICPDAS_USBIO* pInstance, float* o_fChCJCOffset)	
    def AI_GetChCJCOffset(self, fArr):
        return lib.AI_GetChCJCOffset(self.obj,fArr)
    
    # AI_GetChEnable(ICPDAS_USBIO* pInstance, BYTE* o_byChEnable)	
    def AI_GetChEnable(self, byteArr):
        return lib.AI_GetChEnable(self.obj, byteArr)
    	
    # AI_GetFilterRejection(ICPDAS_USBIO* pInstance, BYTE* o_byFilterRejection)	
    def AI_GetFilterRejection(self, bytePrt):
        return lib.AI_GetFilterRejection(self.obj,bytePrt)
    
    # AI_GetCJCOffset(ICPDAS_USBIO* pInstance, float* o_fCJCOffset)	
    def AI_GetCJCOffset(self, fPtr):
        return lib.AI_GetCJCOffset(self.obj, fPtr)
    
    # AI_GetCJCEnable(ICPDAS_USBIO* pInstance, BYTE* o_byCJCEnable)	
    def AI_GetCJCEnable(self, bytePrt):
        return lib.AI_GetCJCEnable(self.obj,bytePrt)
    
    # AI_GetWireDetectEnable(ICPDAS_USBIO* pInstance, BYTE* o_byWireDetectEnable)	
    def AI_GetWireDetectEnable(self, bytePtr):
        return lib.AI_GetWireDetectEnable(self.obj,bytePrt)
    
    # AI_GetResolution(ICPDAS_USBIO* pInstance, BYTE* o_byResolution)	
    def AI_GetResolution(self, bytePrt):
        return lib.AI_GetResolution(self.obj,bytePrt)
    
    # AI_ReadValueDigital(ICPDAS_USBIO* pInstance, DWORD* o_dwAIValue)	
    def AI_ReadValueDigital(self, dwArr):
        return lib.AI_ReadValueDigital(self.obj,dwArr)
    
    # AI_ReadValueDigitalWithChSta(ICPDAS_USBIO* pInstance, DWORD* o_dwAIValue, BYTE* o_byAIChStatus)	
    def AI_ReadValueDigitalWithChSta(self, dwArr , byteArr):
        return lib.AI_ReadValueDigitalWithChSta(self.obj,dwArr , byteArr )
    
    # AI_ReadValueAnalog(ICPDAS_USBIO* pInstance, float* o_fAIValue)	
    def AI_ReadValueAnalog(self, fArr):
        return lib.AI_ReadValueAnalog(self.obj,fArr)
    
    # AI_ReadValueAnalogWithChSta(ICPDAS_USBIO* pInstance, float* o_fAIValue, BYTE* o_byAIChStatus)	
    def AI_ReadValueAnalogWithChSta(self, fArr , byteArr ):
        return lib.AI_ReadValueAnalogWithChSta(self.obj,fArr , byteArr )
    
    # AI_ReadCJCValue(ICPDAS_USBIO* pInstance, float* o_fCJCValue)		
    def AI_ReadCJCValue(self, fPtr ):
        return lib.AI_ReadCJCValue(self.obj,fPtr)
    
    # AI_GetChSampleRate(ICPDAS_USBIO* pInstance, DWORD* i_dwSampleRate)	
    def AI_GetChSampleRate(self, dwArr ):
        return lib.AI_GetChSampleRate(self.obj,dwArr)	
    
    # AI_SetTypeCode(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, BYTE i_byTypeCode)	
    def AI_SetTypeCode(self, bCh , bVal ):
        return lib.AI_SetTypeCode(self.obj,bCh , bVal )
    
    # AI_SetTypeCodes(ICPDAS_USBIO* pInstance, BYTE* i_byTypeCodes)	
    def AI_SetTypeCodes(self, byteArr):
        return lib.AI_SetTypeCodes(self.obj,byteArr)
        
    # AI_SetChCJCOffset(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, float i_fChCJCOffset)	
    def AI_SetChCJCOffset(self, bCh , fVal ):
        return lib.AI_SetChCJCOffset(self.obj,bCh , fVal )
    
    # AI_SetChCJCOffsets(ICPDAS_USBIO* pInstance, float* i_fChCJCOffsets)	
    def AI_SetChCJCOffsets(self, fArr):
        return lib.AI_SetChCJCOffsets(self.obj, fArr )
    
    # AI_SetChEnable(ICPDAS_USBIO* pInstance, BYTE* i_byChEnable)	
    def AI_SetChEnable(self, byteArr):
        return lib.AI_SetChEnable(self.obj,	byteArr )
    
    # AI_SetFilterRejection(ICPDAS_USBIO* pInstance, BYTE i_byFilterRejection)	
    def AI_SetFilterRejection(self, bVal ):
        return lib.AI_SetFilterRejection(self.obj,bVal )
    
    # AI_SetCJCOffset(ICPDAS_USBIO* pInstance, float i_fCJCOffset)	
    def AI_SetCJCOffset(self, fVal ):
        return lib.AI_SetCJCOffset(self.obj,fVal )
    
    # AI_SetCJCEnable(ICPDAS_USBIO* pInstance, BYTE i_byCJCEnable)	
    def AI_SetCJCEnable(self, bVal ):
        return lib.AI_SetCJCEnable(self.obj,bVal )
    
    # AI_SetWireDetectEnable(ICPDAS_USBIO* pInstance, BYTE i_byWireDetectEnable)	
    def AI_SetWireDetectEnable(self, bVal ):
        return lib.AI_SetWireDetectEnable(self.obj, bVal )
    
    # AI_SetChSampleRate(ICPDAS_USBIO* pInstance, DWORD* i_dwSampleRate)	
    def AI_SetChSampleRate(self, dwArr ):
        return lib.AI_SetChSampleRate(self.obj,dwArr )
    	
    # AO_GetTotalSupportType( ICPDAS_USBIO* pInstance, BYTE* o_byTotalSupportType )	
    def AO_GetTotalSupportType(self, byteArr ):
        return lib.AO_GetTotalSupportType(self.obj,byteArr )
    
    # AO_GetSupportTypeCode( ICPDAS_USBIO* pInstance, BYTE* o_bySupportTypeCode )	
    def AO_GetSupportTypeCode(self, byteArr ):
        return lib.AO_GetSupportTypeCode(self.obj,byteArr )
    
    # AO_GetTypeCode( ICPDAS_USBIO* pInstance, BYTE* o_byTypeCode )	
    def AO_GetTypeCode(self, byteArr ):
        return lib.AO_GetTypeCode(self.obj,byteArr)
    
    # AO_GetChEnable( ICPDAS_USBIO* pInstance, BYTE* o_byChEnable )	
    def AO_GetChEnable(self, byteArr ):
        return lib.AO_GetChEnable(self.obj,byteArr )
    
    # AO_GetResolution( ICPDAS_USBIO* pInstance, BYTE* o_byResolution)	
    def AO_GetResolution(self, bytePrt):
        return lib.AO_GetResolution(self.obj,bytePrt)
    
    # AO_ReadExpValueDigital( ICPDAS_USBIO* pInstance, DWORD* o_dwAOExpValue )	
    def AO_ReadExpValueDigital(self, dwArr ):
        return lib.AO_ReadExpValueDigital(self.obj, dwArr )
    
    # AO_ReadExpValueAnalog( ICPDAS_USBIO* pInstance, float* o_fAOExpValue )	
    def AO_ReadExpValueAnalog(self, fArr ):
        return lib.AO_ReadExpValueAnalog(self.obj, fArr)
    
    # AO_ReadCurValueDigital( ICPDAS_USBIO* pInstance, DWORD* o_dwAOCurValue )	
    def AO_ReadCurValueDigital(self, dwArr ):
        return lib.AO_ReadCurValueDigital(self.obj,dwArr)
    
    # AO_ReadCurValueAnalog( ICPDAS_USBIO* pInstance, float* o_fAOCurValue )	
    def AO_ReadCurValueAnalog(self, fArr ):
        return lib.AO_ReadCurValueAnalog(self.obj,fArr )
    
    # AO_GetPowerOnEnable( ICPDAS_USBIO* pInstance, BYTE* o_byPowerOnEnable )	
    def AO_GetPowerOnEnable(self, byteArr):
        return lib.AO_GetPowerOnEnable(self.obj,byteArr )
    
    # AO_GetSafetyEnable( ICPDAS_USBIO* pInstance, BYTE* o_bySafetyEnable )	
    def AO_GetSafetyEnable(self, byteArr):
        return lib.AO_GetSafetyEnable(self.obj, byteArr)
    
    # AO_GetPowerOnValueDigital(ICPDAS_USBIO* pInstance, DWORD* o_dwPwrOnValue)	
    def AO_GetPowerOnValueDigital(self, dwArr):
        return lib.AO_GetPowerOnValueDigital(self.obj,dwArr)
        
    # AO_GetPowerOnValueAnalog(ICPDAS_USBIO* pInstance, float* o_fPwrOnValue)	
    def AO_GetPowerOnValueAnalog(self, fArr ):
        return lib.AO_GetPowerOnValueAnalog(self.obj,fArr )
    
    # AO_GetSafetyValueDigital(ICPDAS_USBIO* pInstance, DWORD* o_dwSafetyValue)	
    def AO_GetSafetyValueDigital(self, dwArr ):
        return lib.AO_GetSafetyValueDigital(self.obj,dwArr)
        
    # AO_GetSafetyValueAnalog(ICPDAS_USBIO* pInstance, float* o_fSafetyValue)	
    def AO_GetSafetyValueAnalog(self, fArr ):
        return lib.AO_GetSafetyValueAnalog(self.obj,fArr)
    
    # AO_GetSlewRate(ICPDAS_USBIO* pInstance, BYTE* o_bySlewRate)	
    def AO_GetSlewRate(self, byteArr):
        return lib.AO_GetSlewRate(self.obj,	byteArr)
    
    # AO_SetTypeCode( ICPDAS_USBIO* pInstance, BYTE i_byChToSet, BYTE i_byTypeCode )	
    def AO_SetTypeCode(self, bCh , bVal  ):
        return lib.AO_SetTypeCode(self.obj,bCh , bVal  )
    
    # AO_SetTypeCodes( ICPDAS_USBIO* pInstance, BYTE* i_byTypeCodes )	
    def AO_SetTypeCodes(self, byteArr):
        return lib.AO_SetTypeCodes(self.obj,byteArr )
    
    # AO_SetChEnable( ICPDAS_USBIO* pInstance, BYTE* i_byChEnable )	
    def AO_SetChEnable(self, byteArr):
        return lib.AO_SetChEnable(self.obj, byteArr)
    
    # AO_WriteChannelValueDigital( ICPDAS_USBIO* pInstance, BYTE i_byChToSet, DWORD i_dwAOVal )	
    def AO_WriteChannelValueDigital(self, bCh , dwVal  ):
        return lib.AO_WriteChannelValueDigital(self.obj,bCh , dwVal)
    
    # AO_WriteValueDigital( ICPDAS_USBIO* pInstance, DWORD* i_dwAOValue )	
    def AO_WriteValueDigital(self, dwArr ):
        return lib.AO_WriteValueDigital(self.obj, dwArr )
    
    # AO_WriteChannelValueAnalog( ICPDAS_USBIO* pInstance, BYTE i_byChToSet, float i_fAOExpValue )									
    def AO_WriteChannelValueAnalog(self, bCh , fVal):
        return lib.AO_WriteChannelValueAnalog(self.obj, bCh , fVal )
    	
    # AO_WriteValueAnalog( ICPDAS_USBIO* pInstance, float* i_fAOExpValue )
    def AO_WriteValueAnalog(self, fArr ):
        return lib.AO_WriteValueAnalog(self.obj,fArr )
    
    # AO_SetPowerOnEnable( ICPDAS_USBIO* pInstance, BYTE* i_byPowerOnEnable )	
    def AO_SetPowerOnEnable(self, byteArr ):
        return lib.AO_SetPowerOnEnable(self.obj,byteArr )
    
    # AO_SetSafetyEnable( ICPDAS_USBIO* pInstance, BYTE* i_bySafetyEnable )	
    def AO_SetSafetyEnable(self, byteArr ):
        return lib.AO_SetSafetyEnable(self.obj,byteArr )
    
    # AO_SetPowerOnValueDigital(ICPDAS_USBIO* pInstance, DWORD* i_dwPwrOnValue)	
    def AO_SetPowerOnValueDigital(self, dwArr):
        return lib.AO_SetPowerOnValueDigital(self.obj,dwArr )
    
    # AO_SetPowerOnChannelValueDigital(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, DWORD i_dwPwrOnValue)	
    def AO_SetPowerOnChannelValueDigital(self, bCh , dwVal ):
        return lib.AO_SetPowerOnChannelValueDigital(self.obj,bCh , dwVal)
    	
    # AO_SetPowerOnValueAnalog(ICPDAS_USBIO* pInstance, float* i_fPwrOnValue)
    def AO_SetPowerOnValueAnalog(self, fArr ):
        return lib.AO_SetPowerOnValueAnalog(self.obj,fArr )
    
    # AO_SetPowerOnChannelValueAnalog(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, float i_fPwrOnValue)	
    def AO_SetPowerOnChannelValueAnalog(self, bCh , fVal ):
        return lib.AO_SetPowerOnChannelValueAnalog(self.obj,bCh , fVal)
    
    # AO_SetSafetyValueDigital(ICPDAS_USBIO* pInstance, DWORD* i_dwSafetyValue)	
    def AO_SetSafetyValueDigital(self, dwArr):
        return lib.AO_SetSafetyValueDigital(self.obj,dwArr)
    
    # AO_SetSafetyChannelValueDigital(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, DWORD i_dwSafetyValue)	
    def AO_SetSafetyChannelValueDigital(self, bCh , dwVal ):
        return lib.AO_SetSafetyChannelValueDigital(self.obj,bCh ,dwVal)
    
    # AO_SetSafetyValueAnalog(ICPDAS_USBIO* pInstance, float* i_fSafetyValue)	
    def AO_SetSafetyValueAnalog(self, fArr):
        return lib.AO_SetSafetyValueAnalog(self.obj,fArr)
    
    # AO_SetSafetyChannelValueAnalog(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, float i_fSafetyValue)	
    def AO_SetSafetyChannelValueAnalog(self, bCh , fVal ):
        return lib.AO_SetSafetyChannelValueAnalog(self.obj,bCh , fVal )
    	
    # AO_SetSlewRate(ICPDAS_USBIO* pInstance, BYTE* i_bySlewRate)
    def AO_SetSlewRate(self, byteArr ):
        return lib.AO_SetSlewRate(self.obj,byteArr )
   
    # PI_GetTotalSupportType( ICPDAS_USBIO* pInstance, BYTE* o_byTotalSupportType ) 	
    def PI_GetTotalSupportType(self, byteArr ):
        return lib.PI_GetTotalSupportType(self.obj, byteArr)
    
    # PI_GetSupportTypeCode( ICPDAS_USBIO* pInstance, BYTE* o_bySupportTypeCode )	
    def PI_GetSupportTypeCode(self, byteArr ):
        return lib.PI_GetSupportTypeCode(self.obj,byteArr )
    
    # PI_GetTypeCode(ICPDAS_USBIO* pInstance, BYTE* o_byTypeCode)	
    def PI_GetTypeCode(self, byteArr):
        return lib.PI_GetTypeCode(self.obj,byteArr)
    	
    # PI_GetTriggerMode(ICPDAS_USBIO* pInstance, BYTE* o_byTriggerMode)
    def PI_GetTriggerMode(self, byteArr):
        return lib.PI_GetTriggerMode(self.obj,byteArr)
        
    # PI_GetChIsolatedFlag(ICPDAS_USBIO* pInstance, BYTE* o_byChIsolatedFlag)	
    def PI_GetChIsolatedFlag(self, byteArr ):
        return lib.PI_GetChIsolatedFlag(self.obj,byteArr )
    
    # PI_GetLPFilterEnable(ICPDAS_USBIO* pInstance, BYTE* o_byLPFilterEnable)	
    def PI_GetLPFilterEnable(self, byteArr):
        return lib.PI_GetLPFilterEnable(self.obj,byteArr)
    
    # PI_GetLPFilterWidth(ICPDAS_USBIO* pInstance, WORD* o_wLPFilterWidth)	
    def PI_GetLPFilterWidth(self, wPrt ):
        return lib.PI_GetLPFilterWidth(self.obj, wPrt)
    
    # PI_ReadValue(ICPDAS_USBIO* pInstance, DWORD* o_dwCntValue, BYTE* o_byChStatus)	
    def PI_ReadValue(self, dwArr , byteArr):
        return lib.PI_ReadValue(self.obj,dwArr, byteArr)
    
    # PI_ReadCntValue(ICPDAS_USBIO* pInstance, DWORD* o_dwCntValue, BYTE* o_byChStatus)	
    def PI_ReadCntValue(self, dwArr , byteArr ):
        return lib.PI_ReadCntValue(self.obj, dwArr , byteArr )
        
    # PI_ReadFreqValue(ICPDAS_USBIO* pInstance, float* o_fFreqValue, BYTE* o_byChStatus)	
    def PI_ReadFreqValue(self, fArr , byteArr):
        return lib.PI_ReadFreqValue(self.obj,fArr ,byteArr)	
    
    # PI_SetTypeCode(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, BYTE i_byTypeCode)	
    def PI_SetTypeCode(self, bCh , bVal ):
        return lib.PI_SetTypeCode(self.obj, bCh , bVal )
    
    # PI_SetTypeCodes(ICPDAS_USBIO* pInstance, BYTE* i_byTypeCodes)	
    def PI_SetTypeCodes(self, byteArr ):
        return lib.PI_SetTypeCodes(self.obj,byteArr )
    
    # PI_ClearSingleChCount(ICPDAS_USBIO* pInstance, BYTE i_byChToClr)	
    def PI_ClearSingleChCount(self, bCh ):
        return lib.PI_ClearSingleChCount(self.obj,bCh )
    
    # PI_ClearChCount(ICPDAS_USBIO* pInstance, BYTE* i_byClrMask)	
    def PI_ClearChCount(self, byteArr ):
        return lib.PI_ClearChCount(self.obj, byteArr )
    
    # PI_ClearSingleChStatus(ICPDAS_USBIO* pInstance, BYTE i_byChToClr)	
    def PI_ClearSingleChStatus(self, bCh ):
        return lib.PI_ClearSingleChStatus(self.obj,bCh )
    
    # PI_ClearChStatus(ICPDAS_USBIO* pInstance, BYTE* i_byClrMask)	
    def PI_ClearChStatus(self, byteArr ):
        return lib.PI_ClearChStatus(self.obj,byteArr )	
    
    # PI_SetTriggerMode(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, BYTE i_byTriggerMode)	
    def PI_SetTriggerMode(self, bCh , bVal ):
        return lib.PI_SetTriggerMode(self.obj,bCh , bVal )
    
    # PI_SetTriggerModes(ICPDAS_USBIO* pInstance, BYTE* i_byTriggerModes)	
    def PI_SetTriggerModes(self, byteArr):
        return lib.PI_SetTriggerModes(self.obj, byteArr)
    
    # PI_SetChIsolatedFlag(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, BOOL i_bChIsolatedFlag)	
    def PI_SetChIsolatedFlag(self, bCh , bFlag ):
        return lib.PI_SetChIsolatedFlag(self.obj, bCh , bFlag )
    	
    # PI_SetChIsolatedFlags(ICPDAS_USBIO* pInstance, BYTE* i_byChIsolatedFlag)
    def PI_SetChIsolatedFlags(self, byteArr):
        return lib.PI_SetChIsolatedFlags(self.obj, byteArr)
   
    # PI_SetLPFilterEnable(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, BOOL i_bLPFilterEnable) 	
    def PI_SetLPFilterEnable(self, bCh , bFlag):
        return lib.PI_SetLPFilterEnable(self.obj,bCh ,bFlag )
    
    # PI_SetLPFilterEnables(ICPDAS_USBIO* pInstance, BYTE* i_byLPFilterEnables)
    def PI_SetLPFilterEnables(self, byteArr):
        return lib.PI_SetLPFilterEnables(self.obj,byteArr)
    
    # PI_SetLPFilterWidth(ICPDAS_USBIO* pInstance, BYTE i_byChToSet, WORD i_wLPFilterWidth)	
    def PI_SetLPFilterWidth(self, bCh , wVal):
        return lib.PI_SetLPFilterWidth(self.obj, bCh , wVal)
    
    # PI_SetLPFilterWidths(ICPDAS_USBIO* pInstance, WORD* i_wLPFilterWidths)
    def PI_SetLPFilterWidths(self, wArr ):  
        return lib.PI_SetLPFilterWidths(self.obj,wArr )
    
    def __del__(self):       
        return lib.DisposeInstance(self.obj)