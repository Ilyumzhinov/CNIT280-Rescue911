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
        private List<Button> SegmentsBtns;
        private int mSelectedSegment = -1;

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

            SegmentsBtns = new List<Button>();
        }


        // FUNCTIONAL METHODS
        public void SetSegments(string Labels)
        {
            lbPreview.Visible = false;

            string[] labelsFetched = Labels.Split('/');

            List<Button> SegmentsBtnsTemp = SegmentsBtns;
            Controls.Clear();
            SegmentsBtnsTemp.Clear();


            for (int i = 0; i < labelsFetched.Length; i++)
            {
                SegmentsBtnsTemp.Add(new Button());
                SegmentsBtnsTemp[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                SegmentsBtnsTemp[i].Font = new System.Drawing.Font("Segoe UI", 8F);
                SegmentsBtnsTemp[i].UseVisualStyleBackColor = false;
                SegmentsBtnsTemp[i].BackColor = System.Drawing.Color.Transparent;
                SegmentsBtnsTemp[i].FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                SegmentsBtnsTemp[i].FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
                SegmentsBtnsTemp[i].FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
                SegmentsBtnsTemp[i].ForeColor = System.Drawing.Color.DodgerBlue;
                SegmentsBtnsTemp[i].Name = "btnSegment" + i;
                SegmentsBtnsTemp[i].Text = labelsFetched[i];
                SegmentsBtnsTemp[i].Size = new System.Drawing.Size(((int)((double)this.Width / labelsFetched.Length) + 1 * i), this.Height);

                if (i == 0)
                    SegmentsBtnsTemp[i].Left = (int)((double)this.Width / labelsFetched.Length) * i;
                else
                    SegmentsBtnsTemp[i].Left = (int)((double)this.Width / labelsFetched.Length) * i - 1 * i;

                SegmentsBtnsTemp[i].Click -= (sender, e) => { };
                SegmentsBtnsTemp[i].Click += (sender, e) => {
                    SegmentBtn_Click?.Invoke(sender, e);
                    SetActiveSegment(((Button)sender).Name);
                };      
            }
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

            Controls.AddRange(SegmentsBtns.ToArray());
        }

        public void SetActiveSegment(string senderName)
        {
            Button sender = new Button();

            for (int j = 0; j < SegmentsBtns.Count; j++)
            {
                if (SegmentsBtns[j].Name == senderName)
                {
                    sender = SegmentsBtns[j];

                    if (mSelectedSegment != -1)
                    {
                        SegmentsBtns[mSelectedSegment].BackColor = System.Drawing.Color.Transparent;
                        SegmentsBtns[mSelectedSegment].FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                        SegmentsBtns[mSelectedSegment].FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
                        SegmentsBtns[mSelectedSegment].FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
                        SegmentsBtns[mSelectedSegment].ForeColor = System.Drawing.Color.DodgerBlue;
                        SegmentsBtns[mSelectedSegment].Enabled = true;
                    }

                    sender.BackColor = System.Drawing.Color.DodgerBlue;
                    sender.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
                    sender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
                    sender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
                    sender.ForeColor = System.Drawing.Color.White;
                    sender.Enabled = false;

                    mSelectedSegment = j;
                    break;
                }
            }
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