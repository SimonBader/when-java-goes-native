package org.example;

import com.sun.jna.Library;
import com.sun.jna.Native;

public class HelloWorldJna {

    public interface CLibrary extends Library {
        CLibrary INSTANCE = (CLibrary)
            Native.load("c", CLibrary.class);

        void printf(String format, Object... args);
    }

    public static void main(String[] args) {
        String greeting = "LET'S USE JNA TO CALL NATIVE PRINT!!";
        CLibrary.INSTANCE.printf(greeting);
    }
}