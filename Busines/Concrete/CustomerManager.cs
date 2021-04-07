using Busines.Abstract;
using Busines.Constant;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;
        
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
       
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);

        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerNotAdded);
        }

       
        public IDataResult<List<Customer>> GetAll
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

    public IDataResult<List<CustomerDetailDto>> GetCustomerDetailDto()
        {
        return new SuccessDataResult<Customer>(_customerDal.Get(cus => cus.CustomerId = customerId));
        }

        public IResult Update(Customer customer)
        {
        _customerDal.Update(Customer);
        return new SuccessResult(Messages.Updated);
        }
    }
}
