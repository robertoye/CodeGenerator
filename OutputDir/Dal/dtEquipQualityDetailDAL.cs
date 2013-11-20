/*
 * Created by zhye at 2013-11-20 9:23:46; 
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
    public class dtEquipQualityDetailAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtEquipQualityDetail> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtEquipQualityID,
                dtTaskID,
                dtPurchaseDetailID,
                AssetCode,
                trDeptID,
                trPositionID,
                Quantity,
                TaxPrice
            from dtEquipQualityDetail";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtEquipQualityDetail entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtEquipQualityDetail(
                ID,
                dtEquipQualityID,
                dtTaskID,
                dtPurchaseDetailID,
                AssetCode,
                trDeptID,
                trPositionID,
                Quantity,
                TaxPrice)
            values (
                @ID,
                @dtEquipQualityID,
                @dtTaskID,
                @dtPurchaseDetailID,
                @AssetCode,
                @trDeptID,
                @trPositionID,
                @Quantity,
                @TaxPrice)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtEquipQualityDetail entity)
        {
            string _strUpdateSql = @"Update  dtEquipQualityDetail set
                ID = @ID, 
                dtEquipQualityID = @dtEquipQualityID, 
                dtTaskID = @dtTaskID, 
                dtPurchaseDetailID = @dtPurchaseDetailID, 
                AssetCode = @AssetCode, 
                trDeptID = @trDeptID, 
                trPositionID = @trPositionID, 
                Quantity = @Quantity, 
                TaxPrice = @TaxPrice 
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
            string _strDeleteSql = @"delete dtEquipQualityDetail where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    