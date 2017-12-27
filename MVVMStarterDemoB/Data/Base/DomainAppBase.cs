using Data.InMemory.Implementation;

namespace MVVMStarterDemoB.Data.Base
{
    public abstract class DomainAppBase : StorableBase
    {
        public int ImageKey { get; set; }

        protected DomainAppBase(int key, int imageKey) : base(key)
        {
            ImageKey = imageKey;
        }
    }
}