namespace FootballMatches
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelForMatches = new System.Windows.Forms.Label();
            this.labelForResults = new System.Windows.Forms.Label();
            this.lambda = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAction = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lambda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelForMatches);
            this.panel1.Controls.Add(this.labelForResults);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 484);
            this.panel1.TabIndex = 0;
            // 
            // labelForMatches
            // 
            this.labelForMatches.Location = new System.Drawing.Point(3, 2);
            this.labelForMatches.Name = "labelForMatches";
            this.labelForMatches.Size = new System.Drawing.Size(246, 465);
            this.labelForMatches.TabIndex = 1;
            // 
            // labelForResults
            // 
            this.labelForResults.Location = new System.Drawing.Point(250, 2);
            this.labelForResults.Name = "labelForResults";
            this.labelForResults.Size = new System.Drawing.Size(232, 272);
            this.labelForResults.TabIndex = 0;
            // 
            // lambda
            // 
            this.lambda.Location = new System.Drawing.Point(594, 13);
            this.lambda.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.lambda.Name = "lambda";
            this.lambda.Size = new System.Drawing.Size(120, 22);
            this.lambda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лямбда";
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(507, 56);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(207, 126);
            this.buttonAction.TabIndex = 3;
            this.buttonAction.Text = "Сыграем в футбол?";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 508);
            this.Controls.Add(this.buttonAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lambda);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lambda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelForMatches;
        private System.Windows.Forms.Label labelForResults;
        private System.Windows.Forms.NumericUpDown lambda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAction;
    }
}

