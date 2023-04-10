//conjunto de classes
namespace GerenciaTarefa.Models;
//conjunto de objetos
public class Tarefa{

  //classe é um conjunto de objetos
  //Propriedades Automáticas
  public int Id { get; set; } //inteiro
  public string? Descricao { get; set; } //texto
  public string? Cabeçalho { get; set; }

  public string? Título { get; set; }
  public bool TaCompleta { get; set; }
  //Funcionalidades

}