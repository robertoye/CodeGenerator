/*
 * Created by zhye at 2013-11-20 9:21:22; 
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
    public class dtReviewDetailAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtReviewDetail> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtReviewID,
                tpReviewItemID,
                ReviewSummary
            from dtReviewDetail";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtReviewDetail entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtReviewDetail(
                ID,
                dtReviewID,
                tpReviewItemID,
                ReviewSummary)
            values (
                @ID,
                @dtReviewID,
                @tpReviewItemID,
                @ReviewSummary)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtReviewDetail entity)
        {
            string _strUpdateSql = @"Update  dtReviewDetail set
                ID = @ID, 
                dtReviewID = @dtReviewID, 
                tpReviewItemID = @tpReviewItemID, 
                ReviewSummary = @ReviewSummary 
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
            string _strDeleteSql = @"delete dtReviewDetail where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    