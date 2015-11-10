using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form,View
    {
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }
        private void lblScore_Click(object sender, EventArgs e)
        {
            
        }
        private void Score_Click(object sender, EventArgs e)
        {

        }
        private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {

        }
        public void cr_score(int num)
        {
            
        }
        public void Notify(Model m)
        {
            int x = (((TwoZeroFourEightModel)m).SummationScore());
            lblScore1.Text = Convert.ToString(x);
        }
    }
}
