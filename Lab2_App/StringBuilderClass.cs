using System.Text;

namespace Lab2_App
{
    public class StringBuilderClass
    {
        private StringBuilder text = new StringBuilder();
        public string GetStrText => text.ToString();

        public StringBuilderClass(string text)
        {
            try
            {
                this.text = new StringBuilder(text == null ? "" : text);
            }
            catch 
            {
                this.text = new StringBuilder("");
            }
        }

        public StringBuilder FindUniqueWord()
        {
            if (text.Length == 0)
                return new StringBuilder("Не знайдено");

            int firstSentenceEnd = text.Length;

            for (int i = 0; i < text.Length; i++)
            {
                if (".!?".Contains(text[i]))
                {
                    firstSentenceEnd = i;
                    break;
                }
            }

            StringBuilder word = new StringBuilder();
            for (int i = 0; i < firstSentenceEnd; i++)
            {
                if (char.IsLetterOrDigit(text[i]))
                {
                    word.Append(text[i]);
                }
                else
                {
                    if (word.Length > 0)
                    {
                        if (!IsWordInText(word, firstSentenceEnd))
                            return new StringBuilder(word.ToString());

                        word.Clear();
                    }
                }
            }

            if (word.Length > 0)
            {
                if (!IsWordInText(word, firstSentenceEnd))
                    return new StringBuilder(word.ToString());
            }

            return new StringBuilder("Не знайдено");
        }

        private bool IsWordInText(StringBuilder word, int startI)
        {
            StringBuilder currentWord = new StringBuilder();

            for (int i = startI; i < text.Length; i++)
            {
                if (char.IsLetterOrDigit(text[i]))
                {
                    currentWord.Append(text[i]);
                }
                else
                {
                    if (currentWord.Length > 0)
                    {
                        if (IsEqual(word, currentWord)) return true;
                        currentWord.Clear();
                    }
                }
            }

            return currentWord.Length > 0 && IsEqual(word, currentWord);
        }

        private bool IsEqual(StringBuilder sb1, StringBuilder sb2)
        {
            if (sb1.Length != sb2.Length) return false;

            for (int i = 0; i < sb1.Length; i++)
            {
                if (char.ToLowerInvariant(sb1[i]) != char.ToLowerInvariant(sb2[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

