/*
 * Created by zhye at 2013-11-20 9:22:15; 
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
    public class dtReviewAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtReview> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                BillDate,
                dtProjectID,
                bsAccountID,
                ProjectCode,
                trDeptID,
                AcceptPermitDate,
                ReviewDate,
                SupplyOrgan,
                TeamLeader,
                DepartSuggest,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                Remark,
                tpBillStateID
            from dtReview";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtReview entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtReview(
                ID,
                BillCode,
                BillDate,
                dtProjectID,
                bsAccountID,
                ProjectCode,
                trDeptID,
                AcceptPermitDate,
                ReviewDate,
                SupplyOrgan,
                TeamLeader,
                DepartSuggest,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                Remark,
                tpBillStateID)
            values (
                @ID,
                @BillCode,
                @BillDate,
                @dtProjectID,
                @bsAccountID,
                @ProjectCode,
                @trDeptID,
                @AcceptPermitDate,
                @ReviewDate,
                @SupplyOrgan,
                @TeamLeader,
                @DepartSuggest,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @Remark,
                @tpBillStateID)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtReview entity)
        {
            string _strUpdateSql = @"Update  dtReview set
                ID = @ID, 
                BillCode = @BillCode, 
                BillDate = @BillDate, 
                dtProjectID = @dtProjectID, 
                bsAccountID = @bsAccountID, 
                ProjectCode = @ProjectCode, 
                trDeptID = @trDeptID, 
                AcceptPermitDate = @AcceptPermitDate, 
                ReviewDate = @ReviewDate, 
                SupplyOrgan = @SupplyOrgan, 
                TeamLeader = @TeamLeader, 
                DepartSuggest = @DepartSuggest, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
                Remark = @Remark, 
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
            string _strDeleteSql = @"delete dtReview where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    