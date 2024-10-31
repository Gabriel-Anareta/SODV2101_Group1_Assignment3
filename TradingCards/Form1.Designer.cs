namespace TradingCards
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
            lb_AllCards = new ListBox();
            SuspendLayout();
            // 
            // lb_AllCards
            // 
            lb_AllCards.FormattingEnabled = true;
            lb_AllCards.Location = new Point(12, 12);
            lb_AllCards.Name = "lb_AllCards";
            lb_AllCards.Size = new Size(175, 224);
            lb_AllCards.TabIndex = 0;
            lb_AllCards.SelectedIndexChanged += lb_AllCards_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(lb_AllCards);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lb_AllCards;
    }
}
