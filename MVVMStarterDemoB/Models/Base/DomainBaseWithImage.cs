namespace MVVMStarterDemoB.Models.Base
{
    public abstract class DomainBaseWithImage<T> : DomainBase<T>
    {
        public int ImageKey { get; set; }

        protected DomainBaseWithImage(int key, int imageKey) : base(key)
        {
            ImageKey = imageKey;
        }
    }
}