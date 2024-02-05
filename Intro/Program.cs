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