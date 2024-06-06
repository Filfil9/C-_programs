using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        Q1:
static void Main(string[] args)
        {
            Console.Write("enter num1 :");
            int c = int.Parse(Console.ReadLine());
            Console.Write("enter num2 :");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine(computnumbers(c, v));
            Console.ReadLine();
        }
        static int computnumbers(int y, int x)
        {
            if (x == y)
            {
                return (x + y) * 3;
            }
            else
            {
                return y + x;
            }
        }
-------------------------------------------------------------------------------------------
Q2:
 static void Main(string[] args)
        {
            Console.Write("enter numb:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(computnumbers(c));
            Console.ReadLine();
        }
        static int computnumbers(int y)
        {
            if (y >= 51)
            {
                return (y - 51) * 3;
            }
            else
            {
                return 51 - y;
            }
        }
------------------------------------------------------------------------------------------
Q3:
static void Main(string[] args)
        {
            Console.Write("enter num1 :");
            int c = int.Parse(Console.ReadLine());
            Console.Write("enter num2 :");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine(computnumbers(c, v));
            Console.ReadLine();
        }
        static bool computnumbers(int y, int x)
        {
            if (x == 30 || y == 30 || (x + y) == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
-------------------------------------------------------------------------------------------
Q5:
static void Main(string[] args)
        {
            Console.Write("enter the word :");
            string c = Console.ReadLine();
            Console.WriteLine(Checkword(c));
            Console.ReadLine();
        }
        static string Checkword(String y)
        {
            if (y.StartsWith("if"))
            {
                return y;
            }
            else
            {
                return ("if" + y);
            }
        }
-------------------------------------------------------------------------------------------
Q6:
    static void Main(string[] args)
        {
            Console.Write("enter the word :");
            string word = Console.ReadLine();
            Console.Write("enter the position you want remove it:");
            int posit = int.Parse(Console.ReadLine());
            Console.WriteLine(Checkword(word, posit));
            Console.ReadLine();
        }
        static string Checkword(string w, int p)
        {
            string z = w.Remove(p, 1);
            return z;
        }
-------------------------------------------------------------------------------------------
Q7:
static void Main(string[] args)
        {
            Console.Write("enter the word :");
            string word = Console.ReadLine();
            Console.WriteLine("the word after exchang first and last char");
            Console.WriteLine(Checkword(word));
            Console.ReadLine();
        }
        static string Checkword(string w)
        {
            if (w.Length <= 1)
            {
                return w;
            }
            else
            {
                char firschar = w[0];
                char lastchare = w[w.Length - 1];
                return lastchare + w.Substring(1, w.Length - 2) + firschar;
            }
        }
----------------------------------------------------------------------------------------
Q8
static void Main(string[] args)
        {
            Console.Write("enter the word :");
            string word = Console.ReadLine();
            Console.WriteLine("the word after copies first 2 char");
            Console.WriteLine(Checkword(word));
            Console.ReadLine();
        }
        static string Checkword(string w)
        {
            if (w.Length <= 1)
            {
                return w;
            }
            else
            {
                string towchar = w.Substring(0, 2);

                return towchar + towchar + towchar + towchar;
            }
        }
----------------------------------------------------------------------------------------
Q9
    static void Main(string[] args)
        {
            Console.Write("enter the word :");
            string word = Console.ReadLine();
            Console.WriteLine("the word after copies first 2 char");
            Console.WriteLine(Checkword(word));
            Console.ReadLine();
        }
        static string Checkword(string w)
        {
            char lastchar = w[w.Length - 1];
            return lastchar + w + lastchar;
        }
    }    
-----------------------------------------------------------------------------------------
Q10
static void Main(string[] args)
    {
        Console.Write("enter the number :");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("is the number multiple of 3 or 7 ?");
        Console.WriteLine(Checkword(number));
        Console.ReadLine();
    }
    static bool Checkword(int numb)
    {
        if (numb % 3 == 0 || numb % 7 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
------------------------------------------------------------------------------------------
Q11
static void Main(string[] args)
    {
        Console.Write("enter the word :");
        string word = Console.ReadLine();
        Console.WriteLine("the word after copies first 3 char");
        Console.WriteLine(Checkword(word));
        Console.ReadLine();
    }
    static string Checkword(string w)
    {
        string threechar = w.Substring(0, 3);

        return threechar + w + threechar;
    }
------------------------------------------------------------------------------------------
Q12
static void Main(string[] args)
    {
        Console.Write("enter the word :");
        string word = Console.ReadLine();
        Console.WriteLine("if word start with C# or not");
        Console.WriteLine(Checkword(word));
        Console.ReadLine();
    }
    static bool Checkword(string w)
    {
        if (w.StartsWith("c#"))
        {
            return true;
        }
        else
        {
            return false;
        }


    }
-------------------------------------------------------------------------------------------
Q 13:
static void Main(string[] args)
    {
        Console.Write("enter the temperature1 :");
        int c = int.Parse(Console.ReadLine());
        Console.Write("enter the temperature2:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Checknum(c, n));
        Console.ReadLine();
    }
    static bool Checknum(int y, int n)
    {
        if ((y < 0 && n > 100) || (n > 100 && y < 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
-------------------------------------------------------------------------------------------
Q14:
static void Main(string[] args)
    {
        Console.Write("enter the number1 :");
        int c = int.Parse(Console.ReadLine());
        Console.Write("enter the number2:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Checkword(c, n));
        Console.ReadLine();
    }
    static bool Checkword(int y, int n)
    {
        if ((y > 100 && n < 200) || (n > 100 && y < 200))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
-------------------------------------------------------------------------------------------
Q15
static void Main(string[] args)
    {
        Console.Write("enter the number1 :");
        int c = int.Parse(Console.ReadLine());
        Console.Write("enter the number2:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("enter the number3 :");
        int z = int.Parse(Console.ReadLine());
        Console.WriteLine(Checknum(c, n, z));
        Console.ReadLine();
    }
    static bool Checknum(int y, int n, int z)
    {
        if (20 <= y && y < 50 && 20 <= z && z < 50 && 20 <= n && n < 50)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
-------------------------------------------------------------------------------------------
Q16
static void Main(string[] args)
    {
        Console.Write("enter the number1 :");
        int c = int.Parse(Console.ReadLine());
        Console.Write("enter the number2:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Checknum(c, n));
        Console.ReadLine();
    }
    static bool Checknum(int y, int n)
    {
        if ((y > 20 && y < 50) || (n < 50 && n > 20))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
-------------------------------------------------------------------------------------------Q17
static void Main(string[] args)
    {
        Console.Write("enter the word :");
        string word = Console.ReadLine();
        Console.WriteLine("if word 'yt' appears at index 1");
        Console.WriteLine(Checkword(word));
        Console.ReadLine();
    }
    static string Checkword(string w)
    {

        if (w.Substring(1, 2) == "yt")
        {
            string z = w.Remove(1, 2);
            return z;
        }
        else
        {
            return w;
        }
    }
-------------------------------------------------------------------------------------------
Q18
 static void Main(string[] args)
    {
        Console.Write("enter the number1 :");
        int c = int.Parse(Console.ReadLine());
        Console.Write("enter the number2:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("enter the number3 :");
        int z = int.Parse(Console.ReadLine());
        Console.WriteLine(Checknum(c, n, z));
        Console.ReadLine();
    }
    static int Checknum(int y, int n, int d)
    {
        int s = Math.Max(n, y);
        int o = Math.Max(s, d);
        return o;
    }
-------------------------------------------------------------------------------------------
Q19
 static void Main(string[] args)
    {
        Console.Write("enter the number1 :");
        int c = int.Parse(Console.ReadLine());
        Console.Write("enter the number2:");
        int n = int.Parse(Console.ReadLine());
        Console.Write(" this number is closed to 100");
        Console.WriteLine(Checknum(c, n));
        Console.ReadLine();
    }
    static int Checknum(int y, int n)
    {
        int result = y.CompareTo(n);
        if (result == 0)
        {
            return 0;
        }
        else if (result > 0)
        {
            return y;
        }
        else
        {
            return n;
        }
    }
-------------------------------------------------------------------------------------------
Q20
static void Main(string[] args)
    {
        Console.Write("enter the number1 :");
        int c = int.Parse(Console.ReadLine());
        Console.Write("enter the number2:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Checknum(c, n));
        Console.ReadLine();
    }
    static bool Checknum(int y, int n)
    {
        if ((y >= 40 && y <= 50) || (n > 40 && n <= 50))
        {
            return true;

        }
        else if ((y >= 50 && y <= 60) || (n > 50 && n <= 60))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
-------------------------------------------------------------------------------------------
Q21
static void Main(string[] args)
    {
        Console.Write("enter the number1 :");
        int c = int.Parse(Console.ReadLine());
        Console.Write("enter the number2:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Checknum(c, n));
        Console.ReadLine();
    }
    static int Checknum(int y, int n)
    {
        if ((y >= 20 && y <= 30) && (n >= 20 && n <= 30))
        {
            return Math.Max(y, n);
        }
        else
        {
            return 0;
        }

    }
------------------------------------------------------------------------------------------
Q22
static bool Checkword(string w)
    {
        int count = 0;
        foreach (char i in w)
        {
            if (i == 'z')
            {
                count++;
            }
            else
            {
                continue;
            }
        }
        if (count >= 2 && count <= 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
 ------------------------------------------------------------------------------------------
Q23
static void Main(string[] args)
    {
        Console.Write("enter the number1 :");
        int c = int.Parse(Console.ReadLine());
        Console.Write("enter the number2:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Checknum(c, n));
        Console.ReadLine();
    }
    static bool Checknum(int num1, int num2)
    {
        if (num1 < 0 && num2 < 0)
        {
            return false;
        }
        else
        {
            int lastdigit1 = (num1 % 10);
            int lastdigit2 = (num2 % 10);
            return lastdigit1 == lastdigit2;
        }

    }
-------------------------------------------------------------------------------------------
Q24
 static void Main(string[] args)
    {
        Console.Write("enter the word :");
        string word = Console.ReadLine();
        Console.WriteLine("convert the last 3 characters to uppercase");
        Console.WriteLine(Checkword(word));
        Console.ReadLine();
    }
    static string Checkword(string w)
    {
        if (w.Length - 1 <= 3)
        {
            return w.ToUpper();
        }
        else
        {
            string z = w.Substring(w.Length - 3, 3).ToUpper();
            return w.Substring(0, w.Length - 3) + z;
        }
    }
-------------------------------------------------------------------------------------------
Q25
static void Main(string[] args)
    {
        Console.Write("enter the word :");
        string word = Console.ReadLine();
        Console.Write("number of copies string : ");
        int times = int.Parse(Console.ReadLine());
        Checkword(word, times);
        Console.ReadLine();
    }
    static void Checkword(string w, int t)
    {
        for (int i = 0; i < t; i++)
        {
            Console.Write(w);
        }
    }
-------------------------------------------------------------------------------------------
Q1
static void Main(string[] args)
    {
        Console.Write("enter the nmber1 :");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("enter the number2 : ");
        int num2 = int.Parse(Console.ReadLine());
        if (num1 == num2)
        {
            Console.WriteLine(num1 + " and " + num2 + " are equal");
        }
        else
        {
            Console.WriteLine(num1 + " and " + num2 + " are not equal");
        }
        Console.ReadLine();
    }
------------------------------------------------------------------------------------------
Q2
static void Main(string[] args)
    {
        Console.Write("enter the nmber :");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine(num + " is an even number");
        }
        else
        {
            Console.WriteLine(num + " is an odd number");
        }
        Console.ReadLine();
    }
-------------------------------------------------------------------------------------------
Q3
static void Main(string[] args)
    {
        Console.Write("enter the nmber :");
        int num = int.Parse(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine(num + " is an negative number");
        }
        else
        {
            Console.WriteLine(num + " is an positive number");
        }
        Console.ReadLine();
    }
-------------------------------------------------------------------------------------------
Q4
static void Main(string[] args)
    {
        Console.Write("enter the year :");
        int num = int.Parse(Console.ReadLine());
        if (num % 4 == 0)
        {
            if (num % 100 == 0 && num % 400 != 0)
            {
                Console.WriteLine(num + " is an not leap year");
            }

            Console.WriteLine(num + " is an leap year");
            Console.ReadLine();
        }
    }
-------------------------------------------------------------------------------------------
Q5
static void Main(string[] args)
    {
        Console.Write("test data :");
        int num = int.Parse(Console.ReadLine());
        if (num <= 18)
        {
            Console.WriteLine("Congratulation! You are eligible for casting your vote.");
        }
        else
        {
            Console.WriteLine(" You are not eligible for casting your vote.");

        }
        Console.ReadLine();

    }
-------------------------------------------------------------------------------------------
Q6
static void Main(string[] args)
    {
        Console.Write("test data :");
        int num = int.Parse(Console.ReadLine());
        if (num < 0)
        {
            Console.WriteLine("The value of n=-1");
        }
        else if (num > 0)
        {

            Console.WriteLine(" The value of n=1");

        }
        else
        {
            Console.WriteLine(" The value of n=0");
        }
        Console.ReadLine();

    }
-------------------------------------------------------------------------------------------
Q7
static void Main(string[] args)
    {
        Console.Write("test data :");
        int num = int.Parse(Console.ReadLine());
        if (num < 150)
        {
            Console.WriteLine("The person is Dwarf");
        }
        else if (num > 150 && num < 170)
        {

            Console.WriteLine(" The person is averige");

        }
        else
        {
            Console.WriteLine(" The person is tall ");
        }
        Console.ReadLine();
    }
-------------------------------------------------------------------------------------------
Q8
static void Main(string[] args)
    {
        Console.Write("Input the 1st number");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Input the 2nd number");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Input the 3nd number");
        int num3 = int.Parse(Console.ReadLine());
        int z = Math.Max(num1, num2);
        Console.WriteLine(Math.Max(z, num3) + " Number is the greatest among three");
        Console.ReadLine();
    }
-------------------------------------------------------------------------------------------
Q9
static void Main(string[] args)
    {
        Console.Write("Input the value for X coordinate");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Input the value for X coordinate");
        int num2 = int.Parse(Console.ReadLine());
        if (num1 > 0 && num2 > 0)
        {
            Console.WriteLine("The coordinate point(" + num1 + "," + num2 + ") lies in the First quadrant");
        }
        else if (num1 < 0 && num2 > 0)
        {
            Console.WriteLine("The coordinate point(" + num1 + "," + num2 + ") lies in the second quadrant");
        }
        else if (num1 < 0 && num2 < 0)
        {
            Console.WriteLine("The coordinate point(" + num1 + "," + num2 + ") lies in the thired quadrant");
        }
        else
        {
            Console.WriteLine("The coordinate point(" + num1 + "," + num2 + ") lies in the forth quadrant");
        }
        Console.ReadLine();
    }
------------------------------------------------------------------------------------------
Q10
 static void Main(string[] args)
    {
        Console.Write("Marks in Maths");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Marks in Phy");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Marks in Chem");
        int num3 = int.Parse(Console.ReadLine());
        if (num1 >= 65 && num2 >= 55 && num3 >= 50)
        {
            int total = num1 + num2 + num3;
            if (total >= 180)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission")
            }
        }
        Console.ReadLine();
    }
-------------------------------------------------------------------------------------------
Q11
    internal class Program
    {
        static void adds(int x, int y, int z)
        {
            double a = y * y - 4 * x * z;
            if (a < 0)
            {
                Console.WriteLine("the root are imaginary");
            }
            else if (a == 0)
            {
                double root = -y / (2 * a);
                Console.WriteLine($"the root is {root}");
            }
            else
            {
                a = Math.Sqrt(a);
                double r1 = (-y + a) / (2 * a);
                double r2 = (-y - a) / (2 * a);
                Console.WriteLine($"root1:{r1}");
                Console.WriteLine($"root2:{r2}");
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a");
            // string x = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter c");
            int z = int.Parse(Console.ReadLine());
            adds(x, y, z);

        }
    }
-------------------------------------------------------------------------------------------
Q12
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the Roll Number of the student");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Name of the Student");
            string num2 = Console.ReadLine();
            Console.Write("Input the marks of Physics ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Input the marks of Chemistry ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Input the marks of Computer Application ");
            int n3 = int.Parse(Console.ReadLine());
            int total = n1 + n2 + n3;
            Console.WriteLine("Roll NUM" + num1);
            Console.WriteLine("Name of Student " + num2);
            Console.WriteLine("Marks in Physics " + n1);
            Console.WriteLine("Marks in Chemistry " + n2);
            Console.WriteLine("Marks in Computer Application " + n3);
            Console.WriteLine("Total Marks =" + total);
            int z = total / 3;
            Console.WriteLine("Percentage = " + total / 3);
            if (z > 80) Console.WriteLine("Division = first");
            else if (z < 80 && z > 50) Console.WriteLine("Division = pass");
            else Console.WriteLine("Division = didnot pass");
            Console.ReadLine();
        }
    }
-------------------------------------------------------------------------------------------
Q13
    internal class Program
    {
        static string adds(int x)
        {

            if (x < 0)
            {
                return "Freezing weather";
            }
            else if (x >= 0 && x <= 10)
            {
                return "Very Cold weather";
            }
            else if (x > 10 && x <= 20)
            {
                return "Cold weather";
            }
            else if (x > 20 && x <= 30)
            {
                return "Normal in Temp";
            }
            else if (x > 30 && x <= 40)
            {
                return "Its Hot";
            }
            else // temperature > 40
            {
                return "Its Very Hot";
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the weather");
            // string x = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            // Console.WriteLine("enter b");
            // int y =int.Parse(Console.ReadLine());
            // Console.WriteLine("enter c");
            //int z =int.Parse(Console.ReadLine());
            Console.WriteLine(adds(x));

        }
    }
-------------------------------------------------------------------------------------------
Q14
static void Main(string[] args)
    {
        Console.Write("enter to check whether a triangle is Equilateral, Isosceles or Scalene.");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        if (num1 == num2 && num1 != num3)
        {
            Console.Write("This is an isosceles triangle");
        }
        else if (num1 == num2 && num1 == num3)
        {
            Console.Write("This is an Equilateral triangle");
        }
        else
        {
            Console.Write("This is an Scalene triangle");
        }
        Console.ReadLine();
    }
-------------------------------------------------------------------------------------------
Q15
static void Main(string[] args)
    {
        Console.Write("Enter angle 1 (degrees): ");
        int angle1 = int.Parse(Console.ReadLine());
        Console.Write("Enter angle 2 (degrees): ");
        int angle2 = int.Parse(Console.ReadLine());
        Console.Write("Enter angle 3 (degrees): ");
        int angle3 = int.Parse(Console.ReadLine());
        if (angle1 <= 0  angle2 <= 0  angle3 <= 0)
        {
            Console.Write("Angles cannot be zero or negative");
        }
        else if (angle3 + angle2 + angle1 == 180)
            Console.Write("The triangle is valid.");
        else
        {
            Console.WriteLine("The triangle is not valid.");
        }

        Console.ReadLine();
    }
}
-------------------------------------------------------------------------------------------
 Q16
static string adds(char x)
{
    x = char.ToLower(x);
    if (x == 'a' || x == 'e' || x == 'o' || x == 'u' || x == 'i')
    {
        return "the alphabet is a consonat";
    }
    else
        return "its not consonat";
}

static void Main(string[] args)
{
    Console.WriteLine("enter the letter");
    char x = char.Parse(Console.ReadLine());
    //int x =int.Parse(Console.ReadLine());
    // Console.WriteLine("enter b");
    // int y =int.Parse(Console.ReadLine());
    // Console.WriteLine("enter c");
    //int z =int.Parse(Console.ReadLine());
    Console.WriteLine(adds(x));

}
    }
}
-------------------------------------------------------------------------------------------
Q17
static string adds(int x, int y)
{
    if (x > y)
    {
        int r = x - y;
        return "your loss is : " + r;
    }
    else
    {
        int r = y - x;
        return "your win is : " + r;
    }
}

static void Main(string[] args)
{
    Console.WriteLine("enter the inital value");
    //char x =char.Parse(Console.ReadLine());
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("enter the final value");
    int y = int.Parse(Console.ReadLine());
    // Console.WriteLine("enter c");
    //int z =int.Parse(Console.ReadLine());
    Console.WriteLine(adds(x, y));

}
    }
-------------------------------------------------------------------------------------------
Q18
    static void Main(string[] args)
{
    Console.Write("ID:");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name:");
    string name = Console.ReadLine();
    Console.Write("unit");
    int unit = int.Parse(Console.ReadLine());
    Console.WriteLine("Customer IDNO :" + id);
    Console.WriteLine("Customer Name :" + name);
    Console.WriteLine("unit Consumed :" + unit);
    double b;
    if (unit <= 199)
    {
        b = unit * 1.20;
        Console.WriteLine("Amount Charges @Rs.1.20 per unit :" + unit * 1.20);
    }
    else if (unit < 400 && unit > 200)
    {
        b = unit * 1.50;

        Console.WriteLine("Amount Charges @Rs.1.50 per unit :" + unit * 1.50);
    }
    else if (unit < 600 && unit >= 400)
    {
        b = unit * 1.80;

        Console.WriteLine("Amount Charges @Rs.1.80 per unit :" + unit * 1.80);
    }
    else
    {
        b = unit * 2.00;
        Console.WriteLine("Amount Charges @Rs.2.00 per unit :" + unit * 2.00);
    }
    double surcharge = b > 400 ? b * 0.15 : 0;
    double finalBillAmount = Math.Max(b + surcharge, 100); // Minimum bill of Rs. 100
    Console.WriteLine("Surchage Amount :" + surcharge);
    Console.WriteLine("Net Amount Paid By the Customer :" + finalBillAmount);
    Console.ReadLine();
}
}
-------------------------------------------------------------------------------------------
Q19
        static void Main(string[] args)
{
    Console.WriteLine("enter the inital value");
    //char x =char.Parse(Console.ReadLine());
    char x = char.Parse(Console.ReadLine());
    //Console.WriteLine("enter the final value");
    // int y =int.Parse(Console.ReadLine());
    // Console.WriteLine("enter c");
    //int z =int.Parse(Console.ReadLine());
    x = char.ToUpper(x);
    switch (x)
    {
        case 'A':
            Console.WriteLine("you have chosen average");
            break;
        case 'E':
            Console.WriteLine("You have chosen excellent");
            break;
        case 'V':
            Console.WriteLine("You have chosen very good");
            break;

    }

}
    }
-------------------------------------------------------------------------------------------
Q20
static void Main(string[] args)
{
    Console.WriteLine("enter the day number");
    //char x =char.Parse(Console.ReadLine());
    int x = int.Parse(Console.ReadLine());
    //Console.WriteLine("enter the final value");
    // int y =int.Parse(Console.ReadLine());
    // Console.WriteLine("enter c");
    //int z =int.Parse(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine("monday");
            break;
        case 2:
            Console.WriteLine("tuesday");
            break;
        case 3:
            Console.WriteLine("wednesday");
            break;
        case 4:
            Console.WriteLine("thursday");
            break;
        case 5:
            Console.WriteLine("friday");
            break;
        case 6:
            Console.WriteLine("saturday");
            break;
        case 7:
            Console.WriteLine("sunday");
            break;


    }

}
    }
-------------------------------------------------------------------------------------------
Q21
static void Main(string[] args)
{
    Console.WriteLine("enter the day number");
    //char x =char.Parse(Console.ReadLine());
    int x = int.Parse(Console.ReadLine());
    //Console.WriteLine("enter the final value");
    // int y =int.Parse(Console.ReadLine());
    // Console.WriteLine("enter c");
    //int z =int.Parse(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine("one");
            break;
        case 2:
            Console.WriteLine("two");
            break;
        case 3:
            Console.WriteLine("three");
            break;
        case 4:
            Console.WriteLine("four");
            break;
        case 5:
            Console.WriteLine("five");
            break;
        case 6:
            Console.WriteLine("six");
            break;
        case 7:
            Console.WriteLine("seven");
            break;
        case 8:
            Console.WriteLine("eight");
            break;
        case 9:
            Console.WriteLine("nine");
            break;
        case 0:
            Console.WriteLine("zero");
            break;


    }

}
    }
-------------------------------------------------------------------------------------------
Q22
static void Main(string[] args)
{
    Console.WriteLine("enter the month number");
    //char x =char.Parse(Console.ReadLine());
    int x = int.Parse(Console.ReadLine());
    //Console.WriteLine("enter the final value");
    // int y =int.Parse(Console.ReadLine());
    // Console.WriteLine("enter c");
    //int z =int.Parse(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine(" January");
            break;
        case 2:
            Console.WriteLine("feb");
            break;
        case 3:
            Console.WriteLine("march");
            break;
        case 4:
            Console.WriteLine("april");
            break;
        case 5:
            Console.WriteLine("may");
            break;
        case 6:
            Console.WriteLine("june");
            break;
        case 7:
            Console.WriteLine("july");
            break;
        case 8:
            Console.WriteLine("august");
            break;
        case 9:
            Console.WriteLine("septem");
            break;
        case 10:
            Console.WriteLine("october");
            break;
        case 11:
            Console.WriteLine("november");
            break;
        case 12:
            Console.WriteLine("december");
            break;


    }

}
    }
-------------------------------------------------------------------------------------------
Q23
static void Main(string[] args)
{
    Console.WriteLine("enter the month number");
    //char x =char.Parse(Console.ReadLine());
    int x = int.Parse(Console.ReadLine());
    //Console.WriteLine("enter the final value");
    // int y =int.Parse(Console.ReadLine());
    // Console.WriteLine("enter c");
    //int z =int.Parse(Console.ReadLine());
    switch (x)
    {
        case 1:
            Console.WriteLine(" January has 31");
            break;
        case 2:
            Console.WriteLine("feb has 28 or 29");
            break;
        case 3:
            Console.WriteLine("march has 31 days");
            break;
        case 4:
            Console.WriteLine("april has 30 days");
            break;
        case 5:
            Console.WriteLine("may has 31 days");
            break;
        case 6:
            Console.WriteLine("june has 30 days");
            break;
        case 7:
            Console.WriteLine("july has 31 days");
            break;
        case 8:
            Console.WriteLine("august has 31 days");
            break;
        case 9:
            Console.WriteLine("septem has 30 days");
            break;
        case 10:
            Console.WriteLine("october has 31 days");
            break;
        case 11:
            Console.WriteLine("november has 30 days ");
            break;
        case 12:
            Console.WriteLine("december has 31 days");
            break;


    }

}
    }
-------------------------------------------------------------------------------------------
Q24
static void Main(string[] args)
{
    while (true)
    {
        // Display menu
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Square");
        Console.WriteLine("4. Exit");
        Console.Write("Input your choice: ");

        // Read user's choice
        int choice = int.Parse(Console.ReadLine());

        // Calculate area based on user's choice
        switch (choice)
        {
            case 1: // Circle
                Console.Write("Input radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * radius * radius;
                Console.WriteLine($"The area is: {circleArea}");
                break;
            case 2: // Rectangle
                Console.Write("Input length of the rectangle: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Input width of the rectangle: ");
                double width = double.Parse(Console.ReadLine());
                double rectangleArea = length * width;
                Console.WriteLine($"The area is: {rectangleArea}");
                break;
            case 3: // Square
                Console.Write("Input side length of the square: ");
                double sideLength = double.Parse(Console.ReadLine());
                double squareArea = sideLength * sideLength;
                Console.WriteLine($"The area is: {squareArea}");
                break;
            case 4: // Exit
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter a valid option.");
                break;
        }
    }
}
        }
 -----------------------------------------------------------------------------------------
Q1
    internal class Program
{
    static int adds(int x)
    {
        int y = x - 51;
        if (y > 51)
        {

            return (y * 3);
        }
        else
        {
            return y;
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter a numner        ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine(adds(x));
    }
}
    }
-------------------------------------------------------------------------------------------
 Q2
        static void Main(string[] args)
{
    Console.WriteLine("enter a string");
    string x = Console.ReadLine();
    int y = x.Length;

    Console.WriteLine($"length of the string is {y}");
}
-------------------------------------------------------------------------------------------
Q3
        static void Main(string[] args)
{
    Console.WriteLine("enter a string");
    string x = Console.ReadLine();
    int y = x.Length;

    for (int i = 0; i < y; i++)
    {
        Console.WriteLine(x[i]);
    }



}
-------------------------------------------------------------------------------------------
Q4
        static void Main(string[] args)
{
    Console.WriteLine("enter a string");
    string x = Console.ReadLine();
    int y = x.Length;

    for (int i = y - 1; i >= 0; i--)
    {
        Console.WriteLine(x[i]);
    }
}
-----------------------------------------------------------------------------------------
Q5
        static void Main(string[] args)
{
    Console.WriteLine("enter a string");
    string x = Console.ReadLine();

    string[] words = x.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    int y = words.Length;
    Console.WriteLine(y);
}
    }
-------------------------------------------------------------------------------------------
Q6
        static void Main(string[] args)
{
    Console.WriteLine("enter a string");
    string x = Console.ReadLine();
    Console.WriteLine("enter another string");
    string y = Console.ReadLine();
    int a = x.Length;
    int b = y.Length;
    if (x == y)
    {
        Console.WriteLine("thength of both are equal and also both string are equal");

    }
    else
    {
        Console.WriteLine("is not equal");

    }
}

    }
}
