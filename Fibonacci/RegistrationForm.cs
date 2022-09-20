using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class RegistrationForm : Form
    {
        AuthorizationForm _authForm;

        List<string> _logins = new List<string>();
        List<string> _passwords = new List<string>();

        bool _reg;

        public RegistrationForm(bool reg, AuthorizationForm authForm)
        {
            InitializeComponent();
            _reg = reg;
            _authForm = authForm;
        }
        
        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_reg) _authForm.Close();
            else _authForm.Show();
        }

        private void _loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back || e.KeyChar == (int)Keys.Enter) return;
            if (!char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.KeyChar = '\0';
        }

        private void _registerButton_Click(object sender, EventArgs e)
        {
            if (_loginTextBox.Text.Length <= 0
                            && _passwordTextBox.Text.Length <= 0
                            && _repeatPasswordTextBox.Text.Length <= 0) return;

            if (_passwordTextBox.Text != _repeatPasswordTextBox.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка");
                return;
            }

            if (_loginTextBox.Text == "Admin")
            {
                MessageBox.Show("Нельзя создавать аккаунт с логином Admin", "Ошибка");
                return;
            }

            _logins.Clear();
            _passwords.Clear();

            if (!_reg)
            {
                try
                {
                    using (StreamReader reader = new StreamReader("Account.acc"))
                    {
                        while (!reader.EndOfStream)
                        {
                            if (!reader.EndOfStream) _logins.Add(reader.ReadLine());
                            if (!reader.EndOfStream) _passwords.Add(reader.ReadLine());
                        }
                    }

                    if (_logins.Count == _passwords.Count)
                    {
                        foreach (string str in _logins)
                            if (str == _loginTextBox.Text)
                            {
                                MessageBox.Show("Такой аккаунт уже есть", "Ошибка");
                                return;
                            }
                        _logins.Add(_loginTextBox.Text);
                        _passwords.Add(_passwordTextBox.Text);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Файл с аккаунтами поврежден или изменен\nПересоздать файл?", "Ошибка", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            _logins.Clear();
                            _passwords.Clear();

                            using (StreamWriter writer = new StreamWriter("Account.acc"))
                            {
                                _logins.Add(_loginTextBox.Text);
                                _passwords.Add(_passwordTextBox.Text);

                                writer.WriteLine(_loginTextBox.Text);
                                writer.WriteLine(_passwordTextBox.Text);
                            }

                            _reg = false;
                            Close();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            _logins.Clear();
                            _passwords.Clear();

                            Close();
                        }
                    }

                    using (StreamWriter writer = new StreamWriter("Account.acc"))
                    {
                        for (int i = 0; i < _logins.Count; i++)
                        {
                            writer.WriteLine(_logins[i]);
                            writer.WriteLine(_passwords[i]);
                        }

                        _reg = false;
                        Close();
                    }
                }
                catch
                {
                    try
                    {
                        _logins.Clear();
                        _passwords.Clear();

                        using (StreamWriter writer = new StreamWriter("Account.acc"))
                        {
                            _logins.Add(_loginTextBox.Text);
                            _passwords.Add(_passwordTextBox.Text);

                            writer.WriteLine(_loginTextBox.Text);
                            writer.WriteLine(_passwordTextBox.Text);
                        }
                        _reg = false;
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка доступа к файлам компьютера", "Ошибка");
                        Close();
                    }
                }
            }
            else
            {
                try
                {
                    _logins.Clear();
                    _passwords.Clear();

                    using (StreamWriter writer = new StreamWriter("Account.acc"))
                    {
                        _logins.Add(_loginTextBox.Text);
                        _passwords.Add(_passwordTextBox.Text);

                        writer.WriteLine(_loginTextBox.Text);
                        writer.WriteLine(_passwordTextBox.Text);
                    }

                    _reg = false;
                    Close();
                }
                catch
                {
                    MessageBox.Show("Ошибка доступа к файлам компьютера", "Ошибка");
                    Close();
                }
            }
        }

        private void _returnButton_Click(object sender, EventArgs e)
        {
            _reg = false;
            Close();
        }
    }
}
