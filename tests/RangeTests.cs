using api.Controllers;
using System;
using System.Collections.Generic;
using Xunit;

namespace tests
{
    public class RangeTests
    {
        [Fact]
        public void CountShouldControlNumberOfResults()
        {
            var range = new Range { Count = 3 };
            var generated = range.Of(() => "");
            List<string> generaredList = new List<string>(generated);
            Assert.Equal(3, generaredList.Count);
        }
    }
}
