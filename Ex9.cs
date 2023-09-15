Console.Write("Digite os segundos: ");
int v_segundos = Convert.ToInt32(Console.ReadLine());

int horas = v_segundos / 3600;
int minutos = (v_segundos % 3600) / 60;
int segundos = v_segundos % 60;

Console.WriteLine("Horas: "+horas+" Minutos: "+minutos+" Segundos: "+segundos);