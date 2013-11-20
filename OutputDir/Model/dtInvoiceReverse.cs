
/*
 * Created by zhye at 2013-11-20 9:24:00; 
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
    [DataContract(Name = "dtInvoiceReverse")]
    public class dtInvoiceReverse
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 付款单ID
      /// </summary>
      [DataMember(Name = "dtPayID")]
      public Guid dtPayID { get ; set ; } 

      /// <summary>
      /// 发票单ID
      /// </summary>
      [DataMember(Name = "dtInvoiceID")]
      public Guid dtInvoiceID { get ; set ; } 

      /// <summary>
      /// 待支付余额
      /// </summary>
      [DataMember(Name = "ResiduePayAmount")]
      public string ResiduePayAmount { get ; set ; } 

      /// <summary>
      /// 本次支付额
      /// </summary>
      [DataMember(Name = "ThisTimePayAmount")]
      public string ThisTimePayAmount { get ; set ; } 

      /// <summary>
      /// 冲销日期
      /// </summary>
      [DataMember(Name = "ReverseDate")]
      public string ReverseDate { get ; set ; } 
    }
}    