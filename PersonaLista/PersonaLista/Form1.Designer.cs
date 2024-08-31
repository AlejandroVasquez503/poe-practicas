namespace PersonaLista
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
            label1 = new Label();
            personasListBox = new ListBox();
            agregarButton = new Button();
            nombreTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(565, 36);
            label1.Name = "label1";
            label1.Size = new Size(159, 28);
            label1.TabIndex = 0;
            label1.Text = "Lista de nombres";
            // 
            // personasListBox
            // 
            personasListBox.FormattingEnabled = true;
            personasListBox.Location = new Point(481, 144);
            personasListBox.Name = "personasListBox";
            personasListBox.Size = new Size(333, 404);
            personasListBox.TabIndex = 1;
            personasListBox.SelectedIndexChanged += personasListBox_SelectedIndexChanged;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(585, 590);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(125, 48);
            agregarButton.TabIndex = 2;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(501, 99);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(288, 27);
            nombreTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 742);
            Controls.Add(nombreTextBox);
            Controls.Add(agregarButton);
            Controls.Add(personasListBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox personasListBox;
        private Button agregarButton;
        private TextBox nombreTextBox;
    }
}
