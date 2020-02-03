using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitSample
{
    [TestFixture]
    public class CustomExceptionTests
    {
        [Test]
        [CustomException(typeof(ArgumentException))]
        public void HandlesArgumentExceptionAsType()
        {
            throw new ArgumentException();
        }

    }
}
