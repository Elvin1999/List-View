using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView.Entities
{
   public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public Level Level { get; set; }
        public Filial Filial { get; set;}
        public string Note { get; set; }
        public Group Clone()
        {
            Group newgroup = new Group();
            newgroup.Filial = this.Filial;
            newgroup.Id = this.Id;
            newgroup.Level = this.Level;
            newgroup.Name = this.Name;
            newgroup.Note = this.Note;
            newgroup.Subject = this.Subject;
            return newgroup;
        }
    }
}
