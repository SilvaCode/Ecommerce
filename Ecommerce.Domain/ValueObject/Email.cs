using Ecommerce.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ecommerce.Domain.ValueObject
{
    public class Email
    {
        public const int EnderecoMaxLength = 254;
        public string Endereco { get; private set; }

        protected Email()
        {

        }

        public Email(string endereco)
        {
            Guard.ForNullOrEmpty(endereco, "E-mail");
            Guard.StringLength("E-mail", endereco, EnderecoMaxLength);

            if (!IsValid(endereco))
                throw new Exception("E-mail inválido");

            this.Endereco = endereco;
        }

        public static bool IsValid(string email) 
        {
            var regexEmail = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            return regexEmail.IsMatch(email);
        }
    }

}
