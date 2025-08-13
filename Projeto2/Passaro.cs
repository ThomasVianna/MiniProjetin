using System;

public class Passaro : Animal, IAnimalComportamento
{
    public Passaro(string nome, int idade, double peso) : base(nome, idade, peso)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Piu! Piu!");
    }

    public override int CalcularIdadeHumana()
    {
        return Idade * 4;
    }

    public void Comer()
    {
        Console.WriteLine("Pássaro gosta de comer alpiste");
    }

    public void Brincar()
    {
        Console.WriteLine("Pássaro gosta de voar ao ar livre");
    }
}