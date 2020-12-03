using System;
using System.Collections.Generic;

namespace Pirate_Sim
{
    public class Ship
    {
        public string name;

        List<string> possibleNames = new List<string>()
        {"The Dragonturtle", "La Desollador", "Reef Sprinter", "Wrath of the Umberlee", "The Wavebreaker", "Firewalker",
        "Windgrace", "Empress Celestina", "The Morning Moon", "The Midnight Sun", "Old Salty", "Nightfall's Rest", "The Parched Parrot",
        "The Red Thief", "Uppertide", "The Stygian", "Lady of the Black Water", "Kraken's Kiss", "Triton's Bane", "The Gold Falchion",
        "The Seafoam Martyr", "Mistral Secret", "The Goading Riptide", "The Torrent", "Misfit's Gamble", "Storm Giants Wake",
        "The Shooting Star", "Shadow Squall", "The Omen", "Wraith's Requiem", "Maelstrom's Bane", "The Sea Maiden's Ballad", "Queen's Grace",
        "The Arcadia", "The Greymaiden", "The Siren's Tear", "Tide Runner", "The Hopeless Blade", "Wave Weasel", "The Lord of Dance",
        "Jupiter's Revenge", "Neptune's Favor", "The Fairweather Fortune", "The Omen", "Caballero", "The Mist", "Eden's Horizon"};

        int HP;
        int DMG;

        bool isAlive = true;

        Random generator = new Random();

        public bool GetAlive()
        {
            if (isAlive == false)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public void Spawn()
        {
            HP = 25;
            DMG = 5;

            int n = generator.Next(possibleNames.Count);
            name = possibleNames[n];

            possibleNames.RemoveAt(n);
        }

        public int Attack()
        {
            int dmgAmount =  generator.Next(1, DMG);
            return dmgAmount;
        }

        public void takeDMG(int dmgAmount)
        {
            HP =- dmgAmount;
        }

        public void Repair()
        {
            int healAmount = 25 - HP;
            HP += healAmount;
        }

        public void Upgrade()
        {
            DMG =+ 2;
        }

        public void GetStats()
        {
            System.Console.WriteLine("Your ship, " + name + ", is at " + HP + "health and has a firepower of " + DMG);
        }
    }

}
