using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class WorkflowModel:ApplicationModel
    {
        public string Id { get; set; }
        public ApplicationModel form { get; set; }
        public ICollection<Stages> stages { get; set; }
    }
}
