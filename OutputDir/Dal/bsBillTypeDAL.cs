/*
 * Created by zhye at 2013-11-20 9:22:30; 
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
    public class bsBillTypeAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.bsBillType> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                Name,
                TableName,
                CodePrefix
            from bsBillType";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.bsBillType entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into bsBillType(
                ID,
                Name,
                TableName,
                CodePrefix)
            values (
                @ID,
                @Name,
                @TableName,
                @CodePrefix)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.bsBillType entity)
        {
            string _strUpdateSql = @"Update  bsBillType set
                ID = @ID, 
                Name = @Name, 
                TableName = @TableName, 
                CodePrefix = @CodePrefix 
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
            string _strDeleteSql = @"delete bsBillType where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    