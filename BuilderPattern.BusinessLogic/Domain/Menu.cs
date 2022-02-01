using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BusinessLogic.Domain
{
    public class Menu
    {

        public Menu()
        {
            Additional = new List<MenuAdditional>();
        }

        public int ComboNumber { get; set; }
        public List<MenuAdditional> Additional { get; set; }
        public bool IsDelivery { get; set; }
        public bool NeedsKetchup { get; set; }
        public string Message { get; internal set; }
    }
}
