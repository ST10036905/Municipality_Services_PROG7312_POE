using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mayra Selemane
//ST10036905
//PROG7321 POE PART 1

namespace Municipality_Services_PROG7321_POE.Classes
{
    public class ReportData
    {
        /// <summary>
        /// declaring data fields to hold and store reporting data.
        /// </summary>
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Media { get; set; }


        /// <summary>
        /// default constructor.
        /// </summary>
        public ReportData() 
        {
        }


        /// <summary>
        /// generating a parameterised constructor.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="media"></param>
        public ReportData(string location,string category, string description, string media)
        {
            Location = location;
            Category = category;
            Description = description;
            Media = media;
        }//__________________________________________________________________________________________________________

    }//_________________________________________________oooooEND OF FILEooooooo___________________________________________
}//_____________________________________________________________________________________________________________________________
