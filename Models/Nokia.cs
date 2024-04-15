namespace DesafioPOO.Models
{
    // Herança implementada!
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo,imei, memoria)
        {

        }
        // Sobrescrita implementada!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo \"{nomeApp}\" foi instalado com sucesso em seu Nokia!");
        }
    }
}