using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using api;
using api.Controllers;
using Npgsql;
using System.Configuration;

namespace api.Tests.Controllers
{
    [TestClass]
    public class Experiment
    {
        [TestMethod]
        public void CallPostgres()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["PostgresDotNet"].ConnectionString;
            using (NpgsqlConnection conn = new NpgsqlConnection(ConnectionString))
            {
                conn.Open();

                var cmd = new NpgsqlCommand("delete from test_table;", conn);
                cmd.ExecuteNonQuery();

                cmd = new NpgsqlCommand("insert into test_table(c1) values('Abc');", conn);
                cmd.ExecuteNonQuery();

                cmd = new NpgsqlCommand("SELECT * FROM test_table where c1 = 'Abc';", conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                var count = 0;
                while (reader.Read())
                {
                    count++;
                    Assert.AreEqual<string>("Abc", reader["c1"] as string);
                }
                Assert.AreEqual(1, count);
            }
        }

    }
}
