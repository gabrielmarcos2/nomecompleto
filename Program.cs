string nome, sobrenome, sobrenomeEmMaiuscula;

Console.Write("Digite seu  primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite seu segundo nome: ");
sobrenome = Console.ReadLine()!;

sobrenomeEmMaiuscula = sobrenome.ToUpper();

Console.WriteLine($"Nome completo:  {nome} {sobrenome}");

Console.WriteLine($"Nmoe de catalogo: {sobrenomeEmMaiuscula}, {nome}");
