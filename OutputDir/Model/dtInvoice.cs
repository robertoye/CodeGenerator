
/*
 * Created by zhye at 2013-11-20 9:23:56; 
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
    [DataContract(Name = "dtInvoice")]
    public class dtInvoice
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
      /// 开票日期
      /// </summary>
      [DataMember(Name = "BillDate")]
      public string BillDate { get ; set ; } 

      /// <summary>
      /// 入账日期
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
      /// 项目ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 采购单ID
      /// </summary>
      [DataMember(Name = "dtPurChaseID")]
      public Guid dtPurChaseID { get ; set ; } 

      /// <summary>
      /// 供应商ID
      /// </summary>
      [DataMember(Name = "bsSupplierID")]
      public int bsSupplierID { get ; set ; } 

      /// <summary>
      /// 币种ID
      /// </summary>
      [DataMember(Name = "tpCurrencyTypeID")]
      public int tpCurrencyTypeID { get ; set ; } 

      /// <summary>
      /// 税率
      /// </summary>
      [DataMember(Name = "TaxRate")]
      public string TaxRate { get ; set ; } 

      /// <summary>
      /// 含税金额
      /// </summary>
      [DataMember(Name = "TaxAmount")]
      public string TaxAmount { get ; set ; } 

      /// <summary>
      /// 累计冲销预付额
      /// </summary>
      [DataMember(Name = "ReverseAmount")]
      public string ReverseAmount { get ; set ; } 

      /// <summary>
      /// 待审核请款额{$记录未完成支付操作的常规请款总额$}
      /// </summary>
      [DataMember(Name = "AuditAmount")]
      public string AuditAmount { get ; set ; } 

      /// <summary>
      /// 累计已付金额{$已完成支付操作的常规请款总额,增加本列数据时需同时扣减待审核请款额$}
      /// </summary>
      [DataMember(Name = "PayedAmount")]
      public string PayedAmount { get ; set ; } 

      /// <summary>
      /// 发票类别ID{$引用基础类别资料，含：增值税专用发票、普通发票……$}
      /// </summary>
      [DataMember(Name = "tpInvoiceTypeID")]
      public int tpInvoiceTypeID { get ; set ; } 

      /// <summary>
      /// 发票号码
      /// </summary>
      [DataMember(Name = "InvoiceNo")]
      public string InvoiceNo { get ; set ; } 

      /// <summary>
      /// 发票张数
      /// </summary>
      [DataMember(Name = "InvoiceQuantity")]
      public int InvoiceQuantity { get ; set ; } 

      /// <summary>
      /// 凭证号码
      /// </summary>
      [DataMember(Name = "ProofNo")]
      public int ProofNo { get ; set ; } 

      /// <summary>
      /// 项目编号{$冗余字段$}
      /// </summary>
      [DataMember(Name = "ProjectCode")]
      public string ProjectCode { get ; set ; } 

      /// <summary>
      /// 合同编号{$冗余字段$}
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
      /// 单据状态ID{$引用基础类别资料，含：已作废、已提交、已审核$}
      /// </summary>
      [DataMember(Name = "tpBillStateID")]
      public int tpBillStateID { get ; set ; } 
    }
}    