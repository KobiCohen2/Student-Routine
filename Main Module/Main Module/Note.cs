using System;

namespace Main_Module
{
    [Serializable]
    public class Note
    {
        private string text;

        //Empty Constructor
        public Note()
        {
            this.text = "~";//empty string as default
        }//end Constructor

        //Constructor
        public Note(string text)
        {
            this.text = text;
        }//end Constructor

        #region Property
        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
            }
        }
        #endregion Property
    }//end class
}//end namespace
