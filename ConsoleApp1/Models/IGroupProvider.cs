using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public interface IGroupProvider
    {
        Group GetOrAddGroup(string groupName);
    }
}
