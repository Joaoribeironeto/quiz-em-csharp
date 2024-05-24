
Dictionary<string, string> perguntasRespostas = new Dictionary<string, string>
{
    ["Qual a capital da Austrália?"] = "Camberra",
    ["Qual é o nome do satélite natural da terra?"] = "Lua",
    ["Em que ano acabou a segunda guerra mundial?"] = "1945"
};

int pontuacao = 0;

foreach (var pergunta in perguntasRespostas)
{
    Console.WriteLine(pergunta.Key);
    Console.Write("Digite aqui a sua resposta: ");
    string resposta = Console.ReadLine()!;
    if (resposta.ToLower() == pergunta.Value.ToLower())
    {
        Console.WriteLine("Você acertou!\n");
        pontuacao += 1;
    }
    else
    {
        Console.WriteLine($"Correção: {pergunta.Value}\n");
    }
}

Console.WriteLine($"Você acertou {pontuacao} de {perguntasRespostas.Count} perguntas.");