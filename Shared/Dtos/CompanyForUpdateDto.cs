namespace Shared.Dtos
{
    public record CompanyForUpdateDto: CompanyForManipulationDTO
    {
        public IEnumerable<EmployeeForCreationDto>? Employees { get; init; }
    }
}
