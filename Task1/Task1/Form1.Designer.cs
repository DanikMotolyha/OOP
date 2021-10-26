
namespace Task1
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
            this.addCar = new System.Windows.Forms.Button();
            this.addLoryy = new System.Windows.Forms.Button();
            this.addBicycle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Roof = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Engine = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.NumericUpDown();
            this.MaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.AmountOfSeats = new System.Windows.Forms.NumericUpDown();
            this.AmountOfDoors = new System.Windows.Forms.NumericUpDown();
            this.MaxLoad = new System.Windows.Forms.NumericUpDown();
            this.GarageList = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PrintGarageFromFile = new System.Windows.Forms.Button();
            this.WriteGarageToFile = new System.Windows.Forms.Button();
            this.PrintGarageInMemory = new System.Windows.Forms.Button();
            this.SortByYear = new System.Windows.Forms.Button();
            this.SortingFilter = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ClearOutputGarage = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfDoors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lorry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bicycle";
            // 
            // addCar
            // 
            this.addCar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addCar.Location = new System.Drawing.Point(280, 441);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(82, 38);
            this.addCar.TabIndex = 3;
            this.addCar.Text = "add";
            this.addCar.UseVisualStyleBackColor = true;
            this.addCar.Click += new System.EventHandler(this.addCar_Click);
            // 
            // addLoryy
            // 
            this.addLoryy.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addLoryy.Location = new System.Drawing.Point(280, 380);
            this.addLoryy.Name = "addLoryy";
            this.addLoryy.Size = new System.Drawing.Size(82, 38);
            this.addLoryy.TabIndex = 4;
            this.addLoryy.Text = "add";
            this.addLoryy.UseVisualStyleBackColor = true;
            this.addLoryy.Click += new System.EventHandler(this.addLoryy_Click);
            // 
            // addBicycle
            // 
            this.addBicycle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addBicycle.Location = new System.Drawing.Point(280, 318);
            this.addBicycle.Name = "addBicycle";
            this.addBicycle.Size = new System.Drawing.Size(82, 38);
            this.addBicycle.TabIndex = 5;
            this.addBicycle.Text = "add";
            this.addBicycle.UseVisualStyleBackColor = true;
            this.addBicycle.Click += new System.EventHandler(this.addBicycle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(124, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "roof";
            // 
            // Roof
            // 
            this.Roof.AutoSize = true;
            this.Roof.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Roof.Location = new System.Drawing.Point(213, 453);
            this.Roof.Name = "Roof";
            this.Roof.Size = new System.Drawing.Size(15, 14);
            this.Roof.TabIndex = 7;
            this.Roof.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(99, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "maxLoad";
            // 
            // Engine
            // 
            this.Engine.AutoSize = true;
            this.Engine.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Engine.Location = new System.Drawing.Point(213, 335);
            this.Engine.Name = "Engine";
            this.Engine.Size = new System.Drawing.Size(15, 14);
            this.Engine.TabIndex = 11;
            this.Engine.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(124, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "engine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(25, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Vehicle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(40, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(26, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "maxSpeed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(40, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 28);
            this.label10.TabIndex = 20;
            this.label10.Text = "year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 28);
            this.label11.TabIndex = 21;
            this.label11.Text = "amountOfSeats";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(12, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 28);
            this.label12.TabIndex = 22;
            this.label12.Text = "amountOfDoors";
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(179, 70);
            this.Price.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(59, 34);
            this.Price.TabIndex = 23;
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxSpeed.Location = new System.Drawing.Point(179, 112);
            this.MaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxSpeed.Name = "MaxSpeed";
            this.MaxSpeed.Size = new System.Drawing.Size(59, 34);
            this.MaxSpeed.TabIndex = 24;
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Year.Location = new System.Drawing.Point(179, 152);
            this.Year.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(59, 34);
            this.Year.TabIndex = 25;
            // 
            // AmountOfSeats
            // 
            this.AmountOfSeats.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountOfSeats.Location = new System.Drawing.Point(179, 192);
            this.AmountOfSeats.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AmountOfSeats.Name = "AmountOfSeats";
            this.AmountOfSeats.Size = new System.Drawing.Size(59, 34);
            this.AmountOfSeats.TabIndex = 26;
            // 
            // AmountOfDoors
            // 
            this.AmountOfDoors.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountOfDoors.Location = new System.Drawing.Point(179, 232);
            this.AmountOfDoors.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AmountOfDoors.Name = "AmountOfDoors";
            this.AmountOfDoors.Size = new System.Drawing.Size(59, 34);
            this.AmountOfDoors.TabIndex = 27;
            // 
            // MaxLoad
            // 
            this.MaxLoad.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxLoad.Location = new System.Drawing.Point(196, 383);
            this.MaxLoad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxLoad.Name = "MaxLoad";
            this.MaxLoad.Size = new System.Drawing.Size(59, 34);
            this.MaxLoad.TabIndex = 28;
            // 
            // GarageList
            // 
            this.GarageList.Location = new System.Drawing.Point(574, 78);
            this.GarageList.Multiline = true;
            this.GarageList.Name = "GarageList";
            this.GarageList.ReadOnly = true;
            this.GarageList.Size = new System.Drawing.Size(633, 401);
            this.GarageList.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(846, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 28);
            this.label13.TabIndex = 30;
            this.label13.Text = "Garage";
            // 
            // PrintGarageFromFile
            // 
            this.PrintGarageFromFile.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrintGarageFromFile.Location = new System.Drawing.Point(280, 137);
            this.PrintGarageFromFile.Name = "PrintGarageFromFile";
            this.PrintGarageFromFile.Size = new System.Drawing.Size(278, 38);
            this.PrintGarageFromFile.TabIndex = 31;
            this.PrintGarageFromFile.Text = "PrintGarageFromFile";
            this.PrintGarageFromFile.UseVisualStyleBackColor = true;
            this.PrintGarageFromFile.Click += new System.EventHandler(this.PrintGarageFromFile_Click);
            // 
            // WriteGarageToFile
            // 
            this.WriteGarageToFile.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WriteGarageToFile.Location = new System.Drawing.Point(280, 198);
            this.WriteGarageToFile.Name = "WriteGarageToFile";
            this.WriteGarageToFile.Size = new System.Drawing.Size(278, 38);
            this.WriteGarageToFile.TabIndex = 32;
            this.WriteGarageToFile.Text = "WriteGarageToFile";
            this.WriteGarageToFile.UseVisualStyleBackColor = true;
            this.WriteGarageToFile.Click += new System.EventHandler(this.WriteGarageToFile_Click);
            // 
            // PrintGarageInMemory
            // 
            this.PrintGarageInMemory.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrintGarageInMemory.Location = new System.Drawing.Point(280, 78);
            this.PrintGarageInMemory.Name = "PrintGarageInMemory";
            this.PrintGarageInMemory.Size = new System.Drawing.Size(278, 38);
            this.PrintGarageInMemory.TabIndex = 33;
            this.PrintGarageInMemory.Text = "PrintGarageInMemory";
            this.PrintGarageInMemory.UseVisualStyleBackColor = true;
            this.PrintGarageInMemory.Click += new System.EventHandler(this.PrintGarageInMemory_Click);
            // 
            // SortByYear
            // 
            this.SortByYear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortByYear.Location = new System.Drawing.Point(280, 254);
            this.SortByYear.Name = "SortByYear";
            this.SortByYear.Size = new System.Drawing.Size(136, 38);
            this.SortByYear.TabIndex = 34;
            this.SortByYear.Text = "SortByYear";
            this.SortByYear.UseVisualStyleBackColor = true;
            this.SortByYear.Click += new System.EventHandler(this.SortByYear_Click);
            // 
            // SortingFilter
            // 
            this.SortingFilter.AutoSize = true;
            this.SortingFilter.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortingFilter.Location = new System.Drawing.Point(514, 267);
            this.SortingFilter.Name = "SortingFilter";
            this.SortingFilter.Size = new System.Drawing.Size(15, 14);
            this.SortingFilter.TabIndex = 35;
            this.SortingFilter.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(446, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 28);
            this.label14.TabIndex = 36;
            this.label14.Text = "desc";
            // 
            // ClearOutputGarage
            // 
            this.ClearOutputGarage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearOutputGarage.Location = new System.Drawing.Point(280, 19);
            this.ClearOutputGarage.Name = "ClearOutputGarage";
            this.ClearOutputGarage.Size = new System.Drawing.Size(278, 38);
            this.ClearOutputGarage.TabIndex = 37;
            this.ClearOutputGarage.Text = "clearOutputGarage";
            this.ClearOutputGarage.UseVisualStyleBackColor = true;
            this.ClearOutputGarage.Click += new System.EventHandler(this.clearOutputGarage_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.Location = new System.Drawing.Point(386, 318);
            this.errorMessage.Multiline = true;
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.ReadOnly = true;
            this.errorMessage.Size = new System.Drawing.Size(172, 54);
            this.errorMessage.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 501);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.ClearOutputGarage);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SortingFilter);
            this.Controls.Add(this.SortByYear);
            this.Controls.Add(this.PrintGarageInMemory);
            this.Controls.Add(this.WriteGarageToFile);
            this.Controls.Add(this.PrintGarageFromFile);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.GarageList);
            this.Controls.Add(this.MaxLoad);
            this.Controls.Add(this.AmountOfDoors);
            this.Controls.Add(this.AmountOfSeats);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.MaxSpeed);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Engine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Roof);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addBicycle);
            this.Controls.Add(this.addLoryy);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfDoors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addCar;
        private System.Windows.Forms.Button addLoryy;
        private System.Windows.Forms.Button addBicycle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Roof;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Engine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown Price;
        private System.Windows.Forms.NumericUpDown MaxSpeed;
        private System.Windows.Forms.NumericUpDown Year;
        private System.Windows.Forms.NumericUpDown AmountOfSeats;
        private System.Windows.Forms.NumericUpDown AmountOfDoors;
        private System.Windows.Forms.NumericUpDown MaxLoad;
        private System.Windows.Forms.TextBox GarageList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button PrintGarageFromFile;
        private System.Windows.Forms.Button WriteGarageToFile;
        private System.Windows.Forms.Button PrintGarageInMemory;
        private System.Windows.Forms.Button SortByYear;
        private System.Windows.Forms.CheckBox SortingFilter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button ClearOutputGarage;
        private System.Windows.Forms.TextBox errorMessage;
    }
}

