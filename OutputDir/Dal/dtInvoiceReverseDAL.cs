/*
 * Created by zhye at 2013-11-20 9:24:02; 
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
    public class dtInvoiceReverseAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtInvoiceReverse> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtPayID,
                dtInvoiceID,
                ResiduePayAmount,
                ThisTimePayAmount,
                ReverseDate
            from dtInvoiceReverse";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtInvoiceReverse entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtInvoiceReverse(
                ID,
                dtPayID,
                dtInvoiceID,
                ResiduePayAmount,
                ThisTimePayAmount,
                ReverseDate)
            values (
                @ID,
                @dtPayID,
                @dtInvoiceID,
                @ResiduePayAmount,
                @ThisTimePayAmount,
                @ReverseDate)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtInvoiceReverse entity)
        {
            string _strUpdateSql = @"Update  dtInvoiceReverse set
                ID = @ID, 
                dtPayID = @dtPayID, 
                dtInvoiceID = @dtInvoiceID, 
                ResiduePayAmount = @ResiduePayAmount, 
                ThisTimePayAmount = @ThisTimePayAmount, 
                ReverseDate = @ReverseDate 
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
            string _strDeleteSql = @"delete dtInvoiceReverse where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    