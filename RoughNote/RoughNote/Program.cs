using System;
using System.Transactions;

namespace RoughNote
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass obj = SingletonClass.GetSingletonObject(); 

            obj.EmployeeID = 11105;
            obj.EmployeeName = "Srini";
            obj.EmployeeSalary = 5000000;

            obj.EmployeeID = 1;

            Console.WriteLine(obj.EmployeeID);
            Console.ReadLine();
        }
    }
}
