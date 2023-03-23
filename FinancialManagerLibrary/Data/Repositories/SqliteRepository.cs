using FinancialManagerLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Data.Repositories
{
    /// <summary>
    /// Singleton repository class for Sqlite
    /// </summary>
    public class SqliteRepository //: IRepository<SqliteRepository> where T : EntityBase
    {
        //private static readonly object obj = new object ();  
        //private static SqliteRepository instance = null;
        string cs = @"URI=file:C:\git\src\FinancialManager\sqlite\FinancialManager.db";
        SQLiteConnection conn;
        SQLiteCommand cmd;

       
        //private SqliteRepository()
        //{
           // conn = new SQLiteConnection(cs);
           // cmd = new SQLiteCommand(conn);

            
        //}

        public void Run()
        {
            string stm = "SELECT * FROM Users";
            try
            {
                conn.Open();
                using var cmd = new SQLiteCommand(stm, conn);
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetString(2)}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
            
        }

        //public static SqliteRepository Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (obj)
        //                {
        //                    if (instance == null)
        //                    {
        //                        instance = new SqliteRepository();
        //                    }
        //                }
        //        }
        //        return instance;
        //    }
        //}

        //public T Insert<T>(T model)
        //{
        //    throw new NotImplementedException();
        //    //cmd.CommandText = "INSERT INTO cars(name, price) VALUES(@name, @price)";

        //    //cmd.Parameters.AddWithValue("@name", "BMW");
        //    //cmd.Parameters.AddWithValue("@price", 36600);
        //    cmd.Prepare();

        //    cmd.ExecuteNonQuery();
        //}



        //public T Select<T>(int pk) where T : new()
        //{
        //    using (var db = new FinancialManagerContext())
        //    {
        //       // (T)Convert.ChangeType(value, typeof(T)) db.Users
        //    }
        //        //string stm = "SELECT * FROM Users";
        //        //try
        //        //{
        //        //    conn.Open();
        //        //    using var cmd = new SQLiteCommand(stm, conn);
        //        //    using (SQLiteDataReader rdr = cmd.ExecuteReader())
        //        //    {
        //        //        while (rdr.Read())
        //        //        {

        //        //            //Console.WriteLine($"{rdr.GetInt32(0)} {rdr.GetString(1)} {rdr.GetString(2)}");
        //        //        }
        //        //    }
        //        //}
        //        //catch (Exception ex)
        //        //{
        //        //    Console.WriteLine(ex.Message);
        //        //}
        //        //finally
        //        //{
        //        //    conn.Close();
        //        //}

        //        throw new NotImplementedException();
        //}

        


    }
}
