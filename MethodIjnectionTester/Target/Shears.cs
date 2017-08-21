namespace MethodIjnectionTester.Target
{
    public class Shears : Tool
    {
        public override void Use()
        {
            base.Use();
            Logger.LogInformation("Shears Used.");
        }
    }

}
