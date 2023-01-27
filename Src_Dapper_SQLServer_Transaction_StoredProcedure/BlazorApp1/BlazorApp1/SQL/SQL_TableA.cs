using System.Data;
using BlazorApp1.Model;
using BlazorApp1.Shared;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Data.SqlClient;

namespace BlazorApp1.SQL
{
    public class SQL_TableA
    {
        public static void Transaction1(TableA insertTableA)
        {
            using (var conn = new SqlConnection(SharedData.ConnectionString))
            {
                conn.Open();

                using (var tran = conn.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        var tableAList = Select(conn, tran);

                        Insert(conn, tran, insertTableA);

                        var tableAList2 = Select(conn, tran);

                        tran.Commit();
                    }
                    catch(Exception ex)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public static IEnumerable<TableA> Select(SqlConnection conn, SqlTransaction tran)
        {
            return conn.Query<TableA>("spTableA_Select", null, tran, commandType: CommandType.StoredProcedure);
        }

        public static void Insert(SqlConnection conn, SqlTransaction tran, TableA _TableA)
        {
            var sqlParam = new
            {
                id = _TableA.Id,
                code = _TableA.Code,
                valueString = _TableA.ValueString,
                valueDate = _TableA.ValueDate
            };

            conn.Execute("spTableA_Insert", sqlParam, tran, commandType: CommandType.StoredProcedure);
        }
    }

}
