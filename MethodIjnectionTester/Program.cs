using System;
using System.Windows.Forms;

namespace MethodIjnectionTester
{
    static class Program
    {

        private static Form1 _form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var consoleWriter = new ConsoleWriter())
            {
                consoleWriter.WriteEvent += consoleWriter_WriteEvent;
                consoleWriter.WriteLineEvent += consoleWriter_WriteLineEvent;

                Console.SetOut(consoleWriter);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                _form = new Form1();
                Application.Run(_form);
            }
        }
        static void consoleWriter_WriteLineEvent(object sender, ConsoleWriterEventArgs e)
        {
            _form.textBox1.Text += Environment.NewLine + e.Value;
        }

        static void consoleWriter_WriteEvent(object sender, ConsoleWriterEventArgs e)
        {
            _form.textBox1.Text += Environment.NewLine + e.Value;
        }
    }
}
