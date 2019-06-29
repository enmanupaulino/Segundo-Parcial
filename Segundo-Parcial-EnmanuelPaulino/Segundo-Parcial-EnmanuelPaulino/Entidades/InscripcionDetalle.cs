﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial_EnmanuelPaulino.Entidades
{
    public class InscripcionDetalle
    {
        [Key]
        public int InscripcionDetallesId { get; set; }
        public int InscripcionId { get; set; }
        public int AsignaturaId { get; set; }
        public decimal SubTotal { get; set; }

        public InscripcionDetalle()
        {
            InscripcionDetallesId = 0;
            InscripcionId = 0;
            AsignaturaId = 0;
            SubTotal = 0;
        }
    }
}
