using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Metodos
{
  public class Total
  {
    // Método de total de Investimento
    public static void RetornoTotal(double quantidade, double preco)
    {
      var total = quantidade * preco;

      System.Console.WriteLine($"Para essa quantidade teremos investido R${total}");
    }
  }
}