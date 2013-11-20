/*
 * Created by zhye at 2013-11-20 9:21:46; 
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
    public class dtPurchaseAlterDetailAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtPurchaseAlterDetail> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtPurchaseID,
                dtPurchaseDetailID,
                dtTaskID,
                ItemName,
                StandardModel,
                tpUnitID,
                BudgetPrice,
                LimitRate,
                SupplierPrice,
                TaxPrice,
                AlteTaxPrice,
                Quantity,
                ArriveQuantity,
                AlterQuantity,
                RequireArriveDate,
                AlterArriveDate,
                Remark
            from dtPurchaseAlterDetail";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtPurchaseAlterDetail entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtPurchaseAlterDetail(
                ID,
                dtPurchaseID,
                dtPurchaseDetailID,
                dtTaskID,
                ItemName,
                StandardModel,
                tpUnitID,
                BudgetPrice,
                LimitRate,
                SupplierPrice,
                TaxPrice,
                AlteTaxPrice,
                Quantity,
                ArriveQuantity,
                AlterQuantity,
                RequireArriveDate,
                AlterArriveDate,
                Remark)
            values (
                @ID,
                @dtPurchaseID,
                @dtPurchaseDetailID,
                @dtTaskID,
                @ItemName,
                @StandardModel,
                @tpUnitID,
                @BudgetPrice,
                @LimitRate,
                @SupplierPrice,
                @TaxPrice,
                @AlteTaxPrice,
                @Quantity,
                @ArriveQuantity,
                @AlterQuantity,
                @RequireArriveDate,
                @AlterArriveDate,
                @Remark)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtPurchaseAlterDetail entity)
        {
            string _strUpdateSql = @"Update  dtPurchaseAlterDetail set
                ID = @ID, 
                dtPurchaseID = @dtPurchaseID, 
                dtPurchaseDetailID = @dtPurchaseDetailID, 
                dtTaskID = @dtTaskID, 
                ItemName = @ItemName, 
                StandardModel = @StandardModel, 
                tpUnitID = @tpUnitID, 
                BudgetPrice = @BudgetPrice, 
                LimitRate = @LimitRate, 
                SupplierPrice = @SupplierPrice, 
                TaxPrice = @TaxPrice, 
                AlteTaxPrice = @AlteTaxPrice, 
                Quantity = @Quantity, 
                ArriveQuantity = @ArriveQuantity, 
                AlterQuantity = @AlterQuantity, 
                RequireArriveDate = @RequireArriveDate, 
                AlterArriveDate = @AlterArriveDate, 
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
            string _strDeleteSql = @"delete dtPurchaseAlterDetail where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    