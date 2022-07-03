
namespace AtividadeJaimeM2S5
{
  internal class Program
  {
    static void Main(string[] args)
    {
       Empregado empregado = new Empregado(1, "dayane");
      Console.WriteLine("Instanciando todas as variáveis e metodos da classe Empregado");
       Console.WriteLine($"Id: {empregado.id}");
      Console.WriteLine($"Nome: {empregado.nome}");
      empregado.Trabalhar();
      empregado.IrEmbora();
      empregado.TirarFolga();
      Console.WriteLine($"------------------------------------------------------------------------------------------");

      SalarioEmpregado salario = new SalarioEmpregado(1, "dayane", 100, 1500.00);
      Console.WriteLine("Instanciando todas as variáveis e metodos da classe SalarioEmpregado");
      Console.WriteLine($"Id: {salario.id}");
      Console.WriteLine($"Nome: {salario.nome}");
      Console.WriteLine($"Codigo Funcionario: {salario.codigoFuncionario}");
      Console.WriteLine($" Valor Salario: {salario.valorSalario}");
      salario.CalcularFolhaPagamento();
      salario.Trabalhar();
      salario.IrEmbora();
      salario.TirarFolga();
      Console.WriteLine($"------------------------------------------------------------------------------------------");
      FuncionarioHorista horista = new FuncionarioHorista (1, "dayane", "18.708/0001-06", 0.5);
      Console.WriteLine("Instanciando todas as variáveis e metodos da classe Funcionario Horista");
      Console.WriteLine($"Id: {horista.id}");
      Console.WriteLine($"Nome: {horista.nome}");
      Console.WriteLine($"CNPJ: {horista.cnpj}");
      Console.WriteLine($"Taxa: {horista.taxa}");
      horista.CalcularTaxa();
      horista.EmitirNota();
      horista.Trabalhar();
      horista.IrEmbora();
      horista.TirarFolga();
      Console.WriteLine($"------------------------------------------------------------------------------------------");
      Secretaria secretaria = new Secretaria(1, "dayane", 100, 1500.00, 3);
      Console.WriteLine($"Id: {secretaria.id}");
      Console.WriteLine($"Nome: {secretaria.nome}");
      Console.WriteLine($"Tempo de Empresa: {secretaria.qtdAnosEmpresa} Anos");
      Console.WriteLine($"Codigo Funcionario: {secretaria.codigoFuncionario}");
      Console.WriteLine($" Valor Salario: {secretaria.valorSalario}");
      secretaria.AtenderCliente();
      secretaria.RealizarLigaçoes();
      secretaria.Trabalhar();
      secretaria.IrEmbora();
      secretaria.TirarFolga();
      secretaria.CalcularFolhaPagamento();
      Console.WriteLine($"------------------------------------------------------------------------------------------");
    }
  }
}