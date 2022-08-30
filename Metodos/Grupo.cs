namespace CSharp.Metodos
{
  public class Grupo
  {
    // Método de Exposição das opções do grupo
    public static void Grupos()
    {
      foreach (var item in Enum.Egrupo.GetNames(typeof(Enum.Egrupo)))
      {
        Console.WriteLine(item);
      }
    }

    // Método de Exposição das opções do Sub-Grupo
    public static void SubGrupos()
    {
      foreach (var item in Enum.ESubGrupo.GetNames(typeof(Enum.ESubGrupo)))
      {
        Console.WriteLine(item);
      }
    }
  }
}