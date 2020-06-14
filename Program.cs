using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;

namespace OptimalRouteApp
{
    class Program
    {
        static void Main(string[] args)
        {       
            ListAttractions();
            Console.WriteLine();
        }

        private static void ListAttractions()
        {
            var attractions = new List<Attraction>
            {      
                { new Attraction() { AttractionName = "St. Isaac's Cathedral", VisitingTime = 5, Importance = 10}},       
                { new Attraction() { AttractionName = "The Hermitage", VisitingTime = 8, Importance = 11}},       
                { new Attraction() { AttractionName = "Kunstkamera", VisitingTime = 3.5, Importance = 4}},       
                { new Attraction() { AttractionName = "Peter and Paul Fortress", VisitingTime = 10, Importance = 7}},       
                { new Attraction() { AttractionName = "Leningrad Zoo", VisitingTime = 9, Importance = 15}},        
                { new Attraction() { AttractionName = "The Bronze Horseman", VisitingTime = 1, Importance = 17}},       
                { new Attraction() { AttractionName = "Kazan Cathedral", VisitingTime = 4, Importance = 3}},        
                { new Attraction() { AttractionName = "Savior on the Blood", VisitingTime = 2, Importance = 9}},       
                { new Attraction() { AttractionName = "Winter Palace of Peter", VisitingTime = 7, Importance = 12}},     
                { new Attraction() { AttractionName = "Zoological Museum", VisitingTime = 5.5, Importance = 6}},   
                { new Attraction() { AttractionName = "Museum of Defense and Siege of Leningrad", VisitingTime = 2, Importance = 19}},      
                { new Attraction() { AttractionName = "Russian Museum", VisitingTime = 5, Importance = 8}},       
                { new Attraction() { AttractionName = "Visit friends", VisitingTime = 12, Importance = 20}},        
                { new Attraction() { AttractionName = "Wax Museum", VisitingTime = 2, Importance = 13}},        
                { new Attraction() { AttractionName = "Literary and Memorial Museum of F.M.Dostoevsky", VisitingTime = 4, Importance = 2}},      
                { new Attraction() { AttractionName = "Catherine Palace", VisitingTime = 1.5, Importance = 5}},       
                { new Attraction() { AttractionName = "Petersburg Museum of Dolls", VisitingTime = 1, Importance = 14}},       
                { new Attraction() { AttractionName = "Museum of microminiatures \"Russian Lefty\" ", VisitingTime = 3, Importance = 18}},       
                { new Attraction() { AttractionName = "All-Russian Museum A.S.Pushkin and branches", VisitingTime = 6, Importance = 1}},       
                { new Attraction() { AttractionName = "Erarta Museum of Modern Art", VisitingTime = 7, Importance = 16}}  
            };

            //attractions.Sort();
            Console.WriteLine("================================ INITIAL  DATA ============================================================ \n");
            

            // View all of the Attractions.
            foreach (Attraction thisAttraction in attractions)
            {
                Console.Write("Attraction Name " + thisAttraction.AttractionName + " ");
                Console.Write("Importance " + thisAttraction.Importance + " ");
                Console.Write("Visiting Time " + thisAttraction.VisitingTime + " ");
                Console.WriteLine();
            }

            foreach (Attraction thisAttraction in attractions)
            {
                Console.Write("Attraction Name " + thisAttraction.AttractionName + " ");
                Console.Write("Importance " + thisAttraction.Importance + " ");
                Console.Write("Visiting Time " + thisAttraction.VisitingTime + " ");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("================================ SORTED  DATA ============================================================ \n");

            var result = from attraction in attractions
                         orderby attraction.VisitingTime ascending
                         orderby attraction.Importance ascending    
                         select attraction;
            foreach (Attraction a in result)
                Console.WriteLine($"{a.AttractionName} - {a.VisitingTime}h - {a.Importance}");
        }
    }

    public class Attraction 
    {
        public string AttractionName { get; set; }
        public int Importance { get; set; }
        public double VisitingTime { get; set; }
    }
}