using Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation.User
{
    public class UserRepository : Repository<Usuario> , IUserReposotory
    {
        public UserRepository(MyDbContext myDbContext) : base(myDbContext)
        { }
    }
}
