using System;
using DBOImplementation;

namespace MVVMStarterDemoB.Models.Domain.Customer
{
    public class CustomerDBO : DBOBase
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public int ZipCode { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int ImageKey { get; set; }

        public int MinPrice { get; set; }

        public int MaxPrice { get; set; }

        public bool NewsLetter { get; set; }

        public override void SetValuesFromObject(object obj)
        {
            Customer customerObj = (obj as Customer);
            if (customerObj == null)
            {
                throw new ArgumentException(nameof(SetValuesFromObject));
            }

            Id = customerObj.Key;
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