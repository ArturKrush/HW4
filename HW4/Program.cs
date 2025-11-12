
namespace Homework4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Task 1
            Employee employee1 = new Employee("Statham", 500);
            Employee employee1AfterInc = employee1 + 100;
            Console.WriteLine(employee1AfterInc.Salary);
            Employee employee1AfterDec = employee1AfterInc - 50.25;
            Console.WriteLine(employee1AfterDec.Salary);

            Employee employee2 = new Employee("Dwayne", 500);
            if (employee1 == employee2)
                Console.WriteLine("{0} and {1} salaries are equal", employee1.LastName, employee2.LastName);
            else
                Console.WriteLine("{0} and {1} salaries are not equal", employee1.LastName, employee2.LastName);

            if (employee1AfterDec != employee2)
                Console.WriteLine("After counting {0} and {1} salaries are not equal", employee1AfterDec.LastName, employee2.LastName);
            else
                Console.WriteLine("After counting {0} and {1} salaries are equal", employee1AfterDec.LastName, employee2.LastName);

            if (employee1 > employee2)
                Console.WriteLine("{0} salary have been higher compare to {1}", employee1.LastName, employee2.LastName);
            else
                Console.WriteLine("{0} salary haven't been higher compare to {1}", employee1.LastName, employee2.LastName);

            if (employee2 < employee1AfterDec)
                Console.WriteLine("{0} salary was got higher compare to {1}", employee1AfterDec.LastName, employee2.LastName);
            else
                Console.WriteLine("{0} salary was got higher compare to {1}", employee1AfterDec.LastName, employee2.LastName);
        }
    }
}
