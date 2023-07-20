public class HelloWorldJNI {

    static {
        System.out.println("Load native library...");
        System.load(System.getProperty("user.dir") + "/libnative.so");
    }

    public static void main(String[] args) {
        System.out.println("Call native library...");
        String greeting = "LET'S USE JNI TO CALL NATIVE PRINT!!";
        var helloWorld = new HelloWorldJNI();
        helloWorld.sayHello(greeting);
    }

    // Declare a native method sayHello() that receives no arguments and returns void
    private native void sayHello(String path);
}