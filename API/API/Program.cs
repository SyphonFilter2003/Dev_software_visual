
//TESTAR AS APIs: - Rest Client - Extensão do VsCode
//                - Postman(instalar no pc)
//                - Insomnia(instalar no pc
//MINIMAL APIs(APIs mínimas, funcionam com menos código possível!)
using API.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoints - Funcionalidades dentro das APIs
//Configurar a URL e o método/verbo
app.MapGet("/", () => "Olá mundo!");

app.MapGet("/segundafuncionalidade", () => "Hello World em C#!");

app.MapGet("/retornarendereco", () => {
    dynamic endereco = new {
        rua = "Rua Jorge Elias",
        numero = 440,
        cep = "84950-000"
    };
    return endereco;
});


app.Run();

//C# - Utilização dos gets e sets
Produto produto = new Produto();
produto.Preco = 5;
produto.
Console.WriteLine("Preço: " + produto.Preco);


//JAVA - Utilização dos gets e sets:
//Produto produto = new Produto();
//produto.setPreco(5);
//Console.WriteLine("Preço: " + produto.getPreco());



//CRIAR UMA FUNCIONALIDADE PARA RECEBER INFORMAÇÕES
// - RECEBER INFORMAÇÕES PELA URL DA REQUISIÇÃO
// - RECEBER INFORMAÇÕES PELO CORPO DA REQUISIÇÃO
// - GUARDAR AS INFORMAÇÕES EM UMA LISTA