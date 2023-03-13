using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Stages
    {
        public string StageId { get; set; }
        public string StageName { get; set; }
        public string Shortlistings { get; set; }
        public ICollection<InterviewQuestions> VideoInterview { get; set; }
    }
    public class InterviewQuestions
    {
        [Key]
        public string InterviewId { get; set; }
        public string VideoUrl { get; set; }
        public string Statement { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
