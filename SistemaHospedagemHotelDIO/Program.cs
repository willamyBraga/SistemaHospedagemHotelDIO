using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Suite
{
    public string Tipo { get; set; }
    public double Diaria { get; set; }
}

class Reserva
{
    public Pessoa Hospede { get; set; }
    public Suite SuiteReservada { get; set; }
    public int QuantidadeDias { get; set; }

    public double CalcularValorTotal()
    {
        double valorTotal = SuiteReservada.Diaria * QuantidadeDias;

        // Aplica um desconto de 10% se a reserva for para mais de 10 dias
        if (QuantidadeDias > 10)
        {
            valorTotal *= 0.9;
        }

        return valorTotal;
    }
}

class Program
{
    static void Main()
    {
        Pessoa hospede = new Pessoa { Nome = "João", Idade = 30 };
        Suite suite = new Suite { Tipo = "Luxo", Diaria = 200 };
        Reserva reserva = new Reserva { Hospede = hospede, SuiteReservada = suite, QuantidadeDias = 12 };

        double valorTotal = reserva.CalcularValorTotal();

        Console.WriteLine($"Hóspede: {hospede.Nome}");
        Console.WriteLine($"Suite: {suite.Tipo}");
        Console.WriteLine($"Quantidade de dias: {reserva.QuantidadeDias}");
        Console.WriteLine($"Valor total da reserva: R${valorTotal:F2}");
    }
}
