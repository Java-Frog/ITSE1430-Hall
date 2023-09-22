/*
 * ITSE 1430
 * Fall 2023
 */
using System.Reflection.Metadata.Ecma335;

namespace MovieLibrary
{
    /// <summary>Represents a movie.</summary>
    /// <remarks>
    /// Paragraphs of descriptions.
    /// </remarks>
    public class Movie
    {
        //Fields - data
        /// <summary>Title of movie.</summary>
        private string _title;
        private string _description = "";
        private string _genre = "";
        private string _rating = "";
        private int _runLength;

        //Properties - Data with Functionality
        ///<summary> Gets or sets the title of movie</summary>
        public string Title
        {
            get {
                if(String.IsNullOrEmpty(_title))
                    return "";
                
                return _title;
            }
            set {
                if (value != null)
                    value= value.Trim();

                _title = value;
            }
        }
        public string Description
        {
            get {
                if (String.IsNullOrEmpty(_description))
                    return "";

                return _description;
            }
            set { _description = value; }
        }
        public string Genre
        {
            get {
                if (String.IsNullOrEmpty(_genre))
                    return "";

                return _genre; 
            }
            set { _genre = value; }
        }
        public string Rating
        {
            get {
                if (String.IsNullOrEmpty(_rating))
                    return "";

                return _rating; 
            }
            set { _rating = value; }
        }
        public int RunLength { get; set}

        public int ReleaseYear { get; set; } = 1900;
      
        public bool IsBlackAndWhite { get; set; }


        //Calculated Property
        public bool NeedsIntermission;
        {
            //RunLength > 150min
            get 
            {
                return _runLength < 150;
            }
        }

        //_______________________________________
        /// <summary> Download Metadata from Internet.</summary>
        /// <remarks>
        /// Searches IMDB and TheTVDB.com
        /// </remarks>
        private void DownloadMetaData ()
        { }

        /// <summary> Validates the Movie Instance</summary>
        /// <returns> Error message if invalid, otherwise emptry string. </returns>
        public string Validate()
        {
            //Title Required
            if (String.IsNullOrEmpty(_title))
                return "Title is required.";

            //Release Year >=1900
            if (ReleaseYear < 1900)
                return "Release year must be >=1900";
            //Length >= 0
            if (RunLength <= 0)
                return "Length must be <=0";
            //TODO: Rating is in a list
            //

            //If ReleaseYear < 1940 then is IsBlackAndWhite must be true;
            if (ReleaseYear < 1940 && !IsBlackAndWhite)
                return "Movies before 1940 must be black and white.";

            //Valid Return
            return "";
        }
    }