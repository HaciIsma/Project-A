namespace Can_I_do
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._name = new System.Windows.Forms.TextBox();
            this._lastname = new System.Windows.Forms.TextBox();
            this._age = new System.Windows.Forms.TextBox();
            this._username = new System.Windows.Forms.TextBox();
            this._password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lastname";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(10, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 7;
            this.name.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Age";
            // 
            // _name
            // 
            this._name.Location = new System.Drawing.Point(71, 12);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(100, 20);
            this._name.TabIndex = 10;
            // 
            // _lastname
            // 
            this._lastname.Location = new System.Drawing.Point(71, 38);
            this._lastname.Name = "_lastname";
            this._lastname.Size = new System.Drawing.Size(100, 20);
            this._lastname.TabIndex = 11;
            // 
            // _age
            // 
            this._age.Location = new System.Drawing.Point(71, 64);
            this._age.Name = "_age";
            this._age.Size = new System.Drawing.Size(100, 20);
            this._age.TabIndex = 12;
            // 
            // _username
            // 
            this._username.Location = new System.Drawing.Point(71, 102);
            this._username.Name = "_username";
            this._username.Size = new System.Drawing.Size(100, 20);
            this._username.TabIndex = 13;
            // 
            // _password
            // 
            this._password.Location = new System.Drawing.Point(71, 128);
            this._password.Name = "_password";
            this._password.Size = new System.Drawing.Size(100, 20);
            this._password.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 187);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._password);
            this.Controls.Add(this._username);
            this.Controls.Add(this._age);
            this.Controls.Add(this._lastname);
            this.Controls.Add(this._name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.TextBox _lastname;
        private System.Windows.Forms.TextBox _age;
        private System.Windows.Forms.TextBox _username;
        private System.Windows.Forms.TextBox _password;
        private System.Windows.Forms.Button button1;
    }
}