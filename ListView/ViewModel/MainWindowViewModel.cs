using ListView.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView.ViewModel
{
    class MainWindowViewModel :BaseViewModel
    {
        public ShowSecondView showSecondView => new ShowSecondView();
    }
}
