using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using TutorApp.DAL;
using TutorApp.Models;
using TutorApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Data;
using TutorApp.ViewModels;

namespace TutorApp.Repositories
{
    public class TutorRepository : ITutorRepository
    {
           private readonly DbWebContext _context;

        public TutorRepository(DbWebContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        //public ObjectResult<Tutor> GetTutors()
        //{
        //    //return ((IObjectContextAdapter)_context).ObjectContext.ExecuteFunction<Tutor>("dbo.GetTutors");
        //}
        public List<Tutor> GetTutorsData()
        {
            //List<Tutor> lista = new List<Tutor>();
            //Tutor tut = new Tutor();
            //tut.CityId = 1;
            //tut.Name = "Marcin123";
            //lista.Add(tut);
            //var result = _context.Database.ExecuteSqlRaw(@"EXEC dbo.GetTutors").ToList();
            var result = _context.Tutors.FromSqlRaw(@"EXEC dbo.GetTutors").ToList();
            return result;
        }

        public List<TutorVM> GetTutorsDataByID(int Id)
        {
            string connectionString = @"Data Source = localhost\SQLEXPRESS;Initial Catalog = DbTutor; Integrated Security = True";
            var values = new { TutorId = Id };
            var connection = new SqlConnection(connectionString);
            var result = connection.Query(@"EXEC dbo.SelectTutorsByNameVM @TutorId", values);
            List<TutorVM> names = new List<TutorVM>();
            foreach (var item in result)
            {
                TutorVM vm = new TutorVM(item.Name, item.Surname);
                names.Add(vm);
            }

            //////var result = _context.Database.ExecuteSqlRaw(@"EXEC dbo.GetTutors").ToList();
            ////var result = _context.Tutors.FromSqlRaw(@"EXEC dbo.SelectTutorsById @TutorId", param).ToList();
            ////var result = _context.Tutors.FromSqlRaw(@"EXEC dbo.SelectTutorsById 1").ToList();
            ////var result = _context.Database.FromSql(@"EXEC dbo.SelectTutorsById 1");
            ////var final_result = result.Select(x => x.Surname).ToList();
            return names;
        }

        public List<Tutor> GetAllTutors()
        {
            return _context.Tutors.ToList();   
        }

        public int Save(Tutor tutor)
        {
            _context.Tutors.Add(tutor);
            _context.SaveChanges();
            return 1;
        }
    }
}
