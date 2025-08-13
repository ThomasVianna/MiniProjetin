using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class PetShop
{
    private List<Animal> animais;

    public PetShop()
    {
        animais = new List<Animal>();
    }

    public void AdicionarAnimal(Animal animal)
    {
        if (animais.Any(a => a.Nome.Equals(animal.Nome, StringComparison.OrdinalIgnoreCase)
                          && a.GetType() == animal.GetType()))
        {
            throw new Exception("Já existe um animal com esse nome e espécie cadastrado.");
        }
        animais.Add(animal);
    }

    public void RemoverAnimalPorID(Guid id)
    {
        var animal = animais.FirstOrDefault(a => a.IdUnico == id);
        if (animal == null)
            throw new AnimalNaoEncontradoException("Animal não encontrado para remoção.");
        animais.Remove(animal);
    }

    public void BuscarPorNome(string nome)
    {
        var encontrados = animais
            .Where(a => a.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (encontrados.Count == 0)
            throw new AnimalNaoEncontradoException("Animal não encontrado com esse nome.");

        foreach (var animal in encontrados)
        {
            Console.WriteLine($"Animal encontrado: {animal.Nome} ({animal.GetType().Name})");
        }
    }

    public void ListarAnimais()
    {
        if (animais.Count == 0)
        {
            Console.WriteLine("Nenhum animal cadastrado.");
            return;
        }

        foreach (var animal in animais)
        {
            Console.WriteLine($"ID: {animal.IdUnico} | Nome: {animal.Nome} | Espécie: {animal.GetType().Name}");
        }
    }

    public void SalvarEmArquivo(string caminho)
    {
        var linhas = animais
            .Select(a => $"{a.IdUnico};{a.Nome};{a.GetType().Name}")
            .ToList();

        File.WriteAllLines(caminho, linhas);
    }

    public void CarregarDeArquivo(string caminho)
    {
        if (!File.Exists(caminho))
            throw new FileNotFoundException("Arquivo não encontrado.");

        animais.Clear();
        var linhas = File.ReadAllLines(caminho);

        foreach (var linha in linhas)
        {
            var partes = linha.Split(';');
            if (partes.Length >= 3)
            {
                var id = Guid.Parse(partes[0]);
                var nome = partes[1];
                var especie = partes[2];

                // Aqui é só exemplo: você precisa mapear para a classe correta
                // Exemplo genérico (dependendo do seu código, substitua):
                // if (especie == "Cachorro") animais.Add(new Cachorro(nome) { IdUnico = id });
                // if (especie == "Gato") animais.Add(new Gato(nome) { IdUnico = id });
            }
        }
    }
}
