using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial_EnmanuelPaulino.Entidades
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public int EstudianteId { get; set; }
        public decimal Monto { get; set; }
        public int CantLab { get; set; }
        public decimal PrecLab { get; set; }
        public decimal PrecCred { get; set; }
        public DateTime Fecha { get; set; }
        public virtual List<InscripcionDetalle> Asignatura { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            EstudianteId = 0;
            Monto = 0;
            CantLab = 0;
            PrecCred = 0;
            PrecLab = 0;
            Fecha = DateTime.Now;
            Asignatura = new List<InscripcionDetalle>();
        }

        public Inscripciones(int inscripcionId,int estudianteId, DateTime fecha, int monto, int cantLab, decimal precLab, decimal precCred, List<InscripcionDetalle> asignatura)
        {
            InscripcionId = inscripcionId;
            EstudianteId = estudianteId;
            Fecha = fecha;
            Monto = monto;
            CantLab = cantLab;
            PrecLab = precLab;
            PrecCred = precCred;
            Asignatura = asignatura;
        }
        
    }
}
