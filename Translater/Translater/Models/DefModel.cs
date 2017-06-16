using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater.Models
{
    public class DefModel
    {
        public string text { get; set; }
        public string pos { get; set; }
        public string ts { get; set; }
        public List<TranslateModel> tr { get; set; }
    }
}
