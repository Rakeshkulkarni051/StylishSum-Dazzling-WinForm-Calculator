namespace ClaculatorUI
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.numin = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.Button();
            this.Res = new System.Windows.Forms.TextBox();
            this.numin2 = new System.Windows.Forms.TextBox();
            this.oprsign = new System.Windows.Forms.Label();
            this.Dot = new WindowsFormsApplication1.RoundButton();
            this.ClearEverything = new WindowsFormsApplication1.RoundButton();
            this.Modu = new WindowsFormsApplication1.RoundButton();
            this.Division = new WindowsFormsApplication1.RoundButton();
            this.Multipication = new WindowsFormsApplication1.RoundButton();
            this.Minus = new WindowsFormsApplication1.RoundButton();
            this.roundButtonRes = new WindowsFormsApplication1.RoundButton();
            this.Clear = new WindowsFormsApplication1.RoundButton();
            this.roundButton10 = new WindowsFormsApplication1.RoundButton();
            this.roundButton9 = new WindowsFormsApplication1.RoundButton();
            this.roundButton8 = new WindowsFormsApplication1.RoundButton();
            this.roundButton7 = new WindowsFormsApplication1.RoundButton();
            this.roundButton6 = new WindowsFormsApplication1.RoundButton();
            this.roundButton5 = new WindowsFormsApplication1.RoundButton();
            this.roundButton4 = new WindowsFormsApplication1.RoundButton();
            this.roundButton3 = new WindowsFormsApplication1.RoundButton();
            this.roundButton2 = new WindowsFormsApplication1.RoundButton();
            this.roundButton1 = new WindowsFormsApplication1.RoundButton();
            this.SuspendLayout();
            // 
            // numin
            // 
            this.numin.BackColor = System.Drawing.Color.Azure;
            this.numin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numin.Font = new System.Drawing.Font("Leelawadee UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numin.Location = new System.Drawing.Point(23, 21);
            this.numin.Multiline = true;
            this.numin.Name = "numin";
            this.numin.ReadOnly = true;
            this.numin.Size = new System.Drawing.Size(466, 72);
            this.numin.TabIndex = 10;
            this.numin.Text = "0";
            this.numin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numin.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // Addition
            // 
            this.Addition.BackColor = System.Drawing.Color.OrangeRed;
            this.Addition.FlatAppearance.BorderSize = 0;
            this.Addition.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.Addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addition.Location = new System.Drawing.Point(396, 544);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(83, 164);
            this.Addition.TabIndex = 13;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = false;
            this.Addition.Click += new System.EventHandler(this.button1_Click);
            // 
            // Res
            // 
            this.Res.BackColor = System.Drawing.Color.Azure;
            this.Res.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Res.Font = new System.Drawing.Font("Leelawadee UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res.Location = new System.Drawing.Point(23, 118);
            this.Res.Multiline = true;
            this.Res.Name = "Res";
            this.Res.ReadOnly = true;
            this.Res.Size = new System.Drawing.Size(466, 65);
            this.Res.TabIndex = 21;
            this.Res.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Res.TextChanged += new System.EventHandler(this.Res_TextChanged);
            // 
            // numin2
            // 
            this.numin2.BackColor = System.Drawing.Color.Azure;
            this.numin2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numin2.Font = new System.Drawing.Font("Leelawadee UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numin2.Location = new System.Drawing.Point(23, 63);
            this.numin2.Multiline = true;
            this.numin2.Name = "numin2";
            this.numin2.ReadOnly = true;
            this.numin2.Size = new System.Drawing.Size(466, 60);
            this.numin2.TabIndex = 22;
            this.numin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // oprsign
            // 
            this.oprsign.AutoSize = true;
            this.oprsign.BackColor = System.Drawing.Color.Azure;
            this.oprsign.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.oprsign.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oprsign.ForeColor = System.Drawing.SystemColors.ControlText;
            this.oprsign.Location = new System.Drawing.Point(397, 63);
            this.oprsign.Name = "oprsign";
            this.oprsign.Size = new System.Drawing.Size(0, 49);
            this.oprsign.TabIndex = 23;
            this.oprsign.Click += new System.EventHandler(this.oprsign_Click);
            // 
            // Dot
            // 
            this.Dot.BackColor = System.Drawing.Color.OrangeRed;
            this.Dot.FlatAppearance.BorderSize = 0;
            this.Dot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.Dot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dot.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dot.ForeColor = System.Drawing.Color.White;
            this.Dot.Location = new System.Drawing.Point(37, 638);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(73, 70);
            this.Dot.TabIndex = 20;
            this.Dot.Tag = "Dot";
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = false;
            this.Dot.Click += new System.EventHandler(this.roundButton18_Click);
            // 
            // ClearEverything
            // 
            this.ClearEverything.BackColor = System.Drawing.Color.DarkOrange;
            this.ClearEverything.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClearEverything.FlatAppearance.BorderSize = 0;
            this.ClearEverything.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.ClearEverything.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.ClearEverything.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearEverything.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearEverything.ForeColor = System.Drawing.Color.White;
            this.ClearEverything.Location = new System.Drawing.Point(156, 250);
            this.ClearEverything.Name = "ClearEverything";
            this.ClearEverything.Size = new System.Drawing.Size(73, 70);
            this.ClearEverything.TabIndex = 19;
            this.ClearEverything.Tag = "One";
            this.ClearEverything.Text = "CE";
            this.ClearEverything.UseVisualStyleBackColor = false;
            this.ClearEverything.Click += new System.EventHandler(this.roundButton17_Click);
            // 
            // Modu
            // 
            this.Modu.BackColor = System.Drawing.Color.OrangeRed;
            this.Modu.FlatAppearance.BorderSize = 0;
            this.Modu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.Modu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Modu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modu.Font = new System.Drawing.Font("Calibri", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modu.ForeColor = System.Drawing.Color.White;
            this.Modu.Location = new System.Drawing.Point(275, 251);
            this.Modu.Name = "Modu";
            this.Modu.Size = new System.Drawing.Size(73, 70);
            this.Modu.TabIndex = 18;
            this.Modu.Tag = "One";
            this.Modu.Text = "%";
            this.Modu.UseVisualStyleBackColor = false;
            this.Modu.Click += new System.EventHandler(this.Modu_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.OrangeRed;
            this.Division.FlatAppearance.BorderSize = 0;
            this.Division.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.Division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Division.Font = new System.Drawing.Font("Calibri", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.ForeColor = System.Drawing.Color.White;
            this.Division.Location = new System.Drawing.Point(396, 251);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(73, 70);
            this.Division.TabIndex = 17;
            this.Division.Tag = "One";
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Multipication
            // 
            this.Multipication.BackColor = System.Drawing.Color.OrangeRed;
            this.Multipication.FlatAppearance.BorderSize = 0;
            this.Multipication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.Multipication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Multipication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multipication.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multipication.ForeColor = System.Drawing.Color.White;
            this.Multipication.Location = new System.Drawing.Point(396, 347);
            this.Multipication.Name = "Multipication";
            this.Multipication.Size = new System.Drawing.Size(73, 70);
            this.Multipication.TabIndex = 16;
            this.Multipication.Tag = "One";
            this.Multipication.Text = "x";
            this.Multipication.UseVisualStyleBackColor = false;
            this.Multipication.Click += new System.EventHandler(this.Multipication_Click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.OrangeRed;
            this.Minus.FlatAppearance.BorderSize = 0;
            this.Minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.Minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 38F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.ForeColor = System.Drawing.Color.White;
            this.Minus.Location = new System.Drawing.Point(396, 445);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(73, 70);
            this.Minus.TabIndex = 14;
            this.Minus.Tag = "One";
            this.Minus.Text = "-";
            this.Minus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.roundButton13_Click);
            // 
            // roundButtonRes
            // 
            this.roundButtonRes.BackColor = System.Drawing.Color.OrangeRed;
            this.roundButtonRes.FlatAppearance.BorderSize = 0;
            this.roundButtonRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.roundButtonRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.roundButtonRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonRes.ForeColor = System.Drawing.Color.White;
            this.roundButtonRes.Location = new System.Drawing.Point(275, 638);
            this.roundButtonRes.Name = "roundButtonRes";
            this.roundButtonRes.Size = new System.Drawing.Size(73, 70);
            this.roundButtonRes.TabIndex = 12;
            this.roundButtonRes.Tag = "One";
            this.roundButtonRes.Text = "=";
            this.roundButtonRes.UseVisualStyleBackColor = false;
            this.roundButtonRes.Click += new System.EventHandler(this.roundButtonRes_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DarkOrange;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(37, 251);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(73, 70);
            this.Clear.TabIndex = 11;
            this.Clear.Tag = "One";
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.roundButton11_Click);
            // 
            // roundButton10
            // 
            this.roundButton10.BackColor = System.Drawing.Color.LightCyan;
            this.roundButton10.FlatAppearance.BorderSize = 0;
            this.roundButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.roundButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.roundButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton10.Location = new System.Drawing.Point(156, 638);
            this.roundButton10.Name = "roundButton10";
            this.roundButton10.Size = new System.Drawing.Size(73, 70);
            this.roundButton10.TabIndex = 9;
            this.roundButton10.Tag = "Zero";
            this.roundButton10.Text = "0";
            this.roundButton10.UseVisualStyleBackColor = false;
            this.roundButton10.Click += new System.EventHandler(this.roundButton10_Click);
            // 
            // roundButton9
            // 
            this.roundButton9.BackColor = System.Drawing.Color.LightCyan;
            this.roundButton9.FlatAppearance.BorderSize = 0;
            this.roundButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.roundButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.roundButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton9.Location = new System.Drawing.Point(275, 347);
            this.roundButton9.Name = "roundButton9";
            this.roundButton9.Size = new System.Drawing.Size(73, 70);
            this.roundButton9.TabIndex = 8;
            this.roundButton9.Tag = "Nine";
            this.roundButton9.Text = "9";
            this.roundButton9.UseVisualStyleBackColor = false;
            this.roundButton9.Click += new System.EventHandler(this.roundButton9_Click);
            // 
            // roundButton8
            // 
            this.roundButton8.BackColor = System.Drawing.Color.LightCyan;
            this.roundButton8.FlatAppearance.BorderSize = 0;
            this.roundButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.roundButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.roundButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton8.Location = new System.Drawing.Point(156, 347);
            this.roundButton8.Name = "roundButton8";
            this.roundButton8.Size = new System.Drawing.Size(73, 70);
            this.roundButton8.TabIndex = 7;
            this.roundButton8.Tag = "Eight";
            this.roundButton8.Text = "8";
            this.roundButton8.UseVisualStyleBackColor = false;
            this.roundButton8.Click += new System.EventHandler(this.roundButton8_Click);
            // 
            // roundButton7
            // 
            this.roundButton7.BackColor = System.Drawing.Color.LightCyan;
            this.roundButton7.FlatAppearance.BorderSize = 0;
            this.roundButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.roundButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.roundButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton7.Location = new System.Drawing.Point(37, 347);
            this.roundButton7.Name = "roundButton7";
            this.roundButton7.Size = new System.Drawing.Size(73, 70);
            this.roundButton7.TabIndex = 6;
            this.roundButton7.Tag = "Seven";
            this.roundButton7.Text = "7";
            this.roundButton7.UseVisualStyleBackColor = false;
            this.roundButton7.Click += new System.EventHandler(this.roundButton7_Click);
            // 
            // roundButton6
            // 
            this.roundButton6.BackColor = System.Drawing.Color.LightCyan;
            this.roundButton6.FlatAppearance.BorderSize = 0;
            this.roundButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.roundButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.roundButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton6.Location = new System.Drawing.Point(275, 445);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(73, 70);
            this.roundButton6.TabIndex = 5;
            this.roundButton6.Tag = "Six";
            this.roundButton6.Text = "6";
            this.roundButton6.UseVisualStyleBackColor = false;
            this.roundButton6.Click += new System.EventHandler(this.roundButton6_Click);
            // 
            // roundButton5
            // 
            this.roundButton5.BackColor = System.Drawing.Color.LightCyan;
            this.roundButton5.FlatAppearance.BorderSize = 0;
            this.roundButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.roundButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.roundButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton5.Location = new System.Drawing.Point(156, 445);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(73, 70);
            this.roundButton5.TabIndex = 4;
            this.roundButton5.Tag = "Five";
            this.roundButton5.Text = "5";
            this.roundButton5.UseVisualStyleBackColor = false;
            this.roundButton5.Click += new System.EventHandler(this.roundButton5_Click);
            // 
            // roundButton4
            // 
            this.roundButton4.BackColor = System.Drawing.Color.LightCyan;
            this.roundButton4.FlatAppearance.BorderSize = 0;
            this.roundButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.roundButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.roundButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton4.Location = new System.Drawing.Point(37, 445);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(73, 70);
            this.roundButton4.TabIndex = 3;
            this.roundButton4.Tag = "Four";
            this.roundButton4.Text = "4";
            this.roundButton4.UseVisualStyleBackColor = false;
            this.roundButton4.Click += new System.EventHandler(this.roundButton4_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.LightCyan;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.roundButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton3.Location = new System.Drawing.Point(275, 544);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(73, 70);
            this.roundButton3.TabIndex = 2;
            this.roundButton3.Tag = "Three";
            this.roundButton3.Text = "3";
            this.roundButton3.UseVisualStyleBackColor = false;
            this.roundButton3.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.LightCyan;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.roundButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton2.Location = new System.Drawing.Point(156, 544);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(73, 70);
            this.roundButton2.TabIndex = 1;
            this.roundButton2.Tag = "Two";
            this.roundButton2.Text = "2";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.LightCyan;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.roundButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roundButton1.Location = new System.Drawing.Point(37, 544);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(73, 70);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Tag = "One";
            this.roundButton1.Text = "1";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 732);
            this.Controls.Add(this.oprsign);
            this.Controls.Add(this.numin2);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.ClearEverything);
            this.Controls.Add(this.Modu);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multipication);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.roundButtonRes);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.numin);
            this.Controls.Add(this.roundButton10);
            this.Controls.Add(this.roundButton9);
            this.Controls.Add(this.roundButton8);
            this.Controls.Add(this.roundButton7);
            this.Controls.Add(this.roundButton6);
            this.Controls.Add(this.roundButton5);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULATOR";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsApplication1.RoundButton roundButton1;
        private WindowsFormsApplication1.RoundButton roundButton2;
        private WindowsFormsApplication1.RoundButton roundButton3;
        private WindowsFormsApplication1.RoundButton roundButton4;
        private WindowsFormsApplication1.RoundButton roundButton5;
        private WindowsFormsApplication1.RoundButton roundButton6;
        private WindowsFormsApplication1.RoundButton roundButton7;
        private WindowsFormsApplication1.RoundButton roundButton8;
        private WindowsFormsApplication1.RoundButton roundButton9;
        private WindowsFormsApplication1.RoundButton roundButton10;
        private System.Windows.Forms.TextBox numin;
        private WindowsFormsApplication1.RoundButton Clear;
        private WindowsFormsApplication1.RoundButton roundButtonRes;
        private System.Windows.Forms.Button Addition;
        private WindowsFormsApplication1.RoundButton Minus;
        private WindowsFormsApplication1.RoundButton Multipication;
        private WindowsFormsApplication1.RoundButton Division;
        private WindowsFormsApplication1.RoundButton Modu;
        private WindowsFormsApplication1.RoundButton Dot;
        private System.Windows.Forms.TextBox Res;
        private WindowsFormsApplication1.RoundButton ClearEverything;
        private System.Windows.Forms.TextBox numin2;
        private System.Windows.Forms.Label oprsign;
    }
}

