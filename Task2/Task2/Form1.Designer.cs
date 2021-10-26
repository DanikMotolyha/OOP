
namespace Task2
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
            this.cityName = new System.Windows.Forms.TextBox();
            this.square = new System.Windows.Forms.NumericUpDown();
            this.population = new System.Windows.Forms.NumericUpDown();
            this.cityDate = new System.Windows.Forms.DateTimePicker();
            this.writeToFile = new System.Windows.Forms.Button();
            this.serialize = new System.Windows.Forms.Button();
            this.deserialize = new System.Windows.Forms.Button();
            this.cityCountry = new System.Windows.Forms.ComboBox();
            this.errorMessage = new System.Windows.Forms.TextBox();
            this.createdCityField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.createCity = new System.Windows.Forms.Button();
            this.parseFromFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.population)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // cityName
            // 
            this.cityName.Location = new System.Drawing.Point(27, 86);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(120, 23);
            this.cityName.TabIndex = 1;
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(27, 130);
            this.square.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(120, 23);
            this.square.TabIndex = 2;
            // 
            // population
            // 
            this.population.Location = new System.Drawing.Point(27, 175);
            this.population.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.population.Name = "population";
            this.population.Size = new System.Drawing.Size(120, 23);
            this.population.TabIndex = 3;
            // 
            // cityDate
            // 
            this.cityDate.Location = new System.Drawing.Point(27, 230);
            this.cityDate.Name = "cityDate";
            this.cityDate.Size = new System.Drawing.Size(120, 23);
            this.cityDate.TabIndex = 4;
            // 
            // writeToFile
            // 
            this.writeToFile.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.writeToFile.Location = new System.Drawing.Point(191, 87);
            this.writeToFile.Name = "writeToFile";
            this.writeToFile.Size = new System.Drawing.Size(121, 38);
            this.writeToFile.TabIndex = 5;
            this.writeToFile.Text = "writeToFile";
            this.writeToFile.UseVisualStyleBackColor = true;
            this.writeToFile.Click += new System.EventHandler(this.writeToFile_Click);
            // 
            // serialize
            // 
            this.serialize.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serialize.Location = new System.Drawing.Point(191, 230);
            this.serialize.Name = "serialize";
            this.serialize.Size = new System.Drawing.Size(121, 38);
            this.serialize.TabIndex = 6;
            this.serialize.Text = "serialize";
            this.serialize.UseVisualStyleBackColor = true;
            this.serialize.Click += new System.EventHandler(this.serialize_Click);
            // 
            // deserialize
            // 
            this.deserialize.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deserialize.Location = new System.Drawing.Point(191, 274);
            this.deserialize.Name = "deserialize";
            this.deserialize.Size = new System.Drawing.Size(121, 38);
            this.deserialize.TabIndex = 7;
            this.deserialize.Text = "deserialize";
            this.deserialize.UseVisualStyleBackColor = true;
            this.deserialize.Click += new System.EventHandler(this.deserialize_Click);
            // 
            // cityCountry
            // 
            this.cityCountry.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityCountry.FormattingEnabled = true;
            this.cityCountry.Location = new System.Drawing.Point(26, 280);
            this.cityCountry.Name = "cityCountry";
            this.cityCountry.Size = new System.Drawing.Size(121, 36);
            this.cityCountry.TabIndex = 8;
            // 
            // errorMessage
            // 
            this.errorMessage.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorMessage.Location = new System.Drawing.Point(496, 359);
            this.errorMessage.Multiline = true;
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.ReadOnly = true;
            this.errorMessage.Size = new System.Drawing.Size(292, 79);
            this.errorMessage.TabIndex = 9;
            // 
            // createdCityField
            // 
            this.createdCityField.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createdCityField.Location = new System.Drawing.Point(379, 74);
            this.createdCityField.Multiline = true;
            this.createdCityField.Name = "createdCityField";
            this.createdCityField.ReadOnly = true;
            this.createdCityField.Size = new System.Drawing.Size(372, 79);
            this.createdCityField.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(481, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Created city";
            // 
            // createCity
            // 
            this.createCity.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createCity.Location = new System.Drawing.Point(27, 341);
            this.createCity.Name = "createCity";
            this.createCity.Size = new System.Drawing.Size(120, 38);
            this.createCity.TabIndex = 12;
            this.createCity.Text = "create";
            this.createCity.UseVisualStyleBackColor = true;
            this.createCity.Click += new System.EventHandler(this.createCity_Click);
            // 
            // parseFromFile
            // 
            this.parseFromFile.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parseFromFile.Location = new System.Drawing.Point(172, 131);
            this.parseFromFile.Name = "parseFromFile";
            this.parseFromFile.Size = new System.Drawing.Size(159, 38);
            this.parseFromFile.TabIndex = 13;
            this.parseFromFile.Text = "parseFromFile";
            this.parseFromFile.UseVisualStyleBackColor = true;
            this.parseFromFile.Click += new System.EventHandler(this.parseFromFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.parseFromFile);
            this.Controls.Add(this.createCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createdCityField);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.cityCountry);
            this.Controls.Add(this.deserialize);
            this.Controls.Add(this.serialize);
            this.Controls.Add(this.writeToFile);
            this.Controls.Add(this.cityDate);
            this.Controls.Add(this.population);
            this.Controls.Add(this.square);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.population)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityName;
        private System.Windows.Forms.NumericUpDown square;
        private System.Windows.Forms.NumericUpDown population;
        private System.Windows.Forms.DateTimePicker cityDate;
        private System.Windows.Forms.Button writeToFile;
        private System.Windows.Forms.Button serialize;
        private System.Windows.Forms.Button deserialize;
        private System.Windows.Forms.ComboBox cityCountry;
        private System.Windows.Forms.TextBox errorMessage;
        private System.Windows.Forms.TextBox createdCityField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createCity;
        private System.Windows.Forms.Button parseFromFile;
    }
}

