using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translater.Models
{
    public class ResponseModel
    {
        public object head { get; set; }
        public List<DefModel> def {get;set;}
    }
}
