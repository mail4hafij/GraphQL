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
                    ObjectNumber = "1101",
                    Street = "Stenhagen",
                    City = "Uppsala",
                    PostalCode = "75267",
                    Country = "Sweden",
                    Payments = new List<Payment>
                    {
                        new Payment
                        {
                            Id = 1,
                            PropertyId = 1,
                            DateCreated = DateTime.Now,
                            DateOverdue = DateTime.Now.AddDays(3),
                            Paid = false,
                            Value = 4000
                        },
                        new Payment
                        {
                            Id = 2,
                            PropertyId = 1,
                            DateCreated = DateTime.Now,
                            DateOverdue = DateTime.Now.AddDays(3),
                            Paid = true,
                            Value = 6000
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
                ObjectNumber = "1101",
                Street = "Stenhagen",
                City = "Uppsala",
                PostalCode = "75267",
                Country = "Sweden",
                Payments = new List<Payment>
                {
                    new Payment
                    {
                        Id = 1,
                        PropertyId = 1,
                        DateCreated = DateTime.Now,
                        DateOverdue = DateTime.Now.AddDays(3),
                        Paid = false,
                        Value = 4000
                    },
                    new Payment
                    {
                        Id = 2,
                        PropertyId = 1,
                        DateCreated = DateTime.Now,
                        DateOverdue = DateTime.Now.AddDays(3),
                        Paid = true,
                        Value = 6000
                    }
                }
            };
        }

        public Property Add(Property property)
        {
            return new Property
            {
                Id = 1,
                ObjectNumber = property.ObjectNumber,
                Street = property.Street,
                City = property.City,
                PostalCode = property.PostalCode,
                Country = property.Country,
                Payments = new List<Payment>
                {
                    new Payment
                    {
                        Id = 1,
                        PropertyId = 1,
                        DateCreated = DateTime.Now,
                        DateOverdue = DateTime.Now.AddDays(3),
                        Paid = false,
                        Value = 5000
                    },
                    new Payment
                    {
                        Id = 2,
                        PropertyId = 1,
                        DateCreated = DateTime.Now,
                        DateOverdue = DateTime.Now.AddDays(3),
                        Paid = true,
                        Value = 5000
                    }
                }
            };
        }
    }
}
