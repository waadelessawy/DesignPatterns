using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Solid
{

    // A class should have only one responsibility and reasin to change

    //The problem
    //public class Invoice
    //{
    //    public void AddInvoice()
    //    {
    //        // your logic
    //    }

    //    public void DeleteInvoice()
    //    {
    //        // your logic
    //    }

    //    public void GenerateReport()
    //    {
    //        // your logic
    //    }

    //    public void EmailReport()
    //    {
    //        // your logic
    //    }
    //}
    //The solution

    public class Invoice
    {
        public void AddInvoice()
        {
            // your logic
        }

        public void DeleteInvoice()
        {
            // your logic
        }
    }

    public class Report
    {

        public void GenerateReport()
        {
            // your logic
        }
    }

    public class Email
    {
        public void EmailReport()
        {
            // your logic
        }
    }
}
