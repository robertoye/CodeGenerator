
/*
 * Created by zhye at 2013-11-20 9:22:17; 
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
    [DataContract(Name = "dtPurchase")]
    public class dtPurchase
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
      /// 签约单位
      /// </summary>
      [DataMember(Name = "bsAccountID")]
      public int bsAccountID { get ; set ; } 

      /// <summary>
      /// 立项主表ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 项目编号{$冗余字段$}
      /// </summary>
      [DataMember(Name = "ProjectCode")]
      public string ProjectCode { get ; set ; } 

      /// <summary>
      /// 合同编号{$系统要求编码必唯一$}
      /// </summary>
      [DataMember(Name = "ContractCode")]
      public string ContractCode { get ; set ; } 

      /// <summary>
      /// 合同名称{$由用户录入采购单据对应的合同名称$}
      /// </summary>
      [DataMember(Name = "ContractName")]
      public string ContractName { get ; set ; } 

      /// <summary>
      /// 属补充合同
      /// </summary>
      [DataMember(Name = "IsAttachContract")]
      public bool IsAttachContract { get ; set ; } 

      /// <summary>
      /// 主合同编号{$如果本合同是补充合同，需填写对应的主合同编号$}
      /// </summary>
      [DataMember(Name = "MainContractCode")]
      public string MainContractCode { get ; set ; } 

      /// <summary>
      /// 供应商ID
      /// </summary>
      [DataMember(Name = "bsSupplierID")]
      public int bsSupplierID { get ; set ; } 

      /// <summary>
      /// 合同签订日期{$原SEAM该列在明细表，原因待咨询？$}
      /// </summary>
      [DataMember(Name = "ContractSignDate")]
      public string ContractSignDate { get ; set ; } 

      /// <summary>
      /// 合同类别ID{$引用基础类别资料，含：设备采购合同、工程合同……$}
      /// </summary>
      [DataMember(Name = "tpContractTypeID")]
      public int tpContractTypeID { get ; set ; } 

      /// <summary>
      /// 结算币种ID
      /// </summary>
      [DataMember(Name = "tpCurrencyTypeID")]
      public int tpCurrencyTypeID { get ; set ; } 

      /// <summary>
      /// 税率
      /// </summary>
      [DataMember(Name = "TaxRate")]
      public string TaxRate { get ; set ; } 

      /// <summary>
      /// 发票类别ID{$引用基础类别资料，含：增值税专用发票、普通发票……$}
      /// </summary>
      [DataMember(Name = "tpInvoiceTypeID")]
      public int tpInvoiceTypeID { get ; set ; } 

      /// <summary>
      /// 合同总额
      /// </summary>
      [DataMember(Name = "ContractAmount")]
      public string ContractAmount { get ; set ; } 

      /// <summary>
      /// 累计收发票
      /// </summary>
      [DataMember(Name = "AcceptInvoiceAmount")]
      public string AcceptInvoiceAmount { get ; set ; } 

      /// <summary>
      /// 付款条件ID{$引用基础类别资料，含：工程进度、合同计划$}
      /// </summary>
      [DataMember(Name = "tpPayConditionID")]
      public int tpPayConditionID { get ; set ; } 

      /// <summary>
      /// 延误扣款(元/天)
      /// </summary>
      [DataMember(Name = "LateFeePerDay")]
      public string LateFeePerDay { get ; set ; } 

      /// <summary>
      /// 随货带合格证
      /// </summary>
      [DataMember(Name = "IsHasCertificate")]
      public bool IsHasCertificate { get ; set ; } 

      /// <summary>
      /// 随货带使用说明
      /// </summary>
      [DataMember(Name = "IsHasUserManual")]
      public bool IsHasUserManual { get ; set ; } 

      /// <summary>
      /// 随货带技术图纸
      /// </summary>
      [DataMember(Name = "IsHasTechMapPaper")]
      public bool IsHasTechMapPaper { get ; set ; } 

      /// <summary>
      /// 随货带其它资料
      /// </summary>
      [DataMember(Name = "OtherInfo")]
      public string OtherInfo { get ; set ; } 

      /// <summary>
      /// 品质保证期(月)
      /// </summary>
      [DataMember(Name = "QualityGuaranteePeriod")]
      public int QualityGuaranteePeriod { get ; set ; } 

      /// <summary>
      /// 质保起始日期
      /// </summary>
      [DataMember(Name = "QualityGuaranteeDate")]
      public string QualityGuaranteeDate { get ; set ; } 

      /// <summary>
      /// 验收标准ID{$引用基础类别资料，含：按供方产品标准、按技术协议标准……$}
      /// </summary>
      [DataMember(Name = "tpAcceptStandardID")]
      public int tpAcceptStandardID { get ; set ; } 

      /// <summary>
      /// 不良N日内退货
      /// </summary>
      [DataMember(Name = "AllowReturnDays")]
      public int AllowReturnDays { get ; set ; } 

      /// <summary>
      /// 付款计划{$非进度款，需将付款计划的明细合并，形如：预付款30%;验收款50%……$}
      /// </summary>
      [DataMember(Name = "PayPlan")]
      public string PayPlan { get ; set ; } 

      /// <summary>
      /// 交货方式ID{$引用基础类别资料，含：需方所在地市内、需方所在地县内、送货上门……$}
      /// </summary>
      [DataMember(Name = "tpDeliveryModeID")]
      public int tpDeliveryModeID { get ; set ; } 

      /// <summary>
      /// 运费支付方ID{$引用基础类别资料，含：供方负责、需方负责……$}
      /// </summary>
      [DataMember(Name = "tpFreightPaySideID")]
      public int tpFreightPaySideID { get ; set ; } 

      /// <summary>
      /// 安装调试方ID{$引用基础类别资料，含：供方负责、需方负责……$}
      /// </summary>
      [DataMember(Name = "tpInstaldebugSideID")]
      public int tpInstaldebugSideID { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 

      /// <summary>
      /// 合同单据状态ID{$引用基础类别资料，含：已作废、已提交、已审核、已验收$}
      /// </summary>
      [DataMember(Name = "tpContractBillStateID")]
      public int tpContractBillStateID { get ; set ; } 

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