using System;
using System.Linq;

using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            if(averageGrade >= 0.80)
            {
                return 'A';
            }
            else if(averageGrade >= 0.60 && averageGrade <= 0.80)
            {
                return 'B';
            }
            else if(averageGrade >= 0.40 && averageGrade <= 0.60)
            {
                return 'C';
            }
            else if(averageGrade >= 0.20 && averageGrade <= 0.40)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
}