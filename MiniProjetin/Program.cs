/*Projeto: Sistema de Cadastro de Animais de Estimação (C#)
Descrição:
Você deverá criar um programa orientado a objetos que permita cadastrar, listar e exibir informações de animais de estimação.
O sistema deve trabalhar com pelo menos dois tipos diferentes de animais (Cachorro e Gato) e aplicar herança para aproveitar código em comum.

Requisitos:
Classe Base (Animal)

Atributos (privados):

Nome (string)

Idade (int)

Métodos:

EmitirSom() → imprime no console um som genérico de animal.

ExibirInformacoes() → imprime no console o nome e a idade do animal.

Criar construtor para inicializar nome e idade.

Usar properties (get/set) para acessar os atributos.

Classes Derivadas (Cachorro e Gato)

Devem herdar de Animal.

Sobrescrever (override) o método EmitirSom():

Cachorro → "Au Au"

Gato → "Miau"

Classe PetShop

Deve ter uma lista para armazenar objetos do tipo Animal.

Métodos:

AdicionarAnimal(Animal animal) → adiciona à lista.

ListarAnimais() → percorre a lista e chama ExibirInformacoes() e EmitirSom() de cada animal.

Classe Program (método Main)

Criar alguns objetos de Cachorro e Gato.

Adicionar ao PetShop.

Listar todos os animais.

Objetivos de Aprendizado:
Encapsulamento: uso de atributos privados com getters/setters.

Herança: reaproveitamento de código entre classes.

Polimorfismo: sobrescrita de métodos.

Composição: PetShop contendo lista de Animal.*/


internal class Program
{
    private static void Main(string[] args)
    {
        PetShop petshop = new PetShop();
        Cachorro cachorro = new Cachorro();
        Gato gato = new Gato();

        cachorro.CriarAnimal("Thor", 10);

        petshop.AdicionarAnimal(cachorro);

    }
}