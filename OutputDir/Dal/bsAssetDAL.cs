/*
 * Created by zhye at 2013-11-20 9:22:44; 
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
    public class bsAssetAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.bsAsset> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                bsAccountId,
                Code,
                AssetCode,
                Name,
                ShortName,
                Standard,
                Model,
                MainCode,
                tpAssetManageTypeID,
                tpAssetFinanceID,
                tpAssetStateID,
                trPositionID,
                trDeptID,
                InstalDate,
                AssetRawWorth,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                Remark,
                bsSupplierId,
                ContractCode,
                ProjectCode,
                tpAssetOATypeID,
                isValid
            from bsAsset";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.bsAsset entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into bsAsset(
                ID,
                bsAccountId,
                Code,
                AssetCode,
                Name,
                ShortName,
                Standard,
                Model,
                MainCode,
                tpAssetManageTypeID,
                tpAssetFinanceID,
                tpAssetStateID,
                trPositionID,
                trDeptID,
                InstalDate,
                AssetRawWorth,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                Remark,
                bsSupplierId,
                ContractCode,
                ProjectCode,
                tpAssetOATypeID,
                isValid)
            values (
                @ID,
                @bsAccountId,
                @Code,
                @AssetCode,
                @Name,
                @ShortName,
                @Standard,
                @Model,
                @MainCode,
                @tpAssetManageTypeID,
                @tpAssetFinanceID,
                @tpAssetStateID,
                @trPositionID,
                @trDeptID,
                @InstalDate,
                @AssetRawWorth,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @Remark,
                @bsSupplierId,
                @ContractCode,
                @ProjectCode,
                @tpAssetOATypeID,
                @isValid)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.bsAsset entity)
        {
            string _strUpdateSql = @"Update  bsAsset set
                ID = @ID, 
                bsAccountId = @bsAccountId, 
                Code = @Code, 
                AssetCode = @AssetCode, 
                Name = @Name, 
                ShortName = @ShortName, 
                Standard = @Standard, 
                Model = @Model, 
                MainCode = @MainCode, 
                tpAssetManageTypeID = @tpAssetManageTypeID, 
                tpAssetFinanceID = @tpAssetFinanceID, 
                tpAssetStateID = @tpAssetStateID, 
                trPositionID = @trPositionID, 
                trDeptID = @trDeptID, 
                InstalDate = @InstalDate, 
                AssetRawWorth = @AssetRawWorth, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
                Remark = @Remark, 
                bsSupplierId = @bsSupplierId, 
                ContractCode = @ContractCode, 
                ProjectCode = @ProjectCode, 
                tpAssetOATypeID = @tpAssetOATypeID, 
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
            string _strDeleteSql = @"delete bsAsset where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    