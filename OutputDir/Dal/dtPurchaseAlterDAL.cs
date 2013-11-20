/*
 * Created by zhye at 2013-11-20 9:21:42; 
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
    public class dtPurchaseAlterAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtPurchaseAlter> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                dtProjectID,
                bsAccountID,
                dtPurchaseID,
                bsSupplierID,
                AlterDate,
                AlterAmount,
                tpPayConditionID,
                AlterReason,
                Remark,
                IsSubmited,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate
            from dtPurchaseAlter";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtPurchaseAlter entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtPurchaseAlter(
                ID,
                BillCode,
                dtProjectID,
                bsAccountID,
                dtPurchaseID,
                bsSupplierID,
                AlterDate,
                AlterAmount,
                tpPayConditionID,
                AlterReason,
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
                @bsAccountID,
                @dtPurchaseID,
                @bsSupplierID,
                @AlterDate,
                @AlterAmount,
                @tpPayConditionID,
                @AlterReason,
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
        public void Update(Model.dtPurchaseAlter entity)
        {
            string _strUpdateSql = @"Update  dtPurchaseAlter set
                ID = @ID, 
                BillCode = @BillCode, 
                dtProjectID = @dtProjectID, 
                bsAccountID = @bsAccountID, 
                dtPurchaseID = @dtPurchaseID, 
                bsSupplierID = @bsSupplierID, 
                AlterDate = @AlterDate, 
                AlterAmount = @AlterAmount, 
                tpPayConditionID = @tpPayConditionID, 
                AlterReason = @AlterReason, 
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
            string _strDeleteSql = @"delete dtPurchaseAlter where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    