using NUnit.Framework;

namespace NUnitSample
{
    [TestFixture(typeof(int))]
    [TestFixture(typeof(string))]
    public class GenericTestFixture<T>
    {
        [Test]
        public void TestType()
        {
            Assert.Pass($"The generic test type is {typeof(T)}");
        }
    }
}
