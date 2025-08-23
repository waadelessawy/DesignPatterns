using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Solid
{
    // Problem


    //public interface IMachine
    //{
    //    void Print();
    //    void Scan();
    //    void Fax();
    //}

    //public class OldPrinter : IMachine
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine("Printing...");
    //    }

    //    public void Scan()
    //    {
    //        // مش مدعوم
    //        throw new NotImplementedException();
    //    }

    //    public void Fax()
    //    {
    //        // مش مدعوم
    //        throw new NotImplementedException();
    //    }
    //}

    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();
    }

    public interface IFax
    {
        void Fax();
    }

    public class OldPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }
    }

    public class ModernPrinter : IPrinter, IScanner, IFax
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning...");
        }

        public void Fax()
        {
            Console.WriteLine("Faxing...");
        }
    }


}
