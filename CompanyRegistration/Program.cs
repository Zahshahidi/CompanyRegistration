using System;
using System.Xml.Linq;

namespace CompanyRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("Welcome To Registration Company System");
            Console.WriteLine("======================================");

            //Get Company Information from User

            Company company = new Company();

            Console.WriteLine("Please Enter Company Name: ");
            company.Name = Console.ReadLine();

            Console.WriteLine("Please Enter  Company StartDate: ");
            company.StartDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Please Enter Company City: ");
            company.City = Console.ReadLine(); 

            //Get Company Employeeies Information from User

            Employee e1, e2;

            e1 = ReadEmployeeFromConsole(1);
            e2 = ReadEmployeeFromConsole(2);

            company.Employees[0] = e1;
            company.Employees[1] = e2;

            //Get Company Products Information from User

            Product p1, p2, p3;
            p1 = ReadProductFromConsole(1);
            p2 = ReadProductFromConsole(2);
            p3 = ReadProductFromConsole(3);

            company.Products[0] = p1;
            company.Products[1] = p2;   
            company.Products[2] = p3;

            company.DisplayInfo();

        }
        public static Employee ReadEmployeeFromConsole(int employeeNumber)
        {
            Console.WriteLine("Please Enter Company Employee Number" + employeeNumber + "First Name: ");
            string fname = Console.ReadLine();

            Console.WriteLine("Please Enter Company Employee Number" + employeeNumber + "Last Name: ");
            string lname = Console.ReadLine();

            Employee e1 = new Employee(fname, lname);

            Console.WriteLine("Please Enter Company Employee Number" + employeeNumber + "Salary: ");
            e1.Salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Company Employee Number" + employeeNumber + "Birth Date: ");
            e1.BirthDate = Convert.ToDateTime(Console.ReadLine());

            return e1;
        }
        public static Product ReadProductFromConsole(int pNumber)
        {
            Console.WriteLine("Please Enter Company Product Number" + pNumber + " Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter Company Product Number" + pNumber + " Code: ");
            string code = Console.ReadLine();

            Console.WriteLine("Please Enter Company Product Number" + pNumber + " Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            Product p = new Product(name, code, price);
            return p;

        }
    }
    public class Company
    {
        public Company()
        {
            Employees = new Employee[2];
            Products = new Product[3];
        }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string City { get; set; }
        public Employee[] Employees { get; set; }
        public Product[] Products { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("Company Full Info is: ");
            Console.WriteLine("Company Name is: " + Name);
            Console.WriteLine("Company StartDate is: " + StartDate.ToString());
            Console.WriteLine("Company City is: " + City);

            foreach (Employee e in Employees)
            {
                e.DisplayInfo();
            }
            foreach (Product p in Products)
            {
                p.DisplayInfo();
            }

            Console.WriteLine("***********************************************");
        }
    }

    public class Employee
    {
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public DateTime BirthDate { get; set; }
        public int Salary { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("Employee Full Information is: ");
            Console.WriteLine("Employee FullName is: " + FullName);
            Console.WriteLine("Employee startBirthDate is: " + BirthDate.ToString());
            Console.WriteLine("Employee Salary is: " + Salary);
            Console.WriteLine("***********************************************");
        }
    }

    public class Product
    {
        public Product(string name, string code, int price)
        {
            Name = name;
            Price = price;
            PCode = code;
        }

        public string Name { get; set; }
        public string PCode { get; set; }
        public int Price { get; set; }

        public void DisplayInfo()
        {

            Console.WriteLine("***********************************************");
            Console.WriteLine("Product Full Information  is: ");
            Console.WriteLine("Product Full Name is " + Name);
            Console.WriteLine("Product Code  is " + PCode);
            Console.WriteLine("Product Price  is " + Price);
            Console.WriteLine("***********************************************");

        }
    }
}
