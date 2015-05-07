﻿namespace MyWebSite.DataAccess
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Tag
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }

        [StringLength(50)]
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual IList<Post> Posts { get; set; }
    }
}