﻿namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.rent = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.technics = new System.Windows.Forms.NumericUpDown();
            this.ad = new System.Windows.Forms.NumericUpDown();
            this.places = new System.Windows.Forms.NumericUpDown();
            this.fame = new System.Windows.Forms.NumericUpDown();
            this.staff_salary = new System.Windows.Forms.NumericUpDown();
            this.actors_salary = new System.Windows.Forms.NumericUpDown();
            this.prof_actors = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.NumericUpDown();
            this.day_type = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tickets_sold = new System.Windows.Forms.Label();
            this.days_left = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.places)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actors_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prof_actors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            this.SuspendLayout();
            // 
            // rent
            // 
            this.rent.Location = new System.Drawing.Point(195, 23);
            this.rent.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(120, 20);
            this.rent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Аренда зала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "дней до выступления:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Специальная техника";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Профессионализм актеров (1-10)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "З.п. актеров";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "З.п. обслуживающего персонала";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Известность постановки (1-10)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Количество мест в зале";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Реклама";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(392, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "ЦЕНА БИЛЕТА";
            // 
            // technics
            // 
            this.technics.Location = new System.Drawing.Point(195, 57);
            this.technics.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.technics.Name = "technics";
            this.technics.Size = new System.Drawing.Size(120, 20);
            this.technics.TabIndex = 12;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(195, 85);
            this.ad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(120, 20);
            this.ad.TabIndex = 13;
            // 
            // places
            // 
            this.places.Location = new System.Drawing.Point(194, 111);
            this.places.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.places.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.places.Name = "places";
            this.places.Size = new System.Drawing.Size(120, 20);
            this.places.TabIndex = 14;
            this.places.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fame
            // 
            this.fame.Location = new System.Drawing.Point(195, 137);
            this.fame.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fame.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fame.Name = "fame";
            this.fame.Size = new System.Drawing.Size(120, 20);
            this.fame.TabIndex = 15;
            this.fame.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // staff_salary
            // 
            this.staff_salary.Location = new System.Drawing.Point(195, 163);
            this.staff_salary.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.staff_salary.Name = "staff_salary";
            this.staff_salary.Size = new System.Drawing.Size(120, 20);
            this.staff_salary.TabIndex = 16;
            // 
            // actors_salary
            // 
            this.actors_salary.Location = new System.Drawing.Point(194, 192);
            this.actors_salary.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.actors_salary.Name = "actors_salary";
            this.actors_salary.Size = new System.Drawing.Size(120, 20);
            this.actors_salary.TabIndex = 17;
            // 
            // prof_actors
            // 
            this.prof_actors.Location = new System.Drawing.Point(195, 220);
            this.prof_actors.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.prof_actors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.prof_actors.Name = "prof_actors";
            this.prof_actors.Size = new System.Drawing.Size(120, 20);
            this.prof_actors.TabIndex = 18;
            this.prof_actors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Начать отсчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "День недели";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Время (24ч формат, часы)";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(193, 275);
            this.time.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(120, 20);
            this.time.TabIndex = 23;
            // 
            // day_type
            // 
            this.day_type.FormattingEnabled = true;
            this.day_type.Items.AddRange(new object[] {
            "будний день",
            "выходной",
            "праздник"});
            this.day_type.Location = new System.Drawing.Point(193, 248);
            this.day_type.Name = "day_type";
            this.day_type.Size = new System.Drawing.Size(121, 21);
            this.day_type.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(107, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "билетов продано:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(392, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "ВЫРУЧКА";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 29;
            // 
            // tickets_sold
            // 
            this.tickets_sold.AutoSize = true;
            this.tickets_sold.Location = new System.Drawing.Point(209, 389);
            this.tickets_sold.Name = "tickets_sold";
            this.tickets_sold.Size = new System.Drawing.Size(10, 13);
            this.tickets_sold.TabIndex = 28;
            this.tickets_sold.Text = "-";
            // 
            // days_left
            // 
            this.days_left.AutoSize = true;
            this.days_left.Location = new System.Drawing.Point(231, 372);
            this.days_left.Name = "days_left";
            this.days_left.Size = new System.Drawing.Size(19, 13);
            this.days_left.TabIndex = 30;
            this.days_left.Text = "20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 488);
            this.Controls.Add(this.days_left);
            this.Controls.Add(this.tickets_sold);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.day_type);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prof_actors);
            this.Controls.Add(this.actors_salary);
            this.Controls.Add(this.staff_salary);
            this.Controls.Add(this.fame);
            this.Controls.Add(this.places);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.technics);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.places)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actors_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prof_actors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown rent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown technics;
        private System.Windows.Forms.NumericUpDown ad;
        private System.Windows.Forms.NumericUpDown places;
        private System.Windows.Forms.NumericUpDown fame;
        private System.Windows.Forms.NumericUpDown staff_salary;
        private System.Windows.Forms.NumericUpDown actors_salary;
        private System.Windows.Forms.NumericUpDown prof_actors;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown time;
        private System.Windows.Forms.ComboBox day_type;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label tickets_sold;
        private System.Windows.Forms.Label days_left;
    }
}

