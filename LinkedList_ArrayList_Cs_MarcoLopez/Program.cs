using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace LinkedList_ArrayList_Cs_MarcoLopez.LinkedList;

namespace LinkedList_ArrayList_Cs_MarcoLopez.LinkedList_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tPRUEBA ARRAYLIST");
            metodo(new ArrayList1<string>(), new ArrayList1<string>(), new ArrayList1<string>()); //Al llamado del método se le llama firma
            Console.WriteLine("\n\tPRUEBA LINKEDLIST");
            metodo(new LinkedList1<string>(), new LinkedList1<string>(), new LinkedList1<string>());
        }



        public static void metodo(List<string> team1, List<string> team2, List<string> team3)
        {
            //List<Alumno> doubles = new ArrayList<>(); //ahora se pueden crear listas de cualquier tipo, esto hace el generics

            //No se puede crear una instancia de List, List list1=new List(); no se puede ya que la interfaz solo tiene métodos abstractos

            team1.addAtTail("Jesús");
            team1.addAtTail("Salomón");
            team1.addAtTail("Yael");

            team2.addAtFront("Cristian");
            team2.addAtFront("Daniel");
            team2.addAtFront("Diego");

            team3.addAtFront("Imelda");

            Iterator<string> iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next(); //Aqui saláa un error que regresaba un object, esto pasa porque estaba usando el Iterador sin decirle de qué tipo era, es decir, en Iterator<String> iterator;.. solo tenía Iterator iterator;
                Console.WriteLine(name);
            }

            //Debió haber impreso
            //Jesus
            //Salomón
            //Yael

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            Console.WriteLine("\n");
            // Debió haber impreso
            // Diego
            // Daniel
            // Cristian

            team1.remove(0);
            team1.addAtFront("Rebeca");
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            Console.WriteLine("\n");
            // Debió haber impreso
            // Rebeca
            // Salomón
            // Yael

            team2.remove(2);
            team2.addAtTail("Rita");
            Console.WriteLine("Team 2 tiene: " + team2.getSize() + " integrantes"); // debe imprimir "Team 2 tiene 3 integrantes"

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            //Debió haber impreso
            //Diego
            //Daniel
            //Rita

            team3.remove(0);
            team3.remove(0); // El elemento no existe pero el programa no debe cerrarse por algún error

            team3.addAtTail("Tadeo");
            team3.addAtFront("Isai");

            Console.WriteLine("Team 3 tiene: " + team3.getSize() + " integrantes"); // debe imprimir "Team 3 tiene 2 integrantes"

            iterator = team3.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            Console.WriteLine("\n");
            // Debió haber impreso
            // Tadeo
            // Isai

            if (team1.getAt(1).Equals("Salomón"))
            {
                team1.setAt(1, "Luis");
            }

            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                string name = iterator.next();
                Console.WriteLine(name);
            }

            Console.WriteLine("\n");
            // Debió haber impreso
            // Rebeca
            // Luis
            // Yael


        }
    }
}