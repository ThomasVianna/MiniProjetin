using System;

public class Animal
{
    private string nome;
    private int idade;
    private double peso;
    public Guid IdUnico { get; private set; }

    public string Nome
    {
        get => nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome não pode ser vazio");
            nome = value;
        }
    }
    public int Idade
    {
        get => idade;
        set
        {
            if (value < 0)
                throw new ArgumentException("A idade não pode ser negativa");
            idade = value;
        }
    }

    public double Peso
    {
        get => peso;
        set
        {
            if (value <= 0)
                throw new ArgumentException("O peso deve ser maior que zero");
            peso = value;
        }
    }

    public Animal(string nome, int idade, double peso)
    {
        IdUnico = Guid.NewGuid();
        Nome = nome;
        Idade = idade;
        Peso = peso;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som do animal:");
    }
    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"IdUnico: {IdUnico}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"Peso: {Peso} Kg");
    }
    public virtual int CalcularIdadeHumana()
    {
        return Idade;
    }

    public override string ToString()
    {
        return $"IdUnico: {IdUnico}\nNome: {Nome}\nIdade: {Idade} anos\nPeso: {Peso} Kg";
    }
}