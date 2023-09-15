double salariofixo,valorvenda,percentual;

Console.WriteLine("Digite o salário fixo do vendedor:");
salariofixo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor total das vendas que o vendedor realizou:");
valorvenda = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o percentual que o vendedor ganha a cada venda:");
percentual = Convert.ToDouble(Console.ReadLine());

double salario = salariofixo + (valorvenda * (percentual/100));

Console.WriteLine("O salário final do vendedor com percentual das vendas é: R"+salario.ToString("C"));
Console.ReadLine();


