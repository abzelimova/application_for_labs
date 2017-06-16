using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater.Sevices
{
    public class ServiceInformation
    {
        public static ServiceInformation Instance = new ServiceInformation();
        public string _langOne = "Английский";
        public string _langTwo = "Русский";
        public string _textinBox;

        public void GetLangOne(string LangOne)
        {
            _langOne = LangOne;
        }

        public void TextinBox(string TextinBox)
        {
            _textinBox = TextinBox;
        }

        public void GetLangTwo(string LangTwo)
        {
            _langTwo = LangTwo;
        }

    }

}