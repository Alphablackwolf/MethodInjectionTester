using MethodIjnectionTester.Target;

namespace MethodIjnectionTester.Source
{
    public class BetterShears : Tool
    {
        public new void Use()
        {
            base.Use();
            Logger.LogInformation("Better Shears Used.");
        }
    }
}
