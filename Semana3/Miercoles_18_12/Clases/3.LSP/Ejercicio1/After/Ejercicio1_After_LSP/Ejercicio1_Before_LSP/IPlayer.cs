using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Before_LSP
{
    internal interface IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerCategory Category { get; set; }
        void SetCategory(PlayerCategory playerCategory);
        string GetMarketValue(PlayerCategory playerCategory);

    }
}
