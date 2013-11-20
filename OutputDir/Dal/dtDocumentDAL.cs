/*
 * Created by zhye at 2013-11-20 9:22:02; 
 *
 *
 *
 *
 *
 * Copyright:Strong
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Dapper;
using Model;

namespace DAL
{
    public class dtDocumentAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtDocument> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                dtProjectID,
                dtTaskID,
                tpDocumentTypeID,
                tpDocumentClassID,
                DocumentTitle,
                IndexKey,
                MainContentDesc,
                DocumentSummary,
                SavePath,
                Remark
            from dtDocument";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtDocument entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtDocument(
                ID,
                BillCode,
                dtProjectID,
                dtTaskID,
                tpDocumentTypeID,
                tpDocumentClassID,
                DocumentTitle,
                IndexKey,
                MainContentDesc,
                DocumentSummary,
                SavePath,
                Remark)
            values (
                @ID,
                @BillCode,
                @dtProjectID,
                @dtTaskID,
                @tpDocumentTypeID,
                @tpDocumentClassID,
                @DocumentTitle,
                @IndexKey,
                @MainContentDesc,
                @DocumentSummary,
                @SavePath,
                @Remark)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtDocument entity)
        {
            string _strUpdateSql = @"Update  dtDocument set
                ID = @ID, 
                BillCode = @BillCode, 
                dtProjectID = @dtProjectID, 
                dtTaskID = @dtTaskID, 
                tpDocumentTypeID = @tpDocumentTypeID, 
                tpDocumentClassID = @tpDocumentClassID, 
                DocumentTitle = @DocumentTitle, 
                IndexKey = @IndexKey, 
                MainContentDesc = @MainContentDesc, 
                DocumentSummary = @DocumentSummary, 
                SavePath = @SavePath, 
                Remark = @Remark 
            where Id = @Id";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model,commandType:CommandType.Text) > 0 ? true : false; 
            }    
        }
        /// <summary>
        /// 删除方法
        /// </summary>
        public bool Delete(int Id)
        {
            string _strDeleteSql = @"delete dtDocument where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    