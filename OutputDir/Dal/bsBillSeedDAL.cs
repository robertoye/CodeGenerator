/*
 * Created by zhye at 2013-11-20 9:23:07; 
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
    public class bsBillSeedAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.bsBillSeed> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                tpOrganId,
                OrganCode,
                isEnableOrgan,
                bsBillTypeId,
                BillCode,
                isEnableType,
                DateChar,
                isEnableDate,
                CodeSeed
            from bsBillSeed";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.bsBillSeed entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into bsBillSeed(
                ID,
                tpOrganId,
                OrganCode,
                isEnableOrgan,
                bsBillTypeId,
                BillCode,
                isEnableType,
                DateChar,
                isEnableDate,
                CodeSeed)
            values (
                @ID,
                @tpOrganId,
                @OrganCode,
                @isEnableOrgan,
                @bsBillTypeId,
                @BillCode,
                @isEnableType,
                @DateChar,
                @isEnableDate,
                @CodeSeed)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.bsBillSeed entity)
        {
            string _strUpdateSql = @"Update  bsBillSeed set
                ID = @ID, 
                tpOrganId = @tpOrganId, 
                OrganCode = @OrganCode, 
                isEnableOrgan = @isEnableOrgan, 
                bsBillTypeId = @bsBillTypeId, 
                BillCode = @BillCode, 
                isEnableType = @isEnableType, 
                DateChar = @DateChar, 
                isEnableDate = @isEnableDate, 
                CodeSeed = @CodeSeed 
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
            string _strDeleteSql = @"delete bsBillSeed where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    