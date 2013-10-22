/*
 * Created by zhye at 2013-10-22 11:44:44; 
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
    public class ContactCreditCardAdapter    
    {   
        /// <summary>
        /// 获取方法
        /// </summary>
        public list<Model.ContactCreditCard> GetList(string strFilter)
        {
            private _strSelectSql = @"select             
                ContactID,
                CreditCardID,
                ModifiedDate
            from ContactCreditCard";

        }
        /// <summary>
        /// 新增方法
        /// </summary>
        public void Insert(Model.ContactCreditCard entity)
        {
            private _strInsertSql = @"insert into ContactCreditCard(
                ContactID,
                CreditCardID,
                ModifiedDate
)
            values (
                :ContactID,
                :CreditCardID,
                :ModifiedDate
)";
        }
        /// <summary>
        /// 修改方法
        /// </summary>
        public void Update(Model.ContactCreditCard entity)
        {
            private _strUpdateSql = @"Update  ContactCreditCard set
                ContactID = :ContactID, 
                CreditCardID = :CreditCardID, 
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