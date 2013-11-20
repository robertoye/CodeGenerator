/*
 * Created by zhye at 2013-11-20 9:22:41; 
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
    public class dtTaskLogAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtTaskLog> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                BillDate,
                dtProjectID,
                dtTaskID,
                RawCompleteRate,
                NowCompleteRate,
                Content,
                IsInvest,
                Quantity,
                PurchaseQaulity,
                PlanCompleteDate,
                EndDate,
                bsEmployeeID,
                AttendMan,
                isSendEmaill,
                Remark,
                CreateMan,
                CreateDate,
                FinalCheckMan,
                FinalCheckDate,
                tpBillStateID
            from dtTaskLog";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtTaskLog entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtTaskLog(
                ID,
                BillCode,
                BillDate,
                dtProjectID,
                dtTaskID,
                RawCompleteRate,
                NowCompleteRate,
                Content,
                IsInvest,
                Quantity,
                PurchaseQaulity,
                PlanCompleteDate,
                EndDate,
                bsEmployeeID,
                AttendMan,
                isSendEmaill,
                Remark,
                CreateMan,
                CreateDate,
                FinalCheckMan,
                FinalCheckDate,
                tpBillStateID)
            values (
                @ID,
                @BillCode,
                @BillDate,
                @dtProjectID,
                @dtTaskID,
                @RawCompleteRate,
                @NowCompleteRate,
                @Content,
                @IsInvest,
                @Quantity,
                @PurchaseQaulity,
                @PlanCompleteDate,
                @EndDate,
                @bsEmployeeID,
                @AttendMan,
                @isSendEmaill,
                @Remark,
                @CreateMan,
                @CreateDate,
                @FinalCheckMan,
                @FinalCheckDate,
                @tpBillStateID)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtTaskLog entity)
        {
            string _strUpdateSql = @"Update  dtTaskLog set
                ID = @ID, 
                BillCode = @BillCode, 
                BillDate = @BillDate, 
                dtProjectID = @dtProjectID, 
                dtTaskID = @dtTaskID, 
                RawCompleteRate = @RawCompleteRate, 
                NowCompleteRate = @NowCompleteRate, 
                Content = @Content, 
                IsInvest = @IsInvest, 
                Quantity = @Quantity, 
                PurchaseQaulity = @PurchaseQaulity, 
                PlanCompleteDate = @PlanCompleteDate, 
                EndDate = @EndDate, 
                bsEmployeeID = @bsEmployeeID, 
                AttendMan = @AttendMan, 
                isSendEmaill = @isSendEmaill, 
                Remark = @Remark, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                FinalCheckMan = @FinalCheckMan, 
                FinalCheckDate = @FinalCheckDate, 
                tpBillStateID = @tpBillStateID 
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
            string _strDeleteSql = @"delete dtTaskLog where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    