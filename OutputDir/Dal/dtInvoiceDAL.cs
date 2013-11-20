/*
 * Created by zhye at 2013-11-20 9:23:58; 
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
    public class dtInvoiceAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtInvoice> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                BillDate,
                AuditDate,
                bsAccountID,
                trDeptID,
                dtProjectID,
                dtPurChaseID,
                bsSupplierID,
                tpCurrencyTypeID,
                TaxRate,
                TaxAmount,
                ReverseAmount,
                AuditAmount,
                PayedAmount,
                tpInvoiceTypeID,
                InvoiceNo,
                InvoiceQuantity,
                ProofNo,
                ProjectCode,
                ContractCode,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpBillStateID
            from dtInvoice";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtInvoice entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtInvoice(
                ID,
                BillCode,
                BillDate,
                AuditDate,
                bsAccountID,
                trDeptID,
                dtProjectID,
                dtPurChaseID,
                bsSupplierID,
                tpCurrencyTypeID,
                TaxRate,
                TaxAmount,
                ReverseAmount,
                AuditAmount,
                PayedAmount,
                tpInvoiceTypeID,
                InvoiceNo,
                InvoiceQuantity,
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
                @AuditDate,
                @bsAccountID,
                @trDeptID,
                @dtProjectID,
                @dtPurChaseID,
                @bsSupplierID,
                @tpCurrencyTypeID,
                @TaxRate,
                @TaxAmount,
                @ReverseAmount,
                @AuditAmount,
                @PayedAmount,
                @tpInvoiceTypeID,
                @InvoiceNo,
                @InvoiceQuantity,
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
        public void Update(Model.dtInvoice entity)
        {
            string _strUpdateSql = @"Update  dtInvoice set
                ID = @ID, 
                BillCode = @BillCode, 
                BillDate = @BillDate, 
                AuditDate = @AuditDate, 
                bsAccountID = @bsAccountID, 
                trDeptID = @trDeptID, 
                dtProjectID = @dtProjectID, 
                dtPurChaseID = @dtPurChaseID, 
                bsSupplierID = @bsSupplierID, 
                tpCurrencyTypeID = @tpCurrencyTypeID, 
                TaxRate = @TaxRate, 
                TaxAmount = @TaxAmount, 
                ReverseAmount = @ReverseAmount, 
                AuditAmount = @AuditAmount, 
                PayedAmount = @PayedAmount, 
                tpInvoiceTypeID = @tpInvoiceTypeID, 
                InvoiceNo = @InvoiceNo, 
                InvoiceQuantity = @InvoiceQuantity, 
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
            string _strDeleteSql = @"delete dtInvoice where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    