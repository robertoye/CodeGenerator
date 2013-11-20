
/*
 * Created by zhye at 2013-11-20 9:22:28; 
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
    [DataContract(Name = "bsBillType")]
    public class bsBillType
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public int ID { get ; set ; } 

      /// <summary>
      /// 业务名称{$标识不同的业务类别名称$}
      /// </summary>
      [DataMember(Name = "Name")]
      public string Name { get ; set ; } 

      /// <summary>
      /// 数据库表名称{$列字段名：TableName$}
      /// </summary>
      [DataMember(Name = "TableName")]
      public string TableName { get ; set ; } 

      /// <summary>
      /// 编号前缀
      /// </summary>
      [DataMember(Name = "CodePrefix")]
      public string CodePrefix { get ; set ; } 
    }
}    