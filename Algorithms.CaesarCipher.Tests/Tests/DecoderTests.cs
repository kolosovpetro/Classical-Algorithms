using System;
using System.Linq;
using Algorithms.CaesarCipher.Cipher;
using FluentAssertions;
using NUnit.Framework;

namespace Algorithms.CaesarCipher.Tests.Tests
{
    [TestFixture]
    public class DecoderTests
    {
        [Test]
        public void SkipTakeConcatTest()
        {
            const int shift = 23;
            var skip = Decoder.Alphabet.Skip(shift).ToArray();
            skip.Length.Should().Be(3);
            skip[0].Should().Be('X');
            skip[1].Should().Be('Y');
            skip[2].Should().Be('Z');

            var take = Decoder.Alphabet.Take(shift).ToArray();
            take.Length.Should().Be(23);
            take[0].Should().Be('A');
            take[22].Should().Be('W');

            var concat = skip.Concat(take).ToArray();
            concat.Length.Should().Be(26);
            concat[0].Should().Be('X');
            concat[1].Should().Be('Y');
            concat[2].Should().Be('Z');
            concat[25].Should().Be('W');
        }
        
        [Test]
        public void DecodeAlphabetTest()
        {
            Action act = () => Decoder.DecodeAlphabet(-1);
            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Shift must be greater or equal 0");

            var decodedAlphabet = Decoder.DecodeAlphabet(23);
            decodedAlphabet.Length.Should().Be(26);
            decodedAlphabet[0].Should().Be('X');
            decodedAlphabet[1].Should().Be('Y');
            decodedAlphabet[2].Should().Be('Z');
            decodedAlphabet[3].Should().Be('A');
            decodedAlphabet[4].Should().Be('B');
            decodedAlphabet[5].Should().Be('C');
            decodedAlphabet[25].Should().Be('W');

            Array.IndexOf(decodedAlphabet, 'Q').Should()
                .Be(Decoder.Alphabet.IndexOf('T'));

            decodedAlphabet.Contains(Char.ToUpper('q')).Should().BeTrue();
        }
        
        [Test]
        public void DecodeStringTest()
        {
            Action act = () => Decoder.Decode("abcd", -1);
            act.Should().Throw<InvalidOperationException>()
                .WithMessage("Shift must be greater or equal 0");

            Decoder.Decode("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG", 23)
                .Should().Be("QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD");
        }
    }
}