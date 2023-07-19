package org.example;

import java.lang.foreign.*;
import static foreign.c.stdio_h.printf;

public class HelloWorldJextract {

  public static void main(String[] args) {
    String greeting = "LET'S USE PANAMA JEXTRACT TO CALL NATIVE PRINT!!";
    try (Arena memorySession = Arena.openConfined()) {
      MemorySegment greetingSegment = memorySession.allocateUtf8String(greeting);
      printf(greetingSegment);
    }
  }
}