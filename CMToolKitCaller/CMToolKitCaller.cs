using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMToolKitCaller
{
    public static class CMToolKitCaller
    {
        static string dllPath = "CMToolKitForBYD.dll";
        static string typeName = "CMToolKitForBYD.CMToolKitForBYD";
        static Assembly assembly =null;
        static Type type =null;

        static public void Init(string strDllPath, string strTypeName)
        {

            dllPath =Application.StartupPath+ @"\"+strDllPath;
            typeName = strTypeName;

            assembly = Assembly.LoadFile(dllPath);
            type = assembly.GetType(typeName);
            FunctionCall("Init", null, null);
        }
        static public object FunctionCall(string Meth, object target, object[] args)
        {
            MethodInfo methodInfo= type.GetMethod(Meth, BindingFlags.Static| BindingFlags.Public);
            if (methodInfo != null)
            {
                return (string)(type.InvokeMember(Meth, BindingFlags.Default | BindingFlags.InvokeMethod, null, target, args));
            }
            else
            {
                MessageBox.Show("没有名字为" + Meth + "方法");
                return null;
            }
            
        }
    }
}
