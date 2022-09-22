using Sam.Medicar.Domain.Entities.Shared;

namespace Sam.Medicar.Domain.Entities
{
    public class Agenda : Entity
    {
        public DateTime Dia { get; set; }
        public int IdMedico { get; set; }
        public ICollection<string> Horarios { get; set; } 

        public virtual Medico? Medico { get; private set; }
        public virtual ICollection<Consulta>? Consultas { get; private set; }


        public Agenda(int id, int idMedico)
        {
            Id = id;
            Random numAleatorio = new Random();
            IdMedico = idMedico;
            Dia = DateTime.Today.AddDays(numAleatorio.Next(7, 14));
            Horarios = new List<string>( new[] {
                "09:00", "10:00", "13:30", "15:00"
            });

        }

    }
}
