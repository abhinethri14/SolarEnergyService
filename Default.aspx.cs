using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client();  // Create a client proxy
        SolarResult.Visible = true;
    
        try
        {
            // convert whether latitude and longitude values to int
            int latitude = Convert.ToInt32(LatitudeInput.Text);
            int longitude = Convert.ToInt32(LongitudeInput.Text);

            // Verify latitude and longitude values
            if(latitude < -90 || latitude > 89) 
            {
                if (longitude < -180 || longitude > 179)
                    SolarResult.Text = "Both Latitude and logitude are invalid";
                else
                    SolarResult.Text = "Latitude is invalid";
            }

            else if (longitude<-180 || longitude>179)
            {
                SolarResult.Text = "Longitude is invalid";
                LatitudeInput.Text = latitude.ToString();

            }
            else
            {
                double res = myClient.SolarIntensity(latitude, longitude);  // Call the solarIntensity method
                // Validate
                if (res.Equals(-101.00) )
                    SolarResult.Text = "Error in processing";
                else
                    SolarResult.Text = "Solar Intensity is " + res.ToString() + " !!!";
            }
        }
        catch (Exception e1)
        {
            SolarResult.Text = e1.Message.ToString();
        }

    }
}