namespace Classes
{
  public class Aluno
  {
    public string nome { get; set; }
    public int matricula { get; set; }
    public string endereco { get; set; }
    public string telefone { get; set; }

    public Boletim Boletim { get; set; }

    //Criando construtor:
    public Aluno()
    {

    }
    public void RealizarMatricula()
    {
      matricula = new Random().Next();
      Console.WriteLine($"Matricula de {nome} realizada com sucesso! Matricula: {matricula} \n");
    }

    public void MostraNotas()
    {
      Console.WriteLine($"O aluno(a) {nome}, matricula: {matricula}, obteve as notas:\n Nota 1: {Boletim.Nota1} | Nota 2: {Boletim.Nota2} | Nota 3: {Boletim.Nota3} \n");
    }
  }
}
