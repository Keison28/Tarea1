using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1.Entidad
{
    public class ExAlumno : Estudiante
    {
        public DateOnly fecha_finalizacion { get; set; }

        public string motivo { get; set; }
    }
}
