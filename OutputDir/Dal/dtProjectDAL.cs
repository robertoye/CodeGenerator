/*
 * Created by zhye at 2013-11-20 9:21:26; 
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
    public class dtProjectAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtProject> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                Code,
                Name,
                bsAccountID,
                EmergencyProgram,
                tpRunModelID,
                tpProjectTypeID,
                ApplyMan,
                ApplyDate,
                FinalCheckMan,
                ReplyDate,
                tpProjectLevelID,
                IsInvolvePurchase,
                IsConfirmHumanCost,
                IsConfrimTechnologyQuality,
                PlanStartWorkDate,
                PlanCompleteWorkDate,
                ProposalBase,
                ProposalTarget,
                BehoofHarmAnalysis,
                PlanContent,
                PredictAlterItem,
                InvestAmount,
                AlterAmount,
                LimitRate,
                InvestRecycleCalculate,
                trDeptID,
                LeadDepartSuggest,
                tpCallControlID,
                WhiteListMember,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                SystemRemark,
                IsTriggerGuard,
                tpGuardTypeID,
                tpProjectStateID
            from dtProject";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtProject entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtProject(
                ID,
                Code,
                Name,
                bsAccountID,
                EmergencyProgram,
                tpRunModelID,
                tpProjectTypeID,
                ApplyMan,
                ApplyDate,
                FinalCheckMan,
                ReplyDate,
                tpProjectLevelID,
                IsInvolvePurchase,
                IsConfirmHumanCost,
                IsConfrimTechnologyQuality,
                PlanStartWorkDate,
                PlanCompleteWorkDate,
                ProposalBase,
                ProposalTarget,
                BehoofHarmAnalysis,
                PlanContent,
                PredictAlterItem,
                InvestAmount,
                AlterAmount,
                LimitRate,
                InvestRecycleCalculate,
                trDeptID,
                LeadDepartSuggest,
                tpCallControlID,
                WhiteListMember,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                SystemRemark,
                IsTriggerGuard,
                tpGuardTypeID,
                tpProjectStateID)
            values (
                @ID,
                @Code,
                @Name,
                @bsAccountID,
                @EmergencyProgram,
                @tpRunModelID,
                @tpProjectTypeID,
                @ApplyMan,
                @ApplyDate,
                @FinalCheckMan,
                @ReplyDate,
                @tpProjectLevelID,
                @IsInvolvePurchase,
                @IsConfirmHumanCost,
                @IsConfrimTechnologyQuality,
                @PlanStartWorkDate,
                @PlanCompleteWorkDate,
                @ProposalBase,
                @ProposalTarget,
                @BehoofHarmAnalysis,
                @PlanContent,
                @PredictAlterItem,
                @InvestAmount,
                @AlterAmount,
                @LimitRate,
                @InvestRecycleCalculate,
                @trDeptID,
                @LeadDepartSuggest,
                @tpCallControlID,
                @WhiteListMember,
                @Remark,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @SystemRemark,
                @IsTriggerGuard,
                @tpGuardTypeID,
                @tpProjectStateID)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtProject entity)
        {
            string _strUpdateSql = @"Update  dtProject set
                ID = @ID, 
                Code = @Code, 
                Name = @Name, 
                bsAccountID = @bsAccountID, 
                EmergencyProgram = @EmergencyProgram, 
                tpRunModelID = @tpRunModelID, 
                tpProjectTypeID = @tpProjectTypeID, 
                ApplyMan = @ApplyMan, 
                ApplyDate = @ApplyDate, 
                FinalCheckMan = @FinalCheckMan, 
                ReplyDate = @ReplyDate, 
                tpProjectLevelID = @tpProjectLevelID, 
                IsInvolvePurchase = @IsInvolvePurchase, 
                IsConfirmHumanCost = @IsConfirmHumanCost, 
                IsConfrimTechnologyQuality = @IsConfrimTechnologyQuality, 
                PlanStartWorkDate = @PlanStartWorkDate, 
                PlanCompleteWorkDate = @PlanCompleteWorkDate, 
                ProposalBase = @ProposalBase, 
                ProposalTarget = @ProposalTarget, 
                BehoofHarmAnalysis = @BehoofHarmAnalysis, 
                PlanContent = @PlanContent, 
                PredictAlterItem = @PredictAlterItem, 
                InvestAmount = @InvestAmount, 
                AlterAmount = @AlterAmount, 
                LimitRate = @LimitRate, 
                InvestRecycleCalculate = @InvestRecycleCalculate, 
                trDeptID = @trDeptID, 
                LeadDepartSuggest = @LeadDepartSuggest, 
                tpCallControlID = @tpCallControlID, 
                WhiteListMember = @WhiteListMember, 
                Remark = @Remark, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
                SystemRemark = @SystemRemark, 
                IsTriggerGuard = @IsTriggerGuard, 
                tpGuardTypeID = @tpGuardTypeID, 
                tpProjectStateID = @tpProjectStateID 
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
            string _strDeleteSql = @"delete dtProject where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    