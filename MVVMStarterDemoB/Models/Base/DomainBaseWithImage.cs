using DataTransformation.Implementation;

namespace MVVMStarterDemoB.Models.Base
{
    public abstract class DomainBaseWithImage : CopyableBase
    {
        public int ImageKey { get; set; }

        protected DomainBaseWithImage(int key, int imageKey) : base(key)
        {
            ImageKey = imageKey;
        }
    }
}