using System;

public class Gato : Animal, IAnimalComportamento
{
    public Gato(string nome, int idade, double peso) : base(nome, idade, peso)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("Miau! Miau!");
    }

    public override int CalcularIdadeHumana()
    {
        return Idade * 6;
    }

    public void Comer()
    {
        Console.WriteLine("Gato gosta de beber leite");
    }

    public void Brincar()
    {
        Console.WriteLine("Gato gosta de brincar com bolinhas");
    }
}