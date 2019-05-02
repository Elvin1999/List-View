﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using ListView.ViewModel;
using ListView.Entities;

namespace ListView.Commands
{
   public class Add : ICommand
    {
        public GroupViewModel GroupViewModel { get; set; }
        public Add(GroupViewModel viewModel)
        {
            GroupViewModel = viewModel;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            var item = GroupViewModel.AllGroups.FirstOrDefault(x => x.Id == GroupViewModel.CurrentGroup.Id);

            if (item==null)
            {
                GroupViewModel.AllGroups.Add(GroupViewModel.CurrentGroup);
                MessageBoxResult add = MessageBox.Show("added");
            }
            else
            {
                var index = GroupViewModel.AllGroups.IndexOf(item);
                GroupViewModel.AllGroups[index] = GroupViewModel.CurrentGroup;
                MessageBoxResult add = MessageBox.Show("updated");
            }
            GroupViewModel.CurrentGroup = null;

        }
    }
}
