namespace ListOfElementNames
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
            this.buttonButton = new System.Windows.Forms.Button();
            this.buttonSmallButton = new System.Windows.Forms.Button();
            this.buttonBigButton = new System.Windows.Forms.Button();
            this.textBoxSortsOfNonsense = new System.Windows.Forms.TextBox();
            this.textBoxMoreNonsense = new System.Windows.Forms.TextBox();
            this.textBoxIDontKnowWhatToCallIt = new System.Windows.Forms.TextBox();
            this.labelSomeInput = new System.Windows.Forms.Label();
            this.labelSomeInputAgain = new System.Windows.Forms.Label();
            this.labelNoException = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonButton
            // 
            this.buttonButton.Location = new System.Drawing.Point(83, 52);
            this.buttonButton.Name = "buttonButton";
            this.buttonButton.Size = new System.Drawing.Size(82, 46);
            this.buttonButton.TabIndex = 0;
            this.buttonButton.Text = "Кнопка";
            this.buttonButton.UseVisualStyleBackColor = true;
            // 
            // buttonSmallButton
            // 
            this.buttonSmallButton.Location = new System.Drawing.Point(83, 211);
            this.buttonSmallButton.Name = "buttonSmallButton";
            this.buttonSmallButton.Size = new System.Drawing.Size(82, 22);
            this.buttonSmallButton.TabIndex = 1;
            this.buttonSmallButton.Text = "Кнопочка";
            this.buttonSmallButton.UseVisualStyleBackColor = true;
            // 
            // buttonBigButton
            // 
            this.buttonBigButton.Location = new System.Drawing.Point(83, 259);
            this.buttonBigButton.Name = "buttonBigButton";
            this.buttonBigButton.Size = new System.Drawing.Size(82, 115);
            this.buttonBigButton.TabIndex = 2;
            this.buttonBigButton.Text = "Кнопище";
            this.buttonBigButton.UseVisualStyleBackColor = true;
            // 
            // textBoxSortsOfNonsense
            // 
            this.textBoxSortsOfNonsense.Location = new System.Drawing.Point(260, 76);
            this.textBoxSortsOfNonsense.Name = "textBoxSortsOfNonsense";
            this.textBoxSortsOfNonsense.Size = new System.Drawing.Size(311, 22);
            this.textBoxSortsOfNonsense.TabIndex = 3;
            // 
            // textBoxMoreNonsense
            // 
            this.textBoxMoreNonsense.Location = new System.Drawing.Point(260, 211);
            this.textBoxMoreNonsense.Name = "textBoxMoreNonsense";
            this.textBoxMoreNonsense.Size = new System.Drawing.Size(311, 22);
            this.textBoxMoreNonsense.TabIndex = 4;
            // 
            // textBoxIDontKnowWhatToCallIt
            // 
            this.textBoxIDontKnowWhatToCallIt.Location = new System.Drawing.Point(260, 352);
            this.textBoxIDontKnowWhatToCallIt.Name = "textBoxIDontKnowWhatToCallIt";
            this.textBoxIDontKnowWhatToCallIt.Size = new System.Drawing.Size(364, 22);
            this.textBoxIDontKnowWhatToCallIt.TabIndex = 5;
            // 
            // labelSomeInput
            // 
            this.labelSomeInput.AutoSize = true;
            this.labelSomeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSomeInput.Location = new System.Drawing.Point(257, 52);
            this.labelSomeInput.Name = "labelSomeInput";
            this.labelSomeInput.Size = new System.Drawing.Size(314, 20);
            this.labelSomeInput.TabIndex = 6;
            this.labelSomeInput.Text = "Сюда можно что-нибудь ввести:";
            // 
            // labelSomeInputAgain
            // 
            this.labelSomeInputAgain.AutoSize = true;
            this.labelSomeInputAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSomeInputAgain.Location = new System.Drawing.Point(257, 188);
            this.labelSomeInputAgain.Name = "labelSomeInputAgain";
            this.labelSomeInputAgain.Size = new System.Drawing.Size(301, 20);
            this.labelSomeInputAgain.TabIndex = 7;
            this.labelSomeInputAgain.Text = "Сюда ввод тоже не запрещён: ";
            // 
            // labelNoException
            // 
            this.labelNoException.AutoSize = true;
            this.labelNoException.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoException.Location = new System.Drawing.Point(257, 329);
            this.labelNoException.Name = "labelNoException";
            this.labelNoException.Size = new System.Drawing.Size(367, 20);
            this.labelNoException.TabIndex = 8;
            this.labelNoException.Text = "И это поле не является исключением:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.labelNoException);
            this.Controls.Add(this.labelSomeInputAgain);
            this.Controls.Add(this.labelSomeInput);
            this.Controls.Add(this.textBoxIDontKnowWhatToCallIt);
            this.Controls.Add(this.textBoxMoreNonsense);
            this.Controls.Add(this.textBoxSortsOfNonsense);
            this.Controls.Add(this.buttonBigButton);
            this.Controls.Add(this.buttonSmallButton);
            this.Controls.Add(this.buttonButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonButton;
        private System.Windows.Forms.Button buttonSmallButton;
        private System.Windows.Forms.Button buttonBigButton;
        private System.Windows.Forms.TextBox textBoxSortsOfNonsense;
        private System.Windows.Forms.TextBox textBoxMoreNonsense;
        private System.Windows.Forms.TextBox textBoxIDontKnowWhatToCallIt;
        private System.Windows.Forms.Label labelSomeInput;
        private System.Windows.Forms.Label labelSomeInputAgain;
        private System.Windows.Forms.Label labelNoException;
    }
}

