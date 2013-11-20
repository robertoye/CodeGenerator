/*
 * Created by zhye at 2013-11-20 9:23:15; 
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
    public class bsEmployeeAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.bsEmployee> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                Name,
                trDeptID,
                Email,
                OfficeTel,
                PositionName,
                DomainAccount,
                DeptHead
            from bsEmployee";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.bsEmployee entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into bsEmployee(
                ID,
                Name,
                trDeptID,
                Email,
                OfficeTel,
                PositionName,
                DomainAccount,
                DeptHead)
            values (
                @ID,
                @Name,
                @trDeptID,
                @Email,
                @OfficeTel,
                @PositionName,
                @DomainAccount,
                @DeptHead)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.bsEmployee entity)
        {
            string _strUpdateSql = @"Update  bsEmployee set
                ID = @ID, 
                Name = @Name, 
                trDeptID = @trDeptID, 
                Email = @Email, 
                OfficeTel = @OfficeTel, 
                PositionName = @PositionName, 
                DomainAccount = @DomainAccount, 
                DeptHead = @DeptHead 
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
            string _strDeleteSql = @"delete bsEmployee where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    