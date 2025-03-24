string palavraSecreta;
string letra;
bool letraExiste;

Console.Clear();
Console.WriteLine("-----Forca-----");

Console.WriteLine("Escreva qual será a palavra secreta: ");
palavraSecreta = Console.ReadLine()!;

Console.Clear();
Console.WriteLine("-----Forca-----");

Console.WriteLine("Escreva uma letra: ");
letra = Console.ReadLine()!
        .Trim()
        .Substring(0, 1)
        .ToLower();


Console.Clear();
Console.WriteLine("-----Forca-----");

letraExiste = palavraSecreta
            .ToLower()
            .Contains(letra);

Console.WriteLine($"A letra {letra} existe na palavra secreta? {letraExiste}");
