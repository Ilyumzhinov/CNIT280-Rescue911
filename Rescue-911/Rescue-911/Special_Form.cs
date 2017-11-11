using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rescue_911
{
    // A form used by most of the forms in the program.
    // Has a special constructor which receives Shared Data and sets the Title of the Form automatically.
    public partial class Special_Form : Form
    {
        protected Shared_Data SD;

        // Reference: https://stackoverflow.com/questions/1216940/net-inherited-winforms-form-vs-designer-issue.
        public Special_Form(ref Shared_Data xSD, string xTitle) : this()
        {
            SD = xSD;

            this.Text = xTitle + " Form";
            this.lbTitle.Text = xTitle;
            this.lbTitle.Dock = DockStyle.Top;
            this.lbTitle.Visible = true;
        }

        public Special_Form()
        {
            InitializeComponent();

            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Franklin Gothic Heavy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(5, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(333, 37);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title";
        }
    }
}
