/*
 * Created by zhye at 2013-11-20 9:21:55; 
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
    public class dtPurchasePaySchemeAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtPurchasePayScheme> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtPurchaseID,
                PayProgressNo,
                PayContentDesc,
                PayRate,
                PayAmountByRate,
                PayAmountAfterChange,
                AccumulatePayAmount,
                IsPrepay,
                IsNeedArriveGoods,
                IsNeedCheck,
                IsNeedQualityGuarantee,
                IsNeedInvoice,
                Remark
            from dtPurchasePayScheme";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtPurchasePayScheme entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtPurchasePayScheme(
                ID,
                dtPurchaseID,
                PayProgressNo,
                PayContentDesc,
                PayRate,
                PayAmountByRate,
                PayAmountAfterChange,
                AccumulatePayAmount,
                IsPrepay,
                IsNeedArriveGoods,
                IsNeedCheck,
                IsNeedQualityGuarantee,
                IsNeedInvoice,
                Remark)
            values (
                @ID,
                @dtPurchaseID,
                @PayProgressNo,
                @PayContentDesc,
                @PayRate,
                @PayAmountByRate,
                @PayAmountAfterChange,
                @AccumulatePayAmount,
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
        public void Update(Model.dtPurchasePayScheme entity)
        {
            string _strUpdateSql = @"Update  dtPurchasePayScheme set
                ID = @ID, 
                dtPurchaseID = @dtPurchaseID, 
                PayProgressNo = @PayProgressNo, 
                PayContentDesc = @PayContentDesc, 
                PayRate = @PayRate, 
                PayAmountByRate = @PayAmountByRate, 
                PayAmountAfterChange = @PayAmountAfterChange, 
                AccumulatePayAmount = @AccumulatePayAmount, 
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
            string _strDeleteSql = @"delete dtPurchasePayScheme where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    