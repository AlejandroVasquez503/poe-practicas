namespace practica__3.Encapsulamiento
{
    partial class Encapsulamiento
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
            Label1 = new Label();
            MontoTextBox = new TextBox();
            depositarButton = new Button();
            retirarButton = new Button();
            saldoButton = new Button();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Label1.Location = new Point(313, 36);
            Label1.Name = "Label1";
            Label1.Size = new Size(269, 21);
            Label1.TabIndex = 0;
            Label1.Text = "Ingrese el monto a depositar o retirar";
            // 
            // MontoTextBox
            // 
            MontoTextBox.Location = new Point(312, 101);
            MontoTextBox.Name = "MontoTextBox";
            MontoTextBox.Size = new Size(270, 23);
            MontoTextBox.TabIndex = 1;
            // 
            // depositarButton
            // 
            depositarButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositarButton.Location = new Point(224, 203);
            depositarButton.Name = "depositarButton";
            depositarButton.Size = new Size(92, 35);
            depositarButton.TabIndex = 2;
            depositarButton.Text = "Depositar";
            depositarButton.UseVisualStyleBackColor = true;
            depositarButton.Click += depositarButton_Click;
            // 
            // retirarButton
            // 
            retirarButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            retirarButton.Location = new Point(408, 203);
            retirarButton.Name = "retirarButton";
            retirarButton.Size = new Size(94, 35);
            retirarButton.TabIndex = 3;
            retirarButton.Text = "Retirar";
            retirarButton.UseVisualStyleBackColor = true;
            retirarButton.Click += retirarButton_Click;
            // 
            // saldoButton
            // 
            saldoButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saldoButton.ForeColor = SystemColors.ActiveCaptionText;
            saldoButton.Location = new Point(585, 203);
            saldoButton.Name = "saldoButton";
            saldoButton.Size = new Size(87, 35);
            saldoButton.TabIndex = 4;
            saldoButton.Text = "Saldo";
            saldoButton.UseVisualStyleBackColor = true;
            saldoButton.Click += saldoButton_Click;
            // 
            // Encapsulamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 534);
            Controls.Add(saldoButton);
            Controls.Add(retirarButton);
            Controls.Add(depositarButton);
            Controls.Add(MontoTextBox);
            Controls.Add(Label1);
            Name = "Encapsulamiento";
            Text = "Encapsulamiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label1;
        private TextBox MontoTextBox;
        private Button depositarButton;
        private Button retirarButton;
        private Button saldoButton;
    }
}