// Kyle Lemons
// CSC202
// 9/19/23
// Last Edited: 9/26/23
/*
 *                           Map (not to scale)
 *                             ______________
 *                             |            |
 *                             |  Bedroom?  |
 *                             |__        __|
 * __________   ______________   |        |   _______________
 * |        |___|            |___|        |___|             |__
 * |  ????   ___ Dining Room  ___ Hallway  ___ Reading Room  _|    Outside
 * |________|   |____________|   |        |   |_____________|
 *                             __|        |__
 *                             |            |
 *                             |  Bedroom?  |
 *                             |____________|
 * 
 * Note: Locations with "?" are not currently implemented
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class FormMain : Form
    {

        private string location; // Current location of the user

        public FormMain()
        {
            InitializeComponent();
        }

        // "Moves" the user to the Reading Room by updating all relevant components to the Reading Room settings
        private void moveToReadingRoom()
        {
            location = "Reading Room";
            textBoxName.Text = location;
            textBoxDesc.Text = "A small room near the corner of the base. This room is primarily used as a quiet room far away from the main common areas. Many people come here to read, but others use this place as a private area to play games or have private conversations.";
            ActiveForm.BackgroundImage = Properties.Resources.Moonbase_Room;
        }

        // "Moves" the user to the Hallway by updating all relevant components to the Hallway settings
        private void moveToHallway()
        {
            location = "Hallway";
            textBoxName.Text = location;
            textBoxDesc.Text = "The hallway between the bedrooms of Craterville's residents. The hallway also leads to the dining room and reading room. Many people come through this place every day. It is standard protocol to greet anyone you way see in these halls to avoid potentail interpersonal issues.";
            ActiveForm.BackgroundImage = Properties.Resources.Moonbase_Hall;
        }

        // "Moves" the user to the Dining Room by updating all relevant components to the Dining Room settings
        private void moveToDining()
        {
            location = "Dining Room";
            textBoxName.Text = location;
            textBoxDesc.Text = "This is the most active room in all of Craterville. Residents come to eat and enjoy eachother's company. The food selection is quite limited with only dehydrated foods being available. This room is also often host to larger group activities and meetings.";
            ActiveForm.BackgroundImage = Properties.Resources.Moonbase_Dining;
        }

        // "Moves" the user to the Outside by updating all relevant components to the Outside settings
        private void moveToOutside()
        {
            location = "Outside";
            textBoxName.Text = location;
            textBoxDesc.Text = "Only a small layer of spacesuit protects you from the cold embrace of space. Outside the base is completely silent due to a lask of atmosphere. The moondust is a sharp powder due to millions of small meteorite impacts and no atmosphere to errode away the sharp edges. The dust is also electrostatically charged, sticking to any surface it comes into contact with. There's nothing to do out here except check on equipment occasionally.";
            ActiveForm.BackgroundImage = Properties.Resources.Moonbase_Outside;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            location = textBoxName.Text; // Upon loading the form, set the location to the current location text name
        }

        // "Moves" the user to the west by by calling the correct room update
        private void westButton_Click(object sender, EventArgs e)
        {
            if (location == "Reading Room")
            {
                moveToHallway();
            }

            else if (location == "Hallway")
            {
                moveToDining();
            }
            
            else if (location == "Outside")
            {
                moveToReadingRoom();
            }
        }

        // "Moves" the user to the east by by calling the correct room update
        private void eastButton_Click(object sender, EventArgs e)
        {
            if (location == "Reading Room")
            {
                moveToOutside();
            }

            else if (location == "Hallway")
            {
                moveToReadingRoom();
            }

            else if (location == "Dining Room")
            {
                moveToHallway();
            }
        }
    }
}
