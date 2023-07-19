package org.example;

import static java.lang.foreign.ValueLayout.ADDRESS;
import static java.lang.foreign.ValueLayout.JAVA_INT;

import java.lang.foreign.Arena;
import java.lang.foreign.FunctionDescriptor;
import java.lang.foreign.Linker;
import java.lang.foreign.SymbolLookup;
import java.lang.invoke.MethodHandle;

public class HelloWorldForeignFunction {
    public static void main(String[] args) throws Throwable {
      String symbolName = "printf";
      String greeting = "LET'S USE PANAMA FOREIGN FUNCTION TO CALL NATIVE PRINT!!";
      Linker nativeLinker = Linker.nativeLinker();
      SymbolLookup stdlibLookup = nativeLinker.defaultLookup();
      SymbolLookup loaderLookup = SymbolLookup.loaderLookup();
      FunctionDescriptor printfDescriptor = FunctionDescriptor.of(JAVA_INT, ADDRESS);
      MethodHandle methodHandle = loaderLookup.find(symbolName)
          .or(() -> stdlibLookup.find(symbolName))
          .map(symbolSegment -> nativeLinker.downcallHandle(symbolSegment, printfDescriptor))
          .orElse(null);
      try (Arena memorySession = Arena.openConfined()) {
        var greetingSegment = memorySession.allocateUtf8String(greeting);
        methodHandle.invoke(greetingSegment);
      }
  }
}
