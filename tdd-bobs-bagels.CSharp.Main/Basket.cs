using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<String> _bagels = new List<String>();

        public bool basketIsFull = false;
        public int basketMaxSize { get; set; } = 3;

        public string addBagel(string bagel)
        {
            throw new NotImplementedException();
        }
    }
}
