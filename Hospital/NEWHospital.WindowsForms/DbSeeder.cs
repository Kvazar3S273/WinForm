﻿using Hospital;
using Hospital.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEWHospital.WindowsForms
{
    public static class DbSeeder
    {
        public static void SeedAll(MyContext context)
        {
            SeedDepartment(context);
            SeedDoctors(context);
            Generate genDoc = new Generate();
            genDoc.GenerateDoctor(context);
            context.SaveChanges();

        }
        private static void SeedDepartment(MyContext context)
        {
            if (context.Departments.Count() == 0)
            {
                context.Departments.Add(
                    new Department
                    {
                        Name = "Педіатрія",
                        NumberCabinet = 8
                    });
                context.Departments.Add(
                    new Department
                    {
                        Name = "Урологія",
                        NumberCabinet = 7
                    });
                context.SaveChanges();
            }
        }
        private static void SeedDoctors(MyContext context)
        {
            if (context.Doctors.Count() == 0)
            {
                context.Doctors.Add(
                    new Doctor
                    {
                        LastName = "Конор",
                        FirstName = "Сара",
                        Login = "sarah",
                        Password = PasswordManager.HashPassword("12346"),
                        Stage = 14,
                        Image = "1.jpg",
                        Department = context.Departments.FirstOrDefault(x => x.Name == "Педіатрія")
                    });
                context.Doctors.Add(
                    new Doctor
                    {
                        LastName = "Бонд",
                        FirstName = "Джеймс",
                        Login = "bond",
                        Password = PasswordManager.HashPassword("007"),
                        Stage = 15,
                        Image = "2.jpg",
                        Department = context.Departments.FirstOrDefault(x => x.Name == "Урологія")

                    });
                context.Doctors.Add(
                    new Doctor
                    {
                        LastName = "Шевченко",
                        FirstName = "Тарас",
                        Login = "sheva",
                        Password = PasswordManager.HashPassword("12346"),
                        Stage = 16,
                        Image = "3.jpg",
                        Department = context.Departments.FirstOrDefault(x => x.Name == "Педіатрія")

                    });
                context.SaveChanges();
            }
                
        }
    }
}
