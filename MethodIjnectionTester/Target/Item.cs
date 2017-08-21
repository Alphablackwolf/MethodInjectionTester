namespace MethodIjnectionTester.Target
{
    public abstract class Item
    {
        public virtual string DisplayName { get; set; }

        //public virtual string Name { get; }

        public virtual int Stack { get; set; }
    }
}
