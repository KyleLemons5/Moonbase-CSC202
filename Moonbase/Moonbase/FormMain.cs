// Kyle Lemons
// CSC202
// 9/19/23
// Last Edited: 10/26/23
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
using System.Media;
using System.Text;
using System.Windows.Forms;


namespace Moonbase
{
    public partial class FormMain : Form
    {

        // All locations in the moonbase
        Location readingRoom = new Location("Reading Room", "A small room near the corner of the base. This room is primarily used as a quiet room far away from the main common areas. Many people come here to read, but others use this place as a private area to play games or have private conversations.", "Resources\\Moonbase Room.jpg", false, false, true, true);
        Location hallway = new Location("Hallway", "The hallway between the bedrooms of Craterville's residents. The hallway also leads to the dining room and reading room. Many people come through this place every day. It is standard protocol to greet anyone you way see in these halls to avoid potentail interpersonal issues.", "Resources\\Moonbase Hall.jpg", true, true, true, true);
        Location diningRoom = new Location("Dining Room", "This is the most active room in all of Craterville. Residents come to eat and enjoy eachother's company. The food selection is quite limited with only dehydrated foods being available. This room is also often host to larger group activities and meetings.", "Resources\\Moonbase Dining.jpg", false, false, false, true);
        Location outside = new Location("Outside", "Only a small layer of spacesuit protects you from the cold embrace of space. Outside the base is completely silent due to a lask of atmosphere. The moondust is a sharp powder due to millions of small meteorite impacts and no atmosphere to errode away the sharp edges. The dust is also electrostatically charged, sticking to any surface it comes into contact with. There's nothing to do out here except check on equipment occasionally.", "Resources\\Moonbase Outside.jpg", false, false, true, false);
        Location northBedroom = new Location("North Bedroom", "The bedrooms in the northern section of Craterville. Higher ranking offcials get their own private bedrooms here. Some offcials use their bedrooms as personal offices.", "Resources\\Moonbase Bedroom 1.jpg", false, true, false, false);
        Location southBedroom = new Location("South Bedroom", "The bedrroms in the southern section od Craterville. Here several beds are packed into the same rooms to save space. Some people host lite night gatherings here with thier roommates.", "Resources\\Moonbase Bedroom 2.jpg", true, false, false, false);
        
        Actor user = new Actor("Reading Room"); // User Actor

        // All NPC's in the moonbase (not displayed yet)
        NPC Jim = new NPC("North bedroom", "Jim", "Captain");
        NPC Jimbo = new NPC("South bedroom", "Jimbo", "Engineer");
        NPC Jimmy = new NPC("Hallway", "Jimmy", "Engineer");
        NPC Jimmothy = new NPC("Dining Room", "Jimmothy", "Chef");

        public FormMain()
        {
            InitializeComponent();
        }

        // "Moves" the user to the location given to the method
        private void moveTo(Location room)
        {
            user.setLocation(room.getLocation());
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
            user.setLocation(textBoxName.Text); // Upon loading the form, set the location to the current location text name
            northButton.Enabled = false;
            southButton.Enabled = false;
        }

        // "Moves" the user to the west by by calling the correct room update
        private void westButton_Click(object sender, EventArgs e)
        {
            if (user.getLocation() == "Reading Room")
            {
                moveTo(hallway);
            }

            else if (user.getLocation() == "Hallway")
            {
                moveTo(diningRoom);
            }

            else if (user.getLocation() == "Outside")
            {
                moveTo(readingRoom);
            }
        }

        // "Moves" the user to the east by by calling the correct room update
        private void eastButton_Click(object sender, EventArgs e)
        {
            if (user.getLocation() == "Reading Room")
            {
                moveTo(outside);
            }

            else if (user.getLocation() == "Hallway")
            {
                moveTo(readingRoom);
            }

            else if (user.getLocation() == "Dining Room")
            {
                moveTo(hallway);
            }
        }

        // "Moves" the user to the north by by calling the correct room update
        private void northButton_Click(object sender, EventArgs e)
        {
            if (user.getLocation() == "Hallway")
            {
                moveTo(northBedroom);
            }

            else if (user.getLocation() == "South Bedroom")
            {
                moveTo(hallway);
            }
        }

        // "Moves" the user to the south by by calling the correct room update
        private void southButton_Click(object sender, EventArgs e)
        {
            if (user.getLocation() == "Hallway")
            {
                moveTo(southBedroom);
            }

            else if (user.getLocation() == "North Bedroom")
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

    // Actor class that represents a being in the moonbase
    public class Actor
    {
        // The properties of Actor
        string location;

        // Constructor of Actor that gets and stores all the information of an actor
        public Actor(string location)
        {
            this.location = location;
        }

        // Setters and getters for the properties of Actor
        public void setLocation(String location)
        {
            this.location = location;
        }

        public string getLocation()
        {
            return location;
        }
    }

    // NPC class that represents NPCs in the moonbase
    public class NPC : Actor
    {
        // The properties of NPC
        string name;
        string job;

        // Constructor of NPC that gets and stores all the information of an NPC
        public NPC(string location, string name, string job) : base(location)
        {
            this.name = name;
            this.job = job;
        }

        // Setters and getters for the properties of NPC
        public void setName(String name)
        {
            this.name = name;
        }

        public void setJob(String job)
        {
            this.job = job;
        }

        public string getName()
        {
            return name;
        }

        public string getJob()
        {
            return job;
        }
    }

}
