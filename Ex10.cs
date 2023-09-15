double a,b,c,aritmetica,harmonica,geometrica;

Console.WriteLine("Digite valor:");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite valor:");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite valor:");
c = Convert.ToDouble(Console.ReadLine());

aritmetica = (a+b+c) /3;

harmonica = 3/(1/a + 1/b + 1/c);

geometrica = Math.Cbrt(a * b * c);

Console.WriteLine("Média aritmética:"+aritmetica);

Console.WriteLine("Média harmônica:"+harmonica);

Console.WriteLine("Média geométrica:"+geometrica);

Console.ReadLine();

