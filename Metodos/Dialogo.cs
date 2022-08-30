namespace CSharp.Metodos
{
  public class Dialogo : Conteudo
  {
    // Método de retorno da lista de produtos
    public static void Dados(string grupo, string subGrupo, string marca, int quantidade, double preco, double precoVenda)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      System.Console.WriteLine("===========================");
      System.Console.WriteLine($"Esses São os dados de seu registro: \nGrupo: {grupo}, \nSubGrupo: {subGrupo}, \nMarca: {marca}, \nQuantidade: {quantidade}, \nValor de Compra: {preco}, \nValor de Venda: {precoVenda}");
      System.Console.WriteLine("===========================");
    }

  // Método de Loop para sair ou Continuar no programa
    public static void Continuar()
    {
      Console.Clear();
      System.Console.WriteLine("Gostaria de continuar usando?");
      System.Console.WriteLine("Sim ou Não:");
      var opcao = Console.ReadLine().ToLower();

      switch (opcao)
      {
        case "sim":
          Console.Clear();
          System.Console.WriteLine("Carregando.");
          Thread.Sleep(1000);
          Console.Clear();
          System.Console.WriteLine("Carregando..");
          Thread.Sleep(1000);
          Console.Clear();
          System.Console.WriteLine("Carregando...");
          Thread.Sleep(1000);
          Console.Clear();
          Chamadas.Chamadas.ChamadaRegistro();
          break;
        case "não":
          System.Console.WriteLine("Obrigado por usar nosso sistema");
          Thread.Sleep(1500);
          Environment.Exit(0);
          break;
        default:
          System.Console.WriteLine("Insira uma opção válida");
          Thread.Sleep(1500);
          Chamadas.Chamadas.ChamadaRegistro();
          break;
      }

    }
  }
}