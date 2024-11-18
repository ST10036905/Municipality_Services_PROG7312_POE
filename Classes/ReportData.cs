using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mayra Selemane
//ST10036905
//PROG7312 POE
//Class used to hold report data

namespace Municipality_Services_PROG7321_POE.Classes
{
    public class ReportData
    {
        /// <summary>
        /// declaring data fields to hold and store reporting data.
        /// </summary>
        public string RequestID { get;set; }  //p3, identifier that will be used to track the service request status  
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Media { get; set; }
        public DateTime SubmissionDate { get;set; }
        public string Status { get; set; }  //p3, status of the service request


        /// <summary>
        /// default constructor.
        /// </summary>
        public ReportData() 
        {

        } //__________________________________________________________________________________________________________


        /// <summary>
        /// generating a parameterised constructor.
        /// </summary>
        /// <param name="requestID"></param>
        /// <param name="location"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="media"></param>
        /// <param name="submissionDate"></param>
        /// <param name="status"></param>
        public ReportData(string requestID, string location, string category, string description, string media, DateTime submissionDate, string status)
        {
            RequestID = requestID;
            Location = location;
            Category = category;
            Description = description;
            Media = media;
            SubmissionDate = submissionDate;
            Status = status;
        } //__________________________________________________________________________________________________________

        /// <summary>
        /// generating a second parameterised constructor to be used in service requests.
        /// </summary>
        /// <param name="requestID"></param>
        /// <param name="location"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="submissionDate"></param>
        /// <param name="status"></param>
        public ReportData(string requestID, string location, string category, string description, DateTime submissionDate, string status)
        {
            RequestID = requestID;
            Location = location;
            Category = category;
            Description = description;
            SubmissionDate = submissionDate;
            Status = status;
        } //__________________________________________________________________________________________________________

    }//_________________________________________________oooooEND OF FILEooooooo___________________________________________
}//_____________________________________________________________________________________________________________________________
