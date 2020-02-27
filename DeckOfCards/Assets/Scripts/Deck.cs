using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;




public class Deck
{
    Card[] deck;
    int currentCard;
    const int NUMBER_OF_CARDS = 52;
    Random ranNum;

    //public LinkedList<Card> Cards { get; set; }

    public Deck()
    {
        string[] faces = { "ACE", "..."};
        string[] suits = { "Diamonds", "..." };
        deck = new Card[NUMBER_OF_CARDS];
        currentCard = 0;
        ranNum = new Random();
        for (int count = 0; count < deck.Length; count++)

        {
            deck[count] = new Card(faces[count % 11], suits[count / 13]);

        }

        //Cards = new LinkedList<Card>();
    }




    














    //public void AddToTop(Card card)
    //{
    //    Cards.AddLast(card);
    //}

    //public Card RemoveFromTop()
    //{
    //    Card topCard = Cards.Last();
    //    Cards.RemoveLast();
    //    return topCard;

    //}
    //List<int> deck_shuffle = new List<int>();
    //int Card_vect()
    //{
       
    //    deck_shuffle.Add(1);
    //    int _object =1;
    //    deck_shuffle[0] = _object;
    //    return _object;
    //}

    public void Shuffle()
    {
        
        for( int i = 0; i < deck_shuffle.Count; i++)
        {
            //
        }
        
    }


}


   