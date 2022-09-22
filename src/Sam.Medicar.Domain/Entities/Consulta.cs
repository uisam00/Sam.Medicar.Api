using Sam.Medicar.Domain.Entities.Shared;

namespace Sam.Medicar.Domain.Entities;

public class Consulta : Entity
{
    public Guid IdUser { get; set; }
    public int IdAgenda { get; set; }
    public DateTime Horario { get; private set; }
    public DateTime DataAgendamento { get; private set; }
    public Agenda Agenda { get; private set; }

    //public Consulta(Guid idUser, int idAgenda, TimeOnly horario)
    //{
    //    IdUser = idUser;
    //    IdAgenda = idAgenda;
    //    Horario = horario;
    //}
}
