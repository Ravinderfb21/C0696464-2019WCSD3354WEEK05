using System;

namespace C0696464
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var b = new birthday_party();
            b.setupPartyList();
            Console.WriteLine(b.printPartyList());
           Console.WriteLine(b.reverseprintPartyList());

        }
    }

    
    class dog
    {
        public dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;
        }

        public dog()
        {
        }

        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog prev_dog;

    }

    class birthday_party
    {
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog giselle;
        public dog lulu;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temporary;

        public void setupPartyList()
        {
            peanut = new dog("Peanut", "Bichon");
            fifi = new dog("Fifi", "Poodle");
            clarence = new dog("Clarence", "German Sheppard");
            giselle = new dog("giselle", "collie");
            lulu = new dog("lulu", "shitzu");
            roy = new dog("Roy", "Beagle");

            peanut.prev_dog = null;
            peanut.next_dog = fifi;
            fifi.prev_dog = peanut;
            fifi.next_dog = clarence;
            clarence.prev_dog = fifi;
            clarence.next_dog = giselle;
            giselle.next_dog = lulu;
            giselle.prev_dog = clarence;
            lulu.next_dog = roy;
            lulu.prev_dog = giselle;

            roy.prev_dog = lulu;
            roy.next_dog = null;
          
            head = peanut;
            tail = roy;
        }

        public string printPartyList()
        {
            string inviteList = "*--";
            temporary = head;
            while (temporary.next_dog != null)
            {
               
                inviteList += temporary.dog_name + " * --- * ";
                temporary = temporary.next_dog;
            }
            inviteList += temporary.dog_name + " * --- * ";
            return inviteList;
        }


        public string reverseprintPartyList()
        {
            string inviteList = "*--";
            temporary = tail;

            while (temporary.prev_dog != null)
            {


                inviteList += temporary.dog_name + " * --- * ";
                
                temporary = temporary.prev_dog;
            }
            inviteList += temporary.dog_name + " * --- * ";
            return inviteList;

        }

    }
}