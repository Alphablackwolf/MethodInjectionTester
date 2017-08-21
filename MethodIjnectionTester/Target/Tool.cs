namespace MethodIjnectionTester.Target
{
    public abstract class Tool : Item
    {
        private string _usageSubject;

        public  string Name => "Tool";

        protected Tool()
        {
            _usageSubject = "bob";
        }


        public virtual void Use()
        {
            Logger.LogInformation("Base Use Class.");
        }
    }
}
