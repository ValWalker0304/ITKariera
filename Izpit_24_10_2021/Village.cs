using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Izpit_24_10_2021_1
{
    public class Village
    {
        private List<Peasant> Peasants = new List<Peasant>();
        private string villageName;
        private string location;
        private int resource;

        public Village(string villageName, string location)
        {
            this.VillageName = villageName;
            this.Location = location;
        }
        public int Resource
        {
            get
            {
                return resource;
            }
            set
            {
                this.resource = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 45)
                {
                    this.location = value;
                }
                else 
                    throw new ArgumentException("Location should be between 3 and 45 characters!");


            }
        }
        public string VillageName
        {
            get
            {
                return villageName;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 40)
                {
                    this.villageName = value;
                }
                else 
                    throw new ArgumentException("Name should be between 2 and 40 characters!");


            }
        }
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine($"Village - {this.villageName} ({this.location})");          
            stb.AppendLine($"Resources - {this.resource}");
            stb.AppendLine($"Peasants - ({Peasants.Count()})");
            foreach (var item in Peasants)
            {
                stb.AppendLine(item.ToString());
            }
            return stb.ToString();
        }
        public void AddPeasant(Peasant peasant)
        {
            Peasants.Add(peasant);
        }
        public int PassDay()
        {
            var productivity = Peasants.Sum(x => x.Productivity);
            Resource += productivity;
            return productivity;
        }
        public List<Peasant> KillPeasants(int count)
        {
            if (count == 0)
            {
                return new List<Peasant>();
            }
            var peasantsToRemove = new List<Peasant>();
            if (count >= Peasants.Count)
            {
                peasantsToRemove = Peasants;
                Peasants.Clear();
                return peasantsToRemove;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    var currentPeasant = Peasants[0];
                    peasantsToRemove.Add(currentPeasant);
                    Peasants.RemoveAt(0);
                }
                return peasantsToRemove;
            }
                
        }
    }
}