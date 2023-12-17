using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Murilo C. Ritterbuch", "001.009.847-67", "murilortt@email.com", "Bob");
        Cliente cliente2 = new Cliente(02, "Joao Silva", "002.039.647-27", "joaosilva@email.com", "Spike");
        Cliente cliente3 = new Cliente(03, "Pedro Torres", "067.003.516-62", "pedrotorres@email.com", "Belinha");
        Cliente cliente4 = new Cliente(04, "Carla Souza", "054.049.042-43", "carlasouza@email.com", "Mel");
        Cliente cliente5 = new Cliente(05, "Ana Oliveira", "014.209.877-98", "anaoliveira@email.com", "Brutus");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "CtrlAlt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "TikTok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
