/*
 * Created by zhye at 2013-11-20 9:24:19; 
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
    public class dtTransferProjectAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtTransferProject> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                BillDate,
                dtProjectID,
                bsAccountID,
                ProjectCode,
                TransferDate,
                trDeptID_Usage,
                UsageMan,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                remark
            from dtTransferProject";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtTransferProject entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtTransferProject(
                ID,
                BillCode,
                BillDate,
                dtProjectID,
                bsAccountID,
                ProjectCode,
                TransferDate,
                trDeptID_Usage,
                UsageMan,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                remark)
            values (
                @ID,
                @BillCode,
                @BillDate,
                @dtProjectID,
                @bsAccountID,
                @ProjectCode,
                @TransferDate,
                @trDeptID_Usage,
                @UsageMan,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @remark)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtTransferProject entity)
        {
            string _strUpdateSql = @"Update  dtTransferProject set
                ID = @ID, 
                BillCode = @BillCode, 
                BillDate = @BillDate, 
                dtProjectID = @dtProjectID, 
                bsAccountID = @bsAccountID, 
                ProjectCode = @ProjectCode, 
                TransferDate = @TransferDate, 
                trDeptID_Usage = @trDeptID_Usage, 
                UsageMan = @UsageMan, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
                remark = @remark 
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
            string _strDeleteSql = @"delete dtTransferProject where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    