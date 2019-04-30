using ListView.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ListView.Commands
{
    class ShowSecondView : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            GroupViewModel groupViewModel = new GroupViewModel();
            groupViewModel.AllGroups = new List<Entities.Group>();

            groupViewModel.Filials = new List<Entities.Filial>()
            {
                new Entities.Filial()
                {
                    Id=1,Name="Baku"
                },
                new Entities.Filial()
                {
                    Id=2,Name="Sumqayit"
                },
                new Entities.Filial(){
                    Id=3,Name="Khirdalan"
                }
            };
            groupViewModel.Levels = new List<int> { 1, 2, 3 };
            groupViewModel.Subjects = new List<Entities.Subject>() {

                new Entities.Subject()
                {
                    Id=1,
                    Name="IT"
                },
                new Entities.Subject()
                {
                    Id=2,
                    Name="Programming"
                },
                new Entities.Subject(){

                    Id=3,
                    Name="Design"
                }
            };
            MainWindow secWindow = new MainWindow(groupViewModel);
            secWindow.ShowDialog();

        }
    }
}
