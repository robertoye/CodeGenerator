/*
 * Created by zhye at 2013-11-20 9:23:26; 
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
    public class dtEquipInstalAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtEquipInstal> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                BillDate,
                AuditDate,
                bsAccountID,
                trDeptID,
                dtProjectID,
                dtPurchaseID,
                ProjectCode,
                ContractCode,
                bsSupplierID,
                trDeptID_Usage,
                trPositionID,
                TechnologyMan,
                ShakedownPeriod,
                HeadDeptSuggest,
                UsageDeptSuggest,
                EngineeringDeptSuggest,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpBillStateID
            from dtEquipInstal";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtEquipInstal entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtEquipInstal(
                ID,
                BillCode,
                BillDate,
                AuditDate,
                bsAccountID,
                trDeptID,
                dtProjectID,
                dtPurchaseID,
                ProjectCode,
                ContractCode,
                bsSupplierID,
                trDeptID_Usage,
                trPositionID,
                TechnologyMan,
                ShakedownPeriod,
                HeadDeptSuggest,
                UsageDeptSuggest,
                EngineeringDeptSuggest,
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
                @dtPurchaseID,
                @ProjectCode,
                @ContractCode,
                @bsSupplierID,
                @trDeptID_Usage,
                @trPositionID,
                @TechnologyMan,
                @ShakedownPeriod,
                @HeadDeptSuggest,
                @UsageDeptSuggest,
                @EngineeringDeptSuggest,
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
        public void Update(Model.dtEquipInstal entity)
        {
            string _strUpdateSql = @"Update  dtEquipInstal set
                ID = @ID, 
                BillCode = @BillCode, 
                BillDate = @BillDate, 
                AuditDate = @AuditDate, 
                bsAccountID = @bsAccountID, 
                trDeptID = @trDeptID, 
                dtProjectID = @dtProjectID, 
                dtPurchaseID = @dtPurchaseID, 
                ProjectCode = @ProjectCode, 
                ContractCode = @ContractCode, 
                bsSupplierID = @bsSupplierID, 
                trDeptID_Usage = @trDeptID_Usage, 
                trPositionID = @trPositionID, 
                TechnologyMan = @TechnologyMan, 
                ShakedownPeriod = @ShakedownPeriod, 
                HeadDeptSuggest = @HeadDeptSuggest, 
                UsageDeptSuggest = @UsageDeptSuggest, 
                EngineeringDeptSuggest = @EngineeringDeptSuggest, 
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
            string _strDeleteSql = @"delete dtEquipInstal where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    