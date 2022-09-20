using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class MainForm : Form
    {
        AuthorizationForm _authForm;
        delegate void Del();
        Del del;
        List<int> _fibs = new List<int>();
        string _user;
        int a;

        public MainForm(AuthorizationForm authForm, string user)
        {
            InitializeComponent();
            _dataGridView.Columns.Add("Num", "№");
            _dataGridView.Columns.Add("Fib", "Число Фибоначчи");
            _authForm = authForm;
            _user = user;

            using (StreamWriter writer = new StreamWriter(_user + ".txt", File.Exists(_user + ".txt")))
            {
                writer.WriteLine("Пользователь авторизировался - " + _user + ", время - " + DateTime.Now.ToString().Split(' ')[0]);
            }
        }

        private void Fib()
        {
            int temp = _fibs[_fibs.Count - 1] + _fibs[_fibs.Count - 2];
            if (_fibs.Count < a)
            {
                _fibs.Add(temp);
                Fib();
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(_user + ".txt", File.Exists(_user + ".txt")))
                {
                    writer.Write("Пользователь ввел число - " + a + " и получил числа Фибоначчи - ");
                    for (int i = 0; i < _fibs.Count; i++)
                    {
                        _dataGridView.Rows.Add(i + 1, _fibs[i].ToString());
                        writer.Write(_fibs[i] + "; ");
                    }
                    writer.Write('\n');
                }
            }
        }

        private void _helpButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("Справка.ref")) Process.Start("Справка.ref");
            else MessageBox.Show("Файл со справкой отсутствует", "Ошибка");
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _authForm.Show();
        }

        private void _calculateButton_Click(object sender, EventArgs e)
        {
            a = (int)_number.Value;

            _dataGridView.Rows.Clear();
            _fibs.Clear();

            if (a >= 1) _fibs.Add(0);
            if (a >= 2) _fibs.Add(1);
            if (a > 3)
            {
                del = Fib;
                BeginInvoke(del);
            }

            if ((_fibs.Count == 1 || _fibs.Count == 2) && (a == 0 || a == 1))
            {
                using (StreamWriter writer = new StreamWriter(_user + ".txt", File.Exists(_user + ".txt")))
                {
                    writer.Write("Пользователь ввел число - " + a + " и получил числа Фибоначчи - ");
                    for (int i = 0; i < _fibs.Count; i++)
                    {
                        _dataGridView.Rows.Add(_fibs[i].ToString());
                        writer.Write(_fibs[i] + "; ");
                    }
                    writer.Write('\n');
                }
            }
        }
    }
}
