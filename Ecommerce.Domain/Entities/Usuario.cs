using Ecommerce.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities
{
    public class Usuario : EntityBase
    {
        public CPF CPF { get; set; }
        public Email Email { get; set; }
        public string Login { get; set; }
        public Endereco Endereco { get; set; }
    }
}
