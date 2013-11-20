/*
 * Created by zhye at 2013-11-20 9:22:58; 
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
    public class dtSummaryDetailAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtSummaryDetail> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtSummaryID,
                tpSummaryItemID,
                summaryContent
            from dtSummaryDetail";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtSummaryDetail entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtSummaryDetail(
                ID,
                dtSummaryID,
                tpSummaryItemID,
                summaryContent)
            values (
                @ID,
                @dtSummaryID,
                @tpSummaryItemID,
                @summaryContent)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtSummaryDetail entity)
        {
            string _strUpdateSql = @"Update  dtSummaryDetail set
                ID = @ID, 
                dtSummaryID = @dtSummaryID, 
                tpSummaryItemID = @tpSummaryItemID, 
                summaryContent = @summaryContent 
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
            string _strDeleteSql = @"delete dtSummaryDetail where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    