using System;
using System.Collections.Generic;
using Xunit;
using Faker;

namespace FakerTest.Lorem
{
    public class LoremTest
    {
        [Fact]
        public void WordTest()
        {
            var word = Faker.Lorem.Word();
            Assert.True(word != null);
        }

        [Fact]
        public void WordsTest()
        {
            var words = Faker.Lorem.Words();
            Assert.True(words != null);
        }

        [Fact]
        public void SentenceTest()
        {
            var sentence = Faker.Lorem.Sentence();
            Assert.True(sentence != null);
        }

        [Fact]
        public void SentencesTest()
        {
            var sentences = Faker.Lorem.Sentences();
            Assert.True(sentences != null);
        }

        [Fact]
        public void ParagraphTest()
        {
            var paragraph = Faker.Lorem.Paragraph();
            Assert.True(paragraph != null);
        }

        [Fact]
        public void ParagraphsTest()
        {
            var paragraphs = Faker.Lorem.Paragraphs();
            Assert.True(paragraphs != null);
        }

        [Fact]
        public void TextTest()
        {
            var text = Faker.Lorem.Text();
            Assert.True(text != null);
        }

        [Fact]
        public void LinesTest()
        {
            var lines = Faker.Lorem.Lines();
            Assert.True(lines != null);
        }
    }

}