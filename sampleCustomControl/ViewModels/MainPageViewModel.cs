using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleCustomControl.ViewModels
{
    public class MainPageViewModel : ViewModelBase, INotifyPropertyChanged
    {

        public DelegateCommand Test { get; set; }
        private string _Txt;

        public string Txt { get { return _Txt; } set { _Txt = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Txt")); } }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            Test = new DelegateCommand(LoginInMethode);
        }
        void LoginInMethode()
        {
            string result = Txt;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
