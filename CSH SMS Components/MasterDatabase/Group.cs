using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDatabase
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<GroupContact> Contacts { get; set; }
    }
}
