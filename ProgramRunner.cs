using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class ProgramRunner
    {
        public static void Run(string problemCode)
        {
            try
            {
                string namespaceName = $"LeetCode.Problems.{problemCode}_*"; // wildcard for folder naming
                var assemblies = AppDomain.CurrentDomain.GetAssemblies();

                foreach (var asm in assemblies)
                {
                    foreach (var type in asm.GetTypes())
                    {
                        if (type.Namespace != null &&
                            type.Namespace.StartsWith($"LeetCode.Problems.{problemCode}", StringComparison.OrdinalIgnoreCase) &&
                            type.Name == "Solution")
                        {
                            object instance = Activator.CreateInstance(type);
                            MethodInfo method = type.GetMethod("RunTest");

                            if (method != null)
                            {
                                method.Invoke(instance, null);
                                return;
                            }

                            Console.WriteLine($"Found class but no RunTests() in {type.FullName}");
                            return;
                        }
                    }
                }

                Console.WriteLine($"Problem {problemCode} not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error running problem {problemCode}: {ex.Message}");
            }
        }
    }
}
