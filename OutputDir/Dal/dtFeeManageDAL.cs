/*
 * Created by zhye at 2013-11-20 9:23:55; 
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
    public class dtFeeManageAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtFeeManage> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                BillDate,
                BusinessDate,
                bsAccountID,
                trDeptID,
                dtProjectID,
                dtTaskID,
                tpCurrencyTypeID,
                TaxRate,
                Amount,
                FundContent,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpBillStateID
            from dtFeeManage";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtFeeManage entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtFeeManage(
                ID,
                BillCode,
                BillDate,
                BusinessDate,
                bsAccountID,
                trDeptID,
                dtProjectID,
                dtTaskID,
                tpCurrencyTypeID,
                TaxRate,
                Amount,
                FundContent,
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
                @BusinessDate,
                @bsAccountID,
                @trDeptID,
                @dtProjectID,
                @dtTaskID,
                @tpCurrencyTypeID,
                @TaxRate,
                @Amount,
                @FundContent,
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
        public void Update(Model.dtFeeManage entity)
        {
            string _strUpdateSql = @"Update  dtFeeManage set
                ID = @ID, 
                BillCode = @BillCode, 
                BillDate = @BillDate, 
                BusinessDate = @BusinessDate, 
                bsAccountID = @bsAccountID, 
                trDeptID = @trDeptID, 
                dtProjectID = @dtProjectID, 
                dtTaskID = @dtTaskID, 
                tpCurrencyTypeID = @tpCurrencyTypeID, 
                TaxRate = @TaxRate, 
                Amount = @Amount, 
                FundContent = @FundContent, 
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
            string _strDeleteSql = @"delete dtFeeManage where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    