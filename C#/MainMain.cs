using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public enum ShippingMethod
{
    AirMail = 1,
    RegisterMail = 2,
    Express = 3
}
public class Temp
{
    public string firstName;
    public string lastName;
    public void TempHelp()
    {

    }
}
public class Temp1 : Temp
{
    public void help()
    {
        firstName = "hello";
        this.TempHelp();
    }

}

class MainMain
{
    static void Main(string[] args)
    {
        char[] t = new char[5] { 'a', 'b', 'c', 'd', 'e' };
        string str1 = new string(t);
        StringBuilder sb1 = new StringBuilder("Hello World");
        sb1.Remove(0, 1);
        sb1.Insert(0, 'a');
        Console.WriteLine(sb1);
        char tst = (char)('a' + 2);
        Console.Write(tst);
        double[] n1 = new double[] { 1.4f, 4 };
        //Console.WriteLine(n1);
        Temp t1 = new Temp { firstName = "f1", lastName = "f2" };
        var num = new[] { 4, 5 };
        Console.WriteLine(num[1]);
        StringBuilder sb = new StringBuilder();
        DateTime dt = DateTime.Now.AddDays(1);
        int[][] tmp = new int[3][];
        Console.WriteLine(dt);
        int n = 1;
        string name = "Test";
        name.Remove(2);
        Console.WriteLine(name);
        for (int i = 0; i < name.Length; i++)
            Console.WriteLine(name[i]);
        int[] narr = new int[3];
        Console.WriteLine(narr[2]);
        Temp temp = new Temp();
        Console.WriteLine(n);
        ShippingMethod sm = ShippingMethod.AirMail;
        Console.WriteLine(sm.ToString());
        string str = "Express";
        //var smethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), str);
        Console.WriteLine((ShippingMethod)n);
        try
        {
            string number = "1234";
            byte b = Convert.ToByte(number);
            Console.WriteLine(b);
        }
        catch (Exception)
        {
            Console.WriteLine("Not converted");
        }

        string dateString = "2017-08-18";
        DateTime dt11 = DateTime.ParseExact(dateString, "yyyy-MM-dd",
            CultureInfo.InvariantCulture);

        string str11 = dt11.ToString("MM/dd/yyyy");
        Console.WriteLine(str11);
        string longstr =
            "Albuterol\r\n  Dose Strength 0 (mcg) Prescribed No. Dose(s) AM  0,  Prescribed No. Dose(s) PM  0, As Needed\r\nStart  08 Sep 2017,  End  10 Sep 2017";
        string[] strarray = longstr.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);


    }
}

