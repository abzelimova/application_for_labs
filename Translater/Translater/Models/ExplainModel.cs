using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater.Models
{
   public class ExplainModel
    {
        public string text { get; set; }
        public List<TranslateModel> tr { get; set; }
    }
}
