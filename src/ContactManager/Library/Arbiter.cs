using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Arbiter
{
  public static string ID { get { return Guid.NewGuid().ToString(); } }
}
