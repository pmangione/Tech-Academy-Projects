using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwenyOneDealer : Dealer
    {
        public List<Card> Hand { set; get; }
        public bool Stay { set; get; }
        public bool isBusted { set; get; }
    }
}
