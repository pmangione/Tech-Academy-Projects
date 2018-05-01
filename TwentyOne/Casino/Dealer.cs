using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { set; get; }
        public int Balance { set; get; } 

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());

            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\pmang\OneDrive\Documents\CodeCamp\TwentyOneFolderText\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }


            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }

    }
}
