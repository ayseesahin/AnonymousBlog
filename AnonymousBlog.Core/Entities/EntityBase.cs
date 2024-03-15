﻿using System;
namespace AnonymousBlog.Core.Entities
{
    public abstract class EntityBase : IEntityBase
    {

        /*public EntityBase()
        {
            Id= Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }*/

        public virtual Guid Id { get; set; } = Guid.NewGuid();
        public virtual string CreatedBy { get; set; }
        public virtual string? ModifiedBy { get; set; } //? -> nullable olduklarını söylüyoruz, ilk oluşturunca direk bunlar yapılmaz çünkü
        public virtual string? DeletedBy { get; set; }

        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; }
        public virtual DateTime? DeletedDate { get; set; }

        public virtual bool IsDeleted { get; set; } = false;
    }
}
