using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka {
    public class TemplatedForm : Form {

        protected void DrawDividers(Control panel, Graphics g) {
            Pen pen = new Pen(Color.Gray, 1);

            var x1 = new Point(panel.Location.X, panel.Location.Y - 1);
            var x2 = new Point(panel.Location.X + panel.Width, panel.Location.Y - 1);
            var x3 = new Point(panel.Location.X, panel.Location.Y + panel.Height);
            var x4 = new Point(panel.Location.X + panel.Width, panel.Location.Y + panel.Height);
            g.DrawLine(pen, x1, x2);
            g.DrawLine(pen, x3, x4);

            g.Dispose();
        }

        protected void CreateControlsFromTemplate(Control template, Control panel, string name, Control[] controls, int numControls) {
            var offset = template.Location.Y + template.Height;
            for (int i = 0; i < numControls; i++) {
                var controlGroup = new GroupBox {
                    Width = template.Width,
                    Height = template.Height,
                    Location = new Point(template.Location.X, offset * i + template.Location.Y),
                    Name = name + i,
                    Text = name + " " + i
                };
                foreach (Control control in template.Controls) {
                    Control newControl = null;
                    if (control is Label) {
                        newControl = new Label {
                            Text = control.Text,
                            Width = control.Width,
                            Height = control.Height,
                            Location = control.Location,
                            Font = control.Font,
                            Name = control.Name
                        };
                        controlGroup.Controls.Add(newControl);
                    }
                    else if (control is Button) {
                        newControl = new Button {
                            Text = control.Text,
                            Width = control.Width,
                            Height = control.Height,
                            Location = control.Location,
                            Name = control.Name
                        };
                    }
                    else if (control is PictureBox) {
                        newControl = new PictureBox {
                            Text = control.Text,
                            Width = control.Width,
                            Height = control.Height,
                            Location = control.Location,
                            Name = control.Name
                        };
                    }
                    if (newControl != null) {
                        controlGroup.Controls.Add(newControl);
                    }
                }
                controlGroup.Hide();
                controls[i] = controlGroup;
                panel.Controls.Add(controlGroup);
            }
            panel.Controls.Remove(template);
            template.Dispose();
        }
    }
}
