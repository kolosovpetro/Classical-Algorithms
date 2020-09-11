using Algorithms.CaesarCipher.Cipher;
using FluentAssertions;
using NUnit.Framework;

namespace Algorithms.CaesarCipher.Tests.Tests
{
    [TestFixture]
    public class EncoderTests
    {
        [Test]
        public void EncodeTest()
        {
            // encode test
            Encoder.Encode("QEB NRFZH YOLTK CLU GRJMP LSBO QEB IXWV ALD", 23)
                .Should().Be("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG");
        }
    }
}