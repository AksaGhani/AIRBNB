using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AIRBNB
{
    public partial class frmMain : Form
    {
        //selected data variables
        public static int selectedDistrict = 0;
        public static int selectedNeighbrhd = 0;
        public static int selectedProperty = 0;
        
        public frmMain()
        {
            InitializeComponent();

            getDistrict();

            showDistrict();
            selectedNeighbrhd = lstNeighbrhd.SelectedIndex;
            selectedProperty = lstProperties.SelectedIndex;
            showNeighbrhd();
            showProperties();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            showNeighbrhd();
            showProperties();
            
        }
        //GET DATA METHODS
        private void getDistrict()
        {
            //create streamreader
            StreamReader inStream = new StreamReader("MiniAirbnb.txt");

            //district variables
            string districtName;
            int numNeighbrhds;

            Neighbourhood[] theseNeighbourhoods;
            //get neighbourhood data x3 - while loop
            while (!inStream.EndOfStream)
            {
                //get district data
                districtName = inStream.ReadLine();
                numNeighbrhds = Convert.ToInt32(inStream.ReadLine());

                //get neighbourhood
                theseNeighbourhoods = getaNeighbrhd(numNeighbrhds, inStream);

                //create district object with that data and those neighbrhds
                District newDistrict = new District(districtName, Convert.ToString(numNeighbrhds), theseNeighbourhoods);

                //make DISTRICT array bigger
                int oldSize = Data.allDistricts.Length;
                Array.Resize(ref Data.allDistricts, oldSize + 1);

                //put new District into space create
                Data.allDistricts[oldSize] = newDistrict;

            }

        }

        private Neighbourhood [] getaNeighbrhd(int numNeighbrhds, StreamReader input)
        {
            //make district array - now we know how many times to go around
            Neighbourhood[] dumplater = new Neighbourhood[0];

            for (int i = 0; i < numNeighbrhds; i++)
            {
                string neighbrhdName = input.ReadLine();
                int numProperties = Convert.ToInt32(input.ReadLine());
                Property[] theseProperties;

                //get property 
                theseProperties = getaProperty(numProperties, input);

                //increase array
                Array.Resize(ref dumplater, dumplater.Length + 1);

                //add new neighbrhd into neighbrhd array
                dumplater[dumplater.Length - 1] = new Neighbourhood(neighbrhdName, numProperties, theseProperties);
            }
            return dumplater;
        }


        private Property[] getaProperty(int numProperties, StreamReader input)
        {
            //make Neighbrhd array - now we know how many times to go around
            Property[] dumpLater = new Property[0];

            for (int i = 0; i < numProperties; i++)
            {
                string propertyId = input.ReadLine();
                string propertyName = input.ReadLine();
                string hostId = input.ReadLine();
                string hostName = input.ReadLine();
                string numPropertiesForHost = input.ReadLine();
                string latitude = input.ReadLine();
                string longitude = input.ReadLine();
                string roomType = input.ReadLine();
                string price = input.ReadLine();
                string minNumNights = input.ReadLine();
                string numOfAvailabilty = input.ReadLine();

                // increase array
                Array.Resize(ref dumpLater, dumpLater.Length + 1);

                //add new property into property array
                dumpLater[dumpLater.Length - 1] = new Property(propertyId, propertyName, hostId, hostName, numPropertiesForHost,
                    latitude, longitude, roomType, price, minNumNights, numOfAvailabilty);
            }
            return dumpLater;
        }
        //SHOW DATA METHODS
        private void showDistrict()
        {
            lstDistricts.Items.Clear();
            foreach (District d in Data.allDistricts)
            {
                lstDistricts.Items.Add("Name: " + d.getDistrictName() + " No. Of Neighbourhoods: " + d.getNumNeighbrhds());
            }
        }
        private void showNeighbrhd()
        {
            //read neighbourhoods from array
            Neighbourhood[] thisNeighbrhdArray = Data.allDistricts[selectedDistrict].getAllNeighbrhds();
            lstNeighbrhd.Items.Clear();

            foreach (Neighbourhood n in thisNeighbrhdArray)
            {
                lstNeighbrhd.Items.Add( "Name: " +n.getNeighbourHdName() + " No. of Properties: " + n.getNumPropertiesInNeighbourhd());
            }
            selectedNeighbrhd = 0;
        }

        private void showProperties()
        {
            //read properties from which array?
            Neighbourhood[] tempAllNeighbrhd = Data.allDistricts[selectedDistrict].getAllNeighbrhds();
            Neighbourhood tempOneNbhd = tempAllNeighbrhd[selectedNeighbrhd];

            Property[] thisPropertyArray = tempOneNbhd.getAllProperties();
            
            lstProperties.Items.Clear();

            foreach (Property p in thisPropertyArray)
            {
                lstProperties.Items.Add("ID: " + p.getpropertyID() + "   Name: " + p.getpropertyName() + "   Host ID: " + p.gethostID() + " Host Names: " + p.gethostName() + "   Properties Listed for host: " + p.getNumPropertiesForHost()
                    + "   Latitude: " + p.getLatitude() + "   Longitude: " + p.getLongitude() + "   Room Type: " + p.getRoomType() + "   Price (£): " + p.getPrice() + "   Min. No. of Nights: " + p.getMinNumNights() + "   No. of available days: " + p.getNumOfAvailability());
            }
            selectedProperty = 0;
            //display horizontal scrollbar
            lstProperties.HorizontalScrollbar = true;
        }
      
        //POPULATE TXTBXS METHODS
        private void populateDistrictTextBxs()
        {
            //populate district txtbxs
            txtDistrictName.Text = Data.allDistricts[selectedDistrict].getDistrictName();
            txtNumNeighbrhdsInDistrict.Text = Data.allDistricts[selectedDistrict].getNumNeighbrhds().ToString();
        }
        private void populateNeighbrhdTxbxs()
        {
            //populate neighbrhd txtbxs
            txtNeighbourhdName.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getNeighbourHdName();
            txtNumPropertiesInNeighbrhd.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getNumPropertiesInNeighbourhd().ToString();
        }

        private void populatePropertyTxbxs()
        {
            //populate property txtbxs
            txtPropertyId.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty].getpropertyID().ToString();
            txtPropertyName.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty].getpropertyName();
            txtHostId.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty].gethostID().ToString();
            txtHostName.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty].gethostName();
            txtNumOfpropertiesForHost.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty].getNumPropertiesForHost().ToString();
            txtLatitude.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty].getLatitude().ToString();
            txtLongitude.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty].getLongitude().ToString();
            txtRoomType.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty].getRoomType();
            txtPrice.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty].getPrice().ToString();
            txtMinNumNights.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty].getMinNumNights().ToString();
            txtAvailability.Text = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty].getNumOfAvailability().ToString();
        }
        private void lstDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDistrict = lstDistricts.SelectedIndex;
            showNeighbrhd();
            showProperties();
            //call method to populate all txtbxs
            populateDistrictTextBxs();
            populateNeighbrhdTxbxs();
            populatePropertyTxbxs();

            selectedProperty = 0;
            selectedNeighbrhd = 0;
        }
        private void lstNeighbrhd_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNeighbrhd = lstNeighbrhd.SelectedIndex;
            showProperties();

            //call method to populate neighbrhd txtbxs and property txtbxs
            populateNeighbrhdTxbxs();
            populatePropertyTxbxs();

            // MessageBox.Show("Neighbourhood no:" + selectedNeighbrhd.ToString());
            selectedProperty = 0;
        }

        private void lstProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProperty = lstProperties.SelectedIndex;
           // MessageBox.Show(selectedProperty.ToString());

            //call method to populate property txtbxs
            populatePropertyTxbxs();

            // MessageBox.Show("Property no:" + selectedProperty.ToString());
        }

        //EDIT BUTTONS
        private void btnSaveDistrict_Click(object sender, EventArgs e)
        {
            //get new value 
            string newDistrictName = txtDistrictName.Text;
            string newNumNeighbrhds = txtNumNeighbrhdsInDistrict.Text;

            //put back into object
            District tempDistrict = Data.allDistricts[selectedDistrict];

            //put into array 
            tempDistrict.setDistrictName(newDistrictName);
            tempDistrict.setNumNeighbrhds(Convert.ToInt32(newNumNeighbrhds));

            //messagebox to finish
            MessageBox.Show("District details have been saved successfully");
            //show
            showDistrict();
        }

        private void btnSaveNeighbrhd_Click(object sender, EventArgs e)
        {
            //get new value 
            string newNeighbrhdName = txtNeighbourhdName.Text;
            string newNumProperties = txtNumPropertiesInNeighbrhd.Text;

            //which district and which neighbrhd
            Neighbourhood tempNeighbrhd = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd];

            //put into array
            tempNeighbrhd.setNeighbourhdName(newNeighbrhdName);
            tempNeighbrhd.setNumProperties(newNumProperties);

            //messagebox to finish
            MessageBox.Show("Neighbourhood details have been saved successfully");

            //show 
            showNeighbrhd();
        }
        private void btnSaveProperty_Click(object sender, EventArgs e)
        {
            //get new value 
            string newPropertyId = txtPropertyId.Text;
            string newPropertyName = txtPropertyName.Text;
            string newHostId = txtHostId.Text;
            string newHostName = txtHostName.Text;
            string newNumPropertiesForHost = txtNumOfpropertiesForHost.Text;
            string newLat = txtLatitude.Text;
            string newLong = txtLongitude.Text;
            string newRoomType = txtRoomType.Text;
            string newPrice = txtPrice.Text;
            string newMinNumNights = txtMinNumNights.Text;
            string newNumOfAvailability = txtAvailability.Text;

            //which neighbourhood and which property
            Property tempProperty = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties()[selectedProperty];

            //put into array
            tempProperty.setPropertyID(Convert.ToInt32(newPropertyId));
            tempProperty.setPropertyName(newPropertyName);
            tempProperty.setHostId(newHostId);
            tempProperty.setHostName(newHostName);
            tempProperty.setNumPropertiesForHost(newNumPropertiesForHost);
            tempProperty.setLatitude(newLat);
            tempProperty.setLongitude(newLong);
            tempProperty.setRoomType(newRoomType);
            tempProperty.setPrice(newPrice);
            tempProperty.setMinNumNights(newMinNumNights);
            tempProperty.setNumOfAvailability(newNumOfAvailability);

            ////save to file
            //StreamWriter editProperty = new StreamWriter("MiniAirbnb.txt");

            //editProperty.WriteLine(newPropertyId);
            //editProperty.WriteLine(newPropertyName);
            //editProperty.WriteLine(newHostId);
            //editProperty.WriteLine(newHostName);
            //editProperty.WriteLine(newNumPropertiesForHost);
            //editProperty.WriteLine(newLat);
            //editProperty.WriteLine(newLong);
            //editProperty.WriteLine(newRoomType);
            //editProperty.WriteLine(newPrice);
            //editProperty.WriteLine(newMinNumNights);
            //editProperty.WriteLine(newNumOfAvailability);

            ////close file
            //editProperty.Close();

            //messagebox to finish
            MessageBox.Show("Property details have been saved successfully");

            //show
            showProperties();
        }

        //ADD BUTTONS
        private void btnAddDistrict_Click(object sender, EventArgs e)
        {
            //call method to ADD DISTRICT
            addDistrict();
            //call method to SHOW district
            showDistrict();
            //show message box to finish 
            MessageBox.Show("A NEW district was added");

            ////create streamwriter
            //StreamWriter outStream = File.AppendText("MiniAirbnb.txt");

            ////district variables
            //string newDistrictName = txtDistrictName.Text;
            //int newNumNeighbrhds = Convert.ToInt32(txtNumNeighbrhdsInDistrict.Text);

            //Neighbourhood[] theseNeighbourhoods;
            ////get neighbourhood data x3 - while loop

            ////get district data
            //outStream.WriteLine(newDistrictName);
            //outStream.WriteLine(newNumNeighbrhds);

            ////get neighbourhood
            //theseNeighbourhoods = addANeighbrhd(newNumNeighbrhds, outStream);

            ////create district object with that data and those neighbrhds
            //District newDistrict = new District(districtName, Convert.ToString(numNeighbrhds), theseNeighbourhoods);

            ////make DISTRICT array bigger
            //int oldSize = Data.allDistricts.Length;
            //Array.Resize(ref Data.allDistricts, oldSize + 1);

            ////put new District into space create
            //Data.allDistricts[oldSize] = newDistrict;

        }
        private void btnAddNeighbrhd_Click(object sender, EventArgs e)
        {
            //call method to ADD NEIGHBRHD
            addNeighbrhd();
            //call method to SHOW NEIGHBHD
            showNeighbrhd();
            //message box
            MessageBox.Show("A NEW Neighbourhood has been successfully added");
        }
        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            //call ADD PROPERTY METHOD
            addProperty();
            //call method to SHOW PROPERTY
            showProperties();
            //message box
            MessageBox.Show("A NEW Property has been successfully added");
        }

        //ADD DISTRICT METHOD
        private void addDistrict()
        {
            // district variables
            string newDistrictName = txtDistrictName.Text;
            string newNumNeighbrhds = txtNumNeighbrhdsInDistrict.Text;
            Neighbourhood[] newNeighbrhds = new Neighbourhood[0];

            // new district
            District newDistrict = new District(newDistrictName, newNumNeighbrhds, newNeighbrhds);

            //add district to array
            int currentDistrict = Data.allDistricts.Length;
            Array.Resize(ref Data.allDistricts, currentDistrict + 1);
            Data.allDistricts[currentDistrict] = newDistrict;

            //call method write to file
            //districtToFile();
        }

        //ADD NEIGHBOURHD METHOD
        private void addNeighbrhd()
        {
            //neighbrhd variables
            string newNeighbrhdName = txtNeighbourhdName.Text;
            int newNumProperties = Convert.ToInt32(txtNumPropertiesInNeighbrhd.Text);
            Property[] newProperties = new Property[0];

            //create neighbourhood object
            Neighbourhood newNeighbrhd = new Neighbourhood(newNeighbrhdName, newNumProperties, newProperties);

            //temp neighbrhd array
            Neighbourhood[] allNeighbrhds = Data.allDistricts[selectedDistrict].getAllNeighbrhds();

            //add neighbrhd to neighbrhd array
            int currentSize = allNeighbrhds.Length;
            Array.Resize(ref allNeighbrhds, currentSize + 1);
            allNeighbrhds[currentSize] = newNeighbrhd;

            //put into bigger array
            Data.allDistricts[selectedDistrict].setAllNeighbrhds(allNeighbrhds);

            //Call method to write to file
           // NeighbrhdToFile();
            
        }
        //ADD PROPERTY METHOD
        private void addProperty()
        {
            // input from user
            string propertyId = txtPropertyId.Text;
            string propertyName = txtPropertyName.Text;
            string hostId = txtHostId.Text;
            string hostName = txtHostName.Text;
            string numPropertiesForHost = txtNumOfpropertiesForHost.Text;
            string latitude = txtLatitude.Text;
            string longitude = txtLongitude.Text;
            string roomType = txtRoomType.Text;
            string price = txtPrice.Text;
            string minNumNights = txtMinNumNights.Text;
            string numOfAvailabilty = txtAvailability.Text;

            //create property object
            Property newProperty = new Property(propertyId, propertyName, hostId, hostName, numPropertiesForHost, latitude, longitude, roomType, price, minNumNights, numOfAvailabilty);

            //temp property array
            Property[] allProperties = Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties();

            //add property to property array
            int currentSize = allProperties.Length;
            Array.Resize(ref allProperties, currentSize + 1);
            allProperties[currentSize] = newProperty;

            //put into neighbrhd array
            Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].setAllProperties(allProperties);

            //call method to write to file
            //propertyToFile();

        }

        //WRITE TO FILE METHODS
        private void writeToFile()
        {
            //create streamwriter
            StreamWriter OutStream = File.AppendText("MiniAirbnb.txt");

            foreach (District d in Data.allDistricts)
            {
                OutStream.WriteLine(d.getDistrictName());
                OutStream.WriteLine(d.getNumNeighbrhds());
            }

            foreach (Neighbourhood n in Data.allDistricts[selectedDistrict].getAllNeighbrhds())
            {
                OutStream.WriteLine(n.getNeighbourHdName());
                OutStream.WriteLine(n.getNumPropertiesInNeighbourhd());
            }

            foreach (Property p in Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties())
            {
                OutStream.WriteLine(p.getpropertyID());
                OutStream.WriteLine(p.getpropertyName());
                OutStream.WriteLine(p.gethostID());
                OutStream.WriteLine(p.gethostName());
                OutStream.WriteLine(p.getNumPropertiesForHost());
                OutStream.WriteLine(p.getLatitude());
                OutStream.WriteLine(p.getLongitude());
                OutStream.WriteLine(p.getRoomType());
                OutStream.WriteLine(p.getPrice());
                OutStream.WriteLine(p.getMinNumNights());
                OutStream.WriteLine(p.getNumOfAvailability());
            }
            //close filestream
            OutStream.Close();
        }
        private void districtToFile()
        {
            //create streamwriter
            StreamWriter districtStream = File.AppendText("MiniAirbnb.txt");

            foreach (District d in Data.allDistricts)
            {
                districtStream.WriteLine(d.getDistrictName());
                districtStream.WriteLine(d.getNumNeighbrhds());
            }
            //close filestream
            districtStream.Close();
        }
        private void NeighbrhdToFile()
        {
            //create streamwriter
            StreamWriter nbhdStream = File.AppendText("MiniAirbnb.txt");

            foreach (Neighbourhood n in Data.allDistricts[selectedDistrict].getAllNeighbrhds())
            {
                nbhdStream.WriteLine(n.getNeighbourHdName());
                nbhdStream.WriteLine(n.getNumPropertiesInNeighbourhd());
            }
            //close filestream
            nbhdStream.Close();
        }
        private void propertyToFile()
        {
            //create streamwriter
            StreamWriter propertyStream = File.AppendText("MiniAirbnb.txt");

            foreach (Property p in Data.allDistricts[selectedDistrict].getAllNeighbrhds()[selectedNeighbrhd].getAllProperties())
            {
                propertyStream.WriteLine(p.getpropertyID());
                propertyStream.WriteLine(p.getpropertyName());
                propertyStream.WriteLine(p.gethostID());
                propertyStream.WriteLine(p.gethostName());
                propertyStream.WriteLine(p.getNumPropertiesForHost());
                propertyStream.WriteLine(p.getLatitude());
                propertyStream.WriteLine(p.getLongitude());
                propertyStream.WriteLine(p.getRoomType());
                propertyStream.WriteLine(p.getPrice());
                propertyStream.WriteLine(p.getMinNumNights());
                propertyStream.WriteLine(p.getNumOfAvailability());
            }
            //close filestream

        }
        //CANCEL BUTTONS
        private void BtnCancelDistric_Click(object sender, EventArgs e)
        {
            //call method to populate district txtbxs
            populateDistrictTextBxs();
        }
        private void btnCancelNeighbrhd_Click(object sender, EventArgs e)
        {
            //call method to populate neighbrhd txtbxs
            populateNeighbrhdTxbxs();
        }
        private void btnCancelProperty_Click_1(object sender, EventArgs e)
        {
            //call method to populate property txbxs
            populatePropertyTxbxs();
        }

        //OTHER BUTTONS
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = lstDistricts.Items.Count -1; i >= 0; i--)
            {
                if (lstDistricts.Items[i].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    //if the word typed in the search box matches a word in the district lstbx, select it
                    lstDistricts.SetSelected(i, true);
                }
            }

            for (int n = lstNeighbrhd.Items.Count -1; n >= 0; n--)
            {
                if (lstNeighbrhd.Items[n].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    //if the word typed in the search box matches a word in the neighbrhd lstbx, select it
                    lstNeighbrhd.SetSelected(n, true);
                }
            }

            for (int p = lstProperties.Items.Count -1; p >= 0; p--)
            {
                if (lstProperties.Items[p].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    //if the word typed in the search box matches a word in the properties lstbx, select it
                    lstProperties.SetSelected(p, true);
                }
            }
        }

        private void BtnDeleteProperty_Click(object sender, EventArgs e)
        {

        }
    }
}

