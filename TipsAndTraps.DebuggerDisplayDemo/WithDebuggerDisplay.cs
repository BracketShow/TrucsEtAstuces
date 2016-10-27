using System.Diagnostics;

namespace TipsAndTraps.DebuggerDisplayDemo
{
    [DebuggerDisplay("Name: {Name}, Value: {Value}")]
    public class WithDebuggerDisplay
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
