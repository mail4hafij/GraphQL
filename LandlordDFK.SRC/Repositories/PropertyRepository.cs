using System;
using System.Collections.Generic;
using System.Linq;
using Landlord.SRC.Models;
using Landlord.SRC.Repositories.Contracts;

namespace Landlord.SRC.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        public PropertyRepository()
        {
        
        }

        public IEnumerable<Property> GetAll()
        {
            return new List<Property>
            {
                new Property
                {
                    Id = 1,
                    City = "Uppsala",
                    Family = "family",
                    Name = "name",
                    Street = "street",
                    Value = 123,
                    Payments = new List<Payment>
                    {
                        new Payment
                        {
                            Id = 1,
                            PropertyId = 1,
                            DateCreated = DateTime.Now,
                            DateOverdue = DateTime.Now.AddDays(3),
                            Paid = false,
                            Value = 123
                        },
                        new Payment
                        {
                            Id = 2,
                            PropertyId = 1,
                            DateCreated = DateTime.Now,
                            DateOverdue = DateTime.Now.AddDays(3),
                            Paid = true,
                            Value = 123
                        }
                    }
                }
            };
        }

        public Property GetById(int id)
        {
            return new Property
            {
                Id = 1,
                City = "Uppsala",
                Family = "family",
                Name = "name",
                Street = "street",
                Value = 123,
                Payments = new List<Payment>
                {
                    new Payment
                    {
                        Id = 1,
                        PropertyId = 1,
                        DateCreated = DateTime.Now,
                        DateOverdue = DateTime.Now.AddDays(3),
                        Paid = false,
                        Value = 123
                    },
                    new Payment
                    {
                        Id = 2,
                        PropertyId = 1,
                        DateCreated = DateTime.Now,
                        DateOverdue = DateTime.Now.AddDays(3),
                        Paid = true,
                        Value = 123
                    }
                }
            };
        }

        public Property Add(Property property)
        {
            return new Property
            {
                Id = 1,
                City = "Uppsala",
                Family = "family",
                Name = "name",
                Street = "street",
                Value = 123,
                Payments = new List<Payment>
                {
                    new Payment
                    {
                        Id = 1,
                        PropertyId = 1,
                        DateCreated = DateTime.Now,
                        DateOverdue = DateTime.Now.AddDays(3),
                        Paid = false,
                        Value = 123
                    },
                    new Payment
                    {
                        Id = 2,
                        PropertyId = 1,
                        DateCreated = DateTime.Now,
                        DateOverdue = DateTime.Now.AddDays(3),
                        Paid = true,
                        Value = 123
                    }
                }
            };
        }
    }
}
