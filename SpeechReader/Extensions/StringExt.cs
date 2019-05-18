namespace SpeechReader
{
    public static class StringExt
    {
        /// <summary>
        /// An Helper to replace all the ocurrencies of a char
        /// </summary>
        /// <param name="_string">The default string</param>
        /// <param name="_cur">The Current char</param>
        /// <param name="_new">The New char</param>
        /// <returns>The new string</returns>
        public static string ReplaceAllChars(this string _string, char _cur, char _new)
        {
            // Replacing the danger characters
            var set = "";
            foreach (var c in _string)
            {
                var aux = c;

                if (aux == _cur)
                    aux = _new;

                set += aux;
            }
            _string = set;
            // End Replacing the danger characters

            return _string;
        }
    }

}
