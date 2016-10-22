using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeCamp.Models
{
  public class TalkModel
  {
    public string Url { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Abstract { get; set; }
    [Required]
    public string Category { get; set; }
    public string Level { get; set; }
    public string Prerequisites { get; set; }
    public DateTime StartingTime { get; set; } = DateTime.Now;
    public string Room { get; set; }
  }
}
