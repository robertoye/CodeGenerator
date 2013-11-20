/*
 * Created by zhye at 2013-11-20 9:21:52; 
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
    public class dtPurchaseDetailAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtPurchaseDetail> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtPurchaseID,
                dtTaskID,
                ItemName,
                StandardModel,
                tpUnitID,
                BudgetPrice,
                LimitRate,
                SupplierPrice,
                TaxPrice,
                BudgetQuantity,
                AccumulateQuantity,
                Quantity,
                ArriveQuantity,
                InstallQuantiry,
                QualityQuantity,
                RequireArriveDate,
                IsEndCase,
                Remark
            from dtPurchaseDetail";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtPurchaseDetail entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtPurchaseDetail(
                ID,
                dtPurchaseID,
                dtTaskID,
                ItemName,
                StandardModel,
                tpUnitID,
                BudgetPrice,
                LimitRate,
                SupplierPrice,
                TaxPrice,
                BudgetQuantity,
                AccumulateQuantity,
                Quantity,
                ArriveQuantity,
                InstallQuantiry,
                QualityQuantity,
                RequireArriveDate,
                IsEndCase,
                Remark)
            values (
                @ID,
                @dtPurchaseID,
                @dtTaskID,
                @ItemName,
                @StandardModel,
                @tpUnitID,
                @BudgetPrice,
                @LimitRate,
                @SupplierPrice,
                @TaxPrice,
                @BudgetQuantity,
                @AccumulateQuantity,
                @Quantity,
                @ArriveQuantity,
                @InstallQuantiry,
                @QualityQuantity,
                @RequireArriveDate,
                @IsEndCase,
                @Remark)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtPurchaseDetail entity)
        {
            string _strUpdateSql = @"Update  dtPurchaseDetail set
                ID = @ID, 
                dtPurchaseID = @dtPurchaseID, 
                dtTaskID = @dtTaskID, 
                ItemName = @ItemName, 
                StandardModel = @StandardModel, 
                tpUnitID = @tpUnitID, 
                BudgetPrice = @BudgetPrice, 
                LimitRate = @LimitRate, 
                SupplierPrice = @SupplierPrice, 
                TaxPrice = @TaxPrice, 
                BudgetQuantity = @BudgetQuantity, 
                AccumulateQuantity = @AccumulateQuantity, 
                Quantity = @Quantity, 
                ArriveQuantity = @ArriveQuantity, 
                InstallQuantiry = @InstallQuantiry, 
                QualityQuantity = @QualityQuantity, 
                RequireArriveDate = @RequireArriveDate, 
                IsEndCase = @IsEndCase, 
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
            string _strDeleteSql = @"delete dtPurchaseDetail where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    