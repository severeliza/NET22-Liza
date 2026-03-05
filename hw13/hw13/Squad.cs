using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ConsoleApp2
{
    public class Squad
    {
        [JsonPropertyName("SoldiersNumber")]
        public int Size { get; set; }

        public string SquadName { get; set; }

        public List<Soldier> Soldiers { get; set; }
    }
}
