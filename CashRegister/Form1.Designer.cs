
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
            this.calculateBox = new System.Windows.Forms.CheckBox();
            this.changeBox = new System.Windows.Forms.TextBox();
            this.tenderLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // item1Box
            // 
            this.item1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1Box.Location = new System.Drawing.Point(190, 52);
            this.item1Box.Name = "item1Box";
            this.item1Box.Size = new System.Drawing.Size(84, 29);
            this.item1Box.TabIndex = 0;
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(64, 275);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(210, 132);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Enter desired item quantity.";
            // 
            // item1Label
            // 
            this.item1Label.AutoSize = true;
            this.item1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1Label.ForeColor = System.Drawing.Color.White;
            this.item1Label.Location = new System.Drawing.Point(60, 53);
            this.item1Label.Name = "item1Label";
            this.item1Label.Size = new System.Drawing.Size(60, 24);
            this.item1Label.TabIndex = 2;
            this.item1Label.Text = "label1";
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.calculateTotalButton.ForeColor = System.Drawing.Color.White;
            this.calculateTotalButton.Location = new System.Drawing.Point(64, 217);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(210, 35);
            this.calculateTotalButton.TabIndex = 3;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = false;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // item2Box
            // 
            this.item2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item2Box.Location = new System.Drawing.Point(190, 104);
            this.item2Box.Name = "item2Box";
            this.item2Box.Size = new System.Drawing.Size(84, 29);
            this.item2Box.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // item3Box
            // 
            this.item3Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item3Box.Location = new System.Drawing.Point(190, 154);
            this.item3Box.Name = "item3Box";
            this.item3Box.Size = new System.Drawing.Size(84, 29);
            this.item3Box.TabIndex = 8;
            // 
            // recieptLabel
            // 
            this.recieptLabel.AutoSize = true;
            this.recieptLabel.BackColor = System.Drawing.Color.White;
            this.recieptLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.recieptLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptLabel.Location = new System.Drawing.Point(330, 40);
            this.recieptLabel.Name = "recieptLabel";
            this.recieptLabel.Size = new System.Drawing.Size(2, 24);
            this.recieptLabel.TabIndex = 9;
            this.recieptLabel.Visible = false;
            // 
            // recieptButton
            // 
            this.recieptButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.recieptButton.Enabled = false;
            this.recieptButton.ForeColor = System.Drawing.Color.White;
            this.recieptButton.Location = new System.Drawing.Point(68, 581);
            this.recieptButton.Name = "recieptButton";
            this.recieptButton.Size = new System.Drawing.Size(210, 35);
            this.recieptButton.TabIndex = 10;
            this.recieptButton.Text = "Print Reciept";
            this.recieptButton.UseVisualStyleBackColor = false;
            this.recieptButton.Click += new System.EventHandler(this.recieptButton_Click);
            // 
            // calculateBox
            // 
            this.calculateBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.calculateBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.calculateBox.ForeColor = System.Drawing.Color.White;
            this.calculateBox.Location = new System.Drawing.Point(320, 217);
            this.calculateBox.Name = "calculateBox";
            this.calculateBox.Size = new System.Drawing.Size(186, 39);
            this.calculateBox.TabIndex = 11;
            this.calculateBox.Text = "calculate total";
            this.calculateBox.UseVisualStyleBackColor = false;
            // 
            // changeBox
            // 
            this.changeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBox.Location = new System.Drawing.Point(190, 427);
            this.changeBox.Name = "changeBox";
            this.changeBox.Size = new System.Drawing.Size(84, 29);
            this.changeBox.TabIndex = 12;
            // 
            // tenderLabel
            // 
            this.tenderLabel.AutoSize = true;
            this.tenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderLabel.ForeColor = System.Drawing.Color.White;
            this.tenderLabel.Location = new System.Drawing.Point(64, 430);
            this.tenderLabel.Name = "tenderLabel";
            this.tenderLabel.Size = new System.Drawing.Size(94, 24);
            this.tenderLabel.TabIndex = 13;
            this.tenderLabel.Text = "Tendered";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.changeButton.Enabled = false;
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(68, 483);
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
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(64, 537);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(82, 24);
            this.changeLabel.TabIndex = 15;
            this.changeLabel.Text = "Change:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(735, 637);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderLabel);
            this.Controls.Add(this.changeBox);
            this.Controls.Add(this.calculateBox);
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
            this.Name = "Form1";
            this.Text = "Cash Register";
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
        private System.Windows.Forms.CheckBox calculateBox;
        private System.Windows.Forms.TextBox changeBox;
        private System.Windows.Forms.Label tenderLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
    }
}

