/*
 * Created by zhye at 2013-11-20 9:21:35; 
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
    public class dtProjectAlterDetailAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtProjectAlterDetail> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                ProjectAlterID,
                dtTaskID,
                ParentID,
                Code,
                TaskDesciption,
                PriorityLevel,
                Proportion,
                WorkContent,
                PlanStartWorkDate,
                PlanCompleteWorkDate,
                ResponsibilityMan,
                AttendMan,
                NeedResource,
                IsDependPretaskComplete,
                IsKeyPoint,
                IsInvest,
                BudgetItemName,
                IsEquipment,
                tpUnitID,
                StandardModel,
                NeedAmount,
                ContainTaxUnitPrice,
                tpCurrencyTypeID,
                PurchaseCycle,
                RequireArriveDate,
                tpFetchModelID,
                AccumulateOrderQuantity,
                AccumulateOrderAmount,
                MainTechniqueParm,
                UsageInstruction,
                trDeptID,
                AlterNumbers,
                AccumulateAlterAmount,
                Remark
            from dtProjectAlterDetail";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtProjectAlterDetail entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtProjectAlterDetail(
                ID,
                ProjectAlterID,
                dtTaskID,
                ParentID,
                Code,
                TaskDesciption,
                PriorityLevel,
                Proportion,
                WorkContent,
                PlanStartWorkDate,
                PlanCompleteWorkDate,
                ResponsibilityMan,
                AttendMan,
                NeedResource,
                IsDependPretaskComplete,
                IsKeyPoint,
                IsInvest,
                BudgetItemName,
                IsEquipment,
                tpUnitID,
                StandardModel,
                NeedAmount,
                ContainTaxUnitPrice,
                tpCurrencyTypeID,
                PurchaseCycle,
                RequireArriveDate,
                tpFetchModelID,
                AccumulateOrderQuantity,
                AccumulateOrderAmount,
                MainTechniqueParm,
                UsageInstruction,
                trDeptID,
                AlterNumbers,
                AccumulateAlterAmount,
                Remark)
            values (
                @ID,
                @ProjectAlterID,
                @dtTaskID,
                @ParentID,
                @Code,
                @TaskDesciption,
                @PriorityLevel,
                @Proportion,
                @WorkContent,
                @PlanStartWorkDate,
                @PlanCompleteWorkDate,
                @ResponsibilityMan,
                @AttendMan,
                @NeedResource,
                @IsDependPretaskComplete,
                @IsKeyPoint,
                @IsInvest,
                @BudgetItemName,
                @IsEquipment,
                @tpUnitID,
                @StandardModel,
                @NeedAmount,
                @ContainTaxUnitPrice,
                @tpCurrencyTypeID,
                @PurchaseCycle,
                @RequireArriveDate,
                @tpFetchModelID,
                @AccumulateOrderQuantity,
                @AccumulateOrderAmount,
                @MainTechniqueParm,
                @UsageInstruction,
                @trDeptID,
                @AlterNumbers,
                @AccumulateAlterAmount,
                @Remark)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtProjectAlterDetail entity)
        {
            string _strUpdateSql = @"Update  dtProjectAlterDetail set
                ID = @ID, 
                ProjectAlterID = @ProjectAlterID, 
                dtTaskID = @dtTaskID, 
                ParentID = @ParentID, 
                Code = @Code, 
                TaskDesciption = @TaskDesciption, 
                PriorityLevel = @PriorityLevel, 
                Proportion = @Proportion, 
                WorkContent = @WorkContent, 
                PlanStartWorkDate = @PlanStartWorkDate, 
                PlanCompleteWorkDate = @PlanCompleteWorkDate, 
                ResponsibilityMan = @ResponsibilityMan, 
                AttendMan = @AttendMan, 
                NeedResource = @NeedResource, 
                IsDependPretaskComplete = @IsDependPretaskComplete, 
                IsKeyPoint = @IsKeyPoint, 
                IsInvest = @IsInvest, 
                BudgetItemName = @BudgetItemName, 
                IsEquipment = @IsEquipment, 
                tpUnitID = @tpUnitID, 
                StandardModel = @StandardModel, 
                NeedAmount = @NeedAmount, 
                ContainTaxUnitPrice = @ContainTaxUnitPrice, 
                tpCurrencyTypeID = @tpCurrencyTypeID, 
                PurchaseCycle = @PurchaseCycle, 
                RequireArriveDate = @RequireArriveDate, 
                tpFetchModelID = @tpFetchModelID, 
                AccumulateOrderQuantity = @AccumulateOrderQuantity, 
                AccumulateOrderAmount = @AccumulateOrderAmount, 
                MainTechniqueParm = @MainTechniqueParm, 
                UsageInstruction = @UsageInstruction, 
                trDeptID = @trDeptID, 
                AlterNumbers = @AlterNumbers, 
                AccumulateAlterAmount = @AccumulateAlterAmount, 
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
            string _strDeleteSql = @"delete dtProjectAlterDetail where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    