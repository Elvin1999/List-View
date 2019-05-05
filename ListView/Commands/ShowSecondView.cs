using ListView.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            /*      public int Id { get; set; }
        public string Name { get; set; }
        public Subject Subject { get; set; }
        public int Level { get; set; }
        public Filial Filial { get; set;}
        public string Note { get; set; }*/

            GroupViewModel groupViewModel = new GroupViewModel();
        

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
            groupViewModel.Levels = new List<Entities.Level>()
            {
                new Entities.Level()
                {
                    Id=5,Name="Beginner"
                },
                new Entities.Level()
                {
                    Id=6,Name="Elementary"
                },
                new Entities.Level()
                {
                    Id=7,Name="Pre-Intermediate"
                }
            };
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
            groupViewModel.AllGroups = new ObservableCollection<Entities.Group>()
            {
                new Entities.Group()
                {
                    Id=1,Name="Elvin", Subject=new Entities.Subject(){
                        Id=6,Name=groupViewModel.Subjects[0].Name
                    },
                    Level=new Entities.Level()
                    {
                        Id=1,Name=groupViewModel.Levels[0].Name
                    }
                    ,Filial=new Entities.Filial(){

                        Id=5,Name=groupViewModel.Filials[0].Name
                    },Note="Everything is okay ."


                },
                new Entities.Group()
                {
                    Id=1,Name="Namiq", Subject=new Entities.Subject(){
                        Id=6,Name=groupViewModel.Subjects[1].Name
                    },
                    Level=new Entities.Level()
                    {
                        Id=1,Name=groupViewModel.Levels[1].Name
                    }
                    ,Filial=new Entities.Filial(){

                        Id=5,Name=groupViewModel.Filials[1].Name
                    },Note="Everything is okay ."


                }
            };
            groupViewModel.CurrentGroup = new Entities.Group();
            MainWindow secWindow = new MainWindow(groupViewModel);
            secWindow.ShowDialog();

        }
    }
}
