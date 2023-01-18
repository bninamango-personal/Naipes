using System;
using System.Collections.Generic;
using System.Text;

namespace bninamango
{
    class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    string value = "";

                    switch (j)
                    {
                        default:
                            value = j.ToString();
                            break;

                        case 1:
                            value = "A";
                            break;

                        case 11:
                            value = "J";
                            break;

                        case 12:
                            value = "Q";
                            break;

                        case 13:
                            value = "K";
                            break;
                    }

                    Card card = new Card(value, (Symbol)i);

                    cards.Add(card);
                }
            }
        }

        public void ShowAll()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                cards[i].Show();

                Console.WriteLine("");
            }
        }

        public void Shuffle()
        {
            List<Card> cards = new List<Card>();

            for (int i = 0; i < this.cards.Count; i += 0)
            {
                int index = new Random().Next(0, this.cards.Count);

                Card card = this.cards[index];

                cards.Add(card);

                this.cards.RemoveAt(index);
            }

            this.cards = cards;
        }
    }
}