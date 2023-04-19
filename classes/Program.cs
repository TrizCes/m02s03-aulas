using Classes;

internal class Program
{
  private static void Main(string[] args)
  {
    var aluno = new Aluno();
    aluno.nome = "Beatriz";
    aluno.endereco = "Rua Professor José, nº 100";
    aluno.matricula = 14;
    aluno.telefone = "(47) 998569-0123";
    aluno.RealizarMatricula();

    var aluno1 = new Aluno();
    aluno1.nome = "Alex";
    aluno1.endereco = "Rua Professor José, nº 100";
    aluno1.matricula = 14;
    aluno1.telefone = "(47) 998569-0123";
    aluno1.RealizarMatricula();
    aluno1.Boletim = new Boletim()
    {
      Nota1 = 8,
      Nota2 = 9,
      Nota3 = 10,
    };
    aluno1.MostraNotas();

    var aluno2 = new Aluno()
    {
      matricula = 1,
      nome = "Nice",
      endereco = "rua Violetas",
      telefone = "(11) 9524-6545",
      Boletim = new Boletim()
      {
        Nota1 = 8,
        Nota2 = 9,
        Nota3 = 10,
      },
    };

    aluno2.RealizarMatricula();
    aluno2.MostraNotas();

  }
}
