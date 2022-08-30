namespace CSharp.Metodos
{
  public class Lucro
  {
    // Método de cálculo dos lucros
    public static void PercentualLucro(double precoVenda, double preco)
    {
      double lucro = Math.Round((precoVenda * 100) / preco - 100);
      Console.WriteLine($"Seu Lucro será de {lucro}%"); ;
    }
  }
}