/*
 * Created by zhye at 2013-11-20 9:21:39; 
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
    public class dtProjectMemberAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtProjectMember> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                dtProjectID,
                bsEmployeeId,
                ResponsibilityDesc,
                tpProjectRoleID,
                AttendRate,
                tpWorkStateID
            from dtProjectMember";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtProjectMember entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtProjectMember(
                ID,
                dtProjectID,
                bsEmployeeId,
                ResponsibilityDesc,
                tpProjectRoleID,
                AttendRate,
                tpWorkStateID)
            values (
                @ID,
                @dtProjectID,
                @bsEmployeeId,
                @ResponsibilityDesc,
                @tpProjectRoleID,
                @AttendRate,
                @tpWorkStateID)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtProjectMember entity)
        {
            string _strUpdateSql = @"Update  dtProjectMember set
                ID = @ID, 
                dtProjectID = @dtProjectID, 
                bsEmployeeId = @bsEmployeeId, 
                ResponsibilityDesc = @ResponsibilityDesc, 
                tpProjectRoleID = @tpProjectRoleID, 
                AttendRate = @AttendRate, 
                tpWorkStateID = @tpWorkStateID 
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
            string _strDeleteSql = @"delete dtProjectMember where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    