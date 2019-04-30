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
using System.Windows.Shapes;

namespace ListView
{
    /// <summary>
    /// Interaction logic for MainWIndow.xaml
    /// </summary>
    public partial class MainWIndow : Window
    {

        MainWindowViewModel MainVM { get; set; }
        public MainWIndow()
        {
            InitializeComponent();

            MainVM = new MainWindowViewModel();

            DataContext = MainVM;
        }
      
    }
}
