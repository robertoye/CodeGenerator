
/*
 * Created by zhye at 2013-11-20 9:21:31; 
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
    [DataContract(Name = "dtProjectAcceptDetail")]
    public class dtProjectAcceptDetail
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 验收主表
      /// </summary>
      [DataMember(Name = "dtProjectAcceptID")]
      public Guid dtProjectAcceptID { get ; set ; } 

      /// <summary>
      /// 项目ID
      /// </summary>
      [DataMember(Name = "dtProjectID")]
      public Guid dtProjectID { get ; set ; } 

      /// <summary>
      /// 合同编号{$允许引用多个合同编号$}
      /// </summary>
      [DataMember(Name = "ContractCode")]
      public string ContractCode { get ; set ; } 

      /// <summary>
      /// 采购单ID
      /// </summary>
      [DataMember(Name = "dtPurchaseID")]
      public int dtPurchaseID { get ; set ; } 

      /// <summary>
      /// 项目验收类型ID{$引用基础类别资料，含：项目验收；合同验收$}
      /// </summary>
      [DataMember(Name = "tpProjectAcceptTypeID")]
      public bool tpProjectAcceptTypeID { get ; set ; } 

      /// <summary>
      /// 合同类别ID{$引用基础类别资料，含：设备采购合同、工程合同……$}
      /// </summary>
      [DataMember(Name = "tpContractTypeID")]
      public int tpContractTypeID { get ; set ; } 

      /// <summary>
      /// 合同金额
      /// </summary>
      [DataMember(Name = "ContractAmount")]
      public string ContractAmount { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 
    }
}    