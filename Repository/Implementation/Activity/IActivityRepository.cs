using Repository.Core;
using Repository.Implementation.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation.Activity
{
    public interface IActivityRepository : IReposotory<Activity>
    {
        void InsertUserActivity(Usuario usuario, TypeActivity tipoActividad);
    }
}
