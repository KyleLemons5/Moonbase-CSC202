// Kyle Lemons
// CSC202
// 9/19/23
// Last Edited: 10/17/23
/*
 *                           Map (not to scale)
 *                             ______________
 *                             |            |
 *                             |  Bedroom   |
 *                             |__        __|
 * __________   ______________   |        |   _______________
 * |        |___|            |___|        |___|             |__
 * |  ????   ___ Dining Room  ___ Hallway  ___ Reading Room  _|    Outside
 * |________|   |____________|   |        |   |_____________|
 *                             __|        |__
 *                             |            |
 *                             |  Bedroom   |
 *                             |____________|
 * 
 * Note: Locations with "?" are not currently implemented
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Moonbase
{
    public partial class FormMain : Form
    {

        private string location; // Current location of the user

        // All locations in the moonbase
        Location readingRoom = new Location("Reading Room", "A small room near the corner of the base. This room is primarily used as a quiet room far away from the main common areas. Many people come here to read, but others use this place as a private area to play games or have private conversations.", "Resources\\Moonbase Room.jpg", false, false, true, true);
        Location hallway = new Location("Hallway", "The hallway between the bedrooms of Craterville's residents. The hallway also leads to the dining room and reading room. Many people come through this place every day. It is standard protocol to greet anyone you way see in these halls to avoid potentail interpersonal issues.", "Resources\\Moonbase Hall.jpg", true, true, true, true);
        Location diningRoom = new Location("Dining Room", "This is the most active room in all of Craterville. Residents come to eat and enjoy eachother's company. The food selection is quite limited with only dehydrated foods being available. This room is also often host to larger group activities and meetings.", "Resources\\Moonbase Dining.jpg", false, false, false, true);
        Location outside = new Location("Outside", "Only a small layer of spacesuit protects you from the cold embrace of space. Outside the base is completely silent due to a lask of atmosphere. The moondust is a sharp powder due to millions of small meteorite impacts and no atmosphere to errode away the sharp edges. The dust is also electrostatically charged, sticking to any surface it comes into contact with. There's nothing to do out here except check on equipment occasionally.", "Resources\\Moonbase Outside.jpg", false, false, true, false);
        Location northBedroom = new Location("North Bedroom", "The bedrooms in the northern section of Craterville. Higher ranking offcials get their own private bedrooms here. Some offcials use their bedrooms as personal offices.", "Resources\\Moonbase Bedroom 1.jpg", false, true, false, false);
        Location southBedroom = new Location("South Bedroom", "The bedrroms in the southern section od Craterville. Here several beds are packed into the same rooms to save space. Some people host lite night gatherings here with thier roommates.", "Resources\\Moonbase Bedroom 2.jpg", true, false, false, false);

        public FormMain()
        {
            InitializeComponent();
        }

        // "Moves" the user to the location given to the method
        private void moveTo(Location room)
        {
            this.location = room.getLocation();
            textBoxName.Text = room.getLocation();
            textBoxDesc.Text = room.getDescription();
            ActiveForm.BackgroundImage = Image.FromFile(room.getImage());
            northButton.Enabled = room.getNorth();
            southButton.Enabled = room.getSouth();
            westButton.Enabled = room.getWest();
            eastButton.Enabled = room.getEast();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            location = textBoxName.Text; // Upon loading the form, set the location to the current location text name
            northButton.Enabled = false;
            southButton.Enabled = false;
        }

        // "Moves" the user to the west by by calling the correct room update
        private void westButton_Click(object sender, EventArgs e)
        {
            if (location == "Reading Room")
            {
                moveTo(hallway);
            }

            else if (location == "Hallway")
            {
                moveTo(diningRoom);
            }

            else if (location == "Outside")
            {
                moveTo(readingRoom);
            }
        }

        // "Moves" the user to the east by by calling the correct room update
        private void eastButton_Click(object sender, EventArgs e)
        {
            if (location == "Reading Room")
            {
                moveTo(outside);
            }

            else if (location == "Hallway")
            {
                moveTo(readingRoom);
            }

            else if (location == "Dining Room")
            {
                moveTo(hallway);
            }
        }

        // "Moves" the user to the north by by calling the correct room update
        private void northButton_Click(object sender, EventArgs e)
        {
            if (location == "Hallway")
            {
                moveTo(northBedroom);
            }

            else if (location == "South Bedroom")
            {
                moveTo(hallway);
            }
        }

        // "Moves" the user to the south by by calling the correct room update
        private void southButton_Click(object sender, EventArgs e)
        {
            if (location == "Hallway")
            {
                moveTo(southBedroom);
            }

            else if (location == "North Bedroom")
            {
                moveTo(hallway);
            }
        }
    }

    // Class that creates a location object that stores all the information of a location
    public class Location
    {
        // The properties of Location
        private string location;
        private string description;
        private string image;
        private Boolean north;
        private Boolean south;
        private Boolean west;
        private Boolean east;

        // Constructor of Location that gets and stores all the information of a location
        public Location(string location, string description, string image, bool north, bool south, bool west, bool east)
        {
            this.location = location;
            this.description = description;
            image = Path.GetFullPath(image); // Gets the full path of an image, so it can be correctly called later
            this.image = image;
            this.north = north;
            this.south = south;
            this.west = west;
            this.east = east;
        }

        // Setters and getters for the properties of Location
        public void setLocation(string location)
        {
            this.location = location;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public void setImage(string image)
        {
            this.image = image;
        }

        public void setNorth(Boolean north)
        {
            this.north = north;
        }

        public void setSouth(Boolean south)
        {
            this.south = south;
        }

        public void setWeat(Boolean west)
        {
            this.west = west;
        }

        public void setEast(Boolean east)
        {
            this.east = east;
        }

        public string getLocation()
        {
            return location;
        }

        public string getDescription()
        {
            return description;
        }
        public string getImage()
        {
            return image;
        }

        public Boolean getNorth()
        {
            return north;
        }

        public Boolean getSouth()
        {
            return south;
        }

        public Boolean getWest()
        {
            return west;
        }

        public Boolean getEast()
        {
            return east;
        }

    }

}
