
/*
 * Created by zhye at 2013-11-20 9:22:10; 
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
    [DataContract(Name = "dtWithhold")]
    public class dtWithhold
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
      /// 扣款日期
      /// </summary>
      [DataMember(Name = "WithholdDate")]
      public string WithholdDate { get ; set ; } 

      /// <summary>
      /// 项目ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 采购单ID
      /// </summary>
      [DataMember(Name = "dtPurchaseID")]
      public Guid dtPurchaseID { get ; set ; } 

      /// <summary>
      /// 发票ID
      /// </summary>
      [DataMember(Name = "dtInvoiceID")]
      public Guid dtInvoiceID { get ; set ; } 

      /// <summary>
      /// 扣款类别ID{$引用基础类别资料，如：品质扣款、交期扣款$}
      /// </summary>
      [DataMember(Name = "tpWithholdID")]
      public int tpWithholdID { get ; set ; } 

      /// <summary>
      /// 扣款原因
      /// </summary>
      [DataMember(Name = "WithholdReason")]
      public string WithholdReason { get ; set ; } 

      /// <summary>
      /// 扣款金额
      /// </summary>
      [DataMember(Name = "WithholdAmount")]
      public string WithholdAmount { get ; set ; } 

      /// <summary>
      /// 凭证号
      /// </summary>
      [DataMember(Name = "ProofNo")]
      public string ProofNo { get ; set ; } 

      /// <summary>
      /// 项目编号
      /// </summary>
      [DataMember(Name = "ProjectCode")]
      public string ProjectCode { get ; set ; } 

      /// <summary>
      /// 合同编号
      /// </summary>
      [DataMember(Name = "ContractCode")]
      public string ContractCode { get ; set ; } 

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
      /// 单据状态ID{$引用基础类别资料，如：已提交、已作废、已审核$}
      /// </summary>
      [DataMember(Name = "tpBillStateID")]
      public int tpBillStateID { get ; set ; } 
    }
}    