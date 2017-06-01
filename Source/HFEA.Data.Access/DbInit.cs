using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Data.Access
{
    public static class DbInit
    {
        public static void Do()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());
            using (var db = new DataContext())
            {
                db.Database.Initialize(false);
            }
        }
    }
}
