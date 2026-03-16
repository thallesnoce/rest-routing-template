namespace RoutingTemplate.Models;

public class Subordinado
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Cargo { get; set; } = string.Empty;
    public int ChefeId { get; set; }
    public Chefe Chefe { get; set; } = null!;
}
