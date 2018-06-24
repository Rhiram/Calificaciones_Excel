using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones_Alumnos
{
    class Alumnos
    {   
        public List<AlumnosDatos> Lista_Alumnos;
        public Alumnos() 
        {
            //creamos una lista vacia
            Lista_Alumnos = new List<AlumnosDatos>();
        }

        public void agregar_Alumnos(AlumnosDatos agregaAlumno)
        {
            Lista_Alumnos.Add(agregaAlumno);
        }

    }
}
