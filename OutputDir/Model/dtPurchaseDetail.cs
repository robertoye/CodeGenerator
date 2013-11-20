
/*
 * Created by zhye at 2013-11-20 9:21:51; 
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
    [DataContract(Name = "dtPurchaseDetail")]
    public class dtPurchaseDetail
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 采购主表ID
      /// </summary>
      [DataMember(Name = "dtPurchaseID")]
      public Guid dtPurchaseID { get ; set ; } 

      /// <summary>
      /// 项目任务ID
      /// </summary>
      [DataMember(Name = "dtTaskID")]
      public Guid dtTaskID { get ; set ; } 

      /// <summary>
      /// 品项名称{$系统要求编码必唯一$}
      /// </summary>
      [DataMember(Name = "ItemName")]
      public string ItemName { get ; set ; } 

      /// <summary>
      /// 规格型号
      /// </summary>
      [DataMember(Name = "StandardModel")]
      public string StandardModel { get ; set ; } 

      /// <summary>
      /// 单位{$如果本合同是补充合同，需填写对应的主合同编号$}
      /// </summary>
      [DataMember(Name = "tpUnitID")]
      public int tpUnitID { get ; set ; } 

      /// <summary>
      /// 预算单价
      /// </summary>
      [DataMember(Name = "BudgetPrice")]
      public string BudgetPrice { get ; set ; } 

      /// <summary>
      /// 允超比率{$取得项目申请的允超率$}
      /// </summary>
      [DataMember(Name = "LimitRate")]
      public string LimitRate { get ; set ; } 

      /// <summary>
      /// 供应商报价
      /// </summary>
      [DataMember(Name = "SupplierPrice")]
      public string SupplierPrice { get ; set ; } 

      /// <summary>
      /// 含税单价{$系统默认预算价格，允许用户修改，但不能超出允超比率$}
      /// </summary>
      [DataMember(Name = "TaxPrice")]
      public string TaxPrice { get ; set ; } 

      /// <summary>
      /// 预算数量{$引用基础类别资料，含：设备采购合同、工程合同……$}
      /// </summary>
      [DataMember(Name = "BudgetQuantity")]
      public string BudgetQuantity { get ; set ; } 

      /// <summary>
      /// 累计已购数量
      /// </summary>
      [DataMember(Name = "AccumulateQuantity")]
      public string AccumulateQuantity { get ; set ; } 

      /// <summary>
      /// 采购数量
      /// </summary>
      [DataMember(Name = "Quantity")]
      public string Quantity { get ; set ; } 

      /// <summary>
      /// 已到货确认数量
      /// </summary>
      [DataMember(Name = "ArriveQuantity")]
      public string ArriveQuantity { get ; set ; } 

      /// <summary>
      /// 已安装验收数量
      /// </summary>
      [DataMember(Name = "InstallQuantiry")]
      public string InstallQuantiry { get ; set ; } 

      /// <summary>
      /// 已质保验收数量
      /// </summary>
      [DataMember(Name = "QualityQuantity")]
      public string QualityQuantity { get ; set ; } 

      /// <summary>
      /// 要求到货日期
      /// </summary>
      [DataMember(Name = "RequireArriveDate")]
      public string RequireArriveDate { get ; set ; } 

      /// <summary>
      /// 已结案{$由用户操作，结案后不允许再收货$}
      /// </summary>
      [DataMember(Name = "IsEndCase")]
      public bool IsEndCase { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 
    }
}    