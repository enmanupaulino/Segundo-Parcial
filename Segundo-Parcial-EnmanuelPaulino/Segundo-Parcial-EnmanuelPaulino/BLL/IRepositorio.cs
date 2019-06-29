using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial_EnmanuelPaulino.BLL
{
    public interface IRespositorio<T> where T : class
    {
        bool Guardar(T entity);
        bool Modificar(T entity);
        T Buscar(int Id);
        List<T> GetList(Expression<Func<T, bool>> expression);
        bool Eliminar(int Id);
    }
}
