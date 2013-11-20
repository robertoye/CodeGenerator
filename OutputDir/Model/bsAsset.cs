
/*
 * Created by zhye at 2013-11-20 9:22:42; 
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
    [DataContract(Name = "bsAsset")]
    public class bsAsset
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 隶属账套ID
      /// </summary>
      [DataMember(Name = "bsAccountId")]
      public int bsAccountId { get ; set ; } 

      /// <summary>
      /// 设备编码
      /// </summary>
      [DataMember(Name = "Code")]
      public string Code { get ; set ; } 

      /// <summary>
      /// 资产编码
      /// </summary>
      [DataMember(Name = "AssetCode")]
      public string AssetCode { get ; set ; } 

      /// <summary>
      /// 全称
      /// </summary>
      [DataMember(Name = "Name")]
      public string Name { get ; set ; } 

      /// <summary>
      /// 简称
      /// </summary>
      [DataMember(Name = "ShortName")]
      public string ShortName { get ; set ; } 

      /// <summary>
      /// 规格
      /// </summary>
      [DataMember(Name = "Standard")]
      public string Standard { get ; set ; } 

      /// <summary>
      /// 型号
      /// </summary>
      [DataMember(Name = "Model")]
      public string Model { get ; set ; } 

      /// <summary>
      /// 主机编号
      /// </summary>
      [DataMember(Name = "MainCode")]
      public string MainCode { get ; set ; } 

      /// <summary>
      /// 资产管理类别ID{$设备管理部门对资产进行的类别设置。$}
      /// </summary>
      [DataMember(Name = "tpAssetManageTypeID")]
      public int tpAssetManageTypeID { get ; set ; } 

      /// <summary>
      /// 资产财务类别ID{$财务部门对资产进行的类别设置。$}
      /// </summary>
      [DataMember(Name = "tpAssetFinanceID")]
      public int tpAssetFinanceID { get ; set ; } 

      /// <summary>
      /// 资产状态ID{$引用基础类别资料，如：未验收、未质保、已报废、已清理$}
      /// </summary>
      [DataMember(Name = "tpAssetStateID")]
      public int tpAssetStateID { get ; set ; } 

      /// <summary>
      /// 地理位置ID{$树结构$}
      /// </summary>
      [DataMember(Name = "trPositionID")]
      public int trPositionID { get ; set ; } 

      /// <summary>
      /// 使用部门ID{$树结构$}
      /// </summary>
      [DataMember(Name = "trDeptID")]
      public int trDeptID { get ; set ; } 

      /// <summary>
      /// 安装日期
      /// </summary>
      [DataMember(Name = "InstalDate")]
      public string InstalDate { get ; set ; } 

      /// <summary>
      /// 资产原值
      /// </summary>
      [DataMember(Name = "AssetRawWorth")]
      public string AssetRawWorth { get ; set ; } 

      /// <summary>
      /// 录入人
      /// </summary>
      [DataMember(Name = "CreateMan")]
      public string CreateMan { get ; set ; } 

      /// <summary>
      /// 录入日期
      /// </summary>
      [DataMember(Name = "CreateDate")]
      public string CreateDate { get ; set ; } 

      /// <summary>
      /// 修改人
      /// </summary>
      [DataMember(Name = "EditMan")]
      public string EditMan { get ; set ; } 

      /// <summary>
      /// 修改日期
      /// </summary>
      [DataMember(Name = "EditDate")]
      public string EditDate { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 

      /// <summary>
      /// 供应商ID
      /// </summary>
      [DataMember(Name = "bsSupplierId")]
      public int bsSupplierId { get ; set ; } 

      /// <summary>
      /// 合同编号
      /// </summary>
      [DataMember(Name = "ContractCode")]
      public string ContractCode { get ; set ; } 

      /// <summary>
      /// 项目编号
      /// </summary>
      [DataMember(Name = "ProjectCode")]
      public string ProjectCode { get ; set ; } 

      /// <summary>
      /// 资产OA类别ID{$引用基础类别资料，如：生产设备(含基地运输设备)、IT设备、办公设备(含总部运输设备/基地食堂设备)、检测及试验仪器设备$}
      /// </summary>
      [DataMember(Name = "tpAssetOATypeID")]
      public int tpAssetOATypeID { get ; set ; } 

      /// <summary>
      /// 是否有效
      /// </summary>
      [DataMember(Name = "isValid")]
      public bool isValid { get ; set ; } 
    }
}    