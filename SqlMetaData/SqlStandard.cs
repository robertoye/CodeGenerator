using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using CodeGenerator.MetadataModel;

namespace SqlMetaData
{
    public class SqlStandard : IObtainTables, IFields
    {
        private string _strConn;

        public SqlStandard(string strConn)
        {
            _strConn = strConn;
        }

        public List<TableDef> ObtainTables(string strFilter)
        {
            List<TableDef> list = new List<TableDef>();
            DataTable dtTab = SourceUtility.GetTableDefinition(_strConn,strFilter);       
            foreach(DataRow dr in dtTab.Rows)
            {
                TableDef td = new TableDef();
                td.Object_Id = int.Parse(dr["object_id"].ToString());
                td.Name = (string ) dr["Name"];
                td.Schema = (string)dr["Schema"];
                string fieldFilter = string.Format("a.Object_Id={0}", td.Object_Id);
                List<FieldDef> fields = this.ObtainFields(td,fieldFilter);
                td.Fields = fields;
                list.Add(td);
            }
            return list;
        }

        public List<FieldDef> ObtainFields(TableDef td,string strFilter)
        {
            List<FieldDef> list = new List<FieldDef>();
            DataTable dtCol = SourceUtility.GetColumnDefinition(_strConn,strFilter);       
            foreach(DataRow dr in dtCol.Rows)
            {
                FieldDef fd = new FieldDef();

                fd.Column_Id = int.Parse( dr["column_id"].ToString());
                fd.Table = td;
                fd.Name =  dr["Name"] as string ?? "";
                fd.Description = dr["Description"] as string ?? "";
                fd.RawType = dr["RawType"] as string ?? "";
                list.Add(fd);
            }      
  
            return list;
        }

        public static string BuildFilter(ArgsHelper args)
        {
            StringBuilder st = new StringBuilder("");
            if (!string.IsNullOrEmpty(args.TableName) && args.TableName != "*")
            {
                st.Append(string.Format("a.Name like '{0}%'", args.TableName));
            }
            if (!string.IsNullOrEmpty(args.TableModifyBefore))
            {
                if (st.Length == 0)
                {
                    st.Append(string.Format("a.modify_date <= '{0}'", args.TableModifyBefore));
                }
                else
                {
                    st.Append(string.Format(" and a.modify_date <= '{0}'", args.TableModifyBefore));
                }
            }
            if (!string.IsNullOrEmpty(args.TableModifyAfter))
            {
                if (st.Length == 0)
                {
                    st.Append(string.Format("a.modify_date >= '{0}'", args.TableModifyAfter));
                }
                else
                {
                    st.Append(string.Format(" and a.modify_date >= '{0}'", args.TableModifyAfter));
                }
            }

            return st.ToString();
        }
    }
}