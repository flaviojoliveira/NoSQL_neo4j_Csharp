using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoSQL_CSharp_App
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }
        public class HelloWorldExample : IDisposable
        {
            private bool _disposed = false;
            private readonly IDriver _driver;

            ~HelloWorldExample() => Dispose(false);

            public HelloWorldExample(string uri, string user, string password)
            {
                _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(user, password));
            }

            public void PrintGreeting(string message)
            {
                using (var session = _driver.AsyncSession())
                {
                    var greeting = session.WriteTransactionAsync(tx =>
                    {
                        var result = tx.RunAsync("CREATE (a:Greeting) " +
                                            "SET a.message = $message " +
                                            "RETURN a.message + ', from node ' + id(a)",
                            new { message });
                        return result;
                    });
                    Console.WriteLine(greeting);
                }
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (_disposed)
                    return;

                if (disposing)
                {
                    _driver?.Dispose();
                }

                _disposed = true;
            }

            
        }
        private void limpaFormulario()
        {
            tb_Nome.Clear();
            tb_Idade.Clear();
            tb_Email.Clear();
        }

        private void lb_Email_Click(object sender, EventArgs e)
        {

        }

        private void lb_Nome_Click(object sender, EventArgs e)
        {

        }

        private void lb_Idade_Click(object sender, EventArgs e)
        {

        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            string nome = tb_Nome.Text;
            string idade = tb_Idade.Text;
            string email = tb_Email.Text;

            MessageBox.Show($"Nome: {nome} Idade: {idade}\nEmail: {email}");
            using (var greeter = new HelloWorldExample("bolt://localhost:7687", "neo4j", "password"))
            {
                greeter.PrintGreeting($"Nome: {nome} Idade: {idade}\nEmail: {email}");
            }

            limpaFormulario();
            tb_Nome.Focus();
        }
    }
}
