using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace travelapp1.Models
{
    public class COMMENT
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public int rating { get; set; }
        public Nullable<int> PlaceId { get; set; }
        public Nullable<int> UserId { get; set; }

        public virtual PlacesToVisit PlacesToVisit { get; set; }
        public virtual User User { get; set; }
    }
}