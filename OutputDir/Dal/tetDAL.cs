/*
 * Created by zhye at 2013-11-20 9:23:22; 
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
    public class tetAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.tet> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                Name,
                DeafultValue,
                Emblem,
                isValid
            from tet";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.tet entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into tet(
                ID,
                Name,
                DeafultValue,
                Emblem,
                isValid)
            values (
                @ID,
                @Name,
                @DeafultValue,
                @Emblem,
                @isValid)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.tet entity)
        {
            string _strUpdateSql = @"Update  tet set
                ID = @ID, 
                Name = @Name, 
                DeafultValue = @DeafultValue, 
                Emblem = @Emblem, 
                isValid = @isValid 
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
            string _strDeleteSql = @"delete tet where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    