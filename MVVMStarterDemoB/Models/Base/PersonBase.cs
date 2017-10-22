using ExtensionsModel.Implementation;

namespace MVVMStarterDemoB.Models.Base
{
    public abstract class PersonBase : ClassWithImage
    {
        private string _fullName;
        private string _phone;
        private string _email;

        protected PersonBase(int key, int imageKey, string fullName, string phone, string email)
            : base(key, imageKey)
        {
            _fullName = fullName;
            _phone = phone;
            _email = email;
        }
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}