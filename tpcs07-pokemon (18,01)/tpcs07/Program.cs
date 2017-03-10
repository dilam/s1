using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tpcs07
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Not A Pokemon
            Pokemon vide = new Pokemon("None", PokemonType.Pikachu, 0, 0);

            // Pikachu
            Pokemon pika = new Pokemon("Pikachu", PokemonType.Pikachu, 50, 120);

            Attack pk0 = new Attack("Éclair", 30, 41, 15, 5, 10);
            pika.set_attack(pk0, 0);

            Attack pk1 = new Attack("Cage-Éclair", 35, 46, 10, 5, 10);
            pika.set_attack(pk1, 1);

            // Dracaufeu
            Pokemon dracau = new Pokemon("Dracaufeu", PokemonType.Dracaufeu, 70, 150);

            Attack drc0 = new Attack("Dracogriffe", 40, 45, 15, 5, 10);
            dracau.set_attack(drc0, 0);

            Attack drc1 = new Attack("Crocs Feu", 35, 46, 10, 5, 10);
            dracau.set_attack(drc1, 1);

            // Lockhlass
            Pokemon lockh = new Pokemon("Lockhlass", PokemonType.Lockhlass, 40, 110);

            Attack lck0 = new Attack("Éclats Glace", 25, 31, 15, 5, 10);
            lockh.set_attack(lck0, 0);

            Attack lck1 = new Attack("Hydrocanon", 30, 40, 10, 5, 10);
            lockh.set_attack(lck1, 1);

            // Smogogo
            Pokemon smog = new Pokemon("Smogogo", PokemonType.Smogogo, 60, 140);

            Attack smg0 = new Attack("Gaz Toxik", 35, 41, 15, 5, 10);
            smog.set_attack(smg0, 0);

            Attack smg1 = new Attack("Bomb Beurk", 40, 47, 10, 5, 10);
            smog.set_attack(smg1, 1);

            // Spectrum
            Pokemon spect = new Pokemon("Spectrum", PokemonType.Spectrum, 40, 110);

            Attack spt0 = new Attack("Ball'Ombre", 25, 31, 15, 5, 10);
            spect.set_attack(spt0, 0);

            Attack spt1 = new Attack("Vibrobscur", 30, 40, 10, 5, 10);
            spect.set_attack(spt1, 1);

            // Aquali
            Pokemon aqua = new Pokemon("Aquali", PokemonType.Aquali, 70, 100);

            Attack aq0 = new Attack("Onde Boréale", 40, 45, 15, 5, 10);
            aqua.set_attack(aq0, 0);

            Attack aq1 = new Attack("Anneau Hydro", 35, 46, 10, 5, 10);
            aqua.set_attack(aq1, 1);

            Application.Run(new Form3(vide, pika, dracau, lockh, smog, spect, aqua));
        }
    }
}
