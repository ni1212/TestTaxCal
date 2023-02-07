
var text = " a fgfd df ";
Console.WriteLine($"{AR.Emp2(text, 2)}:");
Console.WriteLine(AR.EmpCount(text,2));
var chars=new char[text.Length];
for (int i = 0;i< chars.Length; i++)
{
    chars[i] = text[i];
}


ChangeSpace(chars);
static void ChangeSpace(params char[] chars)
{
    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i] == ' ')
        {
            ShiftArray(chars, i, 2);
            chars[i++] = '%';
            chars[i++] = '2';
            chars[i] = '0';     // ここはi++ではない。
        }
    }
    foreach (var item in chars)
    {
        Console.Write(item);
    }
}
static void ShiftArray(char[] chars, int start, int count)
{
    for (int i = chars.Length - 1 - count; start <= i; i--)
    {
        chars[i + count] = chars[i];
    }
}

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