using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101;

public class ShorterMethod
{
    public void PrintReport()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
    }
    private void PrintHeader()
    {
        // ...........
    }
    private void PrintBody()
    {
        // ...........
    }
    private void PrintFooter()
    {
        // ...........
    }
}
