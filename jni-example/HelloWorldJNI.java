public class HelloWorldJNI {

    static {
        System.out.println("Load native library...");
        System.load(System.getProperty("user.dir") + "/libnative.so");
    }

    public static void main(String[] args) {
        System.out.println("Call native library...");
        var helloWorld = new HelloWorldJNI();
        helloWorld.sayHello();
    }

    // Declare a native method sayHello() that receives no arguments and returns void
    private native void sayHello();
}