/*
 * Created by zhye at 2013-11-20 9:23:01; 
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
    public class bsAccountAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.bsAccount> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                Code,
                Name,
                ShortName,
                Address,
                PostCode,
                Linkman,
                Tel,
                Fax,
                Remark,
                DepositBank,
                BankAccount,
                TaxNo,
                PayMan,
                KingDeeCode,
                tpOrganID,
                isValid
            from bsAccount";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.bsAccount entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into bsAccount(
                ID,
                Code,
                Name,
                ShortName,
                Address,
                PostCode,
                Linkman,
                Tel,
                Fax,
                Remark,
                DepositBank,
                BankAccount,
                TaxNo,
                PayMan,
                KingDeeCode,
                tpOrganID,
                isValid)
            values (
                @ID,
                @Code,
                @Name,
                @ShortName,
                @Address,
                @PostCode,
                @Linkman,
                @Tel,
                @Fax,
                @Remark,
                @DepositBank,
                @BankAccount,
                @TaxNo,
                @PayMan,
                @KingDeeCode,
                @tpOrganID,
                @isValid)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.bsAccount entity)
        {
            string _strUpdateSql = @"Update  bsAccount set
                ID = @ID, 
                Code = @Code, 
                Name = @Name, 
                ShortName = @ShortName, 
                Address = @Address, 
                PostCode = @PostCode, 
                Linkman = @Linkman, 
                Tel = @Tel, 
                Fax = @Fax, 
                Remark = @Remark, 
                DepositBank = @DepositBank, 
                BankAccount = @BankAccount, 
                TaxNo = @TaxNo, 
                PayMan = @PayMan, 
                KingDeeCode = @KingDeeCode, 
                tpOrganID = @tpOrganID, 
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
            string _strDeleteSql = @"delete bsAccount where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    