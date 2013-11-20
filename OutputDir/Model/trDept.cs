
/*
 * Created by zhye at 2013-11-20 9:22:49; 
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
    [DataContract(Name = "trDept")]
    public class trDept
    {
      /// <summary>
      /// ID
      /// </summary>
      [DataMember(Name = "ID")]
      public int ID { get ; set ; } 

      /// <summary>
      /// 父级ID
      /// </summary>
      [DataMember(Name = "ParentID")]
      public int ParentID { get ; set ; } 

      /// <summary>
      /// 部门名称
      /// </summary>
      [DataMember(Name = "Name")]
      public string Name { get ; set ; } 

      /// <summary>
      /// 层级数
      /// </summary>
      [DataMember(Name = "LevelNum")]
      public int LevelNum { get ; set ; } 

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
    }
}    