using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
   // Наследование является базовым принципом ООП и позволяет одному классу (наследнику) унаследовать функционал другого класса (родительского). Нередко отношения наследования еще называют генерализацией или обобщением. Наследование определяет отношение IS A, то есть "является".
        class Person
        { public string FirstName { get; set; }
            public string SecondName { get; set; }
        };
        class Student : Person 
        {
            
        };

        //Ассоциация – это когда один класс включает в себя другой класс в качестве одного из полей. Ассоциация описывается словом «имеет». Автомобиль имеет двигатель.
        class ChatRoom
        {
            public string Name { get; set; }
        }
        class User
        {
            public ChatRoom Active { get; set; }
        }
        
        
        //Выделяют два частных случая ассоциации: композицию и агрегацию
        //Композиция – это когда двигатель не существует отдельно от автомобиля. Он создается при создании автомобиля и полностью управляется автомобилем. В типичном примере, экземпляр двигателя будет создаваться в конструкторе автомобиля

        class Car
        {
            private Engine engine;
            public Car()
            {
                engine = new Engine;
            }
        }

        //Агрегация – это когда экземпляр двигателя создается где-то в другом месте кода, и передается в конструктор автомобиля в качестве параметра.
        class Engine
        {   int power;
            public Engine(int p)
            {
                power = p;
            }
        }
        class Car
        {   string model = "Porshe";
            Engine engine;
            public Car(Engine someEngine)
            {
                this.engine = someEngine;
            }
        }

        //Реализация - один или несколько интерфейсов которые должен реализовівать класс
        interface ICrawlable
        {
            void Crawl();
        }
        class Snail : ICrawlable
        {public int Age { get; set; }
            public void Crawl()
            {
                throw new NotImplementedException();
            }
        }


        //Полиморфизм использует эти методы для выполнения различных задач. Это позволяет нам выполнять одно действие разными способами
        class Animal
        { public void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }
        class Pig : Animal
        {
            public void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        //инкапсуляция - это защитный экран, который предотвращает доступ к данным для кода за пределами этого экрана.
        class Gun
        {
            private bool isLoaded;

            private void  Reload()
            {
                Console.WriteLine("Заряжаю..");
                isLoaded = true;
                Console.WriteLine("Заряжено!");
            }
            public void Shoot()
            {
               if (!isLoaded)
                {
                    Console.WriteLine("Орудие заряжено");
                    Reload();
                }
                Console.WriteLine("Пыщ-пыщ\n");
                isLoaded = false; 
            }

            class Program
            { static void Main(string[] args)
                {
                    Gun gun = new Gun();
                    gun.Shoot();
                }

            }
        }
    

   

    
    }
}
