
/*
 * Created by zhye at 2013-11-20 9:21:54; 
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
    [DataContract(Name = "dtPurchasePayScheme")]
    public class dtPurchasePayScheme
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
      /// 付款进度序号
      /// </summary>
      [DataMember(Name = "PayProgressNo")]
      public int PayProgressNo { get ; set ; } 

      /// <summary>
      /// 支付内容描述
      /// </summary>
      [DataMember(Name = "PayContentDesc")]
      public string PayContentDesc { get ; set ; } 

      /// <summary>
      /// 付款比率
      /// </summary>
      [DataMember(Name = "PayRate")]
      public string PayRate { get ; set ; } 

      /// <summary>
      /// 按比率应付金额{$系统按比率默认，禁止用户修改$}
      /// </summary>
      [DataMember(Name = "PayAmountByRate")]
      public string PayAmountByRate { get ; set ; } 

      /// <summary>
      /// 调整后应付金额{$系统按比率默认取整$}
      /// </summary>
      [DataMember(Name = "PayAmountAfterChange")]
      public string PayAmountAfterChange { get ; set ; } 

      /// <summary>
      /// 累计已付金额{$系统自动累计，禁止用户修改$}
      /// </summary>
      [DataMember(Name = "AccumulatePayAmount")]
      public string AccumulatePayAmount { get ; set ; } 

      /// <summary>
      /// 可预付
      /// </summary>
      [DataMember(Name = "IsPrepay")]
      public bool IsPrepay { get ; set ; } 

      /// <summary>
      /// 需到货
      /// </summary>
      [DataMember(Name = "IsNeedArriveGoods")]
      public bool IsNeedArriveGoods { get ; set ; } 

      /// <summary>
      /// 需验收
      /// </summary>
      [DataMember(Name = "IsNeedCheck")]
      public bool IsNeedCheck { get ; set ; } 

      /// <summary>
      /// 需质保
      /// </summary>
      [DataMember(Name = "IsNeedQualityGuarantee")]
      public bool IsNeedQualityGuarantee { get ; set ; } 

      /// <summary>
      /// 需发票
      /// </summary>
      [DataMember(Name = "IsNeedInvoice")]
      public bool IsNeedInvoice { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 
    }
}    