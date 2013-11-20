/*
 * Created by zhye at 2013-11-20 9:21:59; 
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
    public class dtWeekReportAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.dtWeekReport> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ID,
                BillCode,
                dtProjectID,
                WriteDate,
                WeekNumber,
                MonitorPlace,
                MonitorDate,
                WeatherInfo,
                MonitorContent,
                MonitorResult,
                RectificationMeasure,
                TeamLeaderSuggestion,
                IsSubmited,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpBillStateId
            from dtWeekReport";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.QueryMultiple(strSql.ToString(), MixCondition, commandType: CommandType.Text).Read<dtPurchaseMdl>().ToList();
            }    
        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public bool Insert(Model.dtWeekReport entity)
        {
            //StringBuilder strSql = new StringBuilder();
            string _strInsertSql = @"insert into dtWeekReport(
                ID,
                BillCode,
                dtProjectID,
                WriteDate,
                WeekNumber,
                MonitorPlace,
                MonitorDate,
                WeatherInfo,
                MonitorContent,
                MonitorResult,
                RectificationMeasure,
                TeamLeaderSuggestion,
                IsSubmited,
                CreateMan,
                CreateDate,
                EditMan,
                EditDate,
                tpBillStateId)
            values (
                @ID,
                @BillCode,
                @dtProjectID,
                @WriteDate,
                @WeekNumber,
                @MonitorPlace,
                @MonitorDate,
                @WeatherInfo,
                @MonitorContent,
                @MonitorResult,
                @RectificationMeasure,
                @TeamLeaderSuggestion,
                @IsSubmited,
                @CreateMan,
                @CreateDate,
                @EditMan,
                @EditDate,
                @tpBillStateId)";
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), model, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.dtWeekReport entity)
        {
            string _strUpdateSql = @"Update  dtWeekReport set
                ID = @ID, 
                BillCode = @BillCode, 
                dtProjectID = @dtProjectID, 
                WriteDate = @WriteDate, 
                WeekNumber = @WeekNumber, 
                MonitorPlace = @MonitorPlace, 
                MonitorDate = @MonitorDate, 
                WeatherInfo = @WeatherInfo, 
                MonitorContent = @MonitorContent, 
                MonitorResult = @MonitorResult, 
                RectificationMeasure = @RectificationMeasure, 
                TeamLeaderSuggestion = @TeamLeaderSuggestion, 
                IsSubmited = @IsSubmited, 
                CreateMan = @CreateMan, 
                CreateDate = @CreateDate, 
                EditMan = @EditMan, 
                EditDate = @EditDate, 
                tpBillStateId = @tpBillStateId 
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
            string _strDeleteSql = @"delete dtWeekReport where Id = @Id";
            var Condition =new { ID = Id };
            using (SqlConnection conn = DapperFactory.CrateOpenConnection())
            {
                return conn.Execute(strSql.ToString(), Condition, commandType: CommandType.Text) > 0 ? true : false;
            }    
        }
    }
}    