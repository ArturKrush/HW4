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
                    throw new InvalidDataException("Not enough funds on the credit card.");
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

        private string cardNumber;
        public string CardNumber
        {
            get { return cardNumber; }

            private set
            {
                // Регулярний вираз:
                // ^ - початок рядка
                // \d{16} - рівно 16 цифр
                // $ - кінець рядка
                string pattern = @"^\d{16}$";

                if (value != null && Regex.IsMatch(value, pattern))
                {
                    cardNumber = value;
                }
                else
                {
                    throw new InvalidDataException("Card number must consist of 16 numbers.");
                }
            }
        }

        public CreditCard(string cardNumber, string cvv, long balance)
        {
            CardNumber = cardNumber;
            CVV = cvv;
            Balance = balance;
        }

        public static CreditCard operator +(CreditCard card, long inc)
        {
            return new CreditCard(card.CardNumber, card.CVV, card.Balance + inc);
        }

        public static CreditCard operator -(CreditCard card, long dec)
        {
            return new CreditCard(card.CardNumber, card.CVV, card.Balance - dec);
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
