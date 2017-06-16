using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translater.Sevices;

namespace Translater.ViewModels
{
    public class StartPageViewModel : INotifyPropertyChanged
    {
        public string TextinBox { get; set; }
        public string TranslatedWord { get; set; }

        public StartPageViewModel()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public async void Translater(string lang)
        {
            var _dataSerice = DataService.GetInstance();
            var response = await _dataSerice.TranslateAsync(lang, TextinBox);

            TranslatedWord = response.def[0].tr[0].text;
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TranslatedWord)));
        }
    }
}
