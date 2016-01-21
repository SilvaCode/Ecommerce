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
    public class CPFTests
    {
        public string nrCPF { get { return "36728796819"; } }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CPF_New_Branco()
        {
            CPF cpf = new CPF(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CPF_New_Nulo()
        {
            CPF cpf = new CPF(null);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CPF_New_Erro_Tamanho_Excedido()
        {
            string cpfExceeed = "99999999";
            while (cpfExceeed.Length < CPF.CPFMaxlength)
            {
                cpfExceeed += "999999999999999";
            }
            CPF cpf = new CPF(cpfExceeed);
        }

        [TestMethod]
        public void CPF_New_Valido()
        {
            CPF cpf = new CPF(nrCPF);
            Assert.AreEqual(cpf.cpf, nrCPF);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CPF_New_InValido()
        {
            string invalidCPF = "65982698809";
            CPF cpf = new CPF(invalidCPF);
        }

    }
}
