using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results
{
    public class ErrorDataResult
    {
        public class ErrorDataResult<T> : DataResult<T>
        {
            public ErrorDataResult(T data, string message) : base(data, false, message)
            {

            }
            public ErrorDataResult(T data) : base(data, false)
            {

            }
            public ErrorDataResult(string message) : base(default, false, message)
            {

            }
            public ErrorDataResult() : base(default, false)
            {

            }

            public override bool Equals(object obj)
            {
                return obj is ErrorDataResult<T> result &&
                       Message == result.Message &&
                       Success == result.Success &&
                       EqualityComparer<T>.Default.Equals(Data, result.Data);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Message, Success, success, Data);
            }
        }
    }
}
