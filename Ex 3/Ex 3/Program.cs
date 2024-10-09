using Ex_3;

Produto produto1 = new Produto(87654, "Mochila", 89, 19);
Produto produto2 = new Produto(34897, "Garrafa", 59, 7);
Produto produto3 = new Produto(98765, "Caneta", 2, 219);


Console.WriteLine($"\nO código do produto que você escolheu é {produto1.Codigo}, o produto é {produto1.Nome}, o seu preço é R${produto1.Preco},00");
produto1.valorEstoque();

Console.WriteLine($"\nO código do produto que você escolheu é {produto2.Codigo}, o produto é {produto2.Nome}, o seu preço é R${produto2.Preco},00");
produto2.valorEstoque();

Console.WriteLine($"\nO código do produto que você escolheu é {produto3.Codigo}, o produto é {produto3.Nome}, o seu preço é R${produto3.Preco},00");
produto3.valorEstoque();

Console.ReadKey();