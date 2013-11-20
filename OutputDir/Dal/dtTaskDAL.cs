/*
 * Created by zhye at 2013-11-20 9:24:06; 
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
    public class dtTaskAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtTask> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                Code,
                BillDate,
                dtProjectID,
                ParentID,
                TaskDesc,
                PriorityLevel,
                ProportionRate,
                CompleteRate,
                WorkContent,
                IsClose,
                CloseReason,
                PlanStartWorkDate,
                PlanCompleteWorkDate,
                RealCompleteDate,
                ResponsibilityMan,
                AttendMan,
                NeedResource,
                IsDependPretaskComplete,
                IsKeyPoint,
                IsInvest,
                BudgetAmount,
                BudgetItemName,
                IsEquipment,
                tpUnitID,
                StandardModel,
                Qaulity,
                TaxPrice,
                tpCurrencyTypeID,
                PurchaseCycle,
                RequireArriveDate,
                tpFetchModelID,
                PurchaseQaulity,
                PurchaseAmount,
                MainTechniqueParm,
                UsageInstruction,
                trDeptID_Require,
                AlterNumbers,
                AlterAmount,
                IsEndCase,
                EndCaseMan,
                EndCaseDate,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                FinalCheckMan,
                FinalCheckDate,
                tpTaskStateID
            from dtTask";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtTask entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtTask(
                ID,
                Code,
                BillDate,
                dtProjectID,
                ParentID,
                TaskDesc,
                PriorityLevel,
                ProportionRate,
                CompleteRate,
                WorkContent,
                IsClose,
                CloseReason,
                PlanStartWorkDate,
                PlanCompleteWorkDate,
                RealCompleteDate,
                ResponsibilityMan,
                AttendMan,
                NeedResource,
                IsDependPretaskComplete,
                IsKeyPoint,
                IsInvest,
                BudgetAmount,
                BudgetItemName,
                IsEquipment,
                tpUnitID,
                StandardModel,
                Qaulity,
                TaxPrice,
                tpCurrencyTypeID,
                PurchaseCycle,
                RequireArriveDate,
                tpFetchModelID,
                PurchaseQaulity,
                PurchaseAmount,
                MainTechniqueParm,
                UsageInstruction,
                trDeptID_Require,
                AlterNumbers,
                AlterAmount,
                IsEndCase,
                EndCaseMan,
                EndCaseDate,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                FinalCheckMan,
                FinalCheckDate,
                tpTaskStateID)
            values (
                @ID,
                @Code,
                @BillDate,
                @dtProjectID,
                @ParentID,
                @TaskDesc,
                @PriorityLevel,
                @ProportionRate,
                @CompleteRate,
                @WorkContent,
                @IsClose,
                @CloseReason,
                @PlanStartWorkDate,
                @PlanCompleteWorkDate,
                @RealCompleteDate,
                @ResponsibilityMan,
                @AttendMan,
                @NeedResource,
                @IsDependPretaskComplete,
                @IsKeyPoint,
                @IsInvest,
                @BudgetAmount,
                @BudgetItemName,
                @IsEquipment,
                @tpUnitID,
                @StandardModel,
                @Qaulity,
                @TaxPrice,
                @tpCurrencyTypeID,
                @PurchaseCycle,
                @RequireArriveDate,
                @tpFetchModelID,
                @PurchaseQaulity,
                @PurchaseAmount,
                @MainTechniqueParm,
                @UsageInstruction,
                @trDeptID_Require,
                @AlterNumbers,
                @AlterAmount,
                @IsEndCase,
                @EndCaseMan,
                @EndCaseDate,
                @Remark,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @FinalCheckMan,
                @FinalCheckDate,
                @tpTaskStateID)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtTask entity)
        {
            string _strUpdateSql = @"Update  dtTask set
                ID = @ID, 
                Code = @Code, 
                BillDate = @BillDate, 
                dtProjectID = @dtProjectID, 
                ParentID = @ParentID, 
                TaskDesc = @TaskDesc, 
                PriorityLevel = @PriorityLevel, 
                ProportionRate = @ProportionRate, 
                CompleteRate = @CompleteRate, 
                WorkContent = @WorkContent, 
                IsClose = @IsClose, 
                CloseReason = @CloseReason, 
                PlanStartWorkDate = @PlanStartWorkDate, 
                PlanCompleteWorkDate = @PlanCompleteWorkDate, 
                RealCompleteDate = @RealCompleteDate, 
                ResponsibilityMan = @ResponsibilityMan, 
                AttendMan = @AttendMan, 
                NeedResource = @NeedResource, 
                IsDependPretaskComplete = @IsDependPretaskComplete, 
                IsKeyPoint = @IsKeyPoint, 
                IsInvest = @IsInvest, 
                BudgetAmount = @BudgetAmount, 
                BudgetItemName = @BudgetItemName, 
                IsEquipment = @IsEquipment, 
                tpUnitID = @tpUnitID, 
                StandardModel = @StandardModel, 
                Qaulity = @Qaulity, 
                TaxPrice = @TaxPrice, 
                tpCurrencyTypeID = @tpCurrencyTypeID, 
                PurchaseCycle = @PurchaseCycle, 
                RequireArriveDate = @RequireArriveDate, 
                tpFetchModelID = @tpFetchModelID, 
                PurchaseQaulity = @PurchaseQaulity, 
                PurchaseAmount = @PurchaseAmount, 
                MainTechniqueParm = @MainTechniqueParm, 
                UsageInstruction = @UsageInstruction, 
                trDeptID_Require = @trDeptID_Require, 
                AlterNumbers = @AlterNumbers, 
                AlterAmount = @AlterAmount, 
                IsEndCase = @IsEndCase, 
                EndCaseMan = @EndCaseMan, 
                EndCaseDate = @EndCaseDate, 
                Remark = @Remark, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
                FinalCheckMan = @FinalCheckMan, 
                FinalCheckDate = @FinalCheckDate, 
                tpTaskStateID = @tpTaskStateID 
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
            string _strDeleteSql = @"delete dtTask where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    