using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserRoles.Entities
{
    public static class Seeder
    {
        public static void SeedDataBase(EFContext context)
        {
            SeedUser(context);
            SeedRole(context);
            SeedUserRole(context);
        }
        private static void SeedUser(EFContext context)
        {
            if(context.Users.Count()==0)
            {
                context.Users
                    .Add(new User 
                    { 
                        Name = "Карл", 
                        Email = "karl@ukr.net",
                        PhoneNumber = "098-7564645",
                        Password = "marks"
                    });
                context.Users
                    .Add(new User
                    {
                        Name = "Ілон",
                        Email = "elon@ukr.net",
                        PhoneNumber = "098-6546442",
                        Password = "mask"
                    });
                context.SaveChanges();
            }
        }
        private static void SeedRole(EFContext context)
        {
            if(context.Roles.Count()==0)
            {
                context.Roles
                    .Add(new Role { Title = "HR" });
                context.Roles
                    .Add(new Role { Title = "Developer" });
                context.Roles
                    .Add(new Role { Title = "Designer" });
                context.Roles
                    .Add(new Role { Title = "System administrator" });
                context.Roles
                    .Add(new Role { Title = "Artist" });
            }
            context.SaveChanges();
        }
        private static void SeedUserRole(EFContext context)
        {
            if(context.UserRoles.Count()==0)
            {
                context.UserRoles
                    .Add(new UserRole
                    {
                        UserId = 40,
                        RoleId = 13
                    });
                context.UserRoles
                    .Add(new UserRole
                    {
                        UserId = 40,
                        RoleId = 14
                    });
                context.UserRoles
                    .Add(new UserRole
                    {
                        UserId = 41,
                        RoleId = 15
                    });
                context.SaveChanges();
            }
        }
    }
}
