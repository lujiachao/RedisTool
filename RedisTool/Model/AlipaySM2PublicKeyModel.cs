using RedisTool.Model.EntityHelp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisTool.Model
{
    [Model("AlipaySM2PublicKeyModel")]
    public class AlipaySM2PublicKeyModel
    {
        public DateTime TimeInvalid { get; set; }

        public int IdUser { get; set; }

        public string GuidUser { get; set; }

        public string QRCodeAuthHeader { get; set; }

        public string QRCodeAuthContent { get; set; }

        public string QRCodeAuthCustomContent { get; set; }

        public string SM2PublicKey { get; set; }

        public string BatchNo { get; set; }
    }
}
