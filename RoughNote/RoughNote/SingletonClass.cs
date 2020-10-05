using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace RoughNote
{
    class SingletonClass
    {
        private static readonly SingletonClass singletonObject = new SingletonClass();

        private SingletonClass()
        {
            Console.WriteLine("Prevent Creating the instance in another class");
        }

        public string EmployeeName { get; set; }

        public int EmployeeID { get; set; }

        public int SetEmployeeID()
        {
            return EmployeeID = 11106;
        }
            
        public int EmployeeSalary { get; set; }

        public static SingletonClass GetSingletonObject()
        {
            return singletonObject;
        }

        // It Describes the Purpose of readonly, uncomment it and see the error.
        //public void Singleton()
        //{
        //    singletonObject = new SingletonClass();
        //}
    }
}
