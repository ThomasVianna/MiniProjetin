using System.Runtime.InteropServices.Marshalling;

public class Animal
{
    private string Nome { get; set; }
    private int Idade { get; set; }

    public void CriarAnimal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal");
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos");
    }
}
