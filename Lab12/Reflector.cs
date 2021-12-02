using System;
using System.Reflection;
using System.Text;
using System.IO;

namespace Lab12
{
    static class Reflector
    {
        static public void AllClassContent(object obj)
        {
            StreamWriter sw = new(@"C:\OOP\Lab5\text.txt", false, System.Text.Encoding.Default);

            MemberInfo[] members = obj.GetType().GetMembers();
            foreach (MemberInfo item in members)
                sw.WriteLine($"{item.DeclaringType} {item.MemberType} {item.Name}");
            sw.Close();
        }


        static public void PublicMethods(object obj)
        {
            MethodInfo[] pubMethods = obj.GetType().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            Console.WriteLine("Только публичные методы: ");
            foreach (MethodInfo item in pubMethods)
                Console.WriteLine(item.ReturnType.Name + " " + item.Name);
        }


        static public void FieldsAndProperties(object obj)
        {
            Console.WriteLine("Поля: ");
            FieldInfo[] fields = obj.GetType().GetFields();

            foreach (FieldInfo item in fields)
                Console.WriteLine(item.FieldType + " " + item.Name);

            Console.WriteLine("Свойства: ");
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo item in properties)
                Console.WriteLine($"{item.PropertyType} {item.Name}");
        }


        static public void Interfaces(object obj)
        {
            Type type = obj.GetType();
            Console.WriteLine("Реализованные интерфейсы: ");
            foreach (Type item in type.GetInterfaces())
                Console.WriteLine(item.Name);
        }

        static public void MethodsWithParams(object obj)
        {
            Console.WriteLine("Введите название типа для параметров: ");
            string findType = Console.ReadLine();

            MethodInfo[] methods = obj.GetType().GetMethods();
            foreach (MethodInfo item in methods)
            {
                ParameterInfo[] p = item.GetParameters();

                foreach (ParameterInfo param in p)
                    if (param.ParameterType.Name == findType)
                        Console.WriteLine("Метод: " + item.ReturnType.Name + " " + item.Name);
            }
        }

        public static void Invoke(string Class, string MethodName)
        {
            StreamReader reader = new(@"C:\OOP\Lab5\text.txt", Encoding.Default);
            string param1, param2, param3;
            param1 = reader.ReadLine();
            param2 = reader.ReadLine();
            param3 = reader.ReadLine();
            reader.Close();
            Console.WriteLine(param1+" "+param2 + " " + param3);
            Type m = Type.GetType(Class, false);

            object st = Activator.CreateInstance(m, null);
            MethodInfo method = m.GetMethod(MethodName);
        }

    }

}
