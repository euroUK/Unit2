using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Student
    {
        IGroupProvider provider;
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime Birthday { get; set; }
        public Group Group { get; protected set; }
        public Student(string lastName, string firstName, IGroupProvider provider)
        {
            LastName = lastName;
            FirstName = firstName;
            this.provider = provider;
        }
        public void SetGroup(string groupName)
        {
            Group = provider.GetOrAddGroup(groupName);
        }
        public Student(IGroupProvider provider)
        {
            this.provider = provider;
        }
    }
}
