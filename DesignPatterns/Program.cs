using DesignPatterns;
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


        GUIFactory factory = new WinFactory();
        factory.RenderUI();

        factory = new MacFactory();
        factory.RenderUI();


    }
}
