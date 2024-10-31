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
        private Label lbl_POS;
        private Label lbl_GP;
        private Label lbl_MIN;
        private Label lbl_PTS;
        private Label lbl_FGM;
        private Label lbl_FGA;
        private Label lbl_FG_Perc;
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
            lbl_POS = CreateLabel(new Point(Location.X + 10, Location.Y + 270), "POS");
            lbl_GP = CreateLabel(new Point(Location.X + 10, Location.Y + 295), "GP");
            lbl_MIN = CreateLabel(new Point(Location.X + 10, Location.Y + 320), "MIN");
            lbl_PTS = CreateLabel(new Point(Location.X + 150, Location.Y + 220), "PTS");
            lbl_FGM = CreateLabel(new Point(Location.X + 150, Location.Y + 245), "FGM");
            lbl_FGA = CreateLabel(new Point(Location.X + 150, Location.Y + 270), "FGA");
            lbl_FG_Perc = CreateLabel(new Point(Location.X + 150, Location.Y + 295), "FG_Perc");

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
            form.Controls.Add(lbl_POS);
            form.Controls.Add(lbl_GP);
            form.Controls.Add(lbl_MIN);
            form.Controls.Add(lbl_PTS);
            form.Controls.Add(lbl_FGM);
            form.Controls.Add(lbl_FGA);
            form.Controls.Add(lbl_FG_Perc);


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
