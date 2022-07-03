namespace AtividadeJaimeM2S5
{
  class FuncionarioHorista : Empregado
{
    public string  cnpj;
    public double taxa;

    public FuncionarioHorista(int id, string nome,string cnpj, double taxa) : base(id, nome)
    {
      this.cnpj = cnpj;
      this.taxa = taxa;
    }

    public void CalcularTaxa()
    {
      Console.WriteLine($"Calcular Taxa {taxa}");
    }

    public void EmitirNota()
    {
      Console.WriteLine($"Emitir Nota CNPJ:{cnpj} Nome {nome}");
     }
  }
}