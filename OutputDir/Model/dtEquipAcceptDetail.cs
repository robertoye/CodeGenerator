
/*
 * Created by zhye at 2013-11-20 9:23:09; 
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
    [DataContract(Name = "dtEquipAcceptDetail")]
    public class dtEquipAcceptDetail
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 到货确认主表ID
      /// </summary>
      [DataMember(Name = "dtEquipAcceptID")]
      public Guid dtEquipAcceptID { get ; set ; } 

      /// <summary>
      /// 采购单明细ID
      /// </summary>
      [DataMember(Name = "dtPurchaseDetailID")]
      public Guid dtPurchaseDetailID { get ; set ; } 

      /// <summary>
      /// 资产编码
      /// </summary>
      [DataMember(Name = "AssetCode")]
      public string AssetCode { get ; set ; } 

      /// <summary>
      /// 品项名称
      /// </summary>
      [DataMember(Name = "ItemName")]
      public string ItemName { get ; set ; } 

      /// <summary>
      /// 设备品牌
      /// </summary>
      [DataMember(Name = "Brand")]
      public string Brand { get ; set ; } 

      /// <summary>
      /// 规格型号
      /// </summary>
      [DataMember(Name = "StandardModel")]
      public string StandardModel { get ; set ; } 

      /// <summary>
      /// 技术要求/参数
      /// </summary>
      [DataMember(Name = "TechniqueParm")]
      public string TechniqueParm { get ; set ; } 

      /// <summary>
      /// 主机编号
      /// </summary>
      [DataMember(Name = "HostCode")]
      public string HostCode { get ; set ; } 

      /// <summary>
      /// 单位
      /// </summary>
      [DataMember(Name = "tpUnitID")]
      public int tpUnitID { get ; set ; } 

      /// <summary>
      /// 数量
      /// </summary>
      [DataMember(Name = "Quantity")]
      public decimal Quantity { get ; set ; } 

      /// <summary>
      /// 税率
      /// </summary>
      [DataMember(Name = "TaxRate")]
      public decimal TaxRate { get ; set ; } 

      /// <summary>
      /// 含税单价
      /// </summary>
      [DataMember(Name = "ContainTaxUnitPrice")]
      public decimal ContainTaxUnitPrice { get ; set ; } 

      /// <summary>
      /// 使用部门ID{$由用户选择SEAM系统部门资料$}
      /// </summary>
      [DataMember(Name = "trDeptID")]
      public int trDeptID { get ; set ; } 

      /// <summary>
      /// 存放位置ID{$引用位置表资料$}
      /// </summary>
      [DataMember(Name = "trPositionID")]
      public int trPositionID { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 
    }
}    