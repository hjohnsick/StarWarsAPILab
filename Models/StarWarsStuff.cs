using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsAPI.Models
{

    public class CharactersRoot
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Hair_color { get; set; }
        public string Skin_color { get; set; }
        public string Eye_color { get; set; }
        public string Birth_year { get; set; }
        public string Gender { get; set; }
        public string Homeworld { get; set; }
        public string[] Films { get; set; }
        public string[] Species { get; set; }
        public string[] Vehicles { get; set; }
        public string[] Starships { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }


    public class PlanetsRoot
    {
        public string Name { get; set; }
        public string Rotation_period { get; set; }
        public string Orbital_period { get; set; }
        public string Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public string Terrain { get; set; }
        public string Surface_water { get; set; }
        public string Population { get; set; }
        public object[] Residents { get; set; }
        public string[] Films { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public string Url { get; set; }
    }


}
