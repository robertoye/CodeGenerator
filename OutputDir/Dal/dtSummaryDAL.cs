/*
 * Created by zhye at 2013-11-20 9:22:33; 
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
    public class dtSummaryAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtSummary> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                BillDate,
                dtProjectID,
                bsAccountID,
                ProjectCode,
                SummaryDate,
                trDeptID,
                SummaryMan,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                Remark,
                tpBillStateID
            from dtSummary";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtSummary entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtSummary(
                ID,
                BillCode,
                BillDate,
                dtProjectID,
                bsAccountID,
                ProjectCode,
                SummaryDate,
                trDeptID,
                SummaryMan,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                Remark,
                tpBillStateID)
            values (
                @ID,
                @BillCode,
                @BillDate,
                @dtProjectID,
                @bsAccountID,
                @ProjectCode,
                @SummaryDate,
                @trDeptID,
                @SummaryMan,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @Remark,
                @tpBillStateID)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtSummary entity)
        {
            string _strUpdateSql = @"Update  dtSummary set
                ID = @ID, 
                BillCode = @BillCode, 
                BillDate = @BillDate, 
                dtProjectID = @dtProjectID, 
                bsAccountID = @bsAccountID, 
                ProjectCode = @ProjectCode, 
                SummaryDate = @SummaryDate, 
                trDeptID = @trDeptID, 
                SummaryMan = @SummaryMan, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
                Remark = @Remark, 
                tpBillStateID = @tpBillStateID 
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
            string _strDeleteSql = @"delete dtSummary where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    