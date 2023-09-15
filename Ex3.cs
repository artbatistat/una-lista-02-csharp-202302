double temperatura;

Console.WriteLine("Digite a temperatura em Fahrenheit:");
temperatura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Temperatura convertida para centígrados: " + ((temperatura - 32)/1.8).ToString("F"));
Console.ReadLine();

