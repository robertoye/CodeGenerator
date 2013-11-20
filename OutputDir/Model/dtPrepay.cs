
/*
 * Created by zhye at 2013-11-20 9:24:08; 
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
    [DataContract(Name = "dtPrepay")]
    public class dtPrepay
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
      /// 审核日期
      /// </summary>
      [DataMember(Name = "AuditDate")]
      public string AuditDate { get ; set ; } 

      /// <summary>
      /// 支付日期
      /// </summary>
      [DataMember(Name = "PayDate")]
      public string PayDate { get ; set ; } 

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
      [DataMember(Name = "dtPurchaseID")]
      public Guid dtPurchaseID { get ; set ; } 

      /// <summary>
      /// 付款计划ID{$引用采购订单的付款计划ID$}
      /// </summary>
      [DataMember(Name = "dtPurchasePaySchemeID")]
      public Guid dtPurchasePaySchemeID { get ; set ; } 

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
      /// 预付金额
      /// </summary>
      [DataMember(Name = "PrepayAmount")]
      public string PrepayAmount { get ; set ; } 

      /// <summary>
      /// 累计冲销预付额{$收发票时对合同进行预付金额的冲销$}
      /// </summary>
      [DataMember(Name = "ReversePrepayAmount")]
      public string ReversePrepayAmount { get ; set ; } 

      /// <summary>
      /// 款项内容
      /// </summary>
      [DataMember(Name = "FundContent")]
      public string FundContent { get ; set ; } 

      /// <summary>
      /// 付款方式ID{$引用基础类别资料，含：银行转账、电汇、现金……$}
      /// </summary>
      [DataMember(Name = "tpPayModelID")]
      public int tpPayModelID { get ; set ; } 

      /// <summary>
      /// 凭证号
      /// </summary>
      [DataMember(Name = "ProofNo")]
      public string ProofNo { get ; set ; } 

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
      /// 付款单状态ID{$引用基础类别资料，含：已作废、已提交、已打印、已审核、已支付、已生成凭证$}
      /// </summary>
      [DataMember(Name = "tpPayBillStateID")]
      public int tpPayBillStateID { get ; set ; } 
    }
}    