using System.ComponentModel.DataAnnotations;

namespace BlazorLocalization.Models
{
    public class Starship
    {
        [Display(Name = "Identifier", ResourceType = typeof(Resources.App))]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources.App))]
        [StringLength(16, ErrorMessageResourceName = "LengthError", ErrorMessageResourceType = typeof(Resources.App))]
        public string? Identifier { get; set; }

        [Display(Name = "Description", ResourceType = typeof(Resources.App))]
        public string? Description { get; set; }

        [Display(Name = "Classification", ResourceType = typeof(Resources.App))]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources.App))]
        public string? Classification { get; set; }

        [Display(Name = "MaximumAccommodation", ResourceType = typeof(Resources.App))]
        [Range(1, 100000, ErrorMessageResourceName = "RangeError", ErrorMessageResourceType = typeof(Resources.App))]
        public int MaximumAccommodation { get; set; }

        [Display(Name = "EngineeringApproval", ResourceType = typeof(Resources.App))]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources.App))]
        [Range(typeof(bool), "true", "true", ErrorMessageResourceName = "ValidatedDesignError", ErrorMessageResourceType = typeof(Resources.App))]
        public bool IsValidatedDesign { get; set; }

        [Display(Name = "ProductionDate", ResourceType = typeof(Resources.App))]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(Resources.App))]
        public DateTime ProductionDate { get; set; }
    }
}
