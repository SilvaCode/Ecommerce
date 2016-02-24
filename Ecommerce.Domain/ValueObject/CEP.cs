using Ecommerce.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecommerce.Domain.ValueObject
{
    public class CEP
    {
        public Int64? _CepCod { get; private set; }
        public const int CepMaxLength = 8;

        public CEP()
        {

        }

        public CEP(string cep)
        {
            Guard.ForNullOrEmpty(cep, "CEP não pode ser nulo ou em branco");
            cep = TextoHelper.GetNumeros(cep);
            Guard.StringLength("Tamanho do CEP excedido", cep, CepMaxLength);

            try
            {
                this._CepCod = Convert.ToInt64(cep);
            }
            catch (Exception)
            {
                throw new Exception("CEP Inválido");
            }
        }

        public bool Vazio()
        {
            return !this._CepCod.HasValue;
        }

        public object GetCepFormatado()
        {
            if (this._CepCod == null)
                return string.Empty;

            var cep = this._CepCod.ToString();

            while (cep.Length < 8)
                cep = "0" + cep;

            return cep.Substring(0, 5) + "-" + cep.Substring(5);
        }
    }
}
