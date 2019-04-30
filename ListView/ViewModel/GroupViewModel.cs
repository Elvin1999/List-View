using ListView.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListView.ViewModel
{
   public class GroupViewModel : BaseViewModel
    {

        public Entities.Group CurrentGroup { get; set; }
        private List<Entities.Group> allgroups;
        
        public List<Entities.Group> AllGroups
        {
            get
            {
                return allgroups;
            }
            set
            {
                allgroups = value;
                OnPropertyChanged(new PropertyChangedEventArgs("AllGroups"));
            }
        }
        public List<Filial> Filials { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<int> Levels { get; set; }

    }


}
