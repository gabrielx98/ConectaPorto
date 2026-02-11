using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectaPorto.Formatadores
{
    public class CnpjFormatador
    {
        public static string IncluirMascara(long cnpj)
        {
            if (cnpj == 0) return null;
            return Convert.ToInt64(cnpj).ToString(@"000\.000\.000\/0000\-00");
        }

        public static long RetirarMascara(string cnpj) { 
            if(string.IsNullOrEmpty(cnpj)) return 0;
            return long.Parse(cnpj.Replace(".", "").Replace("/", "").Replace("-", ""));
        }
    }
}
