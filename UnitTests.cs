using Microsoft.VisualStudio.TestTools.UnitTesting;
using TragamonedasApp.Models;
using TragamonedasApp.Services;

namespace TragamonedasApp.Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestRegistrarMaquina()
        {
            var service = new MaquinaService();
            service.RegistrarMaquina(new Maquina { Codigo = "M001", Ubicacion = "Sala 1", Estado = "Operativa" });
            Assert.AreEqual(1, service.ObtenerMaquinas().Count);
        }
    }
}