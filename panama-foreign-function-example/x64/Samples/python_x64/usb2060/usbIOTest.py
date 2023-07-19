from ICPDAS_USBIO import USBIO

from ctypes import * 

usb = USBIO()

usb2055 = c_int(1088)
boardID = c_char(1)
iRet = c_int(0)

usb.CloseDevice()
iRet = usb.OpenDevice(usb2055, boardID)
print("OpenDevice ret = ",iRet  )

doArr = (c_char * 8)()
doArr[0]=0x3f
doArr[1]=0
doArr[2]=0
doArr[3]=0
doArr[4]=0
doArr[5]=0
doArr[6]=0
doArr[7]=0

usb.DO_WriteValue(doArr)

doReadArr  = (c_char * 8)()

usb.DO_ReadValue(doReadArr)

print("doReadArr[0] = ", doReadArr[0])
print("doReadArr[1] = ", doReadArr[1])

print("doReadArr[2] = ", doReadArr[2])
print("doReadArr[3] = ", doReadArr[3])

print("doReadArr[4] = ", doReadArr[4])
print("doReadArr[5] = ", doReadArr[5])

print("doReadArr[6] = ", doReadArr[6])
print("doReadArr[7] = ", doReadArr[7])

diReadArr  = (c_char * 8)()

usb.DI_ReadValue(diReadArr)

print("diReadArr[0] = ", diReadArr[0])
print("diReadArr[1] = ", diReadArr[1])

print("diReadArr[2] = ", diReadArr[2])
print("diReadArr[3] = ", diReadArr[3])

print("diReadArr[4] = ", diReadArr[4])
print("diReadArr[5] = ", diReadArr[5])

print("diReadArr[6] = ", diReadArr[6])
print("diReadArr[7] = ", diReadArr[7])


diCntArr = (c_ulong *6)()
usb.DI_ReadCounterValue(diCntArr)

print("diCntArr[0] = ", diCntArr[0])
print("diCntArr[1] = ", diCntArr[1])

print("diCntArr[2] = ", diCntArr[2])
print("diCntArr[3] = ", diCntArr[3])

print("diCntArr[4] = ", diCntArr[4])
print("diCntArr[5] = ", diCntArr[5])

usb.CloseDevice()
