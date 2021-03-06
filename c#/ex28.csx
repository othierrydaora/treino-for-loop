/* 28. Implementar uma função que verifique quantas vogais aparecem em um texto. */

public int FindVowels(string phrase)
{
    phrase = phrase.ToLower();
    int rsp = 0;
    for (int i = 0; i < phrase.Length; i++)
    {
        if (phrase[i] == 'a' || phrase[i] == 'e' || phrase[i] == 'i' || phrase[i] == 'o' || phrase[i] == 'u') rsp += 1;
    }
    return rsp;
}

public void Main()
{
    try
    {
        Console.Write("Contar vogais\nInsira o texto: ");
        string text = Console.ReadLine();
        Console.WriteLine(FindVowels(text));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();