using System;

public class Cachorro : Animal, IAnimalComportamento
{
    public Cachorro(string nome, int idade, double peso) : base(nome, idade, peso)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Au! Au!");
    }

    public override int CalcularIdadeHumana()
    {
        return Idade * 7;
    }

    public void Comer()
    {
        Console.WriteLine("Cachorro gosta de comer ração e carne");
    }

    public void Brincar()
    {
        Console.WriteLine("Cachorro gosta de brincar com bolinhas");
    }
}