using Sam.Medicar.Domain.Entities;
using Sam.Medicar.Domain.Interfaces.Repositories;
using Sam.Medicar.Domain.Interfaces.Services;
using Sam.Medicar.Domain.Services.Shared;

namespace Sam.Medicar.Domain.Services;

public class AgendaService : ServiceBase<Agenda>, IAgendaService
{
    public AgendaService(IAgendaRepository agendaRepository) : base(agendaRepository) { }
}
