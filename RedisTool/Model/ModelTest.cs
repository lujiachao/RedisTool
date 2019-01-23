using RedisTool.Model.EntityHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisTool.Model
{
    [Model("ModelTest")]
    public class ModelTest
    {
        public int TransactionType
        {
            get; set;
        }

        public DateTime TimeStamp
        {
            get; set;
        }

        public string ET
        {
            get; set;
        }

        public string Equipment
        {
            get; set;
        }

        public string UserId
        {
            get; set;
        }

        public string Station
        {
            get; set;
        }
    }
}
