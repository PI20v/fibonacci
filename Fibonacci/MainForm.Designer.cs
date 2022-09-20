namespace Fibonacci
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._showLogButton = new System.Windows.Forms.Button();
            this._number = new System.Windows.Forms.NumericUpDown();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this._calculateButton = new System.Windows.Forms.Button();
            this._helpButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 95);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расчёт числа Фибоначчи";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this._helpButton);
            this.panel2.Controls.Add(this._showLogButton);
            this.panel2.Controls.Add(this._number);
            this.panel2.Controls.Add(this._dataGridView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this._calculateButton);
            this.panel2.Location = new System.Drawing.Point(39, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 314);
            this.panel2.TabIndex = 2;
            // 
            // _showLogButton
            // 
            this._showLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._showLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this._showLogButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
            this._showLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._showLogButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._showLogButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._showLogButton.Location = new System.Drawing.Point(158, 258);
            this._showLogButton.Margin = new System.Windows.Forms.Padding(2);
            this._showLogButton.Name = "_showLogButton";
            this._showLogButton.Size = new System.Drawing.Size(129, 38);
            this._showLogButton.TabIndex = 21;
            this._showLogButton.Text = "Журнал";
            this._showLogButton.UseVisualStyleBackColor = false;
            this._showLogButton.Click += new System.EventHandler(this._showLogButton_Click);
            // 
            // _number
            // 
            this._number.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this._number.Location = new System.Drawing.Point(272, 18);
            this._number.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this._number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._number.Name = "_number";
            this._number.Size = new System.Drawing.Size(120, 32);
            this._number.TabIndex = 20;
            this._number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _dataGridView
            // 
            this._dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Location = new System.Drawing.Point(22, 59);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.Size = new System.Drawing.Size(470, 194);
            this._dataGridView.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите число:";
            // 
            // _calculateButton
            // 
            this._calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this._calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
            this._calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._calculateButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._calculateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._calculateButton.Location = new System.Drawing.Point(363, 258);
            this._calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this._calculateButton.Name = "_calculateButton";
            this._calculateButton.Size = new System.Drawing.Size(129, 38);
            this._calculateButton.TabIndex = 1;
            this._calculateButton.Text = "Рассчитать";
            this._calculateButton.UseVisualStyleBackColor = false;
            this._calculateButton.Click += new System.EventHandler(this._calculateButton_Click);
            // 
            // _helpButton
            // 
            this._helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this._helpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(103)))), ((int)(((byte)(255)))));
            this._helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._helpButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._helpButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this._helpButton.Location = new System.Drawing.Point(22, 258);
            this._helpButton.Margin = new System.Windows.Forms.Padding(2);
            this._helpButton.Name = "_helpButton";
            this._helpButton.Size = new System.Drawing.Size(129, 38);
            this._helpButton.TabIndex = 22;
            this._helpButton.Text = "Справка";
            this._helpButton.UseVisualStyleBackColor = false;
            this._helpButton.Click += new System.EventHandler(this._helpButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(591, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fibonacci";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _calculateButton;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.NumericUpDown _number;
        private System.Windows.Forms.Button _showLogButton;
        private System.Windows.Forms.Button _helpButton;
    }
}

