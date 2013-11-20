/*
 * Created by zhye at 2013-11-20 9:22:53; 
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
    public class trPositionAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.trPosition> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                ParentID,
                PositionDesc,
                LevelNum,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                IsValid
            from trPosition";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.trPosition entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into trPosition(
                ID,
                ParentID,
                PositionDesc,
                LevelNum,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                IsValid)
            values (
                @ID,
                @ParentID,
                @PositionDesc,
                @LevelNum,
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
        public void Update(Model.trPosition entity)
        {
            string _strUpdateSql = @"Update  trPosition set
                ID = @ID, 
                ParentID = @ParentID, 
                PositionDesc = @PositionDesc, 
                LevelNum = @LevelNum, 
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
            string _strDeleteSql = @"delete trPosition where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    