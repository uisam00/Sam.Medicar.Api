namespace Sam.Medicar.Application.Dtos;
public class AgendaDto
{
    public int Id { get; set; }
    public DateTime Dia { get; set; }
    public ICollection<string> Horarios { get; set; }
}
