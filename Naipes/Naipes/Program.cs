using System;

namespace bninamango
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck.Shuffle();

            deck.ShowAll();
        }
    }
}