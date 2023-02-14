namespace CheckSNILSLibrary
{
    public class CheckPersonalClass
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

            if (textString == null)
            {
                return false;
            }
            if (textString.Length > 11 || textString.Length < 11)
            {
                return false;
            }

            for (int i = 9; i > 0; i--)
            {
                for (int z = 0; z < text.Length; z++)
                {
                    sum += Convert.ToInt32(Char.GetNumericValue(Convert.ToChar(text[i]))) * Convert.ToInt32(Char.GetNumericValue(Convert.ToChar(text[z])));
                }
            }
            if (sum != (Convert.ToInt32(text[9]) + Convert.ToInt32(text[10]))){
                return false;
            }
            return true;
        }
    } 
}