/*
 * Created by zhye at 2013-11-20 9:23:37; 
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
    public class dtEquipInstalItemAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtEquipInstalItem> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtEquipInstalID,
                tpInstalAcceptID,
                AcceptSuggest
            from dtEquipInstalItem";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtEquipInstalItem entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtEquipInstalItem(
                ID,
                dtEquipInstalID,
                tpInstalAcceptID,
                AcceptSuggest)
            values (
                @ID,
                @dtEquipInstalID,
                @tpInstalAcceptID,
                @AcceptSuggest)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtEquipInstalItem entity)
        {
            string _strUpdateSql = @"Update  dtEquipInstalItem set
                ID = @ID, 
                dtEquipInstalID = @dtEquipInstalID, 
                tpInstalAcceptID = @tpInstalAcceptID, 
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
            string _strDeleteSql = @"delete dtEquipInstalItem where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    