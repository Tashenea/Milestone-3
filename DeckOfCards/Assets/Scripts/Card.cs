using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Card
{

    string Face;
    string Suit;

    public Card(string cardFace,string cardSuit)
    {
        Face = cardFace;
        Suit = cardSuit;
    }
    public override string ToString()
    {
        return Face + "of" + Suit;
    }

    //public string Name { get; set; }

    //public Card()
    //{
    //    Name = "";
    //}
}

