double capital,juros;
int prazo;

Console.WriteLine("Valor do capital:");
capital = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("O prazo de aplicação (em meses):");
prazo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Taxa de juros mensal:");
juros = Convert.ToDouble(Console.ReadLine());

double montante = capital * Math.Pow((1+juros),prazo);

Console.WriteLine("O montante a ser recebido é: R"+montante.ToString("C"));
Console.ReadLine();
