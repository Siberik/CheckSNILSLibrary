using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSNILSLibrary
{
    public class CheckSNILSClass
    {
        /// <summary>
        /// Расчет контрольной цифры СНИЛС
        /// </summary>
        /// <param name="textString">
        /// Цифры СНИЛС
        /// </param>
        /// <returns>
        /// Возвращает истину(если контрольная сумма правильна) или ложь(если неправильна)
        /// </returns>
        public bool CheckPersonakCode(string textString)
        {
            int sum = 0;
            var text = textString.Split(' ', '-');

            if (textString == string.Empty) 
            {
                return false;
            }
            if (textString.Length!=0)
            {
                return false;
            }
            int i = 9;
           
                for (int z = 0; z < text.Length; z++)
                {
                    sum += i* Convert.ToInt32(Char.GetNumericValue(Convert.ToChar(text[z])));
                    i--;
                }
            var text2= textString.Substring(9, 2);
            if (sum != Convert.ToInt32(Char.GetNumericValue(Convert.ToChar(text2))))
            {
                return false;
            }
            return true;
        }
    }
}
