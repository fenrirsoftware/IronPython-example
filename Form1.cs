using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IronPython_examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Scripting.Hosting.ScriptEngine pythonEngine =
                 IronPython.Hosting.Python.CreateEngine();
            // We execute this script from Visual Studio 
            // so the program will be executed from bin\Debug or bin\Release

            ICollection<string> paths = pythonEngine.GetSearchPaths();
            string dir = @"C:\Users\ozhan\source\repos\IronPython-examples\Lib\";
            paths.Add(dir);
            string dir2 = @"C:\Users\ozhan\source\repos\IronPython-examples\Lib\xml\etree\";
            paths.Add(dir2);
            pythonEngine.SetSearchPaths(paths);

            Microsoft.Scripting.Hosting.ScriptSource pythonScript =
                pythonEngine.CreateScriptSourceFromFile(@"C:\Users\ozhan\source\repos\IronPython-examples\test3.py");
            pythonScript.Execute();

            MessageBox.Show("kaydedildi");
        }
    
    }
}
