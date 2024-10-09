using Ex_4;

Carro carro1 = new Carro("Chevrolet", "Vectra", 105);
Carro carro2 = new Carro("Honda", "Civic", 160);
Carro carro3 = new Carro("Volkswagen", "Golf", 110);


Console.WriteLine($"\na marca do carro é {carro1.Marca}, e o modelo é {carro1.Modelo}"); 
carro1.acelerar();
carro1.desacelerar();

Console.WriteLine($"\na marca do carro é {carro2.Marca}, e o modelo é {carro2.Modelo}");
carro2.acelerar();
carro2.desacelerar();

Console.WriteLine($"\na marca do carro é {carro3.Marca}, e o modelo é {carro3.Modelo}");
carro3.acelerar();
carro3.desacelerar();

Console.ReadKey();  
