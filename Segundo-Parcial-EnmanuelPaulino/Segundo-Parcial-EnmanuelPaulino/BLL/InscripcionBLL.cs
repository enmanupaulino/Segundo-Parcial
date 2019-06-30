using Segundo_Parcial_EnmanuelPaulino.DAL;
using Segundo_Parcial_EnmanuelPaulino.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial_EnmanuelPaulino.BLL
{
   public class InscripcionBLL
    {
        public bool Guardar(Inscripciones inscripciones)
        {
            bool paso = false;
            //Creamos una instancia del contexto para poder conectar con la DB
            Contexto db = new Contexto();
            try
            {
                RepositorioBase<Estudiantes> rp = new RepositorioBase<Estudiantes>();
                Estudiantes estudiante = rp.Buscar(inscripciones.EstudianteId);
                estudiante.Balance += inscripciones.Monto;
                db.Entry(estudiante).State = EntityState.Modified;
                if (db.Inscripciones.Add(inscripciones) != null)
                {
                    db.SaveChanges();
                    paso = true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose(); // Siempre hay que cerrar la conexion;
            }
            return paso;
        }

        public bool Modificar(Inscripciones inscripciones)
        {
 
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                /*var Anterior = db.Inscripciones.Find(persona.PersonaId);
                foreach (var item in Anterior.telefonos)
                {
                    if (!persona.telefonos.Exists(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;
                }
                db.Entry(persona).State = EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }*/
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Inscripciones.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);

            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return paso;
        }

        public static Inscripciones Buscar(int id)
        {
            Contexto db = new Contexto();
            Inscripciones persona = new Inscripciones();
            try
            {
                persona = db.Inscripciones.Find(id);
                persona.Asignatura.Count();//Haciendo llamada a lazyloading al cargar los detalles
            }
            catch (Exception)
            { throw; }
            finally
            { db.Dispose(); }
            return persona;
        }

        public static List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> expression)
        {
            List<Inscripciones> Lista = new List<Inscripciones>();
            Contexto db = new Contexto();
            try
            {
                Lista = db.Inscripciones.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }

    }
}
