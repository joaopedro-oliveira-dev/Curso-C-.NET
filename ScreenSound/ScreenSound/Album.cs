class Album
{
    private List<Musica> Musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);// Para cada música, vai ser somada a duração da mesma.
    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in Musicas)
        {
            Console.WriteLine(musica.Nome);
        }
        Console.WriteLine($"\NPara ouvir esse álbum inteiro, você precisa de {DuracaoTotal} segundos.");
    }
}