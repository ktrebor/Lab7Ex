using System;

// Interfața pentru plățile contact-full
public interface IPlataContactFull
{
    void Introduce();
    void EfectueazaPlata(double suma);
    void Extrage();
}

// Interfața pentru plățile contactless
public interface IPlataContactless
{
    void Apropie();
    void EfectueazaPlata(double suma);
}

// Interfață pentru dispozitivul POS
public interface IPosDevice
{
    void AcceptaPlata(IPlataContactFull card);
    void AcceptaPlata(IPlataContactless card);
}

// Clasa pentru cardurile clasice
public class CardClasic : IPlataContactFull
{
    public void Introduce()
    {
        Console.WriteLine("Introduceți cardul clasic.");
    }

    public void EfectueazaPlata(double suma)
    {
        Console.WriteLine($"Plata contact-full în valoare de {suma} RON a fost efectuată cu succes.");
    }

    public void Extrage()
    {
        Console.WriteLine("Extrageți cardul clasic.");
    }
}

// Clasa pentru cardurile contactless
public class CardContactless : IPlataContactFull, IPlataContactless
{
    public void Introduce()
    {
        Console.WriteLine("Apropiați cardul contactless.");
    }

    public void EfectueazaPlata(double suma)
    {
        Console.WriteLine($"Plata în valoare de {suma} RON a fost efectuată cu succes.");
    }

    public void Extrage()
    {
        Console.WriteLine("Plata contact-full. Introduceți PIN-ul.");
    }

    // Metodele pentru plata contactless
    public void Apropie()
    {
        Console.WriteLine("Apropiați cardul/contactul mobil pentru plată contactless.");
    }
}

// Clasa pentru telefoanele mobile contactless
public class TelefonContactless : IPlataContactless
{
    public void Apropie()
    {
        Console.WriteLine("Apropiați telefonul mobil pentru plată contactless.");
    }

    public void EfectueazaPlata(double suma)
    {
        Console.WriteLine($"Plata contactless în valoare de {suma} RON a fost efectuată cu succes.");
    }
}

// Clasa POS
public class POS : IPosDevice
{
    public void AcceptaPlata(IPlataContactFull card)
    {
        card.Introduce();
        card.EfectueazaPlata(100.0); // Exemplu: plata de 100 RON
        card.Extrage();
    }

    public void AcceptaPlata(IPlataContactless card)
    {
        card.Apropie();
        card.EfectueazaPlata(150.0); // Exemplu: plata contactless de 150 RON
    }
}

class Program
{
    static void Main()
    {
        POS pos = new POS();

        CardClasic cardClasic = new CardClasic();
        CardContactless cardContactless = new CardContactless();
        TelefonContactless telefonContactless = new TelefonContactless();

        // Plata cu cardul clasic
        pos.AcceptaPlata(cardClasic);

        // Plata contactless cu cardul
        pos.AcceptaPlata(cardContactless);

        // Plata contactless cu telefonul mobil
        pos.AcceptaPlata(telefonContactless);

        Console.ReadKey();
    }
}
