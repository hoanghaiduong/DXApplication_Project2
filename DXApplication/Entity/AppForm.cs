using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication.Entity
{
    public class AppForm
    {
        private String id;
        private String formName;

        public string Id { get => id; set => id = value; }
        public string FormName { get => formName; set => formName = value; }
    }
}
