/*
 * Created by zhye at 2013-11-20 9:21:29; 
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
    public class bsTypeDetailAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.bsTypeDetail> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                bsTypeID,
                SerialNo,
                Name,
                DeafultValue,
                Emblem,
                Remark,
                IsValid
            from bsTypeDetail";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.bsTypeDetail entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into bsTypeDetail(
                ID,
                bsTypeID,
                SerialNo,
                Name,
                DeafultValue,
                Emblem,
                Remark,
                IsValid)
            values (
                @ID,
                @bsTypeID,
                @SerialNo,
                @Name,
                @DeafultValue,
                @Emblem,
                @Remark,
                @IsValid)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.bsTypeDetail entity)
        {
            string _strUpdateSql = @"Update  bsTypeDetail set
                ID = @ID, 
                bsTypeID = @bsTypeID, 
                SerialNo = @SerialNo, 
                Name = @Name, 
                DeafultValue = @DeafultValue, 
                Emblem = @Emblem, 
                Remark = @Remark, 
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
            string _strDeleteSql = @"delete bsTypeDetail where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    