
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
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(191, 323);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(111, 24);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Output label";
            // 
            // item1Label
            // 
            this.item1Label.AutoSize = true;
            this.item1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item1Label.Location = new System.Drawing.Point(60, 53);
            this.item1Label.Name = "item1Label";
            this.item1Label.Size = new System.Drawing.Size(60, 24);
            this.item1Label.TabIndex = 2;
            this.item1Label.Text = "label1";
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Location = new System.Drawing.Point(63, 170);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(210, 35);
            this.calculateTotalButton.TabIndex = 3;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 400);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.item1Label);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.item1Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox item1Box;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label item1Label;
        private System.Windows.Forms.Button calculateTotalButton;
    }
}

