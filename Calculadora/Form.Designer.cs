namespace Calculadora
{
    partial class Calculadora
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
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Display = new System.Windows.Forms.TextBox();
            this.Button_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Button_0 = new System.Windows.Forms.Button();
            this.Button_7 = new System.Windows.Forms.Button();
            this.Button_8 = new System.Windows.Forms.Button();
            this.Button_9 = new System.Windows.Forms.Button();
            this.Button_Mult = new System.Windows.Forms.Button();
            this.Button_6 = new System.Windows.Forms.Button();
            this.Button_5 = new System.Windows.Forms.Button();
            this.Button_4 = new System.Windows.Forms.Button();
            this.Button_3 = new System.Windows.Forms.Button();
            this.Button_2 = new System.Windows.Forms.Button();
            this.Button_1 = new System.Windows.Forms.Button();
            this.Button_Res = new System.Windows.Forms.Button();
            this.Button_Mod = new System.Windows.Forms.Button();
            this.Button_Ans = new System.Windows.Forms.Button();
            this.Button_Decimal = new System.Windows.Forms.Button();
            this.Button_Del = new System.Windows.Forms.Button();
            this.Button_AC = new System.Windows.Forms.Button();
            this.ButtonDiv = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Sub = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.ComboBox();
            this.Layout.SuspendLayout();
            this.Button_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Layout
            // 
            this.Layout.BackColor = System.Drawing.Color.Transparent;
            this.Layout.ColumnCount = 1;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.Controls.Add(this.Display, 0, 0);
            this.Layout.Controls.Add(this.Button_Layout, 0, 1);
            this.Layout.Controls.Add(this.History, 0, 2);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Layout.Location = new System.Drawing.Point(0, 0);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 3;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Layout.Size = new System.Drawing.Size(417, 588);
            this.Layout.TabIndex = 1;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Gainsboro;
            this.Display.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 51.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(3, 18);
            this.Display.Margin = new System.Windows.Forms.Padding(3, 3, 3, 13);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(411, 86);
            this.Display.TabIndex = 0;
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Display.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Display_KeyPress);
            // 
            // Button_Layout
            // 
            this.Button_Layout.ColumnCount = 5;
            this.Button_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Button_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Button_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Button_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Button_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Button_Layout.Controls.Add(this.Button_0, 0, 3);
            this.Button_Layout.Controls.Add(this.Button_7, 0, 0);
            this.Button_Layout.Controls.Add(this.Button_8, 1, 0);
            this.Button_Layout.Controls.Add(this.Button_9, 2, 0);
            this.Button_Layout.Controls.Add(this.Button_Mult, 3, 1);
            this.Button_Layout.Controls.Add(this.Button_6, 2, 1);
            this.Button_Layout.Controls.Add(this.Button_5, 1, 1);
            this.Button_Layout.Controls.Add(this.Button_4, 0, 1);
            this.Button_Layout.Controls.Add(this.Button_3, 2, 2);
            this.Button_Layout.Controls.Add(this.Button_2, 1, 2);
            this.Button_Layout.Controls.Add(this.Button_1, 0, 2);
            this.Button_Layout.Controls.Add(this.Button_Res, 3, 3);
            this.Button_Layout.Controls.Add(this.Button_Mod, 2, 3);
            this.Button_Layout.Controls.Add(this.Button_Ans, 1, 3);
            this.Button_Layout.Controls.Add(this.Button_Decimal, 0, 3);
            this.Button_Layout.Controls.Add(this.Button_Del, 3, 0);
            this.Button_Layout.Controls.Add(this.Button_AC, 4, 0);
            this.Button_Layout.Controls.Add(this.ButtonDiv, 4, 1);
            this.Button_Layout.Controls.Add(this.Button_Add, 3, 2);
            this.Button_Layout.Controls.Add(this.Button_Sub, 4, 2);
            this.Button_Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Layout.Location = new System.Drawing.Point(3, 120);
            this.Button_Layout.Name = "Button_Layout";
            this.Button_Layout.RowCount = 4;
            this.Button_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Button_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Button_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Button_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Button_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Button_Layout.Size = new System.Drawing.Size(411, 405);
            this.Button_Layout.TabIndex = 1;
            // 
            // Button_0
            // 
            this.Button_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_0.Location = new System.Drawing.Point(3, 306);
            this.Button_0.Name = "Button_0";
            this.Button_0.Size = new System.Drawing.Size(76, 96);
            this.Button_0.TabIndex = 17;
            this.Button_0.Text = "0";
            this.Button_0.UseVisualStyleBackColor = true;
            this.Button_0.Click += new System.EventHandler(this.Button_0_Click);
            // 
            // Button_7
            // 
            this.Button_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_7.Location = new System.Drawing.Point(3, 3);
            this.Button_7.Name = "Button_7";
            this.Button_7.Size = new System.Drawing.Size(76, 95);
            this.Button_7.TabIndex = 0;
            this.Button_7.Text = "7";
            this.Button_7.UseVisualStyleBackColor = true;
            this.Button_7.Click += new System.EventHandler(this.Button_7_Click);
            // 
            // Button_8
            // 
            this.Button_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_8.Location = new System.Drawing.Point(85, 3);
            this.Button_8.Name = "Button_8";
            this.Button_8.Size = new System.Drawing.Size(76, 95);
            this.Button_8.TabIndex = 1;
            this.Button_8.Text = "8";
            this.Button_8.UseVisualStyleBackColor = true;
            this.Button_8.Click += new System.EventHandler(this.Button_8_Click);
            // 
            // Button_9
            // 
            this.Button_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_9.Location = new System.Drawing.Point(167, 3);
            this.Button_9.Name = "Button_9";
            this.Button_9.Size = new System.Drawing.Size(76, 95);
            this.Button_9.TabIndex = 2;
            this.Button_9.Text = "9";
            this.Button_9.UseVisualStyleBackColor = true;
            this.Button_9.Click += new System.EventHandler(this.Button_9_Click);
            // 
            // Button_Mult
            // 
            this.Button_Mult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Mult.Location = new System.Drawing.Point(249, 104);
            this.Button_Mult.Name = "Button_Mult";
            this.Button_Mult.Size = new System.Drawing.Size(76, 95);
            this.Button_Mult.TabIndex = 4;
            this.Button_Mult.Text = "x";
            this.Button_Mult.UseVisualStyleBackColor = true;
            this.Button_Mult.Click += new System.EventHandler(this.Button_Mult_Click);
            // 
            // Button_6
            // 
            this.Button_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_6.Location = new System.Drawing.Point(167, 104);
            this.Button_6.Name = "Button_6";
            this.Button_6.Size = new System.Drawing.Size(76, 95);
            this.Button_6.TabIndex = 5;
            this.Button_6.Text = "6";
            this.Button_6.UseVisualStyleBackColor = true;
            this.Button_6.Click += new System.EventHandler(this.Button_6_Click);
            // 
            // Button_5
            // 
            this.Button_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_5.Location = new System.Drawing.Point(85, 104);
            this.Button_5.Name = "Button_5";
            this.Button_5.Size = new System.Drawing.Size(76, 95);
            this.Button_5.TabIndex = 6;
            this.Button_5.Text = "5";
            this.Button_5.UseVisualStyleBackColor = true;
            this.Button_5.Click += new System.EventHandler(this.Button_5_Click);
            // 
            // Button_4
            // 
            this.Button_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_4.Location = new System.Drawing.Point(3, 104);
            this.Button_4.Name = "Button_4";
            this.Button_4.Size = new System.Drawing.Size(76, 95);
            this.Button_4.TabIndex = 7;
            this.Button_4.Text = "4";
            this.Button_4.UseVisualStyleBackColor = true;
            this.Button_4.Click += new System.EventHandler(this.Button_4_Click);
            // 
            // Button_3
            // 
            this.Button_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_3.Location = new System.Drawing.Point(167, 205);
            this.Button_3.Name = "Button_3";
            this.Button_3.Size = new System.Drawing.Size(76, 95);
            this.Button_3.TabIndex = 9;
            this.Button_3.Text = "3";
            this.Button_3.UseVisualStyleBackColor = true;
            this.Button_3.Click += new System.EventHandler(this.Button_3_Click);
            // 
            // Button_2
            // 
            this.Button_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_2.Location = new System.Drawing.Point(85, 205);
            this.Button_2.Name = "Button_2";
            this.Button_2.Size = new System.Drawing.Size(76, 95);
            this.Button_2.TabIndex = 10;
            this.Button_2.Text = "2";
            this.Button_2.UseVisualStyleBackColor = true;
            this.Button_2.Click += new System.EventHandler(this.Button_2_Click);
            // 
            // Button_1
            // 
            this.Button_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_1.Location = new System.Drawing.Point(3, 205);
            this.Button_1.Name = "Button_1";
            this.Button_1.Size = new System.Drawing.Size(76, 95);
            this.Button_1.TabIndex = 11;
            this.Button_1.Text = "1";
            this.Button_1.UseVisualStyleBackColor = true;
            this.Button_1.Click += new System.EventHandler(this.Button_1_Click);
            // 
            // Button_Res
            // 
            this.Button_Res.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Res.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Res.Location = new System.Drawing.Point(331, 306);
            this.Button_Res.Name = "Button_Res";
            this.Button_Res.Size = new System.Drawing.Size(77, 96);
            this.Button_Res.TabIndex = 12;
            this.Button_Res.Text = "=";
            this.Button_Res.UseVisualStyleBackColor = true;
            this.Button_Res.Click += new System.EventHandler(this.Button_Res_Click);
            // 
            // Button_Mod
            // 
            this.Button_Mod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Mod.Location = new System.Drawing.Point(249, 306);
            this.Button_Mod.Name = "Button_Mod";
            this.Button_Mod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Mod.Size = new System.Drawing.Size(76, 96);
            this.Button_Mod.TabIndex = 13;
            this.Button_Mod.Text = "%";
            this.Button_Mod.UseVisualStyleBackColor = true;
            this.Button_Mod.Click += new System.EventHandler(this.Button_Mod_Click);
            // 
            // Button_Ans
            // 
            this.Button_Ans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Ans.Location = new System.Drawing.Point(167, 306);
            this.Button_Ans.Name = "Button_Ans";
            this.Button_Ans.Size = new System.Drawing.Size(76, 96);
            this.Button_Ans.TabIndex = 14;
            this.Button_Ans.Text = "ANS";
            this.Button_Ans.UseVisualStyleBackColor = true;
            this.Button_Ans.Click += new System.EventHandler(this.Button_Ans_Click);
            // 
            // Button_Decimal
            // 
            this.Button_Decimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Decimal.Location = new System.Drawing.Point(85, 306);
            this.Button_Decimal.Name = "Button_Decimal";
            this.Button_Decimal.Size = new System.Drawing.Size(76, 96);
            this.Button_Decimal.TabIndex = 15;
            this.Button_Decimal.Text = ".";
            this.Button_Decimal.UseVisualStyleBackColor = true;
            this.Button_Decimal.Click += new System.EventHandler(this.Button_Decimal_Click);
            // 
            // Button_Del
            // 
            this.Button_Del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Del.Location = new System.Drawing.Point(249, 3);
            this.Button_Del.Name = "Button_Del";
            this.Button_Del.Size = new System.Drawing.Size(76, 95);
            this.Button_Del.TabIndex = 18;
            this.Button_Del.Text = "DEL";
            this.Button_Del.UseVisualStyleBackColor = true;
            this.Button_Del.Click += new System.EventHandler(this.Button_Del_Click);
            // 
            // Button_AC
            // 
            this.Button_AC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_AC.Location = new System.Drawing.Point(331, 3);
            this.Button_AC.Name = "Button_AC";
            this.Button_AC.Size = new System.Drawing.Size(77, 95);
            this.Button_AC.TabIndex = 19;
            this.Button_AC.Text = "AC";
            this.Button_AC.UseVisualStyleBackColor = true;
            this.Button_AC.Click += new System.EventHandler(this.Button_AC_Click);
            // 
            // ButtonDiv
            // 
            this.ButtonDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDiv.Location = new System.Drawing.Point(331, 104);
            this.ButtonDiv.Name = "ButtonDiv";
            this.ButtonDiv.Size = new System.Drawing.Size(77, 95);
            this.ButtonDiv.TabIndex = 20;
            this.ButtonDiv.Text = "÷";
            this.ButtonDiv.UseVisualStyleBackColor = true;
            this.ButtonDiv.Click += new System.EventHandler(this.ButtonDiv_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(249, 205);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(76, 95);
            this.Button_Add.TabIndex = 21;
            this.Button_Add.Text = "+";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Sub
            // 
            this.Button_Sub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Sub.Location = new System.Drawing.Point(331, 205);
            this.Button_Sub.Name = "Button_Sub";
            this.Button_Sub.Size = new System.Drawing.Size(77, 95);
            this.Button_Sub.TabIndex = 22;
            this.Button_Sub.Text = "-";
            this.Button_Sub.UseVisualStyleBackColor = true;
            this.Button_Sub.Click += new System.EventHandler(this.Button_Sub_Click);
            // 
            // History
            // 
            this.History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.FormattingEnabled = true;
            this.History.Location = new System.Drawing.Point(3, 544);
            this.History.Margin = new System.Windows.Forms.Padding(3, 16, 3, 3);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(411, 26);
            this.History.TabIndex = 2;
            this.History.TextChanged += new System.EventHandler(this.History_TextChanged);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(417, 588);
            this.Controls.Add(this.Layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(320, 500);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            this.Button_Layout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Layout;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.TableLayoutPanel Button_Layout;
        private System.Windows.Forms.Button Button_7;
        private System.Windows.Forms.Button Button_8;
        private System.Windows.Forms.Button Button_9;
        private System.Windows.Forms.Button Button_Mult;
        private System.Windows.Forms.Button Button_6;
        private System.Windows.Forms.Button Button_5;
        private System.Windows.Forms.Button Button_4;
        private System.Windows.Forms.Button Button_3;
        private System.Windows.Forms.Button Button_2;
        private System.Windows.Forms.Button Button_1;
        private System.Windows.Forms.Button Button_Res;
        private System.Windows.Forms.Button Button_Mod;
        private System.Windows.Forms.Button Button_Decimal;
        private System.Windows.Forms.ComboBox History;
        private System.Windows.Forms.Button Button_0;
        private System.Windows.Forms.Button Button_Del;
        private System.Windows.Forms.Button Button_AC;
        private System.Windows.Forms.Button ButtonDiv;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Sub;
        private System.Windows.Forms.Button Button_Ans;
    }
}

