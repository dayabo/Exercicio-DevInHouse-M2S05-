namespace AtividadeJaimeM2S5
{
 public class Empregado
{
    public int id;
    public string nome;

    public Empregado(int id, string nome)
    {
      this.id = id;
      this.nome = nome;
    }

    public void Trabalhar()
    {
       Console.WriteLine($"{nome} Trabalha das 08:00 as 17:00 ");
    }

    public void IrEmbora()
     {
      Console.WriteLine($"{nome} sai as 17:00");
      }

    public void TirarFolga()
     {
      Console.WriteLine($"{nome} Folga no domingo");
      }
  }

}