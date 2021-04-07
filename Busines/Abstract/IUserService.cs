using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IUserService
    {
        IResult Add(Users user);
        IResult Update(Users user);
        IResult Delete(Users user);
        IDataResult<List<Users>> GetAll();
        IDataResult<Users> GetById(int Id);

    }
}
