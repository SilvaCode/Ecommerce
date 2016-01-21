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
    public class EmailTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Em_Branco()
        {
            Email email = new Email(String.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Null()
        {
            Email email = new Email(null);
        }

        [TestMethod]
        public void Email_New_Valido()
        {
            string endereco = "isaac.candeirasilva@gmail.com";
            Email email = new Email(endereco);
            Assert.AreEqual(endereco, email.Endereco);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_InValido()
        {
            string endereco = "trolololo";
            Email email = new Email(endereco);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Email_New_Erro_Tamanho_Excedido()
        {
            string endereco = "isaac.candeirasilva@gmail.com";
            while(endereco.Length < Email.EnderecoMaxLength )
            {
                endereco += "isaac.candeirasilva@gmail.com";
            }          
            Email email = new Email(endereco);
        }
    }
}
