using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class SimpleGroupProvider : IGroupProvider
    {
        int counter = 0;
        List<Group> groups;
        public Group GetOrAddGroup(string groupName)
        {
            if (groups.Exists(group => group.Name == groupName))
            {
                return groups.First(x => x.Name == groupName);
            }
            else
            {
                Group group = new Group()
                {
                    Name = groupName,
                    Id = ++counter
                };
                groups.Add(group);
                return group;
            }
        }

        public SimpleGroupProvider()
        {
            groups = new List<Group>();
        }
    }
}
