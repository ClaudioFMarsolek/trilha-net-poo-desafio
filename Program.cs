using DesafioPOO.Models;
namespace DesafioPOO{
    internal class Program{
        static void Main( string [] args){
            System.Console.WriteLine("Smartphone Nokia");
            Nokia nokia = new Nokia(numero: "999999", modelo: "Modelo 1", imei: "000000000", memoria: 32);
            nokia.Ligar();
            nokia.InstalarAplicativo("Bradesco Celular");

            System.Console.WriteLine("\n");

            System.Console.WriteLine("Smartphone Iphone");
            Iphone iphone = new Iphone(numero: "888888", modelo: "Modelo 2", imei: "111111111", memoria: 64);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}

