# Panama Jextract

## Prerequisites
- Java >= 18
- enable Java preview

## Generate foreign library using jextract
- 
- 
- download and extract jextract from https://jdk.java.net/jextract/  
`mkdir extract`
`curl -O filename.txt https://download.java.net/java/early_access/jextract/1/openjdk-20-jextract+1-2_linux-x64_bin.tar.gz`  
`tar -xvf openjdk-20-jextract+1-2_linux-x64_bin.tar`  
`cd ..`
- generate stdio Java library
`./jextract/jextract-20/bin/jextract --enable-native-access=org.openjdk.jextract --source --output src/main/java -t foreign.c -I /usr/include/ /usr/include/stdio.h`

## Run
- run the HelloWorld sample:  
`mvn compile exec:java`

## Links
- https://www.baeldung.com/java-project-panama
- https://openjdk.org/projects/panama/
- https://github.com/openjdk/jextract