using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;




public class Deck
{
    public LinkedList<Card> Cards { get; set; }

    public Deck()
    {
        Cards = new LinkedList<Card>();
    }

    public void AddToTop(Card card)
    {
        Cards.AddLast(card);
    }

    public Card RemoveFromTop()
    {
        Card topCard = Cards.Last();
        Cards.RemoveLast();
        return topCard;

    }
    List<int> deck_shuffle = new List<int>();
    int Card_vect()
    {
       
        deck_shuffle.Add(1);
        int _object =1;
        deck_shuffle[0] = _object;
        return _object;
    }

    public void Shuffle()
    {
        
        for( int i = 0; i < deck_shuffle.Count; i++)
        {
            //
        }
        
    }


}


   