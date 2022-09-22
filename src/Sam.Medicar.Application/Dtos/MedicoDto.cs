namespace Sam.Medicar.Application.Dtos;
public class MedicoDto
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public ICollection<AgendaDto> Agendas { get; private set; }
}
