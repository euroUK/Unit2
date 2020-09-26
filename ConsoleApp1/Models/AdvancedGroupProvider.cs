using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Models
{
    public class AdvancedGroupProvider : IGroupProvider
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
        public int GetGroupCount()
        {
            return counter;
        }

        public AdvancedGroupProvider()
        {
            groups = new List<Group>();
        }
    }
}
