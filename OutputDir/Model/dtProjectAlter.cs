
/*
 * Created by zhye at 2013-11-20 9:22:03; 
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
    [DataContract(Name = "dtProjectAlter")]
    public class dtProjectAlter
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
      /// 项目任务ID
      /// </summary>
      [DataMember(Name = "dtTaskID")]
      public Guid dtTaskID { get ; set ; } 

      /// <summary>
      /// 变更项目{$默认任务ID对应的中文描述,允许用户修改$}
      /// </summary>
      [DataMember(Name = "AlterProject")]
      public string AlterProject { get ; set ; } 

      /// <summary>
      /// 填报日期
      /// </summary>
      [DataMember(Name = "WriteDate")]
      public string WriteDate { get ; set ; } 

      /// <summary>
      /// 变更日期
      /// </summary>
      [DataMember(Name = "AlterDate")]
      public string AlterDate { get ; set ; } 

      /// <summary>
      /// 第N次变更{$记录项目工作目前处第N周的数字$}
      /// </summary>
      [DataMember(Name = "AlterNumber")]
      public int AlterNumber { get ; set ; } 

      /// <summary>
      /// 完成时间
      /// </summary>
      [DataMember(Name = "CompleteDate")]
      public string CompleteDate { get ; set ; } 

      /// <summary>
      /// 需财务确认{$由用户自行判断$}
      /// </summary>
      [DataMember(Name = "IsNeedConfirmByFinance")]
      public bool IsNeedConfirmByFinance { get ; set ; } 

      /// <summary>
      /// 需品管部确认{$由用户自行判断$}
      /// </summary>
      [DataMember(Name = "IsNeedConfirmByQC")]
      public bool IsNeedConfirmByQC { get ; set ; } 

      /// <summary>
      /// 变更依据
      /// </summary>
      [DataMember(Name = "AlterBase")]
      public string AlterBase { get ; set ; } 

      /// <summary>
      /// 历史变更
      /// </summary>
      [DataMember(Name = "AlterHistory")]
      public string AlterHistory { get ; set ; } 

      /// <summary>
      /// 本次变更内容
      /// </summary>
      [DataMember(Name = "AlterContent")]
      public string AlterContent { get ; set ; } 

      /// <summary>
      /// 本次变更原因
      /// </summary>
      [DataMember(Name = "AlterReason")]
      public string AlterReason { get ; set ; } 

      /// <summary>
      /// 项目组意见
      /// </summary>
      [DataMember(Name = "TeamSuggestion")]
      public string TeamSuggestion { get ; set ; } 

      /// <summary>
      /// 原立项预算额
      /// </summary>
      [DataMember(Name = "RawBudgetAmount")]
      public string RawBudgetAmount { get ; set ; } 

      /// <summary>
      /// 累计变更额{$不含本次变更金额$}
      /// </summary>
      [DataMember(Name = "AccumulateAlterAmount")]
      public string AccumulateAlterAmount { get ; set ; } 

      /// <summary>
      /// 本次变更额
      /// </summary>
      [DataMember(Name = "CurrentAlterAmount")]
      public string CurrentAlterAmount { get ; set ; } 

      /// <summary>
      /// 变更后预算额
      /// </summary>
      [DataMember(Name = "AfterAlterBudgetAmount")]
      public string AfterAlterBudgetAmount { get ; set ; } 

      /// <summary>
      /// 最终审批人
      /// </summary>
      [DataMember(Name = "FinalCheckMan")]
      public string FinalCheckMan { get ; set ; } 

      /// <summary>
      /// 单据状态ID{$引用基础类别资料，含：已作废、已提交、已审核$}
      /// </summary>
      [DataMember(Name = "tpBillStateID")]
      public int tpBillStateID { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 

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
    }
}    