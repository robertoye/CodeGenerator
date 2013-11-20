/*
 * Created by zhye at 2013-11-20 9:23:51; 
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
    public class dtEquipQualityItemAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtEquipQualityItem> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtEquipQualityID,
                tpQualityAcceptID,
                tpAcceptSummaryID,
                Remark
            from dtEquipQualityItem";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtEquipQualityItem entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtEquipQualityItem(
                ID,
                dtEquipQualityID,
                tpQualityAcceptID,
                tpAcceptSummaryID,
                Remark)
            values (
                @ID,
                @dtEquipQualityID,
                @tpQualityAcceptID,
                @tpAcceptSummaryID,
                @Remark)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtEquipQualityItem entity)
        {
            string _strUpdateSql = @"Update  dtEquipQualityItem set
                ID = @ID, 
                dtEquipQualityID = @dtEquipQualityID, 
                tpQualityAcceptID = @tpQualityAcceptID, 
                tpAcceptSummaryID = @tpAcceptSummaryID, 
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
            string _strDeleteSql = @"delete dtEquipQualityItem where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    