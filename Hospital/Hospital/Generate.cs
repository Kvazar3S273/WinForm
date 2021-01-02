using System;
using System.Collections.Generic;
using System.Text;
using Bogus;
using System.Linq;
using Hospital.Helpers;

namespace Hospital
{
    public class Generate
    {
        //MyContext context = new MyContext();
        public void GenerateDoctor(MyContext context)
        {
            List<Doctor> listDoctor = new List<Doctor>();
            var doctor = new Faker<Doctor>("uk")
                .RuleFor(d => d.LastName, f => f.Name.LastName())
                .RuleFor(d => d.FirstName, f => f.Name.FirstName())
                .RuleFor(d => d.Login, f => f.Internet.UserName())
                .RuleFor(d => d.Password, f => f.Internet.Password())
                .RuleFor(d => d.DepartmentId, f => f.Random.Int(11, 20))
                .RuleFor(d => d.Stage, f => f.Random.Int(1, 40));
            for (int i = 0; i < 1000; i++)
            {
                listDoctor.Add(doctor.Generate());
            }

            //if(context.Doctors.Count()==0)
            //{
                foreach (var item in listDoctor)
                {
                    context.Doctors.Add(
                        new Doctor
                        {
                            LastName = item.LastName,
                            FirstName = item.FirstName,
                            Login = item.Login,
                            Password = PasswordManager.HashPassword(item.Password),
                            DepartmentId =item.DepartmentId,
                            Image="0.jpg",
                            Stage = item.Stage
                        });
                }
            //}
            //context.SaveChanges();
        }
    }
}
