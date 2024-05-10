using dio_bootcamp.models;




Calculadora calc = new Calculadora();

calc.Potencia(3, 3);

// calc.Somar(10, 2);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

// bool choveu = true;
// bool estaTarde = true;

// if (!choveu && !estaTarde) {
//     Console.WriteLine("Vou pedalar");
// } else {
//     Console.WriteLine("Vou pedalar um outro dia");
// }



/* 
bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7) {
    Console.WriteLine("Aprovado");
} else {
    Console.WriteLine("Reprovado");
}
 */





/* 
bool ehMaiorDeIdade = true;
bool possuiAutorizacaoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoResponsavel) {
    Console.WriteLine("Entrada liberada!");
} else {
    Console.WriteLine("Entrada não liberada!");
}

 */



/* Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra) {
    case "a": 
    case "e": 
    case "i": 
    case "o": 
    case "u": 
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("Não é uma vogal");
        break;
}
 */


/* int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


if (quantidadeCompra == 0 ) {
    Console.WriteLine("Venda inválida");
} else if (possivelVenda) {
    Console.WriteLine("Venda realizada");
} else {
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}
 */




// string a = "15-";

// // int b = 0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");



// double a = 4 / (2 + 2);

// Console.WriteLine(a);

// int a = 5;
// double b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);


/* int inteiro = 5;
string a = inteiro.ToString();
Console.WriteLine(a);
 */

/* // Cast - Casting 
int a = Convert.ToInt32(null);    // Convert quando receber um valor nulo, ele converterá para 0. 
//int a = int.Parse("5c");
 
Console.WriteLine(a);

 */

/* DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

*/

/* Maneira alternativa 

dio_bootcamp.models.Pessoa p = new dio_bootcamp.models.Pessoa();

*/


/* string apresentacao = "Olá, seja bem vindo";

int quantidade = 1;

double altura = 1.80;

decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("valor da variável quantidade: " + quantidade);
Console.WriteLine("valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("valor da variável preco: " + preco);
Console.WriteLine("valor da variável condicao: " + condicao); */


/* Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Yan";
pessoa1.Idade = 27;
pessoa1.Apresentar();
 */