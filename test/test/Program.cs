using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    //create class 
    class Bird

    {
       
        string name, species, sex, weight, bandno;
        // getter setter:
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Species
        {
            get { return species; }
            set { species = value; }

        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }

        }
        public string Weight
        {
            get { return weight; }
            set { weight = value; }

        }
        public string Bandno
        {
            get { return bandno; }
            set { bandno = value; }

        }
        //method to display data:
        public Bird(string _name, string _species, string _sex, string _weight, string _bandno)
        {
            Name = _name;
            Species = _species;
            Sex = _sex;
            Weight = _weight;
            Bandno = _bandno;
        }

        public string Birddata()
        {
            return "Bird name=" + Name;

        }
        public string Birdspecies()
        {
            return "Species=" + Species;

        }
        public string Birdsex()
        {
            return "Sex" + Sex;

        }
        public string Birdweight()
        {
            return "Weight=" + weight;

        }
        public string BirdBandno()
        {
            return "Band number=" + bandno;

        }


    }
    class program
    { 
    static void Main(string[] args)
        {
            Console.WriteLine("Bird object created and default data loaded.......");
            //
           
         
            Console.WriteLine("PLEASE UPDATE BIRD DATA");

            // update data from user
            Console.WriteLine("enter the Bird name:");
            string BirdType = Console.ReadLine();

            Console.WriteLine("enter Species:");
            string Species = Console.ReadLine();

            Console.WriteLine("enter the Sex of Bird:");
            string Sex = Console.ReadLine();

            Console.WriteLine("enter the Weight of Bird:");
            string Weight = Console.ReadLine();

            Console.WriteLine("enter the BandNumber of Bird ");
            string Bandno = Console.ReadLine();

            Console.WriteLine("******************************************");
            
            // show data which we collect from user:
            Bird first = new Bird(BirdType, Species,Sex, Weight, Bandno);

            Console.WriteLine(first.Birddata());

            Console.WriteLine(first.Birdspecies());

            Console.WriteLine(first.Birdsex());

            Console.WriteLine(first.Birdweight());

            Console.WriteLine(first.BirdBandno());

            Console.WriteLine("*******************************************");

            Console.ReadLine();
        }
    }
}
