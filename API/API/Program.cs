
//TESTAR AS APIs: - Rest Client - Extensão do VsCode
//                - Postman(instalar no pc)
//                - Insomnia(instalar no pc
//MINIMAL APIs(APIs mínimas, funcionam com menos código possível!)
using API.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoints - Funcionalidades dentro das APIs
//Configurar a URL e o método/verbo
//Response - Retornar os dados(json/xm1) e
app.MapGet("/", () => "API de Produtos");

//LISTAGEM DE PRODUTOS:
List<Produto> produtos = new List<Produto>();
/*produtos.Add(new Produto(){

    Nome = "Notebook",
    Preco = 5000,
    Quantidade = 54
});

produtos.Add(new Produto(){

    Nome = "Creatina",
    Preco = 86,
    Quantidade = 47
});

produtos.Add(new Produto(){

    Nome = "Whey Protein",
    Preco = 110,
    Quantidade = 98
});

produtos.Add(new Produto(){

    Nome = "Straps",
    Preco = 68,
    Quantidade = 102
});
*/
//GET: /produto/listar
app.MapGet("/produto/listar", () =>
{
    if(produtos.Count > 0){
        return Results.Ok(produtos);
    }
    return Results.NotFound();
});

app.MapGet("/produto/buscar/{nome}", (string nome) => {
    foreach(Produto produtoCadastrado in produtos){
        if(produtoCadastrado.Nome == nome){
            return Results.Ok(produtoCadastrado);
        }
    }
    return Results.NotFound();
});

//POST: /produto/cadastrar sem ser no corpo da API(deixando ele mais bonitinho)
app.MapPost("/produto/cadastrar", 
    ([FromBody]Produto produto) =>
{
    /*//Criar o objeto e preencher
    Produto produto = new Produto();
    produto.Nome = nome;*/
    //ADICIONANDO PRODUTO DENTRO DA LISTA 
    produtos.Add(produto);
    return Results.Created("", produto);
});

//Exercícios
// - Remover produto
// - Alterar produto

app.Run();

//C# - Utilização dos gets e sets
//Produto produto = new Produto(){
//    Nome = "teste",
//    Preco = 5,
//    Quantidade = 150
//};

//Console.WriteLine("Preço: " + produto.Preco);


//JAVA - Utilização dos gets e sets:
//Produto produto = new Produto();
//produto.setPreco(5);
//Console.WriteLine("Preço: " + produto.getPreco());



//CRIAR UMA FUNCIONALIDADE PARA RECEBER INFORMAÇÕES
// - RECEBER INFORMAÇÕES PELA URL DA REQUISIÇÃO
// - RECEBER INFORMAÇÕES PELO CORPO DA REQUISIÇÃO
// - GUARDAR AS INFORMAÇÕES EM UMA LISTA
