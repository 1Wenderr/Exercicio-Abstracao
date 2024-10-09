namespace Ex_2
{
    public class Aluno
    {
        public int RM { get; set; }

        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }

        public string Email { get; set; }

        public Aluno(int rm, string nome, DateTime nascimento, string email)
        {
            RM = rm;
            Nome = nome;    
            Nascimento = nascimento;
            Email = email;
        }

        public void Colocar()
        {
            Console.WriteLine($"\nVocê escolheu o aluno {Nome}");

        }
    }
}
