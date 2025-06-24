Console.WriteLine("Eu sou o Groot. (digite 'tchau' para encerrar).");
       
     string pergunta;
       
    do
    {
        Console.Write("\nVocê: ");
        pergunta = Console.ReadLine();
        Console.WriteLine(pergunta.ToLower() != "tchau" ? "Groot: Eu sou Groot!" : "");
           
    } while (pergunta.ToLower() != "tchau");
       
 Console.WriteLine("Groot: Eu sou Groot... (saindo)");

