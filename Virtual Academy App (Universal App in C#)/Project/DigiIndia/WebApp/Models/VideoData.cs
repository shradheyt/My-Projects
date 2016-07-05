using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class VideoData
    {
        [Key]
        public int Id { get; set; }

      //  public string classsel { get; set; }
      //  public string course { get; set; }
     //   public string chapter { get; set; }
     //   public string chapterid { get; set; }
    //    public string chapterName { get; set; }
        public string ChapCode { get; set; }
        public string classCode { get; set; }
      //  public string className { get; set; }
      //  public string SubjectName { get; set; }
        public string SubjectCode { get; set; }

        public string videoName { get; set; }
        public string videoURL { get; set; }
        public string videoDesc { get; set; }
        public string videoTutor { get; set; }
    }
}