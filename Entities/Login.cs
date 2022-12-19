namespace VoeAirlines.Entities;
/*Namespace é um conjunto de classe. Ela serve para organizar 
funcionalidades comuns. 

Namespace é um conjunto de classes com funcionalidades em comum. 
namespace VoeAirlines.Entities - funcionalidade em comum desse namespace: 
definir atributos (valores) e as entidades :classes que serão mapeadas no 
banco de dados do SQL Server. Entidades mapeiam Tabelas.


namespace VoeAirlines.EntityConfigurations: funcionalidade em comum é configurar 
as entidades com Fluent API

https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
*/

public class Login{

    //A classe é um conjunto de objetos.

    /*
    Propriedades automáticas
    get e set
    Métodos set
    Métodos get
    O método set --> define, atribui
    O método get -> usa os dados, pega os dados , retorna os dados.
    
    Define uma variável que possui os dois métodos set como get embutido.
    Ele já trabalha com encapsulamento e definição automática do get e set.
    */
    public int Id { get; set; }
    public string? Usuario { get; set; }
    public string? Senha { get; set; }
    /*
    Um tipo de referência que permite valor nulo é indicado usando a mesma sintaxe que 
    tipos de valor que permitem valor nulo: um ? é acrescentado ao tipo da variável. 
    Por exemplo, a seguinte declaração de variável representa uma variável de cadeia de 
    caracteres que permite valor nulo

    Documentação: https://learn.microsoft.com/pt-br/dotnet/csharp/nullable-references


    Tipo valor: int, double, float, bool, struct, enum --> não precisa da interrogação (?)
    Tipo referência: string, Aeronave, Piloto, Login entre outros... --> precisa da interrogação (?)
    */

    //Construtor sem inicializar = vazio
    public Login(){}

    //Construtor incializando = parâmetros
    public Login(string? usuario, string? senha)
    {
        Usuario = usuario;
        Senha = senha;
    }
    /*
    O construtor constroi objetos
    O construtor inicializa objetos
    */

}