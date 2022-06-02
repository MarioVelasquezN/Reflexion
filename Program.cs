using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

using System.Linq;
using System.Reflection;

namespace myfirtapp{
    class Program{
        static void Main(string[] args){
            try{
                //Obtenemos el tipo
                Type t= Type.GetType("System.Collection.ArrayList");
                //Type t= Type.GetType("System.Collections");

                //Metodos que buscan la informacion sobre el tipo
                CaracteristicasTipo(t);
                //EncuentraCampos(t);
                //EncuentraPropiedades(t);
                //EncuentraMetodos(t);
                //EncuentraInterfaces(t);

            }catch{
                Console.WriteLine("Verificar el Tipo");
            }
        }

        public static void CaracteristicasTipo(Type t){

            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("Las caracteristicas que tiene son:");
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("Clase base: {0}",t.BaseType);
            Console.WriteLine("Es una clase: {0}",t.IsClass);
            Console.WriteLine("Abstracta: {0}",t.IsAbstract);
            Console.WriteLine("Sellada: {0}",t.IsSealed);
            Console.WriteLine("Generic: {0}",t.IsGenericTypeDefinition);
        }

        public static void EncuentraCampos(Type t){
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("Los campos encontrados son: ");
            Console.ForegroundColor=ConsoleColor.Blue;

            //Encontramos los campos en ese tipo
            var nombres=from f in t.GetFields() select f.Name;
            foreach (var nombre in nombres){
                Console.WriteLine("{0}",nombre);
            }
        }

        public static void EncuentraPropiedades(Type t){
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("Las propiedades encontradas son: ");
            Console.ForegroundColor=ConsoleColor.Blue;

            //Encontrar las propiedades en ese tipo
            var nombres=from p in t.GetProperties() select p.Name;
            foreach(var nombre in nombres){
                Console.WriteLine("{0}",nombre);
            }
        }

        public static void EncuentraMetodos(Type t){
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("Los metodos encontrados son: ");
            Console.ForegroundColor=ConsoleColor.Blue;

            var nombres=from p in t.GetMethods() select p.Name;
            foreach(var nombre in nombres){
                Console.WriteLine("{0}",nombre);
            }
        }

        public static void EncuentraInterfaces(Type t){
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("Las interfaces encontradas son: ");
            Console.ForegroundColor=ConsoleColor.Blue;

            var nombres=from p in t.GetInterfaces() select p.Name;
            foreach(var nombre in nombres){
                Console.WriteLine("{0}",nombre);
            }
        }
    }
}