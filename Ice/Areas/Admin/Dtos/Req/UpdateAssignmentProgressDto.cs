using Ice.Enums;

namespace Ice.Areas.Admin.Dtos.Req;

public class UpdateAssignmentProgressDto
{
    public required long StudentGroupId { get; init; }

    public required long AssignmentId { get; init; }

    public required AssignmentProgress Status { get; init; }
}