using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatingGame.Model
{
    public class DatingAnswers
    {
        public string Name { 
            get; 
            set; 
        }
        public string Question { 
            get; 
            set;
        }
        public DateTime answerTime { 
            get; 
            set; 
        }
        public string formDisplay { 
            get; 
            set; 
        }
    }

    public static class DataListAnswer
    {
        public static List<DatingAnswers> lstAnswer { 
            get; 
            set; 
        }
    }
}

//It is class which store the list of answers and track details