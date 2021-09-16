using System.ComponentModel;

namespace notepad
{
    partial class fontsSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fontsSetting));
            this.ExampleFont = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FontSize = new System.Windows.Forms.ComboBox();
            this.FontName = new System.Windows.Forms.ComboBox();
            this.FontStyle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExampleFont
            // 
            this.ExampleFont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ExampleFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ExampleFont.Location = new System.Drawing.Point(179, 69);
            this.ExampleFont.Name = "ExampleFont";
            this.ExampleFont.Size = new System.Drawing.Size(209, 109);
            this.ExampleFont.TabIndex = 1;
            this.ExampleFont.Text = "AaBbБбФф";
            this.ExampleFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(190, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Образец";
            // 
            // FontSize
            // 
            this.FontSize.FormattingEnabled = true;
            this.FontSize.Items.AddRange(new object[] {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"});
            this.FontSize.Location = new System.Drawing.Point(308, 27);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(80, 21);
            this.FontSize.TabIndex = 4;
            this.FontSize.SelectedValueChanged += new System.EventHandler(this.OnFontedChanged);
            // 
            // FontName
            // 
            this.FontName.FormattingEnabled = true;
            this.FontName.Items.AddRange(new object[] {"Microsoft Sans Serif", "Arial", "Comic Sans MS", "Impact", "Sylfaen", "Courier New"});
            this.FontName.Location = new System.Drawing.Point(13, 27);
            this.FontName.Name = "FontName";
            this.FontName.Size = new System.Drawing.Size(137, 21);
            this.FontName.TabIndex = 6;
            this.FontName.SelectedValueChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // FontStyle
            // 
            this.FontStyle.FormattingEnabled = true;
            this.FontStyle.Items.AddRange(new object[] {"обычный", "курсив", "полужирный", "Зачеркнутый", "Подчеркнутый", "полужирный наклонный"});
            this.FontStyle.Location = new System.Drawing.Point(157, 27);
            this.FontStyle.Name = "FontStyle";
            this.FontStyle.Size = new System.Drawing.Size(145, 21);
            this.FontStyle.TabIndex = 8;
            this.FontStyle.SelectedValueChanged += new System.EventHandler(this.OnStyleChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Шрифт:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(156, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Начертание:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(307, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Размер:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Окей";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fontsSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 236);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FontStyle);
            this.Controls.Add(this.FontName);
            this.Controls.Add(this.FontSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExampleFont);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "fontsSetting";
            this.Text = "Шрифт";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.ComboBox FontName;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ComboBox FontStyle;

        private System.Windows.Forms.ComboBox FontSize;

        private System.Windows.Forms.Label ExampleFont;
        
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        

        private System.Windows.Forms.Label label1;

        #endregion
    }
}