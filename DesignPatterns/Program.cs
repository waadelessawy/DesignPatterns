using DesignPatterns.CreationalPatterns;
using System;

class Program
{
    static void Main(string[] args)
    {
        //1- Singleton 
        //Singleton s1 = Singleton.GetInstance();
        //Singleton s2 = Singleton.GetInstance();

        //if (s1 == s2)
        //{
        //    Console.WriteLine("Singleton works, both variables contain the same instance.");
        //}
        //else
        //{
        //    Console.WriteLine("Singleton failed, variables contain different instances.");
        //}

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //Singleton thread safe

        //Console.WriteLine(
        //        "{0}\n{1}\n\n{2}\n",
        //        "If you see the same value, then singleton was reused (yay!)",
        //        "If you see different values, then 2 singletons were created (booo!!)",
        //        "RESULT:"
        //    );

        //Thread p1 = new Thread(() =>
        //{
        //    TestSingleton("FOO");
        //});
        //Thread p2 = new Thread(() =>
        //{
        //    TestSingleton("BAR");
        //});

        //p1.Start();
        //p2.Start();

        //p1.Join(); 
        //p2.Join();


        //static void TestSingleton(string value)
        //{
        //    SingletonThreadSafe singleton = SingletonThreadSafe.GetInstance(value);
        //    Console.WriteLine(singleton.Value);
        //}

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        //3- Factory Method

        //NotificationCreator emailCreator = new EmailNotificatonCreator();
        //emailCreator.Notify("Email message content");


        //NotificationCreator smsCreator = new SmsNotificationCreator();
        //smsCreator.Notify("SMS message content.");

        //NotificationCreator pushCreator = new PushNotificationCreator();
        //pushCreator.Notify("Push message content.");

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        //4- Abstract Factory

        //Company msi = new MsiManufacturer();
        //Gpu msiGpu = msi.CreateGpu();
        //DesignPatterns.Monitor msiMonitor = msi.CreateMonitor();

        //msiGpu.assemble();
        //msiMonitor.assemble();

        //Company asus = new AsusManufacturer();
        //Gpu asusGpu = asus.CreateGpu();
        //DesignPatterns.Monitor asusMonitor = asus.CreateMonitor();

        //asusGpu.assemble();
        //asusMonitor.assemble();


        ///Why we use abstract not interface ?:
        //Shared logic → An abstract class allows us to put common code (e.g., RenderUI) once and reuse it across all factories.
        //Default implementations → Abstract classes can provide base behavior for some methods, while interfaces only define contracts.
        //Extensibility → If we need to add new functionality later, it’s easier with an abstract class since we don’t break all existing factories.

        //GUIFactory factory = new WinFactory();
        //factory.RenderUI();

        //factory = new MacFactory();
        //factory.RenderUI();


        //4- Builder

        // Build a gaming computer
        IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        ComputerDirector director = new ComputerDirector(gamingBuilder);
        director.BuildComputer();
        Computer gamingComputer = director.GetComputer();
        Console.WriteLine("Gaming Computer:");
        Console.WriteLine(gamingComputer);

        // Build an office computer
        IComputerBuilder officeBuilder = new OfficeComputerBuilder();
        director = new ComputerDirector(officeBuilder);
        director.BuildComputer();
        Computer officeComputer = director.GetComputer();
        Console.WriteLine("\nOffice Computer:");
        Console.WriteLine(officeComputer);
    }
}
