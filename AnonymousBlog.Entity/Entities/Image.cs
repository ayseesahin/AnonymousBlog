﻿using System;
using AnonymousBlog.Core.Entities;

namespace AnonymousBlog.Entity.Entities
{
	public class Image : EntityBase
	{
        public string FileName { get; set; }
        public string FileType { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
