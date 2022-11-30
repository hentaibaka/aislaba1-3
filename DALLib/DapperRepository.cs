using StudentLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DALLib
{
    public class DapperRepository<T> : IRepository<T> where T: class, IDomainObject
    {
        static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbConnection;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        IDbConnection db = new SqlConnection(connectionString);
        public void Create(T obj)
        {
            var sqlQuery = "INSERT INTO Students (Name, [Group], Speciality) VALUES(@Name, @Group, @Speciality); SELECT CAST(SCOPE_IDENTITY() as int)";
            int id = db.Query<int>(sqlQuery, obj).FirstOrDefault();
            obj.Id = id;
        }
        public IEnumerable<T> GetAll()
        {
            return db.Query<T>("SELECT * FROM Students").ToList();
        }
        public T Get(int id)
        {
            IEnumerable<T> res = db.Query<T>($"SELECT * FROM Students WHERE Id = {id}");
            
            return res.FirstOrDefault<T>();
        }
        public void Delete(T obj)
        {
            var sqlQuery = "DELETE FROM Students WHERE Id = @Id";
            db.Query<T>(sqlQuery, obj);
        }
        public void Save()
        {
            return;
        }
    }
}
