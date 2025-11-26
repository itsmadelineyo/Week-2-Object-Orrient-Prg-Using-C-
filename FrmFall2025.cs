namespace Week2___Dorse_Solution
{
    public partial class FrmFall2025 : Form
    {
        public FrmFall2025() => InitializeComponent();

        private void InitializeComponent()
        {
            lblPrompt = new Label();
            txtInput = new TextBox();
            lblOutput = new Label();
            btnWipe = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrompt.Location = new Point(79, 40);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(243, 36);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter Text Here:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(335, 38);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(818, 44);
            txtInput.TabIndex = 1;
            // 
            // lblOutput
            // 
            lblOutput.Font = new Font("Times New Roman", 32F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(81, 98);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(1072, 340);
            lblOutput.TabIndex = 2;
            lblOutput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnWipe
            // 
            btnWipe.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWipe.Location = new Point(81, 481);
            btnWipe.Name = "btnWipe";
            btnWipe.Size = new Size(199, 45);
            btnWipe.TabIndex = 3;
            btnWipe.Text = "&Wipe Clear";
            btnWipe.UseVisualStyleBackColor = true;
            btnWipe.Click += btnWipe_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.HotPink;
            btnSave.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(361, 481);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(199, 45);
            btnSave.TabIndex = 4;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Gold;
            btnCancel.ForeColor = Color.DarkBlue;
            btnCancel.Location = new Point(652, 481);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(199, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "C&ancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkBlue;
            btnExit.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Gold;
            btnExit.Location = new Point(954, 481);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(199, 45);
            btnExit.TabIndex = 6;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FrmFall2025
            // 
            BackColor = Color.SlateGray;
            ClientSize = new Size(1237, 560);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnWipe);
            Controls.Add(lblOutput);
            Controls.Add(txtInput);
            Controls.Add(lblPrompt);
            Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmFall2025";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private const string V = "";
        private Label lblPrompt;
        private TextBox txtInput;

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }
        public Label lblOutput;
        private Button btnWipe;
        private Button btnSave;
        private Button btnCancel;
        private Button btnExit;

   
        private void btnSave_Click(object sender, EventArgs e) => lblOutput.Text = txtInput.Text;

        
        private void btnWipe_Click(object sender, EventArgs e) => lblOutput.Text = "";


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtInput.Text = V;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
