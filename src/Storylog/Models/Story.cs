using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storylog.Models
{
    public class Story
    {
        public long Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int ExternalId { get; set; }
        public int Priority { get; set; }
        public StoryStatus Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public long ProjectId { get; set; }

        [ForeignKey("ProjectId")]
        public Project Project { get; set; }
    }

    public enum StoryStatus
    {
        Ready,
        InProgress,
        Done
    }
}
