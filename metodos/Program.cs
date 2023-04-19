int Calcula(int num1, int num2)
{

  return num1 + num2;
}

double CalculaCirculo(double raio)
{
  double pi = 3.1415;
  return 2 * pi * raio;
}

void ExibirBoasVindas()
{
  Console.WriteLine("Bem vindo ao Modulo De backend do DevInHouse");

}

void ExibirSenaoZero(int num)
{
  if (num == 0)
    return;

  Console.WriteLine("Numero: " + num);
}
ExibirSenaoZero(5);
ExibirSenaoZero(0);

ExibirBoasVindas();

int resultado1 = Calcula(1, 2);
Console.WriteLine(resultado1);

int resultado2 = Calcula(3, 4);
Console.WriteLine(resultado2);

double Circulo = CalculaCirculo(15);
Console.WriteLine(Circulo);
