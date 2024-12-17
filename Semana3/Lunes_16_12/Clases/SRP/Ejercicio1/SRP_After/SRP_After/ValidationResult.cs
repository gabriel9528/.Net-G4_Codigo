using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_After
{
    public class ValidationResult
    {
        public List<string> ListErrorMessage { get; set; } = [];
        //public bool IsValid { get; set; } = true;

        public bool IsValid { get
            {
                return !ListErrorMessage.Any();
            }
        }

    }
}
