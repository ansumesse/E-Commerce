﻿namespace E_Commerce.Models.UserFile
{
    public class UserAddresses
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public bool IsDefault { get; set; }
        public virtual User? User { get; set; }

        public virtual UserAddress? UserAddress { get; set; }
    }
}
