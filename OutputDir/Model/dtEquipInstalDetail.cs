
/*
 * Created by zhye at 2013-11-20 9:23:29; 
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
    [DataContract(Name = "dtEquipInstalDetail")]
    public class dtEquipInstalDetail
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 安装验收单ID
      /// </summary>
      [DataMember(Name = "dtEquipInstalID")]
      public Guid dtEquipInstalID { get ; set ; } 

      /// <summary>
      /// 项目任务明细ID
      /// </summary>
      [DataMember(Name = "dtTaskID")]
      public Guid dtTaskID { get ; set ; } 

      /// <summary>
      /// 采购单明细ID
      /// </summary>
      [DataMember(Name = "dtPurchaseDetailID")]
      public Guid dtPurchaseDetailID { get ; set ; } 

      /// <summary>
      /// 资产编码{$由用户自行录入$}
      /// </summary>
      [DataMember(Name = "AssetCode")]
      public string AssetCode { get ; set ; } 

      /// <summary>
      /// 使用部门ID{$暂不开放使用$}
      /// </summary>
      [DataMember(Name = "trDeptID")]
      public int trDeptID { get ; set ; } 

      /// <summary>
      /// 存放位置ID{$暂不开放使用$}
      /// </summary>
      [DataMember(Name = "trPositionID")]
      public int trPositionID { get ; set ; } 

      /// <summary>
      /// 数量{$默认为：1$}
      /// </summary>
      [DataMember(Name = "Quantity")]
      public decimal Quantity { get ; set ; } 

      /// <summary>
      /// 设备单价{$引用资产资料中的原值数据$}
      /// </summary>
      [DataMember(Name = "DeviceUnitPrice")]
      public decimal DeviceUnitPrice { get ; set ; } 
    }
}    