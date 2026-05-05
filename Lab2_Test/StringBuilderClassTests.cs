using Lab2_App;

namespace Lab2_Test
{
    public class StringBuilderClassTests
    {
        [Fact]
        public void Constructor_InitializeSB()
        {
            StringBuilderClass sb = new StringBuilderClass("Це текст");

            Assert.Equal("Це текст", sb.GetStrText);
        }

        [Fact]
        public void Constructor_WithNull_InitializesEmptySB()
        {
            StringBuilderClass sb = new StringBuilderClass(null);

            Assert.Equal("", sb.GetStrText);
        }

        [Fact]
        public void FindUniqueWord_ReturnUniqueWord()
        {
            string text = "Його дім розташований там. А дім його друга - навпроти";
            StringBuilderClass sb = new StringBuilderClass(text);

            string result = sb.FindUniqueWord().ToString();

            Assert.Equal("розташований", result);
        }

        [Fact]
        public void FindUniqueWord_CaseDifference_ReturnUniqueWord()
        {
            string text = "Його дім розташований там. Дім його друга - навпроти. Його звати Дмитро";
            StringBuilderClass sb = new StringBuilderClass(text);

            string result = sb.FindUniqueWord().ToString();

            Assert.Equal("розташований", result);
        }

        [Fact]
        public void FindUniqueWord_LastWord_ReturnUniqueWord()
        {
            string text = "Його дім - там. Дім його друга - навпроти. Його звати Дмитро";
            StringBuilderClass sb = new StringBuilderClass(text);

            string result = sb.FindUniqueWord().ToString();

            Assert.Equal("там", result);
        }

        [Fact]
        public void FindUniqueWord_NoUniqueWords_ReturnNotFoundMessage()
        {
            string text = "Його дім розташований там. Дім його друга також розташований там";
            StringBuilderClass sb = new StringBuilderClass(text);

            string result = sb.FindUniqueWord().ToString();

            Assert.Equal("Не знайдено", result);
        }

        [Fact]
        public void FindUniqueWord_EmptyText_ReturnNotFoundMessage()
        {
            StringBuilderClass sb = new StringBuilderClass("");

            string result = sb.FindUniqueWord().ToString();

            Assert.Equal("Не знайдено", result);
        }
    }
}
