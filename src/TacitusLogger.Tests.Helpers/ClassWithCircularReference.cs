
namespace TacitusLogger.Tests.Helpers
{
    public class ClassWithCircularReference
    {
        public ClassWithCircularReference()
        {
            CircularProperty = this;
        }
        public string Name = "Value";
        public ClassWithCircularReference CircularProperty { get; set; }
    }
}
