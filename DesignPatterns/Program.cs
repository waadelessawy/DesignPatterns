using DesignPatterns.BehavioralPatterns;
using DesignPatterns.CreationalPatterns;
using DesignPatterns.StructuralPatterns;
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
        //IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        //ComputerDirector director = new ComputerDirector(gamingBuilder);
        //director.BuildComputer();
        //Computer gamingComputer = director.GetComputer();
        //Console.WriteLine("Gaming Computer:");
        //Console.WriteLine(gamingComputer);

        //// Build an office computer
        //IComputerBuilder officeBuilder = new OfficeComputerBuilder();
        //director = new ComputerDirector(officeBuilder);
        //director.BuildComputer();
        //Computer officeComputer = director.GetComputer();
        //Console.WriteLine("\nOffice Computer:");
        //Console.WriteLine(officeComputer);

        //5- Adapter

        //Old UI
        //IMultiRestoApp multiRestoApp = new MultiRestoApp();
        //multiRestoApp.displayMenus(new XmlData());

        ////New UI
        //FancyUIServiceAdapter adapter = new FancyUIServiceAdapter();
        //adapter.displayMenus(new XmlData());


        //6- Decorator 
        //INotifier notifier = new FacebookDecorator(new WhatsAppDecorator(
        //    new Notifier("Geekific")));

        //notifier.Send("Like and subscribe");

        //7- Facade
        //BuyCryprtoFacade buyCrypto = new BuyCryprtoFacade();
        //buyCrypto.BuyCryptoCurrency(1000, "BTC");

        //8- Proxy
        //**Old Code

        //IInternet internet = new RealInternet();
        //internet.ConnectTo("google.com");


        //The solution
        //IInternet internet = new ProxyInternet();
        //internet.ConnectTo("google.com");
        //internet.ConnectTo("banned.com");

        //IInternet i = new RealInternet();
        //i.ConnectTo("banned.com");

        //example 2
        //Old
        //VideoDownloader videoDownloader = new RealVideoDownloader();

        //VideoDownloader videoDownloader = new proxyVideoDownloader();

        //videoDownloader.GetVideo("Video 1");
        //videoDownloader.GetVideo("Video 1");
        //videoDownloader.GetVideo("Video 3");
        //videoDownloader.GetVideo("Video 3");
        //videoDownloader.GetVideo("Video 5");
        //videoDownloader.GetVideo("Video 5");
        //videoDownloader.GetVideo("Video 7");


        //9- Observer

        //Store store = new Store();
        //store.GetService().Subscribe(new EmailMsgListener("g@gmail.com"));
        //store.GetService().Subscribe(new EmailMsgListener("g@gmail.com"));
        //store.GetService().Subscribe(new MobileMsgListener("g@gmail.com"));


        //store.newItemPromotion();

        //10- Strategy

        PaymentContext context = new PaymentContext();

        CreditCard card = new CreditCard("11111", "12/12", "123");
        context.SetPaymentStrategy(new PaymentByCreditCard(card));
        context.PayAmount(30);

        context.SetPaymentStrategy(new PaymentByPayPal("test@email.com", "mypassword"));
        context.PayAmount(200);


    }
}
