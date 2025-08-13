/*Projeto: Sistema Avançado de Gerenciamento de Animais de Estimação (C#)
Descrição:
Você deverá criar um sistema orientado a objetos que permita cadastrar, buscar, remover, e listar informações de animais de estimação com persistência de dados em arquivo.
O sistema deve trabalhar com pelo menos três tipos diferentes de animais e aplicar herança, polimorfismo, interfaces e exceções personalizadas.

Requisitos:
1. Classe Base (Animal)
Atributos privados:

Nome (string)

Idade (int)

Peso (double)

ID único (Guid)

Métodos:

EmitirSom() → som genérico de animal.

ExibirInformacoes() → imprime nome, idade, peso e ID.

CalcularIdadeHumana() → retorna idade equivalente em anos humanos (diferente para cada animal, será sobrescrito).

Regras:

Criar construtor com parâmetros para inicializar todos os atributos (menos o ID, que deve ser gerado automaticamente).

Usar properties com validação (ex.: idade não pode ser negativa, nome não pode ser vazio).

Criar um método ToString() que retorne uma string formatada com as informações do animal.

2. Classes Derivadas
Cachorro:

EmitirSom() → "Au Au".

CalcularIdadeHumana() → idade × 7.

Gato:

EmitirSom() → "Miau".

CalcularIdadeHumana() → idade × 6.

Pássaro:

EmitirSom() → "Piu Piu".

CalcularIdadeHumana() → idade × 4.

3. Interface IAnimalComportamento
Métodos:

Comer()

Brincar()

Cada animal deve implementar esses métodos com mensagens personalizadas.

4. Classe PetShop
Atributos:

Lista de Animal.

Métodos:

AdicionarAnimal(Animal animal)

Não permitir cadastro de dois animais com o mesmo nome e espécie.

RemoverAnimalPorID(Guid id)

BuscarPorNome(string nome)

ListarAnimais()

SalvarEmArquivo(string caminho) → salva lista em formato texto.

CarregarDeArquivo(string caminho) → carrega lista do arquivo.

Regra extra:

Se tentar remover ou buscar um animal inexistente, lançar uma exceção personalizada (AnimalNaoEncontradoException).

5. Classe Program
Menu interativo:

1 – Adicionar Animal

2 – Remover Animal

3 – Buscar Animal

4 – Listar Animais

5 – Salvar no Arquivo

6 – Carregar do Arquivo

0 – Sair

Criar alguns objetos iniciais para testes.

Objetivos de Aprendizado Avançados
Encapsulamento: atributos privados com validação nas properties.

Herança: reaproveitamento de código na classe base.

Polimorfismo: sobrescrita de métodos e uso de interface.

Composição: PetShop contendo lista de Animal.

Tratamento de Exceções: criar e lançar exceções personalizadas.

Persistência de Dados: salvar e carregar lista de animais e*/