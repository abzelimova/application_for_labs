using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translater.Sevices;
using Translater.ViewModels;
using Xamarin.Forms;

namespace Translater
{
    public partial class StartPage : ContentPage
    {
        private StartPageViewModel _viewModel;
        public string lang { get; set; }
        public bool changed = false;

        public StartPage()
        {
            InitializeComponent();
            _viewModel = new StartPageViewModel();
            this.BindingContext = _viewModel;
            this.first.Text = ServiceInformation.Instance._langOne;
            this.second.Text = ServiceInformation.Instance._langTwo;
            this.Stacktoeditor.Padding = new Thickness(5, 10);

            lang = "en-ru";
        }

        void ChangeLang(object sender, EventArgs e)
        {
            if (!changed)
            {
                this.first.Text = ServiceInformation.Instance._langTwo;
                this.second.Text = ServiceInformation.Instance._langOne;
                lang = "ru-en";
                changed = true;
            } else
            {

                this.first.Text = ServiceInformation.Instance._langOne;
                this.second.Text = ServiceInformation.Instance._langTwo;
                lang = "en-ru";
                changed = false;
            }
        }
        public async void GiveTranslate(object sender, EventArgs e)
        {
             _viewModel.Translater(lang);
        }
    }
}
