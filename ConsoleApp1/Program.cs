using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) 
        {
            SimpleGroupProvider simpleGroupProvider = new SimpleGroupProvider();
            AdvancedGroupProvider advancedGroupProvider = new AdvancedGroupProvider();

            Student student = new Student("Smith", "John", advancedGroupProvider);
            student.SetGroup("Test");
            
            Student student1 = new Student(advancedGroupProvider)
            {
                LastName = "Smith",
                FirstName = "John",
            };
            student1.SetGroup("Test2");

            Console.WriteLine("Total groups count: {0}", advancedGroupProvider.GetGroupCount());
        }
    }
}
