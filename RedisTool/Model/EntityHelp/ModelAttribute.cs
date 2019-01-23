using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisTool.Model.EntityHelp
{
    public class ModelAttribute : Attribute
    {
        public ModelAttribute(string modelName)
        {
            ModelName = modelName;
        }

        public string ModelName { get; set; }
    }
}
