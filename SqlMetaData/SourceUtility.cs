using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Data.Sql;
using System.Data.SqlClient;

namespace SqlMetaData
{
	public class SourceUtility
	{           
		/// <summary>
		/// 获取表定义
		/// </summary>
		/// <param name="_strConn"></param>
		/// <param name="strFilter"></param>
		/// <returns></returns>
		internal static DataTable GetTableDefinition(string strConn, string strFilter)
		{
			using(SqlConnection conn = new SqlConnection(strConn))
			{
				string sqlFMT = @"select g.name as 'Schema',a.* 
									from sys.tables a join sys.schemas g 
										on(a.schema_id = g.schema_id)    
									{0} {1}
									order by a.object_id";
				string sql = string.Format(sqlFMT, string.IsNullOrEmpty(strFilter) ? "" : "where",
								string.IsNullOrEmpty(strFilter) ? "" : strFilter);
				conn.Open();
				SqlCommand cmd = new SqlCommand(sql, conn);
				DataSet ds = new DataSet();
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(ds);

				return ds.Tables[0];
			}
		}

		/// <summary>
		/// 获取字段定义
		/// </summary>
		/// <param name="_strConn"></param>
		/// <param name="strFilter"></param>
		/// <returns></returns>
		internal static DataTable GetColumnDefinition(string strConn, string strFilter)
		{
			using(SqlConnection conn = new SqlConnection(strConn))
			{
				conn.Open();
				string sqlFMT = @"select g.Name [SchemaName],a.Name TableName,type_name(b.system_type_id) RawType,
									b.column_id,b.Name,max_length 'Length',is_nullable  'Nullable'
									from sys.tables a join sys.columns b
											on(a.object_id = b.object_id)
										 join sys.schemas g
											on(a.schema_id = g.schema_id)
									{0} {1}
									order by a.object_id,b.column_id";
				string sql = string.Format(sqlFMT, string.IsNullOrEmpty(strFilter) ? "" : "where", 
									string.IsNullOrEmpty(strFilter) ? "" : strFilter);

				SqlCommand cmd = new SqlCommand(sql, conn);
				DataSet ds = new DataSet();
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(ds);

				return ds.Tables[0];
				//DataTable tabs = Dapper.SqlMapper.Query<DataRow>(conn, sql, CommandType.Text).CopyToDataTable();
				//return tabs;
			}
		}
	}
}
