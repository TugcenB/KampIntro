using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        CustomerManager manager = new CustomerManager();
        //manager.SendMessage();
        MyDelegate myDelegate = manager.SendMessage;
        myDelegate += manager.SendMessage;
        myDelegate();

        MyDelegate2 myDelegate2 = manager.SendMessage2;
        myDelegate2("Hello");
        Matematik matematik = new Matematik();
        MyDelegate3 myDelegate3 = matematik.Topla;
        Console.WriteLine(myDelegate3(2,3));
        myDelegate3 += matematik.Topla;
        Console.WriteLine(myDelegate3(5,5));

        Func<int, int, int> add = matematik.Topla;
        Console.WriteLine(add(3,5));
        Func<int> getRandomNumber = delegate ()
        {
            Random rand = new Random();
            return rand.Next(1,100);
        };
        Console.WriteLine(getRandomNumber);
        Thread.Sleep(1000);
        Func<int> getRandomNumber2 = () => new Random().Next(1,100);
        Console.WriteLine(getRandomNumber2);
    }
}
public delegate void MyDelegate();
public delegate void MyDelegate2(string text);
public delegate int MyDelegate3(int number1, int number2);
//return döndüren delegeler son girilen sonucu verir.

public class CustomerManager
{
    public void SendMessage()
    {
        Console.WriteLine("Hello!");
    }
    public void ShowAlert()
    {
        Console.WriteLine("Be Careful!");
    }
    public void SendMessage2(string message)
    {
        Console.WriteLine(message);
    }
    public void ShowAlert2(string alert)
    {
        Console.WriteLine(alert);
    }
}
public class Matematik
{
    public int Topla(int sayi1,int sayi2)
    {
        return sayi1 + sayi2;
    }
}