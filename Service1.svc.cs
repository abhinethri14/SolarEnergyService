using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Hosting;

namespace SolarEnergyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double SolarIntensity(int latitude, int longitude)
        { 
        // These array will help to go to the exact line where information corresponding to given latitude and longitude are present
        int[] array_lat = new int[] { -90, -89, -88, -87, -86, -85, -84, -83, -82, -81, -80, -79, -78, -77, -76, -75, -74, -73, -72, -71, -70, -69, -68, -67, -66, -65, -64, -63, -62, -61, -60, -59, -58, -57, -56, -55, -54, -53, -52, -51, -50, -49, -48, -47, -46, -45, -44, -43, -42, -41, -40, -39, -38, -37, -36, -35, -34, -33, -32, -31, -30, -29, -28, -27, -26, -25, -24, -23, -22, -21, -20, -19, -18, -17, -16, -15, -14, -13, -12, -11, -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89 };
        int[] array_long = new int[] { -180, -179, -178, -177, -176, -175, -174, -173, -172, -171, -170, -169, -168, -167, -166, -165, -164, -163, -162, -161, -160, -159, -158, -157, -156, -155, -154, -153, -152, -151, -150, -149, -148, -147, -146, -145, -144, -143, -142, -141, -140, -139, -138, -137, -136, -135, -134, -133, -132, -131, -130, -129, -128, -127, -126, -125, -124, -123, -122, -121, -120, -119, -118, -117, -116, -115, -114, -113, -112, -111, -110, -109, -108, -107, -106, -105, -104, -103, -102, -101, -100, -99, -98, -97, -96, -95, -94, -93, -92, -91, -90, -89, -88, -87, -86, -85, -84, -83, -82, -81, -80, -79, -78, -77, -76, -75, -74, -73, -72, -71, -70, -69, -68, -67, -66, -65, -64, -63, -62, -61, -60, -59, -58, -57, -56, -55, -54, -53, -52, -51, -50, -49, -48, -47, -46, -45, -44, -43, -42, -41, -40, -39, -38, -37, -36, -35, -34, -33, -32, -31, -30, -29, -28, -27, -26, -25, -24, -23, -22, -21, -20, -19, -18, -17, -16, -15, -14, -13, -12, -11, -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179 };

            // Formula to the line number
        int value = 360 * Array.IndexOf(array_lat,latitude) + Array.IndexOf(array_long,longitude);

        String line;
        double sum = 0;
            try
            {

                //Pass the file name having solar intensity data under App_Data
                // Data is obtained from https://eosweb.larc.nasa.gov/sse/global/text/dy_cos_sza . 
                //. Following comment as more info

             /*   NASA Surface meteorology and Solar Energy(SSE) Release 6 Data Set(April 2006)
Parameter: Daylight Average Of Hourly Cosine Solar Zenith Angles(dimensionless)
Notes: 1) SSE Methodology &Accuracy sections online
       2) na == value not available; see Methodology
       3) Solar geometry computed for the "monthly average day", which is the
          day (in the month) whose declination is closest to the average
          declination for that month[S.A.Klein, Calculation of monthly average
          insolation on tilted surfaces, Solar Energy, 19, 325 - 329, 1977].
Internet: http://earth-www.larc.nasa.gov/solar/
Created: October 11, 2006
Lat Lon  Jan  Feb  Mar Apr May Jun Jul Aug Sep Oct Nov Dec  */


                //Read the data from reuired line
                string myFile = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "Solar_test.txt");
                line = File.ReadLines(myFile).Skip(value).Take(1).First();
                // Find the sum of intensities from jan to feb
                    String[] res = line.Split(' ');
                     Int32 lat = Int32.Parse(res[0]);
                    Int32 lon = Int32.Parse(res[1]);

              //  Solar intensity  values are extracted for all the 12 months and average is taken
                        if (res[2].Equals("na"))
                        {
                            res[2] = "0";
                        }
                        sum = sum + Convert.ToDouble(res[2]);
                        if (res[3].Equals("na"))
                        {
                            res[3] = "0";

                        }
                        sum = sum + Convert.ToDouble(res[3]);
                        if (res[4].Equals("na"))
                        {
                            res[4] = "0";

                        }
                        sum = sum + Convert.ToDouble(res[4]);
                        if (res[5].Equals("na"))
                        {
                            res[5] = "0";

                        }
                        sum = sum + Convert.ToDouble(res[5]);
                        if (res[6].Equals("na"))
                        {
                            res[6] = "0";

                        }
                        sum = sum + Convert.ToDouble(res[6]);
                        if (res[7].Equals("na"))
                        {
                            res[7] = "0";

                        }
                        sum = sum + Convert.ToDouble(res[7]);
                        if (res[8].Equals("na"))
                        {
                            res[8] = "0";

                        }
                        sum = sum + Convert.ToDouble(res[8]);
                        if (res[9].Equals("na"))
                        {
                            res[9] = "0";

                        }
                        sum = sum + Convert.ToDouble(res[9]);
                        if (res[10].Equals("na"))
                        {
                            res[10] = "0";

                        }
                        sum = sum + Convert.ToDouble(res[10]);
                        if (res[11].Equals("na"))
                        {
                            res[11] = "0";

                        }
                        sum = sum + Convert.ToDouble(res[11]);
                        if (res[12].Equals("na"))
                        {
                            res[12] = "0";

                        }
                        sum = sum + Convert.ToDouble(res[12]);
                        if (res[13].Equals("na"))
                        {
                            res[13] = "0";

                        }
                        sum = sum + Convert.ToDouble(res[13]);

                        double res1 = sum / 12;

                return res1;

                    }
       
            catch (Exception e)
            {
                return -101.00;
            }
    }
        /* public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        } */
    }
}
