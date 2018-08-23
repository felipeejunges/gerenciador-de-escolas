using System.Text.RegularExpressions;

namespace gerenciador_de_escolas.Utils
{
    public class Util
    {
        public string onlyNumbers(string str) {
            Regex regexObj = new Regex(@"[^\d]");
            return regexObj.Replace(str, "");
        }
    }
}