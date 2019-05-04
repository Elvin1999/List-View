using ListView.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ListView.Commands
{
   public class Update : ICommand
    {
        public GroupViewModel GroupViewModel { get; set; }
        public Update(GroupViewModel GroupViewModel)
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
            var item = GroupViewModel.AllGroups.FirstOrDefault(x => x.Id == GroupViewModel.CurrentGroup.Id);

            if (item != null)
            {
                var index = GroupViewModel.AllGroups.IndexOf(item);
                GroupViewModel.AllGroups[index] = GroupViewModel.CurrentGroup;
                MessageBoxResult update = MessageBox.Show("updated");
            }          
            GroupViewModel.CurrentGroup = null;
        }
    }
}
