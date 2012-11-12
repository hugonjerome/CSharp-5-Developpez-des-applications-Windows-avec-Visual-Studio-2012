using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Détails du type int:");
            int i = 1;
            Type typeInt = i.GetType();
            Console.WriteLine(typeInt.FullName);
            Console.WriteLine(typeInt.Namespace);
            Console.WriteLine(typeInt.Name);

            Console.WriteLine();

            Console.WriteLine("Détails du type string:");
            Type typeString = typeof(string);
            Console.WriteLine(typeString.FullName);
            Console.WriteLine(typeString.Namespace);
            Console.WriteLine(typeString.Name);

            Console.WriteLine();

            Console.WriteLine("Chargement d'un assemblage et énumération de ses types:");
            Assembly assembly = Assembly.LoadFrom(@"..\..\..\OperatorOverloading\bin\Debug\OperatorOverloading.exe");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine(type.FullName);
            }
            Type typeVector = assembly.GetType("OperatorOverloading.Vector");

            Console.WriteLine();

            Console.WriteLine("Enumération des champs du type OperatorOverloading.Vector:");
            FieldInfo[] fields = typeVector.GetFields();
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Enumération des méthodes du type OperatorOverloading.Vector:");
            MethodInfo[] methods = typeVector.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine();

            Console.WriteLine("Création d'une instance d'objet avec Activator.CreateInstance sans paramètres:");
            object o = Activator.CreateInstance(typeVector);
            Console.WriteLine(o);
           
            Console.WriteLine("Création d'une instance d'objet avec Activator.CreateInstance avec paramètres:");
            o = Activator.CreateInstance(typeVector, 8, 9);
            Console.WriteLine(o);
            
            Console.WriteLine("Création d'une instance d'objet avec ConstructorInfo:");
            ConstructorInfo construct = typeVector.GetConstructor(new Type[] { typeof(int), typeof(int) });
            o = construct.Invoke(new object[] { 5, 20 });
            Console.WriteLine(o);

            Console.WriteLine();

            Console.WriteLine("Assignation des champs du type OperatorOverloading.Vector:");
            object o1 = Activator.CreateInstance(typeVector);
            object o2 = Activator.CreateInstance(typeVector);
            FieldInfo fieldX = typeVector.GetField("X");
            fieldX.SetValue(o1, 1);
            fieldX.SetValue(o2, 2);
            FieldInfo fieldY = typeVector.GetField("Y");
            fieldY.SetValue(o1, 3);
            fieldY.SetValue(o2, 10);
            Console.WriteLine("o1: {0}", o1);
            Console.WriteLine("o2: {0}", o2);

            Console.WriteLine();

            Console.WriteLine("Exécution de la méthode Addition:");
            MethodInfo methodAdd = typeVector.GetMethod("Addition");
            o = methodAdd.Invoke(o1, new object[] { o2 });
            Console.WriteLine("o (o1 + o2): {0}", o);

            Console.ReadLine();
        }
    }
}
