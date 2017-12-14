using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RecipeScraper
{
   public static class RegexTool
    {
        public static string GetNumber(string value)
        {
            string number = string.Empty;
            if (value == "")
                 return  number = "0";
           
            string resultado = string.Empty;
            Regex rg = new Regex(@"(\d+)\s*");
            Match busqueda = rg.Match(value);
            if (busqueda.Success)
            {
                 number = busqueda.Groups[1].Value;
                
                resultado = number;
            }
            return resultado;
        }
        public static bool isUrl(String s)
        {
            if (s.Substring(s.Count() - 1) != "/")
                return false;

            String regex = "^(https?://)?(([\\w!~*'().&=+$%-]+: )?[\\w!~*'().&=+$%-]+@)?(([0-9]{1,3}\\.){3}[0-9]{1,3}|([\\w!~*'()-]+\\.)*([\\w^-][\\w-]{0,61})?[\\w]\\.[a-z]{2,6})(:[0-9]{1,4})?((/*)|(/+[\\w!~*'().;?:@&=+$,%#-]+)+/*)$";

            try
            {
                Regex patt = new  Regex(regex);
                Match matcher = patt.Match(s);
                return matcher.Success;
            }
            catch (Exception e)
            {
                return false;
            }
           
        }
    }
}
