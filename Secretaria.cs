namespace AtividadeJaimeM2S5
{
 public class Secretaria :SalarioEmpregado
  {
    public int qtdAnosEmpresa;

    public Secretaria(int id, string nome, int codigoFuncionario, double valorSalario, int qtdAnosEmpresa) : base(id,  nome, codigoFuncionario, valorSalario)
    {
      this.qtdAnosEmpresa = qtdAnosEmpresa;
    }

    public void AtenderCliente()
    {
      Console.WriteLine($"Funcionaria do Atendimento foi  {nome}");
    }
    public void RealizarLigaçoes()
    {
      Console.WriteLine($"{nome} Realizou 2 ligações");
    }
  }


}