using DesafioPOO.Models;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia: ");
        Nokia nokia = new Nokia("999999999", "Modelo NokiaS", "123456", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Whatsapp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone: ");
        Iphone iphone = new Iphone("988888888", "Iphone 6S", "654321", 3);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

    }
}
