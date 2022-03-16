
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.GroupBox();
            this.Balcony = new System.Windows.Forms.CheckBox();
            this.Basement = new System.Windows.Forms.CheckBox();
            this.WC = new System.Windows.Forms.CheckBox();
            this.Bath = new System.Windows.Forms.CheckBox();
            this.Kitchen = new System.Windows.Forms.CheckBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Meters = new System.Windows.Forms.TextBox();
            this.Rooms = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Floor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MaterialType = new System.Windows.Forms.ComboBox();
            this.Adress = new System.Windows.Forms.GroupBox();
            this.FlatT = new System.Windows.Forms.TextBox();
            this.BuildingT = new System.Windows.Forms.TextBox();
            this.StreetT = new System.Windows.Forms.TextBox();
            this.DistrictT = new System.Windows.Forms.TextBox();
            this.TownT = new System.Windows.Forms.TextBox();
            this.CountryT = new System.Windows.Forms.TextBox();
            this.Flat = new System.Windows.Forms.Label();
            this.Building = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.Label();
            this.District = new System.Windows.Forms.Label();
            this.Town = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.WriteData = new System.Windows.Forms.Button();
            this.ClearData = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.Serialize = new System.Windows.Forms.Button();
            this.Deserialize = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rooms)).BeginInit();
            this.Adress.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Метраж:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кол-во комнат:";
            // 
            // Options
            // 
            this.Options.Controls.Add(this.Balcony);
            this.Options.Controls.Add(this.Basement);
            this.Options.Controls.Add(this.WC);
            this.Options.Controls.Add(this.Bath);
            this.Options.Controls.Add(this.Kitchen);
            this.Options.Location = new System.Drawing.Point(69, 175);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(103, 163);
            this.Options.TabIndex = 3;
            this.Options.TabStop = false;
            this.Options.Text = "Опции";
            // 
            // Balcony
            // 
            this.Balcony.AutoSize = true;
            this.Balcony.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Balcony.Location = new System.Drawing.Point(7, 116);
            this.Balcony.Name = "Balcony";
            this.Balcony.Size = new System.Drawing.Size(63, 17);
            this.Balcony.TabIndex = 4;
            this.Balcony.Text = "Балкон";
            this.Balcony.UseVisualStyleBackColor = true;
            // 
            // Basement
            // 
            this.Basement.AutoSize = true;
            this.Basement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Basement.Location = new System.Drawing.Point(7, 92);
            this.Basement.Name = "Basement";
            this.Basement.Size = new System.Drawing.Size(64, 17);
            this.Basement.TabIndex = 3;
            this.Basement.Text = "Подвал";
            this.Basement.UseVisualStyleBackColor = true;
            // 
            // WC
            // 
            this.WC.AutoSize = true;
            this.WC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WC.Location = new System.Drawing.Point(7, 68);
            this.WC.Name = "WC";
            this.WC.Size = new System.Drawing.Size(61, 17);
            this.WC.TabIndex = 2;
            this.WC.Text = "Туалет";
            this.WC.UseVisualStyleBackColor = true;
            // 
            // Bath
            // 
            this.Bath.AutoSize = true;
            this.Bath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bath.Location = new System.Drawing.Point(7, 44);
            this.Bath.Name = "Bath";
            this.Bath.Size = new System.Drawing.Size(57, 17);
            this.Bath.TabIndex = 1;
            this.Bath.Text = "Ванна";
            this.Bath.UseVisualStyleBackColor = true;
            // 
            // Kitchen
            // 
            this.Kitchen.AutoSize = true;
            this.Kitchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kitchen.Location = new System.Drawing.Point(7, 20);
            this.Kitchen.Name = "Kitchen";
            this.Kitchen.Size = new System.Drawing.Size(55, 17);
            this.Kitchen.TabIndex = 0;
            this.Kitchen.Text = "Кухня";
            this.Kitchen.UseVisualStyleBackColor = true;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Indigo;
            this.DateTimePicker.Location = new System.Drawing.Point(435, 55);
            this.DateTimePicker.MaxDate = new System.DateTime(2022, 3, 31, 0, 0, 0, 0);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(109, 20);
            this.DateTimePicker.TabIndex = 4;
            this.DateTimePicker.Value = new System.DateTime(2022, 3, 4, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Год постройки:";
            // 
            // Meters
            // 
            this.Meters.Location = new System.Drawing.Point(122, 54);
            this.Meters.Name = "Meters";
            this.Meters.Size = new System.Drawing.Size(100, 20);
            this.Meters.TabIndex = 6;
            this.Meters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Meters_KeyPress);
            // 
            // Rooms
            // 
            this.Rooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rooms.Location = new System.Drawing.Point(155, 80);
            this.Rooms.Maximum = 5;
            this.Rooms.Minimum = 1;
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(125, 45);
            this.Rooms.TabIndex = 7;
            this.Rooms.Value = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Тип материала:";
            // 
            // Floor
            // 
            this.Floor.Location = new System.Drawing.Point(436, 130);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(42, 20);
            this.Floor.TabIndex = 16;
            this.Floor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Floor_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Этаж:";
            // 
            // MaterialType
            // 
            this.MaterialType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialType.FormattingEnabled = true;
            this.MaterialType.Items.AddRange(new object[] {
            "Камень",
            "Бетон",
            "Кирпич",
            "Стекло",
            "Дерево"});
            this.MaterialType.Location = new System.Drawing.Point(435, 91);
            this.MaterialType.Name = "MaterialType";
            this.MaterialType.Size = new System.Drawing.Size(109, 21);
            this.MaterialType.TabIndex = 17;
            // 
            // Adress
            // 
            this.Adress.Controls.Add(this.FlatT);
            this.Adress.Controls.Add(this.BuildingT);
            this.Adress.Controls.Add(this.StreetT);
            this.Adress.Controls.Add(this.DistrictT);
            this.Adress.Controls.Add(this.TownT);
            this.Adress.Controls.Add(this.CountryT);
            this.Adress.Controls.Add(this.Flat);
            this.Adress.Controls.Add(this.Building);
            this.Adress.Controls.Add(this.Street);
            this.Adress.Controls.Add(this.District);
            this.Adress.Controls.Add(this.Town);
            this.Adress.Controls.Add(this.Country);
            this.Adress.Location = new System.Drawing.Point(342, 175);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(200, 178);
            this.Adress.TabIndex = 18;
            this.Adress.TabStop = false;
            this.Adress.Text = "Адрес";
            // 
            // FlatT
            // 
            this.FlatT.Location = new System.Drawing.Point(82, 149);
            this.FlatT.Name = "FlatT";
            this.FlatT.Size = new System.Drawing.Size(103, 20);
            this.FlatT.TabIndex = 24;
            // 
            // BuildingT
            // 
            this.BuildingT.Location = new System.Drawing.Point(82, 123);
            this.BuildingT.Name = "BuildingT";
            this.BuildingT.Size = new System.Drawing.Size(103, 20);
            this.BuildingT.TabIndex = 23;
            // 
            // StreetT
            // 
            this.StreetT.Location = new System.Drawing.Point(82, 98);
            this.StreetT.Name = "StreetT";
            this.StreetT.Size = new System.Drawing.Size(103, 20);
            this.StreetT.TabIndex = 22;
            this.StreetT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StreetT_KeyPress);
            // 
            // DistrictT
            // 
            this.DistrictT.Location = new System.Drawing.Point(82, 72);
            this.DistrictT.Name = "DistrictT";
            this.DistrictT.Size = new System.Drawing.Size(103, 20);
            this.DistrictT.TabIndex = 21;
            this.DistrictT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DistrictT_KeyPress);
            // 
            // TownT
            // 
            this.TownT.Location = new System.Drawing.Point(82, 48);
            this.TownT.Name = "TownT";
            this.TownT.Size = new System.Drawing.Size(103, 20);
            this.TownT.TabIndex = 20;
            this.TownT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TownT_KeyPress);
            // 
            // CountryT
            // 
            this.CountryT.Location = new System.Drawing.Point(82, 21);
            this.CountryT.Name = "CountryT";
            this.CountryT.Size = new System.Drawing.Size(103, 20);
            this.CountryT.TabIndex = 19;
            this.CountryT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryT_KeyPress);
            // 
            // Flat
            // 
            this.Flat.AutoSize = true;
            this.Flat.Location = new System.Drawing.Point(6, 150);
            this.Flat.Name = "Flat";
            this.Flat.Size = new System.Drawing.Size(55, 13);
            this.Flat.TabIndex = 5;
            this.Flat.Text = "Квартира";
            // 
            // Building
            // 
            this.Building.AutoSize = true;
            this.Building.Location = new System.Drawing.Point(6, 123);
            this.Building.Name = "Building";
            this.Building.Size = new System.Drawing.Size(43, 13);
            this.Building.TabIndex = 4;
            this.Building.Text = "Корпус";
            // 
            // Street
            // 
            this.Street.AutoSize = true;
            this.Street.Location = new System.Drawing.Point(6, 96);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(39, 13);
            this.Street.TabIndex = 3;
            this.Street.Text = "Улица";
            // 
            // District
            // 
            this.District.AutoSize = true;
            this.District.Location = new System.Drawing.Point(6, 72);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(38, 13);
            this.District.TabIndex = 2;
            this.District.Text = "Район";
            // 
            // Town
            // 
            this.Town.AutoSize = true;
            this.Town.Location = new System.Drawing.Point(6, 48);
            this.Town.Name = "Town";
            this.Town.Size = new System.Drawing.Size(37, 13);
            this.Town.TabIndex = 1;
            this.Town.Text = "Город";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(6, 24);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(43, 13);
            this.Country.TabIndex = 0;
            this.Country.Text = "Страна";
            // 
            // WriteData
            // 
            this.WriteData.BackColor = System.Drawing.Color.Fuchsia;
            this.WriteData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WriteData.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteData.ForeColor = System.Drawing.Color.DarkRed;
            this.WriteData.Location = new System.Drawing.Point(391, 527);
            this.WriteData.Name = "WriteData";
            this.WriteData.Size = new System.Drawing.Size(153, 38);
            this.WriteData.TabIndex = 22;
            this.WriteData.Text = "Записать данные";
            this.WriteData.UseVisualStyleBackColor = false;
            this.WriteData.Click += new System.EventHandler(this.WriteData_Click);
            // 
            // ClearData
            // 
            this.ClearData.BackColor = System.Drawing.Color.Fuchsia;
            this.ClearData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearData.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearData.ForeColor = System.Drawing.Color.DarkRed;
            this.ClearData.Location = new System.Drawing.Point(70, 527);
            this.ClearData.Name = "ClearData";
            this.ClearData.Size = new System.Drawing.Size(153, 38);
            this.ClearData.TabIndex = 23;
            this.ClearData.Text = "Стереть данные";
            this.ClearData.UseVisualStyleBackColor = false;
            this.ClearData.Click += new System.EventHandler(this.ClearData_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(70, 374);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(474, 123);
            this.OutputBox.TabIndex = 24;
            this.OutputBox.Text = "";
            // 
            // Serialize
            // 
            this.Serialize.BackColor = System.Drawing.Color.Fuchsia;
            this.Serialize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Serialize.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serialize.ForeColor = System.Drawing.Color.DarkRed;
            this.Serialize.Location = new System.Drawing.Point(70, 583);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(153, 38);
            this.Serialize.TabIndex = 25;
            this.Serialize.Text = "Записать в файл";
            this.Serialize.UseVisualStyleBackColor = false;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // Deserialize
            // 
            this.Deserialize.BackColor = System.Drawing.Color.Fuchsia;
            this.Deserialize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Deserialize.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deserialize.ForeColor = System.Drawing.Color.DarkRed;
            this.Deserialize.Location = new System.Drawing.Point(391, 583);
            this.Deserialize.Name = "Deserialize";
            this.Deserialize.Size = new System.Drawing.Size(153, 38);
            this.Deserialize.TabIndex = 26;
            this.Deserialize.Text = "Выгрузить из файла";
            this.Deserialize.UseVisualStyleBackColor = false;
            this.Deserialize.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label11.Location = new System.Drawing.Point(259, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "Квартира";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(620, 640);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Deserialize);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.ClearData);
            this.Controls.Add(this.WriteData);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.MaterialType);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.Meters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Квартирник";
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rooms)).EndInit();
            this.Adress.ResumeLayout(false);
            this.Adress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.CheckBox Balcony;
        private System.Windows.Forms.CheckBox Basement;
        private System.Windows.Forms.CheckBox WC;
        private System.Windows.Forms.CheckBox Bath;
        private System.Windows.Forms.CheckBox Kitchen;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Meters;
        private System.Windows.Forms.TrackBar Rooms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Floor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox MaterialType;
        private System.Windows.Forms.GroupBox Adress;
        private System.Windows.Forms.Label Flat;
        private System.Windows.Forms.Label Building;
        private System.Windows.Forms.Label Street;
        private System.Windows.Forms.Label District;
        private System.Windows.Forms.Label Town;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.TextBox FlatT;
        private System.Windows.Forms.TextBox BuildingT;
        private System.Windows.Forms.TextBox StreetT;
        private System.Windows.Forms.TextBox DistrictT;
        private System.Windows.Forms.TextBox TownT;
        private System.Windows.Forms.TextBox CountryT;
        private System.Windows.Forms.Button WriteData;
        private System.Windows.Forms.Button ClearData;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Button Serialize;
        private System.Windows.Forms.Button Deserialize;
        private System.Windows.Forms.Label label11;
    }
}

