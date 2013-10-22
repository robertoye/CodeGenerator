/*
 * Created by zhye at 2013-10-22 11:44:49; 
 *
 *
 *
 *
 *
 * Copyright:Team
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Model;

namespace DAL
{
    public class ContactTypeAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.ContactType> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ContactTypeID,
                Name,
                ModifiedDate
            from ContactType";

        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public void Insert(Model.ContactType entity)
        {
            private _strInsertSql = @"insert into ContactType(
                ContactTypeID,
                Name,
                ModifiedDate
)
            values (
                :ContactTypeID,
                :Name,
                :ModifiedDate
)";
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.ContactType entity)
        {
            private _strUpdateSql = @"Update  ContactType set
                ContactTypeID = :ContactTypeID, 
                Name = :Name, 
                ModifiedDate = :ModifiedDate 
            where Id=:Id";
        }
        /// <summary>
        /// 删除方法
        /// </summary>
        public void Delete(int Id)
        {
            private _strDeleteSql = @"";
        }
    }
}    