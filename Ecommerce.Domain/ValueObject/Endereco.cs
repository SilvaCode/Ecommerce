using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialEcommerce.Domain.Enuns;

namespace Ecommerce.Domain.ValueObject
{
    public class Endereco
    {
        public const int LogradouroMaxLength = 50;
        public virtual string Logradouro { get; set; }

        public const int ComplementoMaxLength = 150;
        public virtual string Complemento { get; set; }

        public const int NumeroMaxLength = 50;
        public virtual string Numero { get; set; }

        public const int BairroMaxLength = 150;
        public virtual string Bairro { get; set; }

        public const int CidadeMaxLength = 150;
        public virtual string Cidade { get; set; }

        public Uf Uf { get; set; }

        public CEP cep { get; set; }


    }
}
