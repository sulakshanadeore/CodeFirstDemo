using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstDALDemo;
namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.StudentsTable.Add(new Student{Rollno=1,Studname="Amit",City="Pune",DOB=new DateTime(2022,11,11) });
            context.SaveChanges();
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
