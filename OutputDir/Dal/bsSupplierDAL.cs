/*
 * Created by zhye at 2013-11-20 9:22:37; 
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
    public class bsSupplierAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.bsSupplier> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                Code,
                Name,
                ShortName,
                Linkman,
                LinkAddress,
                Tel,
                Fax,
                PostCode,
                SaleAfterService,
                tpCountryID,
                tpCityID,
                CertificateCode,
                CertificateLevel,
                DepositBank,
                TaxNo,
                BankAddress,
                BankAccount,
                tpClearingModeId,
                ClearingDays,
                ShopCard,
                RegMoney,
                ParentDept,
                MainProduct,
                SaleRange,
                SalesMan,
                Email,
                WebSite,
                isInterior,
                isSupplier,
                isISP,
                isManuFacturer,
                MainCustomer,
                EmployeeNum,
                InfoAcceptPhone,
                KingDeeCode,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpInfoStateID
            from bsSupplier";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.bsSupplier entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into bsSupplier(
                ID,
                Code,
                Name,
                ShortName,
                Linkman,
                LinkAddress,
                Tel,
                Fax,
                PostCode,
                SaleAfterService,
                tpCountryID,
                tpCityID,
                CertificateCode,
                CertificateLevel,
                DepositBank,
                TaxNo,
                BankAddress,
                BankAccount,
                tpClearingModeId,
                ClearingDays,
                ShopCard,
                RegMoney,
                ParentDept,
                MainProduct,
                SaleRange,
                SalesMan,
                Email,
                WebSite,
                isInterior,
                isSupplier,
                isISP,
                isManuFacturer,
                MainCustomer,
                EmployeeNum,
                InfoAcceptPhone,
                KingDeeCode,
                Remark,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpInfoStateID)
            values (
                @ID,
                @Code,
                @Name,
                @ShortName,
                @Linkman,
                @LinkAddress,
                @Tel,
                @Fax,
                @PostCode,
                @SaleAfterService,
                @tpCountryID,
                @tpCityID,
                @CertificateCode,
                @CertificateLevel,
                @DepositBank,
                @TaxNo,
                @BankAddress,
                @BankAccount,
                @tpClearingModeId,
                @ClearingDays,
                @ShopCard,
                @RegMoney,
                @ParentDept,
                @MainProduct,
                @SaleRange,
                @SalesMan,
                @Email,
                @WebSite,
                @isInterior,
                @isSupplier,
                @isISP,
                @isManuFacturer,
                @MainCustomer,
                @EmployeeNum,
                @InfoAcceptPhone,
                @KingDeeCode,
                @Remark,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @tpInfoStateID)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.bsSupplier entity)
        {
            string _strUpdateSql = @"Update  bsSupplier set
                ID = @ID, 
                Code = @Code, 
                Name = @Name, 
                ShortName = @ShortName, 
                Linkman = @Linkman, 
                LinkAddress = @LinkAddress, 
                Tel = @Tel, 
                Fax = @Fax, 
                PostCode = @PostCode, 
                SaleAfterService = @SaleAfterService, 
                tpCountryID = @tpCountryID, 
                tpCityID = @tpCityID, 
                CertificateCode = @CertificateCode, 
                CertificateLevel = @CertificateLevel, 
                DepositBank = @DepositBank, 
                TaxNo = @TaxNo, 
                BankAddress = @BankAddress, 
                BankAccount = @BankAccount, 
                tpClearingModeId = @tpClearingModeId, 
                ClearingDays = @ClearingDays, 
                ShopCard = @ShopCard, 
                RegMoney = @RegMoney, 
                ParentDept = @ParentDept, 
                MainProduct = @MainProduct, 
                SaleRange = @SaleRange, 
                SalesMan = @SalesMan, 
                Email = @Email, 
                WebSite = @WebSite, 
                isInterior = @isInterior, 
                isSupplier = @isSupplier, 
                isISP = @isISP, 
                isManuFacturer = @isManuFacturer, 
                MainCustomer = @MainCustomer, 
                EmployeeNum = @EmployeeNum, 
                InfoAcceptPhone = @InfoAcceptPhone, 
                KingDeeCode = @KingDeeCode, 
                Remark = @Remark, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
                tpInfoStateID = @tpInfoStateID 
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
            string _strDeleteSql = @"delete bsSupplier where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    