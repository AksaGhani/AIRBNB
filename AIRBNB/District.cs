using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRBNB
{
    class District
    {
        private string districtName;
        private int numNeighbourhoods;
        private Neighbourhood[] allNeighbrhds = null;

        //constructor: districtName, numNeighbourhds, allNeighbrhds

        public District(string theDistrictName, string theNumNeighbrhds, Neighbourhood[] allTheNeighbourhds)
        {
            districtName = theDistrictName;
            numNeighbourhoods = Convert.ToInt32(theNumNeighbrhds);
            allNeighbrhds = allTheNeighbourhds;
        }//end constructor

        //all class getters
        public string getDistrictName()
        {
            return districtName;
        }
        public int getNumNeighbrhds()
        {
            return numNeighbourhoods;
        }
        public Neighbourhood[] getAllNeighbrhds()
        {
            return allNeighbrhds;
        }

        //all class setters
        public void setDistrictName(string inDistrictName)
        {
            districtName = inDistrictName;
        }
        public void setNumNeighbrhds(int inNumNeighbrhds)
        {
            try
            {
                numNeighbourhoods = Convert.ToInt32(inNumNeighbrhds);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message +
                    "Please enter a valid Number of Neighbourhoods for this District");
            }
        }
        public void setAllNeighbrhds(Neighbourhood [] inAllNeighbrhds)
        {
            allNeighbrhds = inAllNeighbrhds;
        }//end of District Class
    }
}
