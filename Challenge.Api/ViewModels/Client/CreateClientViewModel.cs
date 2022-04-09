using System.ComponentModel.DataAnnotations;

namespace Challenge.Api.ViewModels.Client;

public class CreateClientViewModel
{
    [Required(ErrorMessage = "Name is required")]
    [MaxLength(200, ErrorMessage = "The max length is 200 chars")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Document is required")]
    [MaxLength(11, ErrorMessage = "The max length is 200 chars")]
    public string Document { get; set; }
    
    [Required]
    [DisplayFormat(DataFormatString = "dd/MM/yyy")]
    public DateTime BirthDate { get; set; }
}