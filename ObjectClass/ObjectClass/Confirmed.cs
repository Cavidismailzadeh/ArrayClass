
#region ClassroomWork

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Confirmed
    {
        public string name;
        public string surname;
        public string address;

    }
}

namespace ConsoleApp1
{
    internal class Confirmed2
    {
        public string name;
        public string surname;
        public string address;

        public string FullConfirmed2()
        {
            return name + "-" + surname + "-" + address;
        }

    }
}



namespace ConsoleApp1
{
    internal class Confirmed3
    {
        public string name;
        public string surname;
        public string address;

        public string FullConfirmed3()
        {
            return $"{name}, {surname}, {address}";
        }

    }
}


#endregion




#region HomeWorkTask
public class Account
{
    public string name;
    public string password;

    public Account(string name, string password)
    {
        this.name = name;
        this.password = password;
    }
    public void Sign()
    {
        if (name == "Cavid123" && password == "Cavid1993")
        {
            Console.WriteLine("Ugurlu Giris");
        }
        else
        {
            Console.WriteLine("Username ve ya Password Dogru Deyil");
        }
    }



}







public class Account2
{
    public string name;
    public string password;

    public Account2(string name, string password)
    {
        this.name = name;
        this.password = password;
    }
    public void Sign()
    {
        if (name == "Ibrahim" && password == "2110477")
        {
            Console.WriteLine("Ugurlu Giris");
        }
        else
        {
            Console.WriteLine("Username ve ya Password Dogru Deyil");
        }
    }



}




public class Factorial
{
    public int n;
    public Factorial() { n = 0; }

    public void NumsFactorial(long n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result = result * i;
        }
        Console.WriteLine(result);

    }
}

#endregion
