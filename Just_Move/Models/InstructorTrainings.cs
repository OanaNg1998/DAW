using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Just_Move.Models
{
    public class InstructorTrainings
    {

        public string Id { get; set; }
        public string InstructorId { get; set; }
        public string TrainingId { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual Training Training { get; set; }
    }
}
