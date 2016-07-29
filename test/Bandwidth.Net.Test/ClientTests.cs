using System;
using Xunit;
using Bandwidth.Net;

namespace Bandwidth.Net.Test
{
    public class ClientTests
    {
        [Fact]
        public void TestConstructor()
        {
            var api = new Client("userId", "apiToken", "apiSecret");
        }

        [Fact]
        public void TestConstructorWithEmprtyParams()
        {
            Assert.Throws<MissingCredentialsException>(() => new Client("", "apiToken", "apiSecret"));
        }
    }
}
