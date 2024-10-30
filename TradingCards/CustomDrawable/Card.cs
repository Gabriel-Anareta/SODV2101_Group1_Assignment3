using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCards.CustomDrawable
{
    public class Card
    {
        private const int Width = 300;
        private const int Height = 400;
        
        public Point Location { get; set; }
        public Label lbl_Name { get; set; }
        public Label lbl_Team { get; set; }
        public PictureBox pb_Player { get; set; }

        public Card(Point position) 
        { 
            Location = position;
            lbl_Name = new Label();
            lbl_Team = new Label();
            pb_Player = new PictureBox();
        }

        public void Draw(Form form)
        {
            //pb_Player.Image = CurrentPlayer.GetImage();
            //pb_Player.Location = new Point(226, 32);

            lbl_Name.Text = "Name";
            lbl_Name.Location = new Point(Location.X + 20, Location.Y + 220);
            lbl_Name.BackColor = Color.Transparent;
            lbl_Team.Text = "Team";
            lbl_Team.Location = new Point(Location.X + 20, Location.Y + 250);
            lbl_Team.BackColor = Color.Transparent;

            form.Controls.Add(lbl_Name);
            form.Controls.Add(lbl_Team);

            form.Paint += new PaintEventHandler(this.DrawBorder);
        }

        private void DrawBorder(object sender, PaintEventArgs e)
        {
            Rectangle card = new Rectangle(Location.X, Location.Y, 300, 400);

            e.Graphics.DrawRectangle(Pens.Black, card);
            e.Graphics.FillRectangle(Brushes.White, card);
        }
    }
}
