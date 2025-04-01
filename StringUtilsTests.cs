using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrossPlatformUtils;

namespace CrossPlatformUtils.Tests
{
    [TestClass]
    public class StringUtilsTests
    {
        [TestMethod]
        public void Reverse_ShouldReverseString()
        {
            Assert.AreEqual("olleH", StringUtils.Reverse("Hello"));
        }

        [TestMethod]
        public void Reverse_ShouldReturnNullForNullInput()
        {
            Assert.IsNull(StringUtils.Reverse(null));
        }
    }
}
