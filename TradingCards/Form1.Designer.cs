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
            PlayerCard = new CardControl();
            SuspendLayout();
            // 
            // lb_AllCards
            // 
            lb_AllCards.DisplayMember = "Name";
            lb_AllCards.FormattingEnabled = true;
            lb_AllCards.Location = new Point(12, 12);
            lb_AllCards.Name = "lb_AllCards";
            lb_AllCards.Size = new Size(175, 224);
            lb_AllCards.TabIndex = 0;
            lb_AllCards.ValueMember = "Name";
            lb_AllCards.SelectedIndexChanged += lb_AllCards_SelectedIndexChanged;
            // 
            // PlayerCard
            // 
            PlayerCard.BackColor = Color.Gray;
            PlayerCard.BoundedPlayer = null;
            PlayerCard.Location = new Point(193, 12);
            PlayerCard.Name = "PlayerCard";
            PlayerCard.Size = new Size(339, 448);
            PlayerCard.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 487);
            Controls.Add(PlayerCard);
            Controls.Add(lb_AllCards);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lb_AllCards;
        private CardControl PlayerCard;
    }
}
