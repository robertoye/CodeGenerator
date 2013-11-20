/*
 * Created by zhye at 2013-11-20 9:23:32; 
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
    public class dtEquipInstalDetailAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtEquipInstalDetail> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtEquipInstalID,
                dtTaskID,
                dtPurchaseDetailID,
                AssetCode,
                trDeptID,
                trPositionID,
                Quantity,
                DeviceUnitPrice
            from dtEquipInstalDetail";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtEquipInstalDetail entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtEquipInstalDetail(
                ID,
                dtEquipInstalID,
                dtTaskID,
                dtPurchaseDetailID,
                AssetCode,
                trDeptID,
                trPositionID,
                Quantity,
                DeviceUnitPrice)
            values (
                @ID,
                @dtEquipInstalID,
                @dtTaskID,
                @dtPurchaseDetailID,
                @AssetCode,
                @trDeptID,
                @trPositionID,
                @Quantity,
                @DeviceUnitPrice)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtEquipInstalDetail entity)
        {
            string _strUpdateSql = @"Update  dtEquipInstalDetail set
                ID = @ID, 
                dtEquipInstalID = @dtEquipInstalID, 
                dtTaskID = @dtTaskID, 
                dtPurchaseDetailID = @dtPurchaseDetailID, 
                AssetCode = @AssetCode, 
                trDeptID = @trDeptID, 
                trPositionID = @trPositionID, 
                Quantity = @Quantity, 
                DeviceUnitPrice = @DeviceUnitPrice 
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
            string _strDeleteSql = @"delete dtEquipInstalDetail where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    