using ListView.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GroupViewModel GroupVM { get; set; }
        public GroupViewModel GroupVMCopyData { get; set; }
        public GroupViewModel GroupVMFromSearch { get; set; }
        public ObservableCollection<Entities.Group> AllGroupsCopy { get; set; }

        public MainWindow(GroupViewModel GroupVM)
        {
            InitializeComponent();
            this.GroupVM = GroupVM;
            DataContext = GroupVM;
            AllGroupsCopy = GroupVM.AllGroups;
        }

        private void SearchTxtb_KeyUp(object sender, KeyEventArgs e)
        {

            var textBox = sender as TextBox;
            if (textBox.Text != String.Empty)
            {

                var items = GroupVM.AllGroups.Where(x => x.Name.Contains(textBox.Text)).ToList();


                if (items.Count != 0)
                {

                    GroupVM.AllGroups = new ObservableCollection<Entities.Group>();
                    foreach (var item in items)
                    {
                        MessageBoxResult messageBoxResult = MessageBox.Show(item.Name);
                        GroupVM.AllGroups.Add(item);
                    }

                    DataContext = GroupVM;
                }
                else
                {
                    DataContext = new GroupViewModel();
                }
            }
        }

    }
}
