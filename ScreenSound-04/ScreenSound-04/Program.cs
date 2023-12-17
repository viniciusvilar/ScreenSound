//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
//        Console.WriteLine(resposta);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine($"Temos um problema: {ex.Message}");
//    }
    
//}

try
{
    for (int i = 3; i >= 0; i--)
    {
        Console.WriteLine($"Valor do I: {i}");
        Console.WriteLine($"{10 / i}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Tivemos um problema: {ex.Message}");
}