
using System.Diagnostics;

namespace Week2___Dorse_Solution
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
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
            lblPrompt = new Label();
            txtInput = new TextBox();
            lblOutput = new Label();
            btnWipe = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrompt.ImageAlign = ContentAlignment.MiddleRight;
            lblPrompt.Location = new Point(42, 29);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(232, 36);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter Text Here";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(379, 27);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(649, 44);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += this.txtInput_TextChanged;
            // 
            // lblOutput
            // 
            lblOutput.Font = new Font("Courier New", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(42, 96);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(986, 384);
            lblOutput.TabIndex = 2;
            lblOutput.TextAlign = ContentAlignment.MiddleLeft;
            lblOutput.Click += this.lblOutput_Click;
            // 
            // btnWipe
            // 
            btnWipe.BackColor = SystemColors.Control;
            btnWipe.Location = new Point(42, 562);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(187, 40);
            btnWipe.TabIndex = 3;
            btnWipe.Text = "&Wipe Clear";
            btnWipe.UseVisualStyleBackColor = false;
            btnWipe.Click += this.btnWipe_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Black;
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(582, 562);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(187, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "C&ancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += this.button2_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Yellow;
            btnExit.ForeColor = SystemColors.ControlText;
            btnExit.Location = new Point(841, 562);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(187, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(255, 192, 255);
            btnSave.Location = new Point(309, 562);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(187, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            CancelButton = btnExit;
            ClientSize = new Size(1073, 648);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnWipe);
            Controls.Add(lblOutput);
            Controls.Add(txtInput);
            Controls.Add(lblPrompt);
            Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fall 2025 - Madison (:";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)

        private void button2_Click(object sender, EventArgs e) => throw new NotImplementedException();

        private void btnWipe_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtInput;
        private Label lblOutput;
        private Button btnWipe;
        private Button btnCancel;
        private Button btnExit;
        private Button btnSave;

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
