
using Abp.Domain.Repositories;
using AutoMapper;
using Shopping_Card.Customer.BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Card.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Entities.Customer> repository;

        public CustomerService(IRepository<Entities.Customer> repository, IMapper mapper)
        {
            this.mapper = mapper;
            this.repository = repository;
        }
        public IEnumerable<CustomerBO> GetAllCustomer()
        {
            var customers = repository.GetAll();
            var query = mapper.Map<IEnumerable<CustomerBO>>(customers);
            return query;
        }
    }
}
