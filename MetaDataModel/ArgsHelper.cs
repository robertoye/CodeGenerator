using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CodeGenerator.MetadataModel
{
    public class ArgsHelper
    {
        private static Hashtable _args;

        public string Creator
        {
            get
            {
                string c = GetArg("c");
                return string.IsNullOrEmpty(c) ? "zhye" : c;
            }
        }

        public string CopyrightTeamName
        {
            get
            {
                string t = GetArg("t");
                return string.IsNullOrEmpty(t) ? "zhye" : t;
            }
        }

        public string TableName
        {
            get
            {
                return GetArg("tn");
            }
        }

        public string TableModifyBefore
        {
            get
            {
                return GetArg("bt");
            }
        }

        public string TableModifyAfter
        {
            get
            {
                return GetArg("at");
            }
        }

        public ArgsHelper(string[] args)
        {
            string argsRange = ",c,t,tn,bt,at,";
            /*
             *  c 创建者
             *  t 工作组名,copyright用
             *  tn 表名
             *  bt 表创建时间在某时间之前
             *  at 表创建日期在某时间之后
             */ 

            _args = new Hashtable();
            try
            {
                foreach (string s in args)
                {
                    string[] pair = s.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                    if (pair.Length > 1)
                    {
                        string pname = pair[0];
                        if (argsRange.IndexOf(pname, 0) < 0)
                        {
                            throw new Exception(string.Format("参数名{0}不是合法参数!", pname));
                        }
                        _args.Add(pair[0], pair[1]);
                    }
                    else
                    {
                        _args.Add(pair[0], "");
                    }
                }
            }
            catch (Exception err)
            {
                System.Console.WriteLine(string.Format("命令行参数列表错误：{0}",err.Message));
                System.Console.WriteLine("合法的参数如下：");
                System.Console.WriteLine("  c：代码创建人，如c=zhye}");
                System.Console.WriteLine("  t：工作组名称，如t=strong");
                System.Console.WriteLine("  tn：表名称，如t=* t=tablename");
                System.Console.WriteLine("  at：表创建时间在参数值之后，如at=2013-1-1");
                System.Console.WriteLine("  bt：表创建时间在参数值之前，如bt=2013-1-1");
            }
        }

        public bool SingleExists(string argName)
        {
            return _args.ContainsKey(argName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argName"></param>
        /// <returns></returns>
        private string GetArg(string argName)
        {
            string result = "";

            foreach (System.Collections.DictionaryEntry obj in _args)
            {
                if(obj.Key.ToString() == argName)
                {
                    result = obj.Value.ToString();
                }
            }

            return result;
        }
    }
}
