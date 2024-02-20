public class Vehiculo
{
    public string marca { get; set; }

    public void Arrancar()
    {
        Console.WriteLine(marca + " está arrancando.");
    }
}

public class Coche : Vehiculo
{
    public void TocarBocina()
    {
        Console.WriteLine(marca + " está tocando la bocina.");
    }
}

public class Motocicleta : Vehiculo
{
    public void Acelerar()
    {
        Console.WriteLine(marca + " está acelerando.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Coche miCoche = new Coche();
        miCoche.marca = "Toyota";
        miCoche.Arrancar();
        miCoche.TocarBocina();

        Motocicleta miMoto = new Motocicleta();
        miMoto.marca = "Honda";
        miMoto.Arrancar();
        miMoto.Acelerar();
    }
}

