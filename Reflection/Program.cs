using System.Reflection;

public class Program
{
    private static void Main(string[] args)
    {
        //DortIslem dortIslem = new DortIslem(2,3);
        //Console.WriteLine(dortIslem.Add2());
        var type = typeof(DortIslem);
        var dortIslem=(DortIslem)Activator.CreateInstance(type,6,7);
        Console.WriteLine(dortIslem.Add(1,2));

        var instance = Activator.CreateInstance(type, 6, 7);
        MethodInfo methodInfo = instance.GetType().GetMethod("Add2");
        var result=methodInfo.Invoke(instance,null);
        Console.WriteLine(result);

        var metodlar = type.GetMethods();
        foreach (var info in metodlar)
        {
            Console.WriteLine("Metod Adı: "+info.Name);
            foreach (var parameterInfo in info.GetParameters())
            {
                Console.WriteLine(parameterInfo.Name);
            }
            foreach (var attribute in info.GetCustomAttributes())
            {
                Console.WriteLine("Attribute Name: "+attribute.GetType().Name);
            }
        }
        Console.ReadLine();
        
    }
}
public class DortIslem
{
    private int _sayi1;
    private int _sayi2;

    public DortIslem(int sayi1, int sayi2)
    {
        _sayi1 = sayi1;
        _sayi2 = sayi2;
    }

    public int Add(int sayi1, int sayi2)
    {
        return sayi1+sayi2;
    }
    public int Carp(int sayi1, int sayi2)
    {
        return sayi1*sayi2;
    }
    public int Add2()
    {
        return _sayi1+_sayi2;
    }
    [MethodName("Carpma")]
    public int Carp2()
    {
        return _sayi1*_sayi2;
    }
}
public class MethodNameAttribute : Attribute
{
    public MethodNameAttribute(string name)
    {

    }
}