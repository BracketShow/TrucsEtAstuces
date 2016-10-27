using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TipsAndTraps.DebuggerDisplayDemo
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test()
        {
            var withoutDebuggerDisplay = new WithoutDebuggerDisplay()
            {
                Name = "Eric",
                Value = 10
            };

            var withDebuggerDisplay = new WithDebuggerDisplay()
            {
                Name = "Eric",
                Value = 10
            };

            var list1 = new List<WithoutDebuggerDisplay>();
            for (int i = 0; i < 10; i++)
            {
                list1.Add(new WithoutDebuggerDisplay()
                {
                    Name = "Eric" + i,
                    Value = i
                });
            }

            var list2 = new List<WithDebuggerDisplay>();
            for (int i = 0; i < 10; i++)
            {
                list2.Add(new WithDebuggerDisplay()
                {
                    Name = "Eric" + i,
                    Value = i
                });
            }
        }
    }
}