# JNI
Run native java functions on Windows.

## Prerequisites
- install gcc
- install java

## Steps
- compile and generate C header file `javac -h . HelloWorldJNI.java`
- generate object file: `g++ -c -fPIC -I${JAVA_HOME}/include -I${JAVA_HOME}/include/linux HelloWorldJNI.cpp -o HelloWorldJNI.o`
- generate shared library: `g++ -shared -fPIC -o libnative.so HelloWorldJNI.o -lc`
- run library `java -cp . -Djava.library.path=/home/sbader/repos/when-java-goes-native/jni-example/libnative.so HelloWorldJNI`

## Links
- https://www.baeldung.com/jni