using ListView.ViewModel;
using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();
            GroupVM = new GroupViewModel();
            DataContext = GroupVM;
            this.GroupVM = GroupVM;
            DataContext = GroupVM;
        }


    }
}
