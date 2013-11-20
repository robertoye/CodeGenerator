/*
 * Created by zhye at 2013-11-20 9:22:47; 
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
    public class dtAttachmentAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtAttachment> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                TableName,
                BillIDValue,
                FileName,
                SavePath,
                tpAttachTypeID,
                Remark,
                DefaultValue,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate
            from dtAttachment";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtAttachment entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtAttachment(
                ID,
                TableName,
                BillIDValue,
                FileName,
                SavePath,
                tpAttachTypeID,
                Remark,
                DefaultValue,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate)
            values (
                @ID,
                @TableName,
                @BillIDValue,
                @FileName,
                @SavePath,
                @tpAttachTypeID,
                @Remark,
                @DefaultValue,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtAttachment entity)
        {
            string _strUpdateSql = @"Update  dtAttachment set
                ID = @ID, 
                TableName = @TableName, 
                BillIDValue = @BillIDValue, 
                FileName = @FileName, 
                SavePath = @SavePath, 
                tpAttachTypeID = @tpAttachTypeID, 
                Remark = @Remark, 
                DefaultValue = @DefaultValue, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate 
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
            string _strDeleteSql = @"delete dtAttachment where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    