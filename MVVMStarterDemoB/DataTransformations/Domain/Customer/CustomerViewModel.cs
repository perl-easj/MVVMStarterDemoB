using DataTransformation.Implementation;

namespace MVVMStarterDemoB.DataTransformations.Domain.Customer
{
    public class CustomerViewModel : TransformedWithDefaultBase<Models.Domain.Customer.Customer>
    {
        public string FullName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int ZipCode { get; set; }

        public string City { get; set; }

        public int MinPrice { get; set; }

        public int MaxPrice { get; set; }

        public bool NewsLetter { get; set; }

        public int ImageKey { get; set; }

        public override void SetDefaultValues()
        {
            Key = NullKey;
            FullName = "(not set)";
            Phone = "(not set)";
            Email = "(not set)";
            Address = "(not set)";
            ZipCode = 0;
            City = "(not set)";
            MinPrice = 0;
            MaxPrice = 0;
            NewsLetter = false;
            ImageKey = NullKey;
        }

        public override void SetValuesFromObject(Models.Domain.Customer.Customer customerObj)
        {
            Key = customerObj.Key;
            FullName = customerObj.FullName;
            Phone = customerObj.Phone;
            Email = customerObj.Email;
            Address = customerObj.Address;
            ZipCode = customerObj.ZipCode;
            City = customerObj.City;
            MinPrice = customerObj.MinPrice;
            MaxPrice = customerObj.MaxPrice;
            NewsLetter = customerObj.NewsLetter;
            ImageKey = customerObj.ImageKey;
        }
    }
}