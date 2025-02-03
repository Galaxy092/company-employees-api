using System.Runtime.Serialization;

namespace Shared.Dtos
{
    [Serializable]
    [DataContract]
    public record CompanyDto
    {
        [DataMember(Name = "Id")]
        public Guid Id { get; init; }

        [DataMember(Name = "Name")]
        public string? Name { get; init; }

        [DataMember(Name = "FullAddress")]
        public string? FullAddress { get; init; }
    }
}
