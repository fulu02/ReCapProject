using Busines.Abstract;
using Busines.Constant;
using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class UserManager : IUserService

    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(Users user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.CarAdded);
        }

       
        public IResult Delete(Users user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.RentalNotAdded);
        }


        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll());
        }

        public IDataResult<Users> GetById(int userId)
        {
            return new SuccessDataResult<Users>(_userDal.Get(u => u.UserId == userId));
        }

        public IResult Update(Users user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.CarUpdated);
        }

      

      
    }
}
