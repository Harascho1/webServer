using mojWEB_API.Models;

namespace mojWEB_API.Controllers;

[Route("[controller]")]
public class GradController:ControllerBase {
    public WebContext context {get; set;}

    public GradController(WebContext webContext) {
        context = webContext;
    }

    [HttpGet("VratiNis")]
    public Grad VratiNis() {
        return new Grad() {
            ID = 1,
            Naziv = "Nis",
            BrojStanovnika = 300000
        };
    }

    [HttpGet("VratiGradove")]
    public List<Grad> VratiGradove() {
        return context.Grad.ToList();
    }
}