using Ex_1;

Livro livro1 = new Livro("Authenticgames: vivendo uma vida autêntica", "Marco Túlio (AuthenticGames)", "Astral Cultural", 2016);
Livro livro2 = new Livro("TazerCraft: Uma aventura Chume Labs", "Pac Tarik Pacanhan, Mike Mikhael Linnyker e Gustavo Magnani", "Intrínseca", 2018);
Livro livro3 = new Livro("It: A coisa", "Stephen King", "Suma", 2014);

livro1.Pegar();
Console.WriteLine($"O título do seu livro é {livro1.Titulo}, o autor é {livro1.Autor}, a editora é {livro1.Editora} e foi lançado em {livro1.Ano}");
livro2.Pegar();
Console.WriteLine($"O título do seu livro é {livro2.Titulo}, os autores são {livro2.Autor}, a editora é {livro2.Editora} e foi lançado em {livro2.Ano}");
livro3.Pegar();
Console.WriteLine($"O título do seu livro é {livro3.Titulo}, o autor é {livro3.Autor}, a editora é {livro3.Editora} e foi lançado em {livro3.Ano}");

Console.ReadKey();