using ExemploFundamentos.Common.Models;

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("SC");


Console.WriteLine($"Itens da lista: {listaString.Count} - capacidade : {listaString.Capacity}");

listaString.Add("ES");
Console.WriteLine($"Itens da lista: {listaString.Count} - capacidade : {listaString.Capacity}");

listaString.Remove("PI");
Console.WriteLine($"Itens da lista: {listaString.Count} - capacidade : {listaString.Capacity}");

// for (int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"O nome do estado é: {listaString[contador]}, e a posição do Array é: {contador}");
// }
// int contador = 0;
// foreach (string estado in listaString)
// {
//     Console.WriteLine($"A lista de estado é: {estado}, e a posição do array é: {contador}");
//     contador++;
// }


// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = 30;
// arrayInteiros[3] = 40;


// int[] arrayInteirosDobrabo = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrabo, arrayInteiros.Length);

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine(valor);
// }

// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//   Console.WriteLine($"Posicao N{contador} - {arrayInteiros[contador]}");
// }

// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Gilson";
// pessoa1.Idade = 45;
// pessoa1.Apresentar();











// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();
    

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Cliente");
//             break;

//         case "2":
//             Console.WriteLine("Buscar Cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("Programa encerrado");




// // int soma = 0;
// // int numero = 0;

// // do
// // {
// //     Console.WriteLine("Digite um numero (0 para parar)");
// //     numero = Convert.ToInt32(Console.ReadLine());
// //     soma += numero;

// // }while(numero != 0);

// // Console.WriteLine($"Total da soma {soma}");




// // int numero = 5;
// // int contador = 0;

// // while (contador <= 10)
// // {

// //     Console.WriteLine($"{numero} x {contador} = {numero} * {contador}");
// //     contador++;

// //     if (contador == 5)
// //     {
// //         break;
// //     }
// // }






// // int numero  = 5;

// // for (int contador = 0; contador <= 10; contador++)
// // {
// //     Console.WriteLine($"{numero} x {contador} = {numero} * {contador}");
// // }






// //  Calculadora calc = new Calculadora();
// // calc.RaizQuadrada(7);
// // calc.Somar(10, 30);
// // calc.Subtrair(10,50);
// // calc.Multiplicar(15,45);
// // calc.Dividir(2,2);
// // calc.Potencia(3,3);
// // calc.Seno(30);
// // calc.Coseno(30);
// // calc.Tangente(30);

// // int numero = 10;

// // Console.WriteLine(numero);

// // Console.WriteLine("Incrementando o 10");
// // numero--;

// // Console.WriteLine(numero);




// // bool choveu = false;
// // bool estaTarde = false;

// // if (!choveu && !estaTarde)
// // {
// //     Console.WriteLine("vou pedalar.");
// // }
// // else
// // {
// //     Console.WriteLine("pedalar outro dia");
// // }



// // bool possuiPresencaMinima = true;
// // double media = 6.3;

// // if (possuiPresencaMinima && media >= 7)
// // {
// //     Console.WriteLine("Aprovado");

// // }
// // else
// // {
// //     Console.WriteLine("Reprovado");
// // }





// // Console.WriteLine("Digite a idade");
// // int maiorIdade = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Autorização do Responsável?");
// // string autorizacao = Console.ReadLine();

// // if(maiorIdade >= 18 || autorizacao == "S")
// // {
// //     Console.WriteLine("Entrada Liberada");
// // }
// // else
// // {
// //     Console.WriteLine("Entrada não permitida");
// // }



// // switch(letra)
// // {
// //     case "a":
// //     case "e":
// //     case "i":
// //     case "o":
// //     case "u":
// //         Console.WriteLine("Vogal");
// //         break;
// //     default:
// //         Console.WriteLine("Não é uma Vogal");
// //         break;
// // }



// // if (letra == "a" ||
// //     letra == "e" ||
// //     letra == "i" ||
// //     letra == "o" || 
// //     letra == "u")
// // {
// //     Console.WriteLine("Vogal.");
// // }
// // else
// // {
// //     Console.WriteLine("Não é Vogal");
// // }


// // if (letra == "a")
// // {
// //     Console.WriteLine("Vogal");
// // }
// // else if (letra == "e")
// // {
// //     Console.WriteLine("Vogal");
// // }
// // else if (letra == "i")
// // {
// //     Console.WriteLine("Vogal");
// // }

// // else if (letra == "o")
// // {
// //     Console.WriteLine("Vogal");
// // }

// // else if (letra == "u")
// // {
// //     Console.WriteLine("Vogal");
// // }
// // else 
// // {
// //     Console.WriteLine("Não Vogal");
// // }





// // int quantidadeEstoque = 10;
// // int quantidadeCompra = 0;
// // bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;


// // Console.WriteLine($"Estoque: {quantidadeEstoque}");
// // Console.WriteLine($"Compra: {quantidadeCompra}");
// // Console.WriteLine($"Realizar venda: {possivelVenda}");


// // if (quantidadeCompra == 0)
// // {
// //     Console.WriteLine("Venda Inválida.");
// // }
// // else if (possivelVenda)
// // {
// //     Console.WriteLine("venda realizada");
// // }
// // else
// // {
// //     Console.WriteLine("Não temos quantidade em estoque.");
// // }




// //  using ExemploFundamentos.Models;

// // string a = "15-";
// // int b = 0;

// // int.TryParse(a, out b);

// // Console.WriteLine(b);
// // Console.WriteLine("Convertido com sucesso!");

// // int a = 5;
// // double b = a;

// // Console.WriteLine(b);

// // int inteiro = 5;
// // string a = inteiro.ToString();


// // Console.WriteLine(a);

// // int a = Convert.ToInt32("5");
// // int b = int.Parse("6");

// // Console.WriteLine(a);
// // Console.WriteLine(b);





// // int a = 12;
// // int b = 10;

// // int c = a + b;

// // c = c + 5;

// // Console.WriteLine(c);


// // string apresentacao = "Olá sejá bem vindo";
// // int quantidade = 1;
// // double altura = 1.80;
// // decimal preco = 1.80M;
// // bool condicao =  true;
// // DateTime dataAtual = DateTime.Now.AddMonths(5);


// // Console.WriteLine(apresentacao);
// // Console.WriteLine("Valor da variavel quantidade: " + quantidade);
// // Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00"));
// // Console.WriteLine("Valor da variavel preco: " + preco);
// // Console.WriteLine("Valor da variavel condicao: " + condicao);
// // Console.WriteLine("Data atual: " + dataAtual.ToString("dd/MM/yyyy HH:mm"));


// // Pessoa pessoa = new Pessoa();

// // pessoa.Nome = "Gilson Moreira dos Santos";
// // pessoa.Idade = 45;
// // pessoa.Apresentar();

