
/*
 * Created by zhye at 2013-11-20 9:24:11; 
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
    [DataContract(Name = "dtProjectAccept")]
    public class dtProjectAccept
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
      /// 项目ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 隶属账套ID
      /// </summary>
      [DataMember(Name = "bsAccountID")]
      public Guid bsAccountID { get ; set ; } 

      /// <summary>
      /// 项目验收类型ID{$引用基础类别资料，含：项目验收；合同验收$}
      /// </summary>
      [DataMember(Name = "tpProjectAcceptTypeID")]
      public bool tpProjectAcceptTypeID { get ; set ; } 

      /// <summary>
      /// 合同编号{$允许引用多个合同编号$}
      /// </summary>
      [DataMember(Name = "ContractCode")]
      public string ContractCode { get ; set ; } 

      /// <summary>
      /// 基建单位ID{$引用供应商资料中的基建类合作商家$}
      /// </summary>
      [DataMember(Name = "bsSupplierID_Construct")]
      public int bsSupplierID_Construct { get ; set ; } 

      /// <summary>
      /// 安装单位ID{$引用供应商资料中的安装类合作商家$}
      /// </summary>
      [DataMember(Name = "bsSupplierID_Instal")]
      public int bsSupplierID_Instal { get ; set ; } 

      /// <summary>
      /// 生产商家ID{$引用供应商资料中的生产类合作商家$}
      /// </summary>
      [DataMember(Name = "bsSupplierID_Produce")]
      public int bsSupplierID_Produce { get ; set ; } 

      /// <summary>
      /// 初验情况描述
      /// </summary>
      [DataMember(Name = "InitialCheckDesc")]
      public string InitialCheckDesc { get ; set ; } 

      /// <summary>
      /// 实际开工日期
      /// </summary>
      [DataMember(Name = "RealStartWorkDate")]
      public string RealStartWorkDate { get ; set ; } 

      /// <summary>
      /// 实际完工日期
      /// </summary>
      [DataMember(Name = "RealCompleteWorkDate")]
      public string RealCompleteWorkDate { get ; set ; } 

      /// <summary>
      /// 验收日期
      /// </summary>
      [DataMember(Name = "CheckAcceptDate")]
      public string CheckAcceptDate { get ; set ; } 

      /// <summary>
      /// 移交日期
      /// </summary>
      [DataMember(Name = "TransferDate")]
      public string TransferDate { get ; set ; } 

      /// <summary>
      /// 项目预算金额
      /// </summary>
      [DataMember(Name = "ProjectBudgetAmount")]
      public string ProjectBudgetAmount { get ; set ; } 

      /// <summary>
      /// 项目实际使用金额
      /// </summary>
      [DataMember(Name = "ProjectRealUseAmount")]
      public string ProjectRealUseAmount { get ; set ; } 

      /// <summary>
      /// 分项费用构成
      /// </summary>
      [DataMember(Name = "PartItemFeeConstitute")]
      public string PartItemFeeConstitute { get ; set ; } 

      /// <summary>
      /// 工程安装确认
      /// </summary>
      [DataMember(Name = "ProjectInstallConfirm")]
      public string ProjectInstallConfirm { get ; set ; } 

      /// <summary>
      /// 设备系统操作确认
      /// </summary>
      [DataMember(Name = "EquipmentOperateConfirm")]
      public string EquipmentOperateConfirm { get ; set ; } 

      /// <summary>
      /// 验收文件资料
      /// </summary>
      [DataMember(Name = "CheckAcceptFileInfo")]
      public string CheckAcceptFileInfo { get ; set ; } 

      /// <summary>
      /// 验收总结
      /// </summary>
      [DataMember(Name = "CheckAcceptSummary")]
      public string CheckAcceptSummary { get ; set ; } 

      /// <summary>
      /// 项目验收状态ID{$引用基础类别资料，含：已提交、已审批、已作废$}
      /// </summary>
      [DataMember(Name = "tpCheckAcceptStateID")]
      public int tpCheckAcceptStateID { get ; set ; } 

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
    }
}    