using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microsoft.eShopWeb.Web.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]

[Route("[controller]/[action]")]


public class test : Controller
{
    private readonly IMediator _mediator;

    public test(IMediator mediator)
    {
        _mediator = mediator;
    }
    // GET: test
    public ActionResult Index()
    {
        return View();
    }

    // GET: test/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }
}
