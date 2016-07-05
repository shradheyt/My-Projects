using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoList.Models
{
    public class VideoData
    {
        [Key] 
        public int VideoID
        {
            get;
            set;
        }
        public string VideoURL
        {
            get;
            set;
        }
        public string ChapCode
        {
            get;
            set;
        }
        public string SubCode
        {
            get;
            set;
        }
        public string ClassCode
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public string Desc
        {
            get;
            set;
        }
        public string Trainer
        {
            get;
            set;
        }

    }
}