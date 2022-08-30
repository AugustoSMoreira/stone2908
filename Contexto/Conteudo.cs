using CSharp.Enum;

namespace CSharp
{
    // Contexto de propriedades
  public class Conteudo
  {
    public Egrupo Egrupo { get; set; }
    public string? grupo { get; set; }
    public Egrupo ESubGrupo { get; set; }
    public string? subGrupo { get; set; }
    public string? marca { get; set; }
    public int quantidade { get; set; }
    public double preco { get; set; }
    public double precoVenda { get; set; }
    public double lucro { get; set; }

  }
}