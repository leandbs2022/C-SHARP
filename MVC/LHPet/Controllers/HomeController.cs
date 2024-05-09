using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;
using LHPet.models;

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
        //instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "Willian", "036.618.250-09", "Willian@sp.senai.br", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada", "800.777.920.50", "Ada@sp.senai.br", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus", "933.622.400.03", "Linus@sp.senai.br", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace ", "911.702.988.00", "Grace@sp.senai.br", "Loboc");

        List<Cliente> listaCliente = new List<Cliente>();
        listaCliente.Add(cliente1);
        listaCliente.Add(cliente2);
        listaCliente.Add(cliente3);
        listaCliente.Add(cliente4);
        listaCliente.Add(cliente5);


        ViewBag.listaCliente = listaCliente;

        //instancias do tipo Fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-00", "arthur.antunes@sp.senai.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "CTRL ALT DOG", "15.836.698/0001-57", "Willian@sp.senai.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BOOTPET INC", "40.810.224/0001-83", "Ada@sp.senai.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "TIK TOK DOGS", "87.945.350/0001-09", "Linus@sp.senai.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "BIFINHO FOREVER", "10.760.614/0001-37", "Grace@sp.senai.br");

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
