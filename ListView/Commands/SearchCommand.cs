using ListView.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;


namespace ListView.Commands
{
   public class SearchCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public GroupViewModel GroupViewModel { get; set; }
        public ObservableCollection<Entities.Group> AllGroupsCopy { get; set; }
        public SearchCommand(GroupViewModel GroupViewModel)
        {
            this.GroupViewModel = GroupViewModel;
            AllGroupsCopy = GroupViewModel.AllGroups;
        }     

        public bool CanExecute(object parameter)
        {
            return true;
        }
      


        public void Execute(object parameter)
        {
           
            if (GroupViewModel.Text != String.Empty)
            {

                var items = AllGroupsCopy.Where(x => x.Name.Contains(GroupViewModel.Text)
                ).ToList();


                if (items.Count != 0)
                {

                    GroupViewModel.AllGroups = new ObservableCollection<Entities.Group>(items);
                    //foreach (var item in items)
                    //{
                    //    GroupViewModel.AllGroups.Add(item);
                    //}                    
                }
            
            }
            else
            {
                GroupViewModel.AllGroups = AllGroupsCopy;
            }
        }
    }
}
