using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0696464
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestions2();
            //a.playingWithForLoops();

            var b = new birthday_party();
            b.setuppartylist();
            b.printPartyList(head, tail)

        }
    }

    class TestQuestions2

    {
        public int myFavoriteVariable = 0;
        public void playingWithForLoops()
        {
            // write a For Loop to add 10 numbers
            for (; MyMethod();)
            {
                if (myFavoriteVariable > 10)
                {
                    Console.WriteLine("i am out here");
                    break;
                }

                Console.WriteLine("i am in the for loop 10 time");
            }
        }
        public bool MyMethod()
        {
            myFavoriteVariable++;
            return true;
        }
    }

    class dog
    {
        public dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;

        }
        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog previous_dog;
    }
    class Birthday_party
    {
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temporary;

        public void setuppartylist();
        {
        peanut = new dog("Peanut","Bichon");
        fifi = new dog("fifi","poodle");
        clarence = new dog("clarence","german", "sheppard");
        roy = new dog("Roy","Beagle");

        peanut.prev_dog= null;
            peanut.next_dog = fifi;
            fifi.prev_dog = peanut;
            fifi.next_dog = clarence;
            clarence.next_dog =roy;
             clarence.prev_dog = fifi;
            roy.prev_dog = clarence;
            roy.next_dog = null;



    }
    public string printPartyList(dog startOfList, dog endOfList)
    {
        string inviteList = "*--";
        temporary = head;
        while (temporary.next_dog != null)
        {
            inviteList += temporary.dog_name + *---*";
        }
        return inviteList;

    }
}
