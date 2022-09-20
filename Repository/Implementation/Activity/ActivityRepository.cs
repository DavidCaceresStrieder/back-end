using Repository.Core;
using Repository.Implementation.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation.Activity
{
    public class ActivityRepository : Repository<Activity> , IActivityRepository
    {
        public ActivityRepository(MyDbContext myDbContext) : base(myDbContext)
        {}

        public void InsertUserActivity(Usuario usuario, TypeActivity tipoActividad)
        {
            var message = "El usuario" + usuario.Name + "ha sido ";

            switch (tipoActividad)
            {
                case TypeActivity.Insert:
                    message = message + "creado";
                    break;

                case TypeActivity.Update:
                    message = message + "actualizado";
                    break;

                case TypeActivity.Delete:
                    message = message + "borrado";
                    break;
            }

            Activity actividad = new Activity()
            {
                Usuario = usuario,
                Date = DateTime.Now,
                Actividad = message
            };

            base.Insert(actividad);
        }

    }
}
