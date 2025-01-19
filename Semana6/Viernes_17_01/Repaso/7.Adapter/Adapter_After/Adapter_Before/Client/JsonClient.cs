using Adapter_Before.Target;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Before
{
    public class JsonClient
    {

        public string ConverToJson(IXmlToJson xmlToJson)
        {
            var result = xmlToJson.ConvertXmlToJson();
            return result;
        }
    }
}
