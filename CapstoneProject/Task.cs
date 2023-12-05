using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string DateAdded { get; set; }

        public override string ToString()
        {
            return $"{Name} {Description} Due Date: {DueDate}";
        }
    }

}
