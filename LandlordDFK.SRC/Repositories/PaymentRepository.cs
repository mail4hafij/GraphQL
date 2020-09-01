using System;
using System.Collections.Generic;
using System.Linq;
using Landlord.SRC.Models;
using Landlord.SRC.Repositories.Contracts;

namespace Landlord.SRC.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        
        public PaymentRepository()
        {
            
        }

        public IEnumerable<Payment> GetAllForProperty(int propertyId)
        {
            return new List<Payment>
            {
                new Payment
                {
                    Id = 1,
                    PropertyId = 1,
                    DateCreated = DateTime.Now,
                    DateOverdue = DateTime.Now.AddDays(3),
                    Paid = false,
                    Property = new Property
                    {
                        Id = 1,
                        City = "Uppsala",
                        Family = "family",
                        Name = "name",
                        Street = "street",
                        Value = 123
                    },
                    Value = 123
                },
                new Payment
                {
                    Id = 2,
                    PropertyId = 1,
                    DateCreated = DateTime.Now,
                    DateOverdue = DateTime.Now.AddDays(3),
                    Paid = true,
                    Property = new Property
                    {
                        Id = 1,
                        City = "Uppsala",
                        Family = "family",
                        Name = "name",
                        Street = "street",
                        Value = 123
                    },
                    Value = 123
                }
            };
        }
        public IEnumerable<Payment> GetAllForProperty(int propertyId, int lastAmount)
        {
            return new List<Payment>
            {
                new Payment
                {
                    Id = 1,
                    PropertyId = 1,
                    DateCreated = DateTime.Now,
                    DateOverdue = DateTime.Now.AddDays(3),
                    Paid = false,
                    Property = new Property
                    {
                        Id = 1,
                        City = "Uppsala",
                        Family = "family",
                        Name = "name",
                        Street = "street",
                        Value = 123
                    },
                    Value = 123
                },
                new Payment
                {
                    Id = 2,
                    PropertyId = 1,
                    DateCreated = DateTime.Now,
                    DateOverdue = DateTime.Now.AddDays(3),
                    Paid = true,
                    Property = new Property
                    {
                        Id = 1,
                        City = "Uppsala",
                        Family = "family",
                        Name = "name",
                        Street = "street",
                        Value = 123
                    },
                    Value = 123
                }
            };
        }
    }
}
