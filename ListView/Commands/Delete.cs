using ListView.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ListView.Commands
{
   public class Delete : ICommand
    {
        public GroupViewModel GroupViewModel { get; set; }
        public Delete(GroupViewModel GroupViewModel)
        {
            this.GroupViewModel = GroupViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var item = GroupViewModel.SelectedGroup;
            GroupViewModel.AllGroups.Remove(item);
            GroupViewModel.CurrentGroup = new Entities.Group();
          
        }
    }
}
