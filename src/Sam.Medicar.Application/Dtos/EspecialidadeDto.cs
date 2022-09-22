namespace Sam.Medicar.Application.Dtos;
public class EspecialidadeDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public IEnumerable<MedicoDto> Medicos { get; set; }

}
