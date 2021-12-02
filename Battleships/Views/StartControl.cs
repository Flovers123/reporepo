using System;
using System.Windows.Forms;
using Battleships.Domain;

namespace Battleships.Views
{
    public partial class StartControl : UserControl
    {
        private Game game;

        public StartControl()
        {
            InitializeComponent();
        }

        public void Configure(Game game)
        {
            if (this.game != null)
                return;

            this.game = game;

            startButton.Click += StartButton_Click;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            game.Start("Human", "AI");
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            My.aa = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
