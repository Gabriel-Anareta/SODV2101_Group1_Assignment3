namespace TradingCards
{
    partial class DeletePlayerView
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
            tb_Name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_Delete = new Button();
            SuspendLayout();
            // 
            // tb_Name
            // 
            tb_Name.Location = new Point(101, 104);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new Size(125, 27);
            tb_Name.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 81);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 35);
            label1.TabIndex = 5;
            label1.Text = "Delete Player";
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(101, 161);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 6;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // DeletePlayerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 221);
            Controls.Add(btn_Delete);
            Controls.Add(label1);
            Controls.Add(tb_Name);
            Controls.Add(label2);
            Name = "DeletePlayerView";
            Text = "DeletePlayerView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Name;
        private Label label2;
        private Label label1;
        private Button btn_Delete;
    }
}