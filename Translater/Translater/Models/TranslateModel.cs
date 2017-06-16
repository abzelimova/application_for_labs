using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater.Models
{
    public class TranslateModel
    {
        public string text { get; set; }
        public string pos { get; set; }
        public string gen { get; set; }
        public List<SynonymsModel> syn { get; set; }
        public List<MeanModel> mean { get; set; }
        public List<ExplainModel> ex { get; set; }

    }
}
