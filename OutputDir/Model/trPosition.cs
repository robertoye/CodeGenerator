
/*
 * Created by zhye at 2013-11-20 9:22:52; 
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
    [DataContract(Name = "trPosition")]
    public class trPosition
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
      /// 位置描述
      /// </summary>
      [DataMember(Name = "PositionDesc")]
      public string PositionDesc { get ; set ; } 

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
      /// 资料有效性
      /// </summary>
      [DataMember(Name = "IsValid")]
      public bool IsValid { get ; set ; } 
    }
}    