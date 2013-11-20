
/*
 * Created by zhye at 2013-11-20 9:22:31; 
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
    [DataContract(Name = "dtSummary")]
    public class dtSummary
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
      /// 制单日期
      /// </summary>
      [DataMember(Name = "BillDate")]
      public string BillDate { get ; set ; } 

      /// <summary>
      /// 项目ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 隶属账套ID
      /// </summary>
      [DataMember(Name = "bsAccountID")]
      public int bsAccountID { get ; set ; } 

      /// <summary>
      /// 项目编号
      /// </summary>
      [DataMember(Name = "ProjectCode")]
      public string ProjectCode { get ; set ; } 

      /// <summary>
      /// 总结日期
      /// </summary>
      [DataMember(Name = "SummaryDate")]
      public string SummaryDate { get ; set ; } 

      /// <summary>
      /// 总结部门ID
      /// </summary>
      [DataMember(Name = "trDeptID")]
      public int trDeptID { get ; set ; } 

      /// <summary>
      /// 总结人
      /// </summary>
      [DataMember(Name = "SummaryMan")]
      public string SummaryMan { get ; set ; } 

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
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 

      /// <summary>
      /// 单据状态ID{$引用基础类别资料，含：已提交、已审批、已作废$}
      /// </summary>
      [DataMember(Name = "tpBillStateID")]
      public int tpBillStateID { get ; set ; } 
    }
}    