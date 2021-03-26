using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIRBNB
{
    class Property
    {
        private int propertyId;
        private string propertyName;
        private int hostId;
        private string hostName;
        private int numPropertiesForHost;
        private double latitude;
        private double longitude;
        private string roomType;
        private int price;
        private int minNumNights;
        private int numOfAvailabilty;

        //constructor (x11): 
        //propertyID, propertyName, hostID, hostName, numPropertiesForHost, latitude, longitude, roomType, price, minNumOfNights, numfAvailability
        public Property(string aPropertyID, string aPropertyName, string aHostID, string aHostName, string aNumPropertiesForHost, string aLatitude, string aLongitude, string aRoomType, string aPrice, string aMinNumNights, string aNumOfAvailablity)
        {
            propertyId = Convert.ToInt32(aPropertyID);
            propertyName = aPropertyName;
            hostId = Convert.ToInt32(aHostID);
            hostName = aHostName;
            numPropertiesForHost = Convert.ToInt32(aNumPropertiesForHost);
            latitude = Convert.ToDouble(aLatitude);
            longitude = Convert.ToDouble(aLongitude);
            roomType = aRoomType;
            price = Convert.ToInt32(aPrice);
            minNumNights = Convert.ToInt32(aMinNumNights);
            numOfAvailabilty = Convert.ToInt32(aNumOfAvailablity);
        }//end constructor


        //GETTERS
        public int getpropertyID()
        {
            return propertyId;
        }
        public string getpropertyName()
        {
            return propertyName;
        }
        public int gethostID()
        {
            return hostId;
        }
        public string gethostName()
        {
            return hostName;
        }
        public int getNumPropertiesForHost()
        {
            return numPropertiesForHost;
        }
        public double getLatitude()
        {
            return latitude;
        }
        public double getLongitude()
        {
            return longitude;
        }
        public string getRoomType()
        {
            return roomType;
        }
        public int getPrice()
        {
            return price;
        }
        public int getMinNumNights()
        {
            return minNumNights;
        }
        public int getNumOfAvailability()
        {
            return numOfAvailabilty;
        }

        //SETTERS
        public void setPropertyID(int inPropertyID)
        {
            propertyId = Convert.ToInt32(inPropertyID);
        }
        public void setPropertyName(string inPropertyName)
        {
            propertyName = inPropertyName;
        }
        public void setHostId(string inHostId)
        {
            hostId = Convert.ToInt32(inHostId);
        }
        public void setHostName(string inHostName)
        {
            hostName = inHostName;
        }
        public void setNumPropertiesForHost(string inNumPropertiesForHost)
        {
            numPropertiesForHost = Convert.ToInt32(inNumPropertiesForHost);              
        }
        public void setLatitude(string inLatitude)
        {
            latitude = Convert.ToDouble(inLatitude);
        }
        public void setLongitude(string inLongitude)
        {
            longitude = Convert.ToDouble(inLongitude);          
        }
        public void setRoomType(string inRoomType)
        {
            roomType = inRoomType;
        }
        public void setPrice(string inPrice)
        {
            price = Convert.ToInt32(inPrice);
        }
        public void setMinNumNights(string inMinNumNights)
        {
            minNumNights = Convert.ToInt32(inMinNumNights);
        }
        public void setNumOfAvailability(string inNumOfAvailable)
        {
            numOfAvailabilty = Convert.ToInt32(inNumOfAvailable);
        }
    }//end of Property class
}
    

