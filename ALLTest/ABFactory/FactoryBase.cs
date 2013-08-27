using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Diagnostics;
using System.Collections;

namespace ABFactory
{
    public class FactoryBase
    {
        #region 委托
        public delegate bool CompareFinal<T>(T result, string match);
        #endregion

        #region 非静态实现
        Assembly assembly;

        public void  InitAssembly(string path)
        {
            assembly = Assembly.LoadFile(path);
        }


        #endregion
        #region 静态方法
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult">特性</typeparam>
        /// <typeparam name="Tinterface">接口</typeparam>
        /// <param name="path">位置</param>
        /// <returns>返回所有实现了的特性</returns>
        public static List<TAttribute> GetAttribute<Tinterface , TAttribute>(string path)
            where TAttribute:Attribute
            where Tinterface:class
        {
            List<TAttribute> result = new List<TAttribute>();
            try
            {
                Assembly Measure = Assembly.LoadFile(path);
                foreach (System.Type tempM in Measure.GetTypes())
                {
                    //
                    try
                    {
                        //否是公开类
                        if (!tempM.IsClass || tempM.IsNotPublic)
                        {
                            continue;
                        }
                        Type[] interfaces = tempM.GetInterfaces();
                        //是否实现接口
                        if (((IList)interfaces).Contains(typeof(Tinterface)))
                        {
                            object[] e = tempM.GetCustomAttributes(true);
                            TAttribute re = e.OfType<TAttribute>().FirstOrDefault();
                            result.Add(re);
                        }
                    }
                    catch (Exception)
                    {
                        Debug.WriteLine("factory异常92");
                        continue;
                    }
                }
                result.RemoveAll(x => x == null);
                return result;
            }
            catch (Exception)
            {
                result.RemoveAll(x => x == null);
                return result;
            }
        }

        /// <summary>
        /// 创建接口实例
        /// </summary>
        /// <typeparam name="TInterface">接口类型</typeparam>
        /// <typeparam name="DelegateT">特性类型</typeparam>
        /// <param name="path">路径</param>
        /// <param name="match">比较字符</param>
        /// <param name="compare">比较器</param>
        /// <returns>返回实例</returns>
        public static TInterface CreateInstance<TInterface, TAttribute>(string path, string match, CompareFinal<TAttribute> compare)
            where TAttribute: Attribute
            where TInterface :class
        {
            TInterface tr = default(TInterface);
            try
            {
                Assembly Measure = Assembly.LoadFile(path);
                foreach (System.Type tempM in Measure.GetTypes())
                {
                    try
                    {//判断是否是公开类
                        if (!tempM.IsClass || tempM.IsNotPublic)
                        {
                            continue;
                        }
                        Type[] interfaces = tempM.GetInterfaces();
                        //是否实现接口
                        if (((IList)interfaces).Contains(typeof(TInterface)))
                        {

                            object[] e = tempM.GetCustomAttributes(true);
                            TAttribute re = e.OfType<TAttribute>().FirstOrDefault();
                            if (compare(re, match))
                            {
                                tr = (TInterface)Activator.CreateInstance(tempM);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Debug.WriteLine("factory异常92");
                        continue;
                    }
                }
                return tr;
            }
            catch (Exception)
            {
                return tr;
            }
        }
        #endregion
    }

}
