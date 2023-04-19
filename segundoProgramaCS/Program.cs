public class Program
{
  //Estrutura base Para projetos antigos com dotnet (Foi necessário usarmos porconta da sobrecarga dos métodos, pois o modelo ivo nào permite)
  public static void Main(string[] args)
  {

    var resultado6 = Calcula(1, 1, 5, 5, 5, 5, 5, 5, 5, 5);
    //Utilizar o Tryparse para conversão 
    //Detalhada
    Console.WriteLine("Digite um numero");
    string valor = Console.ReadLine();

    int valorInteiro;
    bool digitouCerto = int.TryParse(valor, out valorInteiro);

    if (digitouCerto == false)
    {
      Console.WriteLine("Não pequeno jumento, digite um NUMERO");
      return;
    }
    Console.WriteLine(valorInteiro);

    //Resumida
    Console.WriteLine("Digite um numero");
    string valorResu = Console.ReadLine();
    if (!int.TryParse(valorResu, out int valorInteiroResu))
    {
      Console.WriteLine("Não pequeno jumento, digite um NUMERO");
      return;
    }
    Console.WriteLine(valorInteiro);


    //Utilizar o Parse para conversão
    //Conversão Detalhada
    double resultadoDouble = Calcula(1, 2);
    string resultadoString = resultadoDouble.ToString();
    int resultado11 = int.Parse(resultadoString);

    //Conversão resumida
    int resultado1 = int.Parse(Calcula(1, 2).ToString());

    //Casting
    int resultado111 = (int)Calcula(1, 2);




    Console.WriteLine(resultado1);

    //Chamadas do método calcula
    double resultado2 = Calcula(3.5, 4.5);
    Console.WriteLine(resultado2);

    int resultado3 = Calcula(1, 5, 6);
    Console.WriteLine(resultado3);

    int num1 = 1;
    int num2 = 5;
    int num3 = 6;
    int resultado4 = Calcula(num1, num2, num3);


    int num4 = 1;
    int num5 = 5;

    var resultado5 = Calcula(num4, num5);



  }
  //por conta do modelo antigo usando a classe static program os métodos criados nela precisam ser staticos também, 
  //mas nào se preocupem noós aprofundaremos em métodos e classes staticos nás próximas aulas. foquem na compreenção do funcionamento da sobrecarga 
  static double Calcula(int num1, int num2)
  {
    return num1 + num2;
  }
  static double Calcula(double num1, double num2)
  {
    return num1 + num2;
  }
  static int Calcula(int num1, int num2, int num3)
  {
    return num1 + num2 + num3;
  }

  static int Calcula(params int[] param)
  {
    int resultado = 0;
    foreach (var num in param)
    {
      resultado += num;
    }
    return resultado;
  }

}
