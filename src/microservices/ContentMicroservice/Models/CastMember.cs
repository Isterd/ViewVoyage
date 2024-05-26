using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace ContentMicroservice.Models;

public class CastMember
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public BigInteger Id { get; set; }
    public string EmployeeFullName { get; set; } = null!;
    public string RoleName { get; set; } = null!;
    public Content Content { get; set; } = null!;
}