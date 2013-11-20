
/*
 * Created by zhye at 2013-11-20 9:22:39; 
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
    [DataContract(Name = "dtTaskLog")]
    public class dtTaskLog
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
      /// 填报日期{$项目进度细信息的记录日期，默认当天允许用户修改$}
      /// </summary>
      [DataMember(Name = "BillDate")]
      public string BillDate { get ; set ; } 

      /// <summary>
      /// 立项主表ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 项目任务ID
      /// </summary>
      [DataMember(Name = "dtTaskID")]
      public Guid dtTaskID { get ; set ; } 

      /// <summary>
      /// 原达成比率{$由系统将指定任务引入,禁止用户修改$}
      /// </summary>
      [DataMember(Name = "RawCompleteRate")]
      public string RawCompleteRate { get ; set ; } 

      /// <summary>
      /// 当前达成比率{$默认原达成率，允许用户修改，且不能低于原达成率(投资项同系统自行核算，公式：累计订购数量 / 需求数量 * 100)$}
      /// </summary>
      [DataMember(Name = "NowCompleteRate")]
      public string NowCompleteRate { get ; set ; } 

      /// <summary>
      /// 工作内容
      /// </summary>
      [DataMember(Name = "Content")]
      public string Content { get ; set ; } 

      /// <summary>
      /// 是否投资项{$投资项任务在累计订购数量发生变化时，由系统自动生成任务日志$}
      /// </summary>
      [DataMember(Name = "IsInvest")]
      public bool IsInvest { get ; set ; } 

      /// <summary>
      /// 需求数量{$由系统将指定任务引入,禁止用户修改$}
      /// </summary>
      [DataMember(Name = "Quantity")]
      public string Quantity { get ; set ; } 

      /// <summary>
      /// 累计订购数量{$累计订购数量不能超过需求数量$}
      /// </summary>
      [DataMember(Name = "PurchaseQaulity")]
      public string PurchaseQaulity { get ; set ; } 

      /// <summary>
      /// 计划完成日期{$由系统将指定任务引入,禁止用户修改$}
      /// </summary>
      [DataMember(Name = "PlanCompleteDate")]
      public string PlanCompleteDate { get ; set ; } 

      /// <summary>
      /// 截止日期{$当前任务进度内容的截止日期(投资项由系统填写发生变化的当前日期)$}
      /// </summary>
      [DataMember(Name = "EndDate")]
      public string EndDate { get ; set ; } 

      /// <summary>
      /// 责任人HRID{$由系统将指定任务引入,禁止用户修改$}
      /// </summary>
      [DataMember(Name = "bsEmployeeID")]
      public int bsEmployeeID { get ; set ; } 

      /// <summary>
      /// 参与人{$由系统将指定任务引入,禁止用户修改$}
      /// </summary>
      [DataMember(Name = "AttendMan")]
      public string AttendMan { get ; set ; } 

      /// <summary>
      /// 是否发送邮件知会{$当用户设置需发送知会邮件时，进度内容提交时发送进度信息给责任人$}
      /// </summary>
      [DataMember(Name = "isSendEmaill")]
      public bool isSendEmaill { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 

      /// <summary>
      /// 录入人
      /// </summary>
      [DataMember(Name = "CreateMan")]
      public string CreateMan { get ; set ; } 

      /// <summary>
      /// 录入日期
      /// </summary>
      [DataMember(Name = "CreateDate")]
      public string CreateDate { get ; set ; } 

      /// <summary>
      /// 终审人
      /// </summary>
      [DataMember(Name = "FinalCheckMan")]
      public string FinalCheckMan { get ; set ; } 

      /// <summary>
      /// 终审日期
      /// </summary>
      [DataMember(Name = "FinalCheckDate")]
      public string FinalCheckDate { get ; set ; } 

      /// <summary>
      /// 单据状态ID{$引用基础类别资料，含：已作废、已提交、已审核$}
      /// </summary>
      [DataMember(Name = "tpBillStateID")]
      public int tpBillStateID { get ; set ; } 
    }
}    