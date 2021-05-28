using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }

    [Required]
    public int MachineId { get; set; }
    [Required]
    public string Name { get; set; }
    // [Required]
    // public string Teacher { get; set; }
    // [Required]
    // public string Subject { get; set; }
    // [Required]
    public int MachineNumber { get; set; }
    // [Required]
    // public float NumberOfCredits { get; set; }
    public virtual ICollection<MachineEngineer> JoinEntities { get; set; }
    // - (1) -- MachineId (1) -- student(1)
    // - (2) -- MachineId (2) -- student(1)

  }
}