namespace MyWebSite.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [StringLength(50)]
        public virtual string UrlSlug { get; set; }

        [StringLength(50)]
        public virtual string Title { get; set; }

        [StringLength(50)]
        public virtual string ShortDescription { get; set; }

        [StringLength(150)]
        public virtual string Description { get; set; }

        public virtual string Content { get; set; }

        public virtual bool Published { get; set; }

        public virtual DateTime PostedOn { get; set; }

        public virtual DateTime? Modified { get; set; }

        public virtual Category Category { get; set; }

        public virtual IList<Tag> Tags { get; set; }
    }
}
