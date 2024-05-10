using dio_bootcamp.Common.models;



int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

// Copia de um array para outro
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);



// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


Console.WriteLine("Percorrendo o Array com o FOR");
for (int i = 0; i < arrayInteiros.Length; i++) {
    Console.WriteLine($"Posição n. {i} - {arrayInteiros[i]}");
}



// Console.WriteLine("Percorrendo o Array com o FOREACH");
// int contadorForeach = 0;
// foreach (int valor in arrayInteiros) {
//     Console.WriteLine($"Posição n. {contadorForeach} - {valor}");
//     contadorForeach++;
// }



// Pessoa pessoa = new Pessoa();

// pessoa.Nome = "Yan";
// pessoa.Idade = 20;
// pessoa.Apresentar();


// string opcao = "0";
// bool exibirMenu = true;

// while (exibirMenu) {

//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao) {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Buscar de cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             // Environment.Exit(0);
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou");



// int soma = 0, numero = 0;

// do {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números é {soma}");




// int numero = 5;
// int contador = 1; 


// while (contador <= 10) {
//     Console.WriteLine($"{contador} Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if( contador == 6) {
//         break;
//     }
// }





// int numero = 5;

//  for(int contador = 0; contador <= 10; contador++) {
//     Console.WriteLine($"{contador} x {numero} =  {numero * contador}");
//  }



// Calculadora calc = new Calculadora(); 

// calc.RaizQuadrada(9);



// int numeroIncremento = 10;


// Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);


// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;


// Console.WriteLine(numeroDecremento);





// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);

// calc.Potencia(3, 3);

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