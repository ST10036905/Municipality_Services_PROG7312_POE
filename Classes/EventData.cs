using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mayra Selemane
//ST10036905
//PROG7321 POE PART 
//Class used to store event data

namespace Municipality_Services_PROG7321_POE
{
    public class EventData
    {

            /// <summary>
            /// generating public getters and setters.
            /// </summary>
            public string Name { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public DateTime Time { get; set; }
            public Image Media { get; set; }
            public string Location { get; set; }


            /// <summary>
            /// New property to store the formatted time
            /// </summary>
            public string FormattedTime { get;set; }

            /// <summary>
            /// default constructor.
            /// </summary>
            public EventData() 
             {
             }

            /// <summary>
            /// parameterised constructor.
            /// </summary>
            /// <param name="name"></param>
            /// <param name="category"></param>
            /// <param name="description"></param>
            /// <param name="time"></param>
            /// <param name="media"></param>
            /// <param name="location"></param>
             public EventData(string name, string category, string description, DateTime time, Image media, string location)
             {
                Name = name;
                Category = category;
                Description = description;
                Time = time;
                Media = media;
                Location = location;
             }//__________________________________________________________________________________________________________


            /// <summary>
            /// parameterised constructor. 
            /// </summary>
            /// <param name="name"></param>
            /// <param name="category"></param>
            /// <param name="description"></param>
            /// <param name="time"></param>
            /// <param name="media"></param>
            /// <param name="location"></param>
            /// <param name="formattedTime"></param>
            public EventData(string name, string category, string description, DateTime time, Image media, string location, string formattedTime)
            {
                Name = name;
                Category = category;
                Description = description;
                Time = time;
                Media = media;
                Location = location;
                FormattedTime = formattedTime;
            }
    }//____________________________________End of File_______________________________________________________
}//__________________________________________________________________________________________________________

