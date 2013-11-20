/*
 * Created by zhye at 2013-11-20 9:24:09; 
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
    public class dtPrepayAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtPrepay> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                BillDate,
                AuditDate,
                PayDate,
                bsAccountID,
                trDeptID,
                dtProjectID,
                dtPurchaseID,
                dtPurchasePaySchemeID,
                bsSupplierID,
                tpCurrencyTypeID,
                TaxRate,
                PrepayAmount,
                ReversePrepayAmount,
                FundContent,
                tpPayModelID,
                ProofNo,
                ProjectCode,
                ContractCode,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpPayBillStateID
            from dtPrepay";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtPrepay entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtPrepay(
                ID,
                BillCode,
                BillDate,
                AuditDate,
                PayDate,
                bsAccountID,
                trDeptID,
                dtProjectID,
                dtPurchaseID,
                dtPurchasePaySchemeID,
                bsSupplierID,
                tpCurrencyTypeID,
                TaxRate,
                PrepayAmount,
                ReversePrepayAmount,
                FundContent,
                tpPayModelID,
                ProofNo,
                ProjectCode,
                ContractCode,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpPayBillStateID)
            values (
                @ID,
                @BillCode,
                @BillDate,
                @AuditDate,
                @PayDate,
                @bsAccountID,
                @trDeptID,
                @dtProjectID,
                @dtPurchaseID,
                @dtPurchasePaySchemeID,
                @bsSupplierID,
                @tpCurrencyTypeID,
                @TaxRate,
                @PrepayAmount,
                @ReversePrepayAmount,
                @FundContent,
                @tpPayModelID,
                @ProofNo,
                @ProjectCode,
                @ContractCode,
                @Remark,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @tpPayBillStateID)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtPrepay entity)
        {
            string _strUpdateSql = @"Update  dtPrepay set
                ID = @ID, 
                BillCode = @BillCode, 
                BillDate = @BillDate, 
                AuditDate = @AuditDate, 
                PayDate = @PayDate, 
                bsAccountID = @bsAccountID, 
                trDeptID = @trDeptID, 
                dtProjectID = @dtProjectID, 
                dtPurchaseID = @dtPurchaseID, 
                dtPurchasePaySchemeID = @dtPurchasePaySchemeID, 
                bsSupplierID = @bsSupplierID, 
                tpCurrencyTypeID = @tpCurrencyTypeID, 
                TaxRate = @TaxRate, 
                PrepayAmount = @PrepayAmount, 
                ReversePrepayAmount = @ReversePrepayAmount, 
                FundContent = @FundContent, 
                tpPayModelID = @tpPayModelID, 
                ProofNo = @ProofNo, 
                ProjectCode = @ProjectCode, 
                ContractCode = @ContractCode, 
                Remark = @Remark, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
                tpPayBillStateID = @tpPayBillStateID 
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
            string _strDeleteSql = @"delete dtPrepay where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    