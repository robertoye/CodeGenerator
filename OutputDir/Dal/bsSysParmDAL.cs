/*
 * Created by zhye at 2013-11-20 9:22:26; 
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
    public class bsSysParmAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.bsSysParm> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                tpOrganId,
                Code,
                Name,
                DigitValue,
                UpperLimitValue,
                LowerLimitValue,
                CharValue,
                IsDigit,
                IsSystemParm,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                IsValid
            from bsSysParm";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.bsSysParm entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into bsSysParm(
                ID,
                tpOrganId,
                Code,
                Name,
                DigitValue,
                UpperLimitValue,
                LowerLimitValue,
                CharValue,
                IsDigit,
                IsSystemParm,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                IsValid)
            values (
                @ID,
                @tpOrganId,
                @Code,
                @Name,
                @DigitValue,
                @UpperLimitValue,
                @LowerLimitValue,
                @CharValue,
                @IsDigit,
                @IsSystemParm,
                @Remark,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @IsValid)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.bsSysParm entity)
        {
            string _strUpdateSql = @"Update  bsSysParm set
                ID = @ID, 
                tpOrganId = @tpOrganId, 
                Code = @Code, 
                Name = @Name, 
                DigitValue = @DigitValue, 
                UpperLimitValue = @UpperLimitValue, 
                LowerLimitValue = @LowerLimitValue, 
                CharValue = @CharValue, 
                IsDigit = @IsDigit, 
                IsSystemParm = @IsSystemParm, 
                Remark = @Remark, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
                IsValid = @IsValid 
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
            string _strDeleteSql = @"delete bsSysParm where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    