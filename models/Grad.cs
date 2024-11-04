using System.ComponentModel.DataAnnotations;

namespace mojWEB_API.Models;
public class Grad {

    public Grad() {}
    public int ID {get; set;}
    public required string Naziv {get; set;}
    public int BrojStanovnika {get; set;}
};