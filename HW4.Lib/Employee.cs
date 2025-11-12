namespace Homework4
{
    public class Employee
    {
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value == " " || value == "   ")
                    throw new InvalidDataException("Employee must have a last name.");
                lastName = value;
            }
        }
        private double salary;
        public double Salary
        {
            get { return salary; }
            private set
            {
                if (value <= 0)
                    throw new InvalidDataException("Employee must have a salary higher than 0.");
                salary = value;
            }
        }

        public Employee(string lastName, double salary)
        {
            LastName = lastName;
            Salary = salary;
        }

        public static Employee operator +(Employee emp, double inc)
        {
            return new Employee(emp.LastName, emp.Salary + inc);
        }

        public static Employee operator -(Employee emp, double inc)
        {
            return new Employee(emp.LastName, emp.Salary - inc);
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Salary == emp2.Salary;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Salary != emp2.Salary;
        }

        public static bool operator >(Employee emp1, Employee emp2)
        {
            return emp1.Salary > emp2.Salary;
        }

        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.Salary < emp2.Salary;
        }
    }
}
