using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynaar_GUI.Classes
{
    internal class Story
    {
        #region private variable

        private int id;
        private string storyLine;

        #endregion

        #region Constructeur

        //constructor
        public Story(string storyLine, int id)
        {
            this.storyLine = storyLine;
            this.id = id;
        }

        #endregion

        #region accesseur

        public string StoryLine { get => storyLine; set => storyLine = value; }
        public int Id { get => id; set => id = value; }

        #endregion

        #region Function

        #endregion

        #region methods


        #endregion
    }
}