using dio_bootcamp.models;


DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


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