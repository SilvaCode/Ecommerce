using Ecommerce.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Tests.ValueObject
{
    [TestClass]
    public class CEPTests
    {
        [TestMethod]
        public void Cep_New_Valido() 
        {
            var cep = "11432-010";
            var obj = new CEP(cep);
            Assert.AreEqual(11432010, obj._CepCod);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cep_New_Invalido()
        {
            var cep = "kjdklwq";
            var obj = new CEP(cep);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cep_New_Branco()
        {
            var cep = string.Empty;
            var obj = new CEP(cep);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cep_New_Nulo()
        {
            var obj = new CEP(null);
        }

        [TestMethod]
        public void Cep_Get_CEP_Formatado_11432010() 
        {
            var cep = "11432-010";
            var obj = new CEP(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }

        [TestMethod]
        public void Cep_Get_CEP_Formatado_00000000()
        {
            var cep = "00000-000";
            var obj = new CEP(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }

        [TestMethod]
        public void Cep_Get_CEP_Formatado_12345678()
        {
            var cep = "12345-678";
            var obj = new CEP(cep);
            Assert.AreEqual(cep, obj.GetCepFormatado());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Cep_New_Tamanho_Excedido()
        {
            string cep = "23132132312321313";
            while (cep.Length < CEP.CepMaxLength)
                cep += cep;

            CEP obj = new CEP(cep);
        }
    }
}
