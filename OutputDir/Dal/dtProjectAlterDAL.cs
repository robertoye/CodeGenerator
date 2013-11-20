/*
 * Created by zhye at 2013-11-20 9:22:05; 
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
    public class dtProjectAlterAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtProjectAlter> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                dtProjectID,
                dtTaskID,
                AlterProject,
                WriteDate,
                AlterDate,
                AlterNumber,
                CompleteDate,
                IsNeedConfirmByFinance,
                IsNeedConfirmByQC,
                AlterBase,
                AlterHistory,
                AlterContent,
                AlterReason,
                TeamSuggestion,
                RawBudgetAmount,
                AccumulateAlterAmount,
                CurrentAlterAmount,
                AfterAlterBudgetAmount,
                FinalCheckMan,
                tpBillStateID,
                Remark,
                IsSubmited,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate
            from dtProjectAlter";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtProjectAlter entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtProjectAlter(
                ID,
                BillCode,
                dtProjectID,
                dtTaskID,
                AlterProject,
                WriteDate,
                AlterDate,
                AlterNumber,
                CompleteDate,
                IsNeedConfirmByFinance,
                IsNeedConfirmByQC,
                AlterBase,
                AlterHistory,
                AlterContent,
                AlterReason,
                TeamSuggestion,
                RawBudgetAmount,
                AccumulateAlterAmount,
                CurrentAlterAmount,
                AfterAlterBudgetAmount,
                FinalCheckMan,
                tpBillStateID,
                Remark,
                IsSubmited,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate)
            values (
                @ID,
                @BillCode,
                @dtProjectID,
                @dtTaskID,
                @AlterProject,
                @WriteDate,
                @AlterDate,
                @AlterNumber,
                @CompleteDate,
                @IsNeedConfirmByFinance,
                @IsNeedConfirmByQC,
                @AlterBase,
                @AlterHistory,
                @AlterContent,
                @AlterReason,
                @TeamSuggestion,
                @RawBudgetAmount,
                @AccumulateAlterAmount,
                @CurrentAlterAmount,
                @AfterAlterBudgetAmount,
                @FinalCheckMan,
                @tpBillStateID,
                @Remark,
                @IsSubmited,
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
        public void Update(Model.dtProjectAlter entity)
        {
            string _strUpdateSql = @"Update  dtProjectAlter set
                ID = @ID, 
                BillCode = @BillCode, 
                dtProjectID = @dtProjectID, 
                dtTaskID = @dtTaskID, 
                AlterProject = @AlterProject, 
                WriteDate = @WriteDate, 
                AlterDate = @AlterDate, 
                AlterNumber = @AlterNumber, 
                CompleteDate = @CompleteDate, 
                IsNeedConfirmByFinance = @IsNeedConfirmByFinance, 
                IsNeedConfirmByQC = @IsNeedConfirmByQC, 
                AlterBase = @AlterBase, 
                AlterHistory = @AlterHistory, 
                AlterContent = @AlterContent, 
                AlterReason = @AlterReason, 
                TeamSuggestion = @TeamSuggestion, 
                RawBudgetAmount = @RawBudgetAmount, 
                AccumulateAlterAmount = @AccumulateAlterAmount, 
                CurrentAlterAmount = @CurrentAlterAmount, 
                AfterAlterBudgetAmount = @AfterAlterBudgetAmount, 
                FinalCheckMan = @FinalCheckMan, 
                tpBillStateID = @tpBillStateID, 
                Remark = @Remark, 
                IsSubmited = @IsSubmited, 
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
            string _strDeleteSql = @"delete dtProjectAlter where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    