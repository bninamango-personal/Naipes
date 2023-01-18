using System;
using System.Collections.Generic;
using System.Text;

namespace bninamango
{
    public enum Symbol
    {
        Trebol,
        Pica,
        Corazon,
        Diamante
    }

    class Card
    {
        private string value;
        private Symbol symbol;

        public Card(string value, Symbol symbol)
        {
            this.value = value;
            this.symbol = symbol;
        }

        public void Show()
        {
            Console.WriteLine("Value : " + value);
            Console.WriteLine("Simbole : " + symbol);
        }
    }
}