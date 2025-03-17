using System.ComponentModel.DataAnnotations;

namespace WaterProject.API.Data;

public class Project
{
    [Key]
    public int ProjectID { get; set; }
    
    [Required]
    public string ProjectName { get; set; }
    public string? ProjectType { get; set; }
    public string? ProjectRegionalprogram { get; set; }
    public int? ProjectImpact { get; set; }
    public string? ProjectPhase  { get; set; }
    public string? ProjectFunctionalityStatus { get; set; }
}