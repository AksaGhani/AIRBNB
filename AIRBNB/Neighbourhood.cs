using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRBNB
{
    class Neighbourhood
    {
        private string neighbourhdName;
        private int numPropertiesInNeighbourhd;
        private Property[] allProperties = null;

        //constructor: neighbourhdName, numPropertiesInNeighbourhd, property [] allProperties
        public Neighbourhood(string theNeighbourHdName, int theNumPropertiesInNeighbourhd, Property[] allTheProperties)
        {
            neighbourhdName = theNeighbourHdName;
            numPropertiesInNeighbourhd = theNumPropertiesInNeighbourhd;
            allProperties = allTheProperties;
        }//end constructor

        //all class GETTERS
        public string getNeighbourHdName()
        {
            return neighbourhdName;
        }
        public int getNumPropertiesInNeighbourhd()
        {
            return numPropertiesInNeighbourhd;
        }
        public Property[] getAllProperties()
        {
            return allProperties;
        }
        //all class SETTERS
        public void setNeighbourhdName(string inName)
        {
            neighbourhdName = inName;
        }
        public void setNumProperties(string inNumProperties)
        {
            try
            {
                numPropertiesInNeighbourhd = Convert.ToInt32(inNumProperties);
            }
            catch (FormatException e)
            {
                System.Windows.Forms.MessageBox.Show("ERROR:" + e.Message +
                    "Please enter a valid Number of properties for this Neighbourhood");
            }
        }
        public void setAllProperties(Property[] inAllProperties)
        {
            allProperties = inAllProperties;
        }
    }//end of neighbourhood class
}
