// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Olá, mundo!");

// Seção 4.1:
// Exercício 1

string valor = null;
valor = valor?.Trim().ToUpper();
Console.WriteLine(valor);

int tamanho = (int?)pessoa?.Length;

// Seção 4.2
// Exercício 1

int i;
Console.WriteLine(i); // Dispara erro de variável local não atribuída.

// Exercício 2

const double c = 3.99792458E08; // Alteração feita por Silvana 
c = c + 2;  // Erro de build dizendo que o lado esquerdo deve conter uma variavel, propriedade ou indexador. Logo, constante não funciona.
Console.WriteLine(c);

// Exercício 3

char letra = 'A'; //alteração feita por Silvana 
letra++;
Console.WriteLine(letra); // O programa passa para o próximo caractere na tabela ascii