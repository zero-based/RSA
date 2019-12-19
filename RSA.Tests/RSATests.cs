using Microsoft.VisualStudio.TestTools.UnitTesting;
using Type.BigInteger;

namespace Crypto.RSA.Tests
{
    [TestClass]
    public class RSATests
    {
        [DataTestMethod]
        [DynamicData(nameof(DataSet.Encrypt), typeof(DataSet), DynamicDataSourceType.Method)]
        public void EncryptTest(string n, string e, string m, string output)
        {
            var operand1 = new BigInteger(n);
            var operand2 = new BigInteger(e);
            var operand3 = new BigInteger(m);
            var actual = RSA.Encrypt(operand1, operand2, operand3);
            var expected = new BigInteger(output);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DynamicData(nameof(DataSet.Decrypt), typeof(DataSet), DynamicDataSourceType.Method)]
        public void DecryptTest(string n, string e, string m, string output)
        {
            var operand1 = new BigInteger(n);
            var operand2 = new BigInteger(e);
            var operand3 = new BigInteger(m);
            var actual = RSA.Decrypt(operand1, operand2, operand3);
            var expected = new BigInteger(output);
            Assert.AreEqual(expected, actual);
        }
    }
}
