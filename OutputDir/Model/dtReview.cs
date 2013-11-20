
/*
 * Created by zhye at 2013-11-20 9:22:13; 
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
    [DataContract(Name = "dtReview")]
    public class dtReview
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
      /// 主导部门ID
      /// </summary>
      [DataMember(Name = "trDeptID")]
      public int trDeptID { get ; set ; } 

      /// <summary>
      /// 验收批准日期
      /// </summary>
      [DataMember(Name = "AcceptPermitDate")]
      public string AcceptPermitDate { get ; set ; } 

      /// <summary>
      /// 回访日期
      /// </summary>
      [DataMember(Name = "ReviewDate")]
      public string ReviewDate { get ; set ; } 

      /// <summary>
      /// 供应单位{$由用户自行填写，委外填写供应商名称，自制填写主导部门名称$}
      /// </summary>
      [DataMember(Name = "SupplyOrgan")]
      public string SupplyOrgan { get ; set ; } 

      /// <summary>
      /// 项目组长
      /// </summary>
      [DataMember(Name = "TeamLeader")]
      public string TeamLeader { get ; set ; } 

      /// <summary>
      /// 使用部门意见
      /// </summary>
      [DataMember(Name = "DepartSuggest")]
      public string DepartSuggest { get ; set ; } 

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
      /// 单据状态ID{$引用基础类别资料，含：已作废、已提交、已审核$}
      /// </summary>
      [DataMember(Name = "tpBillStateID")]
      public int tpBillStateID { get ; set ; } 
    }
}    