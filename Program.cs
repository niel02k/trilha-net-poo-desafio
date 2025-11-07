using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Smartphone Nokia: ");    
            Nokia nokia = new Nokia("123456789" , "Nokia 3310",  "nokia123@gmail.com ",  16 );
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");
 

           Console.WriteLine("\n");

            Console.WriteLine("Smartphone Iphone:");   
            Iphone iphone = new Iphone("987654321" , "Iphone 13",  "Iphon123@gmail.com  ", 128 );
            iphone.Ligar();
            iphone.InstalarAplicativo("Instagram"); 

        
        }
    }
}