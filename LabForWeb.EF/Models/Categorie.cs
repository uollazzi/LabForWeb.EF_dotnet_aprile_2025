using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabForWeb.EF.Models;

[Table("Categorie")]
public partial class Categorie
{
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Descrizione { get; set; } = null!;

    [InverseProperty("Categoria")]
    public virtual ICollection<Todo> Todos { get; set; } = new List<Todo>();
}
