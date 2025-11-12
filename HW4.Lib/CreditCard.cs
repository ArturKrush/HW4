using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework4
{
    public class CreditCard
    {
        private long balance;
        public long Balance
        {
            get { return balance; }
            private set
            {
                if (value <= 0)
                    throw new InvalidDataException("No more funds on credit card.");
                balance = value;
            }
        }
        private string cvc;
        public string CVV
        {
            get { return cvc; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidDataException("CVC-code can not be empty.");
                }

                string pattern = @"^\d{3}$";

                // Перевірка на відповідність
                if (!Regex.IsMatch(value, pattern))
                {
                    throw new InvalidDataException("CVC-code must consist of 3 numbers.");
                }
                cvc = value;
            }
        }

        public CreditCard(long balance, string cvv)
        {
            Balance = balance;
            CVV = cvv;
        }

        public static CreditCard operator +(CreditCard card, long inc)
        {
            return new CreditCard(card.Balance + inc, card.CVV);
        }

        public static CreditCard operator -(CreditCard card, long dec)
        {
            return new CreditCard(card.Balance - dec, card.CVV);
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.CVV == card2.CVV;
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return card1.CVV != card2.CVV;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }
    }
}
