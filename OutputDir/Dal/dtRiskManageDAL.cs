/*
 * Created by zhye at 2013-11-20 9:22:08; 
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
    public class dtRiskManageAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtRiskManage> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                dtProjectID,
                dtTaskID,
                ResponsibilityMan,
                RiskDesc,
                Solution,
                tpRiskLevelID,
                tpOccurProbabilityID,
                tpAffectLevelID
            from dtRiskManage";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtRiskManage entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtRiskManage(
                ID,
                BillCode,
                dtProjectID,
                dtTaskID,
                ResponsibilityMan,
                RiskDesc,
                Solution,
                tpRiskLevelID,
                tpOccurProbabilityID,
                tpAffectLevelID)
            values (
                @ID,
                @BillCode,
                @dtProjectID,
                @dtTaskID,
                @ResponsibilityMan,
                @RiskDesc,
                @Solution,
                @tpRiskLevelID,
                @tpOccurProbabilityID,
                @tpAffectLevelID)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtRiskManage entity)
        {
            string _strUpdateSql = @"Update  dtRiskManage set
                ID = @ID, 
                BillCode = @BillCode, 
                dtProjectID = @dtProjectID, 
                dtTaskID = @dtTaskID, 
                ResponsibilityMan = @ResponsibilityMan, 
                RiskDesc = @RiskDesc, 
                Solution = @Solution, 
                tpRiskLevelID = @tpRiskLevelID, 
                tpOccurProbabilityID = @tpOccurProbabilityID, 
                tpAffectLevelID = @tpAffectLevelID 
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
            string _strDeleteSql = @"delete dtRiskManage where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    