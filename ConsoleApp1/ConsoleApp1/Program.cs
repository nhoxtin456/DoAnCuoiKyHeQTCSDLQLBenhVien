using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ConsoleApp1.Models;
using ConsoleApp1.Data;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new HospitalManagementContext())
            {
                var account = context.Account.FromSql("GetAccount 'khoa'").ToList();
                foreach (var m in account)
                {
                    Console.WriteLine(m.UserId.ToString());
                }
                //GetStudents "Bill"
                //-- or
                //exec GetStudents "Bill"

                var name = "khoa";

                var stud = context.Account
                                  .FromSql($"GetAccount {name}")
                                  .ToList();


                var stud1 = context.Account.FromSql($"exec GetAccount {name}").ToList();


                var param = new SqlParameter("@UserID", "khoa");


                var param1 = new SqlParameter()
                {
                    ParameterName = "@UserID",
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                    Direction = System.Data.ParameterDirection.Input,
                    Size = 50,
                    Value = "khoa"
                };

                var studs = context.Account.FromSql("GetAccount @UserID", param1).ToList();

                var studs1 = context.Account.FromSql("GetAccount @p0", "khoa").ToList();

            }

        }
    }
}