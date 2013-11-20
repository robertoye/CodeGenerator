/*
 * Created by zhye at 2013-11-20 9:23:11; 
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
    public class dtEquipAcceptDetailAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtEquipAcceptDetail> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtEquipAcceptID,
                dtPurchaseDetailID,
                AssetCode,
                ItemName,
                Brand,
                StandardModel,
                TechniqueParm,
                HostCode,
                tpUnitID,
                Quantity,
                TaxRate,
                ContainTaxUnitPrice,
                trDeptID,
                trPositionID,
                Remark
            from dtEquipAcceptDetail";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtEquipAcceptDetail entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtEquipAcceptDetail(
                ID,
                dtEquipAcceptID,
                dtPurchaseDetailID,
                AssetCode,
                ItemName,
                Brand,
                StandardModel,
                TechniqueParm,
                HostCode,
                tpUnitID,
                Quantity,
                TaxRate,
                ContainTaxUnitPrice,
                trDeptID,
                trPositionID,
                Remark)
            values (
                @ID,
                @dtEquipAcceptID,
                @dtPurchaseDetailID,
                @AssetCode,
                @ItemName,
                @Brand,
                @StandardModel,
                @TechniqueParm,
                @HostCode,
                @tpUnitID,
                @Quantity,
                @TaxRate,
                @ContainTaxUnitPrice,
                @trDeptID,
                @trPositionID,
                @Remark)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtEquipAcceptDetail entity)
        {
            string _strUpdateSql = @"Update  dtEquipAcceptDetail set
                ID = @ID, 
                dtEquipAcceptID = @dtEquipAcceptID, 
                dtPurchaseDetailID = @dtPurchaseDetailID, 
                AssetCode = @AssetCode, 
                ItemName = @ItemName, 
                Brand = @Brand, 
                StandardModel = @StandardModel, 
                TechniqueParm = @TechniqueParm, 
                HostCode = @HostCode, 
                tpUnitID = @tpUnitID, 
                Quantity = @Quantity, 
                TaxRate = @TaxRate, 
                ContainTaxUnitPrice = @ContainTaxUnitPrice, 
                trDeptID = @trDeptID, 
                trPositionID = @trPositionID, 
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
            string _strDeleteSql = @"delete dtEquipAcceptDetail where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    