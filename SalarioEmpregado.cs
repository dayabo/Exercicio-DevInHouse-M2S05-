namespace AtividadeJaimeM2S5
{
 public class SalarioEmpregado:Empregado
  {
    public int codigoFuncionario;
    public double valorSalario;

    public SalarioEmpregado(int id, string nome,int codigoFuncionario, double valorSalario) : base(id,  nome)
    {
      this.codigoFuncionario = codigoFuncionario;
      this.valorSalario = valorSalario;
    }

    public void CalcularFolhaPagamento()
    {
      Console.WriteLine($"Calcular Pagamento {valorSalario}");
    }
  }
}