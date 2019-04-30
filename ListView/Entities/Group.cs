using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView.Entities
{
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public int Level { get; set; }
        public Filial Filial { get; set;}
        public string Note { get; set; }
    }
}
