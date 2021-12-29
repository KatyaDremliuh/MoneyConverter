
namespace MoneyConverterApp
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
            this.moneyAmount = new System.Windows.Forms.Label();
            this.txtBInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtBOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // moneyAmount
            // 
            this.moneyAmount.AutoSize = true;
            this.moneyAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyAmount.Location = new System.Drawing.Point(12, 27);
            this.moneyAmount.Name = "moneyAmount";
            this.moneyAmount.Size = new System.Drawing.Size(181, 25);
            this.moneyAmount.TabIndex = 0;
            this.moneyAmount.Text = "Количество денег";
            // 
            // txtBInput
            // 
            this.txtBInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBInput.Location = new System.Drawing.Point(15, 69);
            this.txtBInput.Name = "txtBInput";
            this.txtBInput.Size = new System.Drawing.Size(181, 30);
            this.txtBInput.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(253, 68);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(196, 50);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtBOutput
            // 
            this.txtBOutput.Location = new System.Drawing.Point(17, 165);
            this.txtBOutput.Multiline = true;
            this.txtBOutput.Name = "txtBOutput";
            this.txtBOutput.ReadOnly = true;
            this.txtBOutput.Size = new System.Drawing.Size(755, 257);
            this.txtBOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtBInput);
            this.Controls.Add(this.moneyAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Конвертер валют";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moneyAmount;
        private System.Windows.Forms.TextBox txtBInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtBOutput;
    }
}

