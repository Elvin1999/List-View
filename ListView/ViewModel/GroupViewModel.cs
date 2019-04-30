using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListView.ViewModel
{
    class GroupViewModel : BaseViewModel
    {

        public Group CurrentGroup { get; set; }
        private List<Group> allgroups;
        public List<Group> AllGroups
        {
            get
            {
                return allgroups;
            }
            set
            {
                allgroups = value;
                OnPropertyChanged(new PropertyChangedEventArgs("AllGroups"))
            }
        }

    }


}
