namespace WindowsFormsClient;

partial class NumberForm
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
        txtNumber = new MaskedTextBox();
        btnCalculate = new Button();
        label1 = new Label();
        label2 = new Label();
        lstDivisors = new Label();
        lstPrimeDivisors = new Label();
        SuspendLayout();
        // 
        // txtNumber
        // 
        txtNumber.Location = new Point(12, 12);
        txtNumber.Name = "txtNumber";
        txtNumber.Size = new Size(70, 23);
        txtNumber.TabIndex = 0;
        // 
        // btnCalculate
        // 
        btnCalculate.Location = new Point(88, 12);
        btnCalculate.Name = "btnCalculate";
        btnCalculate.Size = new Size(75, 23);
        btnCalculate.TabIndex = 1;
        btnCalculate.Text = "Decompor";
        btnCalculate.UseVisualStyleBackColor = true;
        btnCalculate.Click += BtnCalculate_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 49);
        label1.Name = "label1";
        label1.Size = new Size(54, 15);
        label1.TabIndex = 2;
        label1.Text = "Divisores";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(138, 49);
        label2.Name = "label2";
        label2.Size = new Size(94, 15);
        label2.TabIndex = 5;
        label2.Text = "Divisores Primos";
        // 
        // lstDivisors
        // 
        lstDivisors.AutoSize = true;
        lstDivisors.Location = new Point(12, 73);
        lstDivisors.Name = "lstDivisors";
        lstDivisors.Size = new Size(0, 15);
        lstDivisors.TabIndex = 6;
        // 
        // lstPrimeDivisors
        // 
        lstPrimeDivisors.AutoSize = true;
        lstPrimeDivisors.Location = new Point(138, 73);
        lstPrimeDivisors.Name = "lstPrimeDivisors";
        lstPrimeDivisors.Size = new Size(0, 15);
        lstPrimeDivisors.TabIndex = 7;
        // 
        // NumberForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(270, 319);
        Controls.Add(lstPrimeDivisors);
        Controls.Add(lstDivisors);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btnCalculate);
        Controls.Add(txtNumber);
        Name = "NumberForm";
        Text = "Decomposição Numérica";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MaskedTextBox txtNumber;
    private Button btnCalculate;
    private Label label1;
    private Label label2;
    private Label lstDivisors;
    private Label lstPrimeDivisors;
}
