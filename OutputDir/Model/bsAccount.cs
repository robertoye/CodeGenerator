
/*
 * Created by zhye at 2013-11-20 9:23:00; 
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
    [DataContract(Name = "bsAccount")]
    public class bsAccount
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public int ID { get ; set ; } 

      /// <summary>
      /// 编码
      /// </summary>
      [DataMember(Name = "Code")]
      public string Code { get ; set ; } 

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
      /// 地址
      /// </summary>
      [DataMember(Name = "Address")]
      public string Address { get ; set ; } 

      /// <summary>
      /// 邮编
      /// </summary>
      [DataMember(Name = "PostCode")]
      public string PostCode { get ; set ; } 

      /// <summary>
      /// 联系人
      /// </summary>
      [DataMember(Name = "Linkman")]
      public string Linkman { get ; set ; } 

      /// <summary>
      /// 联系电话
      /// </summary>
      [DataMember(Name = "Tel")]
      public string Tel { get ; set ; } 

      /// <summary>
      /// 传真号码
      /// </summary>
      [DataMember(Name = "Fax")]
      public string Fax { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 

      /// <summary>
      /// 开户银行
      /// </summary>
      [DataMember(Name = "DepositBank")]
      public string DepositBank { get ; set ; } 

      /// <summary>
      /// 银行账号
      /// </summary>
      [DataMember(Name = "BankAccount")]
      public string BankAccount { get ; set ; } 

      /// <summary>
      /// 纳税号码
      /// </summary>
      [DataMember(Name = "TaxNo")]
      public string TaxNo { get ; set ; } 

      /// <summary>
      /// 付款人
      /// </summary>
      [DataMember(Name = "PayMan")]
      public string PayMan { get ; set ; } 

      /// <summary>
      /// 金蝶编码
      /// </summary>
      [DataMember(Name = "KingDeeCode")]
      public string KingDeeCode { get ; set ; } 

      /// <summary>
      /// 隶属机构ID{$引用基础类别资料，含：总部、阳江、南京、河北$}
      /// </summary>
      [DataMember(Name = "tpOrganID")]
      public int tpOrganID { get ; set ; } 

      /// <summary>
      /// 是否有效
      /// </summary>
      [DataMember(Name = "isValid")]
      public bool isValid { get ; set ; } 
    }
}    