Console.WriteLine("Digite o total de veículos no estacionamento:");
int nmrVeiculos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o total de rodas no estacionamento:");
int nmrRodas = Convert.ToInt32(Console.ReadLine());
		
int nmrCarros = (nmrRodas - 2 * nmrVeiculos) / 2;
int nmrMotos = nmrVeiculos - nmrCarros;

if (nmrCarros >= 0 && nmrMotos >= 0 && nmrCarros % 1 == 0 && nmrMotos % 1 == 0) 
Console.WriteLine("No estacionamento tem : "+nmrCarros+" de carros e "+nmrMotos+" de motos.");

else 
Console.WriteLine("Não é possível determinar o número de carros e motos com base nos dados inseridos.");
