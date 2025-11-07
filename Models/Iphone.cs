
using DesafioPOO.Models;
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

         public Iphone(string numero ,string modelo , string gmail, int memoria ) : base(numero, modelo, gmail, memoria)    
    {
           
            
    }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone...");
        }   
    }
}