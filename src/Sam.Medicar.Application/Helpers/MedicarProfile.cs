using AutoMapper;
using Sam.Medicar.Application.Dtos;
using Sam.Medicar.Domain.Entities;

namespace Sam.Medicar.Application.Helpers
{
    public class MedicarProfile : Profile
    {
        public MedicarProfile()
        {
            CreateMap<Especialidade, EspecialidadeDto>().ReverseMap();
            CreateMap<Medico, MedicoDto>().ReverseMap();
            CreateMap<Agenda, AgendaDto>().ReverseMap();
        }
    }
}