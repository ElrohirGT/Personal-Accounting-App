using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Personal_Accounting_App.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int _number = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        public Command IncrementCount { get; set; }
        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Number)));
            }
        }
        public MainPageViewModel()
        {
            IncrementCount = new Command(() =>
            {
                ++Number;
            });
        }
    }
}
