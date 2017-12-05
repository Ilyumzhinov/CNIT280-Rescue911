using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Project
{
    public partial class Segmented_Control : UserControl
    {
        // DATA STRUCTURE
        //Composite Data
        private List<Button> SegmentsBtns = new List<Button>();
        private Button mSelectedButton;

        //Public Data
        private string segmentsValue = string.Empty;
        [Description("Set available segments. Use / to separate segements"), Category("Data")]
        public string Segments
        {
            get
            {
                return segmentsValue;
            }
            set
            {
                segmentsValue = value;
                SetSegments(segmentsValue);
            }
        }

        //Events
        public event EventHandler SegmentBtn_Click;
        //


        // CONSTRUCTOR
        public Segmented_Control()
        {
            InitializeComponent();
        }


        // FUNCTIONAL METHODS
        public void SetSegments(string Labels)
        {
            lbPreview.Visible = false;

            string[] labelsFetched = Labels.Split('/');

            SegmentsBtns.Clear();
            Controls.Clear();

            for (int i = 0; i < labelsFetched.Length; i++)
            {
                SegmentsBtns.Add(new Button());
                SegmentsBtns[i].Cursor = System.Windows.Forms.Cursors.Hand;
                SegmentsBtns[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                SegmentsBtns[i].Font = new System.Drawing.Font("Segoe UI", 8F);
                SegmentsBtns[i].TabIndex = i;
                SegmentsBtns[i].UseVisualStyleBackColor = false;
                SegmentsBtns[i].BackColor = System.Drawing.Color.White;
                SegmentsBtns[i].FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                SegmentsBtns[i].FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
                SegmentsBtns[i].FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
                SegmentsBtns[i].ForeColor = System.Drawing.Color.DodgerBlue;
                SegmentsBtns[i].Name = "btnSegment" + i;
                SegmentsBtns[i].Text = labelsFetched[i];
                SegmentsBtns[i].Size = new System.Drawing.Size((this.Width / labelsFetched.Length + 1 * i), this.Height);

                if (i == 0)
                    SegmentsBtns[i].Left = (this.Width / labelsFetched.Length) * i;
                else
                    SegmentsBtns[i].Left = (this.Width / labelsFetched.Length) * i - 1 * i;

                SegmentsBtns[i].Click -= (sender, e) => { };
                SegmentsBtns[i].Click += (sender, e) => {
                    SegmentBtn_Click?.Invoke(sender, e);
                    SetActiveSegment((Button)sender);
                };
                
            }

            Controls.AddRange(SegmentsBtns.ToArray());
        }

        public void SetAvailableSegments(string segmentsString)
        {
            if (segmentsString == string.Empty)
                return;

            string[] segmentsStringFetched = segmentsString.Split('/');

            SetSegments(segmentsValue);

            if (segmentsStringFetched.Length > SegmentsBtns.Count || segmentsStringFetched.Length < SegmentsBtns.Count)
                return;


            for (int i = 0; i < SegmentsBtns.Count; i++)
            {
                if (segmentsStringFetched[i] == "t")
                {
                    continue;
                }
                else if (segmentsStringFetched[i] == "f")
                {
                    SegmentsBtns[i] = null;
                }
                else
                {
                    SegmentsBtns[i] = null;
                }
            }

            while (SegmentsBtns.Contains(null) == true)
            {
                SegmentsBtns.Remove(null);
            }
        }

        public void SetActiveSegment(Button sender)
        {
            if (mSelectedButton != null)
            {
                mSelectedButton.BackColor = System.Drawing.Color.White;
                mSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                mSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
                mSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
                mSelectedButton.ForeColor = System.Drawing.Color.DodgerBlue;
                mSelectedButton.Enabled = true;
            }

            sender.BackColor = System.Drawing.Color.DodgerBlue;
            sender.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            sender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            sender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            sender.ForeColor = System.Drawing.Color.White;
            sender.Enabled = false;

            mSelectedButton = sender;
        }

        // EVENTS HANDLERS
        private void Segmented_Control_SizeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SegmentsBtns.Count; i++)
            {
                SegmentsBtns[i].Size = new System.Drawing.Size((this.Width / SegmentsBtns.Count + 1 * i), this.Height);
            }
        }
        //
    }
}