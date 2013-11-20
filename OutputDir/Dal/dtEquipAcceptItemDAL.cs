/*
 * Created by zhye at 2013-11-20 9:23:18; 
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
    public class dtEquipAcceptItemAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtEquipAcceptItem> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtEquipAcceptID,
                dtPurchaseDetailID,
                ReferSummary,
                AcceptSuggest
            from dtEquipAcceptItem";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtEquipAcceptItem entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtEquipAcceptItem(
                ID,
                dtEquipAcceptID,
                dtPurchaseDetailID,
                ReferSummary,
                AcceptSuggest)
            values (
                @ID,
                @dtEquipAcceptID,
                @dtPurchaseDetailID,
                @ReferSummary,
                @AcceptSuggest)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtEquipAcceptItem entity)
        {
            string _strUpdateSql = @"Update  dtEquipAcceptItem set
                ID = @ID, 
                dtEquipAcceptID = @dtEquipAcceptID, 
                dtPurchaseDetailID = @dtPurchaseDetailID, 
                ReferSummary = @ReferSummary, 
                AcceptSuggest = @AcceptSuggest 
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
            string _strDeleteSql = @"delete dtEquipAcceptItem where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    