/*
 * Created by zhye at 2013-11-20 9:22:50; 
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
    public class trDeptAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.trDept> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                ParentID,
                Name,
                LevelNum,
                CreateMan,
                CreateDate
            from trDept";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.trDept entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into trDept(
                ID,
                ParentID,
                Name,
                LevelNum,
                CreateMan,
                CreateDate)
            values (
                @ID,
                @ParentID,
                @Name,
                @LevelNum,
                @CreateMan,
                @CreateDate)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.trDept entity)
        {
            string _strUpdateSql = @"Update  trDept set
                ID = @ID, 
                ParentID = @ParentID, 
                Name = @Name, 
                LevelNum = @LevelNum, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate 
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
            string _strDeleteSql = @"delete trDept where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    