#include <jni.h>
#include <iostream>
#include "HelloWorldJNI.h"

JNIEXPORT void JNICALL Java_HelloWorldJNI_sayHello(JNIEnv* env, jobject thisObject, jstring greetings) {
  const char *greetingsInC = env->GetStringUTFChars(greetings, 0);
  printf("%s", greetingsInC);
}
