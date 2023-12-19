using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Testando Nokia
        Nokia nokia = new Nokia("123456", "Nokia básico", "000000", 64);
        TestarSmartphone(nokia, "Youtube");

        // Testando Iphone
        Iphone iphone = new Iphone("789012", "iPhone XS", "010101", 64);
        TestarSmartphone(iphone, "Facebook");

    }

    // FUnção para testar TODAS as funções
    static void TestarSmartphone(Smartphone smartphone, string nomeApp)
    {
        Console.WriteLine($"Informações do smartphone - Modelo: {smartphone.Modelo}, Memória: {smartphone.Memoria}GB");
        smartphone.Ligar();
        smartphone.ReceberLigacao();
        smartphone.InstalarAplicativo(nomeApp);
        Console.WriteLine();
    }
}
