namespace AnonymousBlog.Core.Entities
{
    public interface IEntityBase
    {
        Guid Id { get; set; }
        string CreatedBy { get; set; }
        string? ModifiedBy { get; set; }
        string? DeletedBy { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
        DateTime? DeletedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}