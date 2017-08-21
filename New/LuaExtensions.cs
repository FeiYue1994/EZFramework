/*
 * Author:      熊哲
 * CreateTime:  4/1/2017 11:33:11 AM
 * Description:
 * 
*/
using System;
using System.Text;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using XLua;
using Object = UnityEngine.Object;

// 为了降低Lua和框架中其他逻辑的耦合性，部分方法使用扩展方式添加
namespace EZFramework
{
    [LuaCallCSharp]
    public static class LuaExtensions
    {
        public static int GetInt(this EZDatabase instance, string dataName, string key, int value)
        {
            return instance.Get(dataName, key, value);
        }
        public static float GetSingle(this EZDatabase instance, string dataName, string key, float value)
        {
            return instance.Get(dataName, key, value);
        }
        public static double GetDouble(this EZDatabase instance, string dataName, string key, double value)
        {
            return instance.Get(dataName, key, value);
        }
        public static string GetString(this EZDatabase instance, string dataName, string key, string value)
        {
            return instance.Get(dataName, key, value);
        }
        public static bool GetBool(this EZDatabase instance, string dataName, string key, bool value)
        {
            return instance.Get(dataName, key, value);
        }
    }
}