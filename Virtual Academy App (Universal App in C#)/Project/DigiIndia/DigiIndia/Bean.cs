using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiIndia
{
    public static class Bean
    {
        static Bean() { classsel = "class1"; course = "maths"; chapter = "chapter1"; chapterCode = "defaultchapter";
            chapterName = "default";
            classCode = "default";
            SubjectCode = "default";
            videoName = "default";
            videoDesc = "default";
            videoTutor = "default";
        }
        public static string classsel { get;  set; }
        public static string course { get;  set; }
        public static string chapter { get;  set; }
        public static string chapterid { get;  set; }
        public static string chapterName { get;  set; }
        public static string chapterCode { get;  set; }
        public static string classCode { get;  set; }
        public static string className { get;  set; }
        public static string SubjectName { get;  set; }
        public static string SubjectCode { get;  set; }
        public static string videoName { get;  set; }
        public static string videoURL { get; set; }
        public static string videoDesc { get; set; }
        public static string videoTutor { get; set; }



        public static void SetClassel(string locclass)
        {
            classsel = locclass;
        }

        public static void SetCourse(string locclass)
        {
            course = locclass;
        }

        public static void SetChapter(string locclass)
        {
            chapter = locclass;
        }
        public static void SetChapterName(string locclass)
        {
            chapterName = locclass;
        }
        public static void SetChapterCode(string locclass)
        {
            chapterCode = locclass;
        }
        public static void SetClassCode(string locclass)
        {
            classCode = locclass;
        }
    }
}
