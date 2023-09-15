
double preco_Produto;

Console.WriteLine("Digite o preço do produto:");
preco_Produto = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("O valor do produto com acrescimo de 10% :R$"+ (preco_Produto*1.10).ToString("F")+"");
Console.ReadLine();