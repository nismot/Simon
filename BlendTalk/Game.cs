using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;

namespace BlendTalk
{
    class Game
    {
        
        public void Simon()
        {

            Random random = new Random(); //Seed random number generator
            int[] roll = new int[4]; // Initiallizing array

            for (int i = 0; i < roll.Length; i++) // Generates a number between 1 and 4.
            {
                roll[i] = random.Next(1,5);
            }

        }// End Simon Class

        // Simulate Button Presses
        public void ButtonPressed(object sender, EventArgs e) //RoutedEventArgs?
        {
            
        }
        
        public void Player()
        {

        }// End Player Class
    }
}
