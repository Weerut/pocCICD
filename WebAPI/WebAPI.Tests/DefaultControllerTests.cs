using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAPI.Tests
{
    [TestFixture]
    public class DefaultControllerTests
    {
        [Test]
        public void MakeSureTestIsWorking()
        {
            string emptyString = string.Empty;
            Assert.IsEmpty(emptyString);
        }
    }
}
