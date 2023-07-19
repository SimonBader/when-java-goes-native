#include <jni.h>
#include <iostream>
#include "HelloWorldJNI.h"

JNIEXPORT void JNICALL Java_HelloWorldJNI_sayHello(JNIEnv* env, jobject thisObject) {
  printf("LET'S USE JNI TO CALL NATIVE PRINT!!");
}
