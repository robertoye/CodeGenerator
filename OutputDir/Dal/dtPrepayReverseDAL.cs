/*
 * Created by zhye at 2013-11-20 9:24:16; 
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
    public class dtPrepayReverseAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtPrepayReverse> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtPrepayID,
                dtInvoiceID,
                ResidueAmount,
                ThisTimeAmout,
                CheckoutDate
            from dtPrepayReverse";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtPrepayReverse entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtPrepayReverse(
                ID,
                dtPrepayID,
                dtInvoiceID,
                ResidueAmount,
                ThisTimeAmout,
                CheckoutDate)
            values (
                @ID,
                @dtPrepayID,
                @dtInvoiceID,
                @ResidueAmount,
                @ThisTimeAmout,
                @CheckoutDate)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtPrepayReverse entity)
        {
            string _strUpdateSql = @"Update  dtPrepayReverse set
                ID = @ID, 
                dtPrepayID = @dtPrepayID, 
                dtInvoiceID = @dtInvoiceID, 
                ResidueAmount = @ResidueAmount, 
                ThisTimeAmout = @ThisTimeAmout, 
                CheckoutDate = @CheckoutDate 
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
            string _strDeleteSql = @"delete dtPrepayReverse where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    