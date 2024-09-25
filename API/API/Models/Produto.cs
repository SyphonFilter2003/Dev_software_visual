namespace API.Models;

public class Produto{

    //C# - CONTRUTOR DA CLASSE
    public Produto(){

        Id = Guid.NewGuid().ToString();//IDENTIFICADOR ÚNICO GLOBAL TRANSFORMADO EM UMA STRING.
        CriadoEm = DateTime.Now;//Armazena os valores aleatórios 
    }
    //C# - Atributo com get e set
    public string? Id {get; set;}//O "?" serve para deixar sempre o valor NULO.
    public string? Nome {get; set;}
    public string? Descricao {get; set;}
    public double Preco {get; set;}
    public int Quantidade {get; set;}
    public DateTime CriadoEm { get; set; }//DateTime serve para gerar um valor aleatório


 // //JAVA - Atributo com get e set
 //   private double preco;

//    public double getPreco(){
//        return preco;
//    }

//    public setPreco(double preco){
//        this.preco = preco * 3;
//    }
}