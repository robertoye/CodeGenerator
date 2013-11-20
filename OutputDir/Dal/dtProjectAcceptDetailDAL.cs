/*
 * Created by zhye at 2013-11-20 9:21:32; 
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
    public class dtProjectAcceptDetailAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtProjectAcceptDetail> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtProjectAcceptID,
                dtProjectID,
                ContractCode,
                dtPurchaseID,
                tpProjectAcceptTypeID,
                tpContractTypeID,
                ContractAmount,
                Remark
            from dtProjectAcceptDetail";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtProjectAcceptDetail entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtProjectAcceptDetail(
                ID,
                dtProjectAcceptID,
                dtProjectID,
                ContractCode,
                dtPurchaseID,
                tpProjectAcceptTypeID,
                tpContractTypeID,
                ContractAmount,
                Remark)
            values (
                @ID,
                @dtProjectAcceptID,
                @dtProjectID,
                @ContractCode,
                @dtPurchaseID,
                @tpProjectAcceptTypeID,
                @tpContractTypeID,
                @ContractAmount,
                @Remark)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtProjectAcceptDetail entity)
        {
            string _strUpdateSql = @"Update  dtProjectAcceptDetail set
                ID = @ID, 
                dtProjectAcceptID = @dtProjectAcceptID, 
                dtProjectID = @dtProjectID, 
                ContractCode = @ContractCode, 
                dtPurchaseID = @dtPurchaseID, 
                tpProjectAcceptTypeID = @tpProjectAcceptTypeID, 
                tpContractTypeID = @tpContractTypeID, 
                ContractAmount = @ContractAmount, 
                Remark = @Remark 
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
            string _strDeleteSql = @"delete dtProjectAcceptDetail where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    