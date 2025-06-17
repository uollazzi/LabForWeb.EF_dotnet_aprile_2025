using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LabForWeb.EF.Models;

[Table("Utenti")]
public partial class Utenti
{
    [Key]
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public bool Attivo { get; set; }

    [InverseProperty("Utente")]
    public virtual ICollection<Todo> Todos { get; set; } = new List<Todo>();
}
