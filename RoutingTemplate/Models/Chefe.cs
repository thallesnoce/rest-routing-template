namespace RoutingTemplate.Models;

public class Chefe
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Departamento { get; set; } = string.Empty;
    public ICollection<Subordinado> Subordinados { get; set; } = [];
}
