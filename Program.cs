using Bootcamp_.NET.Models;
using Fundamentos_.NET.Models;

Calculadora calc = new Calculadora();
calc.Somar(3, 4);
calc.Subtrair(5, 3);
calc.Mutiplicar(9, 5);
calc.Dividir(5, 2);
calc.Potencia(3, 3);

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch(letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é vogal");
//         break;
// }

// if(letra == "a"){
//     Console.WriteLine("vogal");
// }

// int qtdEstoque = 2;
// int qtdCompra = 5;
// bool possivelVenda = qtdCompra > 0 && qtdEstoque >= qtdCompra;

// Console.WriteLine($"Quantidade em estoque: {qtdEstoque}");
// Console.WriteLine($"Quantidade compra: {qtdCompra}");
// Console.WriteLine($"É possivel realizar a venda {possivelVenda}");

// if(qtdCompra == 0){
//     Console.WriteLine("Venda inválida");
// }
// else if(possivelVenda){
//     Console.WriteLine("Venda realizada");
// }
// else{
//     Console.WriteLine("Desculpa. Não temos a quantidade desejada no estoque");
// }

// int a = Convert.ToInt32("a");
// int a = int.Parse("5");
// Console.WriteLine(a);

// Operadoe de atribuição
// int a = 10;
// int b = 20;
// int c = a + b;
// Console.WriteLine(c);
// c = c + 5;
// Console.WriteLine(c);

// Pega a data da maquina atual
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.90;
// decimal preco = 1.80M;
// // Boolean
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variavel qtd: " + quantidade);
// Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel preco: " + preco);
// Console.WriteLine("Valor da varieavel condição: " + condicao);

//  Pessoa pessoal = new Pessoa();

//  pessoal.Nome = "Matheus";
//  pessoal.Idade = 21;
//  pessoal.Apresentar();
// Pessoa pessoa_FisicaRepesentacao = new Pessoa();