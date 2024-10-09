using Ex_2;

Aluno aluno1 = new Aluno(1987, "Wender de Jesus", new DateTime ( 2007, 07, 09), "wender.penha@portalsesisp.org.br");
Aluno aluno2 = new Aluno(5962, "Gael Carvalho", new DateTime (2009, 09, 02), "gael.carvalho@portalsesisp.org.br");
Aluno aluno3 = new Aluno(2756, "Ulisses dos Santos Barbosa", new DateTime(2005, 05, 31), "ulisses.barbosa@portalsesisp.org.br");

aluno1.Colocar();
Console.WriteLine($"O RM do seu aluno é {aluno1.RM}, o nome dele é {aluno1.Nome}, a sua data de nascimento é {aluno1.Nascimento} e o sei email é {aluno1.Email}."); 
aluno2.Colocar();
Console.WriteLine($"O RM do seu aluno é {aluno2.RM}, o nome dele é {aluno2.Nome}, a sua data de nascimento é {aluno2.Nascimento} e o sei email é {aluno2.Email}.");
aluno3.Colocar();
Console.WriteLine($"O RM do seu aluno é {aluno3.RM}, o nome dele é {aluno3.Nome}, a sua data de nascimento é {aluno3.Nascimento} e o sei email é {aluno3.Email}.");

Console.ReadKey();