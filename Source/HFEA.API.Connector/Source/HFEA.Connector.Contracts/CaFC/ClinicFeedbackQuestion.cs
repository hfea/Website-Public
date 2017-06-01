using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFEA.Connector.Contracts.CaFC
{
    public class ClinicFeedbackQuestion
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public double OverallScore { get; set; }
        public int NumberOfReviews { get; set; }
        public string ScoreValue1Text { get; set; }
        public int ScoreValue1 { get; set; }
        public string ScoreValue2Text { get; set; }
        public int ScoreValue2 { get; set; }
        public string ScoreValue3Text { get; set; }
        public int ScoreValue3 { get; set; }
        public string ScoreValue4Text { get; set; }
        public int ScoreValue4 { get; set; }
        public string ScoreValue5Text { get; set; }
        public int ScoreValue5 { get; set; }
        public string AdditionalText { get; set; }
        public string QuestionType { get; set; }
    }
}
