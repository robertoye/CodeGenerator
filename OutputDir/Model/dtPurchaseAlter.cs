
/*
 * Created by zhye at 2013-11-20 9:21:41; 
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
    [DataContract(Name = "dtPurchaseAlter")]
    public class dtPurchaseAlter
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
      /// 隶属账套ID
      /// </summary>
      [DataMember(Name = "bsAccountID")]
      public Guid bsAccountID { get ; set ; } 

      /// <summary>
      /// 原采购单ID
      /// </summary>
      [DataMember(Name = "dtPurchaseID")]
      public Guid dtPurchaseID { get ; set ; } 

      /// <summary>
      /// 供应商ID
      /// </summary>
      [DataMember(Name = "bsSupplierID")]
      public int bsSupplierID { get ; set ; } 

      /// <summary>
      /// 变更日期
      /// </summary>
      [DataMember(Name = "AlterDate")]
      public string AlterDate { get ; set ; } 

      /// <summary>
      /// 变更总额
      /// </summary>
      [DataMember(Name = "AlterAmount")]
      public string AlterAmount { get ; set ; } 

      /// <summary>
      /// 付款条件ID{$引用基础类别资料，含：工程进度、合同计划$}
      /// </summary>
      [DataMember(Name = "tpPayConditionID")]
      public int tpPayConditionID { get ; set ; } 

      /// <summary>
      /// 变更原因
      /// </summary>
      [DataMember(Name = "AlterReason")]
      public string AlterReason { get ; set ; } 

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