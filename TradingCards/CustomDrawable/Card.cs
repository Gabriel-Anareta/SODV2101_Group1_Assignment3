using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCards.PlayerInfo;

namespace TradingCards.CustomDrawable
{
    public class Card
    {
        private const int Width = 300;
        private const int Height = 400;

        private Player BoundedPlayer;
        private Point Location;
        private Label lbl_Name;
        private Label lbl_Team;
        private PictureBox pb_Player;

        private bool drawn;

        public Card(Point position, Player player) 
        { 
            BoundedPlayer = player;
            Location = position;
            drawn = false;
            
            // Set statistics controls
            lbl_Name = CreateLabel(new Point(Location.X + 10, Location.Y + 220), "Name");
            lbl_Team = CreateLabel(new Point(Location.X + 10, Location.Y + 245), "Team");

            // Set image controls
            pb_Player = new PictureBox();
            //pb_Player.Image = CurrentPlayer.GetImage();
            //pb_Player.Location = new Point(226, 32);
        }

        public void Draw(Form form)
        {
            // Display controls to form
            if (drawn)
                return;

            form.Controls.Add(lbl_Name);
            form.Controls.Add(lbl_Team);
            
            form.Paint += DrawBorder;
            drawn = true;
        }

        private void DrawBorder(object sender, PaintEventArgs e)
        {
            Rectangle card = new Rectangle(Location.X, Location.Y, Width, Height);
            e.Graphics.DrawRectangle(Pens.Black, card);
            e.Graphics.FillRectangle(Brushes.White, card);
        }

        private Label CreateLabel(Point location, string boundedProperty)
        {
            Label label = new Label();

            // Setting label info
            label.DataBindings.Add("Text", BoundedPlayer, boundedProperty, true, DataSourceUpdateMode.OnPropertyChanged);
            label.Location = location;
            label.BackColor = Color.Transparent;

            return label;
        }
    }
}
