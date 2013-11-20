/*
 * Created by zhye at 2013-11-20 9:23:42; 
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
    public class dtEquipQualityAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtEquipQuality> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                bsBillTypeID,
                BillDate,
                AuditDate,
                bsAccountID,
                trDeptID,
                trDeptID_Usage,
                dtProjectID,
                dtPurchaseID,
                ProjectCode,
                ContractCode,
                bsSupplierID,
                QualityPeriod,
                UsageDeptSuggest,
                EngineeringDeptSuggest,
                Remark,
                CreateMan,
                CreateDate,
                tpBillStateID,
                WithholdItem,
                Suggest
            from dtEquipQuality";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtEquipQuality entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtEquipQuality(
                ID,
                BillCode,
                bsBillTypeID,
                BillDate,
                AuditDate,
                bsAccountID,
                trDeptID,
                trDeptID_Usage,
                dtProjectID,
                dtPurchaseID,
                ProjectCode,
                ContractCode,
                bsSupplierID,
                QualityPeriod,
                UsageDeptSuggest,
                EngineeringDeptSuggest,
                Remark,
                CreateMan,
                CreateDate,
                tpBillStateID,
                WithholdItem,
                Suggest)
            values (
                @ID,
                @BillCode,
                @bsBillTypeID,
                @BillDate,
                @AuditDate,
                @bsAccountID,
                @trDeptID,
                @trDeptID_Usage,
                @dtProjectID,
                @dtPurchaseID,
                @ProjectCode,
                @ContractCode,
                @bsSupplierID,
                @QualityPeriod,
                @UsageDeptSuggest,
                @EngineeringDeptSuggest,
                @Remark,
                @CreateMan,
                @CreateDate,
                @tpBillStateID,
                @WithholdItem,
                @Suggest)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtEquipQuality entity)
        {
            string _strUpdateSql = @"Update  dtEquipQuality set
                ID = @ID, 
                BillCode = @BillCode, 
                bsBillTypeID = @bsBillTypeID, 
                BillDate = @BillDate, 
                AuditDate = @AuditDate, 
                bsAccountID = @bsAccountID, 
                trDeptID = @trDeptID, 
                trDeptID_Usage = @trDeptID_Usage, 
                dtProjectID = @dtProjectID, 
                dtPurchaseID = @dtPurchaseID, 
                ProjectCode = @ProjectCode, 
                ContractCode = @ContractCode, 
                bsSupplierID = @bsSupplierID, 
                QualityPeriod = @QualityPeriod, 
                UsageDeptSuggest = @UsageDeptSuggest, 
                EngineeringDeptSuggest = @EngineeringDeptSuggest, 
                Remark = @Remark, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                tpBillStateID = @tpBillStateID, 
                WithholdItem = @WithholdItem, 
                Suggest = @Suggest 
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
            string _strDeleteSql = @"delete dtEquipQuality where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    