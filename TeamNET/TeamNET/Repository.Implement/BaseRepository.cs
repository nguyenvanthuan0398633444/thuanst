using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace TeamNET.Repository.Implement
{
    public class BaseRepository
    {
        protected IDbConnection connection;
        public BaseRepository()
        {
            connection = new NpgsqlConnection(@"Server = 192.168.144.116; Port = 5432; User Id = postgres; Password = 123456; Database = OJTNetDb;");
        }
    }
}
