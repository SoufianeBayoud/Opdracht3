namespace Opdracht3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_int = new System.Windows.Forms.TextBox();
            this.textBox_str = new System.Windows.Forms.TextBox();
            this.textBox_class = new System.Windows.Forms.TextBox();
            this.btn_int_toevoegen = new System.Windows.Forms.Button();
            this.btn_int_delete = new System.Windows.Forms.Button();
            this.btn_int_clear = new System.Windows.Forms.Button();
            this.btn_int_tostring = new System.Windows.Forms.Button();
            this.btn_int_aanwezig = new System.Windows.Forms.Button();
            this.btn_int_copy = new System.Windows.Forms.Button();
            this.btn_str_copy = new System.Windows.Forms.Button();
            this.btn_str_aanwezig = new System.Windows.Forms.Button();
            this.btn_str_tostring = new System.Windows.Forms.Button();
            this.btn_str_clear = new System.Windows.Forms.Button();
            this.btn_str_delete = new System.Windows.Forms.Button();
            this.btn_str_toevoegen = new System.Windows.Forms.Button();
            this.btn_class_copy = new System.Windows.Forms.Button();
            this.btn_class_aanwezig = new System.Windows.Forms.Button();
            this.btn_class_tostring = new System.Windows.Forms.Button();
            this.btn_class_clear = new System.Windows.Forms.Button();
            this.btn_class_delete = new System.Windows.Forms.Button();
            this.btn_class_toevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Integer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // textBox_int
            // 
            this.textBox_int.Location = new System.Drawing.Point(78, 91);
            this.textBox_int.Name = "textBox_int";
            this.textBox_int.Size = new System.Drawing.Size(100, 23);
            this.textBox_int.TabIndex = 3;
            // 
            // textBox_str
            // 
            this.textBox_str.Location = new System.Drawing.Point(360, 91);
            this.textBox_str.Name = "textBox_str";
            this.textBox_str.Size = new System.Drawing.Size(100, 23);
            this.textBox_str.TabIndex = 4;
            // 
            // textBox_class
            // 
            this.textBox_class.Location = new System.Drawing.Point(643, 91);
            this.textBox_class.Name = "textBox_class";
            this.textBox_class.Size = new System.Drawing.Size(100, 23);
            this.textBox_class.TabIndex = 5;
            // 
            // btn_int_toevoegen
            // 
            this.btn_int_toevoegen.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_int_toevoegen.Location = new System.Drawing.Point(78, 130);
            this.btn_int_toevoegen.Name = "btn_int_toevoegen";
            this.btn_int_toevoegen.Size = new System.Drawing.Size(90, 23);
            this.btn_int_toevoegen.TabIndex = 6;
            this.btn_int_toevoegen.Text = "Toevoegen";
            this.btn_int_toevoegen.UseVisualStyleBackColor = true;
            this.btn_int_toevoegen.Click += new System.EventHandler(this.btn_int_toevoegen_Click);
            // 
            // btn_int_delete
            // 
            this.btn_int_delete.Location = new System.Drawing.Point(78, 159);
            this.btn_int_delete.Name = "btn_int_delete";
            this.btn_int_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_int_delete.TabIndex = 7;
            this.btn_int_delete.Text = "Verwijderen";
            this.btn_int_delete.UseVisualStyleBackColor = true;
            this.btn_int_delete.Click += new System.EventHandler(this.btn_int_delete_Click);
            // 
            // btn_int_clear
            // 
            this.btn_int_clear.Location = new System.Drawing.Point(78, 188);
            this.btn_int_clear.Name = "btn_int_clear";
            this.btn_int_clear.Size = new System.Drawing.Size(90, 23);
            this.btn_int_clear.TabIndex = 8;
            this.btn_int_clear.Text = "Leegmaken";
            this.btn_int_clear.UseVisualStyleBackColor = true;
            this.btn_int_clear.Click += new System.EventHandler(this.btn_int_clear_Click);
            // 
            // btn_int_tostring
            // 
            this.btn_int_tostring.Location = new System.Drawing.Point(78, 217);
            this.btn_int_tostring.Name = "btn_int_tostring";
            this.btn_int_tostring.Size = new System.Drawing.Size(90, 23);
            this.btn_int_tostring.TabIndex = 9;
            this.btn_int_tostring.Text = "ToString";
            this.btn_int_tostring.UseVisualStyleBackColor = true;
            this.btn_int_tostring.Click += new System.EventHandler(this.btn_int_tostring_Click);
            // 
            // btn_int_aanwezig
            // 
            this.btn_int_aanwezig.Location = new System.Drawing.Point(78, 246);
            this.btn_int_aanwezig.Name = "btn_int_aanwezig";
            this.btn_int_aanwezig.Size = new System.Drawing.Size(90, 23);
            this.btn_int_aanwezig.TabIndex = 10;
            this.btn_int_aanwezig.Text = "Aanwezig";
            this.btn_int_aanwezig.UseVisualStyleBackColor = true;
            this.btn_int_aanwezig.Click += new System.EventHandler(this.btn_int_aanwezig_Click);
            // 
            // btn_int_copy
            // 
            this.btn_int_copy.Location = new System.Drawing.Point(78, 275);
            this.btn_int_copy.Name = "btn_int_copy";
            this.btn_int_copy.Size = new System.Drawing.Size(90, 23);
            this.btn_int_copy.TabIndex = 11;
            this.btn_int_copy.Text = "Copy";
            this.btn_int_copy.UseVisualStyleBackColor = true;
            this.btn_int_copy.Click += new System.EventHandler(this.btn_int_copy_Click);
            // 
            // btn_str_copy
            // 
            this.btn_str_copy.Location = new System.Drawing.Point(360, 275);
            this.btn_str_copy.Name = "btn_str_copy";
            this.btn_str_copy.Size = new System.Drawing.Size(90, 23);
            this.btn_str_copy.TabIndex = 17;
            this.btn_str_copy.Text = "Copy";
            this.btn_str_copy.UseVisualStyleBackColor = true;
            this.btn_str_copy.Click += new System.EventHandler(this.btn_str_copy_Click);
            // 
            // btn_str_aanwezig
            // 
            this.btn_str_aanwezig.Location = new System.Drawing.Point(360, 246);
            this.btn_str_aanwezig.Name = "btn_str_aanwezig";
            this.btn_str_aanwezig.Size = new System.Drawing.Size(90, 23);
            this.btn_str_aanwezig.TabIndex = 16;
            this.btn_str_aanwezig.Text = "Aanwezig";
            this.btn_str_aanwezig.UseVisualStyleBackColor = true;
            this.btn_str_aanwezig.Click += new System.EventHandler(this.btn_str_aanwezig_Click);
            // 
            // btn_str_tostring
            // 
            this.btn_str_tostring.Location = new System.Drawing.Point(360, 217);
            this.btn_str_tostring.Name = "btn_str_tostring";
            this.btn_str_tostring.Size = new System.Drawing.Size(90, 23);
            this.btn_str_tostring.TabIndex = 15;
            this.btn_str_tostring.Text = "ToString";
            this.btn_str_tostring.UseVisualStyleBackColor = true;
            this.btn_str_tostring.Click += new System.EventHandler(this.btn_str_tostring_Click);
            // 
            // btn_str_clear
            // 
            this.btn_str_clear.Location = new System.Drawing.Point(360, 188);
            this.btn_str_clear.Name = "btn_str_clear";
            this.btn_str_clear.Size = new System.Drawing.Size(90, 23);
            this.btn_str_clear.TabIndex = 14;
            this.btn_str_clear.Text = "Leegmaken";
            this.btn_str_clear.UseVisualStyleBackColor = true;
            this.btn_str_clear.Click += new System.EventHandler(this.btn_str_clear_Click);
            // 
            // btn_str_delete
            // 
            this.btn_str_delete.Location = new System.Drawing.Point(360, 159);
            this.btn_str_delete.Name = "btn_str_delete";
            this.btn_str_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_str_delete.TabIndex = 13;
            this.btn_str_delete.Text = "Verwijderen";
            this.btn_str_delete.UseVisualStyleBackColor = true;
            this.btn_str_delete.Click += new System.EventHandler(this.btn_str_delete_Click);
            // 
            // btn_str_toevoegen
            // 
            this.btn_str_toevoegen.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_str_toevoegen.Location = new System.Drawing.Point(360, 130);
            this.btn_str_toevoegen.Name = "btn_str_toevoegen";
            this.btn_str_toevoegen.Size = new System.Drawing.Size(90, 23);
            this.btn_str_toevoegen.TabIndex = 12;
            this.btn_str_toevoegen.Text = "Toevoegen";
            this.btn_str_toevoegen.UseVisualStyleBackColor = true;
            this.btn_str_toevoegen.Click += new System.EventHandler(this.btn_str_toevoegen_Click);
            // 
            // btn_class_copy
            // 
            this.btn_class_copy.Location = new System.Drawing.Point(643, 275);
            this.btn_class_copy.Name = "btn_class_copy";
            this.btn_class_copy.Size = new System.Drawing.Size(90, 23);
            this.btn_class_copy.TabIndex = 23;
            this.btn_class_copy.Text = "Copy";
            this.btn_class_copy.UseVisualStyleBackColor = true;
            this.btn_class_copy.Click += new System.EventHandler(this.btn_class_copy_Click);
            // 
            // btn_class_aanwezig
            // 
            this.btn_class_aanwezig.Location = new System.Drawing.Point(643, 246);
            this.btn_class_aanwezig.Name = "btn_class_aanwezig";
            this.btn_class_aanwezig.Size = new System.Drawing.Size(90, 23);
            this.btn_class_aanwezig.TabIndex = 22;
            this.btn_class_aanwezig.Text = "Aanwezig";
            this.btn_class_aanwezig.UseVisualStyleBackColor = true;
            this.btn_class_aanwezig.Click += new System.EventHandler(this.btn_class_aanwezig_Click);
            // 
            // btn_class_tostring
            // 
            this.btn_class_tostring.Location = new System.Drawing.Point(643, 217);
            this.btn_class_tostring.Name = "btn_class_tostring";
            this.btn_class_tostring.Size = new System.Drawing.Size(90, 23);
            this.btn_class_tostring.TabIndex = 21;
            this.btn_class_tostring.Text = "ToString";
            this.btn_class_tostring.UseVisualStyleBackColor = true;
            this.btn_class_tostring.Click += new System.EventHandler(this.btn_class_tostring_Click);
            // 
            // btn_class_clear
            // 
            this.btn_class_clear.Location = new System.Drawing.Point(643, 188);
            this.btn_class_clear.Name = "btn_class_clear";
            this.btn_class_clear.Size = new System.Drawing.Size(90, 23);
            this.btn_class_clear.TabIndex = 20;
            this.btn_class_clear.Text = "Leegmaken";
            this.btn_class_clear.UseVisualStyleBackColor = true;
            this.btn_class_clear.Click += new System.EventHandler(this.btn_class_clear_Click);
            // 
            // btn_class_delete
            // 
            this.btn_class_delete.Location = new System.Drawing.Point(643, 159);
            this.btn_class_delete.Name = "btn_class_delete";
            this.btn_class_delete.Size = new System.Drawing.Size(90, 23);
            this.btn_class_delete.TabIndex = 19;
            this.btn_class_delete.Text = "Verwijderen";
            this.btn_class_delete.UseVisualStyleBackColor = true;
            this.btn_class_delete.Click += new System.EventHandler(this.btn_class_delete_Click);
            // 
            // btn_class_toevoegen
            // 
            this.btn_class_toevoegen.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_class_toevoegen.Location = new System.Drawing.Point(643, 130);
            this.btn_class_toevoegen.Name = "btn_class_toevoegen";
            this.btn_class_toevoegen.Size = new System.Drawing.Size(90, 23);
            this.btn_class_toevoegen.TabIndex = 18;
            this.btn_class_toevoegen.Text = "Toevoegen";
            this.btn_class_toevoegen.UseVisualStyleBackColor = true;
            this.btn_class_toevoegen.Click += new System.EventHandler(this.btn_class_toevoegen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_class_copy);
            this.Controls.Add(this.btn_class_aanwezig);
            this.Controls.Add(this.btn_class_tostring);
            this.Controls.Add(this.btn_class_clear);
            this.Controls.Add(this.btn_class_delete);
            this.Controls.Add(this.btn_class_toevoegen);
            this.Controls.Add(this.btn_str_copy);
            this.Controls.Add(this.btn_str_aanwezig);
            this.Controls.Add(this.btn_str_tostring);
            this.Controls.Add(this.btn_str_clear);
            this.Controls.Add(this.btn_str_delete);
            this.Controls.Add(this.btn_str_toevoegen);
            this.Controls.Add(this.btn_int_copy);
            this.Controls.Add(this.btn_int_aanwezig);
            this.Controls.Add(this.btn_int_tostring);
            this.Controls.Add(this.btn_int_clear);
            this.Controls.Add(this.btn_int_delete);
            this.Controls.Add(this.btn_int_toevoegen);
            this.Controls.Add(this.textBox_class);
            this.Controls.Add(this.textBox_str);
            this.Controls.Add(this.textBox_int);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_int;
        private TextBox textBox2;
        private TextBox textBox_class;
        private Button btn_int_toevoegen;
        private Button btn_int_delete;
        private Button btn_int_clear;
        private Button btn_int_tostring;
        private Button btn_int_aanwezig;
        private Button btn_int_copy;
        private TextBox textBox_str;
        private Button btn_str_copy;
        private Button btn_str_aanwezig;
        private Button btn_str_tostring;
        private Button btn_str_clear;
        private Button btn_str_delete;
        private Button btn_str_toevoegen;
        private Button btn_class_copy;
        private Button btn_class_aanwezig;
        private Button btn_class_tostring;
        private Button btn_class_clear;
        private Button btn_class_delete;
        private Button btn_class_toevoegen;
    }
}