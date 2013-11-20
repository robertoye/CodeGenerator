/*
 * Created by zhye at 2013-11-20 9:22:12; 
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
    public class dtWithholdAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtWithhold> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                BillDate,
                WithholdDate,
                dtProjectID,
                dtPurchaseID,
                dtInvoiceID,
                tpWithholdID,
                WithholdReason,
                WithholdAmount,
                ProofNo,
                ProjectCode,
                ContractCode,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpBillStateID
            from dtWithhold";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtWithhold entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtWithhold(
                ID,
                BillCode,
                BillDate,
                WithholdDate,
                dtProjectID,
                dtPurchaseID,
                dtInvoiceID,
                tpWithholdID,
                WithholdReason,
                WithholdAmount,
                ProofNo,
                ProjectCode,
                ContractCode,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpBillStateID)
            values (
                @ID,
                @BillCode,
                @BillDate,
                @WithholdDate,
                @dtProjectID,
                @dtPurchaseID,
                @dtInvoiceID,
                @tpWithholdID,
                @WithholdReason,
                @WithholdAmount,
                @ProofNo,
                @ProjectCode,
                @ContractCode,
                @Remark,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @tpBillStateID)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtWithhold entity)
        {
            string _strUpdateSql = @"Update  dtWithhold set
                ID = @ID, 
                BillCode = @BillCode, 
                BillDate = @BillDate, 
                WithholdDate = @WithholdDate, 
                dtProjectID = @dtProjectID, 
                dtPurchaseID = @dtPurchaseID, 
                dtInvoiceID = @dtInvoiceID, 
                tpWithholdID = @tpWithholdID, 
                WithholdReason = @WithholdReason, 
                WithholdAmount = @WithholdAmount, 
                ProofNo = @ProofNo, 
                ProjectCode = @ProjectCode, 
                ContractCode = @ContractCode, 
                Remark = @Remark, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
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
            string _strDeleteSql = @"delete dtWithhold where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    