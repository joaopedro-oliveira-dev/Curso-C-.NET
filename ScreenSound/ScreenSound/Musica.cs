class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } //Este atributo possui operação de escrita (set) e de leitura (get).
    // É possível abrir a função "set" e colocar uma condição de permissão de usuário, para que somente autorizados alterem essa informação.
    // A partir do momento que são inseridas "funções" na variável de uma classe, ela se torna uma propriedade, e começa como maiúscula
    public string DescricaoResumida => 
        $"A música {Nome} pertence à banda {Artista}."; //Lambda
    /*{
        get
        {
            return $"A música {Nome} pertence à banda {Artista}.";
        } 
    }*/

    public void ExibirFichaTecnica() // Criação de um método para a classe
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o Plano Plus+.");
        }
    }
}