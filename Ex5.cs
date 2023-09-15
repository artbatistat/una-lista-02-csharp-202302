double salariobruto,valorhora,salariofamilia;
int horas,filhos;

Console.WriteLine("Digite o número de horas que o funcionário trabalhou no mês:");
horas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Valor recebido por hora de trabalho:");
valorhora = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Valor do salário família:");
salariofamilia = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Número de filhos com idade menor que 14 anos:");
filhos = Convert.ToInt32(Console.ReadLine());

salariobruto = (horas * valorhora) + (salariofamilia * filhos);

Console.WriteLine("O salário bruto é :"+ salariobruto);
Console.ReadLine();
