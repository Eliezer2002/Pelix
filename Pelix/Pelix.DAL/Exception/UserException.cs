using System;

namespace Pelix.DAL.Exception
{
    public class UserException : SystemException
    {
        public UserException( string message ) : base( message ) 
        {
            
        }
    }
}
