namespace CSharp.Chamadas
{
  public class Chamadas
  {
    // Método de instanciar a Lista
    public static void ChamadaRegistro()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.White;

      var registro = new Registro();
      var lista = new List<Conteudo>();
      lista.Add(registro);
      registro.salvarProduto();
    }
  }
}