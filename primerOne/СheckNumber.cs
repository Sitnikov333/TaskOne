using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TaskOne
{
    // Проверка значения 00XX00XX-00X (12 Элементов строки)
    public class СheckNumber 
    {
        private const string CheckRegExp = @"\d{2}[A-z]{2}\d{2}[A-z]{2}-\d{2}[A-z]$";
        public bool Check(string num) => Regex.IsMatch(num, CheckRegExp, RegexOptions.IgnoreCase);
    }
}
