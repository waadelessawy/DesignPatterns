using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //Creational design pattern
    public sealed class Singleton
    {
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        
    }


    //Thread-safe Singleton

    public sealed class SingletonThreadSafe
    {
        private SingletonThreadSafe() { }

        private static SingletonThreadSafe _instance;

        //will be used to synchronnize threads
        private static readonly object _lock = new object();

        public static SingletonThreadSafe GetInstance(string value)
        {
            if(_instance == null)
            {
                lock (_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonThreadSafe();
                        _instance.Value = value;

                    }
                }
            }
            return _instance;
        }

        // We'll use this property to prove that our Singleton really works.
        public string Value { get; set; }
    }


}
