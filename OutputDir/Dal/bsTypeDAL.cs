/*
 * Created by zhye at 2013-11-20 9:22:22; 
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
    public class bsTypeAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.bsType> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                Name,
                Code,
                IsValid,
                IsSystem,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate
            from bsType";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.bsType entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into bsType(
                ID,
                Name,
                Code,
                IsValid,
                IsSystem,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate)
            values (
                @ID,
                @Name,
                @Code,
                @IsValid,
                @IsSystem,
                @Remark,
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
        public void Update(Model.bsType entity)
        {
            string _strUpdateSql = @"Update  bsType set
                ID = @ID, 
                Name = @Name, 
                Code = @Code, 
                IsValid = @IsValid, 
                IsSystem = @IsSystem, 
                Remark = @Remark, 
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
            string _strDeleteSql = @"delete bsType where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    