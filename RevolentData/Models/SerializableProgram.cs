using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevolentData.Models
{
    public class SerializableProgram
    {
        public SerializableProgram(programsProgram p)
        {

            foreach(var prop in p.GetType().GetProperties().Where(t=>t.CanWrite))
            {
                if(prop.Name!="Id")
                {
                    this.GetType().GetProperty(prop.Name).SetValue(this,prop.GetValue(p));
                }
            }
        }

        private titleDescType[] titlesField;

        private titleDescType[] descriptionsField;

        private castTypeMember[] castField;

        private crewTypeMember[] crewField;

        private string runTimeField;

        private string progTypeField;

        private programsProgramHoliday holidayField;

        private string[] countriesField;

        private awardType[] awardsField;

        private programsProgramGenre[] genresField;

        private ratingType ratingsField;

        private System.DateTime origAirDateField;

        private bool origAirDateFieldSpecified;

        private string colorCodeField;

        private programsProgramMovieInfo movieInfoField;

        private programsProgramEpisodeInfo episodeInfoField;

        private programsProgramSportsInfo sportsInfoField;

        private assetType[] imagesField;

        private string animationField;

        private string origAudioLangField;

        private string[] keywordsField;

        private string sourceTypeField;

        private string tMSIdField;

        private string altFilmIdField;

        private string rootIdField;

        private string versionIdField;

        private string connectorIdField;

        private string seasonIdField;

        private string seriesIdField;


        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("title", IsNullable = false)]
        public titleDescType[] titles
        {
            get
            {
                return this.titlesField;
            }
            set
            {
                this.titlesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("desc", IsNullable = false)]
        public titleDescType[] descriptions
        {
            get
            {
                return this.descriptionsField;
            }
            set
            {
                this.descriptionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("member", IsNullable = false)]
        public castTypeMember[] cast
        {
            get
            {
                return this.castField;
            }
            set
            {
                this.castField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("member", IsNullable = false)]
        public crewTypeMember[] crew
        {
            get
            {
                return this.crewField;
            }
            set
            {
                this.crewField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string runTime
        {
            get
            {
                return this.runTimeField;
            }
            set
            {
                this.runTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string progType
        {
            get
            {
                return this.progTypeField;
            }
            set
            {
                this.progTypeField = value;
            }
        }

        /// <remarks/>
        public programsProgramHoliday holiday
        {
            get
            {
                return this.holidayField;
            }
            set
            {
                this.holidayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("country", DataType = "token", IsNullable = false)]
        public string[] countries
        {
            get
            {
                return this.countriesField;
            }
            set
            {
                this.countriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("award", IsNullable = false)]
        public awardType[] awards
        {
            get
            {
                return this.awardsField;
            }
            set
            {
                this.awardsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("genre", IsNullable = false)]
        public programsProgramGenre[] genres
        {
            get
            {
                return this.genresField;
            }
            set
            {
                this.genresField = value;
            }
        }

        /// <remarks/>
        public ratingType ratings
        {
            get
            {
                return this.ratingsField;
            }
            set
            {
                this.ratingsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime origAirDate
        {
            get
            {
                return this.origAirDateField;
            }
            set
            {
                this.origAirDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool origAirDateSpecified
        {
            get
            {
                return this.origAirDateFieldSpecified;
            }
            set
            {
                this.origAirDateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string colorCode
        {
            get
            {
                return this.colorCodeField;
            }
            set
            {
                this.colorCodeField = value;
            }
        }

        /// <remarks/>
        public programsProgramMovieInfo movieInfo
        {
            get
            {
                return this.movieInfoField;
            }
            set
            {
                this.movieInfoField = value;
            }
        }

        /// <remarks/>
        public programsProgramEpisodeInfo episodeInfo
        {
            get
            {
                return this.episodeInfoField;
            }
            set
            {
                this.episodeInfoField = value;
            }
        }

        /// <remarks/>
        public programsProgramSportsInfo sportsInfo
        {
            get
            {
                return this.sportsInfoField;
            }
            set
            {
                this.sportsInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("image", IsNullable = false)]
        public assetType[] images
        {
            get
            {
                return this.imagesField;
            }
            set
            {
                this.imagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string animation
        {
            get
            {
                return this.animationField;
            }
            set
            {
                this.animationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "language")]
        public string origAudioLang
        {
            get
            {
                return this.origAudioLangField;
            }
            set
            {
                this.origAudioLangField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("keyword", DataType = "token", IsNullable = false)]
        public string[] keywords
        {
            get
            {
                return this.keywordsField;
            }
            set
            {
                this.keywordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string sourceType
        {
            get
            {
                return this.sourceTypeField;
            }
            set
            {
                this.sourceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string TMSId
        {
            get
            {
                return this.tMSIdField;
            }
            set
            {
                this.tMSIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string altFilmId
        {
            get
            {
                return this.altFilmIdField;
            }
            set
            {
                this.altFilmIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string rootId
        {
            get
            {
                return this.rootIdField;
            }
            set
            {
                this.rootIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string versionId
        {
            get
            {
                return this.versionIdField;
            }
            set
            {
                this.versionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string connectorId
        {
            get
            {
                return this.connectorIdField;
            }
            set
            {
                this.connectorIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string seasonId
        {
            get
            {
                return this.seasonIdField;
            }
            set
            {
                this.seasonIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string seriesId
        {
            get
            {
                return this.seriesIdField;
            }
            set
            {
                this.seriesIdField = value;
            }
        }
    }
}
