using CSharp.Metodos;

namespace CSharp
{
  public class Registro : Conteudo
  {
    // Área de registro dos dados de entrada
    public void salvarProduto()
    {
      Console.Clear();

      Console.WriteLine("Opções de Grupos:");
      Grupo.Grupos();

      Console.WriteLine("Escolha um Grupo:");
      grupo = Console.ReadLine();

      Console.Clear();
      Console.WriteLine("Opções de SubGrupo:");
      Grupo.SubGrupos();

      Console.WriteLine("Escolha um SubGrupo:");
      subGrupo = Console.ReadLine();

      Console.Clear();
      Console.WriteLine("Digite a marca:");
      marca = Console.ReadLine();

      Console.WriteLine("Digite a Quantidade:");
      quantidade = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite o Preço:");
      preco = double.Parse(Console.ReadLine());

      Console.WriteLine("Preço de venda:");
      precoVenda = double.Parse(Console.ReadLine());
      Console.Clear();

      Dialogo.Dados(grupo, subGrupo, marca, quantidade, preco, precoVenda);

      Total.RetornoTotal(quantidade, preco);

      Lucro.PercentualLucro(precoVenda, preco);

      System.Console.WriteLine("");
      System.Console.WriteLine("Enter para continuar ...");
      Console.ReadKey();

      Dialogo.Continuar();
    }

  }
}