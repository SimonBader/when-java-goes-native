# Research

## JNI - Java Native Interface
- built-into Java
- includes native C header file which has to be included in the C/C++ sources
- the caller has to deal with memory allocation for native types
- uses a Java-specfic C/C++ type system to map Java types to C types
- marshaling/unmarshaling data between Java and C++

## JNA - Java Native Access
- widely used open-source library 
- native code wrapper fully written in Java (does not require any C / C++ code)
- wraps the memory allocation part 
- can deal with C++ classes
- based on [libffi](https://github.com/atgreen/libffi)
- does use JNI under the hood
- uses one generic C method to pass all types via reflection

## Panama - Foreign Functions
- for non-Java APIs (including C)
- only supported in Java preview-mode (since Java 18)
- native code wrapper fully written in Java (does not require any C / C++ code)
- the caller has to deal with memory allocation for native types
- communicates over the stable C ABI (Application Binary Interface)
- therefore does not support C++ classes (as the C++ ABI is different for every compiler and environment)

## Panama - jextract
- tool to generating a jar library encapsulating all Java code from the Panama Foreign Functions
- own package which has to be downloaded separately
- only supported in Java preview-mode (since Java 18)

# Links
JNI
- 

Panama
- https://openjdk.org/projects/panama/
- https://www.baeldung.com/java-project-panama
- https://denismakogon.github.io/openjdk/panama/2022/05/31/introduction-to-project-panama-part-1.html

JNA
- https://github.com/java-native-access/jna