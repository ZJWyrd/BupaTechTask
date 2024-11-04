using System.ComponentModel.DataAnnotations;

namespace ZJWyrdBupa.Components.Models;

public class VehicleData
{
    [RegularExpression(@"^(?=.{1,7})(([a-zA-Z]?){1,3}(\d){1,3}([a-zA-Z]?){1,3})$",
        ErrorMessage = "Invalid Input, have you removed spaces?")]
    public string Registration { get; set; }
    public string Make { get;set; }
    public string Model { get;set; }
    public string Colour { get;set; }
    public DateTime MOTExpiry { get;set; }
    public int LastMileage { get;set; }
}
