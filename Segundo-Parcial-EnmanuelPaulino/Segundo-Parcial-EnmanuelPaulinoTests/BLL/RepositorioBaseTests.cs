using Microsoft.VisualStudio.TestTools.UnitTesting;
using Segundo_Parcial_EnmanuelPaulino.BLL;
using Segundo_Parcial_EnmanuelPaulino.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial_EnmanuelPaulino.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas = new Asignaturas();
            asignaturas.AsignaturasId = 0;
            asignaturas.Descripcion ="enmaneuel";
            asignaturas.Creditos = 0;

            Assert.AreEqual(true, db.Guardar(asignaturas));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas = new Asignaturas();
            asignaturas.AsignaturasId = 1;
            asignaturas.Descripcion = "jsose";
            asignaturas.Creditos = 24;

            Assert.AreEqual(true, db.Guardar(asignaturas));

        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas = new Asignaturas();
            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas = new Asignaturas();
            Assert.IsNotNull(db.GetList(t=>true));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Asignaturas asignaturas = new Asignaturas();
            Assert.IsTrue(db.Eliminar(1));
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }
    }
}