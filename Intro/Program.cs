// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");


string message1 = "Krediler";
int term = 12;
double amount = 100000;

// variables --> camelCase

bool isAuthenticated = false;
Console.WriteLine(message1);


//condition
if (isAuthenticated)
{
    Console.WriteLine("Buton --> Hoşgeldin Serter");
}
else
{
    Console.WriteLine("Buton --> Sisteme Giriş Yapınız.");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3" };
/* string[] loans2 = new string[]
{
    "Kredi 1",
    "kredi 2",
    "kredi 3"
};

*/


/*
string[] loans3 = new string[6];
loans3[0] = "Kredi1";
loans3[1] = "Kredi2";
loans3[2] = "Kredi3";
loans3[3] = "Kredi4";
*/
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}




CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "56458978215";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654788";
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "abc";
customer4.CustomerNumber = "654789";
customer4.TaxNumber = "1234567897";


BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism (referansları tutma durumu)
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}