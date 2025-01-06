using System.Net.Http.Json;

namespace ConsoleClient;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Digite um número para decompor:");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            try
            {
                var client = new HttpClient { BaseAddress = new Uri("https://localhost:5000") };
                var result = await client.GetFromJsonAsync<NumberDecompositionResult>($"api/numbers/divisors/{number}");

                if (result != null)
                {
                    Console.WriteLine($"Número de Entrada: {result.Number}");
                    Console.WriteLine($"Divisores: {string.Join(", ", result.Divisors)}");
                    Console.WriteLine($"Divisores Primos: {string.Join(", ", result.PrimeDivisors)}");
                }
                else
                {
                    Console.WriteLine("Não foi possível obter os resultados.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido.");
        }
    }
}

internal class NumberDecompositionResult
{
    public int Number { get; set; }
    public List<int> Divisors { get; set; } = [];
    public List<int> PrimeDivisors { get; set; } = [];
}
