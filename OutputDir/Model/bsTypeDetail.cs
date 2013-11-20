
/*
 * Created by zhye at 2013-11-20 9:21:27; 
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
    [DataContract(Name = "bsTypeDetail")]
    public class bsTypeDetail
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public int ID { get ; set ; } 

      /// <summary>
      /// 枚举主表ID
      /// </summary>
      [DataMember(Name = "bsTypeID")]
      public int bsTypeID { get ; set ; } 

      /// <summary>
      /// 序号
      /// </summary>
      [DataMember(Name = "SerialNo")]
      public int SerialNo { get ; set ; } 

      /// <summary>
      /// 名称
      /// </summary>
      [DataMember(Name = "Name")]
      public string Name { get ; set ; } 

      /// <summary>
      /// 默认值
      /// </summary>
      [DataMember(Name = "DeafultValue")]
      public string DeafultValue { get ; set ; } 

      /// <summary>
      /// 表示符
      /// </summary>
      [DataMember(Name = "Emblem")]
      public string Emblem { get ; set ; } 

      /// <summary>
      /// 简要注释
      /// </summary>
      [DataMember(Name = "Remark")]
      public string Remark { get ; set ; } 

      /// <summary>
      /// 有效
      /// </summary>
      [DataMember(Name = "IsValid")]
      public bool IsValid { get ; set ; } 
    }
}    