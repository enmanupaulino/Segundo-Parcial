using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial_EnmanuelPaulino.Entidades
{
    public class Asignaturas
    {
        [Key]

        public int AsignaturasId { get; set; }
        public string Descripcion { get; set; }
        public decimal Creditos { get; set; }
        public Asignaturas()
        {
            AsignaturasId = 0;
            Descripcion = string.Empty;
            Creditos = 0;
        }

    }
}
