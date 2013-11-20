/*
 * Created by zhye at 2013-11-20 9:22:18; 
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
    public class dtPurchaseAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtPurchase> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                BillDate,
                bsAccountID,
                dtProjectID,
                ProjectCode,
                ContractCode,
                ContractName,
                IsAttachContract,
                MainContractCode,
                bsSupplierID,
                ContractSignDate,
                tpContractTypeID,
                tpCurrencyTypeID,
                TaxRate,
                tpInvoiceTypeID,
                ContractAmount,
                AcceptInvoiceAmount,
                tpPayConditionID,
                LateFeePerDay,
                IsHasCertificate,
                IsHasUserManual,
                IsHasTechMapPaper,
                OtherInfo,
                QualityGuaranteePeriod,
                QualityGuaranteeDate,
                tpAcceptStandardID,
                AllowReturnDays,
                PayPlan,
                tpDeliveryModeID,
                tpFreightPaySideID,
                tpInstaldebugSideID,
                Remark,
                tpContractBillStateID,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate
            from dtPurchase";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtPurchase entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtPurchase(
                ID,
                BillCode,
                BillDate,
                bsAccountID,
                dtProjectID,
                ProjectCode,
                ContractCode,
                ContractName,
                IsAttachContract,
                MainContractCode,
                bsSupplierID,
                ContractSignDate,
                tpContractTypeID,
                tpCurrencyTypeID,
                TaxRate,
                tpInvoiceTypeID,
                ContractAmount,
                AcceptInvoiceAmount,
                tpPayConditionID,
                LateFeePerDay,
                IsHasCertificate,
                IsHasUserManual,
                IsHasTechMapPaper,
                OtherInfo,
                QualityGuaranteePeriod,
                QualityGuaranteeDate,
                tpAcceptStandardID,
                AllowReturnDays,
                PayPlan,
                tpDeliveryModeID,
                tpFreightPaySideID,
                tpInstaldebugSideID,
                Remark,
                tpContractBillStateID,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate)
            values (
                @ID,
                @BillCode,
                @BillDate,
                @bsAccountID,
                @dtProjectID,
                @ProjectCode,
                @ContractCode,
                @ContractName,
                @IsAttachContract,
                @MainContractCode,
                @bsSupplierID,
                @ContractSignDate,
                @tpContractTypeID,
                @tpCurrencyTypeID,
                @TaxRate,
                @tpInvoiceTypeID,
                @ContractAmount,
                @AcceptInvoiceAmount,
                @tpPayConditionID,
                @LateFeePerDay,
                @IsHasCertificate,
                @IsHasUserManual,
                @IsHasTechMapPaper,
                @OtherInfo,
                @QualityGuaranteePeriod,
                @QualityGuaranteeDate,
                @tpAcceptStandardID,
                @AllowReturnDays,
                @PayPlan,
                @tpDeliveryModeID,
                @tpFreightPaySideID,
                @tpInstaldebugSideID,
                @Remark,
                @tpContractBillStateID,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtPurchase entity)
        {
            string _strUpdateSql = @"Update  dtPurchase set
                ID = @ID, 
                BillCode = @BillCode, 
                BillDate = @BillDate, 
                bsAccountID = @bsAccountID, 
                dtProjectID = @dtProjectID, 
                ProjectCode = @ProjectCode, 
                ContractCode = @ContractCode, 
                ContractName = @ContractName, 
                IsAttachContract = @IsAttachContract, 
                MainContractCode = @MainContractCode, 
                bsSupplierID = @bsSupplierID, 
                ContractSignDate = @ContractSignDate, 
                tpContractTypeID = @tpContractTypeID, 
                tpCurrencyTypeID = @tpCurrencyTypeID, 
                TaxRate = @TaxRate, 
                tpInvoiceTypeID = @tpInvoiceTypeID, 
                ContractAmount = @ContractAmount, 
                AcceptInvoiceAmount = @AcceptInvoiceAmount, 
                tpPayConditionID = @tpPayConditionID, 
                LateFeePerDay = @LateFeePerDay, 
                IsHasCertificate = @IsHasCertificate, 
                IsHasUserManual = @IsHasUserManual, 
                IsHasTechMapPaper = @IsHasTechMapPaper, 
                OtherInfo = @OtherInfo, 
                QualityGuaranteePeriod = @QualityGuaranteePeriod, 
                QualityGuaranteeDate = @QualityGuaranteeDate, 
                tpAcceptStandardID = @tpAcceptStandardID, 
                AllowReturnDays = @AllowReturnDays, 
                PayPlan = @PayPlan, 
                tpDeliveryModeID = @tpDeliveryModeID, 
                tpFreightPaySideID = @tpFreightPaySideID, 
                tpInstaldebugSideID = @tpInstaldebugSideID, 
                Remark = @Remark, 
                tpContractBillStateID = @tpContractBillStateID, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate 
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
            string _strDeleteSql = @"delete dtPurchase where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    