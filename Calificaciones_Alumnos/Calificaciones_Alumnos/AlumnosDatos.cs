using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using System.Diagnostics;

namespace Calificaciones_Alumnos
{
    public class AlumnosDatos
    {
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Grado { get; set; }
        public string Grupo { get; set; }
        public double Calificacion { get; set; }

        public List<AlumnosDatos> Lista_Alumnos;
    }
}
