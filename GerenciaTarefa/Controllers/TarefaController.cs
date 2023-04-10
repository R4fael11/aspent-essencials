using Microsoft.AspNetCore.Mvc;

namespace GerenciaTarefa.Controllers;

public class TarefaController:Controller{
   
   //View = Página Web (site)
   //Funções
    public IActionResult Index(){
        ViewData["Cabecalho"] = "Tarefa Diária";
        ViewData["Titulo"] = "Planejar Aula Senai";
        ViewData["Descricao"] = "Criar Nova PEUC";
        return View();
    }
}
