using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;

            Type type = i.GetType();
            Assembly info = typeof(int).Assembly;

            Assembly assinfo = Assembly.LoadFile(@"C:\Users\user\Desktop\AssetAllocationClient.dll");

            Type[] types = assinfo.GetTypes();

            foreach (Type tc in types)
            {
                Console.WriteLine("ClassName:"+ tc.Name);

                //Get List of Method Names of Class

                MemberInfo[] methodName = tc.GetMethods();

                foreach (MemberInfo method in methodName)
                {
                    if (method.ReflectedType.IsPublic)
                    {
                        Console.WriteLine("Public Method : " + method.Name.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Non-Public Method : " + method.Name.ToString());
                    }

                    foreach(ParameterInfo parameterName in ((MethodInfo) method).GetParameters() )
                    {
                        Console.WriteLine("Type={0}, Name={1}", method.DeclaringType, method.Name);
                    }
                }
            }

            //Console.WriteLine(assinfo.CodeBase);

            //Console.WriteLine(assinfo.CustomAttributes);
            //Console.WriteLine(assinfo.DefinedTypes);
            //Console.WriteLine(assinfo.EntryPoint);

            //Console.WriteLine(assinfo.EscapedCodeBase);
            //Console.WriteLine(assinfo.Evidence);
            //Console.WriteLine(assinfo.ExportedTypes);
            //Console.WriteLine(assinfo.FullName);

            //Console.WriteLine(assinfo.Location);
            //Console.WriteLine(assinfo.SecurityRuleSet);
            //Console.WriteLine(assinfo.ReflectionOnly);
            //Console.WriteLine(assinfo.PermissionSet);
            //Console.WriteLine(assinfo.Modules);
            //Console.WriteLine(assinfo.ManifestModule);


            //Console.WriteLine(type);
            //Console.WriteLine(info);
            Console.ReadLine();



        }
    }
}
