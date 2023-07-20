# Findings (work in progress)

## 01 JNI - Java Native Interface
- generates a native C header file which has to be included in the C/C++ sources
- uses a Java-specfic C/C++ type system library `jni.h` (like `JNIEnv`, `jobject`, `jstring`) to map Java types to C types
- the Java-specfic type system library covers the memory allocation for native types (marshaling/unmarshaling) // TODO: TO BE VERIFIED

## 02 Panama - Foreign Functions (in-preview)
- for non-Java APIs (including C)
- native code wrapper fully written in Java (does not require any C/C++ code)
- the caller has to deal with memory allocation for native types (`Area`, `Segment`)
- communicates over the stable C ABI (Application Binary Interface)
- therefore does not support C++ classes (as the C++ ABI is different for every compiler and environment)

## 03 Panama - jextract (in-preview)
- tool to generate a jar library encapsulating all Java code from the Panama Foreign Functions
- own package which has to be downloaded separately

## 04 JNA - Java Native Access
- pretty old and widely used open-source library
- native code wrapper fully written in Java (does not require any C/C++ code)
- the JNA library wraps the memory allocation part 
- can deal with C++ classes
- based on [libffi](https://github.com/atgreen/libffi)
- does use JNI under the hood
- uses one generic C method `native/dispatch.c` to pass all types (using reflection)

# Links
JNI
- https://www.baeldung.com/jni
- https://medium.com/nerd-for-tech/guide-to-jni-java-native-interface-5b63fea01828

Panama Foreign Functions
- https://openjdk.org/projects/panama/
- https://www.baeldung.com/java-project-panama
- https://denismakogon.github.io/openjdk/panama/2022/05/31/introduction-to-project-panama-part-1.html

Panama jextract
- https://github.com/openjdk/jextract

JNA
- https://github.com/java-native-access/jna
- https://github.com/java-native-access/jna/blob/master/www/FunctionalDescription.md