using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Oracle.DataAccess.Client;


namespace OraMetaData
{
	public class SourceUtility
	{
		public static DataTable GetTableDefinition(string strConn, string strFilter)
		{
			using (OracleConnection ocn = new OracleConnection(strConn))
			{
				ocn.Open();
				string sqlFMT = @"SELECT * FROM DEPT    
									{0} {1}
									ORDER BY DEPTNO";
				string sql = string.Format(sqlFMT, string.IsNullOrEmpty(strFilter) ? "" : "WHERE",
								string.IsNullOrEmpty(strFilter) ? "" : strFilter);                
				OracleCommand ocmd = new OracleCommand(sql, ocn);
				DataSet ds = new DataSet();
				OracleDataAdapter adapter = new OracleDataAdapter(ocmd);
				adapter.Fill(ds);
				return ds.Tables[0];
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="strConn"></param>
		/// <param name="pName"></param>
		/// <param name="prs"></param>
		/// <returns></returns>
		public static DataSet GetDataSet(string strConn, string pName,OracleParameterCollection prs)
		{
			using (OracleConnection ocn = new OracleConnection(strConn))
			{
				ocn.Open();
				OracleCommand ocmd = new OracleCommand(pName, ocn);
				ocmd.CommandType = CommandType.StoredProcedure;
				OracleParameter pra = new OracleParameter();

				ocmd.Parameters.Add(par);

				DataSet ds = new DataSet();
				OracleDataAdapter adapter = new OracleDataAdapter(ocmd);
				adapter.Fill(ds);
				return ds;
			}
		}
	}
}
