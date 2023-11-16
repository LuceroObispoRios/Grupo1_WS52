namespace CargaSinEstres.API.CargaSinEstres.Resources;

public class UpdateCommentResource
{
    public IList<CommentUpdatedResource> Comments { get; set; } = new List<CommentUpdatedResource>();
}