using System;

namespace Pelix.Web.Exception
{
    public class UserException : SystemException
    {
        public UserException( string message ) : base( message ) 
        {
            
        }
    }
}
