public class PetShop
{
    private List<Animal> animais;

    public PetShop()
    {
        animais = new List<Animal>();
    }
    public void AdicionarAnimal(Animal animail)
    {
        animais.Add(animail);
    }
    public void listarAnimais()
    {
        foreach (var animail in animais)
        {
            animail.ExibirInformacoes();
            animail.EmitirSom();
            Console.WriteLine();
        }
    }
}