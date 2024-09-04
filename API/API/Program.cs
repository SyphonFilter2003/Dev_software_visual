
//TESTAR AS APIs: - Rest Client - Extensão do VsCode
//                - Postman(instalar no pc)
//                - Insomnia(instalar no pc
//MINIMAL APIs(APIs mínimas, funcionam com menos código possível!)
using API.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoints - Funcionalidades dentro das APIs
//Configurar a URL e o método/verbo
//Response - Retornar os dados(json/xm1) e
app.MapGet("/", () => "API de Produtos");

List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto(){

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


app.MapGet("/produto/listar", () =>
{
    return Results.Ok(produtos);
});

//POST: /produto/cadastrar
app.MapPost("/produto/cadastrar/{nome}", 
    (string nome) =>
{
    Produto produto = new Produto();
    produto.Nome = nome; 
    //ADICIONANDO PRODUTO DENTRO DA LISTA 
    produtos.Add(produto);
    return Results.Ok(produtos);
});


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