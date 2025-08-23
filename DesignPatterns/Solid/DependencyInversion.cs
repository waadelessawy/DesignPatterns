using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Solid
{
    //problem

    //public class FileLogger
    //{
    //    public void Log(string message)
    //    {
    //        Console.WriteLine("Log into file: " + message);
    //    }
    //}

    //public class UserService
    //{
    //    private FileLogger logger = new FileLogger(); // اعتماد مباشر على low-level

    //    public void AddUser(string name)
    //    {
    //        // logic
    //        logger.Log("User added: " + name);
    //    }
    //}

    //Solution

    public interface ILogger
    {
        void Log(string message);
    }

    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log into file: " + message);
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log into database: " + message);
        }
    }

    public class UserService
    {
        private readonly ILogger logger;

        public UserService(ILogger logger)
        {
            this.logger = logger;
        }

        public void AddUser(string name)
        {
            // logic
            logger.Log("User added: " + name);
        }
    }


}
