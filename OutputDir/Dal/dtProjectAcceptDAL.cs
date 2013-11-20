/*
 * Created by zhye at 2013-11-20 9:24:13; 
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
    public class dtProjectAcceptAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtProjectAccept> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                dtProjectID,
                bsAccountID,
                tpProjectAcceptTypeID,
                ContractCode,
                bsSupplierID_Construct,
                bsSupplierID_Instal,
                bsSupplierID_Produce,
                InitialCheckDesc,
                RealStartWorkDate,
                RealCompleteWorkDate,
                CheckAcceptDate,
                TransferDate,
                ProjectBudgetAmount,
                ProjectRealUseAmount,
                PartItemFeeConstitute,
                ProjectInstallConfirm,
                EquipmentOperateConfirm,
                CheckAcceptFileInfo,
                CheckAcceptSummary,
                tpCheckAcceptStateID,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                Remark
            from dtProjectAccept";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtProjectAccept entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtProjectAccept(
                ID,
                BillCode,
                dtProjectID,
                bsAccountID,
                tpProjectAcceptTypeID,
                ContractCode,
                bsSupplierID_Construct,
                bsSupplierID_Instal,
                bsSupplierID_Produce,
                InitialCheckDesc,
                RealStartWorkDate,
                RealCompleteWorkDate,
                CheckAcceptDate,
                TransferDate,
                ProjectBudgetAmount,
                ProjectRealUseAmount,
                PartItemFeeConstitute,
                ProjectInstallConfirm,
                EquipmentOperateConfirm,
                CheckAcceptFileInfo,
                CheckAcceptSummary,
                tpCheckAcceptStateID,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                Remark)
            values (
                @ID,
                @BillCode,
                @dtProjectID,
                @bsAccountID,
                @tpProjectAcceptTypeID,
                @ContractCode,
                @bsSupplierID_Construct,
                @bsSupplierID_Instal,
                @bsSupplierID_Produce,
                @InitialCheckDesc,
                @RealStartWorkDate,
                @RealCompleteWorkDate,
                @CheckAcceptDate,
                @TransferDate,
                @ProjectBudgetAmount,
                @ProjectRealUseAmount,
                @PartItemFeeConstitute,
                @ProjectInstallConfirm,
                @EquipmentOperateConfirm,
                @CheckAcceptFileInfo,
                @CheckAcceptSummary,
                @tpCheckAcceptStateID,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @Remark)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtProjectAccept entity)
        {
            string _strUpdateSql = @"Update  dtProjectAccept set
                ID = @ID, 
                BillCode = @BillCode, 
                dtProjectID = @dtProjectID, 
                bsAccountID = @bsAccountID, 
                tpProjectAcceptTypeID = @tpProjectAcceptTypeID, 
                ContractCode = @ContractCode, 
                bsSupplierID_Construct = @bsSupplierID_Construct, 
                bsSupplierID_Instal = @bsSupplierID_Instal, 
                bsSupplierID_Produce = @bsSupplierID_Produce, 
                InitialCheckDesc = @InitialCheckDesc, 
                RealStartWorkDate = @RealStartWorkDate, 
                RealCompleteWorkDate = @RealCompleteWorkDate, 
                CheckAcceptDate = @CheckAcceptDate, 
                TransferDate = @TransferDate, 
                ProjectBudgetAmount = @ProjectBudgetAmount, 
                ProjectRealUseAmount = @ProjectRealUseAmount, 
                PartItemFeeConstitute = @PartItemFeeConstitute, 
                ProjectInstallConfirm = @ProjectInstallConfirm, 
                EquipmentOperateConfirm = @EquipmentOperateConfirm, 
                CheckAcceptFileInfo = @CheckAcceptFileInfo, 
                CheckAcceptSummary = @CheckAcceptSummary, 
                tpCheckAcceptStateID = @tpCheckAcceptStateID, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
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
            string _strDeleteSql = @"delete dtProjectAccept where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    