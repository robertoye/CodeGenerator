/*
 * Created by zhye at 2013-11-20 9:24:23; 
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
    public class dtRegularPayAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtRegularPay> GetList(string strFilter)
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
                ProjectCode,
                dtPurchaseID,
                ContractCode,
                dtPurchasePaySchemeID,
                bsSupplierID,
                tpCurrencyTypeID,
                TaxRate,
                ApplyAmount,
                FundContent,
                tpPayModelID,
                ProofNo,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpPayBillStateID,
                IsExistNegotiate,
                IsExistSignByCEO,
                IsExistFatalError
            from dtRegularPay";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtRegularPay entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtRegularPay(
                ID,
                BillCode,
                BillDate,
                AuditDate,
                PayDate,
                bsAccountID,
                trDeptID,
                dtProjectID,
                ProjectCode,
                dtPurchaseID,
                ContractCode,
                dtPurchasePaySchemeID,
                bsSupplierID,
                tpCurrencyTypeID,
                TaxRate,
                ApplyAmount,
                FundContent,
                tpPayModelID,
                ProofNo,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpPayBillStateID,
                IsExistNegotiate,
                IsExistSignByCEO,
                IsExistFatalError)
            values (
                @ID,
                @BillCode,
                @BillDate,
                @AuditDate,
                @PayDate,
                @bsAccountID,
                @trDeptID,
                @dtProjectID,
                @ProjectCode,
                @dtPurchaseID,
                @ContractCode,
                @dtPurchasePaySchemeID,
                @bsSupplierID,
                @tpCurrencyTypeID,
                @TaxRate,
                @ApplyAmount,
                @FundContent,
                @tpPayModelID,
                @ProofNo,
                @Remark,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @tpPayBillStateID,
                @IsExistNegotiate,
                @IsExistSignByCEO,
                @IsExistFatalError)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtRegularPay entity)
        {
            string _strUpdateSql = @"Update  dtRegularPay set
                ID = @ID, 
                BillCode = @BillCode, 
                BillDate = @BillDate, 
                AuditDate = @AuditDate, 
                PayDate = @PayDate, 
                bsAccountID = @bsAccountID, 
                trDeptID = @trDeptID, 
                dtProjectID = @dtProjectID, 
                ProjectCode = @ProjectCode, 
                dtPurchaseID = @dtPurchaseID, 
                ContractCode = @ContractCode, 
                dtPurchasePaySchemeID = @dtPurchasePaySchemeID, 
                bsSupplierID = @bsSupplierID, 
                tpCurrencyTypeID = @tpCurrencyTypeID, 
                TaxRate = @TaxRate, 
                ApplyAmount = @ApplyAmount, 
                FundContent = @FundContent, 
                tpPayModelID = @tpPayModelID, 
                ProofNo = @ProofNo, 
                Remark = @Remark, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
                tpPayBillStateID = @tpPayBillStateID, 
                IsExistNegotiate = @IsExistNegotiate, 
                IsExistSignByCEO = @IsExistSignByCEO, 
                IsExistFatalError = @IsExistFatalError 
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
            string _strDeleteSql = @"delete dtRegularPay where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    