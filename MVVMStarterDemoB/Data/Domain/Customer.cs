﻿using MVVMStarterDemoB.Data.Base;

namespace MVVMStarterDemoB.Data.Domain
{
    public class Customer : DomainAppBase
    {
        public Customer(int key, int imageKey, string fullName, string phone, string email, string address, int zipCode, string city, int minPrice, int maxPrice, bool newsLetter)
            : base(key, imageKey)
        {
            FullName = fullName;
            Phone = phone;
            Email = email;
            Address = address;
            ZipCode = zipCode;
            City = city;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            NewsLetter = newsLetter;
        }

        public Customer() : base(NullKey, NullKey)
        {
        }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public bool NewsLetter { get; set; }
    }
}
