using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoCurrencyModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoCurrencyModule.Tests
{
    [TestClass()]
    public class PubMethodTests
    {
        [TestMethod()]
        public void DateTimeToUnixTimestampTest()
        {
            long l = PubMethod.DateTimeToUnixTimestamp(DateTime.Now);
            Assert.AreEqual(l, 1);
        }

        [TestMethod()]
        public void UnixTimestampToDateTimeTest()
        {
            long l = 1565262086911;
            DateTime timReult = PubMethod.UnixMillisecondsTimestampToDateTime(l);
            Assert.Fail(timReult.ToString(), "1");
        }
    }
}