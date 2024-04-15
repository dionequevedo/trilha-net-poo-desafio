namespace DesafioPOO.Models
{
    // Herança implementada!
    public class Iphone : Smartphone
    {        
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo,imei, memoria)
        {

        }
        // Sobrescrita implementada!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo \"{nomeApp}\" foi instalado com sucesso no seu Iphone!");
        }
    }
}