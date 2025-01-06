using System.Net.Http.Json;

namespace WindowsFormsClient;

public partial class NumberForm : Form
{
    public NumberForm()
    {
        InitializeComponent();
    }

    private async void BtnCalculate_Click(object sender, EventArgs e)
    {
        if (int.TryParse(txtNumber.Text, out int number))
        {
            using var client = new HttpClient { BaseAddress = new Uri("https://localhost:5000") };
            var response = await client.GetFromJsonAsync<NumberDecompositionResult>($"/api/numbers/divisors/{number}");

            lstDivisors.Text = string.Join("\n", response.Divisors);
            lstPrimeDivisors.Text = string.Join("\n", response.PrimeDivisors);
        }
        else
        {
            lstDivisors.Text = "Número inválido.";
        }
    }
}

internal class NumberDecompositionResult
{
    public int Number { get; set; }
    public List<int> Divisors { get; set; } = [];
    public List<int> PrimeDivisors { get; set; } = [];
}
