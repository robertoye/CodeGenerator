
/*
 * Created by zhye at 2013-11-20 9:23:40; 
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
    [DataContract(Name = "dtEquipQuality")]
    public class dtEquipQuality
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
      /// 单据业务类别ID{$引用单据类别资料含：合同质保期使用情况确认书、合同质保金支付确认表$}
      /// </summary>
      [DataMember(Name = "bsBillTypeID")]
      public int bsBillTypeID { get ; set ; } 

      /// <summary>
      /// 制单日期
      /// </summary>
      [DataMember(Name = "BillDate")]
      public string BillDate { get ; set ; } 

      /// <summary>
      /// 审核日期
      /// </summary>
      [DataMember(Name = "AuditDate")]
      public string AuditDate { get ; set ; } 

      /// <summary>
      /// 隶属账套ID
      /// </summary>
      [DataMember(Name = "bsAccountID")]
      public int bsAccountID { get ; set ; } 

      /// <summary>
      /// 申请部门ID
      /// </summary>
      [DataMember(Name = "trDeptID")]
      public int trDeptID { get ; set ; } 

      /// <summary>
      /// 使用部门ID
      /// </summary>
      [DataMember(Name = "trDeptID_Usage")]
      public int trDeptID_Usage { get ; set ; } 

      /// <summary>
      /// 项目ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 采购ID
      /// </summary>
      [DataMember(Name = "dtPurchaseID")]
      public Guid dtPurchaseID { get ; set ; } 

      /// <summary>
      /// 项目编号{$冗余字段，方便查询统计$}
      /// </summary>
      [DataMember(Name = "ProjectCode")]
      public string ProjectCode { get ; set ; } 

      /// <summary>
      /// 合同编号{$冗余字段，方便查询统计$}
      /// </summary>
      [DataMember(Name = "ContractCode")]
      public string ContractCode { get ; set ; } 

      /// <summary>
      /// 供应商ID
      /// </summary>
      [DataMember(Name = "bsSupplierID")]
      public int bsSupplierID { get ; set ; } 

      /// <summary>
      /// 质保期限{$自    年   月   日--    年   月   日$}
      /// </summary>
      [DataMember(Name = "QualityPeriod")]
      public string QualityPeriod { get ; set ; } 

      /// <summary>
      /// 使用部门意见{$如使用部门同为主导部门,则不填写此栏$}
      /// </summary>
      [DataMember(Name = "UsageDeptSuggest")]
      public string UsageDeptSuggest { get ; set ; } 

      /// <summary>
      /// 工程部意见{$如使用部门同为工程部、主导部门,则不填写此栏$}
      /// </summary>
      [DataMember(Name = "EngineeringDeptSuggest")]
      public string EngineeringDeptSuggest { get ; set ; } 

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
      /// 单据状态ID{$引用基础类别资料，含：已作废、已提交、已审核$}
      /// </summary>
      [DataMember(Name = "tpBillStateID")]
      public int tpBillStateID { get ; set ; } 

      /// <summary>
      /// 是否有应扣款项{$水电费、罚款等扣款项及额度，财务填写$}
      /// </summary>
      [DataMember(Name = "WithholdItem")]
      public string WithholdItem { get ; set ; } 

      /// <summary>
      /// 是否同意支付{$基地总经理意见$}
      /// </summary>
      [DataMember(Name = "Suggest")]
      public string Suggest { get ; set ; } 
    }
}    