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
    public partial class AuthorizationForm : Form
    {
        MainForm _mainForm;
        RegistrationForm _registrationForm;
        List<string> _logins = new List<string>();
        List<string> _passwords = new List<string>();

        public AuthorizationForm()
        {
            InitializeComponent();
        }
 
        private bool ReaderAccount()
        {
            try
            {
                _logins.Clear();
                _passwords.Clear();

                using (StreamReader reader = new StreamReader("Account.acc"))
                {
                    while (!reader.EndOfStream)
                    {
                        if (!reader.EndOfStream) _logins.Add(reader.ReadLine());
                        if (!reader.EndOfStream) _passwords.Add(reader.ReadLine());
                    }
                }

                if (_logins.Count != 0 || _passwords.Count != 0)
                {
                    if (_logins.Count != _passwords.Count)
                    {
                        DialogResult dialogResult = MessageBox.Show("Файл с аккаунтами поврежден или изменен\nПересоздать файл и зарегистрироваться?", "Ошибка", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            _logins.Clear();
                            _passwords.Clear();

                            _registrationForm = new RegistrationForm(true, this);
                            _registrationForm.Show();
                            return false;
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            _logins.Clear();
                            _passwords.Clear();

                            return true;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < _logins.Count; i++)
                        {
                            if (_logins.IndexOf(_logins[i]) != _logins.LastIndexOf(_logins[i]))
                            {
                                DialogResult dialogResult = MessageBox.Show("В файле с аккаунтами есть одинаковые логины\nПересоздать файл и зарегистрироваться?", "Ошибка", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    _logins.Clear();
                                    _passwords.Clear();

                                    _registrationForm = new RegistrationForm(true, this);
                                    _registrationForm.Show();
                                    return false;
                                }
                                else if (dialogResult == DialogResult.No)
                                {
                                    _logins.Clear();
                                    _passwords.Clear();

                                    return true;
                                }
                            }
                        }
                        return true;
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Файл с аккаунтами пуст\nХотите зарегистрироваться?", "Ошибка", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        _registrationForm = new RegistrationForm(true, this);
                        _registrationForm.Show();
                        return false;
                    }
                    else if (dialogResult == DialogResult.No) return true;
                }
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Файл с аккаунтами отсутствует\nХотите зарегистрироваться?", "Ошибка", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _registrationForm = new RegistrationForm(true, this);
                    _registrationForm.Show();
                    return false;
                }
                else if (dialogResult == DialogResult.No) return true;
            }

            return true;
        }
        
        private void AuthorizationForm_Shown(object sender, EventArgs e)
        {
            if (!ReaderAccount()) Hide();
        }

        private void _registerButton_Click(object sender, EventArgs e)
        {
            _registrationForm = new RegistrationForm(false, this);
            _registrationForm.Show();
            Hide();

            _loginTextBox.Text = "";
            _passwordTextBox.Text = "";
        }

        private void _deleteAccountButton_Click(object sender, EventArgs e)
        {
            if (!ReaderAccount()) return;

            try
            {
                _logins.Clear();
                _passwords.Clear();

                using (StreamReader reader = new StreamReader("Account.acc"))
                {
                    while (!reader.EndOfStream)
                    {
                        if (!reader.EndOfStream) _logins.Add(reader.ReadLine());
                        if (!reader.EndOfStream) _passwords.Add(reader.ReadLine());
                    }
                }

                int index = 0;

                for (int i = 0; i < _logins.Count; i++)
                {
                    if (_logins[i] == _loginTextBox.Text)
                    {
                        if (_passwords[i] == _passwordTextBox.Text)
                        {
                            index = i;
                            break;
                        }

                        MessageBox.Show("Неверный пароль от аккаунта", "Ошибка");
                        return;
                    }

                    if (i == _logins.Count - 1)
                    {
                        MessageBox.Show("Такого аккаунта нет", "Ошибка");
                        return;
                    }
                }

                DialogResult dialogResult = MessageBox.Show("Удалить аккаунт:\nlogin: " + _loginTextBox.Text + "\npassword: " + _passwordTextBox.Text, "Ошибка", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _logins.RemoveAt(index);
                        _passwords.RemoveAt(index);

                        using (StreamWriter writer = new StreamWriter("Account.acc"))
                        {
                            for (int i = 0; i < _logins.Count; i++)
                            {
                                writer.WriteLine(_logins[i]);
                                writer.WriteLine(_passwords[i]);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при удалении аккаунта", "Ошибка");
                        return;
                    }
                }
                else if (dialogResult == DialogResult.No) return;
            }
            catch
            {
                MessageBox.Show("Ошибка при открытия файла Account.acc", "Ошибка");
                return;
            }

            _loginTextBox.Clear();
            _passwordTextBox.Clear();
        }

        private void _authorizeButton_Click(object sender, EventArgs e)
        {
            if (_loginTextBox.Text == "Admin" && _passwordTextBox.Text == "admin")
            {
                _mainForm = new MainForm(this, _loginTextBox.Text);
                _mainForm.Show();
                Hide();
                return;
            }

            if (!ReaderAccount()) Hide();
            else
            {
                for (int i = 0; i < _logins.Count; i++)
                {
                    if (_logins[i] == _loginTextBox.Text)
                    {
                        if (_passwords[i] == _passwordTextBox.Text)
                        {
                            _mainForm = new MainForm(this, _loginTextBox.Text);
                            _mainForm.Show();
                            Hide();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Неправильный аккаунт или пароль", "Ошибка");
                            return;
                        }
                    }
                }
                MessageBox.Show("Неправильный аккаунт или пароль", "Ошибка");
                return;
            }

            _loginTextBox.Text = "";
            _passwordTextBox.Text = "";
        }

        private void _loginTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Back) return;
            if (!char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar)) e.KeyChar = '\0';
        }
    }
}


