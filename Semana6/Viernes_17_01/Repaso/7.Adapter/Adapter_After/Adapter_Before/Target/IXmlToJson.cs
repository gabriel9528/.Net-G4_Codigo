using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Before.Target
{
    public interface IXmlToJson
    {
        string ConvertXmlToJson();
    }
}
