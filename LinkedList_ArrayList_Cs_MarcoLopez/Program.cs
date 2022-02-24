using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace LinkedList_ArrayList_Cs_MarcoLopez.LinkedList
{
    public class main 
    {
        public static void Main(string[] args)
        {
            LinkedList1 team1 = new LinkedList1();
            LinkedList1 team2 = new LinkedList1();
            LinkedList1 team3 = new LinkedList1();

            team1.addAtTail("Jesús");
            team1.addAtTail("Salomón");
            team1.addAtTail("Yael");

            team2.addAtFront("Cristian");
            team2.addAtFront("Daniel");
            team2.addAtFront("Diego");

            team3.addAtFront("Imelda");

            LinkedListIterator iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            { //Mientras siga la lista
                string name = iterator.next();
                Console.WriteLine(name);
            }

            Console.WriteLine("\n");
            // Debió haber impreso
            // Jesús
            // Salomón
            // Yael

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

            Console.WriteLine("\n");
            // Debió haber impreso
            // Diego
            // Daniel
            // Rita

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
    }*/

      //Main para ArrayList
namespace LinkedList_ArrayList_Cs_MarcoLopez.ArrayList
{
    public class main 
    {
        public static void Main(string[] args)
        {
            ArrayList1 team1 = new ArrayList1();
            ArrayList1 team2 = new ArrayList1();
            ArrayList1 team3 = new ArrayList1();

            team1.addAtTail("Jesús");
            team1.addAtTail("Salomón");
            team1.addAtTail("Yael");

            team2.addAtFront("Cristian");
            team2.addAtFront("Daniel");
            team2.addAtFront("Diego");

            team3.addAtFront("Imelda");

            ArrayListIterator iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())
            { //Mientras siga la lista
                string name = iterator.next();
                Console.WriteLine(name);
            }

            Console.WriteLine("\n");
            // Debió haber impreso
            // Jesús
            // Salomón
            // Yael

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
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

            Console.WriteLine("\n");
            // Debió haber impreso
            // Diego
            // Daniel
            // Rita

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
