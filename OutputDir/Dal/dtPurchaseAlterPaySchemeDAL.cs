/*
 * Created by zhye at 2013-11-20 9:21:49; 
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
    public class dtPurchaseAlterPaySchemeAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtPurchaseAlterPayScheme> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtPurchaseID,
                dtPurchasePaySchemeID,
                RawProgressNo,
                AlterAfterProgressNo,
                RawPayContentDesc,
                CurrentPayContentDesc,
                RawPayRate,
                AlterAfterPayRate,
                RawRatePayAmount,
                CurrentRatePayAmount,
                RawConfirmPayAmount,
                AlterAfterConfrimPayAmount,
                AccumulatePayAmount,
                RawPayCondition,
                IsPrepay,
                IsNeedArriveGoods,
                IsNeedCheck,
                IsNeedQualityGuarantee,
                IsNeedInvoice,
                Remark
            from dtPurchaseAlterPayScheme";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtPurchaseAlterPayScheme entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtPurchaseAlterPayScheme(
                ID,
                dtPurchaseID,
                dtPurchasePaySchemeID,
                RawProgressNo,
                AlterAfterProgressNo,
                RawPayContentDesc,
                CurrentPayContentDesc,
                RawPayRate,
                AlterAfterPayRate,
                RawRatePayAmount,
                CurrentRatePayAmount,
                RawConfirmPayAmount,
                AlterAfterConfrimPayAmount,
                AccumulatePayAmount,
                RawPayCondition,
                IsPrepay,
                IsNeedArriveGoods,
                IsNeedCheck,
                IsNeedQualityGuarantee,
                IsNeedInvoice,
                Remark)
            values (
                @ID,
                @dtPurchaseID,
                @dtPurchasePaySchemeID,
                @RawProgressNo,
                @AlterAfterProgressNo,
                @RawPayContentDesc,
                @CurrentPayContentDesc,
                @RawPayRate,
                @AlterAfterPayRate,
                @RawRatePayAmount,
                @CurrentRatePayAmount,
                @RawConfirmPayAmount,
                @AlterAfterConfrimPayAmount,
                @AccumulatePayAmount,
                @RawPayCondition,
                @IsPrepay,
                @IsNeedArriveGoods,
                @IsNeedCheck,
                @IsNeedQualityGuarantee,
                @IsNeedInvoice,
                @Remark)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtPurchaseAlterPayScheme entity)
        {
            string _strUpdateSql = @"Update  dtPurchaseAlterPayScheme set
                ID = @ID, 
                dtPurchaseID = @dtPurchaseID, 
                dtPurchasePaySchemeID = @dtPurchasePaySchemeID, 
                RawProgressNo = @RawProgressNo, 
                AlterAfterProgressNo = @AlterAfterProgressNo, 
                RawPayContentDesc = @RawPayContentDesc, 
                CurrentPayContentDesc = @CurrentPayContentDesc, 
                RawPayRate = @RawPayRate, 
                AlterAfterPayRate = @AlterAfterPayRate, 
                RawRatePayAmount = @RawRatePayAmount, 
                CurrentRatePayAmount = @CurrentRatePayAmount, 
                RawConfirmPayAmount = @RawConfirmPayAmount, 
                AlterAfterConfrimPayAmount = @AlterAfterConfrimPayAmount, 
                AccumulatePayAmount = @AccumulatePayAmount, 
                RawPayCondition = @RawPayCondition, 
                IsPrepay = @IsPrepay, 
                IsNeedArriveGoods = @IsNeedArriveGoods, 
                IsNeedCheck = @IsNeedCheck, 
                IsNeedQualityGuarantee = @IsNeedQualityGuarantee, 
                IsNeedInvoice = @IsNeedInvoice, 
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
            string _strDeleteSql = @"delete dtPurchaseAlterPayScheme where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    