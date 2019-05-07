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


        //Boolean isValueBig = (x.Level.Name==null) ? false : true;
        public void Execute(object parameter)
        {

            if (GroupViewModel.Text != String.Empty)
            {

                var items = AllGroupsCopy.Where(x => (x.Name == null) ? true : x.Name.Contains(GroupViewModel.Text) || (x.Filial.Name == null) ? true : x.Filial.Name.Contains(GroupViewModel.Text)
                || (x.Level.Name == null) ? true : x.Level.Name.Contains(GroupViewModel.Text) || (x.Subject.Name == null) ? true : x.Subject.Name.Contains(GroupViewModel.Text) ||
                (x.Note == null) ? true : x.Note.Contains(GroupViewModel.Text)
                ).ToList();

                if (items.Count != 0)
                {

                    GroupViewModel.AllGroups = new ObservableCollection<Entities.Group>(items);
                }
            }
            else
            {
                GroupViewModel.AllGroups = AllGroupsCopy;
            }
        }
    }
}
