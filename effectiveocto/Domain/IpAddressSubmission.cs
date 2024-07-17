using System.ComponentModel.DataAnnotations;

namespace EffectiveOcto.Domain;

public class IpAddressSubmission
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string IpAddress { get; set; }

    [Required]
    public string User { get; set; }

    public DateTime CreateDate { get; set; }

    [Required]
    public string Source { get; set; }
}
