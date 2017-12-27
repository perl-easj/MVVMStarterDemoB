using Data.InMemory.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Base
{
    public class PersistentDataAppBase : StorableBase
    {
        public int Id
        {
            get { return Key; }
            set { Key = value; }
        }
    }
}