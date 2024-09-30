using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        SingletonClass singleton1=SingletonClass.makeInstance();
        SingletonClass singleton2=SingletonClass.makeInstance();

        if (singleton1 == singleton2)
            Console.WriteLine("Both objects are same");
    }
}