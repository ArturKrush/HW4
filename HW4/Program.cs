
namespace Homework4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Task 1
            //Employee employee1 = new Employee("Statham", 500);
            //Employee employee1AfterInc = employee1 + 100;
            //Console.WriteLine(employee1AfterInc.Salary);
            //Employee employee1AfterDec = employee1AfterInc - 50.25;
            //Console.WriteLine(employee1AfterDec.Salary);

            //Employee employee2 = new Employee("Dwayne", 500);
            //if (employee1 == employee2)
            //    Console.WriteLine("{0} and {1} salaries are equal", employee1.LastName, employee2.LastName);
            //else
            //    Console.WriteLine("{0} and {1} salaries are not equal", employee1.LastName, employee2.LastName);

            //if (employee1AfterDec != employee2)
            //    Console.WriteLine("After counting {0} and {1} salaries are not equal", employee1AfterDec.LastName, employee2.LastName);
            //else
            //    Console.WriteLine("After counting {0} and {1} salaries are equal", employee1AfterDec.LastName, employee2.LastName);

            //if (employee1 > employee2)
            //    Console.WriteLine("{0} salary have been higher compare to {1}", employee1.LastName, employee2.LastName);
            //else
            //    Console.WriteLine("{0} salary haven't been higher compare to {1}", employee1.LastName, employee2.LastName);

            //if (employee2 < employee1AfterDec)
            //    Console.WriteLine("{0} salary was got higher compare to {1}", employee1AfterDec.LastName, employee2.LastName);
            //else
            //    Console.WriteLine("{0} salary was got higher compare to {1}", employee1AfterDec.LastName, employee2.LastName);
            //Console.WriteLine("-------------");

            ////Task 2
            //City city1 = new City("Odesa", 1000_000);
            //City city1AfterDec = city1 - 100_000;
            //Console.WriteLine("{0} population was decreased to {1}", city1AfterDec.Name, city1AfterDec.Population);
            //City city2 = new City("Lviv", 750_000);
            //City city2AfterInc = city2 + 125_000;
            //Console.WriteLine("{0} population was increased to {1}", city2AfterInc.Name, city2AfterInc.Population);

            //if(city1 == city1AfterDec)
            //    Console.WriteLine("{0} population wasn't changed", city1AfterDec.Name);
            //else
            //    Console.WriteLine("{0} population was changed", city1AfterDec.Name);

            //if (city2 != city2AfterInc)
            //    Console.WriteLine("{0} population was changed", city2AfterInc.Name);
            //else
            //    Console.WriteLine("{0} population wasn't changed", city2AfterInc.Name);

            //if (city1AfterDec > city2AfterInc)
            //    Console.WriteLine("{0} is still more populated than {1}", city1AfterDec.Name, city2AfterInc.Name);
            //else
            //    Console.WriteLine("{0} not more has a higher population than {1}", city1AfterDec.Name, city2AfterInc.Name);

            //if (city1AfterDec < city2AfterInc + 30_000)
            //    Console.WriteLine("{0} could be towards {1} by population soon", city2AfterInc.Name, city1AfterDec.Name);
            //else
            //    Console.WriteLine("{0} will not reach {1} population soon", city2AfterInc.Name, city1AfterDec.Name);
            //Console.WriteLine("-------------");

            //Task 3
            //CreditCard card1 = new CreditCard("5168757385595626", "225", 10_000);
            //CreditCard card1AfterInc = card1 + 1125;
            //Console.WriteLine("{0} is on {1} card balance.", card1AfterInc.Balance, card1AfterInc.CardNumber);

            //// Кредитна карта, яка відрізняється від попередньої на останню цифру імені
            //CreditCard card2 = new CreditCard("5168757385595627", "337", 12_000);
            //CreditCard card2AfterDec = card2 - 2000;
            //Console.WriteLine("{0} is on {1} card balance.", card2AfterDec.Balance, card2AfterDec.CardNumber);

            //if (card1 == card2)
            //    Console.WriteLine("{0} and {1} credit cards are identical.", card1AfterInc.CardNumber, card2AfterDec.CardNumber);
            //else
            //    Console.WriteLine("{0} and {1} credit cards are different.", card1AfterInc.CardNumber, card2AfterDec.CardNumber);

            //if (card1 != card2)
            //    Console.WriteLine("{0} and {1} credit cards have different CVV-codes.", card1AfterInc.CardNumber, card2AfterDec.CardNumber);
            //else
            //    Console.WriteLine("{0} and {1} credit cards have identical CVV-codes", card1AfterInc.CardNumber, card2AfterDec.CardNumber);

            //if (card1 > card2)
            //    Console.WriteLine("Card {0} has more money on the balance than {1} card.", card1AfterInc.CardNumber, card2AfterDec.CardNumber);
            //else
            //    Console.WriteLine("Card {0} don't have more money on the balance than {1} card.", card1AfterInc.CardNumber, card2AfterDec.CardNumber);

            //if (card1 < card2)
            //    Console.WriteLine("Card {0} has less money on the balance than {1} card.", card1AfterInc.CardNumber, card2AfterDec.CardNumber);
            //else
            //    Console.WriteLine("Card {0} has not less money on the balance than {1} card.", card1AfterInc.CardNumber, card2AfterDec.CardNumber);

            //Task 4
            Matrix mtrx1 = new Matrix(4, 4, true);
            Console.WriteLine("Adding matrix1 and matrix2");
            Console.WriteLine("matrix1:");
            for (int i = 0; i < mtrx1.RowNumber; i++)
            {
                for (int j = 0; j < mtrx1.ColumnNumber; j++)
                {
                    Console.Write(mtrx1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Matrix mtrx2 = new Matrix(4, 4, true);
            Console.WriteLine("matrix2:");
            for (int i = 0; i < mtrx2.RowNumber; i++)
            {
                for (int j = 0; j < mtrx2.ColumnNumber; j++)
                {
                    Console.Write(mtrx2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Matrix added = mtrx1 + mtrx2;
            Console.WriteLine("Sum:");
            for (int i = 0; i < added.RowNumber; i++)
            {
                for (int j = 0; j < added.ColumnNumber; j++)
                {
                    Console.Write(added[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Matrix subtructed = mtrx1 - mtrx2;
            Console.WriteLine("Difference:");
            for (int i = 0; i < subtructed.RowNumber; i++)
            {
                for (int j = 0; j < subtructed.ColumnNumber; j++)
                {
                    Console.Write(subtructed[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int scalar = 2;
            Matrix multipliedByScalar = mtrx1 * scalar;
            Console.WriteLine("matrix1 multiplied by {0}:", scalar);
            for (int i = 0; i < multipliedByScalar.RowNumber; i++)
            {
                for (int j = 0; j < multipliedByScalar.ColumnNumber; j++)
                {
                    Console.Write(multipliedByScalar[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Matrix product = mtrx1 * mtrx2;
            Console.WriteLine("Product of matrix1 and matrix2 is:");
            // Перевірено за допомогою калькулятора
            for (int i = 0; i < product.RowNumber; i++)
            {
                for (int j = 0; j < product.ColumnNumber; j++)
                {
                    Console.Write(product[i, j] + "\t");
                }
                Console.WriteLine();
            }

            if (mtrx1 == mtrx2)
                Console.WriteLine("Matrices 1 and 2 are equal.");
            else
                Console.WriteLine("Matrices 1 and 2 are not equal.");

            if (mtrx1 != mtrx2)
                Console.WriteLine("Matrices 1 and 2 are not equal.");
            else
                Console.WriteLine("Matrices 1 and 2 are equal.");
        }
    }
}
