namespace Entities.Exceptions;

public class RefreshTokenBadRequest : BadRequestException
{
    public RefreshTokenBadRequest() 
        : base("Invalid Client request. The tokenDto has some invalid values.")
    {
    }
}
