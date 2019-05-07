using ListView.Commands;
using ListView.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace ListView.ViewModel
{
    public class GroupViewModel : BaseViewModel
    {
        public Add AddNewItem => new Add(this);
        public Delete DeleteSelectedItem => new Delete(this);
        public Update UpdateSelectedItem => new Update(this);
        public SearchCommand SearchCommand => new SearchCommand(this);
        public ExportExcelCommand ExportExcelCommand => new ExportExcelCommand();
        public ExportPdfCommand ExportPdfCommand => new ExportPdfCommand();
        private ObservableCollection<Entities.Group> allgroups;
        private string text;

        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Text)));
            }
        }

        public ObservableCollection<Entities.Group> AllGroups
        {
            get
            {
                return allgroups;
            }
            set
            {
                allgroups = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(AllGroups)));
            }
        }

        private Entities.Group currentGroup;
        public Entities.Group CurrentGroup
        {
            get
            {
                return currentGroup;
            }
            set
            {
                currentGroup = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentGroup)));
            }
        }

        private Entities.Group selectedGroup;
        public Entities.Group SelectedGroup
        {
            get
            {
                return selectedGroup;
            }
            set
            {
                selectedGroup = value;
                if (value != null)
                {
                    CurrentGroup = SelectedGroup.Clone();
                }
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedGroup)));
            }
        }
        public List<Filial> Filials { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Level> Levels { get; set; }

    }


}
