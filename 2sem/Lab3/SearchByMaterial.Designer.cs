
namespace Lab2
{
    partial class SearchByMaterial
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
            this.MaterialSearch = new System.Windows.Forms.TextBox();
            this.OutputBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearMaterial = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MaterialSearch
            // 
            this.MaterialSearch.Location = new System.Drawing.Point(188, 111);
            this.MaterialSearch.Name = "MaterialSearch";
            this.MaterialSearch.Size = new System.Drawing.Size(149, 20);
            this.MaterialSearch.TabIndex = 0;
            // 
            // OutputBox2
            // 
            this.OutputBox2.Location = new System.Drawing.Point(22, 211);
            this.OutputBox2.Name = "OutputBox2";
            this.OutputBox2.ReadOnly = true;
            this.OutputBox2.Size = new System.Drawing.Size(474, 123);
            this.OutputBox2.TabIndex = 25;
            this.OutputBox2.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(188, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "Искать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(175, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Искать по материалу";
            // 
            // ClearMaterial
            // 
            this.ClearMaterial.BackColor = System.Drawing.Color.Fuchsia;
            this.ClearMaterial.ForeColor = System.Drawing.Color.DarkRed;
            this.ClearMaterial.Location = new System.Drawing.Point(270, 149);
            this.ClearMaterial.Name = "ClearMaterial";
            this.ClearMaterial.Size = new System.Drawing.Size(67, 30);
            this.ClearMaterial.TabIndex = 28;
            this.ClearMaterial.Text = "Очистить";
            this.ClearMaterial.UseVisualStyleBackColor = false;
            this.ClearMaterial.Click += new System.EventHandler(this.ClearMaterial_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(37, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(396, 51);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(100, 58);
            this.richTextBox2.TabIndex = 30;
            this.richTextBox2.Text = "";
            // 
            // SearchByMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(517, 346);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ClearMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputBox2);
            this.Controls.Add(this.MaterialSearch);
            this.Name = "SearchByMaterial";
            this.Text = "SearchByMaterial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaterialSearch;
        private System.Windows.Forms.RichTextBox OutputBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearMaterial;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}