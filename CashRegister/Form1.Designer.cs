
namespace CashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.item1Box = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.item1Label = new System.Windows.Forms.Label();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.item2Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.item3Box = new System.Windows.Forms.TextBox();
            this.recieptLabel = new System.Windows.Forms.Label();
            this.recieptButton = new System.Windows.Forms.Button();
            this.changeBox = new System.Windows.Forms.TextBox();
            this.tenderLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // item1Box
            // 
            this.item1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1Box.Location = new System.Drawing.Point(190, 52);
            this.item1Box.Name = "item1Box";
            this.item1Box.Size = new System.Drawing.Size(84, 20);
            this.item1Box.TabIndex = 0;
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(515, 202);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(277, 67);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Enter desired item quantity.";
            // 
            // item1Label
            // 
            this.item1Label.AutoSize = true;
            this.item1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1Label.ForeColor = System.Drawing.Color.White;
            this.item1Label.Location = new System.Drawing.Point(65, 52);
            this.item1Label.Name = "item1Label";
            this.item1Label.Size = new System.Drawing.Size(35, 13);
            this.item1Label.TabIndex = 2;
            this.item1Label.Text = "label1";
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.calculateTotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalButton.ForeColor = System.Drawing.Color.White;
            this.calculateTotalButton.Location = new System.Drawing.Point(64, 179);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(210, 35);
            this.calculateTotalButton.TabIndex = 3;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = false;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // item2Box
            // 
            this.item2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item2Box.Location = new System.Drawing.Point(190, 90);
            this.item2Box.Name = "item2Box";
            this.item2Box.Size = new System.Drawing.Size(84, 20);
            this.item2Box.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // item3Box
            // 
            this.item3Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item3Box.Location = new System.Drawing.Point(190, 132);
            this.item3Box.Name = "item3Box";
            this.item3Box.Size = new System.Drawing.Size(84, 20);
            this.item3Box.TabIndex = 8;
            // 
            // recieptLabel
            // 
            this.recieptLabel.AutoEllipsis = true;
            this.recieptLabel.AutoSize = true;
            this.recieptLabel.BackColor = System.Drawing.Color.White;
            this.recieptLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptLabel.Location = new System.Drawing.Point(330, 40);
            this.recieptLabel.Name = "recieptLabel";
            this.recieptLabel.Size = new System.Drawing.Size(0, 22);
            this.recieptLabel.TabIndex = 9;
            this.recieptLabel.Visible = false;
            // 
            // recieptButton
            // 
            this.recieptButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.recieptButton.Enabled = false;
            this.recieptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptButton.ForeColor = System.Drawing.Color.White;
            this.recieptButton.Location = new System.Drawing.Point(68, 475);
            this.recieptButton.Name = "recieptButton";
            this.recieptButton.Size = new System.Drawing.Size(210, 35);
            this.recieptButton.TabIndex = 10;
            this.recieptButton.Text = "Print Reciept";
            this.recieptButton.UseVisualStyleBackColor = false;
            this.recieptButton.Click += new System.EventHandler(this.recieptButton_Click);
            // 
            // changeBox
            // 
            this.changeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBox.Location = new System.Drawing.Point(190, 316);
            this.changeBox.Name = "changeBox";
            this.changeBox.Size = new System.Drawing.Size(84, 20);
            this.changeBox.TabIndex = 12;
            // 
            // tenderLabel
            // 
            this.tenderLabel.AutoSize = true;
            this.tenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderLabel.ForeColor = System.Drawing.Color.White;
            this.tenderLabel.Location = new System.Drawing.Point(61, 319);
            this.tenderLabel.Name = "tenderLabel";
            this.tenderLabel.Size = new System.Drawing.Size(53, 13);
            this.tenderLabel.TabIndex = 13;
            this.tenderLabel.Text = "Tendered";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(67, 369);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(210, 35);
            this.changeButton.TabIndex = 14;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(64, 436);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(47, 13);
            this.changeLabel.TabIndex = 15;
            this.changeLabel.Text = "Change:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.White;
            this.subtotalLabel.Location = new System.Drawing.Point(64, 240);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(46, 13);
            this.subtotalLabel.TabIndex = 16;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.White;
            this.taxLabel.Location = new System.Drawing.Point(64, 266);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(25, 13);
            this.taxLabel.TabIndex = 18;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.White;
            this.totalLabel.Location = new System.Drawing.Point(66, 291);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 19;
            this.totalLabel.Text = "Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CashRegister.Properties.Resources.Spamton_screenshot_shop;
            this.pictureBox1.Location = new System.Drawing.Point(518, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(817, 599);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderLabel);
            this.Controls.Add(this.changeBox);
            this.Controls.Add(this.recieptButton);
            this.Controls.Add(this.recieptLabel);
            this.Controls.Add(this.item3Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.item2Box);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.item1Label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.item1Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox item1Box;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label item1Label;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.TextBox item2Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox item3Box;
        private System.Windows.Forms.Label recieptLabel;
        private System.Windows.Forms.Button recieptButton;
        private System.Windows.Forms.TextBox changeBox;
        private System.Windows.Forms.Label tenderLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

