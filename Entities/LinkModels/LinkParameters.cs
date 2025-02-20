using Microsoft.AspNetCore.Http;
using Shared.RequestFolders;

namespace Entities.LinkModels
{
    public record LinkParameters(EmployeeParameters EmployeeParameters, HttpContext Context);
}
