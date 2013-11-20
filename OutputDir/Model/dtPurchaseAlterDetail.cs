
/*
 * Created by zhye at 2013-11-20 9:21:44; 
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
    [DataContract(Name = "dtPurchaseAlterDetail")]
    public class dtPurchaseAlterDetail
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
      /// 采购品项明细ID
      /// </summary>
      [DataMember(Name = "dtPurchaseDetailID")]
      public Guid dtPurchaseDetailID { get ; set ; } 

      /// <summary>
      /// 项目任务ID
      /// </summary>
      [DataMember(Name = "dtTaskID")]
      public Guid dtTaskID { get ; set ; } 

      /// <summary>
      /// 品项名称
      /// </summary>
      [DataMember(Name = "ItemName")]
      public string ItemName { get ; set ; } 

      /// <summary>
      /// 规格型号
      /// </summary>
      [DataMember(Name = "StandardModel")]
      public string StandardModel { get ; set ; } 

      /// <summary>
      /// 单位
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
      /// 采购单价{$系统默认预算价格，允许用户修改，但不能超出允超比率$}
      /// </summary>
      [DataMember(Name = "TaxPrice")]
      public string TaxPrice { get ; set ; } 

      /// <summary>
      /// 变更后单价{$变更后单价<=采购单价 * (1+允超率)$}
      /// </summary>
      [DataMember(Name = "AlteTaxPrice")]
      public string AlteTaxPrice { get ; set ; } 

      /// <summary>
      /// 计划采购数量
      /// </summary>
      [DataMember(Name = "Quantity")]
      public string Quantity { get ; set ; } 

      /// <summary>
      /// 已到货确认数量
      /// </summary>
      [DataMember(Name = "ArriveQuantity")]
      public string ArriveQuantity { get ; set ; } 

      /// <summary>
      /// 变更后采购数量{$变更后数量>=已到货数量，且不能超出原计划采购数量$}
      /// </summary>
      [DataMember(Name = "AlterQuantity")]
      public string AlterQuantity { get ; set ; } 

      /// <summary>
      /// 要求到货日期
      /// </summary>
      [DataMember(Name = "RequireArriveDate")]
      public string RequireArriveDate { get ; set ; } 

      /// <summary>
      /// 变更后到货日期
      /// </summary>
      [DataMember(Name = "AlterArriveDate")]
      public string AlterArriveDate { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 
    }
}    