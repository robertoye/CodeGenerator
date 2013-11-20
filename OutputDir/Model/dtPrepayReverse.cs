
/*
 * Created by zhye at 2013-11-20 9:24:15; 
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
    [DataContract(Name = "dtPrepayReverse")]
    public class dtPrepayReverse
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public Guid ID { get ; set ; } 

      /// <summary>
      /// 预付单ID
      /// </summary>
      [DataMember(Name = "dtPrepayID")]
      public Guid dtPrepayID { get ; set ; } 

      /// <summary>
      /// 发票单ID
      /// </summary>
      [DataMember(Name = "dtInvoiceID")]
      public Guid dtInvoiceID { get ; set ; } 

      /// <summary>
      /// 待核销余额
      /// </summary>
      [DataMember(Name = "ResidueAmount")]
      public string ResidueAmount { get ; set ; } 

      /// <summary>
      /// 本次核销额
      /// </summary>
      [DataMember(Name = "ThisTimeAmout")]
      public string ThisTimeAmout { get ; set ; } 

      /// <summary>
      /// 核销日期
      /// </summary>
      [DataMember(Name = "CheckoutDate")]
      public string CheckoutDate { get ; set ; } 
    }
}    