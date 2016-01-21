using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Helpers.Tests
{
    [TestClass]
    public class GuardTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpty_Erro_Quando_Em_Branco()
        {
            Guard.ForNullOrEmpty(string.Empty, "Valor não pode ser vazio.");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Guard_ForNullOrEmpty_Erro_Quando_Em_Null()
        {
            Guard.ForNullOrEmpty(string.Empty, "Valor não pode ser nulo.");
        }
    }
}
