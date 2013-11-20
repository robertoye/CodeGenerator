
/*
 * Created by zhye at 2013-11-20 9:21:57; 
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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract(Name = "dtWeekReport")]
    public class dtWeekReport
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 单据编号
      /// </summary>
      [DataMember(Name = "BillCode")]
      public string BillCode { get ; set ; } 

      /// <summary>
      /// 立项主表ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 填报日期
      /// </summary>
      [DataMember(Name = "WriteDate")]
      public string WriteDate { get ; set ; } 

      /// <summary>
      /// 项目第N周{$记录项目工作目前处第N周的数字$}
      /// </summary>
      [DataMember(Name = "WeekNumber")]
      public int WeekNumber { get ; set ; } 

      /// <summary>
      /// 监控地点
      /// </summary>
      [DataMember(Name = "MonitorPlace")]
      public string MonitorPlace { get ; set ; } 

      /// <summary>
      /// 监测时间
      /// </summary>
      [DataMember(Name = "MonitorDate")]
      public string MonitorDate { get ; set ; } 

      /// <summary>
      /// 气象信息{$土建工程类项目填写(由用户自行判断,系统不做控制)$}
      /// </summary>
      [DataMember(Name = "WeatherInfo")]
      public string WeatherInfo { get ; set ; } 

      /// <summary>
      /// 监控内容
      /// </summary>
      [DataMember(Name = "MonitorContent")]
      public string MonitorContent { get ; set ; } 

      /// <summary>
      /// 监控结论
      /// </summary>
      [DataMember(Name = "MonitorResult")]
      public string MonitorResult { get ; set ; } 

      /// <summary>
      /// 整改措施
      /// </summary>
      [DataMember(Name = "RectificationMeasure")]
      public string RectificationMeasure { get ; set ; } 

      /// <summary>
      /// 项目组长意见
      /// </summary>
      [DataMember(Name = "TeamLeaderSuggestion")]
      public string TeamLeaderSuggestion { get ; set ; } 

      /// <summary>
      /// 已提交
      /// </summary>
      [DataMember(Name = "IsSubmited")]
      public bool IsSubmited { get ; set ; } 

      /// <summary>
      /// 录入人
      /// </summary>
      [DataMember(Name = "CreateMan")]
      public string CreateMan { get ; set ; } 

      /// <summary>
      /// 录入时间
      /// </summary>
      [DataMember(Name = "CreateDate")]
      public string CreateDate { get ; set ; } 

      /// <summary>
      /// 修改人
      /// </summary>
      [DataMember(Name = "EditMan")]
      public string EditMan { get ; set ; } 

      /// <summary>
      /// 修改时间
      /// </summary>
      [DataMember(Name = "EditDate")]
      public string EditDate { get ; set ; } 

      /// <summary>
      /// 单据状态ID{$引用基础类别资料，含：已作废、已提交、已审核$}
      /// </summary>
      [DataMember(Name = "tpBillStateId")]
      public int tpBillStateId { get ; set ; } 
    }
}    