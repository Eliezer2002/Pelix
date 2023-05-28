
using Microsoft.EntityFrameworkCore;

namespace Pelix.DAL.Core
{
    public class IDbfactory
    {
        DbContext GetDbContext { get; }
    }
}
