using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice.CodingQuestions.SQL_Queries
{
    internal class SQLPractice
    {
        /*SELECT e.Position, e.FirstName, e.LastName, s.Position AS ReportsToPosition

      FROM maintable_48570 e

      JOIN maintable_48570 s ON e.ReportsTo = s.Position

      WHERE e.ReportsTo IS NOT NULL

      ORDER BY s.Position, e.Position;*/
    }
}
