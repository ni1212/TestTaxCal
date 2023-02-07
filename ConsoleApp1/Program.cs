
using System.Security.Cryptography.X509Certificates;

var text = " a fgfd df ";
Console.WriteLine($"{AR.Emp2(text, 2)}:");
Console.WriteLine(AR.EmpCount(text,2));
var chars=new char[text.Length];
for (int i = 0;i< chars.Length; i++)
{
    chars[i] = text[i];
}

int[] s = { 1, 2, 2, 2, 2, 3, 1 };
var linked = new LinkedList<int>(s);
linkList(linked);


foreach (var c in linked)
{
    Console.Write(c);
}

static void linkList(LinkedList<int> ints) => ints.Distinct();


class AR
{
    public static string Emp(string text,int count) => text.Replace(" ", "%20");


    public static string AddEmp(string str,int cou)
    {
        for (int i = 0; i < cou; i++)
        {
            str += " ";
        }
        return str;
    }
    public static string Emp2(string text,int count)
    {
        string str = null;
        foreach (var c in text)
        {
            if (c == ' ')
            {
                str += "%20";
            }
            else
            {
                str += c;
            }
            
        }

        return AddEmp(str, count);
    }
    public static int EmpCount(string text,int cou)
    {
        int count = 0;

        foreach (var c in Emp2(text,cou))
        {
            if(char.IsWhiteSpace(c))count++;
        }
        return Emp2(text,cou).Length - count;
    }
}
