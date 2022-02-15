using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Personal_Accounting_App.ViewModels;

using Xamarin.Forms;

namespace Personal_Accounting_App
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel _viewModel = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = _viewModel;
        }
    }
}
