namespace Ex_1
{
    public class Livro
    {
        public string Titulo { get; set; }

        public string Autor {  get; set; }

        public string Editora { get; set; }

        public int Ano { get; set; }

        public Livro(string titulo, string autor, string editora, int ano) 
        {
            Titulo = titulo;   
            Autor = autor;
            Editora = editora;
            Ano = ano;
        }
        public void Pegar()
        {
            Console.WriteLine($"\nVocê escolheu o livro {Titulo}.");

        }
    }
}
