namespace MethodIjnectionTester.Target
{
    public class WateringCan : Tool
    {
        public override void Use()
        {
            base.Use();
            Logger.LogInformation("Watering Can Used.");
        }
    }

}
