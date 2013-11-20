
/*
 * Created by zhye at 2013-11-20 9:23:03; 
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
    [DataContract(Name = "dtEquipAccept")]
    public class dtEquipAccept
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
      /// 隶属项目编号
      /// </summary>
      [DataMember(Name = "ProjectCode")]
      public string ProjectCode { get ; set ; } 

      /// <summary>
      /// 隶属项目名称
      /// </summary>
      [DataMember(Name = "ProjectName")]
      public string ProjectName { get ; set ; } 

      /// <summary>
      /// 采购单ID
      /// </summary>
      [DataMember(Name = "dtPurchaseID")]
      public Guid dtPurchaseID { get ; set ; } 

      /// <summary>
      /// 合同编号
      /// </summary>
      [DataMember(Name = "ContractCode")]
      public string ContractCode { get ; set ; } 

      /// <summary>
      /// 供应商ID
      /// </summary>
      [DataMember(Name = "bsSupplierID")]
      public int bsSupplierID { get ; set ; } 

      /// <summary>
      /// 收货负责人
      /// </summary>
      [DataMember(Name = "ReceiveGoodsMan")]
      public string ReceiveGoodsMan { get ; set ; } 

      /// <summary>
      /// 收货日期
      /// </summary>
      [DataMember(Name = "ReceiveGoodsDate")]
      public string ReceiveGoodsDate { get ; set ; } 

      /// <summary>
      /// 出厂日期
      /// </summary>
      [DataMember(Name = "ManufactureDate")]
      public string ManufactureDate { get ; set ; } 

      /// <summary>
      /// 验收日期
      /// </summary>
      [DataMember(Name = "CheckAcceptDate")]
      public string CheckAcceptDate { get ; set ; } 

      /// <summary>
      /// 收货意见(或说明){$用户填写中文描述$}
      /// </summary>
      [DataMember(Name = "ReceiveSuggest")]
      public string ReceiveSuggest { get ; set ; } 

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