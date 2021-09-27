//@CodeCopy
//MdStart
namespace SnQTradingCompany.Logic.Modules.Exception
{
    public enum ErrorType : int
    {
        InitAppAccess,
        InvalidAccount,
        NotLogedIn,
        NotAuthorized,
        InvalidToken,
        InvalidId,
        InvalidPageSize,

        InvalidSessionToken,
        InvalidJsonWebToken,
        AuthorizationTimeOut,
        InvalidIdentityName,
        InvalidEmail,
        InvalidPassword,

        InvalidEntityInsert,
        InvalidEntityUpdate,
        InvalidEntityContent,

        InvalidControllerType,
    }
}
//MdEnd
