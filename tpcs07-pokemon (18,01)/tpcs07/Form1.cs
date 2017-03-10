using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tpcs07
{
    public partial class Form1 : Form
    {
#if POKEMON
        Arena arena;
        public Form1(Arena arena)
        {
            this.arena = arena;

            InitializeComponent();
        }

        public void DoAttack(int n)
        {
            arena.attack_with(n);
            this.rightLife.Value = Math.Abs(arena.right.pv);
            this.rightPV.Text = arena.right.pv + " / " + arena.right.pv_max;
            this.leftLife.Value = Math.Abs(arena.left.pv);
            this.leftPV.Text = arena.left.pv + " / " + arena.left.pv_max;
            if (arena.is_finished())
            {
                MessageBox.Show("Game Over");
                Application.Exit();
            }
                
            arena.change_attacker();
        }

        private Image getPokemonImage(PokemonType pokemon, int type)
        {
            string path = "assets//poke_";
            if (pokemon == PokemonType.Pikachu)
                path += "p1kachu";
            else if (pokemon == PokemonType.Aquali)
                path += "aquali";
            else if (pokemon == PokemonType.Lockhlass)
                path += "lockhlass";
            else if (pokemon == PokemonType.Smogogo)
                path += "smogogo";
            else if (pokemon == PokemonType.Spectrum)
                path += "spectrum";
            else if (pokemon == PokemonType.Dracaufeu)
                path += "dracaufeu";
            path += ".png";
            Image img;
            try
            {
                img = Image.FromFile(path);
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            return img;
        }
#else
        public Form1()
        {
            InitializeComponent();
        }
#endif

        // Init function
        private void Form1_Load(object sender, EventArgs e)
        {
            // right Pony
#if POKEMON
            this.rightPony.Image = getPokemonImage(arena.right.type, 1);
            this.rightName.Text = arena.right.name;
            this.rightPV.Text = arena.right.pv + " / " + arena.right.pv_max;
            this.rightLife.Minimum = 0;
            this.rightLife.Maximum = arena.right.pv_max;
            this.rightLife.Value = arena.right.pv;
            this.rightAttack.Items.Add(arena.right.get_attack(0).name);
            this.rightAttack.Items.Add(arena.right.get_attack(1).name);
            this.rightAttack.SelectedIndex = 0;
#endif
            this.rightAttack.Enabled = false;
            this.rightButton.Enabled = false;
            this.rightLife.ForeColor = Color.Green;
            this.rightLife.Style = ProgressBarStyle.Blocks;

            // left Pony
#if POKEMON
            this.leftPony.Image = getPokemonImage(arena.left.type, 1);
            this.leftPony.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            this.leftName.Text = arena.left.name;
            this.leftPV.Text = arena.left.pv + " / " + arena.left.pv_max;
            this.leftLife.Minimum = 0;
            this.leftLife.Maximum = arena.left.pv_max;
            this.leftLife.Value = arena.left.pv;
            this.leftAttack.Items.Add(arena.left.get_attack(0).name);
            this.leftAttack.Items.Add(arena.left.get_attack(1).name);
            this.leftAttack.SelectedIndex = 0;
#endif
            this.leftAttack.Enabled = true;
            this.leftButton.Enabled = true;
            this.leftLife.ForeColor = Color.Green;
            this.leftLife.Style = ProgressBarStyle.Blocks;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (arena.is_finished())
                return;
            if (this.leftAttack.Enabled)
                DoAttack(this.leftAttack.SelectedIndex);
            else
                DoAttack(this.rightAttack.SelectedIndex);

            this.rightAttack.Enabled = !this.rightAttack.Enabled;
            this.rightButton.Enabled = !this.rightButton.Enabled;
            this.leftAttack.Enabled = !this.leftAttack.Enabled;
            this.leftButton.Enabled = !this.leftButton.Enabled;
        }
    }
}