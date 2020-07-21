using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Adventure
{
    public partial class main : Form
    {
        // Variables
        List<string> bag = new List<string>();
        string item;

        // Custom Function
        private List<string> add_to_inventory(List<string> inventory, string item)
        {
            /*
             
             This is the function to add a thing to the inventory
             
             */

            // Add item to inventory
            inventory.Add(item);

            return inventory;
        }

        private List<string> remove_from_inventory(List<string> inventory, string item)
        {
            /*
             
             This is the function to remove an item from the inventory
             
             */

            int index;

            // Find the index of the item
            index = inventory.IndexOf(item);

            // Remove the item from the list
            inventory.RemoveAt(index);

            return inventory;
        }

        private void reset_choice()
        {
            /*
             
             This is the function to reset the choice users make.
             
             */

            // Uncheck all the choice
            choice_1.Checked = false;
            choice_2.Checked = false;

        }

        private void reset_inventory()
        {
            /*
             
             This is the function to reset the inventory of the user.
             
             */

            bag = new List<string>();
            inventory.Text = "";
        }

        private void stage_1()
        {
            // Change the story text
            story.Text = "You're a newly formed rock in the elven forest and you want to be the best rock in the whole world." + 
                "\n\nWhat are you going to do?";

            // Change the action choices
            choice_1.Text = "Sleep for another 100,000 years";
            choice_2.Text = "Converse with other rocks nearby";

            // Make the choices visible
            choice_1.Visible = true;
            choice_2.Visible = true;

            // Uncheck the choice
            reset_choice();

            // Make the next button visible and make the rest invisible
            start_game.Visible = false;
            stage_1_action.Visible = true;
            stage_2_action.Visible = false;
            stage_3_action.Visible = false;
        }

        private void stage_2()
        {
            // Change the story text
            story.Text = "You converse to a rock next to you who turned out to be an old wizard rock." + 
                " Before he die he gives you his magic and you gain Ultra Laser, Teleportation, Invisibility, Flash and Levitation." + 
                " He also mention that the Evil Elven Council is destroying the forest." + 
                "\n\n What are you going to do now?";

            // Change the action choices
            choice_1.Text = "Use Teleportation to confront the Elven Council";
            choice_2.Text = "Ignore the old man wish and chill";

            // Make the choices visible
            choice_1.Visible = true;
            choice_2.Visible = true;

            // Uncheck the choice
            reset_choice();

            // Make the next button visible and make the rest invisible
            start_game.Visible = false;
            stage_1_action.Visible = false;
            stage_2_action.Visible = true;
            stage_3_action.Visible = false;
        }

        private void stage_3()
        {
            // Change the story text
            story.Text = "You arrive in the Elven Council Hall. The Ultimate Elven Wizard confronts you. Your goal is to kill the Elven Wizard." + 
                " Use one of your skill to kill the Elven Wizard." + 
                "\n\nWhat skill will you use?";

            // Change the action choices
            choice_1.Text = "Use Levitation to fly";
            choice_2.Text = "Use Ultra Laser to attack the Wizard";

            // Make the choices visible
            choice_1.Visible = true;
            choice_2.Visible = true;

            // Uncheck the choice
            reset_choice();

            // Make the next button visible and make the rest invisible
            start_game.Visible = false;
            stage_1_action.Visible = false;
            stage_2_action.Visible = false;
            stage_3_action.Visible = true;
        }

        private void dead_end()
        {
            // Change the story text
            story.Text = "Game Over." + 
                "\n\nThe council found you and knew about your ambition to become the strongest rock in the world and destroyed the whole Elven Forest. You're dead now." + 
                " Press start the game to restart.";

            // Change the action choices
            choice_1.Text = "";
            choice_2.Text = "";

            // Make the choices visible
            choice_1.Visible = false;
            choice_2.Visible = false;

            // Uncheck the choice
            reset_choice();

            // Make the next button visible and make the rest invisible
            start_game.Visible = true;
            stage_1_action.Visible = false;
            stage_2_action.Visible = false;
            stage_3_action.Visible = false;

            // Reset inventory
            reset_inventory();
        }

        private void dead()
        {
            // Change the story text
            story.Text = "Game Over." +
                "\n\nThe Wizard used Reflection to reflect the laser back at you. You exploded taking the damage and shattered into pieces. You died." +
                " Press start the game to restart.";

            // Change the action choices
            choice_1.Text = "";
            choice_2.Text = "";

            // Make the choices visible
            choice_1.Visible = false;
            choice_2.Visible = false;

            // Uncheck the choice
            reset_choice();

            // Make the next button visible and make the rest invisible
            start_game.Visible = true;
            stage_1_action.Visible = false;
            stage_2_action.Visible = false;
            stage_3_action.Visible = false;

            // Reset inventory
            reset_inventory();
        }

        private void win()
        {
            // Change the story text
            story.Text = "Congratulations!" +
                "\n\nThe Wizard used Explosion and blowed up the Council Hall. The ceiling fell in front of the Wizard unexpectedly. The Wizard died because of shock. You save the Elven Forest and you become the best rock in the world." +
                " Press start the game to restart.";

            // Change the action choices
            choice_1.Text = "";
            choice_2.Text = "";

            // Make the choices visible
            choice_1.Visible = false;
            choice_2.Visible = false;

            // Uncheck the choice
            reset_choice();

            // Make the next button visible and make the rest invisible
            start_game.Visible = true;
            stage_1_action.Visible = false;
            stage_2_action.Visible = false;
            stage_3_action.Visible = false;

            // Reset inventory
            reset_inventory();
        }

        // Main Function
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void start_game_Click(object sender, EventArgs e) // Start Game
        {
            // On game start, proceed to stage 1
            stage_1();
        }

        private void stage_1_action_Click(object sender, EventArgs e)
        {
            // Create the game branch
            if (choice_1.Checked)
            {
                // trigger dead end
                dead_end();
            }
            else if (choice_2.Checked)
            {
                string item_lists;

                item_lists = "";

                // trigger stage 2
                stage_2();

                // Add skills to the bag
                add_to_inventory(bag, "Ultra Laser");
                add_to_inventory(bag, "Teleportation");
                add_to_inventory(bag, "Invisibility");
                add_to_inventory(bag, "Flash");
                add_to_inventory(bag, "Levitation");

                // Display skills in inventory
                foreach(string item in bag)
                {
                    item_lists = item_lists + item + "     ";
                }

                inventory.Text = item_lists;
            }
        }

        private void stage_2_action_Click(object sender, EventArgs e)
        {
            if (choice_1.Checked)
            {
                string item_lists;

                item_lists = "";

                // Remove teleportation skill from the inventory
                remove_from_inventory(bag, "Teleportation");

                // Display the inventory
                foreach (string item in bag)
                {
                    item_lists = item_lists + item + "     ";
                }

                inventory.Text = item_lists;

                // Trigger stage 3
                stage_3();
            }
            else if (choice_2.Checked)
            {
                // Trigger dead end
                dead_end();
            }
        }

        private void stage_3_action_Click(object sender, EventArgs e)
        {
            if (choice_1.Checked)
            {
                string item_lists;

                item_lists = "";

                // Remove skill from the bag
                remove_from_inventory(bag, "Levitation");

                // Display the inventory
                foreach (string item in bag)
                {
                    item_lists = item_lists + item + "     ";
                }

                inventory.Text = item_lists;

                // Win
                win();
            }
            else if (choice_2.Checked)
            {
                // Trigger dead
                dead();
            }
        }
    }
}
